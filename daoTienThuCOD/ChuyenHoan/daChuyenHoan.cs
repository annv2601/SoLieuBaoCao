using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.ChuyenHoan
{
    public class daChuyenHoan:daBase
    {
        private linqChuyenHoanDataContext lCHoan = new linqChuyenHoanDataContext();
        private sp_tblChuyenHoan_ThongTinResult _BGCHoan = new sp_tblChuyenHoan_ThongTinResult();

        public sp_tblChuyenHoan_ThongTinResult BGCHoan { get => _BGCHoan; set => _BGCHoan = value; }

        public sp_tblChuyenHoan_ThongTinResult ThongTin()
        {
            try
            {
                BGCHoan = lCHoan.sp_tblChuyenHoan_ThongTin(BGCHoan.ItemCode, BGCHoan.ItemCode).Single();
                return BGCHoan;
            }
            catch
            {
                return null;
            }
        }

        public void Xoa()
        {
            lCHoan.sp_tblChuyenHoan_Xoa(MaBuuCuc, Ngay, Ca);
        }

        public void Them()
        {
            lCHoan.sp_tblChuyenHoan_Them(BGCHoan.Ngay,
                BGCHoan.Ca,
                BGCHoan.MaBuuCuc,
                BGCHoan.ItemCode,
                BGCHoan.ReceiverFullname,
                BGCHoan.ReceiverAddress,
                BGCHoan.ReceiverTel,
                BGCHoan.Weight,
                BGCHoan.SoTienCOD,
                BGCHoan.TongCuoc,
                BGCHoan.VAT,
                BGCHoan.ThanhTien,
                BGCHoan.LyDo,
                BGCHoan.NgayChuyenHoan);

        }

        public DataTable DanhSach()
        {
            List<sp_tblChuyenHoan_DanhSachResult> lst;
            lst = lCHoan.sp_tblChuyenHoan_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblChuyenHoan_DanhSachResult> lstDanhSach()
        {
            List<sp_tblChuyenHoan_DanhSachResult> lst;
            lst = lCHoan.sp_tblChuyenHoan_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
            return lst;
        }

        public void CapNhat_TrangThai()
        {
            lCHoan.sp_tblChuyenHoan_CapNhatTrangThai(MaBuuCuc, Ngay);
        }
    }
}
