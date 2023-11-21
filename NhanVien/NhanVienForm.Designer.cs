namespace WindowsFormsApp2
{
    partial class NhanVienForm
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
            this.nhanVienTable = new System.Windows.Forms.DataGridView();
            this.tenKhoaTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.textBoxSoDT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioBNam = new System.Windows.Forms.RadioButton();
            this.radioBNu = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.baoCaoBtn = new System.Windows.Forms.Button();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.textBoxCCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.searchTenSV = new System.Windows.Forms.TextBox();
            this.searchMaNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTable)).BeginInit();
            this.panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên Khoa:";
            // 
            // nhanVienTable
            // 
            this.nhanVienTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nhanVienTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienTable.Location = new System.Drawing.Point(12, 404);
            this.nhanVienTable.Name = "nhanVienTable";
            this.nhanVienTable.RowHeadersWidth = 51;
            this.nhanVienTable.RowTemplate.Height = 24;
            this.nhanVienTable.Size = new System.Drawing.Size(1351, 319);
            this.nhanVienTable.TabIndex = 33;
            this.nhanVienTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhanVienTable_CellClick);
            // 
            // tenKhoaTxt
            // 
            this.tenKhoaTxt.AutoSize = true;
            this.tenKhoaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhoaTxt.Location = new System.Drawing.Point(665, 18);
            this.tenKhoaTxt.Name = "tenKhoaTxt";
            this.tenKhoaTxt.Size = new System.Drawing.Size(186, 29);
            this.tenKhoaTxt.TabIndex = 34;
            this.tenKhoaTxt.Text = "Nhân Viên Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Thông Tin Nhân Viên";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.textBoxSoDT);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.baoCaoBtn);
            this.panel.Controls.Add(this.textBoxMaNV);
            this.panel.Controls.Add(this.deleteBtn);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.updateBtn);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.addBtn);
            this.panel.Controls.Add(this.textBoxCCCD);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.textBoxTenNV);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Location = new System.Drawing.Point(12, 68);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(936, 315);
            this.panel.TabIndex = 35;
            // 
            // textBoxSoDT
            // 
            this.textBoxSoDT.Location = new System.Drawing.Point(677, 133);
            this.textBoxSoDT.Name = "textBoxSoDT";
            this.textBoxSoDT.Size = new System.Drawing.Size(205, 22);
            this.textBoxSoDT.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(674, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 68;
            this.label11.Text = "Số Điện Thoại";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioBNam);
            this.panel3.Controls.Add(this.radioBNu);
            this.panel3.Location = new System.Drawing.Point(394, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 30);
            this.panel3.TabIndex = 67;
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
            this.radioBNu.Location = new System.Drawing.Point(75, 5);
            this.radioBNu.Name = "radioBNu";
            this.radioBNu.Size = new System.Drawing.Size(45, 20);
            this.radioBNu.TabIndex = 29;
            this.radioBNu.TabStop = true;
            this.radioBNu.Text = "Nữ";
            this.radioBNu.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 66;
            this.label12.Text = "Giới Tính";
            // 
            // baoCaoBtn
            // 
            this.baoCaoBtn.Location = new System.Drawing.Point(743, 238);
            this.baoCaoBtn.Name = "baoCaoBtn";
            this.baoCaoBtn.Size = new System.Drawing.Size(159, 37);
            this.baoCaoBtn.TabIndex = 51;
            this.baoCaoBtn.Text = "Báo Cáo";
            this.baoCaoBtn.UseVisualStyleBackColor = true;
            this.baoCaoBtn.Click += new System.EventHandler(this.baoCaoBtn_Click);
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.textBoxMaNV.Location = new System.Drawing.Point(69, 67);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaNV.TabIndex = 41;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(512, 238);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(159, 37);
            this.deleteBtn.TabIndex = 50;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã Nhân Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(270, 238);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 37);
            this.updateBtn.TabIndex = 49;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 238);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 37);
            this.addBtn.TabIndex = 48;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // textBoxCCCD
            // 
            this.textBoxCCCD.Location = new System.Drawing.Point(677, 67);
            this.textBoxCCCD.Name = "textBoxCCCD";
            this.textBoxCCCD.Size = new System.Drawing.Size(205, 22);
            this.textBoxCCCD.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "CCCD";
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.Location = new System.Drawing.Point(69, 125);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(205, 22);
            this.textBoxTenNV.TabIndex = 42;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(394, 67);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(996, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tìm Kiếm ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showAllBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchNgaySinh);
            this.panel1.Controls.Add(this.searchTenSV);
            this.panel1.Controls.Add(this.searchMaNV);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(968, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 315);
            this.panel1.TabIndex = 37;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(30, 238);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(159, 37);
            this.showAllBtn.TabIndex = 71;
            this.showAllBtn.Text = "Hiện Tất Cả";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ngày Sinh";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(209, 238);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(159, 37);
            this.searchBtn.TabIndex = 66;
            this.searchBtn.Text = "Tìm Kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchNgaySinh
            // 
            this.searchNgaySinh.Location = new System.Drawing.Point(101, 179);
            this.searchNgaySinh.Name = "searchNgaySinh";
            this.searchNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.searchNgaySinh.TabIndex = 69;
            // 
            // searchTenSV
            // 
            this.searchTenSV.Location = new System.Drawing.Point(101, 115);
            this.searchTenSV.Name = "searchTenSV";
            this.searchTenSV.Size = new System.Drawing.Size(205, 22);
            this.searchTenSV.TabIndex = 69;
            // 
            // searchMaNV
            // 
            this.searchMaNV.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.searchMaNV.Location = new System.Drawing.Point(101, 55);
            this.searchMaNV.Name = "searchMaNV";
            this.searchMaNV.Size = new System.Drawing.Size(205, 22);
            this.searchMaNV.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Mã Nhân Viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tên Nhân Viên";
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 735);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tenKhoaTxt);
            this.Controls.Add(this.nhanVienTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVienForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTable)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView nhanVienTable;
        private System.Windows.Forms.Label tenKhoaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button baoCaoBtn;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textBoxCCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTenSV;
        private System.Windows.Forms.TextBox searchMaNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioBNam;
        private System.Windows.Forms.RadioButton radioBNu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker searchNgaySinh;
        private System.Windows.Forms.TextBox textBoxSoDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button showAllBtn;
    }
}