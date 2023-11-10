using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HomePage : Form
    {
        private string maKhoa;
        private string tenKhoa;
        private SinhVienForm sinhVienForm;
        private NhanVienForm nhanVienForm;
        private MonHocForm monHocForm;
        private KhoaForm khoaForm;
        private HoaDonForm hoaDonForm;
        private HoaDonReportOptionForm hoaDonReportOptionForm;
        private ChiTietHoaDonFormXem chiTietHoaDonForm;


        public HomePage(string maKhoa, string tenKhoa)
        {
            InitializeComponent();
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
        }

        private void ResizeChildForm(Form childForm)
        {
            childForm.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }


        private void ParentForm_Resize(object sender, EventArgs e)
        {
            // Resize the child form.
            ResizeChildForm(sinhVienForm);
            ResizeChildForm(nhanVienForm);
            ResizeChildForm(monHocForm);
            ResizeChildForm(khoaForm);
            ResizeChildForm(hoaDonForm);
            ResizeChildForm(hoaDonReportOptionForm);
            ResizeChildForm(chiTietHoaDonForm);

           
        }

        private void sinhVienOpenBtn_Click(object sender, EventArgs e)
        {

            CloseAllChildForms();
            sinhVienForm = new SinhVienForm(maKhoa, tenKhoa);
            sinhVienForm.AutoScroll = false;          
            ResizeChildForm(sinhVienForm);
            sinhVienForm.FormBorderStyle = FormBorderStyle.None;
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
        
        }
     

        private void nhanVienOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            nhanVienForm = new NhanVienForm();
            nhanVienForm.AutoScroll = false;
            nhanVienForm.FormBorderStyle = FormBorderStyle.None;
            ResizeChildForm(nhanVienForm);
            nhanVienForm.MdiParent = this;
            nhanVienForm.Show();
        }

        private void monHocOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            monHocForm = new MonHocForm();
            monHocForm.AutoScroll = false;
            
            ResizeChildForm(monHocForm);
            monHocForm.FormBorderStyle = FormBorderStyle.None;
            monHocForm.MdiParent = this;
            monHocForm.Show();
        }

        private void khoaOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            khoaForm = new KhoaForm();
            khoaForm.AutoScroll = false;
            khoaForm.FormBorderStyle = FormBorderStyle.None;
            ResizeChildForm(khoaForm);
            khoaForm.MdiParent = this;
            khoaForm.Show();
        }

        private void hoaDonOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            hoaDonForm = new HoaDonForm(this);
            hoaDonForm.AutoScroll = false;
            hoaDonForm.FormBorderStyle= FormBorderStyle.None;
            ResizeChildForm(hoaDonForm);
            hoaDonForm.MdiParent = this;
            hoaDonForm.Show();
        }

        public void openHoaDonReportOptinForm()
        {
            hoaDonReportOptionForm = new HoaDonReportOptionForm();
            hoaDonReportOptionForm.AutoScroll = false;
            hoaDonReportOptionForm.FormBorderStyle = FormBorderStyle.None;
            ResizeChildForm(hoaDonReportOptionForm);
            hoaDonReportOptionForm.MdiParent = this;
            hoaDonReportOptionForm.Show();

        }

        public void openChiTietHoaDon(string maHD)
        {
            chiTietHoaDonForm = new ChiTietHoaDonFormXem(maHD);
            chiTietHoaDonForm.AutoScroll = false;
            chiTietHoaDonForm.FormBorderStyle = FormBorderStyle.None;
            ResizeChildForm(chiTietHoaDonForm);
            chiTietHoaDonForm.MdiParent = this;
            chiTietHoaDonForm.Show();
        }

        private void CloseAllChildForms()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            hoaDonReportOptionForm = new HoaDonReportOptionForm();
            hoaDonReportOptionForm.AutoScroll = false;
            hoaDonReportOptionForm.FormBorderStyle = FormBorderStyle.None;
            ResizeChildForm(hoaDonReportOptionForm);
            hoaDonReportOptionForm.MdiParent = this;
            hoaDonReportOptionForm.Show();
        }
    }

}
