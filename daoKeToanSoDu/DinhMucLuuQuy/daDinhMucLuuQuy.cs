using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.DinhMucLuuQuy
{
    public class daDinhMucLuuQuy
    {
        private linqDinhMucLuuQuyDataContext lDM = new linqDinhMucLuuQuyDataContext();
        private sp_tblDinhMucLuuQuy_ThongTinResult _DMuc = new sp_tblDinhMucLuuQuy_ThongTinResult();

        public sp_tblDinhMucLuuQuy_ThongTinResult DMuc { get => _DMuc; set => _DMuc = value; }

        public void ThemSua(bool rLaDViNhap)
        {
            lDM.sp_tblDinhMucLuuQuy_ThemSua(DMuc.MaBuuCuc, DMuc.DinhMucLuuQuyTCBC, DMuc.DinhMucLuuQuyTKBD, DMuc.DinhMucLuuQuyTCBC_DonVi, DMuc.DinhMucLuuQuyTKBD_DonVi,
                DMuc.NgayApDung, DMuc.NgayKetThuc, DMuc.GhiChu, rLaDViNhap);
        }
    }
}
