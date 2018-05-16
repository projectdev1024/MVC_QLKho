namespace QLKho.UC
{
    partial class ucViTri
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViTri));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMove = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrangThai = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapXuat = new DevExpress.XtraEditors.SimpleButton();
            this.gr_main = new DevExpress.XtraEditors.GroupControl();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_NSX_HSD = new System.Windows.Forms.Label();
            this.lbl_tenHH = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr_main)).BeginInit();
            this.gr_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(181, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 135);
            this.barDockControlBottom.Size = new System.Drawing.Size(181, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 135);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(181, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 135);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMove);
            this.panel1.Controls.Add(this.btnTrangThai);
            this.panel1.Controls.Add(this.btnNhapXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 34);
            this.panel1.TabIndex = 12;
            // 
            // btnMove
            // 
            this.btnMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMove.Image")));
            this.btnMove.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMove.Location = new System.Drawing.Point(119, 0);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(62, 34);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "D.Chuyển";
            this.btnMove.Visible = false;
            // 
            // btnTrangThai
            // 
            this.btnTrangThai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrangThai.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangThai.Image")));
            this.btnTrangThai.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTrangThai.Location = new System.Drawing.Point(68, 0);
            this.btnTrangThai.Name = "btnTrangThai";
            this.btnTrangThai.Size = new System.Drawing.Size(51, 34);
            this.btnTrangThai.TabIndex = 3;
            this.btnTrangThai.Text = "T.Thái";
            this.btnTrangThai.Click += new System.EventHandler(this.btnTrangThai_Click);
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhapXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapXuat.Image")));
            this.btnNhapXuat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNhapXuat.Location = new System.Drawing.Point(0, 0);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(68, 34);
            this.btnNhapXuat.TabIndex = 4;
            this.btnNhapXuat.Text = "Nhập/xuất";
            this.btnNhapXuat.Click += new System.EventHandler(this.btnNhapXuat_Click);
            // 
            // gr_main
            // 
            this.gr_main.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gr_main.Appearance.Options.UseBackColor = true;
            this.gr_main.Controls.Add(this.lbl_Status);
            this.gr_main.Controls.Add(this.lbl_SoLuong);
            this.gr_main.Controls.Add(this.lbl_NSX_HSD);
            this.gr_main.Controls.Add(this.lbl_tenHH);
            this.gr_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_main.Location = new System.Drawing.Point(0, 0);
            this.gr_main.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gr_main.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gr_main.Name = "gr_main";
            this.gr_main.Size = new System.Drawing.Size(181, 101);
            this.gr_main.TabIndex = 18;
            this.gr_main.Text = "gr_main";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(14, 74);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(46, 13);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "mStatus";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(12, 21);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(48, 13);
            this.lbl_SoLuong.TabIndex = 11;
            this.lbl_SoLuong.Text = "SoLuong";
            // 
            // lbl_NSX_HSD
            // 
            this.lbl_NSX_HSD.AutoSize = true;
            this.lbl_NSX_HSD.Location = new System.Drawing.Point(12, 48);
            this.lbl_NSX_HSD.Name = "lbl_NSX_HSD";
            this.lbl_NSX_HSD.Size = new System.Drawing.Size(56, 13);
            this.lbl_NSX_HSD.TabIndex = 9;
            this.lbl_NSX_HSD.Text = "NSX - HSD";
            // 
            // lbl_tenHH
            // 
            this.lbl_tenHH.AutoSize = true;
            this.lbl_tenHH.Location = new System.Drawing.Point(66, 21);
            this.lbl_tenHH.Name = "lbl_tenHH";
            this.lbl_tenHH.Size = new System.Drawing.Size(39, 13);
            this.lbl_tenHH.TabIndex = 8;
            this.lbl_tenHH.Text = "TenHH";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucViTri
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gr_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucViTri";
            this.Size = new System.Drawing.Size(181, 135);
            this.Load += new System.EventHandler(this.ucViTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gr_main)).EndInit();
            this.gr_main.ResumeLayout(false);
            this.gr_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnMove;
        private DevExpress.XtraEditors.SimpleButton btnTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnNhapXuat;
        private DevExpress.XtraEditors.GroupControl gr_main;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_NSX_HSD;
        private System.Windows.Forms.Label lbl_tenHH;
        private System.Windows.Forms.Timer timer1;


    }
}
