using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daoSLTH.Untilities
{
    public class daBase
    {
        private DateTime _Ngay;

        private DateTime _TuNgay;

        private DateTime _DenNgay;

        private byte _Thang;

        private int _Nam;

        private string _MaDonVi;

        private string _MaBuuCuc;

        private string _MaDoiSoat;

        public DateTime Ngay { get => _Ngay; set => _Ngay = value; }
        public DateTime TuNgay { get => _TuNgay; set => _TuNgay = value; }
        public DateTime DenNgay { get => _DenNgay; set => _DenNgay = value; }
        public byte Thang { get => _Thang; set => _Thang = value; }
        public int Nam { get => _Nam; set => _Nam = value; }
        public string MaDonVi { get => _MaDonVi; set => _MaDonVi = value; }
        public string MaDoiSoat { get => _MaDoiSoat; set => _MaDoiSoat = value; }
        public string MaBuuCuc { get => _MaBuuCuc; set => _MaBuuCuc = value; }
    }
}
