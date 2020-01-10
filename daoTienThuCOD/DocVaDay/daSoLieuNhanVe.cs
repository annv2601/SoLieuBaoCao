using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using daoTienThuCOD.SoLieuDen;
using daoTienThuCOD.PhanHuongBuuTa;
using daoTienThuCOD.ChuyenHoan;
using daoTienThuCOD.Database;
using daoTienThuCOD.KeToan;
using daoSLPH.DataClient;


namespace daoTienThuCOD.DocVaDay
{
    public class daSoLieuNhanVe:daBase
    {
        public event LuuHandler Luu;
        public delegate void LuuHandler(object sender, EventArgs e);
        public event LuuXongHandler LuuXong;
        public delegate void LuuXongHandler(object sender, EventArgs e);

        private sp_tblSLDen_ThongTInResult Chuyen1DongSLDen(DataRow dr)
        {
            sp_tblSLDen_ThongTInResult ptSLD = new sp_tblSLDen_ThongTInResult();

            ptSLD.ToPOSCode = dr["ToPOSCode"].ToString();
            ptSLD.Ngay = Ngay;
            ptSLD.Ca = Ca;
            ptSLD.ItemCode = dr["ItemCode"].ToString();
            ptSLD.ServiceCode = dr["ServiceCode"].ToString();
            ptSLD.FromPOSCode = dr["FromPOSCode"] == DBNull.Value ? "" : dr["FromPOSCode"].ToString();
            ptSLD.MailTripNumber = dr["MailTripNumber"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MailTripNumber"]);
            try
            {
                ptSLD.PostBagNumber = dr["PostBagNumber"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PostBagNumber"]);
            }
            catch
            {
                ptSLD.PostBagNumber = 0;
            }
            ptSLD.PostBagTypeCode = dr["PostBagTypeCode"] == DBNull.Value ? "" : dr["PostBagTypeCode"].ToString();
            ptSLD.IncomingDate = dr["IncomingDate"] == DBNull.Value ? Ngay : Convert.ToDateTime(dr["IncomingDate"]);
            ptSLD.Year = dr["Year"].ToString();
            ptSLD.BatchCode = dr["BatchCode"] == DBNull.Value ? "" : dr["BatchCode"].ToString();
            ptSLD.AcceptancePOSCode = dr["AcceptancePOSCode"].ToString();
            ptSLD.CustomerCode = dr["CustomerCode"] == DBNull.Value ? "" : dr["CustomerCode"].ToString();
            ptSLD.SenderFullname = dr["SenderFullname"] == DBNull.Value ? "" : dr["SenderFullname"].ToString();
            ptSLD.SenderAddress = dr["SenderAddress"] == DBNull.Value ? "" : dr["SenderAddress"].ToString();
            ptSLD.SenderTel = dr["SenderTel"] == DBNull.Value ? "" : dr["SenderTel"].ToString();
            ptSLD.SendingTime = dr["SendingTime"] == DBNull.Value ? Ngay : Convert.ToDateTime(dr["SendingTime"]);
            ptSLD.ReceiverFullname = dr["ReceiverFullname"] == DBNull.Value ? "" : dr["ReceiverFullname"].ToString();
            ptSLD.ReceiverAddress = dr["ReceiverAddress"] == DBNull.Value ? "" : dr["ReceiverAddress"].ToString();
            ptSLD.ReceiverTel = dr["ReceiverTel"] == DBNull.Value ? "" : dr["ReceiverTel"].ToString();
            ptSLD.Weight = dr["Weight"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Weight"]);
            ptSLD.WeightConvert = dr["WeightConvert"] == DBNull.Value ? 0 : Convert.ToDouble(dr["WeightConvert"]);
            ptSLD.SendingContent = dr["SendingContent"] == DBNull.Value ? "" : dr["SendingContent"].ToString();
            ptSLD.Value = dr["Value"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Value"]);

            return ptSLD;

        }

        private sp_tblPhanBuuTa_ThongTinResult Chuyen1DongPhanBuuTa(DataRow dr)
        {
            sp_tblPhanBuuTa_ThongTinResult ptPBT = new sp_tblPhanBuuTa_ThongTinResult(); ;

            ptPBT.Ngay = Ngay;
            ptPBT.Ca = Ca;
            ptPBT.FromPoscode = dr["FromPoscode"].ToString();
            ptPBT.ItemCode = dr["ItemCode"].ToString();
            ptPBT.ServiceCode = dr["ServiceCode"].ToString();
            ptPBT.ToPoscode = dr["ToPOSCode"].ToString();
            ptPBT.MailTripNumber = dr["MailTripNumber"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MailTripNumber"]);
            try
            {
                ptPBT.PostBagNumber = dr["PostBagNumber"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PostBagNumber"]);
            }
            catch
            {
                ptPBT.PostBagNumber = 0;
            }
            ptPBT.PostBagTypeCode = dr["PostBagTypeCode"] == DBNull.Value ? "" : dr["PostBagTypeCode"].ToString();
            ptPBT.IncomingDate = dr["IncomingDate"] == DBNull.Value ? Ngay : Convert.ToDateTime(dr["IncomingDate"]);
            ptPBT.Year = dr["Year"].ToString();
            ptPBT.PostmanCode = dr["PostmanCode"] == DBNull.Value ? "" : dr["PostmanCode"].ToString();
            ptPBT.FullName = dr["FullName"] == DBNull.Value ? "" : dr["FullName"].ToString();
            ptPBT.DeliverRouteName = dr["DeliverRouteName"] == DBNull.Value ? "" : dr["DeliverRouteName"].ToString();
            ptPBT.ReceiverFullname = dr["ReceiverFullname"] == DBNull.Value ? "" : dr["ReceiverFullname"].ToString();
            ptPBT.ReceiverAddress = dr["ReceiverAddress"] == DBNull.Value ? "" : dr["ReceiverAddress"].ToString();
            ptPBT.ReceiverTel = dr["ReceiverTel"] == DBNull.Value ? "" : dr["ReceiverTel"].ToString();
            ptPBT.Weight = dr["Weight"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Weight"]);
            ptPBT.WeightConvert = dr["WeightConvert"] == DBNull.Value ? 0 : Convert.ToDouble(dr["WeightConvert"]);
            ptPBT.SendingContent = dr["SendingContent"] == DBNull.Value ? "" : dr["SendingContent"].ToString();
            ptPBT.Value = dr["Value"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Value"]);
            ptPBT.MaBuuTa = MaBuuCuc + ptPBT.PostmanCode;

            return ptPBT;
        }

        private sp_tblChuyenHoan_ThongTinResult Chuyen1DongChuyenHoan(DataRow dr)
        {
            sp_tblChuyenHoan_ThongTinResult ptCHoan = new sp_tblChuyenHoan_ThongTinResult();

            ptCHoan.Ngay = Ngay;
            ptCHoan.Ca = Ca;
            ptCHoan.MaBuuCuc = MaBuuCuc;
            ptCHoan.ItemCode = dr["SoHieu"].ToString();
            ptCHoan.ReceiverFullname = dr["TenNguoiNhan"] == DBNull.Value ? "" : dr["TenNguoiNhan"].ToString();
            ptCHoan.ReceiverAddress = dr["DiaChiNguoiNhan"] == DBNull.Value ? "" : dr["DiaChiNguoiNhan"].ToString();
            ptCHoan.ReceiverTel = dr["ReceiverTel"] == DBNull.Value ? "" : dr["ReceiverTel"].ToString();
            ptCHoan.Weight = dr["Weight"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Weight"]);
            ptCHoan.SoTienCOD = dr["Value"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Value"]);
            ptCHoan.TongCuoc = dr["TongCuoc"] == DBNull.Value ? 0 : Convert.ToDouble(dr["TongCuoc"]);
            ptCHoan.VAT = dr["VAT"] == DBNull.Value ? 0 : Convert.ToDouble(dr["VAT"]);
            ptCHoan.ThanhTien = dr["ThanhTien"] == DBNull.Value ? 0 : Convert.ToDouble(dr["ThanhTien"]);
            ptCHoan.LyDo = dr["LyDo"] == DBNull.Value ? "" : dr["LyDo"].ToString();
            ptCHoan.NgayChuyenHoan = dr["NgayNhanChuyenHoan"] == DBNull.Value ? Ngay : Convert.ToDateTime(dr["NgayNhanChuyenHoan"]);

            return ptCHoan;
        }

        private sp_tblChuyenTiep_DanhSachResult Chuyen1DongChuyenTiep(DataRow dr)
        {
            sp_tblChuyenTiep_DanhSachResult ptCTiep = new sp_tblChuyenTiep_DanhSachResult();

            ptCTiep.Ngay = Ngay;
            ptCTiep.Ca = Ca;
            ptCTiep.MaBuuCuc = MaBuuCuc;
            ptCTiep.ItemCode = dr["SoHieu"].ToString();
            ptCTiep.ReceiverFullname = dr["TenNguoiNhan"] == DBNull.Value ? "" : dr["TenNguoiNhan"].ToString();
            ptCTiep.ReceiverAddress = dr["DiaChiNguoiNhan"] == DBNull.Value ? "" : dr["DiaChiNguoiNhan"].ToString();
            ptCTiep.ReceiverTel = dr["ReceiverTel"] == DBNull.Value ? "" : dr["ReceiverTel"].ToString();
            ptCTiep.Weight = dr["Weight"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Weight"]);
            ptCTiep.SoTienCOD = dr["Value"] == DBNull.Value ? 0 : Convert.ToDouble(dr["Value"]);
            ptCTiep.TongCuoc = dr["TongCuoc"] == DBNull.Value ? 0 : Convert.ToDouble(dr["TongCuoc"]);
            ptCTiep.VAT = dr["VAT"] == DBNull.Value ? 0 : Convert.ToDouble(dr["VAT"]);
            ptCTiep.ThanhTien = dr["ThanhTien"] == DBNull.Value ? 0 : Convert.ToDouble(dr["ThanhTien"]);
            ptCTiep.LyDo = dr["LyDo"] == DBNull.Value ? "" : dr["LyDo"].ToString();
            ptCTiep.NgayChuyenHoan = dr["NgayNhanChuyenTiep"] == DBNull.Value ? Ngay : Convert.ToDateTime(dr["NgayNhanChuyenTiep"]);

            return ptCTiep;
        }

        public  void DocVaLuuSLDen()
        {
            daDocSLDen dSLD = new daDocSLDen();
            DataTable BangDL;
            dSLD.Ngay = Ngay;
            dSLD.Ca = Ca;
            BangDL = dSLD.DocDuLieuDen();
            if(BangDL.Rows.Count>0)
            {
                daSLDen dSLDen = new daSLDen();
                MaBuuCuc = dSLD.MaBuuCuc;
                dSLDen.MaBuuCuc = dSLD.MaBuuCuc;
                dSLDen.Ngay = Ngay;
                dSLDen.Ca = Ca;
                dSLDen.Xoa();
                DataRow dr;
                for (int i=0;i<BangDL.Rows.Count;i++)
                {
                    dr = BangDL.Rows[i];
                    dSLDen.BGDen = Chuyen1DongSLDen(dr);
                    dSLDen.Them();
                    Luu("Đang thực hiện kết chuyển số liệu Bưu gửi đến .......", null);
                }

                dSLDen.KetChuyenTongHop();

                LuuXong("Kết chuyển xong dữ liệu đến!", null);
            }
        }

        public void DocVaLuuPhanBuuTa()
        {
            daDocSLDen dSLD = new daDocSLDen();
            DataTable BangDL;
            dSLD.Ngay = Ngay;
            dSLD.Ca = Ca;
            BangDL = dSLD.DocDuLieuPhanBuuTa();
            if (BangDL.Rows.Count > 0)
            {
                daPhanBuuTa dPBTa = new daPhanBuuTa();
                MaBuuCuc = dSLD.MaBuuCuc;
                dPBTa.MaBuuCuc = dSLD.MaBuuCuc;
                dPBTa.Ngay = Ngay;
                dPBTa.Ca = Ca;
                dPBTa.Xoa();
                DataRow dr;
                for (int i = 0; i < BangDL.Rows.Count; i++)
                {
                    dr = BangDL.Rows[i];
                    dPBTa.BGPhat = Chuyen1DongPhanBuuTa(dr);
                    dPBTa.Them();
                    Luu("Đang thực hiện kết chuyển số liệu phân hướng Bưu tá .......", null);
                }

                //Ket chuyen
                dPBTa.KetChuyenTongHop();

                /*daKeToanBuuCuc dKTBC = new daKeToanBuuCuc();
                daKeToanBuuTa dKTBT = new daKeToanBuuTa();
                dKTBC.MaBuuCuc = MaBuuCuc;
                dKTBC.Ngay = Ngay;
                dKTBC.ketChuyen();

                dKTBT.MaBuuCuc = MaBuuCuc;
                dKTBT.Ngay = Ngay;
                dKTBT.KetChuyen();*/
                //===========
                LuuXong("Kết chuyển xong dữ liệu phân hướng co Bưu tá", null);
            }
        }

        public void DocVaLuuChuyenHoan()
        {
            daDocSLDen dSLD = new daDocSLDen();
            DataTable BangDL;
            dSLD.Ngay = Ngay;
            dSLD.Ca = Ca;
            BangDL = dSLD.DocDuLieuChuyenHoan();
            if (BangDL.Rows.Count > 0)
            {
                daChuyenHoan dCH = new daChuyenHoan();
                MaBuuCuc = dSLD.MaBuuCuc;
                dCH.MaBuuCuc = dSLD.MaBuuCuc;
                dCH.Ngay = Ngay;
                dCH.Ca = Ca;
                dCH.Xoa();
                DataRow dr;
                for (int i = 0; i < BangDL.Rows.Count; i++)
                {
                    dr = BangDL.Rows[i];
                    dCH.BGCHoan = Chuyen1DongChuyenHoan(dr);
                    dCH.Them();
                    Luu("Đang thực hiện kết chuyển số liệu chuyển hoàn .......", null);
                }
                LuuXong("Kết chuyển xong dữ liệu Chuyển hoàn!", null);
            }
        }

        public void DocVaLuuChuyenTiep()
        {
            daDocSLDen dSLD = new daDocSLDen();
            DataTable BangDL;
            dSLD.Ngay = Ngay;
            dSLD.Ca = Ca;
            BangDL = dSLD.DocDuLieuChuyenTiep();
            if (BangDL.Rows.Count > 0)
            {
                daChuyenTiep dCT = new daChuyenTiep();
                MaBuuCuc = dSLD.MaBuuCuc;
                dCT.MaBuuCuc = dSLD.MaBuuCuc;
                dCT.Ngay = Ngay;
                dCT.Ca = Ca;
                dCT.Xoa();
                DataRow dr;
                for (int i = 0; i < BangDL.Rows.Count; i++)
                {
                    dr = BangDL.Rows[i];
                    dCT.CTiep = Chuyen1DongChuyenTiep(dr);
                    dCT.Them();
                    Luu("Đang thực hiện kết chuyển số liệu chuyển Tiếp .......", null);
                }
                LuuXong("Kết chuyển xong dữ liệu Chuyển Tiếp!", null);
            }
        }
    }
}
