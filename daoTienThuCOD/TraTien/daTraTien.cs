using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.TraTien
{
    public class daTraTien:daBase
    {
        private linqTraTienDataContext lTTien = new linqTraTienDataContext();

        public void LaySoLieu()
        {
            lTTien.sp_tblTraTien_LaySoLieu(MaBuuCuc, Ngay);
        }

        public void CapNhatTrangThai()
        {
            lTTien.sp_tblTraTien_CapNhatTrangThai(MaBuuCuc, Ngay);
        }

        public DataTable DanhSach()
        {
            List<sp_tblTraTien_DanhSachResult> lst;
            lst = lTTien.sp_tblTraTien_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblTraTien_DanhSachResult> lstDanhSach()
        {
            List<sp_tblTraTien_DanhSachResult> lst;
            lst = lTTien.sp_tblTraTien_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
            return lst;
        }
    }
}
