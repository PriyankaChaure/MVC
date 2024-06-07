using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace codefirstexam_akash_.Models
{
    public class batchcontext:DbContext
    {
        public DbSet<batch> batches {  get; set; }
        public DbSet<course>courses { get; set; }
        public DbSet<trainer> trainers { get; set; }
        public DbSet<coursecategory>coursecategories { get; set; }

    }
}