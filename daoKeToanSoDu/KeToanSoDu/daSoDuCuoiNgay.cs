using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.KeToanSoDu
{
    public class daSoDuCuoiNgay
    {
        private linqKeToanSoDuDataContext lSD = new linqKeToanSoDuDataContext();
        private sp_tblKeToanSoDu_ThongTin_BuuCucResult _BuuCuc = new sp_tblKeToanSoDu_ThongTin_BuuCucResult();

        public sp_tblKeToanSoDu_ThongTin_BuuCucResult BuuCuc { get => _BuuCuc; set => _BuuCuc = value; }

        public sp_tblKeToanSoDu_ThongTin_BuuCucResult ThongTinBuuCuc(string rMa)
        {
            try
            {
                BuuCuc = lSD.sp_tblKeToanSoDu_ThongTin_BuuCuc(rMa).Single();
                return BuuCuc;
            }
            catch
            {
                return null;
            }
        }

        public DataTable BaoCaoNgay(string rMDV, DateTime rTNgay, DateTime rDNgay)
        {
            List<sp_tblKeToanSoDu_BaoCao_NgayResult> lst;
            lst = lSD.sp_tblKeToanSoDu_BaoCao_Ngay(rTNgay, rDNgay, rMDV).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable BaoCaoDonVi(string rMDV, DateTime rTNgay, DateTime rDNgay, bool rNhomTheoDV)
        {
            List<sp_tblKeToanSoDu_BaoCao_DonViResult> lst;
            lst = lSD.sp_tblKeToanSoDu_BaoCao_DonVi(rTNgay, rDNgay, rMDV, rNhomTheoDV).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachNhap(string rMBC, DateTime rTNgay, DateTime rDNgay)
        {
            List<sp_tblKeToanSoDu_DanhSachNhapResult> lst;
            lst = lSD.sp_tblKeToanSoDu_DanhSachNhap(rMBC, rTNgay, rDNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachDonVi(string rMDV, DateTime rNgay)
        {
            List<sp_tblKeToanSoDu_DanhSachTheoDonViResult> lst;
            lst = lSD.sp_tblKeToanSoDu_DanhSachTheoDonVi(rMDV, rNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable SoDuCuoiNgay_DonVi(string rMDV, DateTime rTNgay, DateTime rDNgay, bool rIDNhom)
        {
            List<sp_tblKeToanSoDu_BaoCao_SoDuCuoiNgayResult> lst;
            lst = lSD.sp_tblKeToanSoDu_BaoCao_SoDuCuoiNgay(rTNgay, rDNgay,rMDV,rIDNhom).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
