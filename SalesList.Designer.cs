namespace KoseliMart
{
    partial class SalesList
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
            SalesListView = new DataGridView();
            btnAdd = new Button();
            No = new DataGridViewTextBoxColumn();
            Sales_Id = new DataGridViewTextBoxColumn();
            BillNo = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Company_Name = new DataGridViewTextBoxColumn();
            Company_Vat = new DataGridViewTextBoxColumn();
            Costumer_Name = new DataGridViewTextBoxColumn();
            Costumer_MemberShip = new DataGridViewTextBoxColumn();
            PaymentMode = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Vat = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            GrandTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SalesListView).BeginInit();
            SuspendLayout();
            // 
            // SalesListView
            // 
            SalesListView.AllowUserToAddRows = false;
            SalesListView.AllowUserToDeleteRows = false;
            SalesListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesListView.Columns.AddRange(new DataGridViewColumn[] { No, Sales_Id, BillNo, Date, Company_Name, Company_Vat, Costumer_Name, Costumer_MemberShip, PaymentMode, SubTotal, Vat, Discount, GrandTotal });
            SalesListView.Location = new Point(1, 1);
            SalesListView.Name = "SalesListView";
            SalesListView.ReadOnly = true;
            SalesListView.RowHeadersWidth = 62;
            SalesListView.RowTemplate.Height = 33;
            SalesListView.Size = new Size(799, 408);
            SalesListView.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // Sales_Id
            // 
            Sales_Id.HeaderText = "Sales_Id";
            Sales_Id.MinimumWidth = 8;
            Sales_Id.Name = "Sales_Id";
            Sales_Id.ReadOnly = true;
            Sales_Id.Visible = false;
            Sales_Id.Width = 150;
            // 
            // BillNo
            // 
            BillNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BillNo.HeaderText = "Bill_No";
            BillNo.MinimumWidth = 8;
            BillNo.Name = "BillNo";
            BillNo.ReadOnly = true;
            BillNo.Width = 101;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 85;
            // 
            // Company_Name
            // 
            Company_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Company_Name.HeaderText = "Company_Name";
            Company_Name.MinimumWidth = 8;
            Company_Name.Name = "Company_Name";
            Company_Name.ReadOnly = true;
            Company_Name.Width = 179;
            // 
            // Company_Vat
            // 
            Company_Vat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Company_Vat.HeaderText = "Company_Vat";
            Company_Vat.MinimumWidth = 8;
            Company_Vat.Name = "Company_Vat";
            Company_Vat.ReadOnly = true;
            Company_Vat.Width = 157;
            // 
            // Costumer_Name
            // 
            Costumer_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Costumer_Name.HeaderText = "Costumer_Name";
            Costumer_Name.MinimumWidth = 8;
            Costumer_Name.Name = "Costumer_Name";
            Costumer_Name.ReadOnly = true;
            Costumer_Name.Width = 179;
            // 
            // Costumer_MemberShip
            // 
            Costumer_MemberShip.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Costumer_MemberShip.HeaderText = "Costumer_MemberShip";
            Costumer_MemberShip.MinimumWidth = 8;
            Costumer_MemberShip.Name = "Costumer_MemberShip";
            Costumer_MemberShip.ReadOnly = true;
            Costumer_MemberShip.Width = 234;
            // 
            // PaymentMode
            // 
            PaymentMode.HeaderText = "PaymentMode";
            PaymentMode.MinimumWidth = 8;
            PaymentMode.Name = "PaymentMode";
            PaymentMode.ReadOnly = true;
            PaymentMode.Width = 150;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 8;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Visible = false;
            SubTotal.Width = 150;
            // 
            // Vat
            // 
            Vat.HeaderText = "Vat";
            Vat.MinimumWidth = 8;
            Vat.Name = "Vat";
            Vat.ReadOnly = true;
            Vat.Visible = false;
            Vat.Width = 150;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 8;
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Visible = false;
            Discount.Width = 150;
            // 
            // GrandTotal
            // 
            GrandTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GrandTotal.HeaderText = "GrandTotal";
            GrandTotal.MinimumWidth = 8;
            GrandTotal.Name = "GrandTotal";
            GrandTotal.ReadOnly = true;
            GrandTotal.Width = 133;
            // 
            // SalesList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SalesListView);
            Controls.Add(btnAdd);
            Name = "SalesList";
            Text = "SalesList";
            ((System.ComponentModel.ISupportInitialize)SalesListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SalesListView;
        private Button btnAdd;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Sales_Id;
        private DataGridViewTextBoxColumn BillNo;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Company_Name;
        private DataGridViewTextBoxColumn Company_Vat;
        private DataGridViewTextBoxColumn Costumer_Name;
        private DataGridViewTextBoxColumn Costumer_MemberShip;
        private DataGridViewTextBoxColumn PaymentMode;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Vat;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn GrandTotal;
    }
}