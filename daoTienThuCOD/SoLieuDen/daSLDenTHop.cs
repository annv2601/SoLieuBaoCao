using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.SoLieuDen
{
    public class daSLDenTHop:daBase
    {
        private linqSLDenDataContext lSLDen = new linqSLDenDataContext();

        public List<sp_tblSLDenTHop_DanhSachResult> lstDanhSach()
        {
            return lSLDen.sp_tblSLDenTHop_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public void TongHop()
        {
            lSLDen.sp_tblSLDenTHop_TongHop(MaBuuCuc, Ngay);
        }
    }
}
