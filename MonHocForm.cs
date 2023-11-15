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
    }
}
