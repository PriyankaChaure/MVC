using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace db_first_exam.Models
{
    public class assignprostuproVM
    {
        public long assignmentid { get; set; }
        public Nullable<long> studentid { get; set; }
        public Nullable<System.DateTime> assignmentdate { get; set; }
        public Nullable<long> projectid { get; set; }
        
        public string projectname { get; set; }
        public string projectdesc { get; set; }
        
        public string studentname { get; set; }
        public string address { get; set; }
        public string emailid { get; set; }
        public string phoneno { get; set; }


    }
}