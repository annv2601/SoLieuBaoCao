using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class daB0205KeToan
    {
        private linqB0205KeToanDataContext lSLDT = new linqB0205KeToanDataContext();
        private sp_tblDuLieuB0205KeToan_ThongTinResult _SLDT = new sp_tblDuLieuB0205KeToan_ThongTinResult();

        public sp_tblDuLieuB0205KeToan_ThongTinResult SLDT { get => _SLDT; set => _SLDT = value; }

        public void Xoa()
        {
            lSLDT.sp_tblDuLieuB0205KeToan_Xoa(SLDT.Thang, SLDT.Nam);
        }

        public void GanMaTrung()
        {
            lSLDT.sp_tblDuLieuB0205KeToan_GanMaTrung(SLDT.Thang, SLDT.Nam);
        }

        public void Them()
        {
            lSLDT.sp_tblDuLieuB0205KeToan_Them(
                SLDT.NHOM,
                SLDT.MA_DT,
                SLDT.TEN,
                SLDT.TEN_PHU,
                SLDT.DV,
                SLDT.S_L,
                SLDT.D_T,
                SLDT.LK,
                SLDT.T_SUAT,
                SLDT.THUE,
                SLDT.LK_THUE,
                SLDT.SL_DI,
                SLDT.SL_DEN,
                SLDT.NHOM1,
                SLDT.IN_KHONG,
                SLDT.CAP,
                SLDT.TT,
                SLDT.TSUAT,
                SLDT.Thang,
                SLDT.Nam,
                SLDT.MaDonVi);
        }
    }
}
