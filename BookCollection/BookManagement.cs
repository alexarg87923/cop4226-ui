using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BookCollection.Items;
using BookCollectionDB;
using Microsoft.Data.SqlClient;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookCollection
{
    public partial class BookManagement : Form
    {
        private string masterConnectionString = "Server=(localDB)\\MSSQLLocalDB;Database=master;Trusted_Connection=True;";
        private string databaseName = "BookCollectionDB";
        private string booksTableName = "Books";
        public string databaseConnectionString { get => $"Server=(localDB)\\MSSQLLocalDB;Database={databaseName};Trusted_Connection=True;"; set => databaseConnectionString = value; }

        List<Book> books = new List<Book>();
        int current_book_index = 0;
        List<Author> authorList = new List<Author>();
        int current_author_index = 0;
        List<Collection> collectionList = new List<Collection>();
        int current_collection_index = 0;
        List<CollectionBook> collectionBooksList = new List<CollectionBook>();
        List<BookAuthor> collectionBookAuthors = new List<BookAuthor>();

        public BookManagement()
        {
            InitializeComponent();

            button1.Click += SaveBook_Click;
            button2.Click += DeleteBook_Click;

            button3.Click += SaveAuthor_Click;
            button4.Click += DeleteAuthor_Click;

            button6.Click += SaveCollection_Click;
            button5.Click += DeleteCollection_Click;

            button18.Click += CollectionPrev;
            button19.Click += CollectionNext;
            button17.Click += NewCollection;

            InitializeDatabase();
            InitializeData();
            LoadBookComponents();
            LoadAuthorComponents();
        }

        private void LoadBookComponents()
        {
            textBox1.Text = books[current_book_index].BookId.ToString();
            textBox2.Text = books[current_book_index].Title;
            textBox4.Text = books[current_book_index].ISBN;
            textBox5.Text = books[current_book_index].Genre;
            textBox6.Text = books[current_book_index].PublicationDate.ToString();
            
            Authors.DataSource = collectionBookAuthors.Where(each => each.BookId == books[current_book_index].BookId).Join(authorList, bookAuthor => bookAuthor.AuthorId, author => author.AuthorId, (bookAuthor, author) => author).ToList();
            Authors.DisplayMember = "Name";
            Authors.SelectionMode = SelectionMode.MultiExtended;
        }

        private void LoadAuthorComponents()
        {
            textBox9.Text = authorList[current_author_index].AuthorId.ToString();
            textBox10.Text = authorList[current_author_index].Name.ToString();
            textBox11.Text = authorList[current_author_index].BirthDate.ToString();

            listBox1.DataSource = collectionBookAuthors.Where(each => each.AuthorId == authorList[current_author_index].AuthorId).Join(books, bookColl => bookColl.BookId, bookitem => bookitem.BookId, (bookColl, bookitem) => bookitem).ToList();
            listBox1.DisplayMember = "Title";
            Authors.SelectionMode = SelectionMode.None;
        }

        private void UpdateAuthorListInBooksComponent(List<int> author_ids)
        {
            Authors.DataSource = author_ids.Join(authorList, authorId => authorId, author => author.AuthorId, (bookAuthor, author) => author).ToList();
        }

        private void InitializeData()
        {
            books.Clear();
            authorList.Clear();
            collectionList.Clear();
            collectionBooksList.Clear();
            collectionBookAuthors.Clear();

            string book_query = $"SELECT * FROM Books";
            string author_query = $"SELECT * FROM Authors";
            string collections_query = $"SELECT * FROM Collections";
            string collection_books_query = $"SELECT * FROM CollectionBooks";
            string book_authors_query = $"SELECT * FROM BookAuthors";

            using (SqlConnection connection = new SqlConnection(databaseConnectionString))
            {
                SqlCommand books_command = new SqlCommand(book_query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = books_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book tmpBook = new Book();
                            tmpBook.BookId = reader.GetInt32(0);
                            tmpBook.Title = reader.GetString(1);
                            tmpBook.PublicationDate = reader.GetDateTime(2);
                            tmpBook.Sales = reader.GetInt32(3);
                            tmpBook.ISBN = reader.GetString(4);
                            tmpBook.Genre = reader.GetString(5);
                            tmpBook.Summary = reader.GetString(6);
                            books.Add(tmpBook);
                        }
                    }

                    SqlCommand author_command = new SqlCommand(author_query, connection);
                    using (SqlDataReader reader = author_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Author tmpAuthor = new Author();
                            tmpAuthor.AuthorId = reader.GetInt32(0);
                            tmpAuthor.Name = reader.GetString(1);
                            tmpAuthor.BirthDate = reader.GetDateTime(2);
                            tmpAuthor.Biography = reader.GetString(3);
                            authorList.Add(tmpAuthor);
                        }
                    }


                    SqlCommand collections_command = new SqlCommand(collections_query, connection);
                    using (SqlDataReader reader = collections_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Collection tmpCollection = new Collection();
                            tmpCollection.CollectionId = reader.GetInt32(0);
                            tmpCollection.Owner = reader.GetString(1);
                            tmpCollection.Name = reader.GetString(2);
                            tmpCollection.Description = reader.GetString(3);
                            collectionList.Add(tmpCollection);
                        }
                    }

                    SqlCommand collection_books_command = new SqlCommand(collection_books_query, connection);
                    using (SqlDataReader reader = collection_books_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CollectionBook tmpCollectionBook = new CollectionBook();
                            tmpCollectionBook.CollectionId = reader.GetInt32(0);
                            tmpCollectionBook.BookId = reader.GetInt32(1);
                            collectionBooksList.Add(tmpCollectionBook);
                        }
                    }

                    SqlCommand book_authors_command = new SqlCommand(book_authors_query, connection);
                    using (SqlDataReader reader = book_authors_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookAuthor tmpBookAuthor = new BookAuthor();
                            tmpBookAuthor.AuthorId = reader.GetInt32(0);
                            tmpBookAuthor.BookId = reader.GetInt32(1);
                            collectionBookAuthors.Add(tmpBookAuthor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        void reset_data()
        {
            try
            {
                string sqlFilePath = Path.Combine(Application.StartupPath, "Initial_Test_Values.sql");

                if (!File.Exists(sqlFilePath))
                {
                    MessageBox.Show($"SQL script file not found at {sqlFilePath}");
                    return;
                }

                string script = File.ReadAllText(sqlFilePath);

                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(script, connection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data filled in properly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the database: {ex.Message}");
            }
        }

        private void InitializeDatabase()
        {
            EnsureDatabaseAttached();

            if (!DataExistsInDatabase())
            {
                var result = MessageBox.Show("I see your databases don't have test data initalized, do you want me to fill in the databases for you?", "Database Initalizer", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    reset_data();
                }
            }
        }

        private void EnsureDatabaseAttached()
        {
            bool dbExists = DatabaseExists();
            if (!dbExists)
            {
                string userProfileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string dataFilePath = Path.Combine(userProfileFolder, $"{databaseName}.mdf");
                string logFilePath = Path.Combine(userProfileFolder, $"{databaseName}_log.ldf");

                if (System.IO.File.Exists(dataFilePath))
                {
                    // Attempt to attach the database.
                    string attachQuery = $@"
                                            CREATE DATABASE [{databaseName}]
                                            ON (FILENAME = N'{dataFilePath}'),
                                                (FILENAME = N'{logFilePath}')
                                            FOR ATTACH;
                                        ";

                    using (SqlConnection connection = new SqlConnection(masterConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(attachQuery, connection))
                        {
                            try
                            {
                                connection.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show($"Successfully attached the database '{databaseName}'.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(
                                    $"Failed to attach the database. " +
                                    $"Please delete any .mdf and .ldf files inside of your user's directory and restart the program.\nError: {ex.Message}"
                                );
                            }
                        }
                    }
                }
                else
                {
                    var result = MessageBox.Show("I see you don't have the databases initalized, do you want me to initialize them for you?", "Database Initalizer", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string schemaSqlFilePath = Path.Combine(Application.StartupPath, "Book_Collection_Schema.sql");
                            string spSqlFilePath = Path.Combine(Application.StartupPath, "StoredProcedures.sql");

                            if (!File.Exists(schemaSqlFilePath))
                            {
                                MessageBox.Show($"SQL script file not found at {schemaSqlFilePath}");
                                return;
                            }

                            string schemaScript = File.ReadAllText(schemaSqlFilePath);

                            if (!File.Exists(spSqlFilePath))
                            {
                                MessageBox.Show($"SQL script file not found at {spSqlFilePath}");
                                return;
                            }

                            string spScript = File.ReadAllText(spSqlFilePath);

                            IEnumerable<string> schemaCommands = Regex.Split(schemaScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                            IEnumerable<string> spCommands = Regex.Split(spScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                            using (SqlConnection connection = new SqlConnection(masterConnectionString))
                            {
                                connection.Open();

                                foreach (string command in schemaCommands)
                                {
                                    if (string.IsNullOrWhiteSpace(command))
                                        continue;

                                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                                    {
                                        sqlCommand.ExecuteNonQuery();
                                    }
                                }

                                foreach (string command in spCommands)
                                {
                                    if (string.IsNullOrWhiteSpace(command))
                                        continue;

                                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                                    {
                                        sqlCommand.ExecuteNonQuery();
                                    }
                                }
                            }

                            MessageBox.Show("Database and tables created successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while initializing the database: {ex.Message}");
                        }
                    }
                }
            }
        }


        private bool DataExistsInDatabase()
        {
            string query = $"SELECT TOP 1 * FROM {booksTableName}";

            using (SqlConnection connection = new SqlConnection(databaseConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using SqlDataReader reader = command.ExecuteReader();
                    return reader.HasRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking database existence: {ex.Message}");
                    return false;
                }
            }
        }

        private bool DatabaseExists()
        {
            string query = "SELECT database_id FROM sys.databases WHERE Name = @databaseName";

            using (SqlConnection connection = new SqlConnection(masterConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@databaseName", databaseName);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        return (result != null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error checking database existence: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private void SaveBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Title and ISBN).");
                    return;
                }

                Book book = new Book
                {
                    Title = textBox2.Text,
                    ISBN = textBox4.Text,
                    Genre = textBox5.Text
                };

                books.Add(book);
                LoadBookComponents();
                MessageBox.Show("Book saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving book: " + ex.Message);
            }
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            try
            {

                if (int.TryParse(textBox1.Text, out int bookId))
                {

                    Book book = new Book { BookId = bookId };
                    book.Delete();


                    ClearBookForm();
                    MessageBox.Show("Book deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Book ID to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book: " + ex.Message);
            }
        }


        private void ClearBookForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void SaveAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox10.Text))
                {
                    MessageBox.Show("Please fill in the required field (Name).");
                    return;
                }
                Author author = new Author
                {
                    AuthorId = string.IsNullOrWhiteSpace(textBox9.Text) ? 0 : int.Parse(textBox9.Text),
                    Name = textBox10.Text,
                    BirthDate = DateTime.TryParse(textBox11.Text, out DateTime birthDate) ? birthDate : null
                    //Biography = textBox7.Text
                };


                if (author.AuthorId == 0)
                {
                    author.Add();
                    MessageBox.Show("Author added successfully!");
                }
                else
                {
                    author.Update();
                    MessageBox.Show("Author updated successfully!");
                }

                ClearAuthorForm();
                LoadAuthorComponents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving author: " + ex.Message);
            }
        }


        private void ClearAuthorForm()
        {
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            //textBox7.Text = "";
        }

        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {

                if (int.TryParse(textBox9.Text, out int authorId))
                {

                    Author author = new Author { AuthorId = authorId };
                    author.Delete();


                    ClearAuthorForm();
                    MessageBox.Show("Author deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Author ID to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting author: " + ex.Message);
            }
        }

        private void SaveCollection_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox13.Text) || string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name and Owner).");
                    return;
                }
                Collection collection = new Collection
                {
                    CollectionId = string.IsNullOrWhiteSpace(textBox14.Text) ? 0 : int.Parse(textBox14.Text),
                    Name = textBox13.Text,
                    Owner = textBox12.Text,
                    Description = textBox8.Text
                };


                if (collection.CollectionId == 0)
                {
                    collection.Add();
                    MessageBox.Show("Collection added successfully!");
                }
                else
                {
                    collection.Update();
                    MessageBox.Show("Collection updated successfully!");
                }

                ClearCollectionForm();
                PopulateCollectionsOverview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving collection: " + ex.Message);
            }
        }

        private void ClearCollectionForm()
        {
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox8.Text = "";
        }

        private void DeleteCollection_Click(object sender, EventArgs e)
        {
            try
            {

                if (int.TryParse(textBox14.Text, out int collectionId))
                {

                    Collection collection = new Collection { CollectionId = collectionId };
                    collection.Delete();


                    ClearCollectionForm();
                    MessageBox.Show("Collection deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Collection ID to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting collection: " + ex.Message);
            }
        }
        private void PopulateCollectionsOverview()
        {
            try
            {

                tabPage4.Controls.Clear();


                List<Collection> collections = FetchCollectionsFromDatabase();


                int verticalOffset = 10;

                foreach (Collection collection in collections)
                {
                    // Group box for each collection
                    GroupBox groupBox = new GroupBox
                    {
                        Text = collection.Name,
                        Width = tabPage4.Width - 40,
                        Height = 250,
                        Top = verticalOffset,
                        Left = 10
                    };


                    DataGridView dataGridView = new DataGridView
                    {
                        Width = groupBox.Width - 20,
                        Height = 150,
                        Top = 30,
                        Left = 10,
                        AutoGenerateColumns = false,
                        DataSource = collection.ListBooks()
                    };

                    // Add columns to the DataGridView
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title", Width = 200 });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Author", DataPropertyName = "Author", Width = 150 });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ISBN", DataPropertyName = "ISBN", Width = 150 });


                    Button addBookButton = new Button
                    {
                        Text = "Add Book",
                        Top = dataGridView.Bottom + 10,
                        Left = 10
                    };
                    addBookButton.Click += (s, e) => AddBookToCollection_Click(s, e, collection.CollectionId);


                    Button removeBookButton = new Button
                    {
                        Text = "Remove Book",
                        Top = dataGridView.Bottom + 10,
                        Left = 120
                    };
                    removeBookButton.Click += (s, e) => RemoveBookFromCollection_Click(s, e, collection.CollectionId);


                    groupBox.Controls.Add(dataGridView);
                    groupBox.Controls.Add(addBookButton);
                    groupBox.Controls.Add(removeBookButton);


                    tabPage4.Controls.Add(groupBox);


                    verticalOffset += groupBox.Height + 20;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating collections: " + ex.Message);
            }
        }


        private void AddBookToCollection_Click(object sender, EventArgs e, int collectionId)
        {
            try
            {

                string bookIdInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the Book ID to add to the collection:", "Add Book");
                if (int.TryParse(bookIdInput, out int bookId))
                {
                    CollectionBook collectionBook = new CollectionBook
                    {
                        CollectionId = collectionId,
                        BookId = bookId
                    };
                    collectionBook.Add();
                    MessageBox.Show("Book added to collection successfully!");


                    PopulateCollectionsOverview();
                }
                else
                {
                    MessageBox.Show("Invalid Book ID. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book to collection: " + ex.Message);
            }
        }


        private void RemoveBookFromCollection_Click(object sender, EventArgs e, int collectionId)
        {
            try
            {
                // Prompt user for the Book ID to remove
                string bookIdInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the Book ID to remove from the collection:", "Remove Book");
                if (int.TryParse(bookIdInput, out int bookId))
                {
                    CollectionBook collectionBook = new CollectionBook
                    {
                        CollectionId = collectionId,
                        BookId = bookId
                    };
                    collectionBook.Remove();
                    MessageBox.Show("Book removed from collection successfully!");


                    PopulateCollectionsOverview();
                }
                else
                {
                    MessageBox.Show("Invalid Book ID. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing book from collection: " + ex.Message);
            }
        }


        private List<Collection> FetchCollectionsFromDatabase()
        {
            List<Collection> collections = new List<Collection>();

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCollectionDB;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("SELECT collection_id, name, owner, description FROM Collections", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    collections.Add(new Collection
                    {
                        CollectionId = Convert.ToInt32(reader["collection_id"]),
                        Name = reader["name"].ToString(),
                        Owner = reader["owner"].ToString(),
                        Description = reader["description"].ToString()
                    });
                }
            }

            return collections;
        }

        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM BookAuthors; DELETE FROM CollectionBooks; DELETE FROM Collections ;DBCC CHECKIDENT ('Collections', RESEED, 0); " +
                    "DELETE FROM Books; DBCC CHECKIDENT ('Books', RESEED, 0); DELETE FROM Authors; DBCC CHECKIDENT ('Authors', RESEED, 0);";


                using (SqlConnection connection = new SqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                reset_data();

                MessageBox.Show("Database reset successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while resetting the database: {ex.Message}");
            }
        }

        private void AuthorPrev(object sender, EventArgs e)
        {
            if (current_author_index == 0)
            {
                current_author_index = authorList.Count - 1;
            }
            else
            {
                current_author_index--;
            }
            LoadAuthorComponents();
        }

        private void AuthorNext(object sender, EventArgs e)
        {
            if (current_author_index == authorList.Count - 1)
            {
                current_author_index = 0;
            }
            else
            {
                current_author_index++;
            }
            LoadAuthorComponents();
        }

        private void BookPrev(object sender, EventArgs e)
        {
            if (current_book_index == 0)
            {
                current_book_index = books.Count - 1;
            }
            else
            {
                current_book_index--;
            }
            LoadBookComponents();
        }

        private void BookNext(object sender, EventArgs e)
        {
            if (current_book_index == books.Count - 1)
            {
                current_book_index = 0;
            }
            else
            {
                current_book_index++;
            }
            LoadBookComponents();
        }

        private void NewBook(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void NewAuthor(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }


        private void SelectAuthors(object sender, EventArgs e)
        {
            using (var selectAuthorsForm = new SelectAuthorsDialog(authorList))
            {
                var result = selectAuthorsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<int> selectedAuthorIds = selectAuthorsForm.SelectedAuthorIds;
                    UpdateAuthorListInBooksComponent(selectedAuthorIds);
                }
            }
        }

        private void LoadCollectionComponents()
        {
            textBox14.Text = collectionList[current_collection_index].CollectionId.ToString();
            textBox13.Text = collectionList[current_collection_index].Name;
            textBox12.Text = collectionList[current_collection_index].Owner;
            textBox8.Text = collectionList[current_collection_index].Description;
        }

        private void CollectionPrev(object sender, EventArgs e)
        {
            if (current_collection_index == 0)
            {
                current_collection_index = collectionList.Count - 1;
            }
            else
            {
                current_collection_index--;
            }
            LoadCollectionComponents();
        }

        private void CollectionNext(object sender, EventArgs e)
        {
            if (current_collection_index == collectionList.Count - 1)
            {
                current_collection_index = 0;
            }
            else
            {
                current_collection_index++;
            }
            LoadCollectionComponents();
        }

        private void NewCollection(object sender, EventArgs e)
        {
            textBox14.Text = "";  
            textBox13.Text = "";  
            textBox12.Text = "";  
            textBox8.Text = "";   
        }
    }

}
