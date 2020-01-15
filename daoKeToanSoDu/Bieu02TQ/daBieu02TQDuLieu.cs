using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.Bieu02TQ
{
    public class daBieu02TQDuLieu
    {
        private linqBieu02TQDataContext lB02 = new linqBieu02TQDataContext();
        private sp_tblBieuBaoCao02TQDuLieu_ThongTinResult _B02DLieu = new sp_tblBieuBaoCao02TQDuLieu_ThongTinResult();

        public sp_tblBieuBaoCao02TQDuLieu_ThongTinResult B02DLieu { get => _B02DLieu; set => _B02DLieu = value; }

        public sp_tblBieuBaoCao02TQDuLieu_ThongTinResult ThongTin()
        {
            try
            {
                B02DLieu = lB02.sp_tblBieuBaoCao02TQDuLieu_ThongTin(B02DLieu.IDBieuBaoCao, B02DLieu.MaDonVi).Single();
                return B02DLieu;
            }
            catch
            {
                return null;
            }
        }

        public void TongHopSoLieu(DateTime rNgay)
        {
            lB02.sp_tblBieuBaoCao02TQDuLieu_TongHopDuLieu(B02DLieu.IDBieuBaoCao, rNgay);
        }

        public DataTable BaoCao()
        {
            List<sp_tblBieuBaoCao02TQDuLieu_BaoCaoResult> lst;
            lst = lB02.sp_tblBieuBaoCao02TQDuLieu_BaoCao(B02DLieu.IDBieuBaoCao).ToList();
            return daTienIch.ToDataTable(lst);
        }
    }
}
