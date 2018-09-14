using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLTH.Paypost;
using Ext.Net;

namespace SoLieuBaoCao.SoLieuPhatHanh
{
    public partial class frmTheoDoiPaypost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                txtTuNgay.SelectedDate = DateTime.Now;
                txtDenNgay.SelectedDate = DateTime.Now;
                DanhSach();
            }
        }

        #region Rieng
        private void DanhSach()
        {
            daPaypost dPP = new daPaypost();
            dPP.TuNgay = txtTuNgay.SelectedDate;
            dPP.DenNgay = txtDenNgay.SelectedDate;
            dPP.MaDonVi = "";
            stoTDPaypost.DataSource = dPP.DanhSachLoai();
            stoTDPaypost.DataBind();
        }
        #endregion

        protected void btnHienThi_Click(object sender, DirectEventArgs e)
        {
            DanhSach();
        }

        protected void btnLayTrongNgay_Click(object sender, DirectEventArgs e)
        {
            daPaypost dPP = new daPaypost();
            dPP.TongHop();
            DanhSach();
            X.Msg.Alert("","Đã lấy số liệu phát sinh ngày hôm nay!").Show();
        }

        protected void grdTheoDoiPaypost_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesPP"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _MaBuuCuc="0";            

            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    _MaBuuCuc = row["MaBuuCuc"];                   
                }
                catch
                {
                    _MaBuuCuc = "0";
                }
            }

            if (_MaBuuCuc != "0")
            {
                string _url;
                _url = UIHelper.daPhien.LayDiaChiURL("/SoLieuPhatHanh/frmChiTietPaypost.aspx?ppTuNgay=" + txtTuNgay.SelectedDate.ToShortDateString() + "&&ppDenNgay=" + txtDenNgay.SelectedDate.ToShortDateString() + "&&ppMaDonVi=" + _MaBuuCuc);
                string script = "window.open('" + _url + "', '')";
                this.grdTheoDoiPaypost.AddScript(script);
            }
        }
    }
}