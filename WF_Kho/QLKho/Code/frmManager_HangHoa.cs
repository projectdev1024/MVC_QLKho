using DevExpress.XtraEditors.Repository;
using QLKho.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Code
{
    public class frmManager_HangHoa : abForm
    {
        public override bool Add()
        {
            var ob = new HangHoa()
            {
                IsDelete = false
            };
            if (new frmEdit_HangHoa(ob) { IsCreate = true }.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                var db = new dbQLKhoEntities();
                db.HangHoas.Add(ob);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Delete(object p)
        {
            if (p is HangHoa)
            {
                var db = new dbQLKhoEntities();
                var ob = db.HangHoas.ToList()
                    .FirstOrDefault(q => q.MaHH == (p as HangHoa).MaHH);
                if (ob == null) return false;
                ob.IsDelete = true;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Update(object p)
        {
            if (p is HangHoa)
            {
                var db = new dbQLKhoEntities();
                var ob = db.HangHoas.ToList()
                    .FirstOrDefault(q => q.MaHH == (p as HangHoa).MaHH);
                if (ob != null && new frmEdit_HangHoa(ob).ShowDialog() == System.Windows.Forms.DialogResult.Yes)
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
                this.CreateGridColumn("MaHH","Mã hàng hóa"),
                this.CreateGridColumn("TenHH","Tên hàng hóa"),
                this.CreateGridColumn("NhomHangHoa","Nhóm hàng hóa"),
                this.CreateGridColumn("MoTa","Mô tả"),
                this.CreateGridColumn("SoLuongTon","Số lượng tồn"),
            });

            mGridView.Columns["NhomHangHoa"].CreateCombobox(new Model.dbQLKhoEntities().NhomHangHoas.ToList().Where(q => q.IsDelete != true).ToList());
            mGridView.Columns["MaHH"].ReadonlyColumn();
            mGridView.Columns["SoLuongTon"].ReadonlyColumn();
        }

        public override void Reload()
        {
            mGridView.GridControl.DataSource = new dbQLKhoEntities().HangHoas.ToList()
                .Where(q => q.IsDelete != true).ToList();
        }

        public override string GetText()
        {
            return "DANH SÁCH HÀNG HÓA";
        }

        public override void Save()
        {
            var db = new dbQLKhoEntities();
            for (int i = 0; i < mGridView.RowCount; i++)
            {
                var new_obj = mGridView.GetRow(i) as HangHoa;
                var obj = db.HangHoas.ToList().FirstOrDefault(q => q.MaHH == new_obj.MaHH);
                obj.ID_NHH = new_obj.NhomHangHoa.ID_NHH;
                obj.MaHH = new_obj.MaHH;
                obj.MoTa = new_obj.MoTa;
                obj.TenHH = new_obj.TenHH;
            }
            System.Windows.Forms.MessageBox.Show("Lưu thành công " + db.SaveChanges() + " bản ghi", "Thông báo", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
