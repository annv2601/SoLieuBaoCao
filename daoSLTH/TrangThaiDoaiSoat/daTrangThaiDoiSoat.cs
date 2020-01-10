using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using daoSLTH.Database;

namespace daoSLTH.TrangThaiDoaiSoat
{
    public class daTrangThaiDoiSoat
    {
        private linqTrangThaiDoiSoatDataContext _lTT = new linqTrangThaiDoiSoatDataContext();
        private sp_tblTrangThaiDoiSoat_ThongTinResult _TT = new sp_tblTrangThaiDoiSoat_ThongTinResult();

        public sp_tblTrangThaiDoiSoat_ThongTinResult TT { get => _TT; set => _TT = value; }

        public sp_tblTrangThaiDoiSoat_ThongTinResult ThongTin()
        {
            try
            {
                TT = _lTT.sp_tblTrangThaiDoiSoat_ThongTin(TT.MaBuuCuc, TT.Ngay).Single();
                return TT;
            }
            catch
            {
                return null;
            }
        }

        public void KhoiTao()
        {
            _lTT.sp_tblTrangThaiDoiSoat_KhoiTao(TT.Ngay);
        }
    }
}
