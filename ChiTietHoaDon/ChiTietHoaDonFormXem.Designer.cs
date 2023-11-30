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
            this.chiTietHoaDonTable = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.ngayLapText = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.baoCaoBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.thanhTienTxt = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.mienGiamTxt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hocKyTxt = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.namHocTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maSVTxt = new System.Windows.Forms.Label();
            this.lopTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tenSVTxt = new System.Windows.Forms.Label();
            this.ngaySinhTxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maHoaDonTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonTable)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chiTietHoaDonTable
            // 
            this.chiTietHoaDonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chiTietHoaDonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietHoaDonTable.Location = new System.Drawing.Point(9, 313);
            this.chiTietHoaDonTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chiTietHoaDonTable.Name = "chiTietHoaDonTable";
            this.chiTietHoaDonTable.RowHeadersWidth = 51;
            this.chiTietHoaDonTable.RowTemplate.Height = 24;
            this.chiTietHoaDonTable.Size = new System.Drawing.Size(1013, 275);
            this.chiTietHoaDonTable.TabIndex = 92;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(44, 11);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(98, 29);
            this.backBtn.TabIndex = 97;
            this.backBtn.Text = "Quay Lại";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 139;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.ngayLapText);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.baoCaoBtn);
            this.panel.Controls.Add(this.addBtn);
            this.panel.Controls.Add(this.thanhTienTxt);
            this.panel.Controls.Add(this.updateBtn);
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.deleteBtn);
            this.panel.Controls.Add(this.mienGiamTxt);
            this.panel.Controls.Add(this.label14);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label13);
            this.panel.Controls.Add(this.hocKyTxt);
            this.panel.Controls.Add(this.textBox3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.namHocTxt);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.maSVTxt);
            this.panel.Controls.Add(this.lopTxt);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.tenSVTxt);
            this.panel.Controls.Add(this.ngaySinhTxt);
            this.panel.Controls.Add(this.label9);
            this.panel.Location = new System.Drawing.Point(9, 67);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1014, 234);
            this.panel.TabIndex = 138;
            // 
            // ngayLapText
            // 
            this.ngayLapText.AutoSize = true;
            this.ngayLapText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayLapText.Location = new System.Drawing.Point(884, 119);
            this.ngayLapText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngayLapText.Name = "ngayLapText";
            this.ngayLapText.Size = new System.Drawing.Size(59, 15);
            this.ngayLapText.TabIndex = 103;
            this.ngayLapText.Text = "Ngày Lập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(817, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 102;
            this.label12.Text = "Ngày Lập: ";
            // 
            // baoCaoBtn
            // 
            this.baoCaoBtn.Location = new System.Drawing.Point(833, 184);
            this.baoCaoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baoCaoBtn.Name = "baoCaoBtn";
            this.baoCaoBtn.Size = new System.Drawing.Size(119, 30);
            this.baoCaoBtn.TabIndex = 59;
            this.baoCaoBtn.Text = "Báo Cáo";
            this.baoCaoBtn.UseVisualStyleBackColor = true;
            this.baoCaoBtn.Click += new System.EventHandler(this.baoCaoBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(45, 184);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(119, 30);
            this.addBtn.TabIndex = 56;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // thanhTienTxt
            // 
            this.thanhTienTxt.AutoSize = true;
            this.thanhTienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhTienTxt.Location = new System.Drawing.Point(884, 78);
            this.thanhTienTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thanhTienTxt.Name = "thanhTienTxt";
            this.thanhTienTxt.Size = new System.Drawing.Size(69, 15);
            this.thanhTienTxt.TabIndex = 101;
            this.thanhTienTxt.Text = "Thành Tiền";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(325, 184);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(119, 30);
            this.updateBtn.TabIndex = 57;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(815, 78);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 15);
            this.label.TabIndex = 100;
            this.label.Text = "Thành Tiền:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(589, 184);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 30);
            this.deleteBtn.TabIndex = 58;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // mienGiamTxt
            // 
            this.mienGiamTxt.AutoSize = true;
            this.mienGiamTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mienGiamTxt.Location = new System.Drawing.Point(875, 45);
            this.mienGiamTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mienGiamTxt.Name = "mienGiamTxt";
            this.mienGiamTxt.Size = new System.Drawing.Size(58, 15);
            this.mienGiamTxt.TabIndex = 99;
            this.mienGiamTxt.Text = "Giảm Trừ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(331, 119);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "Tên Môn Học";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(815, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 98;
            this.label3.Text = "Giảm Trừ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 119);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Mã Môn Học";
            // 
            // hocKyTxt
            // 
            this.hocKyTxt.AutoSize = true;
            this.hocKyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocKyTxt.Location = new System.Drawing.Point(665, 45);
            this.hocKyTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hocKyTxt.Name = "hocKyTxt";
            this.hocKyTxt.Size = new System.Drawing.Size(45, 15);
            this.hocKyTxt.TabIndex = 96;
            this.hocKyTxt.Text = "Học Kỳ";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.textBox3.Location = new System.Drawing.Point(333, 134);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "Học kỳ:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 78;
            // 
            // namHocTxt
            // 
            this.namHocTxt.AutoSize = true;
            this.namHocTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namHocTxt.Location = new System.Drawing.Point(672, 78);
            this.namHocTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namHocTxt.Name = "namHocTxt";
            this.namHocTxt.Size = new System.Drawing.Size(59, 15);
            this.namHocTxt.TabIndex = 94;
            this.namHocTxt.Text = "Năm Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "Năm Học:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(619, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 82;
            this.label4.Text = "Mã Sinh Viên: ";
            // 
            // maSVTxt
            // 
            this.maSVTxt.AutoSize = true;
            this.maSVTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTxt.Location = new System.Drawing.Point(134, 45);
            this.maSVTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maSVTxt.Name = "maSVTxt";
            this.maSVTxt.Size = new System.Drawing.Size(80, 15);
            this.maSVTxt.TabIndex = 83;
            this.maSVTxt.Text = "Mã Sinh Viên";
            // 
            // lopTxt
            // 
            this.lopTxt.AutoSize = true;
            this.lopTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopTxt.Location = new System.Drawing.Point(430, 76);
            this.lopTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lopTxt.Name = "lopTxt";
            this.lopTxt.Size = new System.Drawing.Size(28, 15);
            this.lopTxt.TabIndex = 89;
            this.lopTxt.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 84;
            this.label7.Text = "Tên Sinh Viên: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 88;
            this.label11.Text = "Lớp Hành Chính: ";
            // 
            // tenSVTxt
            // 
            this.tenSVTxt.AutoSize = true;
            this.tenSVTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSVTxt.Location = new System.Drawing.Point(134, 78);
            this.tenSVTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenSVTxt.Name = "tenSVTxt";
            this.tenSVTxt.Size = new System.Drawing.Size(83, 15);
            this.tenSVTxt.TabIndex = 85;
            this.tenSVTxt.Text = "Tên Sinh Viên";
            // 
            // ngaySinhTxt
            // 
            this.ngaySinhTxt.AutoSize = true;
            this.ngaySinhTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhTxt.Location = new System.Drawing.Point(401, 45);
            this.ngaySinhTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngaySinhTxt.Name = "ngaySinhTxt";
            this.ngaySinhTxt.Size = new System.Drawing.Size(63, 15);
            this.ngaySinhTxt.TabIndex = 87;
            this.ngaySinhTxt.Text = "Ngày Sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 86;
            this.label9.Text = "Ngày Sinh: ";
            // 
            // maHoaDonTxt
            // 
            this.maHoaDonTxt.AutoSize = true;
            this.maHoaDonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHoaDonTxt.Location = new System.Drawing.Point(491, 16);
            this.maHoaDonTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maHoaDonTxt.Name = "maHoaDonTxt";
            this.maHoaDonTxt.Size = new System.Drawing.Size(154, 24);
            this.maHoaDonTxt.TabIndex = 142;
            this.maHoaDonTxt.Text = "Chi Tiết Hóa Đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 141;
            this.label10.Text = "Chi Tiết Hóa Đơn:";
            // 
            // ChiTietHoaDonFormXem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 597);
            this.Controls.Add(this.maHoaDonTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.chiTietHoaDonTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChiTietHoaDonFormXem";
            this.Text = "ChiTietHoaDonForm";
            this.Load += new System.EventHandler(this.ChiTietHoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonTable)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView chiTietHoaDonTable;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button baoCaoBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label thanhTienTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label mienGiamTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label hocKyTxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label namHocTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maSVTxt;
        private System.Windows.Forms.Label lopTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ngaySinhTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tenSVTxt;
        private System.Windows.Forms.Label maHoaDonTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ngayLapText;
        private System.Windows.Forms.Label label12;
    }
}