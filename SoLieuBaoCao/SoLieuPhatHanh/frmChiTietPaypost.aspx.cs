using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using daoSLTH.Paypost;

namespace SoLieuBaoCao.SoLieuPhatHanh
{
    public partial class frmChiTietPaypost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                TuNgay = Request.QueryString["ppTuNgay"];
                DenNgay = Request.QueryString["ppDenNgay"];
                MaBuuCuc = Request.QueryString["ppMaDonVi"];

                DanhSach();
            }
        }

        #region Thuoc tinh
        private string TuNgay
        {
            get { return txtTuNgay.Text; }
            set { txtTuNgay.Text = value; }
        }

        private string DenNgay
        {
            get { return txtDenNgay.Text; }
            set { txtDenNgay.Text = value; }
        }

        private string MaBuuCuc
        {
            get { return txtMaBuuCuc.Text; }
            set { txtMaBuuCuc.Text = value; }
        }
        #endregion

        private void DanhSach()
        {
            daPaypost dPP = new daPaypost();
            dPP.TuNgay = DateTime.Parse(TuNgay);
            dPP.DenNgay = DateTime.Parse(DenNgay);
            dPP.MaBuuCuc = MaBuuCuc;
            stoChiTietPP.DataSource = dPP.DanhSachChiTietGiaiDoan();
            stoChiTietPP.DataBind();
        }
    }
}