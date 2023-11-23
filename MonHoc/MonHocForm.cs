using System;
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
using WindowsFormsApp2.MonHoc;
using WindowsFormsApp2.NhanVien;

namespace WindowsFormsApp2
{
    public partial class MonHocForm : Form
    {
        private string maKhoa;
        private string tenKhoa;
        public MonHocForm(string maKhoa, string tenKhoa)
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

        private void MonHoc_Load(object sender, EventArgs e)
        {
            tenKhoaTxt.Text = tenKhoa;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select_MonHoc", connection);
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                dataAdapter.TableMappings.Add("Table", "MonHoc");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["MonHoc"];

                monHocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                monHocTable.DataSource = dataTable;
            }
        }

        private void updateTable()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select_MonHoc", connection);
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                dataAdapter.TableMappings.Add("Table", "MonHoc");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["MonHoc"];
                monHocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                monHocTable.DataSource = dataTable;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int soTin = (int)monHocNumberPicker.Value;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            using (connection)
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "insert_MonHoc";
                    command.Parameters.Add(new SqlParameter("@maBM", textBoxMaMon.Text));
                    command.Parameters.Add(new SqlParameter("@tenBM", textBoxTenMon.Text));
                    command.Parameters.Add(new SqlParameter("@Sotin", (int)monHocNumberPicker.Value));
                    command.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    command.ExecuteNonQuery();
                }
            }

            updateTable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "update_MonHoc";
                    command.Parameters.Add(new SqlParameter("@maBM", textBoxMaMon.Text));
                    command.Parameters.Add(new SqlParameter("@tenBM", textBoxTenMon.Text));
                    command.Parameters.Add(new SqlParameter("@Sotin", (int)monHocNumberPicker.Value));
                    command.ExecuteNonQuery();
                }
            }
            updateTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "delete_MonHoc";
                    command.Parameters.Add(new SqlParameter("@maBM", textBoxMaMon));
                    command.ExecuteNonQuery();
                }
            }
            updateTable();
        }

        private void monHocTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            textBoxMaMon.Text = monHocTable.Rows[row].Cells["Mã Môn Học"].Value.ToString();
            textBoxTenMon.Text = monHocTable.Rows[row].Cells["Tên Môn Học"].Value.ToString();
            monHocNumberPicker.Value = (int)monHocTable.Rows[row].Cells["Số Tín Chỉ"].Value;
            
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(searchMaMon.Text))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("search_MonHoc_MaMon", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maBM", searchMaMon.Text));
                    dataAdapter.TableMappings.Add("Table", "MonHoc");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["MonHoc"];
                    monHocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    monHocTable.DataSource = dataTable;
                }
            }
            else if(!string.IsNullOrEmpty(searchTenMon.Text))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("search_MonHoc_TenMon", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@tenBM", searchTenMon.Text));
                    dataAdapter.TableMappings.Add("Table", "MonHoc");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["MonHoc"];
                    monHocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    monHocTable.DataSource = dataTable;
                }
            }
            else if (!string.IsNullOrEmpty(searchSoTinChi.Text))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("search_MonHoc_TinChi", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@soTin", searchSoTinChi.Value));
                    dataAdapter.TableMappings.Add("Table", "MonHoc");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["MonHoc"];
                    monHocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    monHocTable.DataSource = dataTable;
                }
            }
        }

        private void baoCaoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("search_MonHoc_Report", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                MonHocReport monHocReport = new MonHocReport();
                monHocReport.SetDataSource(dataTable);
                ReportViewer chiTietHoaDonFormView = new ReportViewer();
                chiTietHoaDonFormView.crystalReportViewer1.ReportSource = monHocReport;
                chiTietHoaDonFormView.Show();
            }
        }
    }
}
