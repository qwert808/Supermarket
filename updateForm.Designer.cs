using KoseliMart;
using System.Windows.Forms;

namespace KoseliMart
{
    partial class UpdateForm
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
        /// 


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            newName = new Label();
            newNameTxtBox = new TextBox();
            updateBtn = new Button();
            newCode = new Label();
            newCodeText = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // newName
            // 
            newName.AutoSize = true;
            newName.BackColor = Color.Transparent;
            newName.Location = new Point(6, 46);
            newName.Name = "newName";
            newName.Size = new Size(99, 25);
            newName.TabIndex = 0;
            newName.Text = "New Name";
            newName.Click += label1_Click;
            // 
            // newNameTxtBox
            // 
            newNameTxtBox.BackColor = Color.White;
            newNameTxtBox.Location = new Point(6, 74);
            newNameTxtBox.Name = "newNameTxtBox";
            newNameTxtBox.Size = new Size(285, 31);
            newNameTxtBox.TabIndex = 3;
            newNameTxtBox.TextChanged += newNameTxtBox_TextChanged;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(83, 229);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(112, 34);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // newCode
            // 
            newCode.AutoSize = true;
            newCode.BackColor = Color.Transparent;
            newCode.Location = new Point(6, 134);
            newCode.Name = "newCode";
            newCode.Size = new Size(94, 25);
            newCode.TabIndex = 5;
            newCode.Text = "New Code";
            // 
            // newCodeText
            // 
            newCodeText.Location = new Point(6, 162);
            newCodeText.Name = "newCodeText";
            newCodeText.Size = new Size(285, 31);
            newCodeText.TabIndex = 6;
            newCodeText.TextChanged += newCodeText_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(newCodeText);
            groupBox1.Controls.Add(newCode);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(newNameTxtBox);
            groupBox1.Controls.Add(newName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 319);
            Controls.Add(groupBox1);
            Name = "UpdateForm";
            Text = "updateForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void newNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newCodeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPrice_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }


        private void newPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Label newName;
        private TextBox newNameTxtBox;
        private Button updateBtn;
        private Label newCode;
        private TextBox newCodeText;
        private GroupBox groupBox1;
    }
}