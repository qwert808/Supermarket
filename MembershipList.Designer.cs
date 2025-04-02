namespace KoseliMart
{
    partial class MembershipList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipList));
            ProductListView = new DataGridView();
            btnAdd = new Button();
            No = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Pan_No = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Contact_Number = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Membership_Number = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)ProductListView).BeginInit();
            SuspendLayout();
            // 
            // ProductListView
            // 
            ProductListView.AllowDrop = true;
            ProductListView.AllowUserToAddRows = false;
            ProductListView.AllowUserToDeleteRows = false;
            ProductListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductListView.Columns.AddRange(new DataGridViewColumn[] { No, Id, Name, Pan_No, Address, Contact_Number, Email, Membership_Number, Edit, Delete });
            ProductListView.EditMode = DataGridViewEditMode.EditOnEnter;
            ProductListView.Location = new Point(0, 9);
            ProductListView.Name = "ProductListView";
            ProductListView.ReadOnly = true;
            ProductListView.RowHeadersWidth = 62;
            ProductListView.RowTemplate.Height = 33;
            ProductListView.Size = new Size(800, 392);
            ProductListView.TabIndex = 8;
            ProductListView.CellContentClick += ProductListView_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.AllowDrop = true;
            btnAdd.Location = new Point(26, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 33);
            btnAdd.TabIndex = 9;
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
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 95;
            // 
            // Pan_No
            // 
            Pan_No.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Pan_No.HeaderText = "Pan_No";
            Pan_No.MinimumWidth = 8;
            Pan_No.Name = "Pan_No";
            Pan_No.ReadOnly = true;
            Pan_No.Width = 107;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 150;
            // 
            // Contact_Number
            // 
            Contact_Number.HeaderText = "Contact_Number";
            Contact_Number.MinimumWidth = 8;
            Contact_Number.Name = "Contact_Number";
            Contact_Number.ReadOnly = true;
            Contact_Number.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Membership_Number
            // 
            Membership_Number.HeaderText = "Membership_Number";
            Membership_Number.MinimumWidth = 8;
            Membership_Number.Name = "Membership_Number";
            Membership_Number.ReadOnly = true;
            Membership_Number.Width = 150;
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
            // MembershipList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductListView);
            Controls.Add(btnAdd);
            
            Text = "MembershipList";
            ((System.ComponentModel.ISupportInitialize)ProductListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductListView;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Pan_No;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Contact_Number;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Membership_Number;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Button btnAdd;
        private DataGridViewTextBoxColumn Name;
    }
}