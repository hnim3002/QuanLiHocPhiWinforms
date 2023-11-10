namespace WindowsFormsApp2
{
    partial class SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tenKhoaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account";
            // 
            // accountTxt
            // 
            this.accountTxt.Location = new System.Drawing.Point(429, 258);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(290, 22);
            this.accountTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(429, 311);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(290, 22);
            this.passwordTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(341, 414);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(174, 45);
            this.signUpBtn.TabIndex = 6;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(562, 414);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(174, 45);
            this.signInBtn.TabIndex = 7;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên Khoa:";
            // 
            // tenKhoaComboBox
            // 
            this.tenKhoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tenKhoaComboBox.FormattingEnabled = true;
            this.tenKhoaComboBox.Location = new System.Drawing.Point(429, 205);
            this.tenKhoaComboBox.Name = "tenKhoaComboBox";
            this.tenKhoaComboBox.Size = new System.Drawing.Size(290, 24);
            this.tenKhoaComboBox.TabIndex = 9;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 589);
            this.Controls.Add(this.tenKhoaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tenKhoaComboBox;
    }
}