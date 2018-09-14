using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuLieuBCCP
{
    public class daLayBangCuoc:daThamSo
    {
        private string _MaDichVu;
        public string MaDichVu
        {
            get { return _MaDichVu; }
            set { _MaDichVu = value; }
        }

        private string _KieuDichVu;
        public string KieuDichVu
        {
            get { return _KieuDichVu; }
            set { _KieuDichVu = value; }
        }

        private daDB _db = new daDB();

        private string _QuyTacCuoc;
        public string QuyTacCuoc
        {
            get { return _QuyTacCuoc; }
            set { _QuyTacCuoc = value; }
        }

        private double _PhuPhiXangDauNT=0;
        public double PhuPhiXangDauNT
        {
            get { return _PhuPhiXangDauNT; }
            set { _PhuPhiXangDauNT = value; }
        }
                

        public string LayMaBuuCuc()
        {
            DataSet ds = new DataSet();
            _db.TaoKetNoi();            
            ds = _db.ChayThuTuc("select ConfigValue from Configuration where ConfigCode='POSCode'");

            return ds.Tables[0].Rows[0][0].ToString(); 
        }

        #region "Khac"

        public DataTable DanhSachKhachHang()
        {
            DataSet ds;
            _db.TaoKetNoi();
            ds = _db.ChayThuTuc("select distinct CustomerCode as Ma,(CustomerCode " + "+':'+" + " A.SenderFullname) as Ten,SenderFullname as TenKhong " +
                    "from Item A " +
                    "where CustomerCode is not null and CustomerCode<>'' and LEN(CustomerCode)=17 " +
                    "order by SenderFullname");
            return ds.Tables[0];
        }

        public DataTable DanhSachSoLieu_KiemTra(DateTime rNgay)
        {
            DataSet ds;
            _db.TaoKetNoi();
            ds = _db.ChayThuTuc("select A.ItemCode,isnull(B.Value,0)as Value,A.Weight,A.DestinationPOSCode " +
                        "from Item A "+
                        "left join (select * from ItemVASPropertyValue where PropertyCode='Amount') B "+
                        "on A.ItemCode=B.ItemCode "+
                        "where ServiceCode='E' and convert(nvarchar(10),SenderIssueDate,101)=convert(nvarchar(10),'"+rNgay.ToString()+"',101)");
            return ds.Tables[0];
        }

        public DataTable SoLieuPhatHanhNoiTinh(DateTime TuNgay, DateTime DenNgay, string rMaBuuCuc, string rMaKH)
        {
            DataSet ds;
            _db.TaoKetNoi();
            if (rMaKH == "")
            {
                ds = _db.ChayThuTuc("select A.ServiceCode, " +
                        "C.ServiceName, " +
                        "B.ValueAddedServiceCode, " +
                        "count(*) as SoLuong, " +
                        "sum(isnull(A.Weight,0))as TrongLuong, " +
                        "sum(round(((isnull(A.TotalFreight,0)-isnull(B.Freight,0))*1.1 ),0))as CuocChuyenPhat, " +
                        "sum(isnull(B.FreightVAT,0))as CuocCOD " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join Service C " +
                    "on A.ServiceCode=C.ServiceCode " +
                    "where DT.[Year] between '" + TuNgay.ToString("yyyyMMdd") + "' and '" + DenNgay.ToString("yyyyMMdd") + "' and A.ProvinceCode='10' and A.CountryCode is null and DT.FromPosCode='" + rMaBuuCuc + "'" +
                    "group by A.ServiceCode,C.ServiceName,B.ValueAddedServiceCode " +
                    "order by A.ServiceCode,B.ValueAddedServiceCode");
            }
            else
            {
                ds = _db.ChayThuTuc("select A.ServiceCode, " +
                        "C.ServiceName, " +
                        "B.ValueAddedServiceCode, " +
                        "count(*) as SoLuong, " +
                        "sum(isnull(A.Weight,0))as TrongLuong, " +
                        "sum(round(((isnull(A.TotalFreight,0)-isnull(B.Freight,0))*1.1 ),0))as CuocChuyenPhat, " +
                        "sum(isnull(B.FreightVAT,0))as CuocCOD " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join Service C " +
                    "on A.ServiceCode=C.ServiceCode " +
                    "where DT.[Year] between '" + TuNgay.ToString("yyyyMMdd") + "' and '" + DenNgay.ToString("yyyyMMdd") + "' and A.ProvinceCode='10' and A.CountryCode is null and DT.FromPosCode='" + rMaBuuCuc + "' and A.CustomerCode='" + rMaKH + "' " +
                    "group by A.ServiceCode,C.ServiceName,B.ValueAddedServiceCode " +
                    "order by A.ServiceCode,B.ValueAddedServiceCode");
            }
            return ds.Tables[0];
        }

        public DataTable SoLieuPhatHanhLienTinh(DateTime TuNgay, DateTime DenNgay, string rMaBuuCuc, string rMaKH)
        {
            DataSet ds;
            _db.TaoKetNoi();
            if (rMaKH == "")
            {
                ds = _db.ChayThuTuc("select A.ServiceCode, " +
                        "C.ServiceName, " +
                        "B.ValueAddedServiceCode, " +
                        "sum(isnull(A.Weight,0))as TrongLuong, " +
                        "count(*) as SoLuong, " +
                        "sum(round(((isnull(A.TotalFreight,0)-isnull(B.Freight,0))*1.1 ),0))as CuocChuyenPhat, " +
                        "sum(isnull(B.FreightVAT,0))as CuocCOD " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join Service C " +
                    "on A.ServiceCode=C.ServiceCode " +
                    "where DT.[Year] between '" + TuNgay.ToString("yyyyMMdd") + "' and '" + DenNgay.ToString("yyyyMMdd") + "' and A.ProvinceCode<>'10' and A.CountryCode is null and DT.FromPosCode='" + rMaBuuCuc + "'" +
                    "group by A.ServiceCode,C.ServiceName,B.ValueAddedServiceCode " +
                    "order by A.ServiceCode,B.ValueAddedServiceCode");
            }
            else
            {
                ds = _db.ChayThuTuc("select A.ServiceCode, " +
                        "C.ServiceName, " +
                        "B.ValueAddedServiceCode, " +
                        "sum(isnull(A.Weight,0))as TrongLuong, " +
                        "count(*) as SoLuong, " +
                        "sum(round(((isnull(A.TotalFreight,0)-isnull(B.Freight,0))*1.1 ),0))as CuocChuyenPhat, " +
                        "sum(isnull(B.FreightVAT,0))as CuocCOD " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join Service C " +
                    "on A.ServiceCode=C.ServiceCode " +
                    "where DT.[Year] between '" + TuNgay.ToString("yyyyMMdd") + "' and '" + DenNgay.ToString("yyyyMMdd") + "' and A.ProvinceCode<>'10' and A.CountryCode is null and DT.FromPosCode='" + rMaBuuCuc + "' and A.CustomerCode='" + rMaKH + "' " +
                    "group by A.ServiceCode,C.ServiceName,B.ValueAddedServiceCode " +
                    "order by A.ServiceCode,B.ValueAddedServiceCode");
            }
            return ds.Tables[0];
        }

        public DataTable SoLieuPhatHanhQuocTe(DateTime TuNgay, DateTime DenNgay, string rMaBuuCuc, string rMaKH)
        {
            DataSet ds;
            _db.TaoKetNoi();
            if (rMaKH == "")
            {
                ds = _db.ChayThuTuc("select A.ServiceCode, " +
                        "C.ServiceName, " +
                        "B.ValueAddedServiceCode, " +
                        "count(*) as SoLuong, " +
                        "sum(isnull(A.Weight,0))as TrongLuong, " +
                        "sum(round(((isnull(A.TotalFreight,0)-isnull(B.Freight,0))*1.1 ),0))as CuocChuyenPhat, " +
                        "sum(isnull(B.FreightVAT,0))as CuocCOD " +
                    "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode " +
                    "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B " +
                    "on A.ItemCode=B.ItemCode " +
                    "left join Service C " +
                    "on A.ServiceCode=C.ServiceCode " +
                    "where DT.[Year] between '" + TuNgay.ToString("yyyyMMdd") + "' and '" + DenNgay.ToString("yyyyMMdd") + "' and A.CountryCode is not null and DT.FromPosCode='" + rMaBuuCuc + "'" +
                    "group by A.ServiceCode,C.ServiceName,B.ValueAddedServiceCode " +
                    "order by A.ServiceCode,B.ValueAddedServiceCode");
            }
            else
            {
                ds = _db.ChayThuTuc("select A.ServiceCode, " +
                    "C.ServiceName, " +
                    "B.ValueAddedServiceCode, " +
                    "count(*) as SoLuong, " +
                    "sum(isnull(A.Weight,0))as TrongLuong, " +
                    "sum(round(((isnull(A.TotalFreight,0)-isnull(B.Freight,0))*1.1 ),0))as CuocChuyenPhat, " +
                    "sum(isnull(B.FreightVAT,0))as CuocCOD " +
                "from Dispatch DT inner join Item A on DT.ItemCode=A.ItemCode " +
                "left join (select * from ValueAddedServiceItem where ValueAddedServiceCode='COD')B " +
                "on A.ItemCode=B.ItemCode " +
                "left join Service C " +
                "on A.ServiceCode=C.ServiceCode " +
                "where DT.[Year] between '" + TuNgay.ToString("yyyyMMdd") + "' and '" + DenNgay.ToString("yyyyMMdd") + "' and A.CountryCode is not null and DT.FromPosCode='" + rMaBuuCuc + "' and A.CustomerCode='" + rMaKH + "' " +
                "group by A.ServiceCode,C.ServiceName,B.ValueAddedServiceCode " +
                "order by A.ServiceCode,B.ValueAddedServiceCode");
            }
            return ds.Tables[0];
        }

        #endregion
    }

}
