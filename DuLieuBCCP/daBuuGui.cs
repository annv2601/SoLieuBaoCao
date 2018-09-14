using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DuLieuBCCP
{
    public class daBuuGui:daThamSo
    {
        private daDB db =new daDB();
        public string FileConfigBCCP="";
        #region "So lieu phat hanh"
        public DataTable DanhSachBuuGui()
        {
            //Lay tat ca so lieu cua mot buu cuc
            //db.ChuoiKetNoi = ChuoiKetNoi;
            //db.TaoKetNoi();
            db.TaoKetNoi(FileConfigBCCP);
            DataSet ds;
            ds = db.ChayThuTuc("select DT.ItemCode SoHieu, isnull(A.SendingContent,'') NoiDungBuuGui, DT.ServiceCode MaDichVu, A.ItemTypeCode as LoaiBuuGui,A.AcceptancePOSCode as MaBCChapNhan,SendingTime as NgayGioNhan,DT.ToPOSCode as BuuCucNhanCT, DT.MailTripNumber SoChuyen, DT.PostBagIndex SoTui,DT.FromPOSCode MaDuongThu, " +
                    "A.Weight TrongLuong, isnull(A.WeightConvert,0) TrongLuongQuiDoi,A.ProvinceCode+'0000' MaTinhPhat,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, '' DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode  " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B  " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C " +
                    "on A.ItemCode=C.ItemCode " +
                    "where A.BatchCode is null and DT.Year='" + Ngay.ToString("yyyyMMdd") + "' and DT.FromPOSCode='" + SoHieuBuuCuc + "' " +
                        " and A.SendingTime between '" + Ngay.AddDays(-1).ToString("MM/dd/yyyy") + " 14:00:00' and '" + Ngay.ToString("MM/dd/yyyy") + " 23:59:00'" +
                    " order by ToPOSCode,DT.MailTripNumber,DT.PostBagIndex,DT.IndexNumber");
            DataTable dt = ds.Tables[0];

            ds = new DataSet();
            ds = db.ChayThuTuc("select A.BatchCode SoHieu, isnull(A.SendingContent,'') NoiDungBuuGui, DT.ServiceCode MaDichVu, A.ItemTypeCode as LoaiBuuGui,A.AcceptancePOSCode as MaBCChapNhan,A.SendingTime as NgayGioNhan,DT.ToPOSCode as BuuCucNhanCT, DT.MailTripNumber SoChuyen, 0 SoTui,DT.FromPOSCode MaDuongThu, " +
                    "sum(A.Weight) TrongLuong, sum(isnull(A.WeightConvert,0)) TrongLuongQuiDoi,A.ProvinceCode+'0000' MaTinhPhat,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, CAST(COUNT(*)as nvarchar(5)) DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode  " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B  " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C " +
                    "on A.ItemCode=C.ItemCode " +
                    "where A.BatchCode is not null and DT.Year='" + Ngay.ToString("yyyyMMdd") + "' and DT.FromPOSCode='" + SoHieuBuuCuc + "' " +
                        " and A.SendingTime between '" + Ngay.AddDays(-1).ToString("MM/dd/yyyy") + " 14:00:00' and '" + Ngay.ToString("MM/dd/yyyy") + " 23:59:00'" +
                    "group by A.BatchCode,isnull(A.SendingContent,''), DT.ServiceCode, DT.MailTripNumber,DT.FromPOSCode,A.ProvinceCode+'0000',A.CountryCode,A.CustomerCode, A.SenderFullname, B.FreightVAT, " +
                    "A.SenderAddress,A.ReceiverFullname, A.ReceiverAddress, A.MainFreight, A.FuelSurchargeFreight,A.ItemTypeCode,A.AcceptancePOSCode,A.SendingTime,DT.ToPOSCode, " +
                    "A.FarRegionFreight, (isnull(A.SubFreight,0)-isnull(B.Freight,0)), (isnull(A.TotalFreight,0)-isnull(B.Freight,0)),A.VATFreight,A.TotalFreightVAT, C.Value, B.Freight, A.IsDebt " +
                    " order by DT.MailTripNumber");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.ImportRow(ds.Tables[0].Rows[i]);
            }
            return dt;
        }

        public DataTable DanhSachBuuGui_TheoDichVu()
        {
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select DT.ItemCode SoHieu, isnull(A.SendingContent,'') NoiDungBuuGui, DT.ServiceCode MaDichVu, DT.MailTripNumber SoChuyen, DT.PostBagIndex SoTui,DT.FromPOSCode MaDuongThu, " +
                    "A.Weight TrongLuong, isnull(A.WeightConvert,0) TrongLuongQuiDoi,A.ProvinceCode+'0000' MaTinhPhat,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, '' DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode  " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B  " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C " +
                    "on A.ItemCode=C.ItemCode " +
                    "where A.BatchCode is null and DT.ServiceCode='" + MaDichVu + "' and DT.Year='" + Ngay.ToString("yyyyMMdd") + "' and DT.FromPOSCode='" + SoHieuBuuCuc + "' " +
                    " order by ToPOSCode,DT.MailTripNumber,DT.PostBagIndex,DT.IndexNumber");
            DataTable dt = ds.Tables[0];

            ds = new DataSet();
            ds = db.ChayThuTuc("select A.BatchCode SoHieu, isnull(A.SendingContent,'') NoiDungBuuGui, DT.ServiceCode MaDichVu, DT.MailTripNumber SoChuyen, 0 SoTui,DT.FromPOSCode MaDuongThu, " +
                    "sum(A.Weight) TrongLuong, sum(isnull(A.WeightConvert,0)) TrongLuongQuiDoi,A.ProvinceCode+'0000' MaTinhPhat,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, CAST(COUNT(*)as nvarchar(5)) DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode  " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B  " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C " +
                    "on A.ItemCode=C.ItemCode " +
                    "where A.BatchCode is not null and DT.ServiceCode='" + MaDichVu + "' and DT.Year='" + Ngay.ToString("yyyyMMdd") + "' and DT.FromPOSCode='" + SoHieuBuuCuc + "' " +
                    "group by A.BatchCode,isnull(A.SendingContent,''), DT.ServiceCode, DT.MailTripNumber,DT.FromPOSCode,A.ProvinceCode+'0000',A.CountryCode,A.CustomerCode, A.SenderFullname, B.FreightVAT, " +
                    "A.SenderAddress,A.ReceiverFullname, A.ReceiverAddress, A.MainFreight, A.FuelSurchargeFreight, "+
                    "A.FarRegionFreight, (isnull(A.SubFreight,0)-isnull(B.Freight,0)), (isnull(A.TotalFreight,0)-isnull(B.Freight,0)),A.VATFreight,A.TotalFreightVAT, C.Value, B.Freight, A.IsDebt "+
                    " order by DT.MailTripNumber");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.ImportRow(ds.Tables[0].Rows[i]);
            }
            return dt;
        }

        public DataTable DanhSachBuuGui_TheoDichVu_Luu()
        {
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select DT.ItemCode SoHieu, A.SendingContent NoiDungBuuGui, DT.ServiceCode MaDichVu, DT.MailTripNumber SoChuyen, DT.PostBagIndex SoTui,DT.FromPOSCode MaDuongThu, " +
                    "A.Weight TrongLuong, isnull(A.WeightConvert,0) TrongLuongQuiDoi,A.POSCode MaTinhPhat,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, '' DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, A.IsDebt as No, convert(bit,1,101) as Chon " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode  " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B  " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C " +
                    "on A.ItemCode=C.ItemCode " +
                    "where DT.ServiceCode='" + MaDichVu + "' and DT.Year='" + Ngay.ToString("yyyyMMdd") + "' and DT.FromPOSCode='" + SoHieuBuuCuc + "' " +
                    " order by ToPOSCode,DT.MailTripNumber,DT.PostBagIndex,DT.IndexNumber");
            DataTable dt = ds.Tables[0];

            return dt;
        }
        #endregion

        #region "So lieu den"
        public DataTable DanhSachBuuGui_Den()
        {
            //Lay tat ca so lieu cua mot buu cuc
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("Select DT.Year as NgayDoiSoat,DT.ItemCode SoHieu, A.ServiceCode MaDichVu, DT.MailTripNumber SoChuyen, DT.PostBagIndex SoTui,DT.FromPOSCode MaDuongThu, DT.ToPOSCode as MaBuuCucNhap, " +
                    "A.Weight TrongLuong, isnull(A.WeightConvert,0) TrongLuongQuiDoi,A.POSCode MaBuuCucChapNhan,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, '' DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon, 1 TrangThai, Tui.LastUpdatedTime NgayTrangThai " +
                    "from MailtripTransportPostBag TuiDen " +
                    "inner join PostBag Tui " +
                    "on TuiDen.PostBagIndex = Tui.PostBagIndex AND TuiDen.FromPOSCode = Tui.FromPOSCode AND TuiDen.ToPOSCode = Tui.ToPOSCode AND TuiDen.MailtripType = tui.MailTripType AND TuiDen.ServiceCode = Tui.ServiceCode AND TuiDen.Year = Tui.Year AND TuiDen.MailTripNumber = Tui.MailTripNumber " +
                    "inner join Dispatch DT  " +
                    "on Tui.ServiceCode=DT.ServiceCode and Tui.MailTripNumber=DT.MailTripNumber and Tui.PostBagNumber=DT.PostBagIndex and Tui.FromPOSCode=DT.FromPOSCode and Tui.ToPOSCode=DT.ToPOSCode AND DT.MailtripType = tui.MailTripType " +
                    "inner join Item A  " +
                    "on DT.ItemCode=A.ItemCode   " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B   " +
                    "on DT.ItemCode=B.ItemCode  " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C  " +
                    "on DT.ItemCode=C.ItemCode  " +
                    "where TuiDen.ToPOSCode='" + SoHieuBuuCuc + "' and TuiDen.BC37Date='"+Ngay.ToString("yyyyMMdd")+"' " +
                    " order by DT.ToPOSCode,DT.MailTripNumber,DT.PostBagIndex,DT.IndexNumber");
            /*ds = db.ChayThuTuc("Select DT.Year as NgayDoiSoat,DT.ItemCode SoHieu, A.ServiceCode MaDichVu, DT.MailTripNumber SoChuyen, DT.PostBagIndex SoTui,DT.FromPOSCode MaDuongThu, DT.ToPOSCode as MaBuuCucNhap, " +
                    "A.Weight TrongLuong, isnull(A.WeightConvert,0) TrongLuongQuiDoi,A.POSCode MaBuuCucChapNhan,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, '' DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon, 1 TrangThai, Tui.LastUpdatedTime NgayTrangThai " +
                    "from PostBag Tui " +
                    "inner join Dispatch DT  " +
                    "on Tui.ServiceCode=DT.ServiceCode and Tui.MailTripNumber=DT.MailTripNumber and Tui.PostBagNumber=DT.PostBagIndex " +
                    "inner join Item A  " +
                    "on DT.ItemCode=A.ItemCode   " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B   " +
                    "on DT.ItemCode=B.ItemCode  " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C  " +
                    "on DT.ItemCode=C.ItemCode  " +
                    "where Tui.ToPOSCode='" + SoHieuBuuCuc + "' and Tui.[Status]=4 and " +
	                    "year(Tui.LastUpdatedTime)="+Ngay.Year.ToString()+" and month(Tui.LastUpdatedTime)="+Ngay.Month.ToString()+" and day(Tui.LastUpdatedTime)="+Ngay.Day.ToString() +
                    " order by DT.ToPOSCode,DT.MailTripNumber,DT.PostBagIndex,DT.IndexNumber");*/
            /*ds = db.ChayThuTuc("select DT.Year as NgayDoiSoat,DT.ItemCode SoHieu, A.ServiceCode MaDichVu, DT.MailTripNumber SoChuyen, DT.PostBagIndex SoTui,DT.FromPOSCode MaDuongThu, DT.ToPOSCode as MaBuuCucNhap, " +
                    "A.Weight TrongLuong, isnull(A.WeightConvert,0) TrongLuongQuiDoi,A.POSCode MaBuuCucChapNhan,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, '' DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon, 1 TrangThai, convert(datetime,DT.Year,101) NgayTrangThai " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode  " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B  " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C " +
                    "on A.ItemCode=C.ItemCode " +
                    "where DT.Year between '" + TuNgay.ToString("yyyyMMdd") + "' and '" + DenNgay.ToString("yyyyMMdd") + "' and DT.ToPOSCode='" + SoHieuBuuCuc + "' " +
                    " order by ToPOSCode,DT.MailTripNumber,DT.PostBagIndex,DT.IndexNumber");*/
            DataTable dt = ds.Tables[0];
            return dt;
            /*ds = new DataSet();
            ds = db.ChayThuTuc("select A.BatchCode SoHieu, A.ServiceCode MaDichVu, DT.MailTripNumber SoChuyen, 0 SoTui,DT.FromPOSCode MaDuongThu, DT.ToPOSCode as MaBuuCucNhap, " +
                    "sum(A.Weight) TrongLuong, sum(isnull(A.WeightConvert,0)) TrongLuongQuiDoi,A.POSCode MaBuuCucChapNhan,A.CountryCode MaNuocPhat,A.CustomerCode MaKhachHang, A.SenderFullname TenKhachHang, " +
                    "A.SenderAddress DiaChiKhachHang,A.ReceiverFullname TenNguoiNhan, A.ReceiverAddress DiaChiNguoiNhan, A.MainFreight CuocChinh, A.FuelSurchargeFreight PhuPhiXD, " +
                    "A.FarRegionFreight PhuPhiVX, (isnull(A.SubFreight,0)-isnull(B.Freight,0)) as CuocCongThem, CAST(COUNT(*)as nvarchar(5)) DichVuCongThem, (isnull(A.TotalFreight,0)-isnull(B.Freight,0)) as TongCuoc,A.VATFreight as VAT,A.TotalFreightVAT as ThanhTien, C.Value SoTienCOD, B.Freight CuocCOD, B.FreightVAT CuocCODVAT, A.IsDebt as No, convert(bit,1,101) as Chon " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode  " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B  " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join (select * from ItemVASPropertyValue where PropertyCode='Amount' and ValueAddedServiceCode='COD') C " +
                    "on A.ItemCode=C.ItemCode " +
                    "where A.BatchCode is not null and DT.Year='" + Ngay.ToString("yyyyMMdd") + "' and DT.ToPOSCode='" + SoHieuBuuCuc + "' " +
                    "group by A.BatchCode, A.ServiceCode, DT.MailTripNumber,DT.FromPOSCode,A.POSCode,A.CountryCode,A.CustomerCode, A.SenderFullname, B.FreightVAT, " +
                    "A.SenderAddress,A.ReceiverFullname, A.ReceiverAddress, A.MainFreight, A.FuelSurchargeFreight, " +
                    "A.FarRegionFreight, (isnull(A.SubFreight,0)-isnull(B.Freight,0)), (isnull(A.TotalFreight,0)-isnull(B.Freight,0)),A.VATFreight,A.TotalFreightVAT, C.Value, B.Freight, A.IsDebt " +
                    " order by DT.MailTripNumber");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.ImportRow(ds.Tables[0].Rows[i]);
            }
            return dt;*/
        }

        public DataTable DanhSachBuuGui_PhanHuongBuuTa()
        {
            //Lay tat ca so lieu cua mot buu cuc
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select convert(datetime,A.Year,101) as NgayDong,A.ItemCode as SoHieu,A.MailTripNumber as SoChuyen,A.PostBagIndex SoTui, A.ToPosCode as MaDuongThu, " +
                                    "A.DeliveryRouteCode as MaDuongThuPhat, C.FullName as TenBuuTa, A.FromPOSCode as MaBuuCucNhap,A.Year as NgayDoiSoat " +
                                "from Dispatch A " +
                                "left join PostmanDeliveryRoute B " +
                                "on A.ToPOSCode=B.PostmanCode and A.DeliveryRouteCode=B.DelieveryRouteCode " +
                                "left join [User] C " +
                                "on B.PostmanCode=C.Username  "+
                                "where A.FromPOSCode='" + SoHieuBuuCuc + "' and A.[Year] = '" + Ngay.ToString("yyyyMMdd") + "'");
                                //"where A.DeliveryRouteCode<>'' and A.FromPOSCode='" + SoHieuBuuCuc + "' and A.[Year] = '" + Ngay.ToString("yyyyMMdd") + "'");
            return ds.Tables[0];
        }

        public DataTable DanhSachBuuGui_ChuyenHoan()
        {
            //Lay tat ca so lieu cua mot buu cuc
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select ReturnDate as NgayDoiSoat, ItemCode as SoHieu,Reason as LyDo, ReturnDate as NgayNhanChuyenHoan, " +
	                    "ReceiverFullname TenNguoiNhan, ReceiverAddress DiaChiNguoiNhan, "+
                        "MainFreight as CuocChinh, FuelSurchargeFreight as PhuPhiXD,Freight TongCuoc,  VATFreight VAT,FreightVAT ThanhTien, POSCode as MaBuuCucNhap " +
                    "from ItemReturn "+
                    "where ReturnDate between '" + TuNgay.ToString("MM/dd/yyyy") + "' and '" + DenNgay.AddDays(1).ToString("MM/dd/yyyy") + "'");
            return ds.Tables[0];
        }

        public DataTable DanhSachBuuGui_TrangThai_PhatThanhCong()
        {
            //Lay tat ca so lieu cua mot buu cuc
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select DeliveryDate as NgayDoiSoat, ItemCode as SoHieu, DeliveryDate as NgayGioPhat,DeliveryNote GhiChu, " +
	                    "RealReciverName NguoiKyNhan, InputDate as NgayGioNhap, InputingUser NguoiNhap, ToPosCode as MaBuuCucNhap "+
                    "from Delivery "+
                    "where IsDeliverable=1 and DeliveryDate between '" + TuNgay.ToString("MM/dd/yyyy") + "' and '" + DenNgay.AddDays(1).ToString("MM/dd/yyyy") + "'");
            return ds.Tables[0];
        }

        public DataTable DanhSachBuuGui_ChuyenTiep()
        {
            //Lay tat ca so lieu cua mot buu cuc
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select ForwardDate as NgayDoiSoat, ItemCode as SoHieu, Reason LyDo, ForwardDate as NgayGioChuyenTiep, " +
                        "ReceiverFullname TenNguoiNhan, ReceiverAddress DiaChiNguoiNhan, ProvinceCode MaTinh, POSCode MaBuuCuc, ForwardPOSCode MaBuuCucNhap, " +
                        "ReceiverFullnameOld TenNguoiNhanCu, ReceiverAddressOld DiaChiNguoiNhanCu, POSCodeOld MaBuuCucCu " +
                    "from ItemForward " +
                    "where ForwardDate between '" + TuNgay.ToString("MM/dd/yyyy") + "' and '" + DenNgay.AddDays(1).ToString("MM/dd/yyyy") + "'");
            return ds.Tables[0];
        }
        #endregion
    }
}
