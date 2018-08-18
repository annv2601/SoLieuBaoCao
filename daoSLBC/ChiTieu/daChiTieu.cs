using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLBC.Core;
using daoSLBC.Database.ChiTieu;

namespace daoSLBC.ChiTieu
{
    public class daChiTieu
    {
        private linqChiTieuDataContext lCT = new linqChiTieuDataContext();
        private sp_tblChiTieuBaoCao_ThongTinResult _CTBC = new sp_tblChiTieuBaoCao_ThongTinResult();
        private sp_tblChiTieuBaoCao_TimResult _CTTim = new sp_tblChiTieuBaoCao_TimResult();
        private sp_tblMSCT_TimResult _MSCT = new sp_tblMSCT_TimResult();

        public sp_tblChiTieuBaoCao_ThongTinResult CTBC { get => _CTBC; set => _CTBC = value; }
        public sp_tblChiTieuBaoCao_TimResult CTTim { get => _CTTim; set => _CTTim = value; }
        public sp_tblMSCT_TimResult MSCT { get => _MSCT; set => _MSCT = value; }

        public sp_tblChiTieuBaoCao_ThongTinResult ThongTin()
        {
            try
            {
                CTBC = lCT.sp_tblChiTieuBaoCao_ThongTin(CTBC.ID).Single();
                return CTBC;
            }
            catch
            {
                return null;
            }
        }

        public sp_tblChiTieuBaoCao_TimResult Tim()
        {
            try
            {
                CTTim = lCT.sp_tblChiTieuBaoCao_Tim(CTTim.Ma).Single();
                return CTTim;
            }
            catch
            {
                return null;
            }
        }

        public sp_tblMSCT_TimResult TimMSCT()
        {
            try
            {
                MSCT = lCT.sp_tblMSCT_Tim(MSCT.MSCT).Single();
                return MSCT;
            }
            catch
            {
                return null;
            }
        }

        public DataTable DanhSach()
        {
            List<sp_tblChiTieuBaoCao_DanhSachResult> lst;
            lst = lCT.sp_tblChiTieuBaoCao_DanhSach(CTBC.IDNhom).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
