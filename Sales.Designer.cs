namespace KoseliMart
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            textBoxMembership = new TextBox();
            textBoxCostumerName = new TextBox();
            textBoxCompanyVat = new TextBox();
            textBoxCompanyName = new TextBox();
            textBoxDate = new TextBox();
            textBoxBillNo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lbBill = new Label();
            lbDate = new Label();
            button1 = new Button();
            LineItemsView = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Product_ID = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBoxGrandTotal = new TextBox();
            textBoxDiscount = new TextBox();
            textBoxVat = new TextBox();
            textBoxSubTotal = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            btnSave = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)LineItemsView).BeginInit();
            SuspendLayout();
            // 
            // textBoxMembership
            // 
            textBoxMembership.Location = new Point(356, 217);
            textBoxMembership.Name = "textBoxMembership";
            textBoxMembership.Size = new Size(453, 31);
            textBoxMembership.TabIndex = 39;
            // 
            // textBoxCostumerName
            // 
            textBoxCostumerName.Location = new Point(271, 178);
            textBoxCostumerName.Name = "textBoxCostumerName";
            textBoxCostumerName.Size = new Size(537, 31);
            textBoxCostumerName.TabIndex = 38;
            // 
            // textBoxCompanyVat
            // 
            textBoxCompanyVat.Location = new Point(257, 132);
            textBoxCompanyVat.Name = "textBoxCompanyVat";
            textBoxCompanyVat.Size = new Size(553, 31);
            textBoxCompanyVat.TabIndex = 37;
            textBoxCompanyVat.Text = "00000";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(257, 95);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(553, 31);
            textBoxCompanyName.TabIndex = 36;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(621, 30);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(187, 31);
            textBoxDate.TabIndex = 35;
            textBoxDate.Text = "0000-00-00";
            // 
            // textBoxBillNo
            // 
            textBoxBillNo.Location = new Point(80, 30);
            textBoxBillNo.Name = "textBoxBillNo";
            textBoxBillNo.Size = new Size(174, 31);
            textBoxBillNo.TabIndex = 34;
            textBoxBillNo.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 128);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 33;
            label4.Text = "Company VatNo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 92);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 32;
            label3.Text = "Company Name";
            // 
            // lbBill
            // 
            lbBill.AutoSize = true;
            lbBill.Location = new Point(11, 28);
            lbBill.Name = "lbBill";
            lbBill.Size = new Size(67, 25);
            lbBill.TabIndex = 29;
            lbBill.Text = "Bill No.";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(560, 28);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(53, 25);
            lbDate.TabIndex = 28;
            lbDate.Text = "Date:";
            // 
            // button1
            // 
            button1.Location = new Point(9, 623);
            button1.Name = "button1";
            button1.Size = new Size(190, 33);
            button1.TabIndex = 27;
            button1.Text = "Add Sales";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LineItemsView
            // 
            LineItemsView.AllowUserToAddRows = false;
            LineItemsView.AllowUserToDeleteRows = false;
            LineItemsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LineItemsView.Columns.AddRange(new DataGridViewColumn[] { No, ID, Product_ID, Product_Name, Price, Quantity, Total });
            LineItemsView.EditMode = DataGridViewEditMode.EditOnEnter;
            LineItemsView.Location = new Point(9, 253);
            LineItemsView.Name = "LineItemsView";
            LineItemsView.ReadOnly = true;
            LineItemsView.RowHeadersWidth = 62;
            LineItemsView.RowTemplate.Height = 33;
            LineItemsView.Size = new Size(800, 363);
            LineItemsView.TabIndex = 26;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            No.HeaderText = "No";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 72;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 150;
            // 
            // Product_ID
            // 
            Product_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Product_ID.HeaderText = "Product_ID";
            Product_ID.MinimumWidth = 8;
            Product_ID.Name = "Product_ID";
            Product_ID.ReadOnly = true;
            Product_ID.Visible = false;
            Product_ID.Width = 150;
            // 
            // Product_Name
            // 
            Product_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product_Name.HeaderText = "Product_Name";
            Product_Name.MinimumWidth = 8;
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 178);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 48;
            label1.Text = "Costumer's Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 217);
            label2.Name = "label2";
            label2.Size = new Size(237, 25);
            label2.TabIndex = 49;
            label2.Text = "Costumer's MemberShip No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 642);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 50;
            label5.Text = "Payment Methode";
            // 
            // textBoxGrandTotal
            // 
            textBoxGrandTotal.Location = new Point(666, 793);
            textBoxGrandTotal.Name = "textBoxGrandTotal";
            textBoxGrandTotal.Size = new Size(141, 31);
            textBoxGrandTotal.TabIndex = 58;
            textBoxGrandTotal.Text = "00.00";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Location = new Point(649, 753);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(158, 31);
            textBoxDiscount.TabIndex = 57;
            textBoxDiscount.Text = "00.00";
            textBoxDiscount.TextChanged += textBoxDiscount_TextChanged;
            // 
            // textBoxVat
            // 
            textBoxVat.Location = new Point(611, 717);
            textBoxVat.Name = "textBoxVat";
            textBoxVat.Size = new Size(195, 31);
            textBoxVat.TabIndex = 56;
            textBoxVat.Text = "00.00";
            // 
            // textBoxSubTotal
            // 
            textBoxSubTotal.Location = new Point(656, 678);
            textBoxSubTotal.Name = "textBoxSubTotal";
            textBoxSubTotal.Size = new Size(150, 31);
            textBoxSubTotal.TabIndex = 55;
            textBoxSubTotal.Text = "00.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(560, 793);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 54;
            label8.Text = "Grand Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(560, 757);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 53;
            label7.Text = "Discount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 717);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 52;
            label6.Text = "Vat";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(560, 678);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 51;
            label9.Text = "Sub Total";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(9, 662);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 33);
            btnSave.TabIndex = 62;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash", "Card", "Online" });
            comboBox1.Location = new Point(656, 639);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 63;
            
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(819, 847);
            Controls.Add(comboBox1);
            Controls.Add(btnSave);
            Controls.Add(textBoxGrandTotal);
            Controls.Add(textBoxDiscount);
            Controls.Add(textBoxVat);
            Controls.Add(textBoxSubTotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMembership);
            Controls.Add(textBoxCostumerName);
            Controls.Add(textBoxCompanyVat);
            Controls.Add(textBoxCompanyName);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxBillNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbBill);
            Controls.Add(lbDate);
            Controls.Add(button1);
            Controls.Add(LineItemsView);
            Name = "Sales";
            Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)LineItemsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxMembership;
        private TextBox textBoxCostumerName;
        private TextBox textBoxCompanyVat;
        private TextBox textBoxCompanyName;
        private TextBox textBoxDate;
        private TextBox textBoxBillNo;
        private Label label4;
        private Label label3;
        private Label lbBill;
        private Label lbDate;
        private Button button1;
        private DataGridView LineItemsView;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox textBoxGrandTotal;
        private TextBox textBoxDiscount;
        private TextBox textBoxVat;
        private TextBox textBoxSubTotal;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Button btnSave;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private ComboBox comboBox1;
    }
}