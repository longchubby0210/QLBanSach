using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DTO;

namespace DAL
{
    public class SqlConnectDatabase
    {

        // Tạo chuỗi kết nối csdl
        string strCon = "Data Source=DESKTOP-82BTP3O\\DUCLONG;Initial Catalog=QLBanSach;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlCon = null;
        // trả về sqlConnect để dễ tái sử dụng khi cần
        public SqlConnection MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
           return sqlCon;
        }
    }
    
    public class ConnectAccess 
    {
        // Chuỗi kết nối xử lý tài khoản đăng nhập
        public static string CheckLoginUser(NguoiDung taikhoan)
        {
            string user = null;
            SqlConnection sqlCon = null;
            // Kết nối đến CSDL
            SqlConnectDatabase sqlData = new SqlConnectDatabase();
            sqlCon = sqlData.MoKetNoi();
            
            SqlCommand cmd = new SqlCommand("proc_checklogin", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user",taikhoan.Username);
            cmd.Parameters.AddWithValue("@pass",taikhoan.Password);

            //Kiểm tra quyền
            cmd.Connection = sqlCon;
            SqlDataReader dataReader = cmd.ExecuteReader();
            
            if (dataReader.HasRows)// nếu mà nó có data thì tiếp tục xử lý
            {
                while (dataReader.Read())
                {
                    //Thêm if để kiểm tra null vì MaND là int 
                    if (!dataReader.IsDBNull(0))
                    {
                        user = dataReader[0].ToString(); // Sử dụng ToString()
                        return user;
                    }
                }
                dataReader.Close();
                sqlCon.Close();
            }
            // không có thì trả về tài khoản sai 
            else 
            {
                return "taikhoan_fail";
            }

            return user;
        }


    }
   


}
