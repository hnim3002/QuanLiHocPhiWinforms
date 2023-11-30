namespace WindowsFormsApp2
{
    partial class SinhVienReportOptionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.baoCaoBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioBNam = new System.Windows.Forms.RadioButton();
            this.radioBNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lopComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thiết Lập Báo Cáo Danh Sách Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 321);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lớp Hành Chính";
            // 
            // baoCaoBtn
            // 
            this.baoCaoBtn.Location = new System.Drawing.Point(623, 274);
            this.baoCaoBtn.Name = "baoCaoBtn";
            this.baoCaoBtn.Size = new System.Drawing.Size(75, 23);
            this.baoCaoBtn.TabIndex = 5;
            this.baoCaoBtn.Text = "In Báo Cáo";
            this.baoCaoBtn.UseVisualStyleBackColor = true;
            this.baoCaoBtn.Click += new System.EventHandler(this.baoCaoBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(42, 31);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Quay Lại";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioBNam);
            this.panel3.Controls.Add(this.radioBNu);
            this.panel3.Location = new System.Drawing.Point(780, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 92);
            this.panel3.TabIndex = 67;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tất Cả";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioBNam
            // 
            this.radioBNam.AutoSize = true;
            this.radioBNam.Location = new System.Drawing.Point(12, 5);
            this.radioBNam.Name = "radioBNam";
            this.radioBNam.Size = new System.Drawing.Size(57, 20);
            this.radioBNam.TabIndex = 28;
            this.radioBNam.TabStop = true;
            this.radioBNam.Text = "Nam";
            this.radioBNam.UseVisualStyleBackColor = true;
            // 
            // radioBNu
            // 
            this.radioBNu.AutoSize = true;
            this.radioBNu.Location = new System.Drawing.Point(12, 31);
            this.radioBNu.Name = "radioBNu";
            this.radioBNu.Size = new System.Drawing.Size(45, 20);
            this.radioBNu.TabIndex = 29;
            this.radioBNu.TabStop = true;
            this.radioBNu.Text = "Nữ";
            this.radioBNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Giới Tính";
            // 
            // lopComboBox
            // 
            this.lopComboBox.FormattingEnabled = true;
            this.lopComboBox.Location = new System.Drawing.Point(459, 137);
            this.lopComboBox.Name = "lopComboBox";
            this.lopComboBox.Size = new System.Drawing.Size(121, 24);
            this.lopComboBox.TabIndex = 68;
            // 
            // SinhVienReportOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 688);
            this.Controls.Add(this.lopComboBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.baoCaoBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinhVienReportOptionForm";
            this.Text = "SinhVienReportOptionForm";
            this.Load += new System.EventHandler(this.SinhVienReportOptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button baoCaoBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioBNam;
        private System.Windows.Forms.RadioButton radioBNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lopComboBox;
    }
}