using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SA.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Roles level { get; set; }
    }
    public enum Roles
    {
        customer,
        cashier,
        owner
    }

    class UserDTO
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
