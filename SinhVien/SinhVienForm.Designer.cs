namespace WindowsFormsApp2
{
    partial class SinhVienForm
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
            this.sinhVienTable = new System.Windows.Forms.DataGridView();
            this.tenKhoaTxt = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioBNam = new System.Windows.Forms.RadioButton();
            this.radioBNu = new System.Windows.Forms.RadioButton();
            this.textBoxLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.baoCaoBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxTenSV = new System.Windows.Forms.TextBox();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchLop = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchTenSV = new System.Windows.Forms.TextBox();
            this.searchMaSV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSoDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienTable)).BeginInit();
            this.panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh Viên Khoa:";
            // 
            // sinhVienTable
            // 
            this.sinhVienTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sinhVienTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sinhVienTable.Location = new System.Drawing.Point(12, 395);
            this.sinhVienTable.Name = "sinhVienTable";
            this.sinhVienTable.RowHeadersWidth = 51;
            this.sinhVienTable.RowTemplate.Height = 24;
            this.sinhVienTable.Size = new System.Drawing.Size(1351, 328);
            this.sinhVienTable.TabIndex = 15;
            this.sinhVienTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sinhVienTable_CellClick);
            // 
            // tenKhoaTxt
            // 
            this.tenKhoaTxt.AutoSize = true;
            this.tenKhoaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhoaTxt.Location = new System.Drawing.Point(631, 18);
            this.tenKhoaTxt.Name = "tenKhoaTxt";
            this.tenKhoaTxt.Size = new System.Drawing.Size(177, 29);
            this.tenKhoaTxt.TabIndex = 22;
            this.tenKhoaTxt.Text = "Sinh Viên Khoa";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.textBoxSoDT);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.textBoxLop);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.baoCaoBtn);
            this.panel.Controls.Add(this.deleteBtn);
            this.panel.Controls.Add(this.updateBtn);
            this.panel.Controls.Add(this.addBtn);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Controls.Add(this.textBoxTenSV);
            this.panel.Controls.Add(this.textBoxMaSV);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(12, 64);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(936, 315);
            this.panel.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioBNam);
            this.panel3.Controls.Add(this.radioBNu);
            this.panel3.Location = new System.Drawing.Point(329, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 30);
            this.panel3.TabIndex = 65;
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
            // textBoxLop
            // 
            this.textBoxLop.Location = new System.Drawing.Point(600, 65);
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.Size = new System.Drawing.Size(205, 22);
            this.textBoxLop.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Lớp";
            // 
            // baoCaoBtn
            // 
            this.baoCaoBtn.Location = new System.Drawing.Point(731, 253);
            this.baoCaoBtn.Name = "baoCaoBtn";
            this.baoCaoBtn.Size = new System.Drawing.Size(159, 37);
            this.baoCaoBtn.TabIndex = 62;
            this.baoCaoBtn.Text = "Báo Cáo";
            this.baoCaoBtn.UseVisualStyleBackColor = true;
            this.baoCaoBtn.Click += new System.EventHandler(this.baoCaoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(511, 253);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(159, 37);
            this.deleteBtn.TabIndex = 61;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(277, 253);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 37);
            this.updateBtn.TabIndex = 60;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(37, 253);
            this.addBtn.Name = "addBtn";
            this.addBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addBtn.Size = new System.Drawing.Size(159, 37);
            this.addBtn.TabIndex = 59;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(326, 65);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 58;
            // 
            // textBoxTenSV
            // 
            this.textBoxTenSV.Location = new System.Drawing.Point(60, 123);
            this.textBoxTenSV.Name = "textBoxTenSV";
            this.textBoxTenSV.Size = new System.Drawing.Size(205, 22);
            this.textBoxTenSV.TabIndex = 57;
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMaSV.Location = new System.Drawing.Point(60, 65);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaSV.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã Sinh Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Thông Tin Sinh Viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(996, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tìm Kiếm ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showAllBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchLop);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.searchTenSV);
            this.panel1.Controls.Add(this.searchMaSV);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(968, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 315);
            this.panel1.TabIndex = 29;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(31, 253);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(159, 37);
            this.showAllBtn.TabIndex = 70;
            this.showAllBtn.Text = "Hiện Tất Cả";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(216, 253);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(159, 37);
            this.searchBtn.TabIndex = 66;
            this.searchBtn.Text = "Tìm Kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchLop
            // 
            this.searchLop.Location = new System.Drawing.Point(101, 179);
            this.searchLop.Name = "searchLop";
            this.searchLop.Size = new System.Drawing.Size(205, 22);
            this.searchLop.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "Lớp";
            // 
            // searchTenSV
            // 
            this.searchTenSV.Location = new System.Drawing.Point(101, 113);
            this.searchTenSV.Name = "searchTenSV";
            this.searchTenSV.Size = new System.Drawing.Size(205, 22);
            this.searchTenSV.TabIndex = 69;
            // 
            // searchMaSV
            // 
            this.searchMaSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchMaSV.Location = new System.Drawing.Point(101, 55);
            this.searchMaSV.Name = "searchMaSV";
            this.searchMaSV.Size = new System.Drawing.Size(205, 22);
            this.searchMaSV.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Mã Sinh Viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tên Sinh Viên";
            // 
            // textBoxSoDT
            // 
            this.textBoxSoDT.Location = new System.Drawing.Point(600, 123);
            this.textBoxSoDT.Name = "textBoxSoDT";
            this.textBoxSoDT.Size = new System.Drawing.Size(205, 22);
            this.textBoxSoDT.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(597, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 66;
            this.label12.Text = "Số Điện Thoại";
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 735);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tenKhoaTxt);
            this.Controls.Add(this.sinhVienTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinhVienForm";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienTable)).EndInit();
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
        private System.Windows.Forms.DataGridView sinhVienTable;
        private System.Windows.Forms.Label tenKhoaTxt;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioBNam;
        private System.Windows.Forms.RadioButton radioBNu;
        private System.Windows.Forms.TextBox textBoxLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button baoCaoBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxTenSV;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchLop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchTenSV;
        private System.Windows.Forms.TextBox searchMaSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.TextBox textBoxSoDT;
        private System.Windows.Forms.Label label12;
    }
}

