using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLTH.Database;
using daoSLTH.Untilities;

namespace daoSLTH.Paypost
{
    public class daPaypost:daBase
    {
        private linqPaypostDataContext lPP = new linqPaypostDataContext();

        public void TongHop()
        {
            lPP.sp_tblPaypostBuuCuc_TongHop(DateTime.Now, true);
        }

        public DataTable DanhSach()
        {
            List<sp_tblPaypostBuuCuc_DanhSachResult> lst;
            lst = lPP.sp_tblPaypostBuuCuc_DanhSach(TuNgay, DenNgay, MaDonVi).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSach_BuuCuc()
        {
            List<sp_tblPaypostBuuCuc_DanhSach_BuuCucResult> lst;
            lst = lPP.sp_tblPaypostBuuCuc_DanhSach_BuuCuc(TuNgay, DenNgay, MaBuuCuc).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachChiTiet()
        {
            List<sp_tblPaypostBuuCuc_ChiTietResult> lst;
            lst = lPP.sp_tblPaypostBuuCuc_ChiTiet(MaDoiSoat).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachChiTietGiaiDoan()
        {
            List<sp_tblPaypostBuuCuc_ChiTiet_GiaiDoanResult> lst;
            lst = lPP.sp_tblPaypostBuuCuc_ChiTiet_GiaiDoan(TuNgay, DenNgay, MaBuuCuc).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachLoai()
        {
            List<sp_tblPayPostLoai_DanhSachResult> lst;
            lst = lPP.sp_tblPayPostLoai_DanhSach(TuNgay, DenNgay, MaDonVi).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachLoai_BuuCuc()
        {
            List<sp_tblPayPostLoai_DanhSach_BuuCucResult> lst;
            lst = lPP.sp_tblPayPostLoai_DanhSach_BuuCuc(TuNgay, DenNgay, MaBuuCuc).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
