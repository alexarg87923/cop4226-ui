using System;
using System.Data;
using Microsoft.Data.SqlClient;  

namespace BookCollection.Items
{
    public class Author
    {
        // Properties matching the Authors table columns
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Biography { get; set; }

        // Connection string 
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCollectionDB;Integrated Security=True;";

        // Add a new author (calls the AddAuthor stored procedure)
        public void Add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddAuthor", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@BirthDate", (object)BirthDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Biography", (object)Biography ?? DBNull.Value);

                conn.Open();
                AuthorId = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Update an existing author (calls the UpdateAuthor stored procedure)
        public void Update()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateAuthor", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AuthorID", AuthorId);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@BirthDate", (object)BirthDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Biography", (object)Biography ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete an author (calls the DeleteAuthor stored procedure)
        public void Delete()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteAuthor", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AuthorID", AuthorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
