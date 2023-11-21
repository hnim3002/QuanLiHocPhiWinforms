namespace WindowsFormsApp2
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sinhVienOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTietHoaDonOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienOpenBtn,
            this.nhanVienOpenBtn,
            this.khoaOpenBtn,
            this.monHocOpenBtn,
            this.hoaDonOpenBtn,
            this.chiTietHoaDonOpenBtn});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1383, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sinhVienOpenBtn
            // 
            this.sinhVienOpenBtn.Name = "sinhVienOpenBtn";
            this.sinhVienOpenBtn.Size = new System.Drawing.Size(84, 24);
            this.sinhVienOpenBtn.Text = "Sinh Viên";
            this.sinhVienOpenBtn.Click += new System.EventHandler(this.sinhVienOpenBtn_Click);
            // 
            // nhanVienOpenBtn
            // 
            this.nhanVienOpenBtn.Name = "nhanVienOpenBtn";
            this.nhanVienOpenBtn.Size = new System.Drawing.Size(91, 24);
            this.nhanVienOpenBtn.Text = "Nhân Viên";
            this.nhanVienOpenBtn.Click += new System.EventHandler(this.nhanVienOpenBtn_Click);
            // 
            // khoaOpenBtn
            // 
            this.khoaOpenBtn.Name = "khoaOpenBtn";
            this.khoaOpenBtn.Size = new System.Drawing.Size(128, 24);
            this.khoaOpenBtn.Text = "Lớp Hành Chính";
            this.khoaOpenBtn.Click += new System.EventHandler(this.khoaOpenBtn_Click);
            // 
            // monHocOpenBtn
            // 
            this.monHocOpenBtn.Name = "monHocOpenBtn";
            this.monHocOpenBtn.Size = new System.Drawing.Size(84, 24);
            this.monHocOpenBtn.Text = "Môn Học";
            this.monHocOpenBtn.Click += new System.EventHandler(this.monHocOpenBtn_Click);
            // 
            // hoaDonOpenBtn
            // 
            this.hoaDonOpenBtn.Name = "hoaDonOpenBtn";
            this.hoaDonOpenBtn.Size = new System.Drawing.Size(83, 24);
            this.hoaDonOpenBtn.Text = "Hóa Đơn";
            this.hoaDonOpenBtn.Click += new System.EventHandler(this.hoaDonOpenBtn_Click);
            // 
            // chiTietHoaDonOpenBtn
            // 
            this.chiTietHoaDonOpenBtn.Name = "chiTietHoaDonOpenBtn";
            this.chiTietHoaDonOpenBtn.Size = new System.Drawing.Size(137, 24);
            this.chiTietHoaDonOpenBtn.Text = "Chi Tiết Hóa Đơn";
            this.chiTietHoaDonOpenBtn.Click += new System.EventHandler(this.chiTietHoaDonOpenBtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 769);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sinhVienOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem nhanVienOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem khoaOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem monHocOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem hoaDonOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem chiTietHoaDonOpenBtn;
    }
}