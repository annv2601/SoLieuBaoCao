using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.KeToan
{
    public class daKeToanBuuCuc:daBase
    {
        private linqKeToanBuuCucDataContext lKTBC = new linqKeToanBuuCucDataContext();

        public void ketChuyen()
        {
            lKTBC.sp_tblKeToanBuuCuc_KetChuyen(MaBuuCuc, Ngay);
        }

        public List<sp_tblKeToan_DanhSachResult> lstDanhSachBuuCuc()
        {
            return lKTBC.sp_tblKeToanBuuCuc_DanhSach_BuuCuc(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public DataTable DanhSachBuuCuc()
        {
            List<sp_tblKeToan_DanhSachResult> lst;
            lst= lKTBC.sp_tblKeToanBuuCuc_DanhSach_BuuCuc(MaBuuCuc, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblKeToan_DanhSachResult> lstDanhSachDonVi()
        {
            return lKTBC.sp_tblKeToanBuuCuc_DanhSach_DonVi(MaDonVi, TuNgay, DenNgay).ToList();
        }

        public DataTable DanhSachDonVi()
        {
            List<sp_tblKeToan_DanhSachResult> lst;
            lst= lKTBC.sp_tblKeToanBuuCuc_DanhSach_DonVi(MaDonVi, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachTyLe()
        {
            List<sp_tblKeToanBuuCuc_TyLeResult> lst;
            lst = lKTBC.sp_tblKeToanBuuCuc_TyLe_DonVi(MaDonVi, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
