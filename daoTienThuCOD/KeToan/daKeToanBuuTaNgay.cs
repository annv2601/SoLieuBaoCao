using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.KeToan
{
    public class daKeToanBuuTaNgay:daBase
    {
        private linqKeToanBuuTaNgayDataContext lKTBTN = new linqKeToanBuuTaNgayDataContext();
        private sp_tblKeToanBuuTaNgay_ThongTinResult _KTN = new sp_tblKeToanBuuTaNgay_ThongTinResult();

        public sp_tblKeToanBuuTaNgay_ThongTinResult KTN { get => _KTN; set => _KTN = value; }

        public sp_tblKeToanBuuTaNgay_ThongTinResult ThongTin()
        {
            try
            {
                KTN = lKTBTN.sp_tblKeToanBuuTaNgay_ThongTin(Ngay, MaBuuCuc, MaBuuTa).Single();
                return KTN;
            }
            catch
            {
                return null;
            }
        }

        public void KetChuyen()
        {
            lKTBTN.sp_tblKeToanBuuTaNgay_ketChuyen(Ngay, MaBuuCuc);
        }

        public List<sp_tblKeToanBuuTaNgay_DanhSachResult> lstDanhSach()
        {
            return lKTBTN.sp_tblKeToanBuuTaNgay_DanhSach(Ngay, MaBuuCuc).ToList();
        }
    }
}
