namespace QLKho
{
    partial class frmManager_LoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_LoHang));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.search = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNhapKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gr_main = new DevExpress.XtraEditors.GroupControl();
            this.xtra_main = new DevExpress.XtraEditors.XtraScrollableControl();
            this.btnClearSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr_main)).BeginInit();
            this.gr_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.search);
            this.groupControl1.Controls.Add(this.btnNhapKho);
            this.groupControl1.Controls.Add(this.btnXuatKho);
            this.groupControl1.Controls.Add(this.btnClearSearch);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1277, 62);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TÙY CHỌN TÌM KIẾM";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(5, 27);
            this.search.Name = "search";
            this.search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.search.Properties.View = this.searchLookUpEdit1View;
            this.search.Size = new System.Drawing.Size(329, 20);
            this.search.TabIndex = 4;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ HÀNG HÓA";
            this.gridColumn1.FieldName = "MaHH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TÊN HÀNG HÓA";
            this.gridColumn2.FieldName = "TenHH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.Image")));
            this.btnNhapKho.Location = new System.Drawing.Point(711, 15);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(108, 44);
            this.btnNhapKho.TabIndex = 2;
            this.btnNhapKho.Text = "NHẬP KHO";
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatKho.Image")));
            this.btnXuatKho.Location = new System.Drawing.Point(597, 15);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(108, 44);
            this.btnXuatKho.TabIndex = 2;
            this.btnXuatKho.Text = "XUẤT KHO";
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(340, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 44);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gr_main
            // 
            this.gr_main.AllowTouchScroll = true;
            this.gr_main.AutoSize = true;
            this.gr_main.Controls.Add(this.xtra_main);
            this.gr_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_main.Location = new System.Drawing.Point(0, 62);
            this.gr_main.Name = "gr_main";
            this.gr_main.Size = new System.Drawing.Size(1277, 628);
            this.gr_main.TabIndex = 1;
            this.gr_main.Text = "DANH SÁCH LÔ HÀNG";
            // 
            // xtra_main
            // 
            this.xtra_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtra_main.Location = new System.Drawing.Point(2, 21);
            this.xtra_main.Name = "xtra_main";
            this.xtra_main.Size = new System.Drawing.Size(1273, 605);
            this.xtra_main.TabIndex = 0;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.Image")));
            this.btnClearSearch.Location = new System.Drawing.Point(451, 15);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(140, 44);
            this.btnClearSearch.TabIndex = 1;
            this.btnClearSearch.Text = "CLEAR TÌM KIẾM";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // frmManager_LoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 690);
            this.Controls.Add(this.gr_main);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmManager_LoHang";
            this.Text = "QUẢN LÝ LÔ HÀNG TRONG KHO";
            this.Load += new System.EventHandler(this.frmManager_LoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr_main)).EndInit();
            this.gr_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl gr_main;
        private DevExpress.XtraEditors.XtraScrollableControl xtra_main;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNhapKho;
        private DevExpress.XtraEditors.SimpleButton btnXuatKho;
        private DevExpress.XtraEditors.SearchLookUpEdit search;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnClearSearch;


    }
}