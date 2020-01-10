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
    public class daCSKHChinhSach
    {
        private linqCSKHChinhSachDataContext lCS = new linqCSKHChinhSachDataContext();
        private sp_tblcskhChinhSach_DanhSachResult _CSach = new sp_tblcskhChinhSach_DanhSachResult();

        public sp_tblcskhChinhSach_DanhSachResult CSach { get => _CSach; set => _CSach = value; }

        public int ThemSua()
        {
            return lCS.sp_tblcskhChinhSach_ThemSua(CSach.ID, CSach.Ma, CSach.Ten, CSach.VanBan, CSach.NgayApDung, CSach.NgayKetThuc).Single().IDChinhSach.Value;
        }

        public void Xoa()
        {
            lCS.sp_tblcskhChinhSach_Xoa(CSach.ID);
        }

        public bool KiemTraMa()
        {
            sp_tblcskhChinhSach_KiemTraMaResult _kt;
            try
            {                
                _kt = lCS.sp_tblcskhChinhSach_KiemTraMa(CSach.Ma).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable DanhSach()
        {
            List<sp_tblcskhChinhSach_DanhSachResult> lst;
            lst = lCS.sp_tblcskhChinhSach_DanhSach().ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
