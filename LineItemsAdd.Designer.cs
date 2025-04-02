namespace KoseliMart
{
    partial class LineItemsAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineItemsAdd));
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtBoxQuantity = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxTotal = new TextBox();
            button1 = new Button();
            label2 = new Label();
            btnClose = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 4;
            label4.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 92);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.Location = new Point(101, 152);
            txtBoxQuantity.Margin = new Padding(4, 5, 4, 5);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(255, 31);
            txtBoxQuantity.TabIndex = 8;
            txtBoxQuantity.TextChanged += txtBoxQuantity_TextChanged_1;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(74, 85);
            txtBoxPrice.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(283, 31);
            txtBoxPrice.TabIndex = 10;
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Location = new Point(74, 217);
            txtBoxTotal.Margin = new Padding(4, 5, 4, 5);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.Size = new Size(283, 31);
            txtBoxTotal.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(109, 285);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 33);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(109, 343);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 33);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 33);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LineItemsAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 422);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "LineItemsAdd";
            Text = "LineItemsAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtBoxQuantity;
        private TextBox txtBoxPrice;
        private TextBox txtBoxTotal;
        private Button button1;
        private Label label2;
        private Button btnClose;
        private ComboBox comboBox1;
    }
}