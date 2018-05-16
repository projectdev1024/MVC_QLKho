using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLKho.Report
{
    public partial class NhapKho_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public NhapKho_Report()
        {
            InitializeComponent();
        }

        internal void InitData(Model.PhieuNhap phieuNhap , System.Collections.Generic.List<Model.LoHang> lst)
        {
            TenNV.Value = phieuNhap.NhanVien.TenNV.ToString();
            ThoiGian.Value = phieuNhap.ThoiGian.Value.ToString("hh:mm:ss dd/MM/yyyy");
            ID_PhieuNhap.Value = phieuNhap.ID_PhieuNhap.ToString();
            bindingSource1.DataSource = lst;
        }
    }
}
