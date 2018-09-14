using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using daoSLBC.Core;
using daoSLBC.Database.DanhMuc;

namespace daoSLBC.DanhMuc
{
    public class daMauBieu
    {
        private linqMauBieuBaoCaoDataContext lMB = new linqMauBieuBaoCaoDataContext();
        private sp_tblMauBieuBaoCaoDinhNghia_ThongTinResult _MB = new sp_tblMauBieuBaoCaoDinhNghia_ThongTinResult();

        public sp_tblMauBieuBaoCaoDinhNghia_ThongTinResult MB { get => _MB; set => _MB = value; }

        public sp_tblMauBieuBaoCaoDinhNghia_ThongTinResult ThongTin()
        {
            try
            {
                MB = lMB.sp_tblMauBieuBaoCaoDinhNghia_ThongTin(MB.ID).Single();
                return MB;
            }
            catch
            {
                return null;
            }
        }

        public void ThemSua()
        {
            lMB.sp_tblMauBieuBaoCaoDinhNghia_ThemSua(MB.ID, MB.Ma, MB.Ten, MB.TenTat, MB.TieuDe1, MB.TieuDe2, MB.TieuDe3, MB.Muc, MB.Cap,
                MB.GhiChu, MB.NgayApDung, MB.NgayKetThuc, MB.NguoiTao,MB.Nhom);
        }

        public DataTable DanhSach()
        {
            List<sp_tblMauBieuBaoCaoDinhNghia_DanhSachResult> lst;
            lst = lMB.sp_tblMauBieuBaoCaoDinhNghia_DanhSach().ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
