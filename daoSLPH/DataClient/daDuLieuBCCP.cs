using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using daoSLPH.Database;
using LiteDB;

namespace daoSLPH.DataClient
{
    public class daDuLieuBCCP
    {
        private const string MaTinh = "100000";
        private daClient dCli = new daClient();
        public daDuLieuBCCP()
        {
            dCli.Tao();
        }
        public void Them(clsDuLieuBCCP ptBCCP)
        {
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                col.Insert(ptBCCP);
                col.EnsureIndex(x => x.ID);
            }
        }

        public void Them(List<clsDuLieuBCCP> lstBCCP)
        {
            int i = 1;
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                foreach (clsDuLieuBCCP pt in lstBCCP)
                {
                    pt.ID = i;
                    pt.DaTruyen = false;
                    col.Insert(pt);
                    i = i + 1;
                }
                col.EnsureIndex(x => x.ID);
            }
        }

        public void CapNhat(clsDuLieuBCCP ptBCCP)
        {
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                col.Update(ptBCCP.ID, ptBCCP);
            }
        }

        public List<clsDuLieuBCCP> LayDanhSachChuaTruyen()
        {
            List<clsDuLieuBCCP> lstBCCP = new List<clsDuLieuBCCP>();
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                lstBCCP = col.Find(x => x.DaTruyen == false).ToList();
            }

            return lstBCCP;
        }

        public void Xoa(string rMaBC)
        {
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                col.Delete(x=>x.MaBuuCuc==rMaBC);
                db.Shrink();
            }
        }

        #region Bao cao
        public DataTable BaoCaoNgay(DateTime rNgay)
        {
            //Dich vu
            List<clsDichVu> lstDV = new List<clsDichVu>();
            daDichVu dDV = new daDichVu();
            lstDV = dDV.LayDanhSach("BCCP");
            //===========
            List<clsBaoCaoKeToanTien> lst=new List<clsBaoCaoKeToanTien>();
            List<clsDuLieuBCCP> lstTM;
            List<clsDuLieuBCCP> lstGN;
            clsBaoCaoKeToanTien cBCKTT;
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                foreach(clsDichVu pDV in lstDV)
                {
                    lstTM = col.Find(tm => tm.GhiNo == false && tm.NgayPhatHanh.Value.ToShortDateString() == rNgay.ToShortDateString() && tm.MaDichVu == pDV.Ma).ToList();
                    lstGN = col.Find(tm => tm.GhiNo == true && tm.NgayPhatHanh.Value.ToShortDateString() == rNgay.ToShortDateString() && tm.MaDichVu == pDV.Ma).ToList();

                    cBCKTT = new clsBaoCaoKeToanTien();
                    cBCKTT.Ma = pDV.Ma;
                    cBCKTT.Ten = pDV.Ten;

                    cBCKTT.SoLuong = lstTM.Count;
                    cBCKTT.KhoiLuong = lstTM.Sum(x => x.TrongLuongQuiDoi.Value);
                    cBCKTT.TongCuoc = lstTM.Sum(x => x.TongCuoc.Value);
                    cBCKTT.CuocCOD = lstTM.Sum(x => x.CuocCOD.Value);
                    cBCKTT.VAT = lstTM.Sum(x => x.VAT.Value);
                    cBCKTT.ThanhTien = lstTM.Sum(x => x.ThanhTien.Value);
                    cBCKTT.ThanhTienCOD = lstTM.Sum(x => x.CuocCODVAT.Value);

                    cBCKTT.SoLuongGNo = lstGN.Count;
                    cBCKTT.KhoiLuongGNo = lstGN.Sum(x => x.TrongLuongQuiDoi.Value);
                    cBCKTT.TongCuocGNo = lstGN.Sum(x => x.TongCuoc.Value);
                    cBCKTT.CuocCODGNo = lstGN.Sum(x => x.CuocCOD.Value);
                    cBCKTT.VATGNo = lstGN.Sum(x => x.VAT.Value);
                    cBCKTT.ThanhTienGNo = lstGN.Sum(x => x.ThanhTien.Value);
                    cBCKTT.ThanhTienCODGNo = lstGN.Sum(x => x.CuocCODVAT.Value);

                    lst.Add(cBCKTT);
                }
            }

            return daTienIch.ToDataTable(lst);
        }

        public List<clsBaoCaoKeToan> PhatHanhNoiTinh(DateTime rNgay)
        {
            //Dich vu
            List<clsDichVu> lstDV = new List<clsDichVu>();
            daDichVu dDV = new daDichVu();
            lstDV = dDV.LayDanhSach("BCCP");
            List<clsBaoCaoKeToan> lst = new List<clsBaoCaoKeToan>();
            clsBaoCaoKeToan pt;
            List<clsDuLieuBCCP> lstNT;
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                foreach (clsDichVu pDV in lstDV)
                {
                    lstNT = col.Find(tm => tm.NgayPhatHanh.Value.ToShortDateString() == rNgay.ToShortDateString() && tm.MaNuocPhat == null && tm.MaTinhPhat == MaTinh && tm.MaDichVu == pDV.Ma).ToList();

                    pt = new clsBaoCaoKeToan();
                    pt.Ma = pDV.Ma;
                    pt.Ten = pDV.Ten;

                    pt.SoLuong = lstNT.Count;
                    pt.KhoiLuong = lstNT.Sum(x => x.TrongLuongQuiDoi.Value);
                    pt.TongCuoc = lstNT.Sum(x => x.TongCuoc.Value);
                    pt.CuocCOD = lstNT.Sum(x => x.CuocCOD.Value);
                    pt.VAT = lstNT.Sum(x => x.VAT.Value);
                    pt.ThanhTien = lstNT.Sum(x => x.ThanhTien.Value);
                    pt.ThanhTienCOD = lstNT.Sum(x => x.CuocCODVAT.Value);
                    lst.Add(pt);
                }
            }

            return lst;
        }

        public List<clsBaoCaoKeToan> PhatHanhLienTinh(DateTime rNgay)
        {
            //Dich vu
            List<clsDichVu> lstDV = new List<clsDichVu>();
            daDichVu dDV = new daDichVu();
            lstDV = dDV.LayDanhSach("BCCP");
            List<clsBaoCaoKeToan> lst = new List<clsBaoCaoKeToan>();
            clsBaoCaoKeToan pt;
            List<clsDuLieuBCCP> lstNT;
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                foreach (clsDichVu pDV in lstDV)
                {
                    lstNT = col.Find(tm => tm.NgayPhatHanh.Value.ToShortDateString() == rNgay.ToShortDateString() && tm.MaNuocPhat == null && tm.MaTinhPhat != MaTinh && tm.MaDichVu == pDV.Ma).ToList();

                    pt = new clsBaoCaoKeToan();
                    pt.Ma = pDV.Ma;
                    pt.Ten = pDV.Ten;

                    pt.SoLuong = lstNT.Count;
                    pt.KhoiLuong = lstNT.Sum(x => x.TrongLuongQuiDoi.Value);
                    pt.TongCuoc = lstNT.Sum(x => x.TongCuoc.Value);
                    pt.CuocCOD = lstNT.Sum(x => x.CuocCOD.Value);
                    pt.VAT = lstNT.Sum(x => x.VAT.Value);
                    pt.ThanhTien = lstNT.Sum(x => x.ThanhTien.Value);
                    pt.ThanhTienCOD = lstNT.Sum(x => x.CuocCODVAT.Value);
                    lst.Add(pt);
                }
            }

            return lst;
        }

        public List<clsBaoCaoKeToan> PhatHanhQuocTe(DateTime rNgay)
        {
            //Dich vu
            List<clsDichVu> lstDV = new List<clsDichVu>();
            daDichVu dDV = new daDichVu();
            lstDV = dDV.LayDanhSach("BCCP");
            List<clsBaoCaoKeToan> lst = new List<clsBaoCaoKeToan>();
            clsBaoCaoKeToan pt;
            List<clsDuLieuBCCP> lstNT;
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                foreach (clsDichVu pDV in lstDV)
                {
                    lstNT = col.Find(tm => tm.NgayPhatHanh.Value.ToShortDateString() == rNgay.ToShortDateString() && tm.MaNuocPhat != null && tm.MaDichVu == pDV.Ma).ToList();

                    pt = new clsBaoCaoKeToan();
                    pt.Ma = pDV.Ma;
                    pt.Ten = pDV.Ten;

                    pt.SoLuong = lstNT.Count;
                    pt.KhoiLuong = lstNT.Sum(x => x.TrongLuongQuiDoi.Value);
                    pt.TongCuoc = lstNT.Sum(x => x.TongCuoc.Value);
                    pt.CuocCOD = lstNT.Sum(x => x.CuocCOD.Value);
                    pt.VAT = lstNT.Sum(x => x.VAT.Value);
                    pt.ThanhTien = lstNT.Sum(x => x.ThanhTien.Value);
                    pt.ThanhTienCOD = lstNT.Sum(x => x.CuocCODVAT.Value);
                    lst.Add(pt);
                }
            }

            return lst;
        }
        #endregion
    }

    public class clsDuLieuBCCP:sp_tblPhatHanhBCCP_ThongTinResult
    {
        private int _ID;

        private bool _DaTruyen;

        public int ID { get => _ID; set => _ID = value; }
        public bool DaTruyen { get => _DaTruyen; set => _DaTruyen = value; }
    }

    public class clsBaoCaoKeToan
    {
        private string _Ma;

        private string _ThuTu;

        private string _Ten;

        private int _SoLuong;

        private decimal _KhoiLuong;

        private decimal _TongCuoc;

        private decimal _CuocCOD;

        private decimal _VAT;

        private decimal _ThanhTien;

        private decimal _ThanhTienCOD;

        private bool _No;

        public string ThuTu { get => _ThuTu; set => _ThuTu = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public decimal KhoiLuong { get => _KhoiLuong; set => _KhoiLuong = value; }
        public decimal TongCuoc { get => _TongCuoc; set => _TongCuoc = value; }
        public decimal CuocCOD { get => _CuocCOD; set => _CuocCOD = value; }
        public decimal VAT { get => _VAT; set => _VAT = value; }
        public decimal ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public decimal ThanhTienCOD { get => _ThanhTienCOD; set => _ThanhTienCOD = value; }
        public bool No { get => _No; set => _No = value; }
        public string Ma { get => _Ma; set => _Ma = value; }
    }

    public class clsBaoCaoKeToanTien:clsBaoCaoKeToan
    {
        private int _SoLuongGNo;

        private decimal _KhoiLuongGNo;

        private decimal _TongCuocGNo;

        private decimal _CuocCODGNo;

        private decimal _VATGNo;

        private decimal _ThanhTienGNo;

        private decimal _ThanhTienCODGNo;

        public int SoLuongGNo { get => _SoLuongGNo; set => _SoLuongGNo = value; }
        public decimal KhoiLuongGNo { get => _KhoiLuongGNo; set => _KhoiLuongGNo = value; }
        public decimal TongCuocGNo { get => _TongCuocGNo; set => _TongCuocGNo = value; }
        public decimal CuocCODGNo { get => _CuocCODGNo; set => _CuocCODGNo = value; }
        public decimal VATGNo { get => _VATGNo; set => _VATGNo = value; }
        public decimal ThanhTienGNo { get => _ThanhTienGNo; set => _ThanhTienGNo = value; }
        public decimal ThanhTienCODGNo { get => _ThanhTienCODGNo; set => _ThanhTienCODGNo = value; }
    }
}
