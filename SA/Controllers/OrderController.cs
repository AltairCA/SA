using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA.Models;
using SA.Helpers;

namespace SA.Controllers
{
    
    public static class OrderController
    {
        public static AppContext db = new AppContext();

        public static FoodItem getFoodItem (int id)
        {
            FoodItem item = null;

            try
            {
                item = db.FoodItems.Where(x => x.id == id).FirstOrDefault();
                return item;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public static bool putItemintoOrder(int itemId)
        {
            FoodItem item = null;
            Order order = null;
            User user = AppSession.getCurrentUser();
            item = getFoodItem(itemId);
            if(item != null)
            {
                order = db.Orders.Where(x => x.user.id == user.id).First();
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
