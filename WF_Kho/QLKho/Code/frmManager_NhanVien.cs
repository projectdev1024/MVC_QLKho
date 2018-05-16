using QLKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Code
{
    public class frmManager_NhanVien : abForm
    {
        public override bool Add()
        {
            var ob = new NhanVien()
            {
                IsDelete = false
            };
            if (new frmEdit_NhanVien(ob).ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                var db = new dbQLKhoEntities();
                db.NhanViens.Add(ob);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Delete(object p)
        {
            if (p is NhanVien)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhanViens.ToList()
                    .FirstOrDefault(q => q.MaNV == (p as NhanVien).MaNV);
                if (ob == null) return false;
                ob.IsDelete = true;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public override bool Update(object p)
        {
            if (p is NhanVien)
            {
                var db = new dbQLKhoEntities();
                var ob = db.NhanViens.ToList()
                    .FirstOrDefault(q => q.MaNV == (p as NhanVien).MaNV);
                if (ob != null && new frmEdit_NhanVien(ob).ShowDialog() == System.Windows.Forms.DialogResult.Yes)
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
                this.CreateGridColumn("MaNV","Mã Nhân viên"),
                this.CreateGridColumn("TenNV","Tên Nhân viên"),
                this.CreateGridColumn("PB","Phòng ban"),
                this.CreateGridColumn("CV","Chức vụ"),
                this.CreateGridColumn("MT","Mô tả")
            });
            var data = new List<string>();
            data.Add("QuanLy");
            data.Add("NVKiemKho");
            data.Add("NVXuatNhapKho");

            mGridView.Columns["CV"].CreateCombobox(data);
            mGridView.Columns["MaNV"].ReadonlyColumn();
        }

        public override void Reload()
        {
            mGridView.GridControl.DataSource = new dbQLKhoEntities().NhanViens.ToList()
                .Where(q => q.IsDelete != true).ToList();
        }

        public override string GetText()
        {
            return "DANH SÁCH NHÂN VIÊN";
        }

        public override void Save()
        {
            var db = new dbQLKhoEntities();
            for (int i = 0; i < mGridView.RowCount; i++)
            {
                var new_obj = mGridView.GetRow(i) as NhanVien;
                var obj = db.NhanViens.ToList().FirstOrDefault(q => q.MaNV == new_obj.MaNV);
                obj.TenNV = new_obj.TenNV;
                obj.PB = new_obj.PB;
                obj.CV = new_obj.CV;
                obj.MT = new_obj.MT;
            }
            System.Windows.Forms.MessageBox.Show("Lưu thành công " + db.SaveChanges() + " bản ghi", "Thông báo", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
