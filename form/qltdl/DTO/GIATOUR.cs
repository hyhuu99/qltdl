//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class GIATOUR
    {
        public int ID { get; set; }
        public int IDT { get; set; }
        public decimal GIATOUR1 { get; set; }
        public Nullable<System.DateTime> NGAYBD { get; set; }
        public Nullable<System.DateTime> NGAYKT { get; set; }
    
        public virtual TOUR TOUR { get; set; }
    }
}
