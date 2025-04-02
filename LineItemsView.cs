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
    public partial class LineItemsView : Form
    {
        private string purchaseId;
        public LineItemsView(string PurchaseId)
        {
            InitializeComponent();
            this.purchaseId = PurchaseId;
            GetLineItems();
        }

        public void GetLineItems()
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT * FROM LineItems 
                                        WHERE Purchase_Id = @PurchaseId";
                command.Parameters.AddWithValue("@PurchaseId", purchaseId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                
                int rowCounter = 0;
              
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        LineItemView.Rows.Add(
                               rowCounter,
                               reader["Id"].ToString(),
                               reader["Product_Id"].ToString(),
                               reader["Name"].ToString(),
                               reader["Price"].ToString(),
                               reader["Quantity"].ToString(),
                               reader["Total"].ToString()
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
    }
}
