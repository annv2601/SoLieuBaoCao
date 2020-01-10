using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.SoLieuDen
{
    public class daSLDenBGGTri:daBase
    {
        private linqSLDenDataContext lSLDen = new linqSLDenDataContext();
        private sp_tblSLDen_TimBuuGuiResult _BGTim = new sp_tblSLDen_TimBuuGuiResult();

        public sp_tblSLDen_TimBuuGuiResult BGTim { get => _BGTim; set => _BGTim = value; }

        public sp_tblSLDen_TimBuuGuiResult Tim()
        {
            try
            {
                BGTim = lSLDen.sp_tblSLDen_TimBuuGui(BGTim.ItemCode, TuNgay, DenNgay).Single();
                return BGTim;
            }
            catch
            {
                return null;
            }
        }

        public DataTable DanhSachTHop(Double rSoTien)
        {
            List<sp_tblSLDen_BuuGui_GiaTri_THopResult> lst;
            lst = lSLDen.sp_tblSLDen_BuuGui_GiaTri_THop(MaDonVi, TuNgay, DenNgay, rSoTien).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblSLDen_BuuGui_GiaTri_THopResult> lstDanhSachTHop(Double rSoTien)
        {
            return lSLDen.sp_tblSLDen_BuuGui_GiaTri_THop(MaDonVi, TuNgay, DenNgay,rSoTien).ToList();
        }

        public DataTable DanhSachCTiet(double STnho, double STlon)
        {
            List<sp_tblSLDen_BuuGui_GiaTri_CTietResult> lst;
            lst = lSLDen.sp_tblSLDen_BuuGui_GiaTri_CTiet(MaDonVi, TuNgay, DenNgay, STnho, STlon).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblSLDen_BuuGui_GiaTri_CTietResult> lstDanhSachCTiet(double STnho, double STlon)
        {
            return lSLDen.sp_tblSLDen_BuuGui_GiaTri_CTiet(MaDonVi, TuNgay, DenNgay, STnho, STlon).ToList();
        }
    }
}
