using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace BookCollection.Items
{
    public class Book
    {
        // Properties matching the Books table columns
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int Sales { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Summary { get; set; }

        // Connection string
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCollectionDB;Integrated Security=True;";


        // Add a new book (calls the AddBook stored procedure)
        public void Add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@PublicationDate", (object)PublicationDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Sales", Sales);
                cmd.Parameters.AddWithValue("@ISBN", (object)ISBN ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Genre", (object)Genre ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Summary", (object)Summary ?? DBNull.Value);

                conn.Open();
                BookId = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Update an existing book (calls the UpdateBook stored procedure)
        public void Update()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookID", BookId);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@PublicationDate", (object)PublicationDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Sales", Sales);
                cmd.Parameters.AddWithValue("@ISBN", (object)ISBN ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Genre", (object)Genre ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Summary", (object)Summary ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete a book (calls the DeleteBook stored procedure)
        public void Delete()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookID", BookId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get a book by ISBN (calls the GetBookByISBN stored procedure)
        public static Book GetByISBN(string isbn)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetBookByISBN", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ISBN", isbn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Book book = new Book
                    {
                        BookId = Convert.ToInt32(reader["book_id"]),
                        Title = reader["title"].ToString(),
                        PublicationDate = reader["publication_date"] as DateTime?,
                        Sales = reader["sales"] != DBNull.Value ? Convert.ToInt32(reader["sales"]) : 0,
                        ISBN = reader["isbn"].ToString(),
                        Genre = reader["genre"].ToString(),
                        Summary = reader["summary"].ToString()
                    };
                    return book;
                }
                else
                {
                    return null;
                }
            }
        }

        // Search books (calls the SearchBooks stored procedure)
        public static List<Book> Search(string title = null, string genre = null, string authorName = null)
        {
            List<Book> books = new List<Book>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchBooks", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", (object)title ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Genre", (object)genre ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AuthorName", (object)authorName ?? DBNull.Value);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book
                    {
                        BookId = Convert.ToInt32(reader["book_id"]),
                        Title = reader["title"].ToString(),
                        PublicationDate = reader["publication_date"] as DateTime?,
                        Sales = reader["sales"] != DBNull.Value ? Convert.ToInt32(reader["sales"]) : 0,
                        ISBN = reader["isbn"].ToString(),
                        Genre = reader["genre"].ToString(),
                        Summary = reader["summary"].ToString()
                    };
                    books.Add(book);
                }
            }

            return books;
        }
    }
}
