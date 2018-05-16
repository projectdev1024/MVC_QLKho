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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Length < 8 || txtRePass.Text.Length < 8)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới có ít nhất 8 kí tự", "Thông báo");
            }
            else if (txtNewPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới trùng nhau", "Thông báo");
            }
            else
            {
                var db = new Model.dbQLKhoEntities();
                var user = db.NhanViens.ToList().FirstOrDefault(q => q.MaNV == COMMON.User.MaNV);
                if (user == null)
                {
                    this.Close();
                }
                else if (user.MatKhau == txtOldPass.Text)
                {
                    user.MatKhau = txtNewPass.Text;
                    bool kq = db.SaveChanges() > 0;
                    MessageBox.Show(kq ? "Đổi mật khẩu thành công" : "Đổi mật khẩu thất bại", "Thông báo");
                    DialogResult = kq ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác","Thông báo");
                }
            }
        }
    }
}
