using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Info_Account_MngBLL
    {
        private Info_Account_Mng info_account;
        public Info_Account_MngBLL() 
        {
            info_account = new Info_Account_Mng();
        }
        public NguoiDung Check_InFo_Account(string username)
        {
            
            NguoiDung user = info_account.Info_Account(username);
            return user;
        }
        
    }
}
