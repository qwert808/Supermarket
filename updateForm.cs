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
    public partial class UpdateForm : Form
    {
        private readonly string _productId;

        public UpdateForm(string productId, string pName,  string pCode)
        {

            InitializeComponent();
            _productId = productId;
            newNameTxtBox.Text = pName;
            newCodeText.Text = pCode;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = " UPDATE Products " +
                    "SET Name = @Name, " +
                    " Code = @Code " +
                    "WHERE Id = @id";

                command.Parameters.AddWithValue("@Name", newNameTxtBox.Text);
                command.Parameters.AddWithValue("@Code", newCodeText.Text);
                command.Parameters.AddWithValue("@id", _productId);

                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductList productListForm = Application.OpenForms.OfType<ProductList>().FirstOrDefault();
                productListForm?.GetProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
