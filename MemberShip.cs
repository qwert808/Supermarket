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
using System.Windows.Forms.VisualStyles;

namespace KoseliMart
{
    public partial class MemberShip : Form
    {
        public MemberShip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string membershipName = textBoxName.Text.Trim();

            if (!IsValidMembershipName(membershipName))
            {
                MessageBox.Show("Invalid membership name. Please enter alphabets, spaces, and dots only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Membership(Id,[Name],Pan_No,Address,Contact_Number,Email,Membership_Number) " +
                    "VALUES (@Id,@Name,@PanNo,@Address,@Contact_Number,@Email,@Membership_Number)";

                Random random = new Random();
                int membershipNo = random.Next();
                command.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                command.Parameters.AddWithValue("@Name", textBoxName.Text);
                command.Parameters.AddWithValue("@PanNo", textBoxPanNo.Text);
                command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@Contact_Number", textBoxContactNo.Text);
                command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@Membership_Number", membershipNo);

                connection.Open();
                command.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Record added successfully. \n Your Membership Id is: " + membershipNo, "Record added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MembershipList membershipList=Application.OpenForms.OfType<MembershipList>().FirstOrDefault();
                //membershipList.GetMemberShip();
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
        private bool IsValidMembershipName(string name)
        {
            // Check if the name contains only alphabets, spaces, and dots
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
