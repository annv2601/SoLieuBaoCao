using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.SoDuCuoiNgay
{
    public class DaDuCuoiTGNH
    {
        private linqSoDuTGNHCuoiNgayDataContext lTGNH = new linqSoDuTGNHCuoiNgayDataContext();
        private sp_tblSoDuTGNHCuoiNgay_ThongTinResult _TGNH = new sp_tblSoDuTGNHCuoiNgay_ThongTinResult();

        public sp_tblSoDuTGNHCuoiNgay_ThongTinResult TGNH { get => _TGNH; set => _TGNH = value; }

        public void Them()
        {
            lTGNH.sp_tblSoDuTGNHCuoiNgay_ThemSua(TGNH.MaKeToanNgay, TGNH.MaBuuCuc, TGNH.Ngay, TGNH.TCBCTapTrung, TGNH.TCBCThanhToanTaiDonVi, TGNH.TKBD, TGNH.KinhDoanh,
                TGNH.Cong, TGNH.GhiChu);
        }

        public void KhoaMo()
        {
            lTGNH.sp_tblSoDuTGNHCuoiNgay_KhoaMo(TGNH.MaKeToanNgay, TGNH.Khoa, TGNH.NguoiKhoa);
        }

        public DataTable DanhSachNhap(string rMBC, DateTime rTNgay, DateTime rDNgay)
        {
            List<sp_tblSoDuTGNHCuoiNgay_DanhSachNhapResult> lst;
            lst = lTGNH.sp_tblSoDuTGNHCuoiNgay_DanhSachNhap(rMBC, rTNgay, rDNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachDonVi(string rMaDVi, DateTime rNgay)
        {
            List<sp_tblSoDuTGNHCuoiNgay_DanhSachDonViResult> lst;
            lst = lTGNH.sp_tblSoDuTGNHCuoiNgay_DanhSachDonVi(rMaDVi, rNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
