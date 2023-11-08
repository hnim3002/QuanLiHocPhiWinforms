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
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Inherit;

            // Set the Dock property to Fill.
            Dock = DockStyle.Fill;

            // Set the Anchor property to Top, Bottom, Left, and Right.
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;



        }

        



        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();


            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();


                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT_NV", connection);
                dataAdapter.TableMappings.Add("Table", "NhanVien");
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DataTable dataTable = dataset.Tables["NhanVien"];

                nhanVienTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                nhanVienTable.Width = this.Width;
                nhanVienTable.DataSource = dataTable;

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void NhanVienForm_SizeChanged(object sender, EventArgs e)
        {
            if(Width >= 1024 )
            {
                addBtn.Text = "sldkfjsallkjdfs";
            }
           
        }
    }
}
