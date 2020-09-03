using DemoStoreClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoStoreUI
{
    //form for making orders
    public partial class MakeOrder : Form
    {
        SqlConnection Connection;
        List<Product> allOrders = new List<Product>();
        BindingList<string> allProducts = new BindingList<string>();

        decimal sum = 0;
        string input1 = "";
        string input2 = "";
        string input3 = "";
        int displayStart = 0;

        //form constructor
        public MakeOrder(SqlConnection connection)
        {
            Connection = connection;
            InitializeComponent();


            SqlDataAdapter command = new SqlDataAdapter("SELECT ProductId, ProductName, CostPrice FROM Product ORDER BY DateAdded OFFSET " + displayStart + " ROWS FETCH NEXT 5 ROWS ONLY", Connection);

            FillGridView(command);

            orderListBox.DataSource = allOrders;
            orderListBox.DisplayMember = "ProductName";

            priceFilterTextBox.Text = "0";
            totalPriceTextBox.Text = "0.00";
        }

        //method to undo filter on click
        private void undoFilterButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter command = new SqlDataAdapter("SELECT ProductId, ProductName, CostPrice FROM Product ORDER BY DateAdded OFFSET " + displayStart + " ROWS FETCH NEXT 5 ROWS ONLY", Connection);
            FillGridView(command);
        }

        //scroller event
        private void priceFilterTrackBar_Scroll(object sender, EventArgs e)
        {
            priceFilterTextBox.Text = priceFilterTrackBar.Value.ToString();
        }

        //filter by product name or price click event
        private void PriceFilterButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter command;
            if (pNameFilterTextBox.Text != "")
            {
                command = new SqlDataAdapter("SELECT ProductId, ProductName, CostPrice FROM Product WHERE ProductName = '" + pNameFilterTextBox.Text + "'", Connection);
            }
            else
            {
                int limit = int.Parse(priceFilterTextBox.Text);
                command = new SqlDataAdapter("SELECT ProductId, ProductName, CostPrice FROM Product WHERE CostPrice < " + limit, Connection);
            }
            
            FillGridView(command);

            if (pNameFilterTextBox.Text != "")
            {
                pNameFilterTextBox.Text = "";
            }
        }

        //click event to add to cart
        private void addtoCartButton_Click(object sender, EventArgs e)
        {
            if (input1 != "" && input2 != "" && input3 != "")
            {
                Product product = new Product();
                product.ProductName = input1;
                product.CostPrice = decimal.Parse(input2);
                product.ProductId = int.Parse(input3);
                allOrders.Add(product);
                allProducts.Add(input1);
                orderListBox.DataSource = allProducts;
                orderListBox.DisplayMember = "ProductName";

                sum += product.CostPrice;

                totalPriceTextBox.Text = sum.ToString();
            }
        }

        //cell click event for product selection
        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (productGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    productGridView.CurrentRow.Selected = true;
                    input1 = productGridView.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
                    input2 = productGridView.Rows[e.RowIndex].Cells["CostPrice"].FormattedValue.ToString();
                    input3 = productGridView.Rows[e.RowIndex].Cells["ProductId"].FormattedValue.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Click an appropriate cell!");
            }
            
        }

        //click event to clear cart
        private void clearCartButton_Click(object sender, EventArgs e)
        {
            allProducts.Clear();
            allOrders.Clear();
            totalPriceTextBox.Text = "0.00";
            sum = 0;
        }

        //cart item delete click event
        private void cartDeleteButton_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            for (int i = 0; i < allOrders.Count; i++)
            {
                if (allOrders[i].ProductName == (string)orderListBox.SelectedValue)
                {
                    price = allOrders[i].CostPrice;
                    allOrders.RemoveAt(i);
                    allProducts.RemoveAt(i);
                    sum -= price;
                    totalPriceTextBox.Text = sum.ToString();
                    i--;
                    break;
                }
            }
        }

        //click event for finishOrder button
        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            int response = 0;
            for (int i = 0; i < allOrders.Count; i++)
            {
                if (allProducts.IndexOf(allProducts[i]) < i)
                {
                    continue;
                }
                else
                {
                    int Quantity = 0;
                    //determine quantity for each product in order list and insert order into cart
                    for (int j = 0; j < allProducts.Count; j++)
                    {
                        if (allProducts[j] == allProducts[i])
                        {
                            Quantity++;
                        }
                    }
                    string sql = "INSERT INTO Cart (ProductId, Quantity) VALUES ('" + allOrders[i].ProductId + "', " + Quantity + ")";
                    SqlCommand command = new SqlCommand(sql, Connection);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(sql, Connection);
                    response = adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                }
            }

            //if order was added successfully
            if (response > 0)
            {
                MessageBox.Show("Order Added!");
            }
            clearCartButton.PerformClick();
        }

        //pagination previous button click event
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (displayStart > 0)
            {
                DataTable dt = new DataTable();
                displayStart -= 5;
                SqlDataAdapter command = new SqlDataAdapter("SELECT ProductId, ProductName, CostPrice FROM Product ORDER BY DateAdded OFFSET " + displayStart + " ROWS FETCH NEXT 5 ROWS ONLY", Connection);
                command.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    productGridView.DataSource = dt;
                }
            }
            else
            {
                return;
            }
        }

        //pagination next button click event
        private void nextButton_Click(object sender, EventArgs e)
        {
            List<Product> productsList = new List<Product>();
            SqlCommand comm = new SqlCommand($"SELECT * FROM Product", Connection);
            var reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = reader.GetInt32(0);
                product.ProductName = reader.GetString(1);
                product.CostPrice = reader.GetDecimal(2);
                product.DateAdded = reader.GetDateTime(3);
                productsList.Add(product);
            }
            reader.Close();

            int numberOfProducts = productsList.Count;

            if (displayStart + 5 < numberOfProducts)
            {
                DataTable dt = new DataTable();
                displayStart += 5;
                SqlDataAdapter command = new SqlDataAdapter("SELECT ProductId, ProductName, CostPrice FROM Product ORDER BY DateAdded OFFSET " + displayStart + " ROWS FETCH NEXT 5 ROWS ONLY", Connection);
                command.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    productGridView.DataSource = dt;
                }
            }
            else
            {
                return;
            }
        }

        //helper method to create product grid view
        private void FillGridView(SqlDataAdapter command)
        {
            //product data table is populated when created
            DataTable dt = new DataTable();
            command.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                productGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Query not found");
            }
        }
    }
}
