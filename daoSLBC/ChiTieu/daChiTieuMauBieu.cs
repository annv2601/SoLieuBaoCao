using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLBC.Database.ChiTieu;
using daoSLBC.Core;

namespace daoSLBC.ChiTieu
{
    public class daChiTieuMauBieu
    {
        private linqChiTieuMauBieuDataContext lCTMB = new linqChiTieuMauBieuDataContext();
        private sp_tblChiTieuTheoMauBieu_ThongTinResult _CTMB = new sp_tblChiTieuTheoMauBieu_ThongTinResult();

        public sp_tblChiTieuTheoMauBieu_ThongTinResult CTMB { get => _CTMB; set => _CTMB = value; }

        public sp_tblChiTieuTheoMauBieu_ThongTinResult ThongTin()
        {
            try
            {
                CTMB = lCTMB.sp_tblChiTieuTheoMauBieu_ThongTin(CTMB.IDMauBieu, CTMB.IDChiTieu).Single();
                return CTMB;
            }
            catch
            {
                return null;
            }
        }

        public void ThemSua()
        {
            lCTMB.sp_tblChiTieuTheoMauBieu_ThemSua(CTMB.IDMauBieu, CTMB.IDChiTieu, CTMB.ThuTu, CTMB.InDam, CTMB.InNghieng, CTMB.STTsx,
                CTMB.NhapTay, CTMB.LayTuDong, CTMB.NguoiTao);
        }

        public void Xoa()
        {
            lCTMB.sp_tblChiTieuTheoMauBieu_Xoa(CTMB.IDMauBieu, CTMB.IDChiTieu);
        }

        public void KhoiTao()
        {
            lCTMB.sp_tblChiTieuTheoMauBieu_KhoiTao(CTMB.IDMauBieu, CTMB.IDChiTieu,CTMB.NguoiTao);
        }

        public DataTable DanhSach()
        {
            List<sp_tblChiTieuTheoMauBieu_DanhSachResult> lst;
            lst = lCTMB.sp_tblChiTieuTheoMauBieu_DanhSach(CTMB.IDMauBieu).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
