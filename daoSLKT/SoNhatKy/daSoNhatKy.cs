using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLKT.Database;
using daoSLKT;

namespace daoSLKT.SoNhatKy
{
    public class daSoNhatKy
    {
        private linqSoNhatKyDataContext lSNK = new linqSoNhatKyDataContext();
        private sp_tblSoNhatKy_ChiTietResult _SNK = new sp_tblSoNhatKy_ChiTietResult();

        public sp_tblSoNhatKy_ChiTietResult SNK { get => _SNK; set => _SNK = value; }

        public DataTable DanhSachChiTiet()
        {
            List<sp_tblSoNhatKy_ChiTietResult> lst;
            lst = lSNK.sp_tblSoNhatKy_ChiTiet(SNK.Thang, SNK.Nam, SNK.MaDonVi,SNK.ND,SNK.NGAY_HT).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachChiTiet2(string rSoTaiKhoan, bool rNoCo)
        {
            List<sp_tblSoNhatKy_ChiTiet2Result> lst;
            lst = lSNK.sp_tblSoNhatKy_ChiTiet2(SNK.Thang, SNK.Nam, SNK.MaDonVi, SNK.NGAY_HT, rSoTaiKhoan, rNoCo).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable TongHop1()
        {
            List<sp_tblSoNhatKy_TongHop1Result> lst;
            lst = lSNK.sp_tblSoNhatKy_TongHop1(SNK.Thang, SNK.Nam, SNK.MaDonVi).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable TongHop2(bool rNoCo)
        {
            List<sp_tblSoNhatKy_TongHop2Result> lst;
            lst = lSNK.sp_tblSoNhatKy_TongHop2(SNK.Thang, SNK.Nam, SNK.MaDonVi,rNoCo).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
