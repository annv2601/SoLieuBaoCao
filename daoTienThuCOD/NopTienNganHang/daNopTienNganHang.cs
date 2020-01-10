using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.NopTienNganHang
{
    public class daNopTienNganHang:daBase
    {
        private linqNopTienNganHangDataContext lNT = new linqNopTienNganHangDataContext();
        private sp_tblNopTienNganHang_ThongTinResult _NTNH = new sp_tblNopTienNganHang_ThongTinResult();

        public sp_tblNopTienNganHang_ThongTinResult NTNH { get => _NTNH; set => _NTNH = value; }

        public sp_tblNopTienNganHang_ThongTinResult ThongTin()
        {
            try
            {
                NTNH = lNT.sp_tblNopTienNganHang_ThongTin(NTNH.ID).Single();
                return NTNH;
            }
            catch
            {
                return null;
            }
        }

        public int KiemTra()
        {
            try
            {
                sp_tblNopTienNganHang_KiemTraResult kt;
                kt = lNT.sp_tblNopTienNganHang_KiemTra(NTNH.Ngay, NTNH.MaBuuCuc).Single();
                return kt.ID;
            }
            catch
            {
                return 0;
            }
        }

        public Int32 ThemSua()
        {
            return lNT.sp_tblNopTienNganHang_ThemSua(NTNH.ID,
                NTNH.MaBuuCuc,
                NTNH.Ngay,
                NTNH.Gio,
                NTNH.Lan,
                NTNH.NguoiGiao,
                NTNH.ChucDanh,
                NTNH.CMND,
                NTNH.NgayCap,
                NTNH.NoiCap,
                NTNH.NguoiNhan,
                NTNH.ChucDanhNguoiNhan,
                NTNH.CMNDNguoiNhan,
                NTNH.NgayCapCMNDNguoiNhan,
                NTNH.NoiCapCMNDNguoiNhan,
                NTNH.TongTienNop,
                NTNH.BangChu,
                NTNH.TongTienCo,
                NTNH.DiaDiemGiaoNhan,
                NTNH.PhuongThucGiaoNhan,
                NTNH.ChiNhanhNganHangGiaoNhan).Single().ID.Value;
        }

        public DataTable DanhSach()
        {
            List<sp_tblNopTienNganHang_ThongTinResult> lst;
            lst = lNT.sp_tblNopTienNganHang_ThongTin(NTNH.ID).ToList();
            return daTienIch.ToDataTable(lst);
        }

        #region Danh sach hien thi den theo doi
        public DataTable DanhSachTD()
        {
            List<sp_tblNopTienNganHang_DanhSachResult> lst;
            lst = lNT.sp_tblNopTienNganHang_DanhSach(MaBuuCuc,TuNgay,DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachTDBuuCuc()
        {
            List<sp_tblNopTienNganHang_DanhSach_BuuCucResult> lst;
            lst = lNT.sp_tblNopTienNganHang_DanhSach_BuuCuc(MaDonVi,TuNgay,DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachTDDonVi()
        {
            List<sp_tblNopTienNganHang_DanhSach_DonViResult> lst;
            lst = lNT.sp_tblNopTienNganHang_DanhSach_DonVi(TuNgay,DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }
        #endregion
    }
}
