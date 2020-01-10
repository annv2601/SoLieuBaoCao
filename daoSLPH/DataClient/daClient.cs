using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LiteDB;

namespace daoSLPH.DataClient
{
    public class daClient
    {
        public daClient()
        {

        }

        private const string ThuMucDuLieu = "DataClient\\LayTuDong";

        private const string FileCauHinh = "CauHinh.db";
        private const string FileLanLay = "LogLay.db";
        private const string FileDuLieuPP = "DuLieuPayPost.db";
        private const string FileDuLieuBCCP = "DuLieuBCCP.db";
        private const string FileDichVu = "DichVu.db";
        private const string FileDanhMucNVPP = "DanhMucNVPP.db";
        private const string FileDuLieuBCCPDen = "DuLieuBCCPDen.db";

        private string _TenThuMuc;

        private string _TenFileCauHinh;

        private string _TenFileLogLay;

        private string _TenFileDuLieuPP;

        private string _TenFileDuLieuBCCP;

        private string _TenFileDichVu;

        private string _TenFileNVPP;

        private string _TenFileDuLieuBCCPDen;

        public string TenThuMuc { get => _TenThuMuc; set => _TenThuMuc = value; }
        public string TenFileCauHinh { get => _TenFileCauHinh; set => _TenFileCauHinh = value; }
        public string TenFileDuLieuPP { get => _TenFileDuLieuPP; set => _TenFileDuLieuPP = value; }
        public string TenFileLogLay { get => _TenFileLogLay; set => _TenFileLogLay = value; }
        public string TenFileDuLieuBCCP { get => _TenFileDuLieuBCCP; set => _TenFileDuLieuBCCP = value; }
        public string TenFileDichVu { get => _TenFileDichVu; set => _TenFileDichVu = value; }
        public string TenFileNVPP { get => _TenFileNVPP; set => _TenFileNVPP = value; }
        public string TenFileDuLieuBCCPDen { get => _TenFileDuLieuBCCPDen; set => _TenFileDuLieuBCCPDen = value; }

        public string BangCauHinh = "CauHinh";
        public string BangLanLay = "LanLay";
        public string BangDuLieuPP = "DuLieuPP";
        public string BangDuLieuBCCP = "DuLieuBCCP";
        public string BangDichVu = "DichVu";
        public string BangDanhMuc = "DanhMuc";
        public string BangDanhMucDVi = "DanhMucDVi";
        public string BangDanhMucND = "DanhMucND";

        public string BangSLDen = "SoLieuDen";
        public string BangPhanBuuTa = "PhanBuuTa";
        public string BangChuyenHoan = "ChuyenHoan";

        private void KhoiTaoThuMuc()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\" + ThuMucDuLieu);
            if (!di.Exists)
            {
                di.Create();
            }

            TenThuMuc = di.FullName;
        }

        public void Tao()
        {
            KhoiTaoThuMuc();

            TenFileCauHinh = TaoFile(FileCauHinh);

            TenFileLogLay = TaoFile(FileLanLay);

            TenFileDuLieuPP = TaoFile(FileDuLieuPP);

            TenFileDuLieuBCCP = TaoFile(FileDuLieuBCCP);

            TenFileDichVu = TaoFile(FileDichVu);

            TenFileNVPP = TaoFile(FileDanhMucNVPP);

            TenFileDuLieuBCCPDen = TaoFile(FileDuLieuBCCPDen);
        }

        private string TaoFile(string rTenFile)
        {
            string _kq;
            _kq = TenThuMuc + "\\" + rTenFile;
            var db = new LiteDatabase(_kq);
            return _kq;
        }

        public void XoaFile(string rTenFile)
        {
            FileInfo fi = new FileInfo(rTenFile);
            if(fi.Exists)
            {
                fi.Delete();
            }
        }
    }

    public class bCauHinh
    {
        private int _ID;

        private string _Ma;

        private string _GiaTri;

        public int ID { get => _ID; set => _ID = value; }
        public string Ma { get => _Ma; set => _Ma = value; }
        public string GiaTri { get => _GiaTri; set => _GiaTri = value; }
    }
}

