using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.GiuLai
{
    public class daBuuCucLuuGiu:daBase
    {
        private linqBuuCucLuuGiuDataContext lBCL = new linqBuuCucLuuGiuDataContext();
        private sp_tblBuuCucGiuLai_ThongTinResult _Luu = new sp_tblBuuCucGiuLai_ThongTinResult();

        public sp_tblBuuCucGiuLai_ThongTinResult Luu { get => _Luu; set => _Luu = value; }

        public sp_tblBuuCucGiuLai_ThongTinResult ThongTin()
        {
            try
            {
                Luu = lBCL.sp_tblBuuCucGiuLai_ThongTin(MaBuuCuc, Luu.ItemCode).Single();
                return Luu;
            }
            catch
            {
                return null;
            }
        }

        public void Xoa()
        {
            lBCL.sp_tblBuuCucGiuLai_Xoa(MaBuuCuc, Luu.ItemCode, Ngay);
        }

        public void Them()
        {
            lBCL.sp_tblBuuCucGiuLai_Them(Luu.Ngay,
            Luu.FromPoscode,
            Luu.ItemCode,
            Luu.ServiceCode,
            Luu.ToPoscode,
            Luu.MailTripNumber,
            Luu.PostBagNumber,
            Luu.PostBagTypeCode,
            Luu.IncomingDate,
            Luu.Year,
            Luu.PostmanCode,
            Luu.FullName,
            Luu.DeliverRouteName,
            Luu.ReceiverFullname,
            Luu.ReceiverAddress,
            Luu.ReceiverTel,
            Luu.Weight,
            Luu.WeightConvert,
            Luu.SendingContent,
            Luu.Value,
            Luu.MaBuuTa);
        }

        public List<sp_tblBuuCucGiuLai_DanhSachResult> lstDanhSach()
        {
            return lBCL.sp_tblBuuCucGiuLai_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public List<sp_tblBuuCucGiuLai_DanhSach_THopResult> lstDanhSachTHop()
        {
            return lBCL.sp_tblBuuCucGiuLai_DanhSach_THop(MaBuuCuc, TuNgay, DenNgay).ToList();
        }

        public List<sp_tblBuuCucGiuLai_DanhSachResult> lstDanhSachBuuTa()
        {
            List<sp_tblBuuCucGiuLai_DanhSach_BuuTaResult> lst;
            lst = lBCL.sp_tblBuuCucGiuLai_DanhSach_BuuTa(MaBuuCuc, MaBuuTa, TuNgay, DenNgay).ToList();
            AutoMapper.Mapper.CreateMap<sp_tblBuuCucGiuLai_DanhSach_BuuTaResult, sp_tblBuuCucGiuLai_DanhSachResult>();

            return AutoMapper.Mapper.Map<List<sp_tblBuuCucGiuLai_DanhSachResult>>(lst);
        }

        public List<sp_tblSLDen_DanhSachResult> lstChuaPhanBuuTa()
        {
            List<sp_tblSLDen_DanhSachResult> lst = new List<sp_tblSLDen_DanhSachResult>();
            sp_tblSLDen_DanhSachResult c;
            foreach (sp_tblBuuCucGiuLai_DanhSach_ChuaPhanBuuTaResult pt in lBCL.sp_tblBuuCucGiuLai_DanhSach_ChuaPhanBuuTa(MaBuuCuc,Ngay).ToList())
            {
                c = new sp_tblSLDen_DanhSachResult();
                c.Ngay = pt.Ngay;
                c.Ca = 0;
                c.ToPOSCode = pt.PostmanCode;
                c.ItemCode = pt.ItemCode;
                c.ServiceCode = pt.ServiceCode;
                c.FromPOSCode = pt.FromPoscode;
                c.MailTripNumber = pt.MailTripNumber;
                c.PostBagNumber = pt.PostBagNumber;
                c.PostBagTypeCode = pt.PostBagTypeCode;
                c.IncomingDate = pt.IncomingDate;
                c.Year = pt.Year;
                c.BatchCode = "";
                c.AcceptancePOSCode = "";
                c.CustomerCode = "";
                c.SenderFullname = "";
                c.SenderAddress = "";
                c.SenderTel = "";
                c.SendingTime = pt.IncomingDate;
                c.ReceiverFullname = pt.ReceiverFullname;
                c.ReceiverAddress = pt.ReceiverAddress;
                c.ReceiverTel = pt.ReceiverTel;
                c.Weight = pt.Weight;
                c.WeightConvert = pt.WeightConvert;
                c.SendingContent = pt.SendingContent;
                c.Value = pt.Value;
                c.DaPhat = pt.DaPhat;
                c.DaChuyenHoan = pt.DaChuyenHoan;
                c.DaHuy = false;
                c.LyDo = "";
                c.NgayHuy = DateTime.MinValue;

                lst.Add(c);
            }

            return lst;
        }
    }
}
