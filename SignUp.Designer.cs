namespace WindowsFormsApp2
{
    partial class SignUp
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rePasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenKhoaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(562, 431);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(174, 45);
            this.signUpBtn.TabIndex = 14;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(341, 431);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(174, 45);
            this.signInBtn.TabIndex = 13;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(358, 303);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(339, 22);
            this.passwordTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // accountTxt
            // 
            this.accountTxt.Location = new System.Drawing.Point(358, 250);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(339, 22);
            this.accountTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 91);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sign Up";
            // 
            // rePasswordTxt
            // 
            this.rePasswordTxt.Location = new System.Drawing.Point(358, 358);
            this.rePasswordTxt.Name = "rePasswordTxt";
            this.rePasswordTxt.Size = new System.Drawing.Size(339, 22);
            this.rePasswordTxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // tenKhoaComboBox
            // 
            this.tenKhoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tenKhoaComboBox.FormattingEnabled = true;
            this.tenKhoaComboBox.Location = new System.Drawing.Point(381, 183);
            this.tenKhoaComboBox.Name = "tenKhoaComboBox";
            this.tenKhoaComboBox.Size = new System.Drawing.Size(290, 24);
            this.tenKhoaComboBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên Khoa:";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 589);
            this.Controls.Add(this.tenKhoaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rePasswordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rePasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tenKhoaComboBox;
        private System.Windows.Forms.Label label5;
    }
}