namespace KoseliMart
{
    partial class PurchaseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseList));
            PurchaseListView = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Purchase_Id = new DataGridViewTextBoxColumn();
            BillNo = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Supplier_Name = new DataGridViewTextBoxColumn();
            Supplier_Vat = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Vat = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            GrandTotal = new DataGridViewTextBoxColumn();
            ViewLineItems = new DataGridViewImageColumn();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)PurchaseListView).BeginInit();
            SuspendLayout();
            // 
            // PurchaseListView
            // 
            PurchaseListView.AllowUserToAddRows = false;
            PurchaseListView.AllowUserToDeleteRows = false;
            PurchaseListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurchaseListView.Columns.AddRange(new DataGridViewColumn[] { No, Purchase_Id, BillNo, Date, Supplier_Name, Supplier_Vat, SubTotal, Vat, Discount, GrandTotal, ViewLineItems });
            PurchaseListView.Location = new Point(0, 0);
            PurchaseListView.Name = "PurchaseListView";
            PurchaseListView.ReadOnly = true;
            PurchaseListView.RowHeadersWidth = 62;
            PurchaseListView.RowTemplate.Height = 33;
            PurchaseListView.Size = new Size(826, 408);
            PurchaseListView.TabIndex = 0;
            PurchaseListView.CellContentClick += PurchaseListView_CellContentClick;
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
            // Purchase_Id
            // 
            Purchase_Id.HeaderText = "Purchase_Id";
            Purchase_Id.MinimumWidth = 8;
            Purchase_Id.Name = "Purchase_Id";
            Purchase_Id.ReadOnly = true;
            Purchase_Id.Visible = false;
            Purchase_Id.Width = 150;
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
            // Supplier_Name
            // 
            Supplier_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Supplier_Name.HeaderText = "Supplier_Name";
            Supplier_Name.MinimumWidth = 8;
            Supplier_Name.Name = "Supplier_Name";
            Supplier_Name.ReadOnly = true;
            Supplier_Name.Width = 167;
            // 
            // Supplier_Vat
            // 
            Supplier_Vat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Supplier_Vat.HeaderText = "Supplier_Vat";
            Supplier_Vat.MinimumWidth = 8;
            Supplier_Vat.Name = "Supplier_Vat";
            Supplier_Vat.ReadOnly = true;
            Supplier_Vat.Width = 145;
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
            // ViewLineItems
            // 
            ViewLineItems.HeaderText = "View Line Items";
            ViewLineItems.Image = (Image)resources.GetObject("ViewLineItems.Image");
            ViewLineItems.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ViewLineItems.MinimumWidth = 8;
            ViewLineItems.Name = "ViewLineItems";
            ViewLineItems.ReadOnly = true;
            ViewLineItems.Resizable = DataGridViewTriState.True;
            ViewLineItems.SortMode = DataGridViewColumnSortMode.Automatic;
            ViewLineItems.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // PurchaseList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(btnAdd);
            Controls.Add(PurchaseListView);
            Name = "PurchaseList";
            Text = "PurchaseList";
            ((System.ComponentModel.ISupportInitialize)PurchaseListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PurchaseListView;
        private Button btnAdd;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Purchase_Id;
        private DataGridViewTextBoxColumn BillNo;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Supplier_Name;
        private DataGridViewTextBoxColumn Supplier_Vat;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Vat;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn GrandTotal;
        private DataGridViewImageColumn ViewLineItems;
    }
}