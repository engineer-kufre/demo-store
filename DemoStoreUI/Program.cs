using DemoStoreClassLibrary;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoStoreUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SqlConnection connection = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; Database = DemoStore; Integrated Security = true");
            connection.Open();

            //create the connection between the UI and the library
            DISocket.PlugSocket();
            IAddProductUtilityClass utility = DISocket.Isocket;
            Application.Run(new MainForm(connection, utility));

            connection.Close();
        }
    }
}
