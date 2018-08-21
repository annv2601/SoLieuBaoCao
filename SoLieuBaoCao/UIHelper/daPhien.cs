﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}