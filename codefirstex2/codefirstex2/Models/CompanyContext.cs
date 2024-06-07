using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace codefirstex2.Models
{
    
    public class CompanyContext:DbContext
    {
        public CompanyContext() : base("company")
        { }

        public DbSet<department> departments { get; set; }
        public DbSet<employee> employees { get; set; }  

    }
}