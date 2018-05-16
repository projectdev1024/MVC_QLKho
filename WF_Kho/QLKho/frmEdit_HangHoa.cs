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
    public partial class frmEdit_HangHoa : Form, IFormBase
    {
        HangHoa mObj;
        public bool IsCreate { get; set; }
        public frmEdit_HangHoa(HangHoa obj)
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
                mObj = value as HangHoa;
            }
        }

        bool validate()
        {
            var r = true;
            dxErrorProvider1.ClearErrors();
            r = r && txtTenHH.ValidateControl(txtMaHangHoa.Text, @"^.+$", dxErrorProvider1);
            r = r && txtTenHH.ValidateControl(txtTenHH.Text, @"^.+$", dxErrorProvider1);
            r = r && cmbNhomHH.ValidateControl(cmbNhomHH.EditValue, @"^.+$", dxErrorProvider1);
            return r;
        }

        public void Save()
        {
            if (IsCreate)
            {
                if (new dbQLKhoEntities().HangHoas.ToList().Any(q => q.IsDelete != true && q.ID_NHH.Equals(txtMaHangHoa.Text.Trim())))
                {
                    MessageBox.Show("Mã hàng hóa này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (validate())
            {
                mObj.MaHH = txtMaHangHoa.Text.Trim();
                mObj.TenHH = txtTenHH.Text;
                mObj.ID_NHH = cmbNhomHH.EditValue.ToString();
                mObj.MoTa = rtbMoTa.Text;
                mObj.SoLuongTon = 0;
                DialogResult = System.Windows.Forms.DialogResult.Yes;
                Close();
            }
        }

        public void Cancel()
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

        private void frmEdit_HangHoa_Load(object sender, EventArgs e)
        {
            cmbNhomHH.CreateLookUp(new dbQLKhoEntities().NhomHangHoas.ToList().Where(q => q.IsDelete == false).ToList(),
                "ID_NHH", "TenNHH",
                null);
            if (mObj != null)
            {
                txtMaHangHoa.Text = mObj.MaHH;
                txtTenHH.Text = mObj.TenHH;
                rtbMoTa.Text = mObj.MoTa;
                cmbNhomHH.EditValue = mObj.ID_NHH;
            }
            if (IsCreate == false)
            {
                txtMaHangHoa.Properties.ReadOnly = true;
            }
        }
    }
}
