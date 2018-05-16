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
using QLKho.Model;

namespace QLKho
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new dbQLKhoEntities();
            var ob = db.NhanViens.ToList().FirstOrDefault(q => q.MaNV.Equals(txtUsername.Text)
                && q.MatKhau.Equals(txtPassword.Text)
                && q.IsDelete == false);
            if (ob != null)
            {
                COMMON.User = ob;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}