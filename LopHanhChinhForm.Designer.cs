namespace WindowsFormsApp2
{
    partial class LopHanhChinhForm
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.khoaTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tenKhoaTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khoaTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(141, 253);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(159, 37);
            this.deleteBtn.TabIndex = 49;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(244, 170);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 37);
            this.updateBtn.TabIndex = 48;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(25, 170);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 37);
            this.addBtn.TabIndex = 47;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.textBoxMaNV.Location = new System.Drawing.Point(115, 84);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaNV.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên Lớp Hành Chính";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // khoaTable
            // 
            this.khoaTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khoaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khoaTable.Location = new System.Drawing.Point(642, 86);
            this.khoaTable.Name = "khoaTable";
            this.khoaTable.RowHeadersWidth = 51;
            this.khoaTable.RowTemplate.Height = 24;
            this.khoaTable.Size = new System.Drawing.Size(721, 637);
            this.khoaTable.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Thông Tin Lớp Hành Chính";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxMaNV);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Location = new System.Drawing.Point(90, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 329);
            this.panel2.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Tìm Kiếm ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(90, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 286);
            this.panel1.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên Lớp Hành Chính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(132, 177);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(159, 37);
            this.searchBtn.TabIndex = 66;
            this.searchBtn.Text = "Tìm Kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.textBox1.Location = new System.Drawing.Point(115, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 52;
            // 
            // tenKhoaTxt
            // 
            this.tenKhoaTxt.AutoSize = true;
            this.tenKhoaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhoaTxt.Location = new System.Drawing.Point(651, 21);
            this.tenKhoaTxt.Name = "tenKhoaTxt";
            this.tenKhoaTxt.Size = new System.Drawing.Size(54, 29);
            this.tenKhoaTxt.TabIndex = 77;
            this.tenKhoaTxt.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "Lớp Khoa:";
            // 
            // LopHanhChinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 735);
            this.Controls.Add(this.tenKhoaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.khoaTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LopHanhChinhForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KhoaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView khoaTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tenKhoaTxt;
        private System.Windows.Forms.Label label1;
    }
}