using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using daoSLBC.Database.HeThong;

namespace SoLieuBaoCao.UIHelper
{
    public static class daPhien
    {
        public static bool DaDangNhap
        {
            get { return HttpContext.Current.Session["slbcIsLogin"] == null ? false : (bool)HttpContext.Current.Session["slbcIsLogin"]; }
            set { HttpContext.Current.Session["slbcIsLogin"] = value; }
        }

        public static string MaNSD
        {
            get { return HttpContext.Current.Session["slbcIsMaNSD"] == null ? "" : (string)HttpContext.Current.Session["slbcIsMaNSD"]; }
            set { HttpContext.Current.Session["slbcIsMaNSD"] = value; }
        }

        public static string MaDonVi
        {
            get { return HttpContext.Current.Session["slbcIsMaDonVi"] == null ? "" : (string)HttpContext.Current.Session["slbcIsMaDonVi"]; }
            set { HttpContext.Current.Session["slbcIsMaDonVi"] = value; }
        }

        public static sp_KiemTraDangNhapResult ThongTinDN
        {
            get { return HttpContext.Current.Session["slbcIsTTDangNhap"] == null ? new sp_KiemTraDangNhapResult() : (sp_KiemTraDangNhapResult)HttpContext.Current.Session["slbcIsTTDangNhap"]; }
            set { HttpContext.Current.Session["slbcIsTTDangNhap"] = value; }
        }

        public static string TenNguoiSuDung
        {
            get { return HttpContext.Current.Session["slbcIsTenNSD"] == null ? "" : (string)HttpContext.Current.Session["slbcIsTenNSD"]; }
            set { HttpContext.Current.Session["slbcIsTenNSD"] = value; }
        }

        public static string LayDiaChiURL(string rDuongDan)
        {
            HttpRequest r = HttpContext.Current.Request;
            if (r.ApplicationPath == "/")
            {
                return r.Url.Scheme + "://" + r.Url.Authority + rDuongDan;
            }
            else
            {
                return r.Url.Scheme + "://" + r.Url.Authority + r.ApplicationPath + rDuongDan;
            }
        }

        public static string LayDiaChiURLChucNang(int rID, string rDuongDan)
        {
            HttpRequest r = HttpContext.Current.Request;
            if (r.ApplicationPath == "/")
            {
                return r.Url.Scheme + "://" + r.Url.Authority + rDuongDan + "?CN=" + rID.ToString();
            }
            else
            {
                return r.Url.Scheme + "://" + r.Url.Authority + r.ApplicationPath + rDuongDan + "?CN=" + rID.ToString(); ;
            }
        }

        public static void KiemTraXacThuc()
        {
            if (HttpContext.Current.Session["PhienLamViecBSC"] == null)
            {
                HttpContext.Current.Response.Redirect("frmChuaLogin.aspx");
            }
        }

        public static string TenFileInBaoCao(string rTenDau)
        {
            string _tenfile;
            _tenfile = "//" + "DataPDF" + "//" + rTenDau + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            return _tenfile;
        }

        public static DateTime NgayDauTuan(DateTime rNgay)
        {
            /*System.Globalization.CultureInfo ci =
            System.Threading.Thread.CurrentThread.CurrentCulture;
            ci.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Monday;
            DayOfWeek firstDay = ci.DateTimeFormat.FirstDayOfWeek;*/
            DayOfWeek firstDay = DayOfWeek.Monday;
            DateTime firstDayInWeek = rNgay.Date;
            while (firstDayInWeek.DayOfWeek != firstDay)
                firstDayInWeek = firstDayInWeek.AddDays(-1);

            return firstDayInWeek;
        }

        public static DateTime NgayDauThang(DateTime rNgay)
        {
            return DateTime.Parse(rNgay.Month.ToString() + "/01/" + rNgay.Year.ToString());
        }

        public static DateTime NgayDauNam(DateTime rNgay)
        {
            return DateTime.Parse("01/01/" + rNgay.Year.ToString());
        }
    }
}
