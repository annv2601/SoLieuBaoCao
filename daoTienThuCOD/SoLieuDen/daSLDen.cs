using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.SoLieuDen
{
    public class daSLDen:daBase
    {       

        private linqSLDenDataContext lSLDen = new linqSLDenDataContext();
        private sp_tblSLDen_ThongTInResult _BGDen = new sp_tblSLDen_ThongTInResult();

        public sp_tblSLDen_ThongTInResult BGDen { get => _BGDen; set => _BGDen = value; }

        public sp_tblSLDen_ThongTInResult ThongTin()
        {
            try
            {
                BGDen = lSLDen.sp_tblSLDen_ThongTIn(BGDen.ToPOSCode, BGDen.ItemCode).Single();
                return BGDen;
            }
            catch
            {
                return null;
            }
        }

        public void Xoa()
        {
            lSLDen.sp_tblSLDen_Xoa(MaBuuCuc, Ngay, Ca);
        }

        public void Huy()
        {
            lSLDen.sp_tblSLDen_Huy(BGDen.ToPOSCode, BGDen.ItemCode, BGDen.LyDo);
        }

        public void Them()
        {
            lSLDen.sp_tblSLDen_Them(
                    BGDen.ToPOSCode,
                    BGDen.Ngay,
                    BGDen.Ca,
                    BGDen.ItemCode,
                    BGDen.ServiceCode,
                    BGDen.FromPOSCode,
                    BGDen.MailTripNumber,
                    BGDen.PostBagNumber,
                    BGDen.PostBagTypeCode,
                    BGDen.IncomingDate,
                    BGDen.Year,
                    BGDen.BatchCode,
                    BGDen.AcceptancePOSCode,
                    BGDen.CustomerCode,
                    BGDen.SenderFullname,
                    BGDen.SenderAddress,
                    BGDen.SenderTel,
                    BGDen.SendingTime,
                    BGDen.ReceiverFullname,
                    BGDen.ReceiverAddress,
                    BGDen.ReceiverTel,
                    BGDen.Weight,
                    BGDen.WeightConvert,
                    BGDen.SendingContent,
                    BGDen.Value);

            
        }

        public void KetChuyenTongHop()
        {
            lSLDen.sp_tblSLDenTHop_TongHop(MaBuuCuc, Ngay);
        }

        public DataTable DanhSach()
        {
            List<sp_tblSLDen_DanhSachResult> lst;
            lst = lSLDen.sp_tblSLDen_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSach_THop()
        {
            List<sp_tblSLDen_DanhSach_THopResult> lst;
            lst = lSLDen.sp_tblSLDen_DanhSach_THop(MaBuuCuc, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblSLDen_DanhSach_THopResult> lstDanhSach_THop()
        {
            List<sp_tblSLDen_DanhSach_THopResult> lst;
            lst = lSLDen.sp_tblSLDen_DanhSach_THop(MaBuuCuc, TuNgay, DenNgay).ToList();
            return lst;
        }

        public DataTable DanhSach_ChuyenThu()
        {
            List<sp_tblSLDen_DanhSach_ChuyenThuResult> lst;
            lst = lSLDen.sp_tblSLDen_DanhSach_ChuyenThu(BGDen.ToPOSCode, BGDen.Ngay, BGDen.MailTripNumber,BGDen.PostBagNumber,BGDen.FromPOSCode,BGDen.ServiceCode).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblSLDen_DanhSachResult> lstDanhSach_ChuyenThu()
        {
            List<sp_tblSLDen_DanhSach_ChuyenThuResult> lst;
            lst = lSLDen.sp_tblSLDen_DanhSach_ChuyenThu(BGDen.ToPOSCode, BGDen.Ngay, BGDen.MailTripNumber, BGDen.PostBagNumber, BGDen.FromPOSCode, BGDen.ServiceCode).ToList();
            AutoMapper.Mapper.CreateMap<sp_tblSLDen_DanhSach_ChuyenThuResult, sp_tblSLDen_DanhSachResult>();

            return AutoMapper.Mapper.Map<List<sp_tblSLDen_DanhSachResult>>(lst);
        }

        public List<sp_tblSLDen_DanhSachResult> lstChuaPhanBuuTa()
        {
            List<sp_tblSLDen_ChuaPhanBuuTaResult> lst;
            lst = lSLDen.sp_tblSLDen_ChuaPhanBuuTa(MaBuuCuc, Ngay).ToList();
            AutoMapper.Mapper.CreateMap<sp_tblSLDen_ChuaPhanBuuTaResult, sp_tblSLDen_DanhSachResult>();

            return AutoMapper.Mapper.Map<List<sp_tblSLDen_DanhSachResult>>(lst);
        }
    }

    public class clsBuuGuiPhat:sp_tblSLDen_ThongTInResult
    {
        private DateTime _NgayPhat;

        private DateTime _NgayChuyenHoan;

        private DateTime _NgayPhanBuuTa;

        private string _MaBuuTa;

        private string _TenBuuTa;

        public DateTime NgayPhat { get => _NgayPhat; set => _NgayPhat = value; }
        public DateTime NgayChuyenHoan { get => _NgayChuyenHoan; set => _NgayChuyenHoan = value; }
        public DateTime NgayPhanBuuTa { get => _NgayPhanBuuTa; set => _NgayPhanBuuTa = value; }
        public string MaBuuTa { get => _MaBuuTa; set => _MaBuuTa = value; }
        public string TenBuuTa { get => _TenBuuTa; set => _TenBuuTa = value; }
    }
}
