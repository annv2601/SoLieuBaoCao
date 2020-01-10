using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.KeToan
{
    public class daKeToanBuuTa:daBase
    {
        private linqKeToanBuuTaDataContext lKTBT = new linqKeToanBuuTaDataContext();

        public void KetChuyen()
        {
            lKTBT.sp_tblKeToanBuuTa_KetChuyen(MaBuuCuc, Ngay);
        }

        public List<sp_tblKeToan_DanhSachResult> lstDanhSachBuuTa()
        {
            return lKTBT.sp_tblKeToanBuuTa_DanhSach_BuuTa(MaBuuCuc, MaBuuTa, TuNgay, DenNgay).ToList();
        }

        public List<sp_tblKeToan_DanhSachResult> lstDanhSachBuuCuc()
        {
            return lKTBT.sp_tblKeToanBuuTa_DanhSach_BuuCuc(MaBuuCuc, TuNgay, DenNgay).ToList();
        }
    }
}
