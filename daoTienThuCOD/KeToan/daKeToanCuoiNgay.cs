using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.KeToan
{
    public class daKeToanCuoiNgay:daBase
    {
        private linqKeToanCuoiNgayDataContext lKTCN = new linqKeToanCuoiNgayDataContext();

        public void KetChuyen()
        {
            lKTCN.sp_tblKeToanCuoiNgay_KetChuyen(MaBuuCuc, Ngay);
        }

        public List<sp_tblKeToanBuuCucCuoiNgay_DanhSachResult> BuuCuc_DanhSach()
        {
            return lKTCN.sp_tblKeToanBuuCucCuoiNgay_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public List<sp_tblKeToanBuuTaCuoiNgay_DanhSachResult> BuuTa_DanhSach()
        {
            return lKTCN.sp_tblKeToanBuuTaCuoiNgay_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public List<sp_tblBuuCucDuCuoi_DanhSachResult> lstDuCuoiCTiet()
        {
            return lKTCN.sp_tblBuuCucDuCuoi_DanhSach(MaBuuCuc, Ngay).ToList();
        }

        public List<sp_tblBuuCucDuDau_DanhSachResult> lstDuDauCTiet()
        {
            return lKTCN.sp_tblBuuCucDuDau_DanhSach(MaBuuCuc, Ngay).ToList();
        }
    }
}
