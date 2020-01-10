using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLTH.Untilities;
using daoSLTH.Database.CSKH;

namespace daoSLTH.CSKH
{
    public class daChietKhauKhachHang:daBase
    {
        private linqChietKhauKhachHangDataContext lCKKH = new linqChietKhauKhachHangDataContext();

        public void TongHop()
        {
            lCKKH.sp_tblChietKhauKhachHang_TongHop(Thang, Nam, MaDonVi);
        }

        public DataTable DanhSach()
        {
            List<sp_tblChietKhauKhachHang_DanhSachResult> lst;
            lst = lCKKH.sp_tblChietKhauKhachHang_DanhSach(TuThang, DenThang, Nam, MaDonVi).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
