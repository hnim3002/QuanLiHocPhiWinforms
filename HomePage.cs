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
        private LopHanhChinhForm khoaForm;
        private HoaDonForm hoaDonForm;
        private HoaDonReportOptionForm hoaDonReportOptionForm;
        private ChiTietHoaDonFormXem chiTietHoaDonForm;
        private SinhVienReportOptionForm sinhVienReportOptionForm;
        


        public HomePage(string maKhoa, string tenKhoa)
        {
            InitializeComponent();
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.AutoScroll = false;
           
        }

        private void ResizeChildForm(Form childForm)
        {
           
            childForm.Size = new Size(this.ClientSize.Width - 4, this.ClientSize.Height-28);
            

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
            ResizeChildForm(sinhVienReportOptionForm);

        }

        private void sinhVienOpenBtn_Click(object sender, EventArgs e)
        {

            CloseAllChildForms();
            sinhVienForm = new SinhVienForm(this, maKhoa, tenKhoa);
            sinhVienForm.AutoScroll = false;
            
            ResizeChildForm(sinhVienForm);
            
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
        
        }
     

        private void nhanVienOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            nhanVienForm = new NhanVienForm(maKhoa, tenKhoa);
            nhanVienForm.AutoScroll = false;
          
            ResizeChildForm(nhanVienForm);
            nhanVienForm.MdiParent = this;
            nhanVienForm.Show();
        }

        private void monHocOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            monHocForm = new MonHocForm(maKhoa, tenKhoa);
            monHocForm.AutoScroll = false;
            
            ResizeChildForm(monHocForm);
           
            monHocForm.MdiParent = this;
            monHocForm.Show();
        }

        private void khoaOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            khoaForm = new LopHanhChinhForm(maKhoa, tenKhoa);
            khoaForm.AutoScroll = false;
            
            ResizeChildForm(khoaForm);
            khoaForm.MdiParent = this;
            khoaForm.Show();
        }

        private void hoaDonOpenBtn_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            hoaDonForm = new HoaDonForm(this, maKhoa, tenKhoa);
            hoaDonForm.AutoScroll = false;
            
            ResizeChildForm(hoaDonForm);
            hoaDonForm.MdiParent = this;
            hoaDonForm.Show();
        }

        public void openHoaDonReportOptinForm()
        {
            hoaDonReportOptionForm = new HoaDonReportOptionForm(maKhoa, tenKhoa);
            hoaDonReportOptionForm.AutoScroll = false;
            
            ResizeChildForm(hoaDonReportOptionForm);
            hoaDonReportOptionForm.MdiParent = this;
            hoaDonReportOptionForm.Show();

        }

        public void openChiTietHoaDon(string maHD)
        {
            chiTietHoaDonForm = new ChiTietHoaDonFormXem(maHD);
            chiTietHoaDonForm.AutoScroll = false;
            
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

        public void openSinhVienOptionForm()
        {
            sinhVienReportOptionForm = new SinhVienReportOptionForm(maKhoa);
            sinhVienReportOptionForm.AutoScroll = false;

            ResizeChildForm(sinhVienReportOptionForm);
            sinhVienReportOptionForm.MdiParent = this;
            sinhVienReportOptionForm.Show();
        }

        

        private void chiTietHoaDonOpenBtn_Click(object sender, EventArgs e)
        {

            ReportViewer hoaDonReoportFormView = new ReportViewer();

           
            hoaDonReoportFormView.Show();
            //CloseAllChildForms();
            //ChiTietHoaDonFormEdit = new ChiTietHoaDonFormEdit(maHD);
            //ChiTietHoaDonFormEdit.AutoScroll = false;
            //ChiTietHoaDonFormEdit.FormBorderStyle = FormBorderStyle.None;
            //ResizeChildForm(ChiTietHoaDonFormEdit);
            //ChiTietHoaDonFormEdit.MdiParent = this;
            //ChiTietHoaDonFormEdit.Show();
        }
    }

}
