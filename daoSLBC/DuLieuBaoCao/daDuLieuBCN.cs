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
    public class daDuLieuBCN:daBase
    {
        private linqDuLieuBCNDataContext lBCN = new linqDuLieuBCNDataContext();        
        private sp_tblDuLieuBaoCaoNhanh_ThongTinResult _BCN = new sp_tblDuLieuBaoCaoNhanh_ThongTinResult();

        public sp_tblDuLieuBaoCaoNhanh_ThongTinResult BCN { get => _BCN; set => _BCN = value; }


        public sp_tblDuLieuBaoCaoNhanh_ThongTinResult ThongTin()
        {
            try
            {
                BCN = lBCN.sp_tblDuLieuBaoCaoNhanh_ThongTin(BCN.MaBieuBaoCao, BCN.IDChiTieu).Single();
                return BCN;
            }
            catch
            {
                return null;
            }
        }

        public void KhoiTao()
        {
            lBCN.sp_tblDuLieuBaoCaoNhanh_KhoiTao(BCN.MaBieuBaoCao, IDMauBieu);
        }

        public void CapNhatNhap()
        {
            lBCN.sp_tblDuLieuBaoCaoNhanh_CapNhatBaoCao(BCN.MaBieuBaoCao, BCN.IDChiTieu, BCN.SoLieuNhap, BCN.NguoiNhapBCN);
        }

        public void CapNhatThucHien()
        {
            lBCN.sp_tblDuLieuBaoCaoNhanh_CapNhatThucHien(BCN.MaBieuBaoCao, BCN.IDChiTieu, BCN.SoLieuThucHien, BCN.NguoiNhapTH);
        }

        public void LaySTK1()
        {
            lBCN.sp_tblDuLieuBaoCaoNhanh_LaySTK1(Thang, Nam, MaDonViSTK1, MaBieuBaoCao);
        }

        public void TinhDanSuatSTK1()
        {
            lBCN.sp_tblDuLieuBaoCaoNhanh_TinhDanSuat_STK1(Thang, Nam, MaDonVi, MaBieuBaoCao);            
        }

        public void LaySTK1ThucHien()
        {
            lBCN.sp_tblDuLieuBaoCaoNhanh_LaySTK1_ThucHien(Thang, Nam, MaDonViSTK1, MaBieuBaoCao);
        }

        public void TinhDanSuatThucHien()
        {
            lBCN.sp_tblDuLieuBaoCaoNhanh_TinhDanSuat_ThucHien(Thang, Nam, MaDonVi, MaBieuBaoCao);
        }

        public List<clsTinhDanSuat> TinhDanSuatNhap()
        {
            linqDuLieuChiTietSTK1DataContext lCTSTK = new linqDuLieuChiTietSTK1DataContext();
            return lCTSTK.sp_tblDuLieuBaoCaoNhanh_TinhDanSuat_Nhap(IDMauBieu, BCN.MaBieuBaoCao, BCN.IDChiTieu,BCN.SoLieuNhap).ToList();
        }

        public DataTable DanhSachNhapBCN()
        {
            List<sp_tblDuLieuBaoCaoNhanh_DanhSachBaoCaoResult> lst;
            lst = lBCN.sp_tblDuLieuBaoCaoNhanh_DanhSachBaoCao(MaBieuBaoCao, Nam, MaDonVi).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
