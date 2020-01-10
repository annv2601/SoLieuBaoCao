using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLTH.Database;
using daoSLTH.Untilities;

namespace daoSLTH.DoanhThuKhachHang
{
    public class daDoanhThuKH:daBase
    {
        private linqDoanhThuKhachHangDataContext lDTKH = new linqDoanhThuKhachHangDataContext();
        
        public void TongHop()
        {
            lDTKH.sp_tblDoanhThuKhachHangDichVu_TongHopSoLieu_ThoiGian(TuNgay, DenNgay);
        }

        public DataTable DanhSach()
        {
            List<sp_tblDoanhThuKhachHangDichVu_BaoCao_CTietResult> lst;
            lst = lDTKH.sp_tblDoanhThuKhachHangDichVu_BaoCao_CTiet(TuNgay, DenNgay, MaDonVi).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
