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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }


        private void signInBtn_Click(object sender, EventArgs e)
        {
            if(checkTaiKhoan(accountTxt.Text.ToString(), passwordTxt.Text.ToString()))
            {
                this.Hide();
                HomePage homePage = new HomePage();
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

        public bool checkTaiKhoan(string taiKhoan, string matKhau)
        {
            SqlConnection connection = new SqlConnection();


            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

            using (connection)
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TaiKhoan WHERE TenDangNhap = @tk AND MatKhau = @mk", connection);
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@tk", taiKhoan));
                dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@mk", matKhau));
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0) return true;
            }

            return false;
        }


        
    }
}
