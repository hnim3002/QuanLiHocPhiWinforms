namespace WindowsFormsApp2
{
    partial class HoaDonReportOptionForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNamHoc = new System.Windows.Forms.TextBox();
            this.textBoxLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trangThaiOption = new System.Windows.Forms.ComboBox();
            this.hocKyOption = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.inBaoCaoBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Học Kỳ";
            // 
            // textBoxNamHoc
            // 
            this.textBoxNamHoc.Location = new System.Drawing.Point(528, 111);
            this.textBoxNamHoc.Name = "textBoxNamHoc";
            this.textBoxNamHoc.Size = new System.Drawing.Size(205, 22);
            this.textBoxNamHoc.TabIndex = 53;
            // 
            // textBoxLop
            // 
            this.textBoxLop.Location = new System.Drawing.Point(172, 108);
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.Size = new System.Drawing.Size(205, 22);
            this.textBoxLop.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Năm Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Trạng Thái ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Lớp";
            // 
            // trangThaiOption
            // 
            this.trangThaiOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trangThaiOption.FormattingEnabled = true;
            this.trangThaiOption.Items.AddRange(new object[] {
            "Đã Nộp",
            "Chưa Nộp",
            "Tất Cả"});
            this.trangThaiOption.Location = new System.Drawing.Point(172, 152);
            this.trangThaiOption.Name = "trangThaiOption";
            this.trangThaiOption.Size = new System.Drawing.Size(121, 24);
            this.trangThaiOption.TabIndex = 60;
            // 
            // hocKyOption
            // 
            this.hocKyOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hocKyOption.FormattingEnabled = true;
            this.hocKyOption.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.hocKyOption.Location = new System.Drawing.Point(528, 68);
            this.hocKyOption.Name = "hocKyOption";
            this.hocKyOption.Size = new System.Drawing.Size(121, 24);
            this.hocKyOption.TabIndex = 61;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(214, 229);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(206, 50);
            this.backBtn.TabIndex = 62;
            this.backBtn.Text = "Quay Lai";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // inBaoCaoBtn
            // 
            this.inBaoCaoBtn.Location = new System.Drawing.Point(571, 229);
            this.inBaoCaoBtn.Name = "inBaoCaoBtn";
            this.inBaoCaoBtn.Size = new System.Drawing.Size(206, 50);
            this.inBaoCaoBtn.TabIndex = 63;
            this.inBaoCaoBtn.Text = "In Báo Cáo";
            this.inBaoCaoBtn.UseVisualStyleBackColor = true;
            this.inBaoCaoBtn.Click += new System.EventHandler(this.inBaoCaoBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 280);
            this.dataGridView1.TabIndex = 64;
            // 
            // HoaDonReportOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inBaoCaoBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hocKyOption);
            this.Controls.Add(this.trangThaiOption);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNamHoc);
            this.Controls.Add(this.textBoxLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "HoaDonReportOptionForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNamHoc;
        private System.Windows.Forms.TextBox textBoxLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox trangThaiOption;
        private System.Windows.Forms.ComboBox hocKyOption;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button inBaoCaoBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}