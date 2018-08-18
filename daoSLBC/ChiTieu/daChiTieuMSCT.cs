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
    public class daChiTieuMSCT
    {
        private linqChiTieuMSCTDataContext lMSCT = new linqChiTieuMSCTDataContext();
        private sp_tblChiTieuGhepMSCTCong_DanhSachResult _PT = new sp_tblChiTieuGhepMSCTCong_DanhSachResult();

        public sp_tblChiTieuGhepMSCTCong_DanhSachResult PT { get => _PT; set => _PT = value; }

        public void ThemMSCTCong()
        {
            lMSCT.sp_tblChiTieuGhepMSCTCong_Them(PT.IDMauBieu, PT.IDChiTieu, PT.MSCT);
        }

        public void ThemMSCTTru()
        {
            lMSCT.sp_tblChiTieuGhepMSCTTru_Them(PT.IDMauBieu, PT.IDChiTieu, PT.MSCT);
        }

        public DataTable DanhSachMSCTCong()
        {
            List<sp_tblChiTieuGhepMSCTCong_DanhSachResult> lst;
            lst = lMSCT.sp_tblChiTieuGhepMSCTCong_DanhSach(PT.IDMauBieu, PT.IDChiTieu).ToList();

            int n;
            n = lst.Count();
            sp_tblChiTieuGhepMSCTCong_DanhSachResult _pt;
            for(int i=0;i<=10;i++)
            {
                n = n + 1;
                _pt = new sp_tblChiTieuGhepMSCTCong_DanhSachResult();
                _pt.IDMauBieu = PT.IDMauBieu;
                _pt.IDChiTieu = PT.IDChiTieu;
                _pt.MSCT = "";
                _pt.STT = n;
                _pt.TenMSCT = "";
                lst.Add(_pt);
            }

            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachMSCTTru()
        {
            List<sp_tblChiTieuGhepMSCTTru_DanhSachResult> lst;
            lst = lMSCT.sp_tblChiTieuGhepMSCTTru_DanhSach(PT.IDMauBieu, PT.IDChiTieu).ToList();

            int n;
            n = lst.Count();
            sp_tblChiTieuGhepMSCTTru_DanhSachResult _pt;
            for (int i = 0; i <= 10; i++)
            {
                n = n + 1;
                _pt = new sp_tblChiTieuGhepMSCTTru_DanhSachResult();
                _pt.IDMauBieu = PT.IDMauBieu;
                _pt.IDChiTieu = PT.IDChiTieu;
                _pt.MSCT = "";
                _pt.STT = n;
                _pt.TenMSCT = "";
                lst.Add(_pt);
            }

            return daTienIch.ToDataTable(lst);
        }
    }
}
