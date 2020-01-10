using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLTH.Untilities;
using daoSLTH.Database.CSKH;

namespace daoSLTH.CSKH
{
    public class daCSKHApDoiTuong
    {
        public enum eDoiTuong
        {
            Dịch_Vụ=1,
            Khách_Hàng=2,
            Bưu_Cục=3,
            Đơn_Vị=4
        }

        private linqCSKHApDoiTuongDataContext lADT = new linqCSKHApDoiTuongDataContext();
        private sp_tblcskhApDoiTuong_DanhSachResult _ADTuong = new sp_tblcskhApDoiTuong_DanhSachResult();

        public sp_tblcskhApDoiTuong_DanhSachResult ADTuong { get => _ADTuong; set => _ADTuong = value; }

        public void ThemSua()
        {
            lADT.sp_tblcskhApDoiTuong_Them(ADTuong.IDChinhSach, ADTuong.Ma, ADTuong.Ten, ADTuong.LoaiDoiTuong, ADTuong.NgayApDung, ADTuong.NgayKetThuc);
        }

        public bool KiemTra()
        {
            try
            {
                lADT.sp_tblcskhApDoiTuong_KiemTra(ADTuong.IDChinhSach, ADTuong.Ma).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Xoa()
        {
            lADT.sp_tblcskhApDoiTuong_Xoa(ADTuong.IDChinhSach, ADTuong.Ma);
        }

        public DataTable DanhSach()
        {
            List<sp_tblcskhApDoiTuong_DanhSachResult> lst;
            lst = lADT.sp_tblcskhApDoiTuong_DanhSach(ADTuong.IDChinhSach).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
