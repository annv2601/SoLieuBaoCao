using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.NopTienNganHang
{
    public class daTaiKhoanNganHang
    {
        private linqNopTienNganHangDataContext lNT = new linqNopTienNganHangDataContext();
        private sp_tblTaiKhoanNopTien_DanhSachResult _TKhoan = new sp_tblTaiKhoanNopTien_DanhSachResult();

        public sp_tblTaiKhoanNopTien_DanhSachResult TKhoan { get => _TKhoan; set => _TKhoan = value; }

        public List<sp_tblTaiKhoanNopTien_DanhSachResult> lstDanhSach()
        {
            return lNT.sp_tblTaiKhoanNopTien_DanhSach(TKhoan.MaDonVi).ToList();
        }
    }
}
