using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;
     
namespace daoKeToanSoDu.NganHang
{
    public class daNganHang
    {
        public enum eNhomNganHang
        {
            NH_Đề_Nghị_Tiếp_Quỹ=1
        }

        private linqNganHangDataContext lNH = new linqNganHangDataContext();
        private sp_tblNganHang_ThongTinResult _NHang = new sp_tblNganHang_ThongTinResult();

        public sp_tblNganHang_ThongTinResult NHang { get => _NHang; set => _NHang = value; }

        public sp_tblNganHang_ThongTinResult ThongTin()
        {
            try
            {
                NHang = lNH.sp_tblNganHang_ThongTin(NHang.MaDonVi, NHang.IDNhom).Single();
                return NHang;
            }
            catch
            {
                return null;
            }
        }

        public void ThemSua()
        {
            lNH.sp_tblNganHang_ThemSua(NHang.ID, NHang.MaDonVi, NHang.TenDonViHuong, NHang.SoTaiKhoan, NHang.NganHang, NHang.PhongGiaoDich, NHang.IDNhom);
        }
    }
}
