namespace WindowsFormsApp2
{
    partial class ChiTietHoaDonFormXem
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
            this.baoCaoBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.khoaTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lopTxt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ngaySinhTxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tenSVTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maSVTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maHdText = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chiTietHoaDonTable = new System.Windows.Forms.DataGridView();
            this.hocKyTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namHocTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.mienGiamTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.thanhTienTxt = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonTable)).BeginInit();
            this.SuspendLayout();
            // 
            // baoCaoBtn
            // 
            this.baoCaoBtn.Location = new System.Drawing.Point(807, 238);
            this.baoCaoBtn.Name = "baoCaoBtn";
            this.baoCaoBtn.Size = new System.Drawing.Size(159, 37);
            this.baoCaoBtn.TabIndex = 59;
            this.baoCaoBtn.Text = "Báo Cáo";
            this.baoCaoBtn.UseVisualStyleBackColor = true;
            this.baoCaoBtn.Click += new System.EventHandler(this.baoCaoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(565, 238);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(159, 37);
            this.deleteBtn.TabIndex = 58;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(309, 238);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 37);
            this.updateBtn.TabIndex = 57;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(57, 238);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 37);
            this.addBtn.TabIndex = 56;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // khoaTxt
            // 
            this.khoaTxt.AutoSize = true;
            this.khoaTxt.Location = new System.Drawing.Point(587, 126);
            this.khoaTxt.Name = "khoaTxt";
            this.khoaTxt.Size = new System.Drawing.Size(38, 16);
            this.khoaTxt.TabIndex = 91;
            this.khoaTxt.Text = "Khoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 90;
            this.label10.Text = "Khoa: ";
            // 
            // lopTxt
            // 
            this.lopTxt.AutoSize = true;
            this.lopTxt.Location = new System.Drawing.Point(650, 92);
            this.lopTxt.Name = "lopTxt";
            this.lopTxt.Size = new System.Drawing.Size(30, 16);
            this.lopTxt.TabIndex = 89;
            this.lopTxt.Text = "Lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 88;
            this.label11.Text = "Lớp Hành Chính: ";
            // 
            // ngaySinhTxt
            // 
            this.ngaySinhTxt.AutoSize = true;
            this.ngaySinhTxt.Location = new System.Drawing.Point(326, 126);
            this.ngaySinhTxt.Name = "ngaySinhTxt";
            this.ngaySinhTxt.Size = new System.Drawing.Size(69, 16);
            this.ngaySinhTxt.TabIndex = 87;
            this.ngaySinhTxt.Text = "Ngày Sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 86;
            this.label9.Text = "Ngày Sinh: ";
            // 
            // tenSVTxt
            // 
            this.tenSVTxt.AutoSize = true;
            this.tenSVTxt.Location = new System.Drawing.Point(340, 92);
            this.tenSVTxt.Name = "tenSVTxt";
            this.tenSVTxt.Size = new System.Drawing.Size(90, 16);
            this.tenSVTxt.TabIndex = 85;
            this.tenSVTxt.Text = "Tên Sinh Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 84;
            this.label7.Text = "Tên Sinh Viên: ";
            // 
            // maSVTxt
            // 
            this.maSVTxt.AutoSize = true;
            this.maSVTxt.Location = new System.Drawing.Point(142, 126);
            this.maSVTxt.Name = "maSVTxt";
            this.maSVTxt.Size = new System.Drawing.Size(85, 16);
            this.maSVTxt.TabIndex = 83;
            this.maSVTxt.Text = "Mã Sinh Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Mã Sinh Viên: ";
            // 
            // maHdText
            // 
            this.maHdText.AutoSize = true;
            this.maHdText.Location = new System.Drawing.Point(142, 92);
            this.maHdText.Name = "maHdText";
            this.maHdText.Size = new System.Drawing.Size(82, 16);
            this.maHdText.TabIndex = 81;
            this.maHdText.Text = "Mã Hóa Đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 76;
            this.label12.Text = "Mã Hóa Đơn: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(445, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 16);
            this.label15.TabIndex = 73;
            this.label15.Text = "Chi Tiết Hóa Đơn";
            // 
            // chiTietHoaDonTable
            // 
            this.chiTietHoaDonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chiTietHoaDonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietHoaDonTable.Location = new System.Drawing.Point(7, 308);
            this.chiTietHoaDonTable.Name = "chiTietHoaDonTable";
            this.chiTietHoaDonTable.RowHeadersWidth = 51;
            this.chiTietHoaDonTable.RowTemplate.Height = 24;
            this.chiTietHoaDonTable.Size = new System.Drawing.Size(1182, 322);
            this.chiTietHoaDonTable.TabIndex = 92;
            // 
            // hocKyTxt
            // 
            this.hocKyTxt.AutoSize = true;
            this.hocKyTxt.Location = new System.Drawing.Point(858, 126);
            this.hocKyTxt.Name = "hocKyTxt";
            this.hocKyTxt.Size = new System.Drawing.Size(50, 16);
            this.hocKyTxt.TabIndex = 96;
            this.hocKyTxt.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Học kỳ:";
            // 
            // namHocTxt
            // 
            this.namHocTxt.AutoSize = true;
            this.namHocTxt.Location = new System.Drawing.Point(858, 92);
            this.namHocTxt.Name = "namHocTxt";
            this.namHocTxt.Size = new System.Drawing.Size(64, 16);
            this.namHocTxt.TabIndex = 94;
            this.namHocTxt.Text = "Năm Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(784, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 93;
            this.label5.Text = "Năm Học:";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(58, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 97;
            this.backBtn.Text = "Quay Lại";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // mienGiamTxt
            // 
            this.mienGiamTxt.AutoSize = true;
            this.mienGiamTxt.Location = new System.Drawing.Point(1068, 92);
            this.mienGiamTxt.Name = "mienGiamTxt";
            this.mienGiamTxt.Size = new System.Drawing.Size(62, 16);
            this.mienGiamTxt.TabIndex = 99;
            this.mienGiamTxt.Text = "Giảm Trừ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(994, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 98;
            this.label3.Text = "Giảm Trừ:";
            // 
            // thanhTienTxt
            // 
            this.thanhTienTxt.AutoSize = true;
            this.thanhTienTxt.Location = new System.Drawing.Point(1068, 126);
            this.thanhTienTxt.Name = "thanhTienTxt";
            this.thanhTienTxt.Size = new System.Drawing.Size(75, 16);
            this.thanhTienTxt.TabIndex = 101;
            this.thanhTienTxt.Text = "Thành Tiền";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(994, 126);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 16);
            this.label.TabIndex = 100;
            this.label.Text = "Thành Tiền:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 74;
            this.label14.Text = "Tên Môn Học";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 75;
            this.label13.Text = "Mã Môn Học";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(787, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 22);
            this.textBox1.TabIndex = 80;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 22);
            this.textBox2.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(711, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Đơn Giá";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.textBox3.Location = new System.Drawing.Point(477, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 22);
            this.textBox3.TabIndex = 77;
            // 
            // ChiTietHoaDonFormXem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 636);
            this.Controls.Add(this.thanhTienTxt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.mienGiamTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hocKyTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namHocTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chiTietHoaDonTable);
            this.Controls.Add(this.khoaTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lopTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ngaySinhTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tenSVTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maSVTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maHdText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.baoCaoBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "ChiTietHoaDonFormXem";
            this.Text = "ChiTietHoaDonForm";
            this.Load += new System.EventHandler(this.ChiTietHoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button baoCaoBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label khoaTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lopTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ngaySinhTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tenSVTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label maSVTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maHdText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView chiTietHoaDonTable;
        private System.Windows.Forms.Label hocKyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namHocTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label mienGiamTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label thanhTienTxt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}