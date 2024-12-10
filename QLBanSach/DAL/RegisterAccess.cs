
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
        // Chuỗi xử lý tài khoản đăng ký
        public static string Register(NguoiDung taikhoan)
        {
            SqlConnection sqlCon = null;
            // Kết nối đến CSDL
            SqlConnectDatabase sqlData = new SqlConnectDatabase();
            sqlCon = sqlData.MoKetNoi();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    {
                    sqlCon.Open();
                    }
                    SqlCommand cmd = new SqlCommand("pro_register", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", taikhoan.Username);
                    cmd.Parameters.AddWithValue("@pass", taikhoan.Pass);
                    cmd.Parameters.AddWithValue("@name", taikhoan.HoVaTen);
                    DateTime validNamSinh = taikhoan.NamSinh >= new DateTime(1753, 1, 1)  ? taikhoan.NamSinh : new DateTime(1753, 1, 1);
                    cmd.Parameters.AddWithValue("@namsinh", validNamSinh);
                    cmd.Parameters.AddWithValue("@gioitinh", taikhoan.GioiTinh);
                    cmd.Parameters.AddWithValue("@diachi", taikhoan.DiaChi);
                    cmd.Parameters.AddWithValue("@sodienthoai", taikhoan.SoDienThoai);
                    cmd.Connection = sqlCon;
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
