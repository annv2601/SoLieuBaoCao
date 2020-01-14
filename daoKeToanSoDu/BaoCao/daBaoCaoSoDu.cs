using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;
using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;


namespace daoKeToanSoDu.BaoCao
{
    public class daBaoCaoSoDu
    {
        private linqBaoCaoDataContext _lBC = new linqBaoCaoDataContext();

        public DataTable TonQuyCuoiNgay(string rMaDVi, DateTime rNgay)
        {
            List<sp_tblKeToanSoDu_BaoCaoTonQuyResult> lst;
            lst = _lBC.sp_tblKeToanSoDu_BaoCaoTonQuy(rMaDVi, rNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable TonQuyCuoiNgayBuuCuc(string rMaBuuCuc, DateTime rNgay)
        {
            List<sp_tblKeToanSoDu_BaoCaoTonQuyResult> lst=new List<sp_tblKeToanSoDu_BaoCaoTonQuyResult>();            
            sp_tblKeToanSoDu_BaoCaoTonQuyResult pt = new sp_tblKeToanSoDu_BaoCaoTonQuyResult();
            linqKeToanSoDuDataContext lKTSD = new linqKeToanSoDuDataContext();
            try
            {
                sp_tblKeToanSoDu_DanhSachNhapResult _tq = lKTSD.sp_tblKeToanSoDu_DanhSachNhap(rMaBuuCuc, rNgay, rNgay).Single();

                pt.STT = "1";
                pt.Ten = "Số dư tiền cuối ngày";
                pt.DinhMucLuuQuyTCBC_DonVi = _tq.DinhMucLuuQuyTCBC_DonVi;
                pt.DinhMucLuuQuyTKBD_DonVi = _tq.DinhMucLuuQuyTKBD_DonVi;
                pt.TCBCTapTrung = _tq.TCBCTapTrung;
                pt.TCBCThanhToanTaiDonVi = _tq.TCBCThanhToanTaiDonVi;
                pt.TKBD = _tq.TKBD;
                pt.KinhDoanh = _tq.KinhDoanh;
                pt.Cong = _tq.Cong;
                pt.Dam = false;
                pt.Nghieng = false;

                lst.Add(pt);

                pt = new sp_tblKeToanSoDu_BaoCaoTonQuyResult();
                pt.STT = "2";
                pt.Ten = "Dự kiến chi trả ngày tiếp theo";
                pt.DinhMucLuuQuyTCBC_DonVi = 0;
                pt.DinhMucLuuQuyTKBD_DonVi = 0;
                pt.TCBCTapTrung = _tq.dkTCBCTapTrung;
                pt.TCBCThanhToanTaiDonVi = _tq.dkTCBCThanhToanTaiDonVi;
                pt.TKBD = _tq.dkTKBD;
                pt.KinhDoanh = _tq.dkKinhDoanh;
                pt.Cong = _tq.dkCong;
                pt.Dam = false;
                pt.Nghieng = false;

                lst.Add(pt);
            }
            catch { }
            

            return daTienIch.ToDataTable(lst);
        }

    }
}
