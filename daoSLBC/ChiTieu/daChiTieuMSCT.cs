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
            lMSCT.sp_tblChiTieuGhepMSCTCong_Them(PT.IDMauBieu, PT.IDChiTieu, PT.MSCT,PT.LoaiSoLieu);
        }

        public void ThemMSCTTru()
        {
            lMSCT.sp_tblChiTieuGhepMSCTTru_Them(PT.IDMauBieu, PT.IDChiTieu, PT.MSCT, PT.LoaiSoLieu);
        }

        public void XoaMSCTCong()
        {
            lMSCT.sp_tblChiTieuGhepMSCTCong_Xoa(PT.IDMauBieu, PT.IDChiTieu, PT.MSCT, PT.LoaiSoLieu);
        }

        public void XoaMSCTTru()
        {
            lMSCT.sp_tblChiTieuGhepMSCTTru_Xoa(PT.IDMauBieu, PT.IDChiTieu, PT.MSCT, PT.LoaiSoLieu);
        }

        public DataTable DanhSachMSCTCong()
        {
            List<sp_tblChiTieuGhepMSCTCong_DanhSachResult> lst;
            lst = lMSCT.sp_tblChiTieuGhepMSCTCong_DanhSach(PT.IDMauBieu, PT.IDChiTieu, PT.LoaiSoLieu).ToList();

            int n;
            n = lst.Count();
            sp_tblChiTieuGhepMSCTCong_DanhSachResult _pt;
            for(int i=0;i<=10;i++)
            {
                n = n + 1;
                _pt = new sp_tblChiTieuGhepMSCTCong_DanhSachResult();
                _pt.IDMauBieu = PT.IDMauBieu;
                _pt.IDChiTieu = PT.IDChiTieu;
                _pt.LoaiSoLieu = PT.LoaiSoLieu;
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
            lst = lMSCT.sp_tblChiTieuGhepMSCTTru_DanhSach(PT.IDMauBieu, PT.IDChiTieu, PT.LoaiSoLieu).ToList();

            int n;
            n = lst.Count();
            sp_tblChiTieuGhepMSCTTru_DanhSachResult _pt;
            for (int i = 0; i <= 10; i++)
            {
                n = n + 1;
                _pt = new sp_tblChiTieuGhepMSCTTru_DanhSachResult();
                _pt.IDMauBieu = PT.IDMauBieu;
                _pt.IDChiTieu = PT.IDChiTieu;
                _pt.LoaiSoLieu = PT.LoaiSoLieu;
                _pt.MSCT = "";
                _pt.STT = n;
                _pt.TenMSCT = "";
                lst.Add(_pt);
            }

            return daTienIch.ToDataTable(lst);
        }
    }

    public class clsCotSTK1
    {
        public enum eCotSTK1
        {
            SLDi=1,
            SLDen=2,
            SLNVu=3,
            Cuoc=4,
            vat=5
        }

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Ma", typeof(string));
            dt.Columns.Add("Ten", typeof(string));

            dt.Rows.Add(1, "SLDi", "Sản lượng đi");
            dt.Rows.Add(1, "SLDen", "Sản lượng đến");
            dt.Rows.Add(1, "SLNVu", "Sản lượng nghiệp vụ");
            dt.Rows.Add(1, "Cuoc", "Doanh thu chưa thuế");
            dt.Rows.Add(1, "Vat", "Thuế GTGT");

            return dt;
        }
    }

    public class ptCotSTK1
    {
        private int _ID;

        private string _Ma;

        private string _Ten;

        public int ID { get => _ID; set => _ID = value; }
        public string Ma { get => _Ma; set => _Ma = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
    }
}
