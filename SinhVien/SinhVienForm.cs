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

namespace WindowsFormsApp2
{
    public partial class SinhVienForm : Form
    {
        private HomePage homePage;
        private string maKhoa;
        private string tenKhoa;

        public SinhVienForm(HomePage homePage,string maKhoa, string tenKhoa)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FormClosing += ChildForm_FormClosing;

            
        }

       

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            tenKhoaTxt.Text = tenKhoa;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT_SV", connection);
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                dataAdapter.TableMappings.Add("Table", "SinhVien");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["SinhVien"];
                sinhVienTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                sinhVienTable.DataSource = dataTable;
            }


        }

        

       
        private void updateTable()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT_SV", connection);
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                dataAdapter.TableMappings.Add("Table", "SinhVien");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["SinhVien"];
                sinhVienTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                sinhVienTable.Width = this.Width;
                sinhVienTable.DataSource = dataTable;

            }
        }

        

        private void sinhVienTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            textBoxMaSV.Text = sinhVienTable.Rows[row].Cells["Mã Sinh Viên"].Value.ToString();
            textBoxTenSV.Text = sinhVienTable.Rows[row].Cells["Tên Sinh Viên"].Value.ToString();
            textBoxLop.Text = sinhVienTable.Rows[row].Cells["Lớp"].Value.ToString();
            textBoxSoDT.Text = sinhVienTable.Rows[row].Cells["Số ĐT"].Value.ToString();


            if (sinhVienTable.Rows[row].Cells["Giới Tính"].Value.ToString().Equals("Nam"))
            {
                radioBNam.Checked = true;
            }
            else
            {
                radioBNu.Checked = true;
            }


            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime NgaySinh = (DateTime)sinhVienTable.Rows[row].Cells["Ngày Sinh"].Value;

            dateTimePicker.Value = NgaySinh;
        }

       
       

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(searchMaSV.Text))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_SV_MaSV", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.TableMappings.Add("Table", "SinhVien");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["SinhVien"];
                    sinhVienTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    sinhVienTable.DataSource = dataTable;
                }
            }
            else if(!string.IsNullOrEmpty(searchTenSV.Text) && string.IsNullOrEmpty(searchLop.Text))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_SV_TenSV", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@tenSV", searchTenSV.Text));
                    dataAdapter.TableMappings.Add("Table", "SinhVien");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["SinhVien"];
                    sinhVienTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    sinhVienTable.DataSource = dataTable;
                }
            }
            else if(string.IsNullOrEmpty(searchTenSV.Text) && !string.IsNullOrEmpty(searchLop.Text))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_SV_Lop", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Lop", searchLop.Text));
                    dataAdapter.TableMappings.Add("Table", "SinhVien");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["SinhVien"];
                    sinhVienTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    sinhVienTable.DataSource = dataTable;
                }
            }
            else if(!string.IsNullOrEmpty(searchTenSV.Text) && !string.IsNullOrEmpty(searchLop.Text))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_SV_TenSV_Lop", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@tenSV", searchTenSV.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Lop", searchLop.Text));
                    dataAdapter.TableMappings.Add("Table", "SinhVien");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["SinhVien"];
                    sinhVienTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    sinhVienTable.DataSource = dataTable;
                }
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void baoCaoBtn_Click(object sender, EventArgs e)
        {
            homePage.openSinhVienOptionForm();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            bool gioiTinh = true;
            string maSV, tenSV;

            maSV = textBoxMaSV.Text.ToString();
            tenSV = textBoxTenSV.Text;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime NgaySinh = DateTime.ParseExact(dateTimePicker.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", provider);
            if (radioBNam.Checked)
            {
                gioiTinh = true;
            }
            else if (radioBNu.Checked)
            {
                gioiTinh = false;
            }
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            using (connection)
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "INSERT_SV";
                    command.Parameters.Add(new SqlParameter("@maSV", maSV));
                    command.Parameters.Add(new SqlParameter("@TenSV", tenSV));
                    command.Parameters.Add(new SqlParameter("@GT", gioiTinh));
                    command.Parameters.Add(new SqlParameter("@Ns", NgaySinh));
                    command.Parameters.Add(new SqlParameter("@Mak", maKhoa));
                    command.Parameters.Add(new SqlParameter("@Lop", textBoxLop.Text));
                    command.Parameters.Add(new SqlParameter("@soDT", textBoxSoDT.Text));

                    command.ExecuteNonQuery();
                }
            }

            updateTable();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            bool gioiTinh = true;
            string maSV, tenSV, lopHC;
            lopHC = textBoxLop.Text;
            maSV = textBoxMaSV.Text;
            tenSV = textBoxTenSV.Text;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime NgaySinh = DateTime.ParseExact(dateTimePicker.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", provider);
            if (radioBNam.Checked)
            {
                gioiTinh = true;
            }
            else if (radioBNu.Checked)
            {
                gioiTinh = false;
            }

            SqlConnection connection = new SqlConnection();


            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UPDATE_SV";
                    command.Parameters.Add(new SqlParameter("@maSV", maSV));
                    command.Parameters.Add(new SqlParameter("@TenSV", tenSV));
                    command.Parameters.Add(new SqlParameter("@GT", gioiTinh));
                    command.Parameters.Add(new SqlParameter("@Ns", NgaySinh));
                    command.Parameters.Add(new SqlParameter("@Lop", lopHC));
                    command.Parameters.Add(new SqlParameter("@soDT", textBoxSoDT.Text));
                    command.ExecuteNonQuery();
                }
            }
            updateTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string maSV;
            maSV = textBoxMaSV.Text;
            SqlConnection connection = new SqlConnection();


            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "delete_SV";
                    command.Parameters.Add(new SqlParameter("@ma", maSV));
                    command.ExecuteNonQuery();
                }
            }
            updateTable();
        }
    }
}
