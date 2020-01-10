using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.GiuLai
{
    public class daBuuTaGiuLai:daBase
    {
        private linqBuuTaGiuLaiDataContext lBTG = new linqBuuTaGiuLaiDataContext();
        private sp_tblBuuTaGiuLai_ThongTinResult _Giu = new sp_tblBuuTaGiuLai_ThongTinResult();

        public sp_tblBuuTaGiuLai_ThongTinResult Giu { get => _Giu; set => _Giu = value; }

        public sp_tblBuuTaGiuLai_ThongTinResult ThongTin()
        {
            try
            {
                Giu = lBTG.sp_tblBuuTaGiuLai_ThongTin(MaBuuCuc, Giu.ItemCode).Single();
                return Giu;
            }
            catch
            {
                return null;
            }
        }

        public void Xoa()
        {
            lBTG.sp_tblBuuTaGiuLai_Xoa(MaBuuCuc, Giu.ItemCode, Ngay);
        }

        public void Them()
        {
            lBTG.sp_tblBuuTaGiuLai_Them(Giu.Ngay,
                Giu.FromPoscode,
                Giu.ItemCode,
                Giu.ServiceCode,
                Giu.ToPoscode,
                Giu.MailTripNumber,
                Giu.PostBagNumber,
                Giu.PostBagTypeCode,
                Giu.IncomingDate,
                Giu.Year,
                Giu.PostmanCode,
                Giu.FullName,
                Giu.DeliverRouteName,
                Giu.ReceiverFullname,
                Giu.ReceiverAddress,
                Giu.ReceiverTel,
                Giu.Weight,
                Giu.WeightConvert,
                Giu.SendingContent,
                Giu.Value,
                Giu.MaBuuTa);
        }

        public List<sp_tblBuuTaGiuLai_DanhSachResult> lstDanhSach()
        {
            return lBTG.sp_tblBuuTaGiuLai_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public List<sp_tblBuuTaTraLai_DanhSachResult> lstDanhSachTra()
        {
            return lBTG.sp_tblBuuTaTraLai_DanhSach(MaBuuCuc, MaBuuTa, TuNgay, DenNgay).ToList();
        }
    }
}
