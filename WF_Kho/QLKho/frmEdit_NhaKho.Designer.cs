namespace QLKho
{
    partial class frmEdit_NhaKho
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
            this.lookupStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.numSoTang = new System.Windows.Forms.NumericUpDown();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.numSoHang = new System.Windows.Forms.NumericUpDown();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.numSoCot = new System.Windows.Forms.NumericUpDown();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseEdit1
            // 
            this.ucBaseEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBaseEdit1.iFormBase = null;
            this.ucBaseEdit1.Location = new System.Drawing.Point(0, 272);
            this.ucBaseEdit1.Name = "ucBaseEdit1";
            this.ucBaseEdit1.Size = new System.Drawing.Size(379, 74);
            this.ucBaseEdit1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 272);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin Nhà kho";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.numSoCot);
            this.layoutControl1.Controls.Add(this.numSoHang);
            this.layoutControl1.Controls.Add(this.numSoTang);
            this.layoutControl1.Controls.Add(this.lookupStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(375, 249);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookupStatus
            // 
            this.lookupStatus.Location = new System.Drawing.Point(64, 84);
            this.lookupStatus.Name = "lookupStatus";
            this.lookupStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupStatus.Size = new System.Drawing.Size(299, 20);
            this.lookupStatus.StyleController = this.layoutControl1;
            this.lookupStatus.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(375, 249);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookupStatus;
            this.layoutControlItem3.CustomizationFormText = "Trạng thái";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(355, 157);
            this.layoutControlItem3.Text = "Trạng thái";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(49, 13);
            // 
            // numSotang
            // 
            this.numSoTang.Location = new System.Drawing.Point(64, 12);
            this.numSoTang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTang.Name = "numSotang";
            this.numSoTang.Size = new System.Drawing.Size(299, 20);
            this.numSoTang.TabIndex = 7;
            this.numSoTang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.numSoTang;
            this.layoutControlItem4.CustomizationFormText = "Số tầng";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem4.Text = "Số tầng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(49, 13);
            // 
            // numSoHang
            // 
            this.numSoHang.Location = new System.Drawing.Point(64, 36);
            this.numSoHang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoHang.Name = "numSoHang";
            this.numSoHang.Size = new System.Drawing.Size(299, 20);
            this.numSoHang.TabIndex = 8;
            this.numSoHang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.numSoHang;
            this.layoutControlItem2.CustomizationFormText = "Số hàng";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem2.Text = "Số hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(49, 13);
            // 
            // numSoCot
            // 
            this.numSoCot.Location = new System.Drawing.Point(64, 60);
            this.numSoCot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoCot.Name = "numSoCot";
            this.numSoCot.Size = new System.Drawing.Size(299, 20);
            this.numSoCot.TabIndex = 9;
            this.numSoCot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.numSoCot;
            this.layoutControlItem5.CustomizationFormText = "Số cột";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem5.Text = "Số cột";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(49, 13);
            // 
            // frmEdit_NhaKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 346);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucBaseEdit1);
            this.Name = "frmEdit_NhaKho";
            this.Text = "NHÀ KHO";
            this.Load += new System.EventHandler(this.frmNhaKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucBaseEdit ucBaseEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit lookupStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.NumericUpDown numSoCot;
        private System.Windows.Forms.NumericUpDown numSoHang;
        private System.Windows.Forms.NumericUpDown numSoTang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}