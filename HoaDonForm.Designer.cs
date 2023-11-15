﻿namespace WindowsFormsApp2
{
    partial class HoaDonForm
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
            this.dateTimeNgayLap = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hoaDonTable = new System.Windows.Forms.DataGridView();
            this.radioButtonChuaNop = new System.Windows.Forms.RadioButton();
            this.radioButtonDaNop = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tenKhoaTxt = new System.Windows.Forms.Label();
            this.textBoxNamHoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hocKyOption = new System.Windows.Forms.ComboBox();
            this.numberBoxMienGiam = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxMienGiam)).BeginInit();
            this.SuspendLayout();
            // 
            // baoCaoBtn
            // 
            this.baoCaoBtn.Location = new System.Drawing.Point(789, 234);
            this.baoCaoBtn.Name = "baoCaoBtn";
            this.baoCaoBtn.Size = new System.Drawing.Size(159, 37);
            this.baoCaoBtn.TabIndex = 35;
            this.baoCaoBtn.Text = "Báo Cáo";
            this.baoCaoBtn.UseVisualStyleBackColor = true;
            this.baoCaoBtn.Click += new System.EventHandler(this.baoCaoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(547, 234);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(159, 37);
            this.deleteBtn.TabIndex = 34;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(291, 234);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 37);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(39, 234);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 37);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dateTimeNgayLap
            // 
            this.dateTimeNgayLap.Location = new System.Drawing.Point(519, 104);
            this.dateTimeNgayLap.Name = "dateTimeNgayLap";
            this.dateTimeNgayLap.Size = new System.Drawing.Size(200, 22);
            this.dateTimeNgayLap.TabIndex = 31;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(156, 183);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaNV.TabIndex = 28;
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Location = new System.Drawing.Point(156, 141);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaSV.TabIndex = 27;
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.textBoxMaHD.Location = new System.Drawing.Point(156, 98);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaHD.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Trạng Thái ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Hóa Đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Danh Sách Hóa Đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Miễn Giảm ";
            // 
            // hoaDonTable
            // 
            this.hoaDonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoaDonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonTable.Location = new System.Drawing.Point(12, 299);
            this.hoaDonTable.Name = "hoaDonTable";
            this.hoaDonTable.RowHeadersWidth = 51;
            this.hoaDonTable.RowTemplate.Height = 24;
            this.hoaDonTable.Size = new System.Drawing.Size(1012, 278);
            this.hoaDonTable.TabIndex = 41;
            // 
            // radioButtonChuaNop
            // 
            this.radioButtonChuaNop.AutoSize = true;
            this.radioButtonChuaNop.Location = new System.Drawing.Point(874, 118);
            this.radioButtonChuaNop.Name = "radioButtonChuaNop";
            this.radioButtonChuaNop.Size = new System.Drawing.Size(88, 20);
            this.radioButtonChuaNop.TabIndex = 42;
            this.radioButtonChuaNop.TabStop = true;
            this.radioButtonChuaNop.Text = "Chưa Nộp";
            this.radioButtonChuaNop.UseVisualStyleBackColor = true;
            // 
            // radioButtonDaNop
            // 
            this.radioButtonDaNop.AutoSize = true;
            this.radioButtonDaNop.Location = new System.Drawing.Point(874, 92);
            this.radioButtonDaNop.Name = "radioButtonDaNop";
            this.radioButtonDaNop.Size = new System.Drawing.Size(74, 20);
            this.radioButtonDaNop.TabIndex = 43;
            this.radioButtonDaNop.TabStop = true;
            this.radioButtonDaNop.Text = "Đã Nộp";
            this.radioButtonDaNop.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(781, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Học Kỳ";
            // 
            // tenKhoaTxt
            // 
            this.tenKhoaTxt.AutoSize = true;
            this.tenKhoaTxt.Location = new System.Drawing.Point(473, 29);
            this.tenKhoaTxt.Name = "tenKhoaTxt";
            this.tenKhoaTxt.Size = new System.Drawing.Size(129, 16);
            this.tenKhoaTxt.TabIndex = 46;
            this.tenKhoaTxt.Text = "Danh Sách Hóa Đơn";
            // 
            // textBoxNamHoc
            // 
            this.textBoxNamHoc.Location = new System.Drawing.Point(519, 186);
            this.textBoxNamHoc.Name = "textBoxNamHoc";
            this.textBoxNamHoc.Size = new System.Drawing.Size(205, 22);
            this.textBoxNamHoc.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Năm Học";
            // 
            // hocKyOption
            // 
            this.hocKyOption.FormattingEnabled = true;
            this.hocKyOption.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.hocKyOption.Location = new System.Drawing.Point(874, 150);
            this.hocKyOption.Name = "hocKyOption";
            this.hocKyOption.Size = new System.Drawing.Size(83, 24);
            this.hocKyOption.TabIndex = 62;
            // 
            // numberBoxMienGiam
            // 
            this.numberBoxMienGiam.Location = new System.Drawing.Point(519, 147);
            this.numberBoxMienGiam.Name = "numberBoxMienGiam";
            this.numberBoxMienGiam.Size = new System.Drawing.Size(120, 22);
            this.numberBoxMienGiam.TabIndex = 63;
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 589);
            this.Controls.Add(this.numberBoxMienGiam);
            this.Controls.Add(this.hocKyOption);
            this.Controls.Add(this.textBoxNamHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tenKhoaTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonDaNop);
            this.Controls.Add(this.radioButtonChuaNop);
            this.Controls.Add(this.hoaDonTable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.baoCaoBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dateTimeNgayLap);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.textBoxMaSV);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxMienGiam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baoCaoBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DateTimePicker dateTimeNgayLap;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView hoaDonTable;
        private System.Windows.Forms.RadioButton radioButtonChuaNop;
        private System.Windows.Forms.RadioButton radioButtonDaNop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tenKhoaTxt;
        private System.Windows.Forms.TextBox textBoxNamHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox hocKyOption;
        private System.Windows.Forms.NumericUpDown numberBoxMienGiam;
    }
}