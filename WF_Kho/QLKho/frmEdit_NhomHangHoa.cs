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
    public partial class frmEdit_NhomHangHoa : Form, IFormBase
    {
        NhomHangHoa mObj;
        public bool IsCreate { get; set; }
        public frmEdit_NhomHangHoa(NhomHangHoa obj)
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
                mObj = value as NhomHangHoa;
            }
        }

        public void Save()
        {
            if (IsCreate)
            {
                if (new dbQLKhoEntities().NhomHangHoas.ToList().Any(q => q.IsDelete != true && q.ID_NHH.Equals(txtMaHangHoa.Text.Trim())))
                {
                    MessageBox.Show("Mã nhóm hàng hóa này đã tồn tại!");
                    return;
                }
            }
            mObj.ID_NHH = txtMaHangHoa.Text;
            mObj.TenNHH = txtTenNHH.Text;
            mObj.ID_NHH = txtMaHangHoa.Text.Trim();
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Close();
        }

        public void Cancel()
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

        private void frmNhomHangHoa_Load(object sender, EventArgs e)
        {
            if (mObj != null)
            {
                txtTenNHH.Text = mObj.TenNHH;
                txtMaHangHoa.Text = mObj.ID_NHH;
            }
            if (IsCreate == false)
            {
                txtMaHangHoa.Properties.ReadOnly = true;
            }
        }

    }
}
