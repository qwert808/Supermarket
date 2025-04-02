using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KoseliMart
{
    public partial class MembershipUpdate : Form
    {
        private readonly string _memberId;
        public MembershipUpdate(string memberId,string mName,string mPanNo,string mAddress,string mContactNumber,string mEmail)
        {
            InitializeComponent();
            _memberId = memberId;
            textBoxName.Text = mName;
            textBoxPanNo.Text = mPanNo;
            textBoxAddress.Text = mAddress;
            textBoxContactNo.Text = mContactNumber;
            textBoxEmail.Text = mEmail;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbConnector.ConnectionString;
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"Update Membership
                                        Set [Name]=@Name,
                                        Pan_No=@PanNo,
                                        [Address]=@Address,
                                        Contact_Number=@Contact_Number, 
                                        Email=@Email
                                        Where Id=@Id";

                command.Parameters.AddWithValue("@Id", _memberId);
                command.Parameters.AddWithValue("@Name", textBoxName.Text);
                command.Parameters.AddWithValue("@PanNo", textBoxPanNo.Text);
                command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@Contact_Number", textBoxContactNo.Text);
                command.Parameters.AddWithValue("@Email", textBoxEmail.Text);


                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MembershipList member = Application.OpenForms.OfType<MembershipList>().FirstOrDefault();
                member?.GetMemberShip();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
    
