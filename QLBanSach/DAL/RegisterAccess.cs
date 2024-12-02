
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DTO;
namespace DAL
{

    public class RegisterAccess
    {

        public static string Register(NguoiDung taikhoan)
        {
            // Chuỗi xử lý tài khoản đăng ký

            SqlConnection sqlCon = null;
            // Kết nối đến CSDL
            SqlConnectDatabase sqlData = new SqlConnectDatabase();
            sqlCon = sqlData.MoKetNoi();
            DateTime dt = taikhoan.NamSinh;
            
            // Chuyển đổi ngày sinh từ chuỗi thành DateTime
            try
            {
                SqlCommand cmd = new SqlCommand("proc_register", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", taikhoan.Username);
                cmd.Parameters.AddWithValue("@pass", taikhoan.Password);
                cmd.Parameters.AddWithValue("@name", taikhoan.HoVaTen);
                cmd.Parameters.AddWithValue("@namsinh", taikhoan.NamSinh);
                cmd.Parameters.AddWithValue("@gioitinh", taikhoan.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", taikhoan.DiaChi);
                cmd.Parameters.AddWithValue("@sodienthoai", taikhoan.SoDienThoai);
                
                cmd.ExecuteNonQuery();
                return "register_access";
            }
            catch (SqlException ex)
            {
                // Kiểm tra mã lỗi trong csdl
                if (ex.Number == 50000) // Bắt lỗi throw 50000 trong csdl
                {
                    return "register_retail";
                }
                return "error";
            }
            finally
            {
                // Đảm bảo đóng kết nối SQL
                if (sqlCon != null && sqlCon.State ==ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
