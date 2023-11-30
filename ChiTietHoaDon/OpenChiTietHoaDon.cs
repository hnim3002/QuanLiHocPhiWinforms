using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.ChiTietHoaDon
{
    public partial class OpenChiTietHoaDon : Form
    {
        private HomePage homePage;
        public OpenChiTietHoaDon(HomePage homePage)
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.homePage = homePage;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã hoá đơn");
                return;
            }
            homePage.openChiTietHoaDon(textBoxMaHD.Text);
        }

        private void enter_print_CTHD(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBoxMaHD.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập mã hoá đơn");
                } else
                {
                    openBtn.PerformClick();
                }
            }
        }
    }
}
