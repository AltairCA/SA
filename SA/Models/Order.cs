using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SA.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public virtual User user { get; set; }

        public DateTime date { get; set; }

        public virtual List<OrderItem> orderItems { get; set; }
        public states states { get; set; }
    }

    public enum states
    {
        newOrder,
        inProcess,
        Completed
    }
}
