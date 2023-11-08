﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChiTietHoaDonForm : Form
    {
        private string maHD;
        public ChiTietHoaDonForm(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }


       

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();


                SqlDataAdapter dataAdapter_info = new SqlDataAdapter("Select_ChiTietHoaDon_Data", connection);
                dataAdapter_info.TableMappings.Add("Table","ChiTietHoaDon2");
                dataAdapter_info.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter_info.SelectCommand.Parameters.Add(new SqlParameter("@maHD", maHD));
                DataSet dataset = new DataSet();
                dataAdapter_info.Fill(dataset);
                DataTable dataTable = dataset.Tables["ChiTietHoaDon2"];
                maHdText.Text = dataTable.Rows[0]["Mã HĐ"].ToString();
                maSVTxt.Text = dataTable.Rows[0]["Mã SV"].ToString();
                tenSVTxt.Text = dataTable.Rows[0]["Tên Sinh Viên"].ToString();
                lopTxt.Text = dataTable.Rows[0]["Lớp"].ToString();
                khoaTxt.Text = dataTable.Rows[0]["Khoa"].ToString();
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime ngaySinh = (DateTime)dataTable.Rows[0]["Ngày Sinh"];
                ngaySinhTxt.Text = ngaySinh.ToString("dd/MM/yyyy");
                DateTime ngayLap = (DateTime)dataTable.Rows[0]["Ngày Lập"];
                namHocTxt.Text = ngayLap.Year.ToString();
                hocKyTxt.Text = dataTable.Rows[0]["Học Kỳ"].ToString();
                mienGiamTxt.Text = dataTable.Rows[0]["MienGiam"].ToString();
                thanhTienTxt.Text = dataTable.Rows[0]["ThanhTien"].ToString();

                SqlDataAdapter dataAdapter_data = new SqlDataAdapter("Select_CTHD", connection);
                dataAdapter_data.TableMappings.Add("Table", "ChiTietHoaDon");
                dataAdapter_data.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter_data.SelectCommand.Parameters.Add(new SqlParameter("@maHD", maHD));
                DataSet dataset2 = new DataSet();
                dataAdapter_data.Fill(dataset);
                DataTable dataTable2 = dataset.Tables["ChiTietHoaDon"];
                chiTietHoaDonTable.DataSource = dataTable2;
                chiTietHoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baoCaoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select_CTHD_Report", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maHD", maHD));

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                ChiTietHoaDonReport chiTietHoaDonReport = new ChiTietHoaDonReport();
                chiTietHoaDonReport.SetDataSource(dataTable);


                ChiTietHoaDonFormView chiTietHoaDonFormView = new ChiTietHoaDonFormView();
                chiTietHoaDonFormView.crystalReportViewer1.ReportSource = chiTietHoaDonReport;

                chiTietHoaDonFormView.Show();

                
                

            }
        }

        
    }
}
