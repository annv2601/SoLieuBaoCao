using System;

namespace daoSLBC.Core
{
    public class daBase
    {
        public daBase()
        {
        }

        private string maDonVi;

        private byte thang;

        private int nam;

        private DateTime ngay;

        private byte _TuThang;

        private byte _DenThang;

        private DateTime _TuNgay;

        private DateTime _DenNgay;


        public string MaDonVi { get => maDonVi; set => maDonVi = value; }
        public byte Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public byte TuThang { get => _TuThang; set => _TuThang = value; }
        public byte DenThang { get => _DenThang; set => _DenThang = value; }
        public DateTime TuNgay { get => _TuNgay; set => _TuNgay = value; }
        public DateTime DenNgay { get => _DenNgay; set => _DenNgay = value; }
    }
}
