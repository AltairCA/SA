﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SA.Models
{
    public class FoodItem
    {
       [Key]
        public int id { get; set; }
        public string itemName { get; set; }
        public float price { get; set; }

        public int qty { get; set; }
    }
    public class FoodItemDTO
    {
    
       
        public string itemName { get; set; }
        public float price { get; set; }

        public int qty { get; set; }
    }
}
