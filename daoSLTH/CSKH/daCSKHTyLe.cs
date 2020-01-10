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
    public class daCSKHTyLe
    {
        private linqCSKHTyLeDataContext lTL = new linqCSKHTyLeDataContext();
        private sp_tblcskhTyLe_DanhSachResult _TLe = new sp_tblcskhTyLe_DanhSachResult();

        public sp_tblcskhTyLe_DanhSachResult TLe { get => _TLe; set => _TLe = value; }

        public void ThemSua()
        {
            lTL.sp_tblcskhTyLe_ThemSua(TLe.IDChinhSach, TLe.IDMucDoanhThu, TLe.TyLe, TLe.NgayApDung, TLe.NgayKetThuc);
        }

        public void Xoa()
        {
            lTL.sp_tblcskhTyLe_Xoa(TLe.IDChinhSach, TLe.IDMucDoanhThu);
        }

        public DataTable DanhSach()
        {
            List<sp_tblcskhTyLe_DanhSachResult> lst;
            lst = lTL.sp_tblcskhTyLe_DanhSach(TLe.IDChinhSach).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
