using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLTH.Untilities;
using DuLieuBCCP;

namespace daoSLTH.DoanhThuKhachHang
{
    public class daTheoDoiDoanhThu:daBase
    {
        public DataTable BaoCaoDonViCot()
        {
            daDB dDB = new daDB();
            dDB.TaoKetNoiTuConfig();
            return dDB.ChayThuTuc("sp_tblDoanhThuKhachHangDichVu_BaoCao_DonViCot '" + TuNgay.ToString() + "','" + DenNgay.ToString() + "','" + MaDonVi+"'").Tables[0];
        }
    }
}
