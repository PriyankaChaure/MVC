using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assignment_on_codefirst.Models
{
    public class contextclass:DbContext
    {
        public DbSet<emp1>emp1s { get; set; }
        public DbSet<dept1> dept1s { get; set;}
        public DbSet<city1> city1s { get; set; }
    }
}