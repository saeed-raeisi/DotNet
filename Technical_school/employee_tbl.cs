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
    
    public partial class employee_tbl
    {
        public int personal_code { get; set; }
        public string contact_type { get; set; }
        public Nullable<System.DateTime> name_birthday { get; set; }
        public string job { get; set; }
        public string degree { get; set; }
    
        public virtual manager_tbl manager_tbl { get; set; }
    }
}