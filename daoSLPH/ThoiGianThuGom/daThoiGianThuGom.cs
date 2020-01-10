using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoSLPH.Database;

namespace daoSLPH.ThoiGianThuGom
{
    public class daThoiGianThuGom
    {
        private linqThoiGianThuGomDataContext lTG = new linqThoiGianThuGomDataContext();
        private sp_tblThoiGianThuGom_LayResult _TG = new sp_tblThoiGianThuGom_LayResult();

        public sp_tblThoiGianThuGom_LayResult TG { get => _TG; set => _TG = value; }

        public sp_tblThoiGianThuGom_LayResult Lay()
        {
            try
            {
                TG = lTG.sp_tblThoiGianThuGom_Lay(TG.MaBuuCuc).Single();
                return TG;
            }
            catch
            {
                return null;
            }
        }
    }
}
