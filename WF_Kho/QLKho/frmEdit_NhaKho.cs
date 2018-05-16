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
    public partial class frmEdit_NhaKho : Form, IFormBase
    {
        NhaKho mObj;
        public frmEdit_NhaKho(NhaKho obj)
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
                mObj = value as NhaKho;
            }
        }

        public void Save()
        {
            mObj.SoHang = (int)numSoHang.Value;
            mObj.SoTang = (int)numSoTang.Value;
            mObj.SoCot = (int)numSoCot.Value;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Close();
        }

        public void Cancel()
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            Close();
        }

        private void frmNhaKho_Load(object sender, EventArgs e)
        {
            var dic = new Dictionary<string, string>();
            dic.Add("DaXoa", "Đã xóa");
            dic.Add("SanSang", "Sẵn sàng");
            dic.Add("Full", "Đầy kho");
            dic.Add("SuaChua", "Đang sửa chữa");
            lookupStatus.CreateLookUp(dic, "Key", "Value", null);
            if (mObj != null)
            {
                numSoTang.Value = mObj.SoTang ?? 1;
                numSoHang.Value = mObj.SoHang ?? 1;
                numSoCot.Value = mObj.SoCot ?? 1;
                lookupStatus.EditValue = mObj.Status;
            }
        }
    }
}
