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
    public class daChiTieuDanSuat
    {
        private linqChiTieuDanSuatDataContext lDS = new linqChiTieuDanSuatDataContext();
        private sp_tblChiTieuDanSuatCong_DanhSachResult _PT = new sp_tblChiTieuDanSuatCong_DanhSachResult();

        public sp_tblChiTieuDanSuatCong_DanhSachResult PT { get => _PT; set => _PT = value; }

        public void ThemDanSuatCong()
        {
            lDS.sp_tblChiTieuDanSuatCong_Them(PT.IDMauBieu, PT.IDChiTieu, PT.IDChiTieuDanSuat, PT.MaChiTieuDanSuat, PT.HeSo);
        }

        public void ThemDanSuatTru()
        {
            lDS.sp_tblChiTieuDanSuatTru_Them(PT.IDMauBieu, PT.IDChiTieu, PT.IDChiTieuDanSuat, PT.MaChiTieuDanSuat, PT.HeSo);
        }

        public void ThemDanSuatNhan()
        {
            lDS.sp_tblChiTieuDanSuatNhan_Them(PT.IDMauBieu, PT.IDChiTieu, PT.IDChiTieuDanSuat, PT.MaChiTieuDanSuat, PT.HeSo);
        }

        public DataTable DanhSachDanSuatCong()
        {
            List<sp_tblChiTieuDanSuatCong_DanhSachResult> lst;
            lst = lDS.sp_tblChiTieuDanSuatCong_DanhSach(PT.IDMauBieu, PT.IDChiTieu).ToList();

            int n;
            n = lst.Count();
            sp_tblChiTieuDanSuatCong_DanhSachResult _pt;
            for (int i = 0; i <= 10; i++)
            {
                n = n + 1;
                _pt = new sp_tblChiTieuDanSuatCong_DanhSachResult();
                _pt.IDMauBieu = PT.IDMauBieu;
                _pt.IDChiTieu = PT.IDChiTieu;
                _pt.IDChiTieuDanSuat = 0;
                _pt.STT = n;
                _pt.MaChiTieuDanSuat = "";
                _pt.HeSo = 0;
                _pt.TenChiTieuDanSuat = "";
                lst.Add(_pt);
            }

            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachDanSuatTru()
        {
            List<sp_tblChiTieuDanSuatTru_DanhSachResult> lst;
            lst = lDS.sp_tblChiTieuDanSuatTru_DanhSach(PT.IDMauBieu, PT.IDChiTieu).ToList();

            int n;
            n = lst.Count();
            sp_tblChiTieuDanSuatTru_DanhSachResult _pt;
            for (int i = 0; i <= 10; i++)
            {
                n = n + 1;
                _pt = new sp_tblChiTieuDanSuatTru_DanhSachResult();
                _pt.IDMauBieu = PT.IDMauBieu;
                _pt.IDChiTieu = PT.IDChiTieu;
                _pt.IDChiTieuDanSuat = 0;
                _pt.STT = n;
                _pt.MaChiTieuDanSuat = "";
                _pt.HeSo = 0;
                _pt.TenChiTieuDanSuat = "";
                lst.Add(_pt);
            }

            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachDanSuatNhan()
        {
            List<sp_tblChiTieuDanSuatNhan_DanhSachResult> lst;
            lst = lDS.sp_tblChiTieuDanSuatNhan_DanhSach(PT.IDMauBieu, PT.IDChiTieu).ToList();

            int n;
            n = lst.Count();
            sp_tblChiTieuDanSuatNhan_DanhSachResult _pt;
            for (int i = 0; i <= 10; i++)
            {
                n = n + 1;
                _pt = new sp_tblChiTieuDanSuatNhan_DanhSachResult();
                _pt.IDMauBieu = PT.IDMauBieu;
                _pt.IDChiTieu = PT.IDChiTieu;
                _pt.IDChiTieuDanSuat = 0;
                _pt.STT = n;
                _pt.MaChiTieuDanSuat = "";
                _pt.HeSo = 0;
                _pt.TenChiTieuDanSuat = "";
                lst.Add(_pt);
            }

            return daTienIch.ToDataTable(lst);
        }
    }
}
