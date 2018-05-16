namespace QLKho
{
    partial class frmBCNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCNhapKho));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cb_MaPhieu = new System.Windows.Forms.CheckBox();
            this.cb_KhoangThoiGian = new System.Windows.Forms.CheckBox();
            this.txt_MaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.date_end = new DevExpress.XtraEditors.DateEdit();
            this.date_start = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grctrl_main = new DevExpress.XtraGrid.GridControl();
            this.grv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grctrl_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cb_MaPhieu);
            this.groupControl1.Controls.Add(this.cb_KhoangThoiGian);
            this.groupControl1.Controls.Add(this.txt_MaPhieu);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.btnBaoCao);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.date_end);
            this.groupControl1.Controls.Add(this.date_start);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1019, 88);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "TÌM KIẾM";
            // 
            // cb_MaPhieu
            // 
            this.cb_MaPhieu.AutoSize = true;
            this.cb_MaPhieu.Location = new System.Drawing.Point(76, 58);
            this.cb_MaPhieu.Name = "cb_MaPhieu";
            this.cb_MaPhieu.Size = new System.Drawing.Size(96, 17);
            this.cb_MaPhieu.TabIndex = 5;
            this.cb_MaPhieu.Text = "Mã phiếu nhập";
            this.cb_MaPhieu.UseVisualStyleBackColor = true;
            // 
            // cb_KhoangThoiGian
            // 
            this.cb_KhoangThoiGian.AutoSize = true;
            this.cb_KhoangThoiGian.Location = new System.Drawing.Point(76, 34);
            this.cb_KhoangThoiGian.Name = "cb_KhoangThoiGian";
            this.cb_KhoangThoiGian.Size = new System.Drawing.Size(106, 17);
            this.cb_KhoangThoiGian.TabIndex = 5;
            this.cb_KhoangThoiGian.Text = "Khoảng thời gian";
            this.cb_KhoangThoiGian.UseVisualStyleBackColor = true;
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(188, 56);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Size = new System.Drawing.Size(244, 20);
            this.txt_MaPhieu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.Location = new System.Drawing.Point(576, 33);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(110, 42);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(460, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // date_end
            // 
            this.date_end.EditValue = null;
            this.date_end.Location = new System.Drawing.Point(332, 30);
            this.date_end.Name = "date_end";
            this.date_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_end.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_end.Size = new System.Drawing.Size(100, 20);
            this.date_end.TabIndex = 0;
            // 
            // date_start
            // 
            this.date_start.EditValue = null;
            this.date_start.Location = new System.Drawing.Point(188, 31);
            this.date_start.Name = "date_start";
            this.date_start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_start.Size = new System.Drawing.Size(107, 20);
            this.date_start.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grctrl_main);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 88);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1019, 591);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "DỮ LIỆU";
            // 
            // grctrl_main
            // 
            this.grctrl_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.grctrl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrl_main.Location = new System.Drawing.Point(2, 21);
            this.grctrl_main.MainView = this.grv_main;
            this.grctrl_main.Name = "grctrl_main";
            this.grctrl_main.Size = new System.Drawing.Size(1015, 568);
            this.grctrl_main.TabIndex = 0;
            this.grctrl_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_main});
            // 
            // grv_main
            // 
            this.grv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.grv_main.GridControl = this.grctrl_main;
            this.grv_main.Name = "grv_main";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ PHIẾU NHẬP";
            this.gridColumn1.FieldName = "ID_PhieuNhap";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "NHÂN VIÊN";
            this.gridColumn2.FieldName = "NhanVien";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời gian";
            this.gridColumn3.FieldName = "ThoiGian";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ghi chú";
            this.gridColumn4.FieldName = "Note";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmBCNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 679);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBCNhapKho";
            this.Text = "BÁO CÁO NHẬP KHO";
            this.Load += new System.EventHandler(this.frmBCNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grctrl_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grctrl_main;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_main;
        private DevExpress.XtraEditors.DateEdit date_end;
        private DevExpress.XtraEditors.DateEdit date_start;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_MaPhieu;
        private System.Windows.Forms.CheckBox cb_MaPhieu;
        private System.Windows.Forms.CheckBox cb_KhoangThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
    }
}