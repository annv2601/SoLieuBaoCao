using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoSLCT.Database;

namespace daoSLCT.Data
{
    public class daData:clsThamSo
    {
        private linqDataDataContext lDT = new linqDataDataContext();

        private clsNghiepVuPP _rPP = new clsNghiepVuPP();

        public clsNghiepVuPP rPP { get => _rPP; set => _rPP = value; }

        public void LayDuLieu()
        {
            lDT.sp_LayDuLieu_BuuCuc(MaBuuCuc, Ngay);
        }

        public void TongHopDuLieu()
        {
            lDT.sp_TongHop_DuLieu(MaBuuCuc, Ngay);
        }

        public void ThemNghiepVu()
        {
            lDT.sp_tblNghiepVuPaypost_Them(rPP.MaNhom, rPP.TenNhom, rPP.Ma, rPP.Ten);
        }

        #region Bao cao
        public List<sp_tblKinhDoanhGhiNoKhachHang_BaoCaoResult> lstKinhDoanhGhiNoKhachHang()
        {
            return lDT.sp_tblKinhDoanhGhiNoKhachHang_BaoCao(TuNgay, DenNgay, MaBuuCuc).ToList();
        }

        public List<sp_tblKinhDoanhGhiNo_BaoCaoResult> lstKinhDoanhGhiNo()
        {
            return lDT.sp_tblKinhDoanhGhiNo_BaoCao(TuNgay, DenNgay, MaBuuCuc).ToList();
        }

        public List<sp_tblKinhDoanhTiemMat_BaoCaoResult> lstKinhDoanhTiemMat()
        {
            return lDT.sp_tblKinhDoanhTiemMat_BaoCao(TuNgay, DenNgay, MaBuuCuc).ToList();
        }

        public List<sp_tblTaiChinhTapChung_BaoCaoResult> lstTaiChinhTapChung()
        {
            return lDT.sp_tblTaiChinhTapChung_BaoCao(TuNgay, DenNgay, MaBuuCuc).ToList();
        }

        public List<sp_tblTien_BaoCaoResult> lstTien()
        {
            return lDT.sp_tblTien_BaoCao(TuNgay, DenNgay, MaBuuCuc).ToList();
        }


        #endregion
    }

    public class clsThamSo
    {
        private DateTime _Ngay;

        private DateTime _TuNgay;

        private DateTime _DenNgay;

        private string _MaBuuCuc;

        public DateTime Ngay { get => _Ngay; set => _Ngay = value; }
        public DateTime TuNgay { get => _TuNgay; set => _TuNgay = value; }
        public DateTime DenNgay { get => _DenNgay; set => _DenNgay = value; }
        public string MaBuuCuc { get => _MaBuuCuc; set => _MaBuuCuc = value; }
    }

    public class clsNghiepVuPP
    {
        private string _MaNhom;

        private string _TenNhom;

        private string _Ma;

        private string _Ten;

        public string MaNhom { get => _MaNhom; set => _MaNhom = value; }
        public string TenNhom { get => _TenNhom; set => _TenNhom = value; }
        public string Ma { get => _Ma; set => _Ma = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
    }
}
