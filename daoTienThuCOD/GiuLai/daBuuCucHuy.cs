using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.GiuLai
{
    public class daBuuCucHuy:daBase
    {
        private linqBuuCucHuyDataContext lBCH = new linqBuuCucHuyDataContext();
        private sp_tblBuuCucHuy_ThongTinResult _Huy = new sp_tblBuuCucHuy_ThongTinResult();

        public sp_tblBuuCucHuy_ThongTinResult Huy { get => _Huy; set => _Huy = value; }

        public sp_tblBuuCucHuy_ThongTinResult ThongTin()
        {
            try
            {
                Huy = lBCH.sp_tblBuuCucHuy_ThongTin(MaBuuCuc, Huy.ItemCode).Single();
                return Huy;
            }
            catch
            {
                return null;
            }
        }

        public void Them()
        {
            lBCH.sp_tblBuuCucHuy_Them(Huy.Ngay, Huy.Ca, Huy.ToPOSCode, Huy.ItemCode, Huy.ServiceCode, Huy.FromPOSCode, Huy.MailTripNumber, Huy.PostBagNumber,
                Huy.PostBagTypeCode, Huy.IncomingDate, Huy.Year, Huy.BatchCode, Huy.AcceptancePOSCode, Huy.CustomerCode, Huy.SenderFullname, Huy.SenderAddress,
                Huy.SenderTel, Huy.SendingTime, Huy.ReceiverFullname, Huy.ReceiverAddress, Huy.ReceiverTel, Huy.Weight, Huy.WeightConvert, Huy.SendingContent,
                Huy.Value, Huy.LyDo, Huy.NgayHuy);
        }

        public List<sp_tblBuuCucHuy_DanhSachResult> lstDanhSach()
        {
            return lBCH.sp_tblBuuCucHuy_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public List<sp_tblBuuCucHuy_DanhSach_THopResult> lstDanhSachTHop()
        {
            return lBCH.sp_tblBuuCucHuy_DanhSach_THop(MaBuuCuc, TuNgay, DenNgay).ToList();
        }
    }
}
