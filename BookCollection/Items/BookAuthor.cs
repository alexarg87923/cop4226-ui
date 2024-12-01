using Microsoft.Data.SqlClient; 

namespace BookCollectionDB
{
    public class BookAuthor
    {
        // Properties matching the BookAuthors table columns
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        // Connection string 
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCollectionDB;Integrated Security=True;";


        // Link a book and an author (calls the LinkBookAuthor stored procedure)
        public void Link()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("LinkBookAuthor", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookID", this.BookId);
                cmd.Parameters.AddWithValue("@AuthorID", this.AuthorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Unlink a book and an author (calls the UnlinkBookAuthor stored procedure)
        public void Unlink()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UnlinkBookAuthor", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookID", this.BookId);
                cmd.Parameters.AddWithValue("@AuthorID", this.AuthorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
