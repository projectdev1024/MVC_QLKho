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
    public partial class frmEdit_NhanVien : Form, IFormBase
    {
        NhanVien mObj;
        public frmEdit_NhanVien(NhanVien obj)
        {
            InitializeComponent();
            ucBaseEdit1.iFormBase = this;
            mObj = obj;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public object TResult
        {
            get
            {
                return mObj;
            }
            set
            {
                mObj = value as NhanVien;
            }
        }

        public void Save()
        {
            mObj.MaNV = txtMaNV.Text;
            mObj.CV = lookupCV.EditValue.ToString();
            mObj.PB = txtPhongBan.Text;
            mObj.MatKhau = txtMK.Text;
            mObj.TenNV = txtHoTen.Text;
            mObj.MT = rtbMoTa.Text;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Close();
        }

        public void Cancel()
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

        private void frmEdit_NhanVien_Load(object sender, EventArgs e)
        {
            var data = new Dictionary<string, string>();
            data.Add("QuanLy", "Quản lý");
            data.Add("NVKiemKho", "Nhân viên kiểm kho");
            data.Add("NVXuatNhapKho", "Nhân viên xuất nhập kho");
            lookupCV.CreateLookUp(data.ToList(),
                "Key", "Value",
                null,
                new LookUpColumnInfo("Value", "Chức vụ")
                );
            if (mObj != null)
            {
                txtMaNV.Text = mObj.MaNV;
                lookupCV.EditValue = mObj.CV;
                txtPhongBan.Text = mObj.PB;
                txtMK.Text = mObj.MatKhau;
                txtHoTen.Text = mObj.TenNV;
                rtbMoTa.Text = mObj.MT;
                if (string.IsNullOrEmpty(mObj.MaNV) == false)
                {
                    txtMaNV.Properties.ReadOnly = true;
                    layoutMK.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
            }
        }
    }
}
