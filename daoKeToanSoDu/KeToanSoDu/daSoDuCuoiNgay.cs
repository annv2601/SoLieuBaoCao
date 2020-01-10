﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.KeToanSoDu
{
    public class daSoDuCuoiNgay
    {
        private linqKeToanSoDuDataContext lSD = new linqKeToanSoDuDataContext();

        public DataTable BaoCaoNgay(string rMDV, DateTime rTNgay, DateTime rDNgay)
        {
            List<sp_tblKeToanSoDu_BaoCao_NgayResult> lst;
            lst = lSD.sp_tblKeToanSoDu_BaoCao_Ngay(rTNgay, rDNgay, rMDV).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable BaoCaoDonVi(string rMDV, DateTime rTNgay, DateTime rDNgay, bool rNhomTheoDV)
        {
            List<sp_tblKeToanSoDu_BaoCao_DonViResult> lst;
            lst = lSD.sp_tblKeToanSoDu_BaoCao_DonVi(rTNgay, rDNgay, rMDV, rNhomTheoDV).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
