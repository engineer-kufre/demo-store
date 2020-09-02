using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DemoStoreClassLibrary;

namespace DemoStoreUI
{
    //form for adding, modifying and deleting products
    public partial class AddProduct : Form
    {
        //sql connection receiver
        SqlConnection Connection;

        IAddProductUtilityClass Utility;

        //form constructor
        public AddProduct(SqlConnection connection, IAddProductUtilityClass utility)
        {
            Connection = connection;
            Utility = utility;
            InitializeComponent();
        }

        //save button click event
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            if (AddProductNameTextBox.Text.Trim().Length < 1) { return; }

            string sql = "INSERT INTO Product (ProductName, CostPrice) VALUES ('" + AddProductNameTextBox.Text.Trim() + "', " + decimal.Parse(ProductPriceTextBox.Text) + ")";

            int response = Utility.AddProductUtility(sql, Connection);

            //product added successfully
            if (response > 0)
            {
                MessageBox.Show("Product Added!");
            }

            ResetTextBoxes();
        }

        //edit button click event
        private void addProductEditButton_Click(object sender, EventArgs e)
        {
            if (AddProductNameTextBox.Text.Trim().Length < 1) { return; }

            string sql = "UPDATE Product SET CostPrice = " + decimal.Parse(ProductPriceTextBox.Text) + " WHERE ProductName =  '" + AddProductNameTextBox.Text.Trim() + "'";

            int response = Utility.AddProductUtility(sql, Connection);

            //product price edited successfully
            if (response > 0)
            {
                MessageBox.Show("Product Updated!");
            }
            //product price edit failed
            else if (response == 0)
            {
                MessageBox.Show("Product not found!");
            }

            ResetTextBoxes();
        }

        //delete button click event
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            //first delete product from cart table then from product table
            string sql = "DELETE Cart WHERE ProductId =  " + AddProductNameTextBox.Text.Trim();
            int response = Utility.AddProductUtility(sql, Connection);

            sql = "DELETE Product WHERE ProductId =  '" + AddProductNameTextBox.Text.Trim() + "'";
            response = Utility.AddProductUtility(sql, Connection);

            //product price deleted successfully
            if (response > 0)
            {
                MessageBox.Show("Product Deleted!");
            }
            //product delete failed
            else if (response == 0)
            {
                MessageBox.Show("Product not found!");
            }

            ResetTextBoxes();
        }

        //resets all form textboxes
        private void ResetTextBoxes()
        {
            //reset textboxes
            ProductPriceTextBox.Text = "";
            AddProductNameTextBox.Text = "";
        }
    }
}