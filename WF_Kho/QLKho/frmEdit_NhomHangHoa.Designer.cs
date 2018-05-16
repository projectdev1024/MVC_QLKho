namespace QLKho
{
    partial class frmEdit_NhomHangHoa
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
            this.ucBaseEdit1 = new QLKho.UC.ucBaseEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMaHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNHH = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseEdit1
            // 
            this.ucBaseEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBaseEdit1.iFormBase = null;
            this.ucBaseEdit1.Location = new System.Drawing.Point(0, 105);
            this.ucBaseEdit1.Name = "ucBaseEdit1";
            this.ucBaseEdit1.Size = new System.Drawing.Size(334, 74);
            this.ucBaseEdit1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(334, 105);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin nhóm hàng hóa";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMaHangHoa);
            this.layoutControl1.Controls.Add(this.txtTenNHH);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(330, 82);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(110, 12);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(208, 20);
            this.txtMaHangHoa.StyleController = this.layoutControl1;
            this.txtMaHangHoa.TabIndex = 5;
            // 
            // txtTenNHH
            // 
            this.txtTenNHH.Location = new System.Drawing.Point(110, 36);
            this.txtTenNHH.Name = "txtTenNHH";
            this.txtTenNHH.Size = new System.Drawing.Size(208, 20);
            this.txtTenNHH.StyleController = this.layoutControl1;
            this.txtTenNHH.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(330, 82);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMaHangHoa;
            this.layoutControlItem2.CustomizationFormText = "Mã hàng hóa";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(310, 24);
            this.layoutControlItem2.Text = "Mã nhóm hàng hóa";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenNHH;
            this.layoutControlItem1.CustomizationFormText = "Tên nhóm hàng hóa";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(310, 38);
            this.layoutControlItem1.Text = "Tên nhóm hàng hóa";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // frmEdit_NhomHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 179);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucBaseEdit1);
            this.Name = "frmEdit_NhomHangHoa";
            this.Text = "NHÓM HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmNhomHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucBaseEdit ucBaseEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtTenNHH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtMaHangHoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}