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
using DevExpress.XtraTreeList.Nodes;
using QLKho.Code;
using QLKho.Model;
using System.Data.Entity;
using DevExpress.XtraTreeList.Columns;

namespace QLKho
{
    public partial class frmManager_LoHang : DevExpress.XtraEditors.XtraForm, Code.INhapXuat
    {
        INotify _iNotify;
        public List<LoHang> lst_LoHang { get; set; }
        public List<CT_XuatKho> lst_XuatKho { get; set; }
        public List<UC.ucViTri> lstUcViTri { get; set; }
        frmWait _frmWait;

        public frmManager_LoHang(INotify iNotify)
        {
            InitializeComponent();
            this._iNotify = iNotify;
            Text = "QUẢN LÝ CÁC LÔ HÀNG TRONG KHO";
            CheckForIllegalCrossThreadCalls = false;
            _frmWait = new frmWait()
            {
                ShowOnTopMode = DevExpress.XtraWaitForm.ShowFormOnTopMode.AboveAll,
                StartPosition = FormStartPosition.CenterScreen
            };
        }

        private void frmManager_LoHang_Load(object sender, EventArgs e)
        {
            lst_LoHang = new List<LoHang>();
            lst_XuatKho = new List<CT_XuatKho>();
            search.Properties.DataSource = new dbQLKhoEntities().HangHoas.ToList().Where(q => q.IsDelete != true).ToList();
            search.Properties.NullText = "Vui lòng chọn loại hàng hóa muốn tìn kiếm";
            backgroundWorker1.RunWorkerAsync();
        }

        void _reload()
        {
            lstUcViTri = new List<UC.ucViTri>();
            var db = new dbQLKhoEntities();
            var nhaKho = db.NhaKhoes.ToList().Where(q => q.Status != "DaXoa").ToList();
            var vitrisua = db.VitriSuas.ToList();
            xtra_main.Controls.Clear();
            foreach (var kho in nhaKho)
            {
                var vitrisua_ofKho = vitrisua.Where(q => q.ID_NhaKho == kho.ID_NhaKho).ToList();
                var lohang_ofKho = db.LoHangs.ToList().Where(q => q.Status != 0 && q.ID_NhaKho == kho.ID_NhaKho).ToList();
                var total = kho.SoTang * kho.SoHang * kho.SoCot;
                _iNotify.Status("Loading...");

                for (int tang = kho.SoTang ?? 0; tang > 0; tang--)
                {
                    var gr = new GroupControl()
                    {
                        Text = "Tầng " + tang,
                        Size = new Size(25, 25),
                        AutoSize = true,
                        Dock = DockStyle.Top
                    };
                    xtra_main.Controls.Add(gr);

                    for (int hang = kho.SoHang ?? 0; hang > 0; hang--)
                    {
                        FlowLayoutPanel p = new FlowLayoutPanel()
                        {
                            Size = new Size(0, 0),
                            AutoSize = true,
                            Dock = DockStyle.Top
                        };
                        gr.Controls.Add(p);

                        for (int cot = 1; cot <= kho.SoCot; cot++)
                        {
                            var mLoHang = lohang_ofKho.FirstOrDefault(q => q.Tang == tang && q.Hang == hang && q.Cot == cot);
                            var uc = new UC.ucViTri()
                            {
                                mLoHang = mLoHang,
                                iNhapXuat = this,
                                mTang = tang,
                                mHang = hang,
                                mCot = cot,
                                ID_NhaKho = kho.ID_NhaKho
                            };
                            uc.Reload(vitrisua_ofKho.Any(q => q.Tang == tang && q.Hang == hang && q.Cot == cot));

                            p.Height = uc.Height;
                            p.Width += uc.Width;
                            p.Controls.Add(uc);
                            lstUcViTri.Add(uc);
                            p.Location = new Point(3, uc.Height * hang + 3);
                        }
                        gr.Height += p.Height;
                        if (p.Width > gr.Width) gr.Width = p.Width;
                    }
                }
            }
            _iNotify.Status();
        }

        frmNhapKho f_nhapkho;

        public void NhapKho(LoHang lohang)
        {
            lst_LoHang.Add(lohang);
            if (f_nhapkho == null)
            {
                f_nhapkho = new frmNhapKho(this);
                f_nhapkho.Reload();
                f_nhapkho.Show();
            }
            else
            {
                f_nhapkho.Reload();
            }
        }

        public void RemoveNhapKho(LoHang lohang)
        {
            lst_LoHang.Remove(lohang);
            if (lst_LoHang.Count <= 0)
            {
                f_nhapkho.Close();
            }
        }

        public void ClearNhapKho()
        {
            lst_LoHang = new List<LoHang>();
            if (f_nhapkho != null)
            {
                f_nhapkho.Close();
                f_nhapkho.Dispose();
                f_nhapkho = null;
            }
            _reload();
        }

        public bool SaveNhapKho()
        {
            if (lst_LoHang.Count > 0)
            {
                var db = new dbQLKhoEntities();
                var hanghoa = db.HangHoas.ToList();
                var phieuNhap = new PhieuNhap
                {
                    ID_NhanVien = COMMON.User.MaNV,
                    Note = "",
                    ThoiGian = DateTime.Now
                };
                db.PhieuNhaps.Add(phieuNhap);

                var r = db.SaveChanges() > 0;
                if (r)
                {
                    foreach (var item in lst_LoHang)
                    {
                        var hh = hanghoa.FirstOrDefault(q => q.MaHH == item.MaHH);
                        hh.SoLuongTon += item.SoLuong;
                        db.LoHangs.Add(new LoHang
                        {
                            Cot = item.Cot,
                            Hang = item.Hang,
                            HSD = item.HSD,
                            ID_NhaKho = item.ID_NhaKho,
                            ID_PhieuNhap = phieuNhap.ID_PhieuNhap,
                            MaHH = item.MaHH,
                            MaNCC = item.MaNCC,
                            NSX = item.NSX,
                            SoLuong = item.SoLuong,
                            Status = item.Status,
                            Tang = item.Tang
                        });
                    }
                    r = r && (db.SaveChanges() > 0);
                }
                MessageBox.Show(r ? "Thêm thành công" : "Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearNhapKho();
                return r;
            }
            return false;
        }

        public List<LoHang> GetListNhapKho()
        {
            return lst_LoHang;
        }

        public void XuatKho(CT_XuatKho ctxuat)
        {
            lst_XuatKho.Add(ctxuat);
            if (f_xuatKho == null)
            {
                f_xuatKho = new frmXuatKho(this);
                f_xuatKho.Show();
            }
            f_xuatKho.ReloadGridview();
            var uc = lstUcViTri.FirstOrDefault(q => q.mLoHang != null && q.mLoHang.MaLoHang == ctxuat.MaLoHang);
            uc.UpdateValue((ctxuat.SoLuong ?? 0) * -1);
        }

        public void RemoveXuatKho(CT_XuatKho ctxuat)
        {
            lst_XuatKho.Remove(ctxuat);
        }

        frmXuatKho f_xuatKho;
        public void ClearXuatKho()
        {
            lst_XuatKho = new List<CT_XuatKho>();
            if (f_xuatKho != null)
            {
                f_xuatKho.Close();
                f_xuatKho.Dispose();
                f_xuatKho = null;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        public bool SaveXuatKho()
        {
            if (lst_XuatKho.Count > 0)
            {
                var phieuXuat = new PhieuXuat
                {
                    ID_NhanVien = COMMON.User.MaNV,
                    Note = "",
                    ThoiGian = DateTime.Now
                };
                var db = new dbQLKhoEntities();
                db.PhieuXuats.Add(phieuXuat);

                var lstHang = db.LoHangs.ToList().Where(q => q.Status != 0).ToList();
                var lstHangHoa = db.HangHoas.ToList();
                foreach (var item in lst_XuatKho)
                {
                    var ob = lstHang.FirstOrDefault(q => q.MaLoHang == item.MaLoHang);
                    if (ob != null)
                    {
                        db.CT_XuatKho.Add(new CT_XuatKho
                        {
                            ID_PhieuXuat = phieuXuat.ID_PhieuXuat,
                            MaLoHang = item.MaLoHang,
                            Note = "",
                            SoLuong = item.SoLuong
                        });

                        ob.SoLuong -= item.SoLuong;
                        if (ob.SoLuong <= 0)
                        {
                            ob.Status = 0;
                        }
                        var hh = lstHangHoa.FirstOrDefault(q => q.MaHH == ob.MaHH);
                        if (hh != null)
                        {
                            hh.SoLuongTon -= item.SoLuong;
                        }
                    }
                }
                var r = db.SaveChanges() > 0;
                MessageBox.Show(r ? "Xuất thành công" : "Xuất thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backgroundWorker1.RunWorkerAsync();
                return r;
            }
            return false;
        }

        public List<CT_XuatKho> GetListXuatKho()
        {
            return lst_XuatKho;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                    _reload();
                });
            }
            else
            {
                _reload();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            f_xuatKho = new frmXuatKho(this);
            f_xuatKho.Show();
            f_xuatKho.ReloadGridview();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var ob = search.EditValue as HangHoa;
            var count = 0;
            foreach (var uc in lstUcViTri)
            {
                if (ob != null && uc.mLoHang != null && uc.mLoHang.MaHH == ob.MaHH)
                {
                    uc.HightLight();
                    count++;
                }
                else
                {
                    uc.ClearHightLight();
                }
            }
            _iNotify.Status("Có {0} kết quả phù hợp!", count);
            if (count <= 0)
            {
                MessageBox.Show("Không có kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            f_nhapkho = new frmNhapKho(this);
            f_nhapkho.Show();
            f_nhapkho.Reload();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            search.EditValue = null;
            foreach (var uc in lstUcViTri)
            {
                uc.ClearHightLight();
            }
            _iNotify.Status();
        }
    }
}