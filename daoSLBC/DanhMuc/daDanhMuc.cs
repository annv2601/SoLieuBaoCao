using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLBC.Database.DanhMuc;
using daoSLBC.Core;

namespace daoSLBC.DanhMuc
{
    public class daDanhMuc
    {
        private linqDanhMucDataContext lDM = new linqDanhMucDataContext();
        private sp_tblDanhMuc_DanhSachResult _DM = new sp_tblDanhMuc_DanhSachResult();

        public sp_tblDanhMuc_DanhSachResult DM { get => _DM; set => _DM = value; }

        public DataTable DanhSach()
        {
            List<sp_tblDanhMuc_DanhSachResult> lst;
            lst = lDM.sp_tblDanhMuc_DanhSach(DM.IDNhom).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
