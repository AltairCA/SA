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

                if (user == null)
                    return false;
                else
                    return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void seedData()
        {
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                FoodItem item = new FoodItem();
                item.price = rand.Next(10, 100);
                item.qty = rand.Next(10, 100);
                item.itemName = "item" + rand.Next(10, 100);
                context.FoodItems.Add(item);
            }

            context.SaveChanges();
        }
    }
}
