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
    public partial class SalesList : Form
    {
        public SalesList()
        {
            InitializeComponent();
        }

        public void GetSales()
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            SalesListView.Rows.Clear();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Sales";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int rowCounter = 0;

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        SalesListView.Rows.Add(
                            rowCounter,
                            reader["Id"].ToString(),
                            reader["BillNo"].ToString(),
                            reader["Date"].ToString(),
                            reader["CompanyName"].ToString(),
                            reader["CompanyVat"].ToString(),
                            reader["CostumerName"].ToString(),
                            reader["MemberShip"].ToString(),
                            reader["PaymentMode"].ToString(),
                            reader["SubTotal"].ToString(),
                            reader["Vat"].ToString(),
                            reader["Discount"].ToString(),
                            reader["GrandTotal"].ToString()
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
            Sales sales = new Sales();
            sales.Show();
        }
    }
}
