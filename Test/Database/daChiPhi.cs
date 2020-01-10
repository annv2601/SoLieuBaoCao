using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class daChiPhi
    {
        private linqChiPhiDataContext lCP = new linqChiPhiDataContext();
        private sp_tblChiPhi_ThongTinResult _CP = new sp_tblChiPhi_ThongTinResult();

        public sp_tblChiPhi_ThongTinResult CP { get => _CP; set => _CP = value; }

        public void Xoa()
        {
            lCP.sp_tblChiPhi_Xoa(CP.Thang, CP.Nam, CP.MaDonVi);
        }

        public void Them()
        {
            lCP.sp_tblChiPhi_Them(CP.Thang, CP.Nam, CP.MaDonVi, CP.Ma, CP.Ten, CP.DonViTinh,
                CP.PhatSinhThuongXuyen, CP.PhatSinhPhanBo, CP.TongCong);
        }
    }
}
