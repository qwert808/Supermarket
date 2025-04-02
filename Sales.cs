using Microsoft.Data.SqlClient;
using System.Data;

namespace KoseliMart
{
    public partial class Sales : Form
    {

        private static int billNumber = 1;
        private int GenerateBillNumber()
        {
            int nextBillNumber = billNumber;
            billNumber++;
            return nextBillNumber;
        }
        private int billNo;
        public Sales()
        {
            InitializeComponent();
            GetLineItems();
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            textBoxDate.Text = today;
            billNo = GenerateBillNumber();
            textBoxBillNo.Text = billNo.ToString();
        }

        private string salesId = "";
        private void button1_Click(object sender, EventArgs e)
        {
            salesId = Guid.NewGuid().ToString();
            LineItemsSales lineItemsSales = new LineItemsSales(salesId);
            lineItemsSales.Show();
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
                command.CommandText = @"SELECT * FROM LineItemsSales 
                                        WHERE Sales_Id = @salesId";
                command.Parameters.AddWithValue("@salesId", salesId);
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
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;

            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"INSERT INTO Sales
                                        VALUES  (@Id,@BillNo,@Date,@CompanyName,@CompanyVat,@CostumerName,@Membership,@PaymentMode,@SubTotal,@Vat,@Discount,@GrandTotal)";

                string ID = Guid.NewGuid().ToString();
                string memberId = textBoxMembership.Text;
                int memberID = Convert.ToInt32(memberId);
                command.Parameters.AddWithValue("@Id", salesId);
                command.Parameters.AddWithValue("@BillNo", billNo);
                command.Parameters.AddWithValue("@Date", textBoxDate.Text);
                command.Parameters.AddWithValue("@CostumerName", textBoxCostumerName.Text);
                command.Parameters.AddWithValue("@Membership", memberId);
                command.Parameters.AddWithValue("@CompanyName", textBoxCompanyName.Text);
                command.Parameters.AddWithValue("@CompanyVat", int.Parse(textBoxCompanyVat.Text));
                command.Parameters.AddWithValue("@PaymentMode", comboBox1.Text);
                command.Parameters.AddWithValue("@SubTotal", decimal.Parse(textBoxSubTotal.Text));
                command.Parameters.AddWithValue("@Vat", decimal.Parse(textBoxVat.Text));
                command.Parameters.AddWithValue("@Discount", decimal.Parse(textBoxDiscount.Text));
                command.Parameters.AddWithValue("@GrandTotal", decimal.Parse(textBoxGrandTotal.Text));

                connection.Open();
                command.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Record added successfully!", "Record added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SalesList productListForm = Application.OpenForms.OfType<SalesList>().FirstOrDefault();
                productListForm?.GetSales();
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
            Sales purchase = new Sales();
            purchase.Show();
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


    }
}

