using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoSLPH.Database;

namespace daoSLPH.BCCP
{
    public class daPhatHanhBCCP
    {
        private linqPhatHanhBCCPDataContext lBCCP = new linqPhatHanhBCCPDataContext();
        private sp_tblPhatHanhBCCP_ThongTinResult _PH = new sp_tblPhatHanhBCCP_ThongTinResult();

        private sp_tblTrangThaiLayBCCP_ThongTinResult _TT = new sp_tblTrangThaiLayBCCP_ThongTinResult();

        public sp_tblPhatHanhBCCP_ThongTinResult PH { get => _PH; set => _PH = value; }
        public sp_tblTrangThaiLayBCCP_ThongTinResult TT { get => _TT; set => _TT = value; }

        public sp_tblTrangThaiLayBCCP_ThongTinResult ThongTinTT()
        {
            try
            {
                TT = lBCCP.sp_tblTrangThaiLayBCCP_ThongTin(TT.MaBuuCuc, TT.Ngay).Single();
                return TT;
            }
            catch
            {
                return null;
            }
        }

        public void ThemTT()
        {
            lBCCP.sp_tblTrangThaiLayBCCP_Them(TT.MaBuuCuc, TT.Ngay);
        }

        public void Xoa()
        {
            lBCCP.sp_tblPhatHanhBCCP_Xoa(TT.MaBuuCuc, TT.Ngay);
        }

        public void ThemPH()
        {
            lBCCP.sp_tblPhatHanhBCCP_Them(PH.MaBuuCuc,
                PH.NgayPhatHanh,
                PH.MAC,
                PH.SoHieu,
                PH.MaDichVu,                
                PH.TenDichVu,
                PH.LoaiBuuGui,
                PH.SoChuyen,
                PH.SoTui,
                PH.MaDuongThu,
                PH.MaBuuCucChapNhan,
                PH.NgayGioChapNhan,
                PH.MaBuuCucDong,
                PH.NgayGioDong,
                PH.TrongLuong,
                PH.TrongLuongQuiDoi,
                PH.MaTinhPhat,
                PH.MaNuocPhat,
                PH.MaKhachHang,
                PH.TenKhachHang,
                PH.DiaChiKhachHang,
                PH.TenNguoiNhan,
                PH.DiaChiNguoiNhan,
                PH.CuocChinh,
                PH.PhuPhiXD,
                PH.PhuPhiVX,
                PH.CuocCongThem,
                PH.DichVuCongThem,
                PH.SoTienCOD,
                PH.CuocCOD,
                PH.VAT,
                PH.CuocCODVAT,
                PH.ThanhTien,
                PH.TongCuoc,
                PH.GhiNo,
                PH.NoiDungBuuGui,
                PH.GuiLo,
                PH.SoLo);
        }
    }
}
