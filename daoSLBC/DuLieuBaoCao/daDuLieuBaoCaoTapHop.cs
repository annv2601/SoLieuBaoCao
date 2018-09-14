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
    public class daDuLieuBaoCaoTapHop:daBase
    {
        private linqDuLieuBaocaoTapHopDataContext lDLTH = new linqDuLieuBaocaoTapHopDataContext();
        private sp_tblDuLieuBaoCaoNhanh_DanhSachBaoCaoResult _TapHop = new sp_tblDuLieuBaoCaoNhanh_DanhSachBaoCaoResult();
        public sp_tblDuLieuBaoCaoNhanh_DanhSachBaoCaoResult TapHop { get => _TapHop; set => _TapHop = value; }

        public void CapNhatBCN()
        {
            lDLTH.sp_tblDuLieuBaoCaoNhanhTapHop_CapNhatBaoCao(TapHop.MaBieuBaoCao, TapHop.IDChiTieu, TapHop.SoLieuNhap, "");
        }

        public void CapNhatThucHien()
        {
            lDLTH.sp_tblDuLieuBaoCaoNhanhTapHop_CapNhatThucHien(TapHop.MaBieuBaoCao, TapHop.IDChiTieu, TapHop.SoLieuThucHien, "");
        }

        public void TapHopDuLieu(bool LaBCN_THien)
        {
            lDLTH.sp_tblDuLieuBaoCaoNhanhTapHop_TapHop(MaBieuBaoCao, LaBCN_THien);
        }

        public void KhoiTao()
        {
            lDLTH.sp_tblDuLieuBaoCaoNhanhTapHop_KhoiTao(MaBieuBaoCao, IDMauBieu);
        }

        public DataTable DanhSachBaoCao()
        {
            List<sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCaoResult> lst;
            lst = lDLTH.sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCao(MaBieuBaoCao,Nam, MaDonVi).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable ChiTietDonVi(int rLoaiDuLieu)
        {
            List<clsChiTietDonViTapHop> lst;
            lst = lDLTH.sp_tblDuLieuBaoCaoNhanhTapHop_ChiTietDonVi(MaBieuBaoCao, rLoaiDuLieu).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
