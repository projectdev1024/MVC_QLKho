//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKho.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VitriSua
    {
        public int ID_ViTri { get; set; }
        public Nullable<int> ID_NhaKho { get; set; }
        public Nullable<int> Tang { get; set; }
        public Nullable<int> Hang { get; set; }
        public Nullable<int> Cot { get; set; }
        public string Note { get; set; }
    
        public virtual NhaKho NhaKho { get; set; }
    }
}
