using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsApp2
{
    public class DataProvider
    {

        
        public DataTable execQuery(string qry)
        { 
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            using (connection)
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(data);
            }
            return data;
        }

        // Hàm này dùng cho lệnh insert,delete,update để thêm,xoá,sửa
        public int execNonQuery(string qry)
        {
            int data = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            using (connection)
            {
                connection.Open();
                SqlCommand sqlCmd = new SqlCommand(qry, connection);
                data = sqlCmd.ExecuteNonQuery();
            }
            return data;
        }

        // Dùng để truy vấn 1 dòng dữ liệu
        // Dùng để tính tổng các cột, hoá đơn,...
        public object execScaler(string qry)
        {
            object data = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["QlHocPhiConnectionString"].ConnectionString;
            using (connection)
            {
                connection.Open();
                SqlCommand sqlCmd = new SqlCommand(qry, connection);
                data = sqlCmd.ExecuteScalar();
            }
            return data;
        }
    }
}
