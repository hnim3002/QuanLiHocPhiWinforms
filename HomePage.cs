using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ChiTietHoaDon;

namespace WindowsFormsApp2
{
    public partial class HomePage : Form
    {
        private string maKhoa;
        private string tenKhoa;
        private string taiKhoan;
        private SinhVienForm sinhVienForm;
        private NhanVienForm nhanVienForm;
        private MonHocForm monHocForm;
        private LopHanhChinhForm khoaForm;
        private HoaDonForm hoaDonForm;
        private HoaDonReportOptionForm hoaDonReportOptionForm;
        private ChiTietHoaDonFormXem chiTietHoaDonForm;
        private SinhVienReportOptionForm sinhVienReportOptionForm;
        private OpenChiTietHoaDon chiTietHoaDonOpen;
        


        public HomePage(string maKhoa, string tenKhoa, string taiKhoan)
        {
            InitializeComponent();
            hideSubBtn();
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.taiKhoan = taiKhoan;
            this.AutoScroll = false;
           
        }

        private void hideSubBtn()
        {
            changePasswordBtn.Visible = false;
            signOutBtn.Visible = false;
        }

        private void showSubBtn()
        {
            changePasswordBtn.Visible = true;
            signOutBtn.Visible = true;
        }

        private void ResizeChildForm(Form childForm)
        {

            childForm.Size = new Size(this.ClientSize.Width - 177 , this.ClientSize.Height - 5);
        }

        public void resetButtonColor()
        {
            if (accountBtn.BackColor == accountBtn.FlatAppearance.MouseOverBackColor)
            {
                accountBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (changePasswordBtn.BackColor == changePasswordBtn.FlatAppearance.MouseOverBackColor)
            {
                changePasswordBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (signOutBtn.BackColor == signOutBtn.FlatAppearance.MouseOverBackColor)
            {
                signOutBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (sinhVienOpenBtn.BackColor == sinhVienOpenBtn.FlatAppearance.MouseOverBackColor)
            {
                sinhVienOpenBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (nhanVienOpenBtn.BackColor == nhanVienOpenBtn.FlatAppearance.MouseOverBackColor)
            {
                nhanVienOpenBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (lopOpenBtn.BackColor == lopOpenBtn.FlatAppearance.MouseOverBackColor)
            {
                lopOpenBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (monHocOpenBtn.BackColor == monHocOpenBtn.FlatAppearance.MouseOverBackColor)
            {
                monHocOpenBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (hoaDonOpenBtn.BackColor == hoaDonOpenBtn.FlatAppearance.MouseOverBackColor)
            {
                hoaDonOpenBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
            else if (chiTietHoaDonOpenBtn.BackColor == chiTietHoaDonOpenBtn.FlatAppearance.MouseOverBackColor)
            {
                chiTietHoaDonOpenBtn.BackColor = Color.FromArgb(41, 128, 185);
            }
        }
        public void changeButtomColor(Button button)
        {
            if (button.BackColor == button.FlatAppearance.MouseOverBackColor)
            {
                button.BackColor = Color.FromArgb(41, 128, 185);
            }
            else
            {
                button.BackColor = button.FlatAppearance.MouseOverBackColor;
            }
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

        

        
        

        private void sinhVienOpenBtn_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            changeButtomColor(sinhVienOpenBtn);
            CloseAllChildForms();
            sinhVienForm = new SinhVienForm(this, maKhoa, tenKhoa);
            sinhVienForm.AutoScroll = false;
            ResizeChildForm(sinhVienForm);
            sinhVienForm.MdiParent = this;
            sinhVienForm.Show();
        }

        private void nhanVienOpenBtn_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            changeButtomColor(nhanVienOpenBtn);
            CloseAllChildForms();
            nhanVienForm = new NhanVienForm(maKhoa, tenKhoa);
            nhanVienForm.AutoScroll = false;
            ResizeChildForm(nhanVienForm);
            nhanVienForm.MdiParent = this;
            nhanVienForm.Show();
        }

        private void lopOpenBtn_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            changeButtomColor(lopOpenBtn);
            CloseAllChildForms();
            khoaForm = new LopHanhChinhForm(maKhoa, tenKhoa);
            khoaForm.AutoScroll = false;

            ResizeChildForm(khoaForm);
            khoaForm.MdiParent = this;
            khoaForm.Show();
        }

        private void monHocOpenBtn_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            changeButtomColor(monHocOpenBtn);
            CloseAllChildForms();
            monHocForm = new MonHocForm(maKhoa, tenKhoa);
            monHocForm.AutoScroll = false;
            ResizeChildForm(monHocForm);
            monHocForm.MdiParent = this;
            monHocForm.Show();
        }

        private void hoaDonOpenBtn_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            changeButtomColor(hoaDonOpenBtn);
            CloseAllChildForms();
            hoaDonForm = new HoaDonForm(this, maKhoa, tenKhoa);
            hoaDonForm.AutoScroll = false;
            ResizeChildForm(hoaDonForm);
            hoaDonForm.MdiParent = this;
            hoaDonForm.Show();
        }

        private void chiTietHoaDonOpenBtn_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            changeButtomColor(chiTietHoaDonOpenBtn);
            CloseAllChildForms();
            chiTietHoaDonOpen = new OpenChiTietHoaDon(this);
            chiTietHoaDonOpen.AutoScroll = false;
            chiTietHoaDonOpen.FormBorderStyle = FormBorderStyle.None;
            ResizeChildForm(chiTietHoaDonOpen);
            chiTietHoaDonOpen.MdiParent = this;
            chiTietHoaDonOpen.Show();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            if (changePasswordBtn.Visible == true) hideSubBtn();
            else if (changePasswordBtn.Visible == false) showSubBtn();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPassword resetPassword = new ResetPassword(maKhoa, tenKhoa, taiKhoan);
            resetPassword.Closed += (s, args) => this.Close();
            resetPassword.Show();
        }

    }

}
