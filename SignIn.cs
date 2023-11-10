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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class SignIn : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public SignIn()
        {
            InitializeComponent();
        }


        private void signInBtn_Click(object sender, EventArgs e)
        {
            if(checkTaiKhoan(accountTxt.Text.ToString(), passwordTxt.Text.ToString(), tenKhoaComboBox.Text))
            {
                string maKhoa = "0";
                DataTable dataTable = new DataTable();
                StringBuilder qry = new StringBuilder("EXEC Select_maKhoa ");
                qry.Append("@tenKhoa = N'" + tenKhoaComboBox.Text + "'");        
                dataTable = dataProvider.execQuery(qry.ToString());
                maKhoa = dataTable.Rows[0]["MaKhoa"].ToString();    
                this.Hide();
                HomePage homePage = new HomePage(maKhoa, tenKhoaComboBox.Text);
                homePage.Closed += (s, args) => this.Close();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("sdlafkj");
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Closed += (s, args) => this.Close();
            signUp.Show();

        }

        public bool checkTaiKhoan(string taiKhoan, string matKhau, string tenKhoa)
        {

            //DataTable dataTable = new DataTable();
            //StringBuilder qry = new StringBuilder("EXEC find_TaiKhoan");

            //qry.Append("@tk= '" + taiKhoan + "'");
            //qry.Append(",@mk= '" + matKhau + "'");
            //qry.Append(",@tenKhoa= N'" + tenKhoa + "'");
            //dataTable = dataProvider.execQuery(qry.ToString());
            //if (dataTable.Rows.Count > 0) return true;
            //return false;

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    tenKhoaComboBox.Items.Add(row["TenKhoa"]);
            //}
            SqlConnection connection = new SqlConnection();


            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("find_TaiKhoan", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@tk", taiKhoan));
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@mk", matKhau));
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@tenKhoa", tenKhoa));

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0) return true;
            }

            return false;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();
            StringBuilder qry = new StringBuilder("EXEC Select_tenKhoa");
            dataTable = dataProvider.execQuery(qry.ToString());

            foreach (DataRow row in dataTable.Rows)
            {
                tenKhoaComboBox.Items.Add(row["TenKhoa"]);
            }
        }
    }
}
