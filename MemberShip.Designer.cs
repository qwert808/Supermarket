namespace KoseliMart
{
    partial class MemberShip
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxPanNo = new TextBox();
            textBoxAddress = new TextBox();
            textBoxContactNo = new TextBox();
            textBoxEmail = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 84);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Pan No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 147);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 208);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 269);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(89, 21);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(297, 31);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPanNo
            // 
            textBoxPanNo.Location = new Point(99, 83);
            textBoxPanNo.Name = "textBoxPanNo";
            textBoxPanNo.Size = new Size(287, 31);
            textBoxPanNo.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(100, 144);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(286, 31);
            textBoxAddress.TabIndex = 7;
            // 
            // textBoxContactNo
            // 
            textBoxContactNo.Location = new Point(129, 205);
            textBoxContactNo.Name = "textBoxContactNo";
            textBoxContactNo.Size = new Size(257, 31);
            textBoxContactNo.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(81, 263);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(303, 31);
            textBoxEmail.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(129, 328);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MemberShip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 401);
            Controls.Add(button1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxContactNo);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPanNo);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MemberShip";
            Text = "MemberShip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxPanNo;
        private TextBox textBoxAddress;
        private TextBox textBoxContactNo;
        private TextBox textBoxEmail;
        private Button button1;
    }
}