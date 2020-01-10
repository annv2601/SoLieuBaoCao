using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.NopTienNganHang
{
    public class daNopTienNganHangTaiKhoan:daBase
    {
        private linqNopTienNganHangDataContext lNT = new linqNopTienNganHangDataContext();
        private sp_tblNopTienNganHangTaiKhoan_DanhSachResult _NTK = new sp_tblNopTienNganHangTaiKhoan_DanhSachResult();

        public sp_tblNopTienNganHangTaiKhoan_DanhSachResult NTK { get => _NTK; set => _NTK = value; }

        public void Them()
        {
            lNT.sp_tblNopTienNganHangTaiKhoan_Them(NTK.IDNopTien, NTK.IDTaiKhoanNganHang, NTK.SoTaiKhoan, NTK.TenTaiKhoan, NTK.SoTien);
        }

        public void Xoa()
        {
            lNT.sp_tblNopTienNganHangTaiKhoan_Xoa(NTK.IDNopTien);
        }

        public DataTable DanhSach()
        {
            List<sp_tblNopTienNganHangTaiKhoan_DanhSachResult> lst;
            lst = lNT.sp_tblNopTienNganHangTaiKhoan_DanhSach(MaDonVi, NTK.IDNopTien).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblNopTienNganHangTaiKhoan_DanhSachResult> lstDanhSach()
        {
            return lNT.sp_tblNopTienNganHangTaiKhoan_DanhSach(MaDonVi,NTK.IDNopTien).ToList();
        }
    }
}
