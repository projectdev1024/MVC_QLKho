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
    public partial class frmXuatKho : DevExpress.XtraEditors.XtraForm
    {
        Code.INhapXuat iNhapXuat;
        public frmXuatKho(Code.INhapXuat iNhapXuat)
        {
            InitializeComponent();
            this.iNhapXuat = iNhapXuat;
        }

        public void ReloadGridview()
        {
            grctrl.DataSource = new List<Model.CT_XuatKho>(iNhapXuat.GetListXuatKho());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iNhapXuat.SaveXuatKho();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            iNhapXuat.ClearXuatKho();
            ReloadGridview();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grv.SelectedRowsCount > 0)
            {
                foreach (var item in grv.GetSelectedRows())
                {
                    var ob = grv.GetRow(item) as Model.CT_XuatKho;
                    iNhapXuat.RemoveXuatKho(ob);
                }
                ReloadGridview();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn các lô hàng muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            ReloadGridview();
            num_soLuong.Minimum = 1;
        }

        private void frmXuatKho_MouseMove(object sender, MouseEventArgs e)
        {
            Opacity = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lohang = _checkLoHang();
            if (lohang != null)
            {
                iNhapXuat.XuatKho(new Model.CT_XuatKho()
                {
                    MaLoHang = int.Parse(txt_MaLoHang.Text),
                    Note = rtb_Note.Text,
                    SoLuong = (int)num_soLuong.Value,
                    LoHang = lohang
                });
            }
            else
            {
                MessageBox.Show("Lô hàng không tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }

        private void txt_MaLoHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _checkLoHang();
            }
        }

        private Model.LoHang _checkLoHang()
        {
            var db = new Model.dbQLKhoEntities();
            var ob = db.LoHangs.ToList().FirstOrDefault(q => q.SoLuong > 0 && q.MaLoHang.ToString().Equals(txt_MaLoHang.Text));
            if (ob == null)
            {
                dxErrorProvider1.SetError(txt_MaLoHang, "Lô hàng không tồn tại");
                lblNhom.Text = "Lô hàng không tồn tại";
                lblNhom.ForeColor = Color.FromName("RED");
                lblSoLuong.Text = "";
                lblViTri.Text = "";
            }
            else
            {
                var exported = iNhapXuat.GetListXuatKho().Where(q => q.MaLoHang == ob.MaLoHang).Sum(q => q.SoLuong);
                if (exported < ob.SoLuong)
                {
                    dxValidationProvider1.Validate(txt_MaLoHang);
                    lblNhom.Text = string.Format("Nhóm HH: {0} - Loại HH: {1}", ob.HangHoa.NhomHangHoa.TenNHH, ob.HangHoa.TenHH);
                    lblViTri.Text = string.Format("Tầng {0} - Hàng {1} - Cột {2}", ob.Tang, ob.Hang, ob.Cot);
                    num_soLuong.Maximum = (ob.SoLuong - exported) ?? 1;
                    lblNhom.ForeColor = Color.FromName("GREEN");
                    lblSoLuong.Text = "Số lượng còn: " + ((ob.SoLuong - exported) ?? 0);
                }
                else
                {
                    lblNhom.ForeColor = Color.FromName("RED");
                    lblNhom.Text = "Lô hàng đã được xuất hết!";
                    lblSoLuong.Text = "";
                    lblViTri.Text = "";
                    return null;
                }
            }
            return ob;
        }

        private void frmXuatKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}