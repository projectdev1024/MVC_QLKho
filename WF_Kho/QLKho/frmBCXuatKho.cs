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
using System.Text.RegularExpressions;

namespace QLKho
{
    public partial class frmBCXuatKho : DevExpress.XtraEditors.XtraForm
    {
        public frmBCXuatKho(Code.INotify iNotify)
        {
            InitializeComponent();
            this._iNotify = iNotify;
        }

        private void frmBCXuatKho_Load(object sender, EventArgs e)
        {
            date_end.EditValue = DateTime.Now;
            var end = DateTime.Now.AddMonths(-1);
            end = new DateTime(end.Year, end.Month, 1);
            date_start.EditValue = end;
            _reload();
        }

        private void _reload()
        {
            var data = new Model.dbQLKhoEntities().PhieuXuats.ToList();
            if (cb_KhoangThoiGian.Checked)
            {
                data = data.Where(q => q.ThoiGian.Value >= (DateTime)date_start.EditValue && q.ThoiGian.Value <= (DateTime)date_end.EditValue).ToList();
            }
            if (cb_MaPhieu.Checked)
            {
                if (new Regex(@"\d+").IsMatch(txt_MaPhieu.Text))
                {
                    data = data.Where(q => q.ID_PhieuXuat.Equals(int.Parse(txt_MaPhieu.Text))).ToList();
                }
                else
                {
                    dxErrorProvider1.SetError(txt_MaPhieu, "Vui lòng kiểm tra lại mã phiếu.");
                }
            }
            grctrl_main.DataSource = data.OrderByDescending(q=>q.ThoiGian.Value).ToList();
            _iNotify.Status("Có {0} phiếu nhập", data.Count);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _reload();
        }

        Code.INotify _iNotify;

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            foreach (var item in grv_main.GetSelectedRows())
            {
                var obj = grv_main.GetRow(item) as Model.PhieuXuat;
                using (var f = new frmPrint())
                {
                    f.PrintXuatKho(obj);
                    f.ShowDialog();
                }
                return;
            }
        }
    }
}