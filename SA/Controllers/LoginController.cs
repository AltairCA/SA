using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA.Models;
using SA.Helpers;

namespace SA.Controllers
{
    class LoginController
    {
        private static AppContext context = new AppContext();

        public bool login(String _email, String _password)
        {
            try
            {
                User user = context.Users.Where(x => x.email == _email && x.password == _password).FirstOrDefault();
                AppSession.setCurrentUser(user);

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
