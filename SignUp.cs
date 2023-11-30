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
    public partial class SignUp : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public SignUp()
        {
            InitializeComponent();
        }

       

        
        private void SignUp_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            StringBuilder qry = new StringBuilder("EXEC Select_tenKhoa");
            dataTable = dataProvider.execQuery(qry.ToString());

            foreach (DataRow row in dataTable.Rows)
            {
                tenKhoaComboBox.Items.Add(row["TenKhoa"]);
            }
        }

        private void signUpBtn_Click_1(object sender, EventArgs e)
        {
            if (passwordTxt.Text.ToString().Equals(rePasswordTxt.Text.ToString()))
            {
                string a = tenKhoaComboBox.SelectedItem.ToString();
                StringBuilder qry = new StringBuilder("EXEC insert_TaiKhoan");
                qry.Append(" @tk= '" + accountTxt.Text + "'");
                qry.Append(",@mk= N'" + passwordTxt.Text + "'");
                qry.Append(",@tenKhoa= N'" + tenKhoaComboBox.Text + "'");

                dataProvider.execNonQuery(qry.ToString());
                //SqlConnection connection = new SqlConnection();
                //connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                //using (connection)
                //{
                //    connection.Open();


                //    using (SqlCommand command = connection.CreateCommand())
                //    {

                //        command.CommandType = CommandType.StoredProcedure;
                //        command.CommandText = "insert_TaiKhoan";

                //        command.Parameters.Add(new SqlParameter("@tk", accountTxt.Text.ToString()));
                //        command.Parameters.Add(new SqlParameter("@mk", passwordTxt.Text.ToString()));


                //        command.ExecuteNonQuery();


                //    }


                //}
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.Closed += (s, args) => this.Close();
                signIn.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu");
            }
        }

        private void signInBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        private void enter_signup(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tenKhoaComboBox.Text.Equals("") || accountTxt.Text.Equals("") || passwordTxt.Text.Equals("") || rePasswordTxt.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin đăng ký");
                }
                else
                {
                    signUpBtn.PerformClick();
                }
            }
        }
    }
}
