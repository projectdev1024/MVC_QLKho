namespace QLKho
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lblTimeSystem = new DevExpress.XtraBars.BarStaticItem();
            this.lblStatusSystem = new DevExpress.XtraBars.BarStaticItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.lblUser = new DevExpress.XtraBars.BarStaticItem();
            this.btnHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhomHH = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNCC = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatKho = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonLogin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.lblTimeSystem,
            this.lblStatusSystem,
            this.btnChangePassword,
            this.btnLogin,
            this.btnKho,
            this.lblUser,
            this.btnHangHoa,
            this.btnNhomHH,
            this.btnNhaKho,
            this.btnNhanVien,
            this.btnNCC,
            this.btnNhapKho,
            this.btnXuatKho});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 17;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.PageHeaderItemLinks.Add(this.lblUser);
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControlMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControlMain.Size = new System.Drawing.Size(1070, 147);
            this.ribbonControlMain.StatusBar = this.ribbonStatusBar1;
            // 
            // lblTimeSystem
            // 
            this.lblTimeSystem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblTimeSystem.Caption = "lblTimeSystem";
            this.lblTimeSystem.Glyph = ((System.Drawing.Image)(resources.GetObject("lblTimeSystem.Glyph")));
            this.lblTimeSystem.Id = 1;
            this.lblTimeSystem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("lblTimeSystem.LargeGlyph")));
            this.lblTimeSystem.Name = "lblTimeSystem";
            this.lblTimeSystem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblStatusSystem
            // 
            this.lblStatusSystem.Caption = "lblStatusSystem";
            this.lblStatusSystem.Id = 2;
            this.lblStatusSystem.Name = "lblStatusSystem";
            this.lblStatusSystem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 3;
            this.btnChangePassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.LargeGlyph")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 4;
            this.btnLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogin.LargeGlyph")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Quản lý kho";
            this.btnKho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKho.Glyph")));
            this.btnKho.Id = 5;
            this.btnKho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKho.LargeGlyph")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // lblUser
            // 
            this.lblUser.Caption = "lblUser";
            this.lblUser.Id = 6;
            this.lblUser.Name = "lblUser";
            this.lblUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Caption = "Hàng hóa";
            this.btnHangHoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHangHoa.Glyph")));
            this.btnHangHoa.Id = 7;
            this.btnHangHoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHangHoa.LargeGlyph")));
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHangHoa_ItemClick);
            // 
            // btnNhomHH
            // 
            this.btnNhomHH.Caption = "Nhóm hàng hóa";
            this.btnNhomHH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhomHH.Glyph")));
            this.btnNhomHH.Id = 8;
            this.btnNhomHH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhomHH.LargeGlyph")));
            this.btnNhomHH.Name = "btnNhomHH";
            this.btnNhomHH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhomHH_ItemClick);
            // 
            // btnNhaKho
            // 
            this.btnNhaKho.Caption = "Nhà kho";
            this.btnNhaKho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhaKho.Glyph")));
            this.btnNhaKho.Id = 9;
            this.btnNhaKho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhaKho.LargeGlyph")));
            this.btnNhaKho.Name = "btnNhaKho";
            this.btnNhaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhaKho_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 10;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnNCC
            // 
            this.btnNCC.Caption = "Nhà cung cấp";
            this.btnNCC.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNCC.Glyph")));
            this.btnNCC.Id = 11;
            this.btnNCC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNCC.LargeGlyph")));
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNCC_ItemClick);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Caption = "Nhập kho";
            this.btnNhapKho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.Glyph")));
            this.btnNhapKho.Id = 15;
            this.btnNhapKho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.LargeGlyph")));
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapKho_ItemClick);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Caption = "Xuất kho";
            this.btnXuatKho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuatKho.Glyph")));
            this.btnXuatKho.Id = 16;
            this.btnXuatKho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXuatKho.LargeGlyph")));
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatKho_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonLogin});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HOME";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "KHO";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNCC);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhaKho);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHangHoa);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhomHH);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "DANH MỤC";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapKho);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXuatKho);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "HÓA ĐƠN";
            // 
            // ribbonLogin
            // 
            this.ribbonLogin.AllowTextClipping = false;
            this.ribbonLogin.ItemLinks.Add(this.btnChangePassword);
            this.ribbonLogin.ItemLinks.Add(this.btnLogin);
            this.ribbonLogin.Name = "ribbonLogin";
            this.ribbonLogin.ShowCaptionButton = false;
            this.ribbonLogin.Text = "TÀI KHOẢN";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lblTimeSystem);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblStatusSystem);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 698);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControlMain;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1070, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControlMain;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "NHẬP XUẤT KHO";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 721);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControlMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "HỆ THỐNG QUẢN LÝ KHO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem lblTimeSystem;
        private DevExpress.XtraBars.BarStaticItem lblStatusSystem;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonLogin;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarStaticItem lblUser;
        private DevExpress.XtraBars.BarButtonItem btnHangHoa;
        private DevExpress.XtraBars.BarButtonItem btnNhomHH;
        private DevExpress.XtraBars.BarButtonItem btnNhaKho;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnNCC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnNhapKho;
        private DevExpress.XtraBars.BarButtonItem btnXuatKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

