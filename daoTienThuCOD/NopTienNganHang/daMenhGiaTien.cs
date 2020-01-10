using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.NopTienNganHang
{
    public class daMenhGiaTien
    {
        private linqNopTienNganHangDataContext lNT = new linqNopTienNganHangDataContext();
        private List<sp_tblMenhGia_DanhSachResult> lstDanhSach()
        {
            return lNT.sp_tblMenhGia_DanhSach().ToList();
        }
    }
}
