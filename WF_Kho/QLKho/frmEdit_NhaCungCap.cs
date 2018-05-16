using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.Code;
using QLKho.Model;

namespace QLKho
{
    public partial class frmEdit_NhaCungCap : Form , IFormBase
    {
        NhaCungCap mObj;
        public bool IsCreate { get; set; }
        public frmEdit_NhaCungCap(NhaCungCap obj)
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
                mObj = value as NhaCungCap;
            }
        }

        public void Save()
        {
            if (IsCreate)
            {
                if (new dbQLKhoEntities().NhaCungCaps.ToList().Any(q => q.IsDelete != true && q.MaNCC.Equals(txtMaNCC.Text.Trim())))
                {
                    MessageBox.Show("Mã nhà cung cấp này đã tồn tại!");
                    return;
                }
                mObj.MaNCC = txtMaNCC.Text.Trim();
            }
            mObj.TenNCC = txtTenNCC.Text;
            mObj.DiaChi = txtDiaChi.Text;
            mObj.SDT = txtSDT.Text;
            mObj.Web = txtWebsite.Text;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Close();
        }

        public void Cancel()
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            if (mObj != null)
            {
                txtMaNCC.Text = mObj.MaNCC;
                txtTenNCC.Text = mObj.TenNCC;
                txtDiaChi.Text = mObj.DiaChi;
                txtWebsite.Text = mObj.Web;
                txtSDT.Text = mObj.SDT;
            }
            if (IsCreate == false)
            {
                txtMaNCC.ReadOnly = true;
            }
        }

    }
}
