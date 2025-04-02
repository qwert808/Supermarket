namespace KoseliMart
{
    partial class LineItemsView
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
            LineItemView = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Product_Id = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LineItemView).BeginInit();
            SuspendLayout();
            // 
            // LineItemView
            // 
            LineItemView.AllowUserToAddRows = false;
            LineItemView.AllowUserToDeleteRows = false;
            LineItemView.BackgroundColor = Color.AntiqueWhite;
            LineItemView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LineItemView.Columns.AddRange(new DataGridViewColumn[] { No, Product_Id, ID, Product_Name, Price, Quantity, Total });
            LineItemView.EditMode = DataGridViewEditMode.EditOnEnter;
            LineItemView.Location = new Point(-1, 12);
            LineItemView.Name = "LineItemView";
            LineItemView.ReadOnly = true;
            LineItemView.RowHeadersWidth = 62;
            LineItemView.RowTemplate.Height = 33;
            LineItemView.Size = new Size(803, 347);
            LineItemView.TabIndex = 5;
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
            // Product_Id
            // 
            Product_Id.HeaderText = "";
            Product_Id.MinimumWidth = 8;
            Product_Id.Name = "Product_Id";
            Product_Id.ReadOnly = true;
            Product_Id.Visible = false;
            Product_Id.Width = 150;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 150;
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
            // LineItemsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 378);
            Controls.Add(LineItemView);
            Name = "LineItemsView";
            Text = "LineItemsView";
            ((System.ComponentModel.ISupportInitialize)LineItemView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView LineItemView;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Product_Id;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
    }
}