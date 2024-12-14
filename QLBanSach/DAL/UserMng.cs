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
            
                SqlConnectDatabase db = new SqlConnectDatabase();
                db.MoKetNoi();
                SqlConnection sqlCon = db.sqlCon;
                string sql = "select * from tbl_NguoiDung where Username = @Username";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            finally
            {
                db.DongKetNoi();
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

        //Su kien them usser
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
                // đóng kết nối
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
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_EditUser";
            int kq = 0;
            // Truyền tham số vào
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
               // thực thi
                kq = cmd.ExecuteNonQuery();
            }
            catch(SqlException ex) 
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                // đóng kết nối
                db.DongKetNoi();
            }
            if(kq > 0)
            {
                this.Users.Add(editUser);
                return "edit_Success";
            }
            return "error_Edit_Success";
        }
        public string XoaTTNguoiDung(string deleteUser)
        {
            //kết nối csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteUsers";
            int kq = 0;
            try
            {
                //Truyền tham số vào
                cmd.Parameters.AddWithValue("@user", deleteUser);
                //Thực thi thủ tục
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                // đóng kết nối
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                return "delete_Success";
            }
            return "error_Delete_Success";
        }
    }
}
