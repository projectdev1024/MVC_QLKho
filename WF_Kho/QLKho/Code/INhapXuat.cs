using QLKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Code
{
    public interface INhapXuat
    {
        void NhapKho(LoHang lohang);
        void RemoveNhapKho(LoHang lohang);
        void ClearNhapKho();
        bool SaveNhapKho();
        List<LoHang> GetListNhapKho();

        void XuatKho(CT_XuatKho ctxuat);
        void RemoveXuatKho(CT_XuatKho ctxuat);
        void ClearXuatKho();
        bool SaveXuatKho();
        List<CT_XuatKho> GetListXuatKho();
    }
}
