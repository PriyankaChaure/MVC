//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dffgfd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class projectassignment
    {
        public long assignmentid { get; set; }
        public Nullable<long> studentid { get; set; }
        public Nullable<System.DateTime> assignmentdate { get; set; }
        public Nullable<long> projectid { get; set; }
    
        public virtual project project { get; set; }
    }
}
