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
    public partial class frmEdit_XuatKho : Form, IFormBase
    {
        CT_XuatKho mObj;
        public int MaxValue { get; set; }
        public frmEdit_XuatKho(CT_XuatKho obj)
        {
            InitializeComponent();
            ucBaseEdit1.iFormBase = this;
            mObj = obj;
            StartPosition = FormStartPosition.CenterScreen;
            num_SoLuong.Maximum = int.MaxValue;
        }

        public object TResult
        {
            get
            {
                return mObj;
            }
            set
            {
                mObj = value as CT_XuatKho;
            }
        }

        public void Save()
        {
            mObj.SoLuong = (int)num_SoLuong.Value;
            mObj.Note = rtb_Note.Text;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Close();
        }

        public void Cancel()
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

        private void frmEdit_XuatKho_Load(object sender, EventArgs e)
        {
            if (mObj != null)
            {
                num_SoLuong.Value = mObj.SoLuong ?? 0;
                rtb_Note.Text = mObj.Note;
            }
            num_SoLuong.Maximum = MaxValue;
        }
    }
}
