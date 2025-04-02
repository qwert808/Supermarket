namespace KoseliMart
{
    partial class RateSetup
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
            components = new System.ComponentModel.Container();
            RateGridView = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            CostPrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            dbConnectorBindingSource = new BindingSource(components);
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)RateGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // RateGridView
            // 
            RateGridView.AllowUserToAddRows = false;
            RateGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RateGridView.Columns.AddRange(new DataGridViewColumn[] { No, ProductName, ProductID, CostPrice, SellingPrice });
            RateGridView.Location = new Point(14, 13);
            RateGridView.Name = "RateGridView";
            RateGridView.RowHeadersWidth = 62;
            RateGridView.RowTemplate.Height = 33;
            RateGridView.Size = new Size(564, 375);
            RateGridView.TabIndex = 0;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            No.HeaderText = "No";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.Width = 72;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.Width = 162;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ProductID.HeaderText = "";
            ProductID.MinimumWidth = 8;
            ProductID.Name = "ProductID";
            ProductID.Visible = false;
            ProductID.Width = 150;
            // 
            // CostPrice
            // 
            CostPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CostPrice.HeaderText = "Cost Price";
            CostPrice.MinimumWidth = 8;
            CostPrice.Name = "CostPrice";
            CostPrice.Width = 126;
            // 
            // SellingPrice
            // 
            SellingPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SellingPrice.DataPropertyName = "0";
            SellingPrice.HeaderText = "Selling Price";
            SellingPrice.MinimumWidth = 8;
            SellingPrice.Name = "SellingPrice";
            SellingPrice.Width = 142;
            // 
            // dbConnectorBindingSource
            // 
            dbConnectorBindingSource.DataSource = typeof(DbConnector);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(462, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 57);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // RateSetup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 463);
            Controls.Add(btnSave);
            Controls.Add(RateGridView);
            Name = "RateSetup";
            Text = "RateSetup";
            ((System.ComponentModel.ISupportInitialize)RateGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView RateGridView;
        private Button btnSave;
        private BindingSource dbConnectorBindingSource;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn CostPrice;
        private DataGridViewTextBoxColumn SellingPrice;
    }
}