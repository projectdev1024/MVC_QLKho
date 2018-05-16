using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKho
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm, Code.INotify
    {

        #region FUNCTION

        public void Status(string message = "Sẵn sàng", params object[] args)
        {
            lblStatusSystem.Caption = string.Format(message, args);
        }

        void _openForm(Form f)
        {
            var frm = MdiChildren.FirstOrDefault(q => q.Text == f.Text);
            if (frm == null)
            {
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        void _reload()
        {
            if (COMMON.User == null)
            {
                lblUser.Caption = "Vui lòng đăng nhập";
                btnLogin.Caption = "Đăng nhập";
            }
            else
            {
                lblUser.Caption = COMMON.User.TenNV + " - " + COMMON.User.CV;
                btnLogin.Caption = "Đăng xuất";
            }
            _enableAction();
        }


        /// <summary>
        /// "QuanLy", "Quản lý" => full quyền
        /// "NVKiemKho", "Nhân viên kiểm kho" => chỉ kho 
        /// "NVXuatNhapKho", "Nhân viên xuất nhập kho" => chỉ cho nhập xuất
        /// </summary>
        private void _enableAction()
        {
            var lstAllowClick = new List<BarButtonItem>() { btnLogin };
            if (COMMON.User != null)
            {
                lstAllowClick.Add(btnChangePassword);
                switch (COMMON.User.CV)
                {
                    case "NVKiemKho":
                        lstAllowClick.AddRange(new BarButtonItem[] { 
                        btnKho,
                        btnKho,
                        btnHangHoa
                        });
                        break;
                    case "NVXuatNhapKho":
                        lstAllowClick.AddRange(new BarButtonItem[] { 
                        btnNhapKho,
                        btnXuatKho
                        });
                        break;
                    case "QuanLy":
                    default:
                        break;
                }
            }
            foreach (RibbonPage page in ribbonControlMain.Pages)
            {
                foreach (RibbonPageGroup gr in page.Groups)
                {
                    bool visible = false;
                    foreach (BarButtonItemLink button in gr.ItemLinks)
                    {
                        if (lstAllowClick.Contains(button.Item) || (COMMON.User != null && COMMON.User.CV == "QuanLy"))
                        {
                            lstAllowClick.Remove(button.Item);
                            button.Item.Visibility = BarItemVisibility.Always;
                            visible = true;
                        }
                        else
                        {
                            button.Item.Visibility = BarItemVisibility.Never;
                        }
                    }
                    gr.Visible = visible;
                }
            }
        }

        #endregion

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeSystem.Caption = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTimeSystem.Caption = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
            timer1.Enabled = true;
            Status();
            _reload();
            new frmLogin().ShowDialog();
            _reload();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _login();
        }

        private void _login()
        {
            COMMON.User = null;
            foreach (var item in MdiChildren)
            {
                item.Close();
            }
            new frmLogin().ShowDialog();
            _reload();
        }

        private void btnNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _openForm(new frmManager(new Code.frmManager_NhaCungCap(), this));
        }

        private void btnNhomHH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _openForm(new frmManager(new Code.frmManager_NhomHangHoa(), this));
        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _openForm(new frmManager(new Code.frmManager_HangHoa(), this));
        }

        private void btnNhaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _openForm(new frmManager(new Code.frmManager_NhaKho(), this));
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _openForm(new frmManager(new Code.frmManager_NhanVien(), this));
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            _openForm(new frmManager_LoHang(this));
        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (new frmChangePassword().ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                _login();
            }
        }

        private void btnNhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            _openForm(new frmBCNhapKho(this));
        }

        private void btnXuatKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            _openForm(new frmBCXuatKho(this));
        }
    }
}
