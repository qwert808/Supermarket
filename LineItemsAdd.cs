using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace KoseliMart
{
    public partial class LineItemsAdd : Form
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

        private string purchaseId;
        public LineItemsAdd(string purchaseId)
        {
            InitializeComponent();
            this.purchaseId = purchaseId;
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
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private string selectedProductId;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProductId = comboBox1.SelectedValue.ToString();
        }
        private void txtBoxQuantity_TextChanged_1(object sender, EventArgs e)
        {
            decimal iPrice, iQuantity;
            string priceString = txtBoxPrice.Text;
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
            SqlTransaction transaction = null;

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandType = CommandType.Text;

                command.CommandText = @"INSERT INTO LineItems (ID, Product_Id, Purchase_Id, [Name], Price, Quantity, Total) 
                                VALUES (@Id, @productId, @purchaseId, @Name, @Price, @Quantity, @Total)";
                command.Parameters.AddWithValue("@Id", Guid.NewGuid());
                command.Parameters.AddWithValue("@productId", selectedProductId);
                command.Parameters.AddWithValue("@purchaseId", purchaseId);
                command.Parameters.AddWithValue("@Name", comboBox1.Text);
                command.Parameters.AddWithValue("@Price", decimal.Parse(txtBoxPrice.Text));
                command.Parameters.AddWithValue("@Quantity", decimal.Parse(txtBoxQuantity.Text));
                command.Parameters.AddWithValue("@Total", decimal.Parse(txtBoxTotal.Text));

                command.ExecuteNonQuery();

                command.CommandText = @"UPDATE Products
                                SET Quantity = @Quantity, 
                                    CostPrice = @Price
                                WHERE Id = @productId";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@productId", selectedProductId);
                command.Parameters.AddWithValue("@Quantity", decimal.Parse(txtBoxQuantity.Text));
                command.Parameters.AddWithValue("@Price", decimal.Parse(txtBoxPrice.Text));
                command.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Record added successfully.", "Record added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Purchase lineItems = Application.OpenForms.OfType<Purchase>().FirstOrDefault();
                lineItems.GetLineItems();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}


