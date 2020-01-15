using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoKeToanSoDu.Database;

namespace daoKeToanSoDu.Bieu02TQ
{
    public class daBieu02TQ
    {
        public enum eLoaiBaoCao
        {
            B02TQ=1
        }

        private linqBieu02TQDataContext lB02 = new linqBieu02TQDataContext();
        private sp_tblBieuBaoCao02TQ_ThongTinResult _B02 = new sp_tblBieuBaoCao02TQ_ThongTinResult();
        private daBieu02TQDuLieu _DuLieu = new daBieu02TQDuLieu();

        public sp_tblBieuBaoCao02TQ_ThongTinResult B02 { get => _B02; set => _B02 = value; }
        public daBieu02TQDuLieu DuLieu { get => _DuLieu; set => _DuLieu = value; }

        public sp_tblBieuBaoCao02TQ_ThongTinResult ThongTin()
        {
            try
            {
                B02 = lB02.sp_tblBieuBaoCao02TQ_ThongTin(B02.Ngay, B02.MaDonVi).Single();
                return B02;
            }
            catch
            {
                return null;
            }
        }

        public int Them()
        {
            B02.ID = Convert.ToInt32(lB02.sp_tblBieuBaoCao02TQ_Them(B02.Ngay, B02.MaDonVi, B02.LoaiBaoCao, B02.TieuDeBaoCao).Single().IDThem02TQ);
            return B02.ID;
        }

        public void KhoaMo()
        {
            lB02.sp_tblBieuBaoCao02TQ_KhoaMo(B02.ID, B02.DaKhoa, B02.NguoiKhoa);
        }
    }
}
