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
using KoseliMart;

namespace KoseliMart
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
            GetProducts();
        }

        public void GetProducts()
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            ProductListView.Rows.Clear();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Products";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int rowCounter = 0;

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        ProductListView.Rows.Add(
                            rowCounter,
                            reader["Id"].ToString(),
                            reader["Name"].ToString(),
                            reader["SellingPrice"].ToString(),
                            reader["CostPrice"].ToString(),
                            reader["Code"].ToString()
                        );
                    }
                }


                reader.Close();
                connection.Close();
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void ProductListView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string? pName = ProductListView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            string? pCode = ProductListView.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            string? columnName = ProductListView.Columns[e.ColumnIndex].Name;
            string? productId = ProductListView.Rows[e.RowIndex].Cells["ID"].Value?.ToString();

            //Guid _productId = Guid.Empty;

            //if (!string.IsNullOrEmpty(productId))
            //{
            //    Guid.Parse(productId);
            //}


            if (columnName == "Edit")
            {

                UpdateForm updateForm = new UpdateForm(productId, pName, pCode);
                updateForm.Show();

            }

            if (columnName == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = DbConnector.ConnectionString;
                    try
                    {
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = @"DELETE FROM Products
                                                WHERE ID = @Id";

                        command.Parameters.AddWithValue("@Id", productId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully.", "Data deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Data Not Deleted", "Request Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
