using SA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.Controllers
{
    class AddItemController
    {
        private static AppContext context = new AppContext();

        public bool addItem(String _quantity, String _price)
        {
            try
            {
                //User user = context.Users.Where(x => x.email == _email && x.password == _password).FirstOrDefault();
              

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }










    }
}
