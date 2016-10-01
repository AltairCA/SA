using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SA.Models
{
    class AppContext:DbContext
    {
        public AppContext()
            :base("AppDbContext")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
