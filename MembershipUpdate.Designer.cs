namespace KoseliMart
{
    partial class MembershipUpdate
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
            btnUpdate = new Button();
            textBoxEmail = new TextBox();
            textBoxContactNo = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPanNo = new TextBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(119, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(71, 297);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(303, 31);
            textBoxEmail.TabIndex = 20;
            // 
            // textBoxContactNo
            // 
            textBoxContactNo.Location = new Point(119, 239);
            textBoxContactNo.Name = "textBoxContactNo";
            textBoxContactNo.Size = new Size(257, 31);
            textBoxContactNo.TabIndex = 19;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(90, 178);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(286, 31);
            textBoxAddress.TabIndex = 18;
            // 
            // textBoxPanNo
            // 
            textBoxPanNo.Location = new Point(89, 117);
            textBoxPanNo.Name = "textBoxPanNo";
            textBoxPanNo.Size = new Size(287, 31);
            textBoxPanNo.TabIndex = 17;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(79, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(297, 31);
            textBoxName.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 303);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 242);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 14;
            label4.Text = "Contact No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 181);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 13;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 118);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 12;
            label2.Text = "Pan No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 54);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // MembershipUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(btnUpdate);
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
            Name = "MembershipUpdate";
            Text = "MembershipUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox textBoxEmail;
        private TextBox textBoxContactNo;
        private TextBox textBoxAddress;
        private TextBox textBoxPanNo;
        private TextBox textBoxName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}