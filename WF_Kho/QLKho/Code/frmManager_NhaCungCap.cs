using QLKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Code
{
    public class frmManager_NhaCungCap : abForm
    {
        public override bool Add()
        {
            var ob = new NhaCungCap()
            {
                IsDelete = false
            };
            if (new frmEdit_NhaCungCap(ob) { IsCreate = true }.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                var db = new dbQLKhoEntities();
                db.NhaCungCaps.Add(ob);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Delete(object p)
        {
            if (p is NhaCungCap)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhaCungCaps.ToList()
                    .FirstOrDefault(q => q.MaNCC == (p as NhaCungCap).MaNCC);
                if (ob == null) return false;
                ob.IsDelete = true;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Update(object p)
        {
            if (p is NhaCungCap)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhaCungCaps.ToList()
                    .FirstOrDefault(q => q.MaNCC == (p as NhaCungCap).MaNCC);
                if (ob != null && new frmEdit_NhaCungCap(ob).ShowDialog() == System.Windows.Forms.DialogResult.Yes)
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
                this.CreateGridColumn("MaNCC","Mã nhà cung cấp"),
                this.CreateGridColumn("TenNCC","Tên nhà cung cấp"),
                this.CreateGridColumn("DiaChi","Địa chỉ"),
                this.CreateGridColumn("SDT","Số điện thoại"),
                this.CreateGridColumn("Web","Website")
            });
            mGridView.Columns["MaNCC"].ReadonlyColumn();
        }

        public override void Reload()
        {
            mGridView.GridControl.DataSource = new dbQLKhoEntities().NhaCungCaps.ToList()
                .Where(q => q.IsDelete != true).ToList();
        }

        public override string GetText()
        {
            return "DANH SÁCH NHÀ CUNG CẤP";
        }

        public override void Save()
        {
            var db = new dbQLKhoEntities();
            for (int i = 0; i < mGridView.RowCount; i++)
            {
                var new_obj = mGridView.GetRow(i) as NhaCungCap;
                var obj = db.NhaCungCaps.ToList().FirstOrDefault(q => q.MaNCC == new_obj.MaNCC);
                obj.TenNCC = new_obj.TenNCC;
                obj.DiaChi = new_obj.DiaChi;
                obj.Web = new_obj.Web;
                obj.SDT = new_obj.SDT;
            }
            System.Windows.Forms.MessageBox.Show("Lưu thành công " + db.SaveChanges() + " bản ghi", "Thông báo", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
