namespace KoseliMart
{
    partial class Product_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSales = new Button();
            btnMembership = new Button();
            btnPurchase = new Button();
            btnProduct = new Button();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            groupToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            rateSetupToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSales);
            groupBox1.Controls.Add(btnMembership);
            groupBox1.Controls.Add(btnPurchase);
            groupBox1.Controls.Add(btnProduct);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Controls.Add(menuStrip2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 438);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Minimart";
            // 
            // btnSales
            // 
            btnSales.Location = new Point(134, 308);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(227, 72);
            btnSales.TabIndex = 6;
            btnSales.Text = "Add Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click_1;
            // 
            // btnMembership
            // 
            btnMembership.Location = new Point(134, 234);
            btnMembership.Name = "btnMembership";
            btnMembership.Size = new Size(227, 68);
            btnMembership.TabIndex = 5;
            btnMembership.Text = "Add Membership";
            btnMembership.UseVisualStyleBackColor = true;
            btnMembership.Click += btnMembership_Click_1;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(134, 160);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(227, 68);
            btnPurchase.TabIndex = 4;
            btnPurchase.Text = "Add Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click_1;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(131, 87);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(230, 67);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Add Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(3, 60);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(480, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, viewToolStripMenuItem, exitToolStripMenuItem });
            menuStrip2.Location = new Point(3, 27);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(480, 33);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(77, 29);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productToolStripMenuItem, purchaseToolStripMenuItem, salesToolStripMenuItem, groupToolStripMenuItem, rateSetupToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(270, 34);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(270, 34);
            purchaseToolStripMenuItem.Text = "Purchase";
            purchaseToolStripMenuItem.Click += purchaseToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(270, 34);
            salesToolStripMenuItem.Text = "Sales";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
            // 
            // groupToolStripMenuItem
            // 
            groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            groupToolStripMenuItem.Size = new Size(270, 34);
            groupToolStripMenuItem.Text = "MemberShip";
            groupToolStripMenuItem.Click += groupToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(55, 29);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // rateSetupToolStripMenuItem
            // 
            rateSetupToolStripMenuItem.Name = "rateSetupToolStripMenuItem";
            rateSetupToolStripMenuItem.Size = new Size(270, 34);
            rateSetupToolStripMenuItem.Text = "Rate Setup";
            rateSetupToolStripMenuItem.Click += rateSetupToolStripMenuItem_Click;
            // 
            // Product_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 433);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "Product_Management";
            Text = "Kosali MiniMart";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private Button btnSales;
        private Button btnMembership;
        private Button btnPurchase;
        private Button btnProduct;
        private ToolStripMenuItem rateSetupToolStripMenuItem;
    }
}