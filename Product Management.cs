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
    public partial class Product_Management : Form
    {
        public Product_Management()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList list = new ProductList();
            list.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseList purchase = new PurchaseList();
            purchase.Show();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembershipList membership = new MembershipList();
            membership.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesList sales = new SalesList();
            sales.Show();
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
        }

        private void btnMembership_Click_1(object sender, EventArgs e)
        {
            MemberShip ship = new MemberShip();
            ship.Show();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        private void rateSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RateSetup rateSetup = new RateSetup();
            rateSetup.Show();
        }
    }
}

