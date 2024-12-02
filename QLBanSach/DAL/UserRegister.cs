using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRegister:RegisterAccess
    {
        public string CheckRegister(NguoiDung taikhoan)
        {
            string newUser =  Register(taikhoan);
            return newUser;
        }
    }
}
