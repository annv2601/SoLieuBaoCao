using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class daSoNhatKy
    {
        private linqSoNhatKyDataContext lSNK = new linqSoNhatKyDataContext();
        private sp_tblSoNhatKy_ThongTinResult _SNK = new sp_tblSoNhatKy_ThongTinResult();

        public sp_tblSoNhatKy_ThongTinResult SNK { get => _SNK; set => _SNK = value; }

        public void Them()
        {
            TachMaDonVi();

            lSNK.sp_tblSoNhatKyTam_Them(SNK.NGAY_HT, SNK.SO_CT, SNK.NGAY_CT, SNK.ND, SNK.TK_NO, SNK.TKE_NO, SNK.DTU_NO, SNK.SP_NO, SNK.TK_CO, SNK.TKE_CO, SNK.DTU_CO,
                SNK.SP_CO, SNK.TIEN_NO, SNK.TIEN_CO, SNK.MA_DVI, SNK.NOTE, SNK.MaDonVi, SNK.MaNSD, SNK.Thang, SNK.Nam, SNK.NgayHeThong);
        }

        private void TachMaDonVi()
        {
            string[] str = SNK.MA_DVI.Split('/');
            SNK.MaDonVi = str[0];
            SNK.MaNSD = str[1];
        }
    }
}
