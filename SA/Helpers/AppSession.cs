using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA.Models;

namespace SA.Helpers
{
    public class AppSession
    {
        private static User currentUser;

        public static void setCurrentUser(User _user)
        {
            currentUser = _user;
        }

        public static User getCurrentUser()
        {
            return currentUser;
        }
    }
}
