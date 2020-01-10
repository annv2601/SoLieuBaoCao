using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.PhanHuongBuuTa
{
    public class daPhanBuuTa:daBase
    {

        private linqPhanHuongBuuTaDataContext lPHBTa = new linqPhanHuongBuuTaDataContext();
        private sp_tblPhanBuuTa_ThongTinResult _BGPhat = new sp_tblPhanBuuTa_ThongTinResult();

        public sp_tblPhanBuuTa_ThongTinResult BGPhat { get => _BGPhat; set => _BGPhat = value; }

        public sp_tblPhanBuuTa_ThongTinResult ThongTin()
        {
            try
            {
                BGPhat = lPHBTa.sp_tblPhanBuuTa_ThongTin(BGPhat.ToPoscode, BGPhat.ItemCode).Single();
                return BGPhat;
            }
            catch
            {
                return null;
            }
        }

        public void Xoa()
        {
            lPHBTa.sp_tblPhanBuuTa_Xoa(MaBuuCuc, Ngay, Ca);
        }

        public void Them()
        {
            lPHBTa.sp_tblPhanBuuTa_Them(BGPhat.Ngay,
                BGPhat.Ca,
                BGPhat.FromPoscode,
                BGPhat.ItemCode,
                BGPhat.ServiceCode,
                BGPhat.ToPoscode,
                BGPhat.MailTripNumber,
                BGPhat.PostBagNumber,
                BGPhat.PostBagTypeCode,
                BGPhat.IncomingDate,
                BGPhat.Year,
                BGPhat.PostmanCode,
                BGPhat.FullName,
                BGPhat.DeliverRouteName,
                BGPhat.ReceiverFullname,
                BGPhat.ReceiverAddress,
                BGPhat.ReceiverTel,
                BGPhat.Weight,
                BGPhat.WeightConvert,
                BGPhat.SendingContent,
                BGPhat.Value,
                BGPhat.MaBuuTa);
        }

        public void KetChuyenTongHop()
        {
            lPHBTa.sp_tblPhanBuuTaTHop_TongHop(MaBuuCuc, Ngay);
        }

        public DataTable DanhSach()
        {
            List<sp_tblPhanBuuTa_DanhSachResult> lst;
            lst = lPHBTa.sp_tblPhanBuuTa_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSach__THop()
        {
            List<sp_tblPhanBuuTa_DanhSach_THopResult> lst;
            lst = lPHBTa.sp_tblPhanBuuTa_DanhSach_THop(MaBuuCuc, TuNgay, DenNgay).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblPhanBuuTa_DanhSach_THopResult> lstDanhSach__THop()
        {
            List<sp_tblPhanBuuTa_DanhSach_THopResult> lst;
            lst = lPHBTa.sp_tblPhanBuuTa_DanhSach_THop(MaBuuCuc, TuNgay, DenNgay).ToList();
            return lst;
        }

        public DataTable DanhSach_BuuTa()
        {
            List<sp_tblPhanBuuTa_DanhSach_BuuTaResult> lst;
            lst = lPHBTa.sp_tblPhanBuuTa_DanhSach_BuuTa(BGPhat.FromPoscode, BGPhat.Ngay, BGPhat.Ca, BGPhat.ToPoscode).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblPhanBuuTa_DanhSach_BuuTaResult> lstDanhSach_BuuTa()
        {
            List<sp_tblPhanBuuTa_DanhSach_BuuTaResult> lst;
            lst = lPHBTa.sp_tblPhanBuuTa_DanhSach_BuuTa(BGPhat.FromPoscode, BGPhat.Ngay, BGPhat.Ca, BGPhat.ToPoscode).ToList();
            return lst;
        }

        public DataTable DanhSach_ChuyenThu()
        {
            List<sp_tblPhanBuuTa_DanhSach_ChuyenThuResult> lst;
            lst = lPHBTa.sp_tblPhanBuuTa_DanhSach_ChuyenThu(BGPhat.FromPoscode, BGPhat.Ngay, BGPhat.ToPoscode,BGPhat.ServiceCode,BGPhat.MailTripNumber,BGPhat.PostBagNumber).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public List<sp_tblPhanBuuTa_DanhSach_BuuTaResult> lstDanhSach_ChuyenThu()
        {
            List<sp_tblPhanBuuTa_DanhSach_ChuyenThuResult> lst;
            lst = lPHBTa.sp_tblPhanBuuTa_DanhSach_ChuyenThu(BGPhat.FromPoscode, BGPhat.Ngay, BGPhat.ToPoscode,BGPhat.ServiceCode,BGPhat.MailTripNumber,BGPhat.PostBagNumber).ToList();
            AutoMapper.Mapper.CreateMap<sp_tblPhanBuuTa_DanhSach_ChuyenThuResult, sp_tblPhanBuuTa_DanhSach_BuuTaResult>();

            return AutoMapper.Mapper.Map<List<sp_tblPhanBuuTa_DanhSach_BuuTaResult>>(lst);
        }
    }
}
