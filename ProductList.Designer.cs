namespace KoseliMart
{
    partial class ProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductList));
            ProductListView = new DataGridView();
            btnAdd = new Button();
            No = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            CostPrice = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)ProductListView).BeginInit();
            SuspendLayout();
            // 
            // ProductListView
            // 
            ProductListView.AllowUserToAddRows = false;
            ProductListView.AllowUserToDeleteRows = false;
            ProductListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductListView.Columns.AddRange(new DataGridViewColumn[] { No, Id, ProductName, SellingPrice, CostPrice, Code, Edit, Delete });
            ProductListView.EditMode = DataGridViewEditMode.EditOnEnter;
            ProductListView.Location = new Point(0, 8);
            ProductListView.Name = "ProductListView";
            ProductListView.ReadOnly = true;
            ProductListView.RowHeadersWidth = 62;
            ProductListView.RowTemplate.Height = 33;
            ProductListView.Size = new Size(800, 392);
            ProductListView.TabIndex = 6;
            ProductListView.CellContentClick += ProductListView_CellContentClick_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(26, 408);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 33);
            btnAdd.TabIndex = 7;
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
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 64;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // SellingPrice
            // 
            SellingPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SellingPrice.HeaderText = "SellingPrice";
            SellingPrice.MinimumWidth = 8;
            SellingPrice.Name = "SellingPrice";
            SellingPrice.ReadOnly = true;
            SellingPrice.Width = 137;
            // 
            // CostPrice
            // 
            CostPrice.HeaderText = "CostPrice";
            CostPrice.MinimumWidth = 8;
            CostPrice.Name = "CostPrice";
            CostPrice.ReadOnly = true;
            CostPrice.Width = 150;
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.MinimumWidth = 8;
            Code.Name = "Code";
            Code.ReadOnly = true;
            Code.Width = 150;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 8;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 8;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductListView);
            Controls.Add(btnAdd);
            Name = "ProductList";
            Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)ProductListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductListView;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Button btnAdd;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn CostPrice;
    }
}