using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace codefirstforpractice.Models
{
    public class playerscontext:DbContext
    {
        public DbSet<player> players { get; set; }
        public DbSet<team> teams{ get; set; }
        public DbSet<sportseries> sportseries {  get; set; }
        public DbSet<country> countries {  get; set; }
    }
}