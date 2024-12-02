using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DTO;
using DAL;
using System.Text.RegularExpressions;
namespace BLL
{
    public class RegisterBLL
    {
       
        UserRegister userRegister = new UserRegister();
        public string CheckRegister(NguoiDung taiKhoan)
        {
            
            //Kiểm tra thông tin người dùng nhập vào hay chưa
            if(taiKhoan.Username == "" || taiKhoan.Password == "" || taiKhoan.HoVaTen == "" 
                || taiKhoan.GioiTinh == "" || taiKhoan.DiaChi == "" || taiKhoan.SoDienThoai == "")
            {
                return "Bạn chưa điền đầy đủ thông tin!";
            }
            
             string checkRegister = userRegister.CheckRegister(taiKhoan);
            return checkRegister;
        }
        
        
    }
}
