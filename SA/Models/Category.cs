using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SA.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string categoryName { get; set; }
        
        public virtual List<FoodItem> foodItems { get; set; }
    }
}
