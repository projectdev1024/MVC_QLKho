using QLKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Code
{
    public class frmManager_NhaKho : abForm
    {
        public override bool Add()
        {
            var ob = new NhaKho()
            {
                Status = "SanSang"
            };
            if (new frmEdit_NhaKho(ob).ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                var db = new dbQLKhoEntities();
                db.NhaKhoes.Add(ob);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Delete(object p)
        {
            if (p is NhaKho)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhaKhoes.ToList()
                    .FirstOrDefault(q => q.ID_NhaKho == (p as NhaKho).ID_NhaKho);
                if (ob == null) return false;
                ob.Status = "DaXoa";
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Update(object p)
        {
            if (p is NhaKho)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhaKhoes.ToList()
                    .FirstOrDefault(q => q.ID_NhaKho == (p as NhaKho).ID_NhaKho);
                if (ob != null && new frmEdit_NhaKho(ob).ShowDialog() == System.Windows.Forms.DialogResult.Yes)
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
                this.CreateGridColumn("ID_NhaKho","Mã nhà kho"),
                this.CreateGridColumn("SoTang","Số tầng"),
                this.CreateGridColumn("SoHang","Số hàng"),
                this.CreateGridColumn("SoCot","Số cột"),
                this.CreateGridColumn("Status","Trạng thái"),
            });

            var dic = new Dictionary<string, string>();
            dic.Add("DaXoa", "Đã xóa");
            dic.Add("SanSang", "Sẵn sàng");
            dic.Add("Full", "Đầy kho");
            dic.Add("SuaChua", "Đang sửa chữa");
            mGridView.Columns["Status"].CreateCombobox(dic.ToList());

            mGridView.Columns["ID_NhaKho"].ReadonlyColumn();
        }

        public override void Reload()
        {
            mGridView.GridControl.DataSource = new dbQLKhoEntities().NhaKhoes.ToList().Where(q => q.Status != "DaXoa").ToList();
        }

        public override string GetText()
        {
            return "DANH SÁCH NHÀ KHO";
        }

        public override void Save()
        {
            var db = new dbQLKhoEntities();
            for (int i = 0; i < mGridView.RowCount; i++)
            {
                var new_obj = mGridView.GetRow(i) as NhaKho;
                var obj = db.NhaKhoes.ToList().FirstOrDefault(q => q.ID_NhaKho == new_obj.ID_NhaKho);
                obj.SoTang = new_obj.SoTang;
                obj.SoHang = new_obj.SoHang;
                obj.SoCot = new_obj.SoCot;
                obj.Status = new_obj.Status;
            }
            System.Windows.Forms.MessageBox.Show("Lưu thành công " + db.SaveChanges() + " bản ghi", "Thông báo", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
