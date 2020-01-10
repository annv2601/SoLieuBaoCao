using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoSLPH.Database;

namespace daoSLPH.LanLayDuLieu
{
    public class daLanLayDuLieu
    {
        private linqLayDuLieuDataContext lLay = new linqLayDuLieuDataContext();
        private sp_tblLanLayDuLieu_ThongTinResult _LanLay = new sp_tblLanLayDuLieu_ThongTinResult();

        public sp_tblLanLayDuLieu_ThongTinResult LanLay { get => _LanLay; set => _LanLay = value; }

        public void Them()
        {
            lLay.sp_tblLanLayDuLieu_Them(LanLay.MaBuuCuc,
                LanLay.MAC,
                LanLay.DiaChiIP,
                LanLay.DichVu,
                LanLay.SoLuong,
                LanLay.TongTien,
                LanLay.ThoiGianBatDau,
                LanLay.ThoiGianKetThuc,
                LanLay.ChuoiKetNoi);
        }
    }
}
