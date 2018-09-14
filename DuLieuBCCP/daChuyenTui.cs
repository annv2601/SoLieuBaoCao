using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuLieuBCCP
{
    public class daChuyenTui:daThamSo
    {
        private daDB db = new daDB();

        public DataTable DanhSachChuyenTrongNgay()
        {
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select MailtripNumber as ChuyenSo "+
                    "from Mailtrip "+
                    "where StartingCode='"+SoHieuBuuCuc+"' and DestinationCode='"+MaDuongThu+"' and ServiceCode='"+MaDichVu+"' and [Year]='"+Ngay.ToString("yyyyMMdd")+"' and Status=2 "+
                    "order by MailtripNumber desc");
            return ds.Tables[0];
        }

        public DataTable DanhSachTuiTrongNgay()
        {
            db.ChuoiKetNoi = ChuoiKetNoi;
            db.TaoKetNoi();
            DataSet ds;
            ds = db.ChayThuTuc("select PostBagNumber as TuiSo "+
                    "from PostBag "+
                    "where ServiceCode='"+MaDichVu+"' and FromPOSCode='"+SoHieuBuuCuc+"' and ToPOSCode='"+MaDuongThu+"' and [Year]='"+Ngay.ToString("yyyyMMdd")+"' "+//and [Status]=2 "+
	                    "and MailTripNumber="+SoChuyen.ToString()+
                    " order by PostBagNumber desc");
            return ds.Tables[0];
        }
    }
}
