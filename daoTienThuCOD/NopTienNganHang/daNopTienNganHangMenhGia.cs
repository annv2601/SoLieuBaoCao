using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.NopTienNganHang
{
    public class daNopTienNganHangMenhGia
    {
        private linqNopTienNganHangDataContext lNT = new linqNopTienNganHangDataContext();
        private sp_tblNopTienNganHangMenhGia_DanhSachResult _NMG = new sp_tblNopTienNganHangMenhGia_DanhSachResult();

        public sp_tblNopTienNganHangMenhGia_DanhSachResult NMG { get => _NMG; set => _NMG = value; }

        public void Them()
        {
            lNT.sp_tblNopTienNganHangMenhGia_Them(NMG.IDNopTien, NMG.IDMenhGia, NMG.SoLuong, NMG.SoTien);
        }

        public void Xoa()
        {
            lNT.sp_tblNopTienNganHangMenhGia_Xoa(NMG.IDNopTien);
        }

        public DataTable DanhSach()
        {
            List<sp_tblNopTienNganHangMenhGia_DanhSachResult> lst;
            lst= lNT.sp_tblNopTienNganHangMenhGia_DanhSach(NMG.IDNopTien).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblNopTienNganHangMenhGia_DanhSachResult> lstDanhSach()
        {
            return lNT.sp_tblNopTienNganHangMenhGia_DanhSach(NMG.IDNopTien).ToList();
        }
    }
}
