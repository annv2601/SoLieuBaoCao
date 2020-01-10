using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLTH.Database;
using daoSLTH.Untilities;

namespace daoSLTH.KhachHang
{
    public class daKhachHang:daBase
    {
        private linqKhachHangDataContext lKH = new linqKhachHangDataContext();
        private sp_tblKhachHang_DanhSachResult _KH = new sp_tblKhachHang_DanhSachResult();

        public sp_tblKhachHang_DanhSachResult KH { get => _KH; set => _KH = value; }

        public void CapNhatNgay()
        {
            lKH.sp_tblKhachHang_CapNhat_NgayPhatSinhDoanhThu(KH.MaBuuCuc, KH.MaKhachHang, KH.NgayPhatSinhDoanhThu);
        }

        public DataTable DanhSachDanhMuc()
        {
            List<sp_tblDanhMuc_DanhSachResult> lst;
            lst = lKH.sp_tblDanhMuc_DanhSach().ToList();

            sp_tblDanhMuc_DanhSachResult pt = new sp_tblDanhMuc_DanhSachResult();
            pt.ID = 0;
            pt.Ma="TatCa";
            pt.Ten = "--- Tất cả ---";
            lst.Add(pt);
            
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSach()
        {
            List<sp_tblKhachHang_DanhSachResult> lst;
            lst = lKH.sp_tblKhachHang_DanhSach(TuNgay,DenNgay,KH.Nhom,MaDonVi).ToList();
            
            return daTienIch.ToDataTable(lst);
        }
    }
}
