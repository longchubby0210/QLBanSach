using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAccess:ConnectAccess
    {
        public string CheckLogin(NguoiDung taikhoan)
        {
            string infoUser = CheckLoginUser(taikhoan);
            return infoUser;
        }

    }
}
