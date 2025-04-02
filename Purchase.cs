using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace KoseliMart
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
            GetLineItems();
        }

        private string purchaseId = "";
        private void button1_Click_1(object sender, EventArgs e)
        {
            purchaseId = Guid.NewGuid().ToString();
            LineItemsAdd lineItemsAdd = new LineItemsAdd(purchaseId);
            lineItemsAdd.Show();
        }

        private decimal SubTotal = 0;
        private decimal Vat = 0;
        private decimal Discount = 0;
        private decimal GrandTotal = 0;
        public void GetLineItems()
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            LineItemsView.Rows.Clear();
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
                SubTotal = 0;

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowCounter++;
                        decimal total = decimal.Parse(reader["Total"].ToString());
                        SubTotal += total;
                        LineItemsView.Rows.Add(
                            rowCounter,
                            reader["Id"].ToString(),
                            reader["Product_Id"].ToString(),
                            reader["Name"].ToString(),
                            reader["Price"].ToString(),
                            reader["Quantity"].ToString(),
                            total.ToString()
                        );
                    }

                }

                textBoxSubTotal.Text = SubTotal.ToString();
                Vat = 0.13M * SubTotal;
                textBoxVat.Text = Vat.ToString();

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
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = DbConnector.ConnectionString;


                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandType = CommandType.Text;
                    command.CommandText = @"INSERT INTO Purchase
                                    VALUES  (@Date, @BillNo, @SupplierName, @SupplierVat, @SubTotal, @Vat, @Discount, @GrandTotal, @Id)";
                    command.Parameters.AddWithValue("@Id", purchaseId);
                    command.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateTimePicker1.Text));
                    command.Parameters.AddWithValue("@BillNo", int.Parse(textBoxBillNo.Text));
                    command.Parameters.AddWithValue("@SupplierName", textBoxSupplierName.Text);
                    command.Parameters.AddWithValue("@SupplierVat", int.Parse(textBoxSupplierVatNo.Text));
                    command.Parameters.AddWithValue("@SubTotal", decimal.Parse(textBoxSubTotal.Text));
                    command.Parameters.AddWithValue("@Vat", decimal.Parse(textBoxVat.Text));
                    command.Parameters.AddWithValue("@Discount", decimal.Parse(textBoxDiscount.Text));
                    command.Parameters.AddWithValue("@GrandTotal", decimal.Parse(textBoxGrandTotal.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Record added successfully!", "Record added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PurchaseList productListForm = Application.OpenForms.OfType<PurchaseList>().FirstOrDefault();
                    productListForm?.GetPurchase();
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
                Close();
                Purchase purchase = new Purchase();
                purchase.Show();
            }
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxDiscount.Text, out decimal discount))
            {
                GrandTotal = SubTotal + Vat - discount;
                textBoxGrandTotal.Text = GrandTotal.ToString();
            }
            else
            {
                GrandTotal = SubTotal + Vat;
                textBoxGrandTotal.Text = GrandTotal.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LineItemsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string? columnName = LineItemsView.Columns[e.ColumnIndex].Name;
            string? Id = LineItemsView.Rows[e.RowIndex].Cells["ID"].Value?.ToString();
            if (columnName == "delete")
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
                        command.CommandText = @"DELETE FROM LineItems
                                                WHERE ID = @Id";

                        command.Parameters.AddWithValue("@Id", Id);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully.", "Data deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetLineItems();
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
            if (columnName == "edit")
            {

            }
        }
    }
}
