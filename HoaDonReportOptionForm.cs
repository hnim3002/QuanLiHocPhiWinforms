using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HoaDonReportOptionForm : Form
    {
        private string maKhoa;
        private string tenKhoa;
        public HoaDonReportOptionForm(string maKhoa, string tenKhoa)
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
        }

        private void inBaoCaoBtn_Click(object sender, EventArgs e)
        {

            var trangThai = false;
            var hocKy = 0;
            
            MessageBox.Show(tenKhoa);
            string loP = textBoxLop.Text.ToString();
            int namHoc = int.Parse(textBoxNamHoc.Text.ToString());

      
            if (hocKyOption.Text.Equals("1"))
            {
                hocKy = 1;
            } else
            {
                hocKy = 2;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            if (trangThaiOption.Text.Equals("Chưa Nộp"))
            {
                trangThai = false;
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select_HD_LopNamHocKy_TrangThai", connection);

                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Lop", loP));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@NamHoc", namHoc));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Ky", hocKy));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Khoa", tenKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@TrangThai", trangThai));

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Width = this.Width;
                    dataGridView1.DataSource = dataTable;

                    HoaDon_Lop_NamHocReport hoaDon_Lop_NamHocReport = new HoaDon_Lop_NamHocReport();

                    hoaDon_Lop_NamHocReport.SetDataSource(dataTable);

                    HoaDonReoportFormView hoaDonReoportFormView = new HoaDonReoportFormView();

                    hoaDonReoportFormView.crystalReportViewer1.ReportSource = hoaDon_Lop_NamHocReport;
                    hoaDonReoportFormView.Show();
                }
            }
            else if (trangThaiOption.Text.Equals("Đã Nộp"))
            {
                trangThai = true;
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select_HD_LopNamHocKy_TrangThai", connection);

                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Lop", loP));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@NamHoc", namHoc));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Ky", hocKy));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Khoa", tenKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@TrangThai", trangThai));

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Width = this.Width;
                    dataGridView1.DataSource = dataTable;

                    HoaDon_Lop_NamHocReport hoaDon_Lop_NamHocReport = new HoaDon_Lop_NamHocReport();

                    hoaDon_Lop_NamHocReport.SetDataSource(dataTable);

                    HoaDonReoportFormView hoaDonReoportFormView = new HoaDonReoportFormView();

                    hoaDonReoportFormView.crystalReportViewer1.ReportSource = hoaDon_Lop_NamHocReport;
                    hoaDonReoportFormView.Show();
                }
            }
            else
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select_HD_LopNamHocKy", connection);

                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Lop", loP));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@NamHoc", namHoc));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Ky", hocKy));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Khoa", tenKhoa));

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Width = this.Width;
                    dataGridView1.DataSource = dataTable;

                    HoaDon_Lop_NamHocReport hoaDon_Lop_NamHocReport = new HoaDon_Lop_NamHocReport();

                    hoaDon_Lop_NamHocReport.SetDataSource(dataTable);

                    HoaDonReoportFormView hoaDonReoportFormView = new HoaDonReoportFormView();

                    hoaDonReoportFormView.crystalReportViewer1.ReportSource = hoaDon_Lop_NamHocReport;
                    hoaDonReoportFormView.Show();
                }
            }



            

            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
