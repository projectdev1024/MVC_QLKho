using DevExpress.XtraEditors.Controls;
using QLKho.Code;
using QLKho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho
{
    public partial class frmEdit_LoHang : Form, IFormBase
    {
        LoHang mObj;
        public frmEdit_LoHang(LoHang obj)
        {
            InitializeComponent();
            ucBaseEdit1.iFormBase = this;
            mObj = obj;
            StartPosition = FormStartPosition.CenterScreen;
            num_SoLuong.Maximum = int.MaxValue;
            num_SoLuong.Minimum = 1;
            num_SoLuong.Value = 1;
        }

        public object TResult
        {
            get
            {
                return mObj;
            }
            set
            {
                mObj = value as LoHang;
            }
        }

        bool validate()
        {
            dxErrorProvider1.ClearErrors();
            var r = true;
            r = r && date_HSD.ValidateControl(date_HSD.EditValue, @".+", dxErrorProvider1);
            r = r && date_NSX.ValidateControl(date_NSX.EditValue, @".+", dxErrorProvider1);
            r = r && num_SoLuong.ValidateControl(num_SoLuong.Value, @"^\d+$", dxErrorProvider1);
            r = r && lookup_MaNCC.ValidateControl(lookup_MaNCC.EditValue, @"^.+$", dxErrorProvider1);
            r = r && lookup_MaHH.ValidateControl(lookup_MaHH.EditValue, @"^.+$", dxErrorProvider1);
            return r;
        }


        public void Save()
        {
            if (validate() == false) return;
            mObj.HSD = (DateTime)date_HSD.EditValue;
            mObj.NSX = (DateTime)date_NSX.EditValue;
            mObj.SoLuong = (int)num_SoLuong.Value;
            mObj.MaNCC = lookup_MaNCC.EditValue.ToString();
            mObj.MaHH = lookup_MaHH.EditValue.ToString();
            mObj.Status = 1;
            mObj.NhaCungCap = lookup_MaNCC.GetSelectedDataRow() as NhaCungCap;
            mObj.HangHoa = lookup_MaHH.GetSelectedDataRow() as HangHoa;
            DialogResult = System.Windows.Forms.DialogResult.Yes;

            mObj.HangHoa.SoLuongTon += mObj.SoLuong;
            Close();
        }

        public void Cancel()
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

        private void frmEdit_LoHang_Load(object sender, EventArgs e)
        {
            _loadMaHH();
            _loadNCC();
            if (mObj != null)
            {
                date_HSD.EditValue = mObj.HSD;
                date_NSX.EditValue = mObj.NSX;
                num_SoLuong.Value = mObj.SoLuong ?? 1;
                lookup_MaNCC.EditValue = mObj.MaNCC;
                lookup_MaHH.EditValue = mObj.MaHH;
            }
        }

        private void _loadMaHH()
        {
            lookup_MaHH.CreateLookUp(new dbQLKhoEntities().HangHoas.ToList().Where(q => q.IsDelete != true).ToList(), "MaHH", "TenHH", null);
        }

        private void _loadNCC()
        {
            lookup_MaNCC.CreateLookUp(new dbQLKhoEntities().NhaCungCaps.ToList().Where(q => q.IsDelete != true).ToList(), "MaNCC", "TenNCC", null);
        }

        private void btnAddNHH_Click(object sender, EventArgs e)
        {
            _kiemTraNHH();
        }

        private void _kiemTraNHH()
        {
            if (string.IsNullOrWhiteSpace(txt_MaHH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhóm hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new Model.dbQLKhoEntities();
            var ob = db.HangHoas.ToList().FirstOrDefault(q => q.IsDelete != true && q.MaHH.Equals(txt_MaHH.Text.Trim()));
            if (ob == null)
            {
                var frm = new frmEdit_HangHoa(new HangHoa { MaHH = txt_MaHH.Text.Trim() });
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    var value = frm.TResult as HangHoa;
                    value.IsDelete = false;
                    db.HangHoas.Add(value);
                    if (db.SaveChanges() > 0)
                    {
                        _loadMaHH();
                        lookup_MaHH.EditValue = value.MaHH;
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                lookup_MaHH.EditValue = ob.MaHH;
            }
        }

        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            _kiemTraNCC();
        }

        private void _kiemTraNCC()
        {
            if (string.IsNullOrWhiteSpace(txt_MaHH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new Model.dbQLKhoEntities();
            var ob = db.NhaCungCaps.ToList().FirstOrDefault(q => q.IsDelete != true && q.MaNCC.Equals(txt_MaNCC.Text.Trim()));
            if (ob == null)
            {
                var frm = new frmEdit_NhaCungCap(new NhaCungCap { MaNCC = txt_MaNCC.Text.Trim() });
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    var value = frm.TResult as NhaCungCap;
                    value.IsDelete = false;
                    db.NhaCungCaps.Add(value);
                    if (db.SaveChanges() > 0)
                    {
                        _loadNCC();
                        lookup_MaNCC.EditValue = value.MaNCC;
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                lookup_MaNCC.EditValue = ob.MaNCC;
            }
        }

        private void lookup_MaNCC_EditValueChanged(object sender, EventArgs e)
        {
            txt_MaNCC.Text = lookup_MaNCC.EditValue.ToString();
        }

        private void lookup_MaHH_EditValueChanged(object sender, EventArgs e)
        {
            txt_MaHH.Text = lookup_MaHH.EditValue.ToString();
        }

        private void txt_MaHH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _kiemTraNHH();
            }
        }

        private void txt_MaNCC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _kiemTraNCC();
        }
    }
}
