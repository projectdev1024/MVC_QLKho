using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace QLKho.Report
{
    public partial class XuatKho_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public XuatKho_Report()
        {
            InitializeComponent();
        }

        public void InitData(Model.PhieuXuat phieuXuat,List<Model.CT_XuatKho> lst)
        {
            pTenNV.Value = phieuXuat.NhanVien.TenNV.ToString();
            pThoiGian.Value = phieuXuat.ThoiGian.Value.ToString("hh:mm:ss dd/MM/yyyy");
            pID_PhieuXuat.Value = phieuXuat.ID_PhieuXuat.ToString();
            bindingSource1.DataSource = lst;
        }
    }
}
