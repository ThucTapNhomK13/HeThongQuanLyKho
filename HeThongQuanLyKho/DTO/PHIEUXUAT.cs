//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUXUAT
    {
        public string Spxuat { get; set; }
        public Nullable<System.DateTime> ngayxuat { get; set; }
        public string lydoxuat { get; set; }
        public Nullable<int> maNV { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
