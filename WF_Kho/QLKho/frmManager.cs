using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLKho.Code;

namespace QLKho
{
    public partial class frmManager : DevExpress.XtraEditors.XtraForm
    {
        public abForm _abForm { get; private set; }
        public INotify iNotify { get; set; }
        public frmManager(abForm _abForm, INotify iNotify)
        {
            InitializeComponent();
            this._abForm = _abForm;
            this.iNotify = iNotify;
            Text = _abForm.GetText();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_abForm.Add())
            {
                _abForm.Reload();
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int cout = 0;
            foreach (var index in grv.GetSelectedRows())
            {
                cout += _abForm.Update(grv.GetRow(index)) ? 1 : 0;
            }
            if (cout > 0)
            {
                _abForm.Reload();
            }
            //else
            //{
            //    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            iNotify.Status("Cập nhật thành công {0} bản ghi", cout);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var agr = grv.GetSelectedRows();
            if (agr.Length > 0
                && MessageBox.Show("Bạn có muốn xóa " + agr.Length + " bản ghi", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int cout = 0;
                foreach (var index in agr)
                {
                    cout += _abForm.Delete(grv.GetRow(index)) ? 1 : 0;
                }
                if (cout > 0)
                {
                    _abForm.Reload();
                }
                //else
                //{
                //    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                iNotify.Status("Xóa thành công {0} bản ghi", cout);
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            _abForm.Init(grv);
            _abForm.Reload();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu các thay đổi?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _abForm.Save();
                _abForm.Reload();
            }
        }

    }
}