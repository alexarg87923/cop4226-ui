using Microsoft.Data.SqlClient;

namespace BookCollectionDB
{
    public class CollectionBook
    {
        // Properties matching the CollectionBooks table columns
        public int CollectionId { get; set; }
        public int BookId { get; set; }

        // Connection string
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCollectionDB;Integrated Security=True;";

        // Add a book to a collection (calls the AddBookToCollection stored procedure)
        public void Add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddBookToCollection", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CollectionID", this.CollectionId);
                cmd.Parameters.AddWithValue("@BookID", this.BookId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Remove a book from a collection (calls the RemoveBookFromCollection stored procedure)
        public void Remove()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RemoveBookFromCollection", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CollectionID", this.CollectionId);
                cmd.Parameters.AddWithValue("@BookID", this.BookId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
