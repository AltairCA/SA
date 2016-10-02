using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA.Models;

namespace SA.Controllers
{
    public static class RegistrationController
    {
        private static AppContext db = new AppContext();
        public static bool Registration(string email,string password,Roles role)
        {
            User user = new User();
            user.email = email;
            user.level = role;
            user.password = password;
            db.Users.Add(user);
            db.SaveChanges();
            return true;
        }
    }
}
