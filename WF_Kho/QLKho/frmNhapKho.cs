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
    public partial class frmNhapKho : DevExpress.XtraEditors.XtraForm
    {
        Code.INhapXuat iNhapXuat;
        public frmNhapKho(Code.INhapXuat iNhapXuat)
        {
            InitializeComponent();
            this.iNhapXuat = iNhapXuat;
        }

        public void Reload()
        {
            grctrl.DataSource = new List<Model.LoHang>(iNhapXuat.GetListNhapKho());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iNhapXuat.SaveNhapKho();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            iNhapXuat.ClearNhapKho();
            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grv.SelectedRowsCount > 0)
            {
                foreach (var item in grv.GetSelectedRows())
                {
                    var ob = grv.GetRow(item) as Model.LoHang;
                    iNhapXuat.RemoveNhapKho(ob);
                }
                Reload();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn các lô hàng muốn xóa!");
            }
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void frmNhapKho_MouseMove(object sender, MouseEventArgs e)
        {
            Opacity = 1;
        }

    }
}