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
        public enum eTrangThai
        {
            Nhập_số_liệu=1,
            Sửa_số_liệu=2,
            Gửi_Báo_cáo=3,
            Duyệt_Báo_cáo=4,
            Khóa_Báo_cáo=5,
            Khởi_tạo_lại_Báo_cáo=6
        }

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
