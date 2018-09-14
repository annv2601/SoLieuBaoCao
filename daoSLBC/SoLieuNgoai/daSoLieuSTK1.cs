using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using daoSLBC.Core;
using daoSLBC.Database.SoLieuNgoai;

namespace daoSLBC.SoLieuNgoai
{
    public class daSoLieuSTK1:daBase
    {
        private linqSoLieuSTK1DataContext lSTK1 = new linqSoLieuSTK1DataContext();

        public void LaySoLieuSTK1()
        {
            lSTK1.sp_tblSoLieuSTK1Ngay_LayDuLieu(Thang, Nam);
        }

        public void LaySoLieuSTK1_DonVi()
        {
            lSTK1.sp_tblSoLieuSTK1Ngay_LayDuLieu_DonVi(Thang, Nam, MaDonViSTK1);
        }
    }
}
