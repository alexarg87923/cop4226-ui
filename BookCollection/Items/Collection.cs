using System;
using System.Collections.Generic;
using System.Data;
using BookCollection.Items;
using Microsoft.Data.SqlClient; 

namespace BookCollectionDB
{
    public class Collection
    {
        // Properties matching the Collections table columns
        public int CollectionId { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Connection string 
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCollectionDB;Integrated Security=True;";


        // Add a new collection (calls the AddCollection stored procedure)
        public void Add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddCollection", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Owner", this.Owner);
                cmd.Parameters.AddWithValue("@Name", this.Name);
                cmd.Parameters.AddWithValue("@Description", (object)this.Description ?? DBNull.Value);

                conn.Open();
                this.CollectionId = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Update an existing collection (calls the UpdateCollection stored procedure)
        public void Update()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateCollection", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CollectionID", this.CollectionId);
                cmd.Parameters.AddWithValue("@Owner", this.Owner);
                cmd.Parameters.AddWithValue("@Name", this.Name);
                cmd.Parameters.AddWithValue("@Description", (object)this.Description ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete a collection (calls the DeleteCollection stored procedure)
        public void Delete()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteCollection", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CollectionID", this.CollectionId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // List books in collection (calls the ListBooksInCollection stored procedure)
        public List<Book> ListBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ListBooksInCollection", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CollectionID", this.CollectionId);

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

        // Change collection owner name (calls the ChangeCollectionOwnerName stored procedure)
        public static void ChangeOwnerName(string oldOwnerName, string newOwnerName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ChangeCollectionOwnerName", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OldOwnerName", oldOwnerName);
                cmd.Parameters.AddWithValue("@NewOwnerName", newOwnerName);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
