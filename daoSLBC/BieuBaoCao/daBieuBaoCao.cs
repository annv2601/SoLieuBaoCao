using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLBC.Core;
using daoSLBC.Database.BieuBaoCao;

namespace daoSLBC.BieuBaoCao
{
    public class daBieuBaoCao
    {
        private linqBieuBaoCaoDataContext lBBC = new linqBieuBaoCaoDataContext();
        private sp_tblBieuBaoCao_ThongTinResult _BieuBC = new sp_tblBieuBaoCao_ThongTinResult();

        public sp_tblBieuBaoCao_ThongTinResult BieuBC { get => _BieuBC; set => _BieuBC = value; }

        public string SinhMaBaoCao()
        {
            BieuBC.MaBaoCao = daTienIch.LayBenPhai("0"+BieuBC.Thang.ToString(),2) + BieuBC.Nam.ToString() + BieuBC.DonVi;
            return BieuBC.MaBaoCao;
        }

        public sp_tblBieuBaoCao_ThongTinResult ThongTin()
        {
            try
            {
                BieuBC = lBBC.sp_tblBieuBaoCao_ThongTin(BieuBC.MaBaoCao).Single();
                return BieuBC;
            }
            catch
            {
                return null;
            }
        }

        public void Them()
        {
            lBBC.sp_tblBieuBaoCao_Them(BieuBC.MaBaoCao, BieuBC.Thang, BieuBC.Nam, BieuBC.DonVi, BieuBC.NoiDung, BieuBC.IDBieuDinhNghia, BieuBC.TongDoanhThu, BieuBC.TongChiPhi, BieuBC.TrangThai);
        }

        public void DoiTrangThai()
        {
            lBBC.sp_tblBieuBaoCao_DoiTrangThai(BieuBC.MaBaoCao, BieuBC.TrangThai);
        }

        public DataTable DanhSach()
        {
            List<sp_tblBieuBaoCao_DanhSachResult> lst;
            lst = lBBC.sp_tblBieuBaoCao_DanhSach(BieuBC.DonVi).ToList();

            sp_tblBieuBaoCao_DanhSachResult pt = new sp_tblBieuBaoCao_DanhSachResult();
            pt.STT = 0;
            pt.MaBaoCao = "000000";
            pt.TenBieuBaoCao = "Tạo Báo cáo mới";
            pt.urlAnh = "../Resource/Images/TaoBaoCao.png";
            lst.Add(pt);

            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSach_ThoiGian()
        {
            List<sp_tblBieuBaoCao_DanhSach_ThoiGianResult> lst;
            lst = lBBC.sp_tblBieuBaoCao_DanhSach_ThoiGian(BieuBC.Thang,BieuBC.Nam).ToList();

            sp_tblBieuBaoCao_DanhSach_ThoiGianResult pt = new sp_tblBieuBaoCao_DanhSach_ThoiGianResult();
            pt.STT = 0;
            pt.MaBaoCao = "000000";
            pt.urlAnh = "../Resource/Images/BieuBaoCao.png";
            lst.Add(pt);

            return daTienIch.ToDataTable(lst);
        }
    }
}
