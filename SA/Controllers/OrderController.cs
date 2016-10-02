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
            OrderItem orderItem = null;
            User user = AppSession.getCurrentUser();
            User dbUser = db.Users.Where(x => x.id == user.id).First();
            item = db.FoodItems.Where(x => x.id == itemId).FirstOrDefault();
            
            if(item != null)
            {
                order = db.Orders.Where(x => x.user.id == user.id && x.states == states.newOrder).FirstOrDefault();
                if(order == null)
                {
                    order = new Order();
                    order.states = states.newOrder;
                    order.user = dbUser;
                    orderItem = new OrderItem();
                    orderItem.foodItem = item;
                    orderItem.qty = 1;
                    order.orderItems.Add(orderItem);
                    db.Orders.Add(order);
                }else
                {
                    orderItem = order.orderItems.Where(x => x.foodItem.id == item.id).FirstOrDefault();
                    if (orderItem == null)
                    {
                        orderItem = new OrderItem();
                        orderItem.foodItem = item;
                        orderItem.qty = 1;
                        order.orderItems.Add(orderItem);
                    }
                    else
                    {
                        orderItem.qty++;
                    }
                }
                db.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
        public static Order getOrder()
        {
            User user = AppSession.getCurrentUser();
            Order order = null;
            order = db.Orders.Where(x => x.user.id == user.id && x.states == states.newOrder).FirstOrDefault();
            return order;
        }
        public static bool RemoveItemFromOrder(int itemId)
        {
            User user = AppSession.getCurrentUser();
            Order order = null;
            OrderItem orderItem = null;
            order = db.Orders.Where(x => x.user.id == user.id && x.states == states.newOrder).FirstOrDefault();
            orderItem = order.orderItems.Where(x => x.foodItem.id == itemId).FirstOrDefault();
            if(orderItem != null)
            {
                if (orderItem.qty != 0)
                {
                    orderItem.qty--;
                }
                else
                {
                    order.orderItems.Remove(orderItem);
                }

                db.SaveChanges();
                
            }
            return true;
        }

    }
}
