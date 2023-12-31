﻿namespace WindowsFormsApp2
{
    partial class MonHocForm
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
            this.textBoxTenMon = new System.Windows.Forms.TextBox();
            this.textBoxMaMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monHocNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.monHocTable = new System.Windows.Forms.DataGridView();
            this.tenKhoaTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchMaMon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTenMon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchSoTinChi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.monHocNumberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchSoTinChi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // baoCaoBtn
            // 
            this.baoCaoBtn.Location = new System.Drawing.Point(231, 387);
            this.baoCaoBtn.Name = "baoCaoBtn";
            this.baoCaoBtn.Size = new System.Drawing.Size(159, 37);
            this.baoCaoBtn.TabIndex = 59;
            this.baoCaoBtn.Text = "Báo Cáo";
            this.baoCaoBtn.UseVisualStyleBackColor = true;
            this.baoCaoBtn.Click += new System.EventHandler(this.baoCaoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(28, 387);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(159, 37);
            this.deleteBtn.TabIndex = 58;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(231, 299);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 37);
            this.updateBtn.TabIndex = 57;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(28, 299);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 37);
            this.addBtn.TabIndex = 56;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // textBoxTenMon
            // 
            this.textBoxTenMon.Location = new System.Drawing.Point(122, 129);
            this.textBoxTenMon.Name = "textBoxTenMon";
            this.textBoxTenMon.Size = new System.Drawing.Size(205, 22);
            this.textBoxTenMon.TabIndex = 55;
            // 
            // textBoxMaMon
            // 
            this.textBoxMaMon.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.textBoxMaMon.Location = new System.Drawing.Point(122, 67);
            this.textBoxMaMon.Name = "textBoxMaMon";
            this.textBoxMaMon.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaMon.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã Môn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Số Tín Chỉ";
            // 
            // monHocNumberPicker
            // 
            this.monHocNumberPicker.Location = new System.Drawing.Point(122, 192);
            this.monHocNumberPicker.Name = "monHocNumberPicker";
            this.monHocNumberPicker.Size = new System.Drawing.Size(120, 22);
            this.monHocNumberPicker.TabIndex = 63;
            // 
            // monHocTable
            // 
            this.monHocTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monHocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monHocTable.Location = new System.Drawing.Point(808, 90);
            this.monHocTable.Name = "monHocTable";
            this.monHocTable.RowHeadersWidth = 51;
            this.monHocTable.RowTemplate.Height = 24;
            this.monHocTable.Size = new System.Drawing.Size(555, 633);
            this.monHocTable.TabIndex = 64;
            this.monHocTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.monHocTable_CellClick);
            // 
            // tenKhoaTxt
            // 
            this.tenKhoaTxt.AutoSize = true;
            this.tenKhoaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhoaTxt.Location = new System.Drawing.Point(629, 25);
            this.tenKhoaTxt.Name = "tenKhoaTxt";
            this.tenKhoaTxt.Size = new System.Drawing.Size(105, 29);
            this.tenKhoaTxt.TabIndex = 65;
            this.tenKhoaTxt.Text = "Môn học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Tìm Kiếm ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchMaMon);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.showAllBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchTenMon);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.searchSoTinChi);
            this.panel1.Location = new System.Drawing.Point(461, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 495);
            this.panel1.TabIndex = 66;
            // 
            // searchMaMon
            // 
            this.searchMaMon.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.searchMaMon.Location = new System.Drawing.Point(67, 67);
            this.searchMaMon.Name = "searchMaMon";
            this.searchMaMon.Size = new System.Drawing.Size(205, 22);
            this.searchMaMon.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Mã Môn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(82, 387);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(159, 37);
            this.showAllBtn.TabIndex = 72;
            this.showAllBtn.Text = "Hiện Tất Cả";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tên Môn";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(82, 299);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(159, 37);
            this.searchBtn.TabIndex = 66;
            this.searchBtn.Text = "Tìm Kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTenMon
            // 
            this.searchTenMon.Location = new System.Drawing.Point(67, 129);
            this.searchTenMon.Name = "searchTenMon";
            this.searchTenMon.Size = new System.Drawing.Size(205, 22);
            this.searchTenMon.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Số Tín Chỉ";
            // 
            // searchSoTinChi
            // 
            this.searchSoTinChi.Location = new System.Drawing.Point(67, 192);
            this.searchSoTinChi.Name = "searchSoTinChi";
            this.searchSoTinChi.Size = new System.Drawing.Size(120, 22);
            this.searchSoTinChi.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Thông Tin Môn Học";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxMaMon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxTenMon);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.monHocNumberPicker);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.baoCaoBtn);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 495);
            this.panel2.TabIndex = 70;
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 735);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tenKhoaTxt);
            this.Controls.Add(this.monHocTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonHocForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monHocNumberPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchSoTinChi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baoCaoBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textBoxTenMon;
        private System.Windows.Forms.TextBox textBoxMaMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown monHocNumberPicker;
        private System.Windows.Forms.DataGridView monHocTable;
        private System.Windows.Forms.Label tenKhoaTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchMaMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchTenMon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown searchSoTinChi;
    }
}