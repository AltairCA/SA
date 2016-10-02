using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SA.Models
{
    public class OrderItem
    {
        [Key]
        public int id { get; set; }

        public FoodItem foodItem { get; set; }
        public int qty { get; set; }
    }
    public class OrderItemDTO
    {
        
       
        public FoodItem foodItem { get; set; }
        public int qty { get; set; }
    }
}
