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
    public partial class MembershipList : Form
    {
        public MembershipList()
        {
            InitializeComponent();
            GetMemberShip();
        }

        public void GetMemberShip()
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            ProductListView.Rows.Clear();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Membership";

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
                            reader["Pan_No"].ToString(),
                            reader["Address"].ToString(),
                            reader["Contact_Number"].ToString(),
                            reader["Email"].ToString(),
                            reader["Membership_Number"].ToString()
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


        private void ProductListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string? mName = ProductListView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            string? mPanNo = ProductListView.Rows[e.RowIndex].Cells["Pan_No"].Value.ToString();
            string? mAddress = ProductListView.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            string? mContactNumber = ProductListView.Rows[e.RowIndex].Cells["Contact_Number"].Value.ToString();
            string? mEmail = ProductListView.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            string? mebershipNumber = ProductListView.Rows[e.RowIndex].Cells["Membership_Number"].Value.ToString();
            string? columnName = ProductListView.Columns[e.ColumnIndex].Name;
            string? memberId = ProductListView.Rows[e.RowIndex].Cells["Id"].Value?.ToString();

            //Guid _productId = Guid.Empty;

            //if (!string.IsNullOrEmpty(productId))
            //{
            //    Guid.Parse(productId);
            //}


            if (columnName == "Edit")
            {

                MembershipUpdate updateForm = new MembershipUpdate(memberId, mName, mPanNo, mAddress, mContactNumber, mEmail);
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
                        command.CommandText = @"DELETE FROM Membership
                                                WHERE ID = @Id";

                        command.Parameters.AddWithValue("@Id", memberId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully.", "Data deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetMemberShip();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberShip memberShip = new MemberShip();
            memberShip.Show();
        }
    }
}


