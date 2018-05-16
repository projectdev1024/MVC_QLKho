using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLKho
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void PrintNhapKho(Model.PhieuNhap phieuNhap)
        {
            var lst = new Model.dbQLKhoEntities().LoHangs.ToList().Where(q => q.ID_PhieuNhap == phieuNhap.ID_PhieuNhap).OrderBy(q => q.HangHoa.TenHH).ToList();
            var report = new Report.NhapKho_Report();
            report.InitData(phieuNhap, lst);
            foreach (DevExpress.XtraReports.Parameters.Parameter item in report.Parameters)
                item.Visible = false;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintXuatKho(Model.PhieuXuat phieuXuat)
        {
            var lst = new Model.dbQLKhoEntities().CT_XuatKho.ToList().Where(q => q.ID_PhieuXuat == phieuXuat.ID_PhieuXuat).ToList();
            var report = new Report.XuatKho_Report();
            report.InitData(phieuXuat, lst);
            foreach (DevExpress.XtraReports.Parameters.Parameter item in report.Parameters)
                item.Visible = false;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}