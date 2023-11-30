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
    public partial class ResetPassword : Form
    {
        private string maKhoa;
        private string tenKhoa;
        private string taiKhoan;
        public ResetPassword(string maKhoa, string tenKhoa, string taiKhoan )
        {
            InitializeComponent();
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.taiKhoan = taiKhoan;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (oldPasswordTxt.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ để thay đổi");
                return;
            }
            if (passwordTxt.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
                return;
            }
            if (!rePasswordTxt.Text.Equals(passwordTxt.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác!");
            }
            if(checkTaiKhoan(taiKhoan, oldPasswordTxt.Text, tenKhoa))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "update_TaiKhoan";
                        command.Parameters.Add(new SqlParameter("@tk", taiKhoan));
                        command.Parameters.Add(new SqlParameter("@mk", passwordTxt.Text.ToString()));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.Hide();
                        SignIn signIn = new SignIn();
                        signIn.Closed += (s, args) => this.Close();
                        signIn.Show();
                    }
                }
            }

        }

        public bool checkTaiKhoan(string taiKhoan, string matKhau, string tenKhoa)
        {
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

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(maKhoa, tenKhoa, taiKhoan);
            homePage.Closed += (s, args) => this.Close();
            homePage.Show();
        }
    }
}
