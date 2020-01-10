using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLBC.Database.HeThong;
using daoSLBC.Core;
namespace daoSLBC.HeThong
{
    public class daDangNhap
    {
        private linqDangNhapDataContext lDN = new linqDangNhapDataContext();
        
        #region Thuoc tinh
        private string _MaNSD;

        private string _MaDonVi;

        private string _TenNguoiSuDung;

        private sp_KiemTraDangNhapResult _TTDN = new sp_KiemTraDangNhapResult();

        public string MaNSD { get => _MaNSD; set => _MaNSD = value; }
        public string MaDonVi { get => _MaDonVi; set => _MaDonVi = value; }
        public string TenNguoiSuDung { get => _TenNguoiSuDung; set => _TenNguoiSuDung = value; }
        public sp_KiemTraDangNhapResult TTDN { get => _TTDN; set => _TTDN = value; }

        #endregion

        public bool KiemTra()
        {
            try
            {
                //TenNguoiSuDung = lDN.sp_KiemTraDangNhap(MaNSD, MaDonVi).Single().KetQuaKiemTra;
                
                TTDN = lDN.sp_KiemTraDangNhap(MaNSD, MaDonVi).Single();
                TenNguoiSuDung = TTDN.TenNguoiSuDung;

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

        public DataTable DanhSach()
        {
            List<sp_NguoiSuDung_DanhSachResult> lst;
            lst = lDN.sp_NguoiSuDung_DanhSach().ToList();
            
            return daTienIch.ToDataTable(lst);
        }
    }
}
