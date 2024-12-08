using System.Text.RegularExpressions;
using BookCollection.Items;
using BookCollectionDB;
using Microsoft.Data.SqlClient;

namespace BookCollection
{
    public partial class BookManagement : Form
    {
        private static string masterConnectionString = "Server=(localDB)\\MSSQLLocalDB;Database=master;Trusted_Connection=True;";
        private static string databaseName = "BookCollectionDB";
        private static string booksTableName = "Books";
        private static string databaseConnectionString = $"Server=(localDB)\\MSSQLLocalDB;Database={databaseName};Trusted_Connection=True;";

        public BookManagement()
        {
            InitializeComponent();

            button1.Click += SaveBook_Click;
            button2.Click += DeleteBook_Click;


            button3.Click += SaveAuthor_Click;
            button4.Click += DeleteAuthor_Click;


            button6.Click += SaveCollection_Click;
            button5.Click += DeleteCollection_Click;

            InitializeDatabase();
        }


        private static void InitializeDatabase()
        {
            if (!DatabaseExists())
            {
                var result = MessageBox.Show("I see you don't have the databases initalized, do you want me to initialize them for you?", "Database Initalizer", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string sqlFilePath = Path.Combine(Application.StartupPath, "Book_Collection_Schema.sql");

                        if (!File.Exists(sqlFilePath))
                        {
                            MessageBox.Show($"SQL script file not found at {sqlFilePath}");
                            return;
                        }

                        string script = File.ReadAllText(sqlFilePath);

                        IEnumerable<string> commands = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                        using (SqlConnection connection = new SqlConnection(masterConnectionString))
                        {
                            connection.Open();

                            foreach (string command in commands)
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
            else
            {
                if (!DataExistsInDatabase())
                {
                    var result = MessageBox.Show("I see your databases don't have test data initalized, do you want me to fill in the databases for you?", "Database Initalizer", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
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

                            using (SqlConnection connection = new SqlConnection(masterConnectionString))
                            {
                                connection.Open();

                                using (SqlCommand sqlCommand = new SqlCommand(script, connection))
                                {
                                    sqlCommand.ExecuteNonQuery();
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

        private static bool DataExistsInDatabase()
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

        private static bool DatabaseExists()
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

                book.Add();
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
            textBox3.Text = "";
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
                    BirthDate = DateTime.TryParse(textBox11.Text, out DateTime birthDate) ? birthDate : null,
                    Biography = textBox7.Text
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
            textBox7.Text = "";
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
                string sqlFilePath = Path.Combine(Application.StartupPath, "ResetDB.sql");

                if (!File.Exists(sqlFilePath))
                {
                    MessageBox.Show($"SQL script file not found at {sqlFilePath}");
                    return;
                }

                string script = File.ReadAllText(sqlFilePath);

                using (SqlConnection connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(script, connection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Database reset successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the database: {ex.Message}");
            }
        }
    }
}
