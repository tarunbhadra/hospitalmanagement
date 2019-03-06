using ServerLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Login
    {
        
        public bool Login(string UserID, string Password)
        {
            if(UserID != null && Password != null)
            {
                using (DBTESTEntities db = new DBTESTEntities())
                {
                    var result = db.Users.Where(c => c.UserName.ToUpper() == UserID.ToUpper() && c.Password == Password).First();
                    if(result != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}
