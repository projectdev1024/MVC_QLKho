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
    
    public partial class LoHang
    {
        public LoHang()
        {
            this.CT_XuatKho = new HashSet<CT_XuatKho>();
        }
    
        public int MaLoHang { get; set; }
        public string MaHH { get; set; }
        public Nullable<System.DateTime> NSX { get; set; }
        public Nullable<System.DateTime> HSD { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> ID_NhaKho { get; set; }
        public Nullable<int> ID_PhieuNhap { get; set; }
        public string MaNCC { get; set; }
        public Nullable<int> Tang { get; set; }
        public Nullable<int> Hang { get; set; }
        public Nullable<int> Cot { get; set; }
    
        public virtual ICollection<CT_XuatKho> CT_XuatKho { get; set; }
        public virtual HangHoa HangHoa { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhaKho NhaKho { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
