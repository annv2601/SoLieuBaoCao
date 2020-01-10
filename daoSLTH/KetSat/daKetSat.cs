using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using daoSLTH.Database;
using daoSLTH.Untilities;

namespace daoSLTH.KetSat
{
    public class daKetSat:daBase
    {
        private linqKetSatDataContext lKS = new linqKetSatDataContext();
        private sp_tblKetSat_ThongTinResult _KS = new sp_tblKetSat_ThongTinResult();

        public sp_tblKetSat_ThongTinResult KS { get => _KS; set => _KS = value; }

        public void TongHop()
        {
            lKS.sp_tblKetSat_TongHop(Ngay);
        }

        public void TongHopPhatSinh()
        {
            lKS.sp_tblKetSatCoNo_TongHop(Ngay);
        }

        public DataTable DanhSachTheoDoi()
        {
            List<sp_tblKetSat_TheoDoi_BuuCucResult> lst;
            lst = lKS.sp_tblKetSat_TheoDoi_BuuCuc(TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
