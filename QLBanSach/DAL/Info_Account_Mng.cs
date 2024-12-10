using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;

namespace DAL
{
    public class Info_Account_Mng
    {
       
        public NguoiDung Info_Account(string username) {
            NguoiDung user = null;
            // Kết nối CSDL
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_NguoiDung where Username = @username";
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        user = new NguoiDung
                        {
                            MaND = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Pass = reader.GetString(2),
                            MaQuyen = reader.GetInt32(3),
                            HoVaTen = reader.GetString(4),
                            NamSinh = reader.GetDateTime(5),
                            GioiTinh = reader.GetString(6),
                            DiaChi = reader.GetString(7),
                            SoDienThoai = reader.GetString(8)
                        };
                    }
                }
                db.DongKetNoi();
                reader.Close();
            return user;

        }
    }
}
