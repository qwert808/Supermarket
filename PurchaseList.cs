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
    public partial class PurchaseList : Form
    {
        public PurchaseList()
        {
            InitializeComponent();
            GetPurchase();
        }
        public void GetPurchase()
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            PurchaseListView.Rows.Clear();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Purchase";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int rowCounter = 0;

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        PurchaseListView.Rows.Add(
                            rowCounter,
                            reader["Id"].ToString(),
                            reader["BillNo"].ToString(),
                            reader["Date"].ToString(),
                            reader["SupplierName"].ToString(),
                            reader["SupplierVat"].ToString(),
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
            Purchase purchase = new Purchase();
            purchase.Show();
        }

        private void PurchaseListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string? columnName = PurchaseListView.Columns[e.ColumnIndex].Name;
            string? PurchaseId = PurchaseListView.Rows[e.RowIndex].Cells["Purchase_Id"].Value?.ToString();
            if (columnName == "ViewLineItems")
            {
                LineItemsView lineItemsView = new LineItemsView(PurchaseId);
                lineItemsView.Show();
            }
        }
    }
}
