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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HoaDonForm : Form
    {

        private HomePage homePage;
        private string maKhoa;
        private string tenKhoa;
        public HoaDonForm(HomePage homePage, string maKhoa, string tenKhoa)
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.homePage = homePage;
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;  
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            tenKhoaTxt.Text = tenKhoa;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select_HD", connection);
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                dataAdapter.TableMappings.Add("Table", "HoaDon");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["HoaDon"];
                hoaDonTable.DataSource = dataTable;

                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Text = "Xem Chi Tiết";
                buttonColumn.Name = "";
                buttonColumn.UseColumnTextForButtonValue = true;
                if (hoaDonTable.Columns[""] == null)
                {
                    hoaDonTable.Columns.Insert(11, buttonColumn);
                }
                hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                hoaDonTable.CellContentClick += new DataGridViewCellEventHandler(hoaDonTable_CellContentClick);

            }
        }

        private void updateTable()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select_HD", connection);
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                dataAdapter.TableMappings.Add("Table", "HoaDon");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["HoaDon"];
                hoaDonTable.DataSource = dataTable;

                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Text = "Xem Chi Tiết";
                buttonColumn.Name = "";
                buttonColumn.UseColumnTextForButtonValue = true;
                if (hoaDonTable.Columns[""] == null)
                {
                    hoaDonTable.Columns.Insert(11, buttonColumn);
                }
                hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                hoaDonTable.CellContentClick += new DataGridViewCellEventHandler(hoaDonTable_CellContentClick);

            }
        }

        private void hoaDonTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            if (e.ColumnIndex == hoaDonTable.Columns[""].Index)
            {
                string maHD = hoaDonTable.Rows[row].Cells["Mã HĐ"].Value.ToString();
 
                homePage.openChiTietHoaDon(maHD);
            }
        }

        private void baoCaoBtn_Click(object sender, EventArgs e)
        {
            homePage.openHoaDonReportOptinForm();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool trangThai = false;
            
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime NgayLap = DateTime.ParseExact(dateTimeNgayLap.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", provider);
            if (radioButtonDaNop.Checked)
            {
                trangThai = true;
            }
            else if (radioButtonChuaNop.Checked)
            {
                trangThai = false;
            }
            
            if (checkMaSV())
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "insert_HD";
                        command.Parameters.Add(new SqlParameter("@maHD", textBoxMaHD.Text));
                        command.Parameters.Add(new SqlParameter("@MaSV", textBoxMaSV.Text));
                        command.Parameters.Add(new SqlParameter("@maNV", textBoxMaNV.Text));
                        command.Parameters.Add(new SqlParameter("@ngaylap", NgayLap));
                        command.Parameters.Add(new SqlParameter("@hocKy", Convert.ToInt32(hocKyOption.SelectedItem)));
                        command.Parameters.Add(new SqlParameter("@namHoc", textBoxNamHoc.Text));
                        command.Parameters.Add(new SqlParameter("@trangThai", trangThai));
                        command.Parameters.Add(new SqlParameter("@miengiam", (float)numberBoxMienGiam.Value));
                        command.ExecuteNonQuery();
                    }
                }
            } else
            {
                MessageBox.Show("Sinh Viên không thuộc khoa hoặc không tồn tại");
            }
            

            updateTable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            bool trangThai = false;

            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime NgayLap = DateTime.ParseExact(dateTimeNgayLap.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", provider);
            if (radioButtonDaNop.Checked)
            {
                trangThai = true;
            }
            else if (radioButtonChuaNop.Checked)
            {
                trangThai = false;
            }

            if (checkMaSV())
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "update_HD";
                        command.Parameters.Add(new SqlParameter("@maHD", textBoxMaHD.Text));
                        command.Parameters.Add(new SqlParameter("@MaSV", textBoxMaSV.Text));
                        command.Parameters.Add(new SqlParameter("@maNV", textBoxMaNV.Text));
                        command.Parameters.Add(new SqlParameter("@ngaylap", NgayLap));
                        command.Parameters.Add(new SqlParameter("@hocKy", (int)hocKyOption.SelectedItem));
                        command.Parameters.Add(new SqlParameter("@namHoc", textBoxNamHoc.Text));
                        command.Parameters.Add(new SqlParameter("@trangThai", trangThai));
                        command.Parameters.Add(new SqlParameter("@miengiam", (float)numberBoxMienGiam.Value));
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sinh Viên không thuộc khoa hoặc không tồn tại");
            }


            updateTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {


            if (checkMaSV())
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "delete_HD";
                        command.Parameters.Add(new SqlParameter("@maHD", textBoxMaHD.Text));
                        command.Parameters.Add(new SqlParameter("@MaKhoa", maKhoa));
                       
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sinh Viên không thuộc khoa hoặc không tồn tại");
            }


            updateTable();
        }

        public bool checkMaSV()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("check_MaSV", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", textBoxMaSV.Text));
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0) return true;
            }

            return false;
        }
        public bool checkMaHD()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("check_HD", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", textBoxMaSV.Text));
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));


                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0) return true;
            }

            return false;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            if (!string.IsNullOrEmpty(searchMaHD.Text))
            {
                

                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaHD", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maHD", searchMaHD.Text));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
            else if(!string.IsNullOrEmpty(searchMaSV.Text) && string.IsNullOrEmpty(searchHocKy.Text) 
                                                            && string.IsNullOrEmpty(searchNamHoc.Text) 
                                                              && radioTatCa.Checked)
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaSV", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
            else if(!string.IsNullOrEmpty(searchMaSV.Text) && string.IsNullOrEmpty(searchHocKy.Text)
                                                            && string.IsNullOrEmpty(searchNamHoc.Text)
                                                              && radioDaNop.Checked)
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaSV_TrangThai", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@trangThai", 1));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
            else if (!string.IsNullOrEmpty(searchMaSV.Text) && string.IsNullOrEmpty(searchHocKy.Text)
                                                            && string.IsNullOrEmpty(searchNamHoc.Text)
                                                              && radioChuaNop.Checked)
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaSV_TrangThai", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@trangThai", 0));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
            else if (!string.IsNullOrEmpty(searchMaSV.Text) && !string.IsNullOrEmpty(searchHocKy.Text)
                                                            && !string.IsNullOrEmpty(searchNamHoc.Text)
                                                              && radioTatCa.Checked)
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaSV_HocKy_NamHoc", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@namHoc", searchNamHoc.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@hocKy", Int32.Parse(searchHocKy.Text)));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
            else if (!string.IsNullOrEmpty(searchMaSV.Text) && !string.IsNullOrEmpty(searchHocKy.Text)
                                                            && !string.IsNullOrEmpty(searchNamHoc.Text)
                                                              && radioTatCa.Checked)
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaSV_HocKy_NamHoc", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@namHoc", searchNamHoc.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@hocKy", Int32.Parse(searchHocKy.Text)));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
            else if (!string.IsNullOrEmpty(searchMaSV.Text) && !string.IsNullOrEmpty(searchHocKy.Text)
                                                            && !string.IsNullOrEmpty(searchNamHoc.Text)
                                                              && radioDaNop.Checked)
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaSV_HocKy_NamHoc_TrangThai", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@namHoc", searchNamHoc.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@hocKy", Int32.Parse(searchHocKy.Text)));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@trangThai", 1));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
            else if (!string.IsNullOrEmpty(searchMaSV.Text) && !string.IsNullOrEmpty(searchHocKy.Text)
                                                            && !string.IsNullOrEmpty(searchNamHoc.Text)
                                                              && radioChuaNop.Checked)
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Search_HD_MaSV_HocKy_NamHoc_TrangThai", connection);
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maKhoa", maKhoa));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@maSV", searchMaSV.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@namHoc", searchNamHoc.Text));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@hocKy", Int32.Parse(searchHocKy.Text)));
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@trangThai", 0));
                    dataAdapter.TableMappings.Add("Table", "HoaDon");
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    DataTable dataTable = dataset.Tables["HoaDon"];
                    hoaDonTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hoaDonTable.DataSource = dataTable;
                }
            }
        }
    }
}
