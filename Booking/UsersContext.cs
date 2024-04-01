using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Booking
{
    internal class UsersContext : DbContext
    {
        public DbSet<User> Booking { get; set; }

        public UsersContext() : base("DefaultConnection") 
        {

        }
    }
}
