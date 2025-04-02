namespace KoseliMart
{
    partial class LineItemsSales
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
            comboBox1 = new ComboBox();
            btnClose = new Button();
            button1 = new Button();
            txtBoxTotal = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxQuantity = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 33);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(125, 365);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 33);
            btnClose.TabIndex = 25;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.Location = new Point(125, 307);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 33);
            button1.TabIndex = 24;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Location = new Point(90, 239);
            txtBoxTotal.Margin = new Padding(4, 5, 4, 5);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.Size = new Size(283, 31);
            txtBoxTotal.TabIndex = 23;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(90, 107);
            txtBoxPrice.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(283, 31);
            txtBoxPrice.TabIndex = 22;
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.Location = new Point(117, 174);
            txtBoxQuantity.Margin = new Padding(4, 5, 4, 5);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(255, 31);
            txtBoxQuantity.TabIndex = 21;
            txtBoxQuantity.TextChanged += txtBoxQuantity_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 114);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 20;
            label6.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 239);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 19;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 18;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // LineItemsSales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnClose);
            Controls.Add(button1);
            Controls.Add(txtBoxTotal);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxQuantity);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "LineItemsSales";
            Text = "LineItemsSales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnClose;
        private Button button1;
        private TextBox txtBoxTotal;
        private TextBox txtBoxPrice;
        private TextBox txtBoxQuantity;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}