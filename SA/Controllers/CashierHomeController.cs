using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA.Helpers;
using SA.Models;

namespace SA.Controllers
{
    class CashierHomeController
    {
        private static AppContext context = new AppContext();

        public class OrderDataBindingProjection
        {
            public int OrderID { get; set; }
            public string Customer { get; set; }
            public string Date { get; set; }
        }

        public bool completeOrder(Order _order)
        {
            try
            {
                Order order = context.Orders.Where(x => x.id == _order.id).FirstOrDefault();
                order.states = states.Completed;
                context.SaveChanges();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public List<Order> getIncompleteOrders()
        {
            List<Order> orders = context.Orders.Where(x => x.states == states.newOrder).ToList();

            //var query = from c in context.Orders
            //            where c.states == states.newOrder
            //            select new OrderDataBindingProjection { OrderID = c.id };
            //var orders = query.ToList();

            return orders;
        }

        public void seedData()
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                FoodItem item = new FoodItem();
                item.itemName = "Item " + rand.Next(1, 10).ToString();
                item.price = rand.Next(1, 10) * i;

                context.FoodItems.Add(item);
            }

            for (int i = 0; i < 10; i++)
            {
                Order order = new Order();

                List<OrderItem> items = new List<OrderItem>();

                order.states = states.newOrder;
                order.date = DateTime.Now;

                for (int j = 0; j < 3; j++)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.foodItem = context.FoodItems.First();
                    orderItem.qty = rand.Next(1, 10);

                    context.OrderItems.Add(orderItem);
                    items.Add(orderItem);
                }
                
                context.Orders.Add(order);
            }
        }
    }
}
