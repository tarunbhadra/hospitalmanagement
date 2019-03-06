using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BAL_Login
    {
        public bool Login(string UserID,string Password)
        {
            DAL_Login _Login = new DAL_Login();
            return _Login.Login(UserID,Password);
        }

    }
}
