using System.Data.SqlClient;

namespace DemoStoreClassLibrary
{
    public class AddProductUtilityClass : IAddProductUtilityClass
    {
        //runs the SQL query and returns a response
        public int AddProductUtility(string sql, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, connection);
            int response = adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();

            return response;
        }
    }
}
