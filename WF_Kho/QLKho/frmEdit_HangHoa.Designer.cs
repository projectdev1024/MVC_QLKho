namespace QLKho
{
    partial class frmEdit_HangHoa
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
            this.ucBaseEdit1 = new QLKho.UC.ucBaseEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMaHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.txtTenHH = new DevExpress.XtraEditors.TextEdit();
            this.cmbNhomHH = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhomHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseEdit1
            // 
            this.ucBaseEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBaseEdit1.iFormBase = null;
            this.ucBaseEdit1.Location = new System.Drawing.Point(0, 190);
            this.ucBaseEdit1.Name = "ucBaseEdit1";
            this.ucBaseEdit1.Size = new System.Drawing.Size(383, 74);
            this.ucBaseEdit1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(383, 190);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMaHangHoa);
            this.layoutControl1.Controls.Add(this.rtbMoTa);
            this.layoutControl1.Controls.Add(this.txtTenHH);
            this.layoutControl1.Controls.Add(this.cmbNhomHH);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(379, 167);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(90, 12);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(277, 20);
            this.txtMaHangHoa.StyleController = this.layoutControl1;
            this.txtMaHangHoa.TabIndex = 8;
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(90, 84);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(277, 71);
            this.rtbMoTa.TabIndex = 7;
            this.rtbMoTa.Text = "";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(90, 36);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(277, 20);
            this.txtTenHH.StyleController = this.layoutControl1;
            this.txtTenHH.TabIndex = 4;
            // 
            // cmbNhomHH
            // 
            this.cmbNhomHH.Location = new System.Drawing.Point(90, 60);
            this.cmbNhomHH.Name = "cmbNhomHH";
            this.cmbNhomHH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhomHH.Properties.PopupSizeable = false;
            this.cmbNhomHH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbNhomHH.Size = new System.Drawing.Size(277, 20);
            this.cmbNhomHH.StyleController = this.layoutControl1;
            this.cmbNhomHH.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(379, 167);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenHH;
            this.layoutControlItem1.CustomizationFormText = "Tên hàng hóa";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem1.Text = "Tên hàng hóa";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbNhomHH;
            this.layoutControlItem3.CustomizationFormText = "Nhóm hàng hóa";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem3.Text = "Nhóm hàng hóa";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rtbMoTa;
            this.layoutControlItem2.CustomizationFormText = "Mô tả";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(359, 75);
            this.layoutControlItem2.Text = "Mô tả";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMaHangHoa;
            this.layoutControlItem4.CustomizationFormText = "Mã hàng hóa";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem4.Text = "Mã hàng hóa";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmEdit_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 264);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucBaseEdit1);
            this.Name = "frmEdit_HangHoa";
            this.Text = "HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmEdit_HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhomHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucBaseEdit ucBaseEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtTenHH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit cmbNhomHH;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.TextEdit txtMaHangHoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}