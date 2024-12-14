using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class NguoiDungBLL
    {
        
        
        private UserMng userMng;
        public NguoiDungBLL() 
        { 
            userMng = new UserMng();
        }
        //sự kiện tìm kiếm người dùng bằng username
        public DataTable TimKiemUsers(string username)
        {
            if (username == null)
            {
                throw new Exception("Mã sinh viên không được để trống.");
            }
            return userMng.TimKiemUser(username);
        }
        //Sự kiện tìm kiếm người dùng bằng họ và tên
        public DataTable TimKiemUser(string HoTen)
        {
            if (HoTen == null)
            {
                throw new Exception("Họ tên sinh viên không được để trống.");
            }
            return userMng.TimKiemUsers(HoTen);
        }
        // hiển thị người dùng BLL
        public DataTable HienThiDuLieuUser()
        {
            try
            {
                return userMng.DocDuLieuUser();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
        // sự kiện thêm người dùng
        public string ThemNguoiDung(NguoiDung newUser)
        {
            // Kiểm tra null của NguoiDung
            if (newUser == null)
            {
                return "newUser_null_error"; 
            }
            // kiểm tra xem thông tin đã được nhập vào hay chưa
            if (newUser.Username == "" || 
                newUser.Pass == "" || 
                newUser.HoVaTen == "" || 
                newUser.DiaChi == "" ||
                newUser.SoDienThoai == "") 
                return "name_error";
            UserMng newUserMng = new UserMng();
            string Add_OK = newUserMng.ThemNguoiDung(newUser);
            return Add_OK;
        }
        public string SuaTTNguoiDung(NguoiDung editUser)
        {
            if(editUser == null)
            {
                return "editUser_error_null";
            }
            UserMng editUserMng = new UserMng();

            string Edit_OK = editUserMng.SuaTTNguoiDung(editUser);
            return Edit_OK;
        }
        public string XoaTTNguoiDung(string deleteUser)
        {
            if (deleteUser == null)
            {
                return "delete_error_null";
            }
            try
            {
                return userMng.XoaTTNguoiDung(deleteUser);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình xóa người dùng: " + ex.Message);
            }
            
        }
        
    }
    
}
