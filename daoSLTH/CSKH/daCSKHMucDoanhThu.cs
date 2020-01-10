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
    public class daCSKHMucDoanhThu
    {
        private linqCSKHMucDoanhThuDataContext lMDT = new linqCSKHMucDoanhThuDataContext();
        private sp_tblcskhMucDoanhThu_DanhSachResult _MDThu = new sp_tblcskhMucDoanhThu_DanhSachResult();

        public sp_tblcskhMucDoanhThu_DanhSachResult MDThu { get => _MDThu; set => _MDThu = value; }

        public void ThemSua()
        {
            lMDT.sp_tblcskhMucDoanhThu_ThemSua(MDThu.ID, MDThu.Ma, MDThu.Ten, MDThu.MucDuoi, MDThu.MucTren, MDThu.GhiChu);
        }

        public bool KiemTra()
        {
            try
            {
                lMDT.sp_tblcskhMucDoanhThu_KiemTra(MDThu.MucDuoi, MDThu.MucTren).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable DanhSach()
        {
            List<sp_tblcskhMucDoanhThu_DanhSachResult> lst;
            lst = lMDT.sp_tblcskhMucDoanhThu_DanhSach().ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
