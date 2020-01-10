using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class daB02KTNV
    {
        private linqB02KTNVDataContext lB02 = new linqB02KTNVDataContext();
        private sp_tblBaoCaoB02KTNV_ThongTinResult _B02 = new sp_tblBaoCaoB02KTNV_ThongTinResult();

        public sp_tblBaoCaoB02KTNV_ThongTinResult B02 { get => _B02; set => _B02 = value; }

        public void Xoa()
        {
            lB02.sp_tblBaoCaoB02KTNV_Xoa(B02.Thang, B02.Nam, B02.MaDonVi);
        }

        public void Them()
        {
            lB02.sp_tblBaoCaoB02KTNV_Them(
                B02.Thang,
                B02.Nam,
                B02.MaDonVi,
                B02.MaSo,
                B02.ChiTieu,
                B02.DonViTinh,
                B02.SanLuong,
                B02.DoanhThuPS,
                B02.DoanhThuLK,
                B02.ThueSuat,
                B02.ThuePS,
                B02.ThueLK,
                B02.SanLuongNghiepVuDi,
                B02.SanLuongDen);
        }
    }
}
