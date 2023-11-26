using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ChiTietHoaDon;
using WindowsFormsApp2.SinhVien;

namespace WindowsFormsApp2
{
    public partial class SinhVienReportOptionForm : Form
    {
        private string maKhoa;
        public SinhVienReportOptionForm(string maKhoa)
        {
            InitializeComponent();
            this.maKhoa = maKhoa;
            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

       
        }

        private void baoCaoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT_SV_REPORT", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Lop", lopComboBox.Text));
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                SinhVienReport sinhVienReport = new SinhVienReport();
                sinhVienReport.SetDataSource(dataTable);
                ReportViewer chiTietHoaDonFormView = new ReportViewer();
                chiTietHoaDonFormView.crystalReportViewer1.ReportSource = sinhVienReport;
                chiTietHoaDonFormView.Show();
            }
        }
    }
}
