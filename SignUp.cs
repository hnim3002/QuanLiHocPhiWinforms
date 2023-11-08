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
        public SignUp()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if(passwordTxt.Text.ToString().Equals(rePasswordTxt.Text.ToString()))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;

                using (connection)
                {
                    connection.Open();


                    using (SqlCommand command = connection.CreateCommand())
                    {


                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "insert_TaiKhoan";

                        command.Parameters.Add(new SqlParameter("@tk", accountTxt.Text.ToString()));
                        command.Parameters.Add(new SqlParameter("@mk", passwordTxt.Text.ToString()));


                        command.ExecuteNonQuery();

                      
                    }


                }
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.Closed += (s, args) => this.Close();
                signIn.Show();
            }
            
        }
    }
}
