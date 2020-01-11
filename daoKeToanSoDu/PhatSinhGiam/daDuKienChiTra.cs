using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.PhatSinhGiam
{
    public class daDuKienChiTra
    {
        private linqDuKienChiTraDataContext lDK = new linqDuKienChiTraDataContext();
        private sp_tblDuKienChiTra_ThongTinResult _DKCTra = new sp_tblDuKienChiTra_ThongTinResult();

        public sp_tblDuKienChiTra_ThongTinResult DKCTra { get => _DKCTra; set => _DKCTra = value; }

        public sp_tblDuKienChiTra_ThongTinResult ThongTin()
        {
            try
            {
                DKCTra = lDK.sp_tblDuKienChiTra_ThongTin(DKCTra.MaKeToanNgay).Single();
                return DKCTra;
            }
            catch
            {
                return null;
            }
        }

        public void KhoaMo()
        {
            lDK.sp_tblDuKienChiTra_KhoaMo(DKCTra.MaKeToanNgay, DKCTra.Khoa, DKCTra.NguoiKhoa);
        }

        public void ThemSua()
        {
            lDK.sp_tblDuKienChiTra_ThemSua(DKCTra.MaKeToanNgay, DKCTra.MaBuuCuc, DKCTra.Ngay, DKCTra.TCBCTapTrung, DKCTra.TCBCThanhToanTaiDonVi, DKCTra.TKBD, DKCTra.KinhDoanh,
                DKCTra.Cong, DKCTra.GhiChu);
        }
    }
}
