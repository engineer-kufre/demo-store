using DemoStoreClassLibrary;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoStoreUI
{
    //index form
    public partial class MainForm : Form
    {
        SqlConnection Connection;
        private readonly IAddProductUtilityClass Utility;
        public MainForm(SqlConnection connection, IAddProductUtilityClass utility)
        {
            Connection = connection;
            Utility = utility;
            InitializeComponent();
        }

        //click event for addproduct button
        private void mainFormAddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(Connection, Utility);
            addProduct.Show();
        }

        //click event for makeorder button
        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            MakeOrder makeOrder = new MakeOrder(Connection);
            makeOrder.Show();
        }
    }
}
