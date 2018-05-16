namespace QLKho
{
    partial class frmEdit_XuatKho
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
            this.rtb_Note = new System.Windows.Forms.RichTextBox();
            this.num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseEdit1
            // 
            this.ucBaseEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBaseEdit1.iFormBase = null;
            this.ucBaseEdit1.Location = new System.Drawing.Point(0, 181);
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
            this.groupControl1.Size = new System.Drawing.Size(383, 181);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rtb_Note);
            this.layoutControl1.Controls.Add(this.num_SoLuong);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(379, 158);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rtb_Note
            // 
            this.rtb_Note.Location = new System.Drawing.Point(57, 36);
            this.rtb_Note.Name = "rtb_Note";
            this.rtb_Note.Size = new System.Drawing.Size(310, 110);
            this.rtb_Note.TabIndex = 11;
            this.rtb_Note.Text = "";
            // 
            // num_SoLuong
            // 
            this.num_SoLuong.Location = new System.Drawing.Point(57, 12);
            this.num_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SoLuong.Name = "num_SoLuong";
            this.num_SoLuong.Size = new System.Drawing.Size(310, 20);
            this.num_SoLuong.TabIndex = 10;
            this.num_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(379, 158);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.num_SoLuong;
            this.layoutControlItem5.CustomizationFormText = "Số lượng";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem5.Text = "Số lượng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rtb_Note;
            this.layoutControlItem1.CustomizationFormText = "Ghi chú";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(359, 114);
            this.layoutControlItem1.Text = "Ghi chú";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(42, 13);
            // 
            // frmEdit_XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 255);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucBaseEdit1);
            this.Name = "frmEdit_XuatKho";
            this.Text = "XUẤT KHO";
            this.Load += new System.EventHandler(this.frmEdit_XuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucBaseEdit ucBaseEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.NumericUpDown num_SoLuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.RichTextBox rtb_Note;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}