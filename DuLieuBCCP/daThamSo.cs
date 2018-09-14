using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuLieuBCCP
{
    public class daThamSo
    {
        private string _ChuoiKetNoi;
        public string ChuoiKetNoi
        {
            get { return _ChuoiKetNoi; }
            set { _ChuoiKetNoi = value; }
        }

        private string _SoHieuBuuCuc;
        public string SoHieuBuuCuc
        {
            get { return _SoHieuBuuCuc; }
            set { _SoHieuBuuCuc = value; }
        }

        private DateTime _Ngay;
        public DateTime Ngay
        {
            get { return _Ngay; }
            set { _Ngay = value; }
        }

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

        private string _MaKhachHang;
        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }

        private string _MaDichVu;
        public string MaDichVu
        {
            get { return _MaDichVu; }
            set { _MaDichVu = value; }
        }

        private string _MaDuongThu;
        public string MaDuongThu
        {
            get { return _MaDuongThu; }
            set { _MaDuongThu = value; }
        }

        private int _SoChuyen;
        public int SoChuyen
        {
            get { return _SoChuyen; }
            set { _SoChuyen = value; }
        }

        private int _SoTui;
        public int SoTui
        {
            get { return _SoTui; }
            set { _SoTui = value; }
        }

        private string _MaTui;
        public string MaTui
        {
            get { return _MaTui; }
            set { _MaTui = value; }
        }
    }
}
