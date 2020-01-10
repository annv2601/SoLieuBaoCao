using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DuLieuBCCP;

namespace daoSLPH.DataClient
{
    public class daDocSLDen
    {
        public DateTime Ngay;
        public Int16 Ca;
        public string MaBuuCuc = "";

        public DataTable DocDuLieuDen()
        {            
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
            if (dCH.CauHinh != null)
            {
                MaBuuCuc = dCH.CauHinh.GiaTri;
            }

            daBuuGui dBG = new daBuuGui();
            dBG.SoHieuBuuCuc = MaBuuCuc;
            dBG.Ngay = Ngay;

            dCH.Lay((int)daCauHinh.eCauHinh.Đường_Dẫn_BCCP);
            if (dCH.CauHinh != null)
            {
                dBG.FileConfigBCCP = dCH.CauHinh.GiaTri;
            }

            if (Ca == 1)
            {
                return dBG.DanhSachBuuGui_CODDen_CaSang();
            }
            else
            {
                return dBG.DanhSachBuuGui_CODDen_CaChieu();
            }
        }

        public DataTable DocDuLieuPhanBuuTa()
        {            
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
            if (dCH.CauHinh != null)
            {
                MaBuuCuc = dCH.CauHinh.GiaTri;
            }

            daBuuGui dBG = new daBuuGui();
            dBG.SoHieuBuuCuc = MaBuuCuc;
            dBG.Ngay = Ngay;

            dCH.Lay((int)daCauHinh.eCauHinh.Đường_Dẫn_BCCP);
            if (dCH.CauHinh != null)
            {
                dBG.FileConfigBCCP = dCH.CauHinh.GiaTri;
            }

            if (Ca == 1)
            {
                return dBG.DanhSachBuuGui_COD_DongBuuTa_CaSang();
            }
            else
            {
                return dBG.DanhSachBuuGui_COD_DongBuuTa_CaChieu();
            }
        }

        public DataTable DocDuLieuChuyenHoan()
        {            
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
            if (dCH.CauHinh != null)
            {
                MaBuuCuc = dCH.CauHinh.GiaTri;
            }

            daBuuGui dBG = new daBuuGui();
            dBG.SoHieuBuuCuc = MaBuuCuc;
            dBG.Ngay = Ngay;
            dBG.TuNgay = Ngay;
            dBG.DenNgay = Ngay;

            dCH.Lay((int)daCauHinh.eCauHinh.Đường_Dẫn_BCCP);
            if (dCH.CauHinh != null)
            {
                dBG.FileConfigBCCP = dCH.CauHinh.GiaTri;
            }

            return dBG.DanhSachBuuGui_ChuyenHoan();
        }

        public DataTable DocDuLieuChuyenTiep()
        {
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
            if (dCH.CauHinh != null)
            {
                MaBuuCuc = dCH.CauHinh.GiaTri;
            }

            daBuuGui dBG = new daBuuGui();
            dBG.SoHieuBuuCuc = MaBuuCuc;
            dBG.Ngay = Ngay;
            dBG.TuNgay = Ngay;
            dBG.DenNgay = Ngay;

            dCH.Lay((int)daCauHinh.eCauHinh.Đường_Dẫn_BCCP);
            if (dCH.CauHinh != null)
            {
                dBG.FileConfigBCCP = dCH.CauHinh.GiaTri;
            }

            return dBG.DanhSachBuuGui_ChuyenTiep();
        }
    }
}
