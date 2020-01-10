using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.PhanHuongBuuTa
{
    public class daPhanBuuTaTHop:daBase
    {
        private linqPhanHuongBuuTaDataContext lPBTa = new linqPhanHuongBuuTaDataContext();

        public List<sp_tblPhanBuuTaTHop_DanhSachResult> lstDanhSach()
        {
            return lPBTa.sp_tblPhanBuuTaTHop_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public void TongHop()
        {
            lPBTa.sp_tblPhanBuuTaTHop_TongHop(MaBuuCuc, Ngay);
        }
    }
}
