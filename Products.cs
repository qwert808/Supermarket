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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"INSERT INTO [Products](Id, [Name], Code, SellingPrice, CostPrice, Quantity) 
                                        VALUES (@Id, @Name,  @Code, @SP, @CP, @Q)";

                command.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                command.Parameters.AddWithValue("@Name", ProductName.Text);
                command.Parameters.AddWithValue("@Code", ProductCode.Text);
                command.Parameters.AddWithValue("@SP", 0); 
                command.Parameters.AddWithValue("@CP", 0);
                command.Parameters.AddWithValue("@Q", 0);

                connection.Open();
                command.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Record added successfully.", "Record added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductList productListForm = Application.OpenForms.OfType<ProductList>().FirstOrDefault();
                productListForm?.GetProducts();
                ProductName.Clear();
                ProductCode.Clear();    
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

        private void ProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
