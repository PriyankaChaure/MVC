using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace customauthorizationfilter.Models
{
    public class UserContext:DbContext
    {
        public DbSet<customer> customers {  get; set; } 
        public DbSet<user> users { get; set; }
    }
}