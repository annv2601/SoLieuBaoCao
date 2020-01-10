using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.Khac
{
    public class daTrangThaiKeToan:daBase
    {
        private linqTrangThaiKeToanDataContext lTThai = new linqTrangThaiKeToanDataContext();
        private sp_tblTrangThaiKeToan_ThongTinResult _TThai = new sp_tblTrangThaiKeToan_ThongTinResult();
        private sp_tblTrangThaiKeToan_LayNgayChotResult _NgayChot = new sp_tblTrangThaiKeToan_LayNgayChotResult();

        public sp_tblTrangThaiKeToan_ThongTinResult TThai { get => _TThai; set => _TThai = value; }
        public sp_tblTrangThaiKeToan_LayNgayChotResult NgayChot { get => _NgayChot; set => _NgayChot = value; }

        public sp_tblTrangThaiKeToan_ThongTinResult ThongTin()
        {
            try
            {
                _TThai = lTThai.sp_tblTrangThaiKeToan_ThongTin(MaBuuCuc, Ngay).Single();
                return _TThai;
            }
            catch
            {
                return null;
            }
        }

        public void Them()
        {
            lTThai.sp_tblTrangThaiKeToan_Them(_TThai.MaBuuCuc, _TThai.Ngay, TThai.DiaChiIP, TThai.TenMay, TThai.MAC);
        }

        public sp_tblTrangThaiKeToan_LayNgayChotResult LayNgayChot()
        {
            try
            {
                NgayChot = lTThai.sp_tblTrangThaiKeToan_LayNgayChot(MaBuuCuc).Single();
                return NgayChot;
            }
            catch
            {
                return null;
            }
        }

        public void ChotMo()
        {
            lTThai.sp_tblTrangThaiKeToan_ChotMo(MaBuuCuc, Ngay, TThai.ChotSoLieu);
        }

        public DataTable DanhSach()
        {
            List<sp_tblTrangThaiKeToan_DanhSachResult> lst;
            lst = lTThai.sp_tblTrangThaiKeToan_DanhSach(MaBuuCuc).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblTrangThaiKeToan_DanhSachResult> lstDanhSach()
        {
            return lTThai.sp_tblTrangThaiKeToan_DanhSach(MaBuuCuc).ToList();
        }
    }
}
