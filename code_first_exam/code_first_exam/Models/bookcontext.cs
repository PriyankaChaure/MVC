using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace code_first_exam.Models
{
    public class bookcontext:DbContext
    {
        public DbSet<book>books { get; set; }
        public DbSet<publisher> publisher { get; set; }
        public DbSet<bookcategory> bookcategories { get; set; }
        public DbSet<author> authors { get; set; }
    }
}