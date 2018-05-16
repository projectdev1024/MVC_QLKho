using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKho.Model;

namespace QLKho.UC
{
    public partial class ucViTri : DevExpress.XtraEditors.XtraUserControl
    {
        public enum eStatus
        {
            Trong, CoHang, SuaChua, Importing, Exporting, None
        }
        public Code.INhapXuat iNhapXuat { get; set; }
        public LoHang mLoHang { get; set; }
        public bool HasValue { get; set; }
        public eStatus mStatus { get; set; }
        public int mTang { get; set; }
        public int mHang { get; set; }
        public int mCot { get; set; }
        public int ID_NhaKho { get; set; }
        public ucViTri()
        {
            InitializeComponent();
        }

        public void Reload(bool isSuaChua)
        {
            HasValue = mLoHang != null;
            mStatus = HasValue ? eStatus.CoHang : isSuaChua ? eStatus.SuaChua : eStatus.Trong;
        }

        void _reload()
        {
            HasValue = mLoHang != null;
            gr_main.Text = HasValue ? ("Mã lô hàng: " + mLoHang.MaLoHang) : string.Format("Hàng{0}-Cột{1} <{2}>", mHang, mCot, mStatus.ToString());
            lbl_NSX_HSD.Text = HasValue ? string.Format("{0} - {1}", mLoHang.NSX.Value.ToShortDateString(), mLoHang.HSD.Value.ToShortDateString()) : "<trống>";
            lbl_SoLuong.Text = HasValue ? ("Còn " + mLoHang.SoLuong) : "<trống>";
            lbl_tenHH.Text = HasValue ? mLoHang.HangHoa.TenHH : "<trống>";
            btnNhapXuat.Text = HasValue ? "Xuất hàng" : "Nhập hàng";
            _checkStatus();
        }

        void _checkStatus()
        {
            Color color = Color.Aqua;
            switch (mStatus)
            {
                case eStatus.Trong:
                    color = Color.FromArgb(143, 234, 147);
                    break;
                case eStatus.CoHang:
                    color = Color.FromArgb(232, 208, 157);
                    break;
                case eStatus.SuaChua:
                    color = Color.FromArgb(204, 119, 104);
                    break;
                case eStatus.Importing:
                    color = Color.FromArgb(64, 232, 181);
                    break;
                case eStatus.Exporting:
                    color = Color.FromArgb(167, 118, 237);
                    break;
                default:
                    color = Color.FromArgb(163, 163, 163);
                    break;
            }
            lbl_Status.Text = mStatus.ToString();// HasValue ? mLoHang.Status mStatus : mStatus.ToString();
            gr_main.BackColor = color;
        }

        private void ucViTri_Load(object sender, EventArgs e)
        {
            _reload();
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            if (HasValue)
            {
                if (mLoHang.SoLuong > 0)
                {
                    var f = new frmEdit_XuatKho(new CT_XuatKho()
                    {
                        MaLoHang = mLoHang.MaLoHang,
                        Note = "",
                        LoHang = mLoHang,
                        SoLuong = 1
                    });
                    f.MaxValue = mLoHang.SoLuong ?? 0;
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        iNhapXuat.XuatKho(f.TResult as CT_XuatKho);
                        mStatus = eStatus.Exporting;
                        mLoHang.SoLuong -= (f.TResult as CT_XuatKho).SoLuong;
                        _reload();
                    }
                }
                else
                {
                    MessageBox.Show("Lô hàng này đã hết sản phẩm có thể xuất kho!");
                }
            }
            else if (mStatus == eStatus.SuaChua)
            {
                MessageBox.Show("Vị trí này đang được sửa chữa");
            }
            else if (mStatus == eStatus.Importing)
            {
                MessageBox.Show("Vị trí này đang đã được nhập");
            }
            else if (mStatus == eStatus.Exporting)
            {
                MessageBox.Show("Vị trí này đang được được xuất");
            }
            else
            {
                var f = new frmEdit_LoHang(new LoHang()
                {
                    Cot = mCot,
                    Hang = mHang,
                    Tang = mTang,
                    ID_NhaKho = ID_NhaKho
                });
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    iNhapXuat.NhapKho(f.TResult as LoHang);
                    mStatus = eStatus.Importing;
                    mLoHang = f.TResult as LoHang;
                    _reload();
                }
            }
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            if (mStatus == eStatus.SuaChua && MessageBox.Show("Vị trí này đã được sửa chữa xong?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new dbQLKhoEntities();
                var ob = db.VitriSuas.ToList().FirstOrDefault(q => q.Tang == mTang && q.Hang == mHang && q.Cot == mCot);
                if (ob != null)
                {
                    db.VitriSuas.Remove(ob);
                    if (db.SaveChanges() > 0)
                    {
                        mStatus = eStatus.Trong;
                        _reload();
                    }
                    else MessageBox.Show("Chuyển trạng thái thất bại?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if ((mStatus == eStatus.Trong || mStatus == eStatus.None) && MessageBox.Show("Bạn muốn sửa chữa vị trí này?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new dbQLKhoEntities();
                var ob = db.VitriSuas.ToList().FirstOrDefault(q => q.Tang == mTang && q.Hang == mHang && q.Cot == mCot);
                if (ob == null)
                {
                    db.VitriSuas.Add(new VitriSua
                    {
                        Cot = mCot,
                        Hang = mHang,
                        ID_NhaKho = ID_NhaKho,
                        Note = "",
                        Tang = mTang
                    });
                    if (db.SaveChanges() > 0)
                    {
                        mStatus = eStatus.SuaChua;
                        _reload();
                    }
                    else
                    {
                        MessageBox.Show("Chuyển trạng thái thất bại?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else MessageBox.Show("Vị trí này không thể Chuyển sang trạng thái khác?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        }


        public void UpdateValue(int SoLuong)
        {
            mLoHang.SoLuong += SoLuong;
            mStatus = SoLuong > 0 ? eStatus.Importing : eStatus.Exporting;
            _reload();
        }

        internal void HightLight()
        {
            timer1.Enabled = true;
        }

        internal void ClearHightLight()
        {
            timer1.Enabled = false;
            _checkStatus();
        }

        bool isOld = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr_main.BackColor = isOld ? Color.FromArgb(139, 175, 239) : Color.FromArgb(178, 71, 110);
            gr_main.ForeColor = isOld ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255, 255, 255);
            isOld = !isOld;
        }
    }
}
