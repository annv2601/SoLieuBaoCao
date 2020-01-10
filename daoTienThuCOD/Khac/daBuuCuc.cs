using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.Khac
{
    public class daBuuCuc
    {
        private linqBuuTaDataContext lBC = new linqBuuTaDataContext();
        private sp_LayThongTinBuuCucResult _BC = new sp_LayThongTinBuuCucResult();

        public sp_LayThongTinBuuCucResult BC { get => _BC; set => _BC = value; }

        public sp_LayThongTinBuuCucResult ThongTin()
        {
            try
            {
                BC = lBC.sp_LayThongTinBuuCuc(BC.MaBuuCuc).Single();
                return BC;
            }
            catch
            {
                return null;
            }
        }
    }
}
