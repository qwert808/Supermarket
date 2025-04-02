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
    public partial class RateSetup : Form
    {
        public RateSetup()
        {
            InitializeComponent();
            Rate();
        }

        public void Rate()
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;

            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT ID,Name,CostPrice, SellingPrice FROM Products";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int rowCounter = 0;

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        RateGridView.Rows.Add(
                            rowCounter,
                            reader["Name"].ToString(),
                            reader["Id"].ToString(),
                            reader["CostPrice"].ToString(),
                            reader["SellingPrice"].ToString()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;

            try
            {
                connection.Open();
                SqlCommand updateCommand = new SqlCommand();
                updateCommand.Connection = connection;
                updateCommand.CommandType = CommandType.Text;
                foreach (DataGridViewRow row in RateGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string? productId = Convert.ToString(row.Cells["ProductId"].Value);
                        // decimal? sellingPrice = Convert.ToDecimal(row.Cells["SellingPrice"].Value);
                        string? sellingPriceStr = Convert.ToString(row.Cells["SellingPrice"].Value);
                       
                        if (decimal.TryParse(sellingPriceStr, out decimal sellingPrice))
                        {
                            updateCommand.CommandText = @"UPDATE Products 
                                                     SET SellingPrice = @SellingPrice 
                                                     WHERE ID = @ProductId";
                            updateCommand.Parameters.Clear();
                            updateCommand.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                            updateCommand.Parameters.AddWithValue("@ProductId", productId);

                        }

                        updateCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Selling prices updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

