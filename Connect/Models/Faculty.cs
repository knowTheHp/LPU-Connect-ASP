//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Connect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faculty
    {
        public long Fac_Id { get; set; }
        public int EmpId { get; set; }
        public int Department { get; set; }
        public string Title { get; set; }
        public string FromYear { get; set; }
        public string ToYear { get; set; }
        public Nullable<bool> CurrentlyWorking { get; set; }
        public Nullable<long> UserId { get; set; }
    
        public virtual Department Departments { get; set; }
        public virtual User Users { get; set; }
    }
}
