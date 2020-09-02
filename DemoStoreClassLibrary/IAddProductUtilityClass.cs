using System.Data.SqlClient;

namespace DemoStoreClassLibrary
{
    public interface IAddProductUtilityClass
    {
        int AddProductUtility(string sql, SqlConnection connection);
    }
}
