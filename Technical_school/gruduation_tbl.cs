//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Technical_school
{
    using System;
    using System.Collections.Generic;
    
    public partial class gruduation_tbl
    {
        public int register_id { get; set; }
        public Nullable<int> intern_national_code { get; set; }
        public int course_id { get; set; }
        public Nullable<System.DateTime> register_date { get; set; }
        public string register_conditions { get; set; }
    
        public virtual course_tbl course_tbl { get; set; }
        public virtual intern_tbl intern_tbl { get; set; }
    }
}
