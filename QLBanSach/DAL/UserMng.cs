using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class UserMng
    {
        private List<NguoiDung> Users = new List<NguoiDung>();
        public NguoiDung taikhoan;
        
        //public List<NguoiDung> DocDuLieuUser() 
        //{
        //    try
        //    {

        //        SqlConnectDatabase db = new SqlConnectDatabase();
        //        db.MoKetNoi();
        //        //đối tượng truy vấn
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "select * from tbl_NguoiDung";

        //        //gan vao csdl
        //        cmd.Connection = db.sqlCon;

        //        //thực thi truy vấn
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            NguoiDung user = new NguoiDung
        //            {
        //                MaND = reader.GetInt32(0),
        //                Username = reader.GetString(1),
        //                Pass = reader.GetString(2),
        //                MaQuyen = reader.GetInt32(3),
        //                HoVaTen = reader.GetString(4),
        //                NamSinh = reader.GetDateTime(5),
        //                GioiTinh = reader.GetString(6),
        //                DiaChi = reader.GetString(7),
        //                SoDienThoai = reader.GetString(8)
        //            };
        //            Users.Add(user);
        //        }
        //        db.DongKetNoi();
        //        reader.Close();
        //    }
        //    catch(SqlException ex)
        //    {
        //        Console.WriteLine($"Lỗi cơ sở dữ liệu:" + ex.Message);
        //    }
        //    return Users;
        //}
        public DataTable DocDuLieuUser()
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlConn = db.sqlCon;
            //đối tượng truy vấn
            string sql = "select * from tbl_NguoiDung";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimKiemUser(string username)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnectDatabase db = new SqlConnectDatabase();
                db.MoKetNoi();
                SqlConnection sqlCon = db.sqlCon;
                string sql = "select * from tbl_NguoiDung where Username = @Username";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            return dataTable;
        }
        public DataTable TimKiemUsers(string HoTen)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnectDatabase db = new SqlConnectDatabase();
                db.MoKetNoi();
                SqlConnection sqlCon = db.sqlCon;
                string sql = "select * from tbl_NguoiDung Where HoVaTen LIKE @HoVaTen";
                SqlCommand cmd = new SqlCommand(sql,sqlCon);
                cmd.Parameters.AddWithValue("@HoVaTen", "%" + HoTen + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            return dataTable ;
        }   

        //Suwj kien them usser
        public string ThemNguoiDung(NguoiDung newUser)
        {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_InsertUser";
           int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@user", newUser.getUsername());
                cmd.Parameters.AddWithValue("@pass", newUser.getPass());
                cmd.Parameters.AddWithValue("@hoTen", newUser.getHoVaTen());
                cmd.Parameters.AddWithValue("@maQuyen", newUser.getMaQuyen());
                cmd.Parameters.AddWithValue("@gioiTinh", newUser.getGioiTinh());
                cmd.Parameters.AddWithValue("@namSinh", newUser.getNamSinh());
                cmd.Parameters.AddWithValue("@diaChi", newUser.getDiaChi());
                cmd.Parameters.AddWithValue("@soDienThoai", newUser.getSoDienThoai());
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally 
            {
                db.DongKetNoi();
            }
            if(kq > 0)
            {
                this.Users.Add(newUser);
                return "add_Success";
            }
            return "error_Add_Success";
        }
        public string SuaTTNguoiDung(NguoiDung editUser)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_EditUser";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@user", editUser.getUsername());
                cmd.Parameters.AddWithValue("@pass", editUser.getPass());
                cmd.Parameters.AddWithValue("@hoTen", editUser.getHoVaTen());
                cmd.Parameters.AddWithValue("@maQuyen", editUser.getMaQuyen());
                cmd.Parameters.AddWithValue("@gioiTinh", editUser.getGioiTinh());
                cmd.Parameters.AddWithValue("@namSinh", editUser.getNamSinh());
                cmd.Parameters.AddWithValue("@diaChi", editUser.getDiaChi());
                cmd.Parameters.AddWithValue("@soDienThoai", editUser.getSoDienThoai());
                kq = cmd.ExecuteNonQuery();
            }
            catch(SqlException ex) 
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if(kq > 0)
            {
                this.Users.Add(editUser);
                return "edit_Success";
            }
            return "error_Edit_Success";
        }
        public string XoaTTNguoiDung(NguoiDung deleteUser)
        {
            // kết nối cơ sở dữ liệu
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteUsers";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@user", deleteUser.getUsername());
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                this.Users.Remove(deleteUser);
                return "delete_Success";
            }
            
            Console.WriteLine($"Số dòng bị xóa: {kq}");
            Console.WriteLine(deleteUser.getMaND());
            Console.WriteLine($"Số dòng bị ảnh hưởng: {kq}");
            return "error_Delete_Success";
        }
        //public DataTable XoaTTNguoiDung()
        //{
        //    //kết nối cơ sở dữ liệu
        //    SqlConnectDatabase db = new SqlConnectDatabase();
        //    db.MoKetNoi();
        //    SqlConnection sqlConn = db.sqlCon;

        //    //đối tượng truy vấn
        //    string sql = "proc_DeleteUser";
        //    SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConn);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt;
        //}

    }

}
