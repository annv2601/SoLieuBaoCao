using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.GiayDeNghi
{
    public class daGiayDeNghi
    {
        private linqGiayDeNghiDataContext lGDN = new linqGiayDeNghiDataContext();
        private sp_tblGiayDeNghiTiepQuy_ThongTinResult _GDN = new sp_tblGiayDeNghiTiepQuy_ThongTinResult();

        public sp_tblGiayDeNghiTiepQuy_ThongTinResult GDN { get => _GDN; set => _GDN = value; }

        public sp_tblGiayDeNghiTiepQuy_ThongTinResult ThongTin()
        {
            try
            {
                GDN = lGDN.sp_tblGiayDeNghiTiepQuy_ThongTin(GDN.MaKeToanNgay).Single();
                return GDN;
            }
            catch
            {
                return null;
            }
        }

        public void ThemSua()
        {
            lGDN.sp_tblGiayDeNghiTiepQuy_ThemSua(GDN.MaKeToanNgay,
                GDN.MaDonVi,
                GDN.Ngay,
                GDN.NoiDung,
                GDN.TrinhDonVi,
                GDN.SoTienDeNghi,
                GDN.BangChu,
                GDN.IDNganHang,
                GDN.DuKienChiTra,
                GDN.dkctBangTienMat,
                GDN.dkctBangChuyenKhoan,
                GDN.SoTienVayQuyKhac,
                GDN.SoTienQuyKhacVay,
                GDN.TongSoDuTien,
                GDN.SoDuTienMat,
                GDN.SoDuTienMatTaiBuuCuc,
                GDN.SoDuTienMatTaiBDH,
                GDN.SoDuTGNH,
                GDN.SoDuTienDangChuyen,
                GDN.NoiLuuVB);
        }

        public void CapNhatAnhBanKy()
        {
            lGDN.sp_tblGiayDeNghiTiepQuy_CapNhatAnhBanKy(GDN.MaKeToanNgay, GDN.urlAnhBanIn);
        }

        public void CapNhatBangChu()
        {
            lGDN.sp_tblGiayDeNghiTiepQuy_CapNhatBangChu(GDN.MaKeToanNgay, GDN.BangChu);
        }

        public void CapNhatKhoaMo()
        {
            lGDN.sp_tblGiayDeNghiTiepQuy_CapNhatKhoaMo(GDN.MaKeToanNgay, GDN.DaKhoa, GDN.NguoiKhoa);
        }

        public void TongHop()
        {
            lGDN.sp_tblGiayDeNghiTiepQuy_TongHopSoLieu(GDN.MaDonVi, GDN.Ngay, GDN.IDNganHang, GDN.NoiDung, GDN.TrinhDonVi, GDN.NoiLuuVB);
        }

        public DataTable InPhieu()
        {
            List<sp_tblGiayDeNghiTiepQuy_ThongTinResult> lst;
            lst = lGDN.sp_tblGiayDeNghiTiepQuy_ThongTin(GDN.MaKeToanNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSach(string rMaDVi, DateTime rTNgay, DateTime rDNgay)
        {
            List<sp_tblGiayDeNghiTiepQuy_DanhSachResult> lst;
            lst = lGDN.sp_tblGiayDeNghiTiepQuy_DanhSach(rMaDVi, rTNgay, rDNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSach(DateTime rTNgay, DateTime rDNgay)
        {
            List<sp_tblGiayDeNghiTiepQuy_DanhSachDonViResult> lst;
            lst = lGDN.sp_tblGiayDeNghiTiepQuy_DanhSachDonVi(rTNgay, rDNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
