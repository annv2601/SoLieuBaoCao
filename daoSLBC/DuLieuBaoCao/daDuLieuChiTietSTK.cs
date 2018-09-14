using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLBC.Core;
using daoSLBC.Database.DuLieuBaoCao;

namespace daoSLBC.DuLieuBaoCao
{
    public class daDuLieuChiTietSTK
    {
        private linqDuLieuChiTietSTK1DataContext lCTSTK = new linqDuLieuChiTietSTK1DataContext();

        private string _MaBieuBaoCao;

        private int _IDChiTieu;

        public string MaBieuBaoCao { get => _MaBieuBaoCao; set => _MaBieuBaoCao = value; }
        public int IDChiTieu { get => _IDChiTieu; set => _IDChiTieu = value; }

        public DataTable dsChiTietDichVu()
        {
            List<clsChiTietDichVu> lst;
            lst = lCTSTK.sp_tblDuLieuBaoCaoNhanh_ChiTiet_STK1(MaBieuBaoCao, IDChiTieu).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable dsChiTietDichVuNgay()
        {
            List<clsChiTietNgay> lst;
            lst = lCTSTK.sp_tblDuLieuBaoCaoNhanh_ChiTiet_STK1_ThoiGian(MaBieuBaoCao, IDChiTieu).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable dsChiTietBuuCucNgay()
        {
            List<clsChiTietNgay> lst;
            lst = lCTSTK.sp_tblDuLieuBaoCaoNhanh_ChiTiet_STK1_DonVi(MaBieuBaoCao, IDChiTieu).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
