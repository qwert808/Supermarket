namespace KoseliMart
{
    partial class Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            LineItemsView = new DataGridView();
            button1 = new Button();
            lbDate = new Label();
            lbBill = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxBillNo = new TextBox();
            textBoxSupplierName = new TextBox();
            textBoxSupplierVatNo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxSubTotal = new TextBox();
            textBoxVat = new TextBox();
            textBoxDiscount = new TextBox();
            textBoxGrandTotal = new TextBox();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            No = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Product_Id = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)LineItemsView).BeginInit();
            SuspendLayout();
            // 
            // LineItemsView
            // 
            LineItemsView.AllowUserToAddRows = false;
            LineItemsView.AllowUserToDeleteRows = false;
            LineItemsView.BackgroundColor = Color.AntiqueWhite;
            LineItemsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LineItemsView.Columns.AddRange(new DataGridViewColumn[] { No, ID, Product_Id, Product_Name, Price, Quantity, Total, edit, delete });
            LineItemsView.EditMode = DataGridViewEditMode.EditOnEnter;
            LineItemsView.Location = new Point(-5, 165);
            LineItemsView.Name = "LineItemsView";
            LineItemsView.ReadOnly = true;
            LineItemsView.RowHeadersWidth = 62;
            LineItemsView.RowTemplate.Height = 33;
            LineItemsView.Size = new Size(834, 347);
            LineItemsView.TabIndex = 4;
            LineItemsView.CellContentClick += LineItemsView_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(12, 518);
            button1.Name = "button1";
            button1.Size = new Size(114, 65);
            button1.TabIndex = 5;
            button1.Text = "Add Items";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(541, 16);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(58, 25);
            lbDate.TabIndex = 6;
            lbDate.Text = "Date :";
            // 
            // lbBill
            // 
            lbBill.AutoSize = true;
            lbBill.BackColor = Color.Transparent;
            lbBill.Location = new Point(11, 8);
            lbBill.Name = "lbBill";
            lbBill.Size = new Size(67, 25);
            lbBill.TabIndex = 7;
            lbBill.Text = "Bill No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(80, 58);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 10;
            label3.Text = "Supplier's Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(80, 112);
            label4.Name = "label4";
            label4.Size = new Size(143, 50);
            label4.TabIndex = 11;
            label4.Text = "Supplier's VatNo\r\n\r\n";
            // 
            // textBoxBillNo
            // 
            textBoxBillNo.Location = new Point(80, 10);
            textBoxBillNo.Name = "textBoxBillNo";
            textBoxBillNo.Size = new Size(174, 31);
            textBoxBillNo.TabIndex = 12;
            textBoxBillNo.Text = "00";
            // 
            // textBoxSupplierName
            // 
            textBoxSupplierName.Location = new Point(254, 58);
            textBoxSupplierName.Name = "textBoxSupplierName";
            textBoxSupplierName.Size = new Size(553, 31);
            textBoxSupplierName.TabIndex = 14;
            // 
            // textBoxSupplierVatNo
            // 
            textBoxSupplierVatNo.Location = new Point(256, 108);
            textBoxSupplierVatNo.Name = "textBoxSupplierVatNo";
            textBoxSupplierVatNo.Size = new Size(553, 31);
            textBoxSupplierVatNo.TabIndex = 15;
            textBoxSupplierVatNo.Text = "00000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(549, 522);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 18;
            label5.Text = "Sub Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(549, 573);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 19;
            label6.Text = "Vat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(549, 630);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 20;
            label7.Text = "Discount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(549, 682);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 21;
            label8.Text = "Grand Total";
            // 
            // textBoxSubTotal
            // 
            textBoxSubTotal.Location = new Point(657, 518);
            textBoxSubTotal.Name = "textBoxSubTotal";
            textBoxSubTotal.Size = new Size(150, 31);
            textBoxSubTotal.TabIndex = 22;
            textBoxSubTotal.Text = "00.00";
            // 
            // textBoxVat
            // 
            textBoxVat.Location = new Point(657, 570);
            textBoxVat.Name = "textBoxVat";
            textBoxVat.Size = new Size(150, 31);
            textBoxVat.TabIndex = 23;
            textBoxVat.Text = "00.00";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Location = new Point(657, 630);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(150, 31);
            textBoxDiscount.TabIndex = 24;
            textBoxDiscount.Text = "00.00";
            textBoxDiscount.TextChanged += textBoxDiscount_TextChanged;
            // 
            // textBoxGrandTotal
            // 
            textBoxGrandTotal.Location = new Point(657, 675);
            textBoxGrandTotal.Name = "textBoxGrandTotal";
            textBoxGrandTotal.Size = new Size(150, 31);
            textBoxGrandTotal.TabIndex = 25;
            textBoxGrandTotal.Text = "00.00";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Location = new Point(11, 592);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 53);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(605, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 31);
            dateTimePicker1.TabIndex = 27;
            dateTimePicker1.Value = new DateTime(2023, 7, 17, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            No.HeaderText = "No";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 72;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 150;
            // 
            // Product_Id
            // 
            Product_Id.HeaderText = "";
            Product_Id.MinimumWidth = 8;
            Product_Id.Name = "Product_Id";
            Product_Id.ReadOnly = true;
            Product_Id.Visible = false;
            Product_Id.Width = 150;
            // 
            // Product_Name
            // 
            Product_Name.HeaderText = "Product_Name";
            Product_Name.MinimumWidth = 8;
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            Product_Name.Width = 150;
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
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 116;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit.HeaderText = "";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.MinimumWidth = 8;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Width = 8;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            delete.HeaderText = "";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Width = 8;
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 715);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSave);
            Controls.Add(textBoxGrandTotal);
            Controls.Add(textBoxDiscount);
            Controls.Add(textBoxVat);
            Controls.Add(textBoxSubTotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxSupplierVatNo);
            Controls.Add(textBoxSupplierName);
            Controls.Add(textBoxBillNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbBill);
            Controls.Add(lbDate);
            Controls.Add(LineItemsView);
            Controls.Add(button1);
            Name = "Purchase";
            Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)LineItemsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LineItemsView;
        private Button button1;
        private Label lbDate;
        private Label lbBill;
        private Label label3;
        private Label label4;
        private TextBox textBoxBillNo;
        private TextBox textBoxSupplierName;
        private TextBox textBoxSupplierVatNo;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxSubTotal;
        private TextBox textBoxVat;
        private TextBox textBoxDiscount;
        private TextBox textBoxGrandTotal;
        private DataGridViewTextBoxColumn Purchase_ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Line_ID;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Product_Id;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
    }
}