using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoseliMart
{
    public partial class LineItemsSales : Form
    {
        private List<ProductLookUp> GetProductsFromDatabase()
        {
            List<ProductLookUp> productList = new List<ProductLookUp>();
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Id, [Name] FROM Products";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductLookUp lineItemsAdd = new ProductLookUp
                    {

                        Id = Guid.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString()

                    };

                    productList.Add(lineItemsAdd);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return productList;
        }

        private string SalesId;

        public LineItemsSales(string salesId)
        {
            InitializeComponent();
            this.SalesId = salesId;
            GetProductList();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void GetProductList()
        {
            List<ProductLookUp> productList = GetProductsFromDatabase();
            comboBox1.DataSource = productList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private string priceString;
        private decimal quantityDecimal;
        private string selectedProductId;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is ProductLookUp selectedProduct)
            {
                selectedProductId = selectedProduct.Id.ToString();

                using SqlConnection connection = new SqlConnection();
                connection.ConnectionString = DbConnector.ConnectionString;
                

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    command.CommandText = "SELECT SellingPrice,Quantity FROM Products WHERE Id = @ProductId";

                    command.Parameters.AddWithValue("@ProductId", selectedProductId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        object price = reader["SellingPrice"];
                        object quantity = reader["Quantity"];

                        quantityDecimal = Convert.ToDecimal(quantity);
                        if (quantityDecimal == 0)
                        {
                            MessageBox.Show("OUT OF STOCK", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBoxPrice.Text = "Not Available";
                            txtBoxQuantity.Text = "Not Available";
                        }
                        else
                        {
                            priceString = Convert.ToString(price);
                            txtBoxPrice.Text = priceString;
                            txtBoxQuantity.Clear();

                        }


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            decimal quantitytext;

            if (Decimal.TryParse(txtBoxQuantity.Text, out quantitytext))
            {
                if (quantityDecimal < quantitytext)
                {
                    MessageBox.Show("AVAILABLE STOCK: " + quantityDecimal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxQuantity.Clear();
                }
            }
            decimal iPrice, iQuantity;
            string quantity = txtBoxQuantity.Text;
            decimal.TryParse(priceString, out iPrice);
            decimal.TryParse(quantity, out iQuantity);

            decimal iTotal = iQuantity * iPrice;
            txtBoxTotal.Text = iTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"INSERT INTO LineItemsSales (ID,Product_Id, Sales_Id ,[Name], Price, Quantity, Total) 
                                        VALUES (@Id,@productId,@SalesId, @Name, @Price, @Quantity, @Total)";

                command.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                command.Parameters.AddWithValue("@productId", selectedProductId);
                command.Parameters.AddWithValue("@SalesId", SalesId);
                command.Parameters.AddWithValue("@Name", comboBox1.Text);
                command.Parameters.AddWithValue("@Price", txtBoxPrice.Text);
                command.Parameters.AddWithValue("@Quantity", txtBoxQuantity.Text);
                command.Parameters.AddWithValue("@Total", txtBoxTotal.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                txtBoxPrice.Clear();
                txtBoxQuantity.Clear();
                txtBoxTotal.Clear();
                MessageBox.Show("Record added successfully.", "Record added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Sales lineItems = Application.OpenForms.OfType<Sales>().FirstOrDefault();
                lineItems.GetLineItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
