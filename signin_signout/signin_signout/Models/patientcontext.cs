using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace signin_signout.Models
{
    public class patientcontext:DbContext
    {
        public DbSet<patient> patients {  get; set; }
        public DbSet<doctor> doctors { get; set; }
    }
}