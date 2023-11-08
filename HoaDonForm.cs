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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HoaDonForm : Form
    {

        private HomePage homePage;
        public HoaDonForm(HomePage homePage)
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.homePage = homePage;
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();


                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select_HD", connection);
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
                //string maSV = hoaDonTable.Rows[row].Cells["Mã Sinh Viên"].Value.ToString();
                //string tenSV = hoaDonTable.Rows[row].Cells["Tên Sinh Viên"].Value.ToString();
                //string tenKhoa = hoaDonTable.Rows[row].Cells["Khoa"].Value.ToString();
                //DateTime ngaySinh = (DateTime)hoaDonTable.Rows[row].Cells["Ngày Sinh"].Value;
                //DateTime ngayLap = (DateTime)hoaDonTable.Rows[row].Cells["Ngày Lập"].Value;

                homePage.openChiTietHoaDon(maHD);
            }
        }

        private void baoCaoBtn_Click(object sender, EventArgs e)
        {
            homePage.openHoaDonReportOptinForm();
        }
    }
}
