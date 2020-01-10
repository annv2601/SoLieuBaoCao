using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.SoDuCuoiNgay
{
    public class daDuCuoiTienMat
    {
        private linqSoDuTienMatCuoiNgayDataContext lTM = new linqSoDuTienMatCuoiNgayDataContext();
        private sp_tblSoDuTienMatCuoiNgay_ThongTinResult _TM = new sp_tblSoDuTienMatCuoiNgay_ThongTinResult();

        public sp_tblSoDuTienMatCuoiNgay_ThongTinResult TM { get => _TM; set => _TM = value; }

        public sp_tblSoDuTienMatCuoiNgay_ThongTinResult ThongTin()
        {
            try
            {
                TM = lTM.sp_tblSoDuTienMatCuoiNgay_ThongTin(TM.MaKeToanNgay).Single();
                return TM;
            }
            catch
            {
                return null;
            }
        }

        public void ThemSua()
        {
            lTM.sp_tblSoDuTienMatCuoiNgay_ThemSua(TM.MaKeToanNgay, TM.MaBuuCuc, TM.Ngay, TM.TCBCTapTrung, TM.TCBCThanhToanTaiDonVi, TM.TKBD, TM.KinhDoanh,
                TM.Cong, TM.GhiChu);
        }

        public void KhoaMo()
        {
            lTM.sp_tblSoDuTienMatCuoiNgay_KhoaMo(TM.MaKeToanNgay, TM.Khoa, TM.NguoiKhoa);
        }

        public DataTable DanhSachNhap(string rMBC, DateTime rTNgay, DateTime rDNgay)
        {
            List<sp_tblSoDuTienMatCuoiNgay_DanhSachNhapResult> lst;
            lst = lTM.sp_tblSoDuTienMatCuoiNgay_DanhSachNhap(rMBC, rTNgay, rDNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachDonVi(string rMDV, DateTime rNgay)
        {
            List<sp_tblSoDuTienMatCuoiNgay_DanhSachTheoDonViResult> lst;
            lst = lTM.sp_tblSoDuTienMatCuoiNgay_DanhSachTheoDonVi(rMDV,rNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
