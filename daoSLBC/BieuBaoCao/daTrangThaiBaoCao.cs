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
    public class daTrangThaiBaoCao
    {
        private linqTrangThaiBaoCaoDataContext lTTBC = new linqTrangThaiBaoCaoDataContext();
        private sp_tblTrangThaiBieuBaoCao_ThongTinResult _TT = new sp_tblTrangThaiBieuBaoCao_ThongTinResult();

        public sp_tblTrangThaiBieuBaoCao_ThongTinResult TT { get => _TT; set => _TT = value; }

        public sp_tblTrangThaiBieuBaoCao_ThongTinResult ThongTin()
        {
            try
            {
                TT = lTTBC.sp_tblTrangThaiBieuBaoCao_ThongTin(TT.MaBaoCao, TT.NgayTrangThai).Single();
                return TT;
            }
            catch
            {
                return null;
            }
        }

        public void Them()
        {
            lTTBC.sp_tblTrangThaiBieuBaoCao_Them(TT.MaBaoCao, TT.IDTrangThai, TT.TenTrangThai, TT.NguoiThucHien, TT.TenMay, TT.DiaChiIP, TT.MAC);
        }

        public DataTable DanhSach()
        {
            List<sp_tblTrangThaiBieuBaoCao_DanhSachResult> lst;
            lst = lTTBC.sp_tblTrangThaiBieuBaoCao_DanhSach(TT.MaBaoCao).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
