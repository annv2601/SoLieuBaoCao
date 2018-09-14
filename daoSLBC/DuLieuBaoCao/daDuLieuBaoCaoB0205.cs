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
    public class daDuLieuBaoCaoB0205:daBase
    {
        private linqDuLieuBaoCaoB0205DataContext lB0205 = new linqDuLieuBaoCaoB0205DataContext();

        public void KhoiTao()
        {
            lB0205.sp_tblDuLieuBaoCaoB0205_KhoiTao(MaBieuBaoCao, IDMauBieu, NguoiThucHien);
        }

        public void LaySoLieuSTK1()
        {
            lB0205.sp_tblDuLieuBaoCaoB0205_LaySTK1(Thang, Nam, MaDonViSTK1, MaBieuBaoCao);
        }

        public void TinhDanSuat()
        {
            lB0205.sp_tblDuLieuBaoCaoB0205_TinhDanSuat_STK1(Thang, Nam, MaDonVi, MaBieuBaoCao);
        }

        public List<sp_tblDuLieuBaoCaoB0205_BaoCaoResult> lstDanhSach()
        {
            return lB0205.sp_tblDuLieuBaoCaoB0205_BaoCao(MaBieuBaoCao).ToList();
        }

        public DataTable DanhSach()
        {
            List<sp_tblDuLieuBaoCaoB0205_BaoCaoResult> lst;
            lst = lB0205.sp_tblDuLieuBaoCaoB0205_BaoCao(MaBieuBaoCao).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
