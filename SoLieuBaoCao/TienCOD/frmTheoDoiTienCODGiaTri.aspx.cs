using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoTienThuCOD.SoLieuDen;
using daoTienThuCOD;
using Ext.Net;

namespace SoLieuBaoCao.TienCOD
{
    public partial class frmTheoDoiTienCODGiaTri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                DateTime rNgay = DateTime.Now;
                TuNgay = rNgay.AddDays(-7);
                DenNgay = rNgay;

                SoTien = 3000000;
                HienThi(SoTien);
            }
        }

        #region thuoc tinh
        private Double SoTien
        {
            get { return (Double)Session["TienCODGiaTri"]; }
            set { Session["TienCODGiaTri"] = value; }
        }

        private DateTime TuNgay
        {
            get { return txtTuNgay.SelectedDate; }
            set { txtTuNgay.SelectedDate = value; }
        }

        private DateTime DenNgay
        {
            get { return txtDenNgay.SelectedDate; }
            set { txtDenNgay.SelectedDate = value; }
        }
        #endregion

        #region Rieng
        private void HienThi(Double rSoTien)
        {
            daSLDenBGGTri dBGGT = new daSLDenBGGTri();
            dBGGT.TuNgay = TuNgay;
            dBGGT.DenNgay = DenNgay;
            dBGGT.MaDonVi = "";
            stoTheoDoiTienCODGiaTri.DataSource = dBGGT.DanhSachTHop(rSoTien);
            stoTheoDoiTienCODGiaTri.DataBind();
        }
        #endregion

        #region Su kien
        protected void btnTren1Trieu_Click(object sender, DirectEventArgs e)
        {
            SoTien = 1000000;
            HienThi(SoTien);
        }

        protected void btnTren2Trieu_Click(object sender, DirectEventArgs e)
        {
            SoTien = 2000000;
            HienThi(SoTien);
        }

        protected void btnTren3Trieu_Click(object sender, DirectEventArgs e)
        {
            SoTien = 3000000;
            HienThi(SoTien);
        }

        protected void btnTren5Trieu_Click(object sender, DirectEventArgs e)
        {
            SoTien = 5000000;
            HienThi(SoTien);
        }

        protected void btnTren10Trieu_Click(object sender, DirectEventArgs e)
        {
            SoTien = 10000000;
            HienThi(SoTien);
        }

        protected void grdTheoDoiTienCODGiaTri_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesGT"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _MaBuuCuc = "0";
            DateTime _TuNgay = DateTime.Now, _DenNgay = DateTime.Now;
            Double _ST = 0;
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    _MaBuuCuc = row["Ma"];
                    _TuNgay = DateTime.Parse(row["TuNgay"]);
                    _DenNgay = DateTime.Parse(row["DenNgay"]);
                    _ST = Convert.ToDouble(row["GiaTri"]);
                }
                catch
                {
                    _MaBuuCuc = "0";
                }
            }

            if (_MaBuuCuc != "0")
            {
                string _url;
                _url = UIHelper.daPhien.LayDiaChiURL("/TienCOD/frmTheoDoiTienCODGiaTri_CTiet.aspx?gtTuNgay=" + _TuNgay.ToShortDateString() + "&&gtDenNgay=" + _DenNgay.ToShortDateString() + "&&gtMaDonVi=" + _MaBuuCuc + "&&gtSoTien=" + SoTien.ToString() + "&&gtGiaTri=" + _ST.ToString());
                string script = "window.open('" + _url + "', '')";
                this.grdTheoDoiTienCODGiaTri.AddScript(script);
            }
        }
        #endregion
    }
}