using System;
using System.Data;
using System.Collections.Generic;
using DuLieuBCCP;

namespace daoSLPH.DataClient
{
    public class daSoLieuPhatHanhBCCP
    {
        #region Khai bao
        private DateTime _TuNgay;
        public DateTime TuNgay
        {
            get { return _TuNgay; }
            set { _TuNgay = value; }
        }

        private DateTime _DenNgay;
        public DateTime DenNgay
        {
            get { return _DenNgay; }
            set { _DenNgay = value; }
        }

        private string _MaBuuCuc;
        public string MaBuuCuc
        {
            get { return _MaBuuCuc; }
            set { _MaBuuCuc = value; }
        }

        private string _TenBuuCuc;
        public string TenBuuCuc
        {
            get { return _TenBuuCuc; }
            set { _TenBuuCuc = value; }
        }

        private string _MaTinh;
        public string MaTinh
        {
            get { return _MaTinh; }
            set { _MaTinh = value; }
        }

        private string _MaKhachHang;
        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }

        public DataTable KetQua;
        #endregion

        public daSoLieuPhatHanhBCCP()
        {
            KetQua = TaoBang();
        }

        public daSoLieuPhatHanhBCCP(string sohieubuucuc)
        {
            KetQua = TaoBang();
        }

      
        public DataTable TaoBang()
        {
            DataTable Bang = new DataTable();

            Bang.Columns.Add("MaDichVu", typeof(string));
            Bang.Columns.Add("MaDichVuCT", typeof(string));
            Bang.Columns.Add("Ten",typeof(string));
            Bang.Columns.Add("SoLuongNT",typeof(int));
            Bang.Columns.Add("TrongNT",typeof(decimal));
            Bang.Columns.Add("CuocNT",typeof(decimal));
            Bang.Columns.Add("CuocCODNT",typeof(decimal));
            Bang.Columns.Add("SoLuongLT", typeof(int));
            Bang.Columns.Add("TrongLT", typeof(decimal));
            Bang.Columns.Add("CuocLT", typeof(decimal));
            Bang.Columns.Add("CuocCODLT", typeof(decimal));
            Bang.Columns.Add("SoLuongQT", typeof(int));
            Bang.Columns.Add("TrongQT", typeof(decimal));
            Bang.Columns.Add("CuocQT", typeof(decimal));
            Bang.Columns.Add("CuocCODQT", typeof(decimal));

            DataTable dtNT;
            //daLayBangCuoc dLay = new daLayBangCuoc();
            List<clsDichVu> lstDV = new List<clsDichVu>();
            daDichVu dDV = new daDichVu();
            lstDV = dDV.LayDanhSach("BCCP");
            string _TenDV;
            //for (int k = 0; k < dtNT.Rows.Count; k++)
            foreach(clsDichVu dv in lstDV)
            {
                _TenDV = dv.Ten.Split('-')[0].Trim();
                if (dv.Ma == "E")
                {
                    Bang.Rows.Add(dv.Ma, "", _TenDV, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    Bang.Rows.Add(dv.Ma, "COD", _TenDV + " _ COD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    Bang.Rows.Add(dv.Ma, "HT", _TenDV + " _ Hỏa Tốc", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                }
                else
                {
                    if (dv.Ma == "C" || dv.Ma == "R")
                    {
                        Bang.Rows.Add(dv.Ma, "", _TenDV, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                        Bang.Rows.Add(dv.Ma, "COD", _TenDV + " _ COD", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    }
                    else
                    {
                        Bang.Rows.Add(dv.Ma, "", _TenDV, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    }
                }
            }

            return Bang;
        }

        public void LayNoiTinh()
        {
            clsSoLieu pt;
            daDuLieuBCCP dBCCP = new daDuLieuBCCP();
            List<clsBaoCaoKeToan> lstNT;
            lstNT = dBCCP.PhatHanhNoiTinh(TuNgay);
            //daLayBangCuoc dLay = new daLayBangCuoc();
            int j;
            
            if (lstNT.Count > 0)
            {
                foreach (clsBaoCaoKeToan nt in lstNT)
                {
                    pt= new clsSoLieu();
                    pt.MaDichVu = nt.Ma;
                    pt.TenDichVu = nt.Ten;
                    pt.MaDichVuCT = "";
                    pt.SoLuong = nt.SoLuong;
                    pt.TrongLuong = pt.TrongLuong;
                    pt.Cuoc = nt.ThanhTien;
                    pt.CuocCOD = nt.ThanhTienCOD;

                    //pt.TenDichVu = pt.TenDichVu + "_" + pt.MaDichVuCT;
                    //KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT==""?"":("_" + pt.MaDichVuCT)), pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD, 0, 0, 0, 0, 0, 0, 0, 0);                    
                    j = TimTen(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT);
                    if (j == -1)
                    {
                        KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT==""?"":("_" + pt.MaDichVuCT)), pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD, 0, 0, 0, 0, 0, 0, 0, 0);                    
                    }
                    else
                    {
                        KetQua.Rows[j]["SoLuongNT"] =Convert.ToInt32(KetQua.Rows[j]["SoLuongNT"])+ pt.SoLuong;
                        KetQua.Rows[j]["TrongNT"] = Convert.ToDecimal(KetQua.Rows[j]["TrongNT"]) + pt.TrongLuong;
                        KetQua.Rows[j]["CuocNT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocNT"]) + pt.Cuoc;
                        KetQua.Rows[j]["CuocCODNT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocCODNT"]) + pt.CuocCOD;
                    }
                }
            }
        }

        public void LayLienTinh()
        {
            clsSoLieu pt;
            
            int j;
            daDuLieuBCCP dBCCP = new daDuLieuBCCP();
            List<clsBaoCaoKeToan> lstLT;
            lstLT = dBCCP.PhatHanhLienTinh(TuNgay);
            if (lstLT.Count > 0)
            {
               foreach(clsBaoCaoKeToan nt in lstLT)
                {
                    pt = new clsSoLieu();
                    pt.MaDichVu = nt.Ma;
                    pt.TenDichVu = nt.Ten;
                    pt.MaDichVuCT = "";
                    pt.SoLuong = nt.SoLuong;
                    pt.TrongLuong = pt.TrongLuong;
                    pt.Cuoc = nt.ThanhTien;
                    pt.CuocCOD = nt.ThanhTienCOD;

                    j = TimTen(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT);
                    if (j == -1)
                    {
                        KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT == null ? "" : ("_" + pt.MaDichVuCT)), 0, 0, 0, 0, pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD, 0, 0, 0, 0);
                    }
                    else
                    {
                        KetQua.Rows[j]["SoLuongLT"] = Convert.ToInt32(KetQua.Rows[j]["SoLuongLT"]) + pt.SoLuong;
                        KetQua.Rows[j]["TrongLT"] = Convert.ToDecimal(KetQua.Rows[j]["TrongLT"]) + pt.TrongLuong;
                        KetQua.Rows[j]["CuocLT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocLT"]) + pt.Cuoc;
                        KetQua.Rows[j]["CuocCODLT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocCODLT"]) + pt.CuocCOD;
                    }
                }
            }
        }

        public void LayQuocTe()
        {
            clsSoLieu pt;
           
            int j;
            daDuLieuBCCP dBCCP = new daDuLieuBCCP();
            List<clsBaoCaoKeToan> lstQT;
            lstQT = dBCCP.PhatHanhQuocTe(TuNgay);
            if (lstQT.Count > 0)
            {
                foreach(clsBaoCaoKeToan nt in lstQT)
                {
                    pt = new clsSoLieu();
                    pt.MaDichVu = nt.Ma;
                    pt.TenDichVu = nt.Ten;
                    pt.MaDichVuCT = "";
                    pt.SoLuong = nt.SoLuong;
                    pt.TrongLuong = pt.TrongLuong;
                    pt.Cuoc = nt.ThanhTien;
                    pt.CuocCOD = nt.ThanhTienCOD;

                    j = TimTen(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT);
                    if (j == -1)
                    {
                        KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT == null ? "" : ("_" + pt.MaDichVuCT)), 0, 0, 0, 0, 0, 0, 0, 0, pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD);
                    }
                    else
                    {
                        KetQua.Rows[j]["SoLuongQT"] = pt.SoLuong;
                        KetQua.Rows[j]["TrongQT"] = pt.TrongLuong;
                        KetQua.Rows[j]["CuocQT"] = pt.Cuoc;
                        KetQua.Rows[j]["CuocCODQT"] = pt.CuocCOD;
                    }
                }
            }
        }

        /*public void LayNoiTinhTong()
        {
            clsSoLieu pt;
            DataTable dtNT;
            //daLayBangCuoc dLay = new daLayBangCuoc();
            int j;
            dLay.MaTinh = MaTinh;            
            dtNT = dLay.SoLieuPhatHanhNoiTinhTong(TuNgay, DenNgay, MaBuuCuc, MaKhachHang);
            if (dtNT.Rows.Count > 0)
            {
                for (int k = 0; k < dtNT.Rows.Count; k++)
                {
                    pt = new clsSoLieu();
                    pt.MaDichVu = dtNT.Rows[k]["ServiceCode"].ToString();
                    pt.TenDichVu = dtNT.Rows[k]["ServiceName"].ToString();
                    pt.MaDichVuCT = "";
                    pt.SoLuong = Convert.ToInt32(dtNT.Rows[k]["SoLuong"]);
                    pt.TrongLuong = Convert.ToDecimal(dtNT.Rows[k]["TrongLuong"]);
                    pt.Cuoc = Convert.ToDecimal(dtNT.Rows[k]["CuocChuyenPhat"]);
                    pt.CuocCOD = Convert.ToDecimal(dtNT.Rows[k]["CuocCOD"]);

                    //pt.TenDichVu = pt.TenDichVu + "_" + pt.MaDichVuCT;
                    //KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT == "" ? "" : ("_" + pt.MaDichVuCT)), pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD, 0, 0, 0, 0, 0, 0, 0, 0);
                    j = TimTen(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT);
                    if (j == -1)
                    {
                        KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT == null ? "" : ("_" + pt.MaDichVuCT)), pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD, 0, 0, 0, 0, 0, 0, 0, 0);
                    }
                    else
                    {
                        KetQua.Rows[j]["SoLuongNT"] = Convert.ToInt32(KetQua.Rows[j]["SoLuongNT"]) + pt.SoLuong;
                        KetQua.Rows[j]["TrongNT"] = Convert.ToDecimal(KetQua.Rows[j]["TrongNT"]) + pt.TrongLuong;
                        KetQua.Rows[j]["CuocNT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocNT"]) + pt.Cuoc;
                        KetQua.Rows[j]["CuocCODNT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocCODNT"]) + pt.CuocCOD;
                    }
                }
            }
        }

        public void LayLienTinhTong()
        {
            clsSoLieu pt;
            DataTable dtNT;
            //daLayBangCuoc dLay = new daLayBangCuoc();
            int j;
            dLay.MaTinh = MaTinh;
            dtNT = dLay.SoLieuPhatHanhLienTinh(TuNgay, DenNgay, MaBuuCuc, MaKhachHang);
            if (dtNT.Rows.Count > 0)
            {
                for (int k = 0; k < dtNT.Rows.Count; k++)
                {
                    pt = new clsSoLieu();
                    pt.MaDichVu = dtNT.Rows[k]["ServiceCode"].ToString();
                    pt.TenDichVu = dtNT.Rows[k]["ServiceName"].ToString();
                    pt.MaDichVuCT = "";
                    pt.SoLuong = Convert.ToInt32(dtNT.Rows[k]["SoLuong"]);
                    pt.TrongLuong = Convert.ToDecimal(dtNT.Rows[k]["TrongLuong"]);
                    pt.Cuoc = Convert.ToDecimal(dtNT.Rows[k]["CuocChuyenPhat"]);
                    pt.CuocCOD = Convert.ToDecimal(dtNT.Rows[k]["CuocCOD"]);

                    j = TimTen(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT);
                    if (j == -1)
                    {
                        KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT == null ? "" : ("_" + pt.MaDichVuCT)), 0, 0, 0, 0, pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD, 0, 0, 0, 0);
                    }
                    else
                    {
                        KetQua.Rows[j]["SoLuongLT"] =Convert.ToInt32(KetQua.Rows[j]["SoLuongLT"])+pt.SoLuong;
                        KetQua.Rows[j]["TrongLT"] = Convert.ToDecimal(KetQua.Rows[j]["TrongLT"]) + pt.TrongLuong;
                        KetQua.Rows[j]["CuocLT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocLT"]) + pt.Cuoc;
                        KetQua.Rows[j]["CuocCODLT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocCODLT"]) + pt.CuocCOD;
                    }
                }
            }
        }

        public void LayQuocTeTong()
        {
            clsSoLieu pt;
            DataTable dtNT;
            //daLayBangCuoc dLay = new daLayBangCuoc();
            int j;
            dLay.MaTinh = MaTinh;
            dtNT = dLay.SoLieuPhatHanhQuocTeTong(TuNgay, DenNgay, MaBuuCuc, MaKhachHang);
            if (dtNT.Rows.Count > 0)
            {
                for (int k = 0; k < dtNT.Rows.Count; k++)
                {
                    pt = new clsSoLieu();
                    pt.MaDichVu = dtNT.Rows[k]["ServiceCode"].ToString();
                    pt.TenDichVu = dtNT.Rows[k]["ServiceName"].ToString();
                    pt.MaDichVuCT = "";
                    pt.SoLuong = Convert.ToInt32(dtNT.Rows[k]["SoLuong"]);
                    pt.TrongLuong = Convert.ToDecimal(dtNT.Rows[k]["TrongLuong"]);
                    pt.Cuoc = Convert.ToDecimal(dtNT.Rows[k]["CuocChuyenPhat"]);
                    pt.CuocCOD = Convert.ToDecimal(dtNT.Rows[k]["CuocCOD"]);

                    j = TimTen(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT);
                    if (j == -1)
                    {
                        KetQua.Rows.Add(pt.MaDichVu, pt.MaDichVuCT == null ? "" : pt.MaDichVuCT, pt.TenDichVu + (pt.MaDichVuCT == null ? "" : ("_" + pt.MaDichVuCT)), 0, 0, 0, 0, 0, 0, 0, 0, pt.SoLuong, pt.TrongLuong, pt.Cuoc, pt.CuocCOD);
                    }
                    else
                    {
                        KetQua.Rows[j]["SoLuongQT"] = Convert.ToInt32(KetQua.Rows[j]["SoLuongQT"]) + pt.SoLuong;
                        KetQua.Rows[j]["TrongQT"] = Convert.ToDecimal(KetQua.Rows[j]["TrongQT"]) + pt.TrongLuong;
                        KetQua.Rows[j]["CuocQT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocQT"]) + pt.Cuoc;
                        KetQua.Rows[j]["CuocCODQT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocCODQT"]) + pt.CuocCOD;
                    }
                }
            }
        }*/

        public void TinhTong()
        {
            try
            {
                KetQua.Columns.Add("SoLuongT", typeof(int));
                KetQua.Columns.Add("TrongT", typeof(decimal));
                KetQua.Columns.Add("CuocT", typeof(decimal));
                KetQua.Columns.Add("CuocCODT", typeof(decimal));
            }
            catch { }

            //Tinh tong so
            for (int j = 0; j < KetQua.Rows.Count; j++)
            {
                KetQua.Rows[j]["SoLuongT"] = Convert.ToInt32(KetQua.Rows[j]["SoLuongNT"]) + Convert.ToInt32(KetQua.Rows[j]["SoLuongLT"]) + Convert.ToInt32(KetQua.Rows[j]["SoLuongQT"]);
                KetQua.Rows[j]["TrongT"] = Convert.ToDecimal(KetQua.Rows[j]["TrongNT"]) + Convert.ToDecimal(KetQua.Rows[j]["TrongLT"]) + Convert.ToDecimal(KetQua.Rows[j]["TrongQT"]);
                KetQua.Rows[j]["CuocT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocNT"]) + Convert.ToDecimal(KetQua.Rows[j]["CuocLT"]) + Convert.ToDecimal(KetQua.Rows[j]["CuocQT"]);
                KetQua.Rows[j]["CuocCODT"] = Convert.ToDecimal(KetQua.Rows[j]["CuocCODNT"]) + Convert.ToDecimal(KetQua.Rows[j]["CuocCODLT"]) + Convert.ToDecimal(KetQua.Rows[j]["CuocCODQT"]);
            }
        }

        public int TimTen(string MaDichVu, string MaDichVuCT)
        {
            int kq = -1;
            for (int i = 0; i < KetQua.Rows.Count; i++)
            {
                if (MaDichVu == KetQua.Rows[i]["MaDichVu"].ToString() && MaDichVuCT==KetQua.Rows[i]["MaDichVuCT"].ToString())
                {
                    kq = i;
                    break;
                }
            }
            return kq;
        }
    }

    public class clsSoLieu
    {
        private string _MaDichVu;
        public string MaDichVu
        {
            get { return _MaDichVu; }
            set { _MaDichVu = value; }
        }

        private string _TenDichVu;
        public string TenDichVu
        {
            get { return _TenDichVu; }
            set { _TenDichVu = value; }
        }

        private string _MaDichVuCT;
        public string MaDichVuCT
        {
            get { return _MaDichVuCT; }
            set { _MaDichVuCT = value; }
        }

        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private decimal _TrongLuong;
        public decimal TrongLuong
        {
            get { return _TrongLuong; }
            set { _TrongLuong = value; }
        }

        private decimal _Cuoc;
        public decimal Cuoc
        {
            get { return _Cuoc; }
            set { _Cuoc = value; }
        }

        private decimal _CuocCOD;
        public decimal CuocCOD
        {
            get { return _CuocCOD; }
            set { _CuocCOD = value; }
        }
    }
}
