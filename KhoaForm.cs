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

namespace WindowsFormsApp2
{
    public partial class KhoaForm : Form
    {
        public KhoaForm()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void KhoaForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();


            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();


                SqlDataAdapter dataAdapter = new SqlDataAdapter("select_Khoa", connection);
                dataAdapter.TableMappings.Add("Table", "Khoa");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["khoa"];

                khoaTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                khoaTable.DataSource = dataTable;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var maKhoa = textBoxTenNV.Text.ToString();
            SqlConnection connection = new SqlConnection();


            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();


                SqlDataAdapter dataAdapter = new SqlDataAdapter("DS_NV", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@TenK", maKhoa));
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                

                khoaTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                khoaTable.DataSource = dataTable;
            }
        }
    }
}
