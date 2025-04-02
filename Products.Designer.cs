namespace KoseliMart
{
    partial class Products
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
            label1 = new Label();
            ProductName = new TextBox();
            label3 = new Label();
            ProductCode = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // ProductName
            // 
            ProductName.Location = new Point(42, 59);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(367, 31);
            ProductName.TabIndex = 1;
            ProductName.TextChanged += ProductName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 143);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Code";
            label3.Click += label3_Click;
            // 
            // ProductCode
            // 
            ProductCode.Location = new Point(44, 185);
            ProductCode.Name = "ProductCode";
            ProductCode.Size = new Size(363, 31);
            ProductCode.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(161, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Add";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 353);
            Controls.Add(btnUpdate);
            Controls.Add(ProductCode);
            Controls.Add(label3);
            Controls.Add(ProductName);
            Controls.Add(label1);
            Name = "Products";
            Text = "Products";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ProductName;
        private Label label3;
        private TextBox ProductCode;
        private Button btnUpdate;
    }
}