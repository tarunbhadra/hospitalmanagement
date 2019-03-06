using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;

namespace HospitalManagement.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(string Userid,string Password)
        {
            BAL_Login _Login = new BAL_Login();
            bool flag = false;
            flag = _Login.Login(Userid, Password);
            if (flag)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
