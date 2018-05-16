using QLKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Code
{
    public class frmManager_NhomHangHoa : abForm
    {
        public override bool Add()
        {
            var ob = new NhomHangHoa()
            {
                IsDelete = false
            };
            if (new frmEdit_NhomHangHoa(ob) { IsCreate = true }.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                var db = new dbQLKhoEntities();
                db.NhomHangHoas.Add(ob);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Delete(object p)
        {
            if (p is NhomHangHoa)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhomHangHoas.ToList()
                    .FirstOrDefault(q => q.ID_NHH == (p as NhomHangHoa).ID_NHH);
                if (ob == null) return false;
                ob.IsDelete = true;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Update(object p)
        {
            if (p is NhomHangHoa)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhomHangHoas.ToList()
                    .FirstOrDefault(q => q.ID_NHH == (p as NhomHangHoa).ID_NHH);
                if (ob != null && new frmEdit_NhomHangHoa(ob).ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    return db.SaveChanges() > 0;
                }
            }
            return false;
        }

        public override void Init(DevExpress.XtraGrid.Views.Grid.GridView grv)
        {
            this.mGridView = grv;
            mGridView.Columns.Clear();
            mGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[]
            {
                this.CreateGridColumn("ID_NHH","Mã nhóm hàng hóa"),
                this.CreateGridColumn("TenNHH","Tên nhóm hàng hóa"),
            });

            mGridView.Columns["ID_NHH"].ReadonlyColumn();
        }

        public override void Reload()
        {
            mGridView.GridControl.DataSource = new dbQLKhoEntities().NhomHangHoas.ToList()
                .Where(q => q.IsDelete == false).ToList();
        }

        public override string GetText()
        {
            return "DANH SÁCH NHÓM HÀNG HÓA";
        }

        public override void Save()
        {
            var db = new dbQLKhoEntities();
            for (int i = 0; i < mGridView.RowCount; i++)
            {
                var obj = db.NhomHangHoas.ToList().FirstOrDefault(q => q.ID_NHH == (mGridView.GetRow(i) as NhomHangHoa).ID_NHH);
                var new_obj = mGridView.GetRow(i) as NhomHangHoa;
                obj.TenNHH = new_obj.TenNHH;
            }
            System.Windows.Forms.MessageBox.Show("Lưu thành công " + db.SaveChanges() + " bản ghi", "Thông báo", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
