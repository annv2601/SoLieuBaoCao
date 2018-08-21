using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using daoSLBC.Database.HeThong;

namespace daoSLBC.HeThong
{
    public class daDangNhap
    {
        private linqDangNhapDataContext lDN = new linqDangNhapDataContext();

        #region Thuoc tinh
        private string _MaNSD;

        private string _MaDonVi;

        private string _TenNguoiSuDung;

        public string MaNSD { get => _MaNSD; set => _MaNSD = value; }
        public string MaDonVi { get => _MaDonVi; set => _MaDonVi = value; }
        public string TenNguoiSuDung { get => _TenNguoiSuDung; set => _TenNguoiSuDung = value; }

        #endregion

        public bool KiemTra()
        {
            try
            {
                TenNguoiSuDung = lDN.sp_KiemTraDangNhap(MaNSD, MaDonVi).Single().KetQuaKiemTra;
                if (TenNguoiSuDung!="")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
