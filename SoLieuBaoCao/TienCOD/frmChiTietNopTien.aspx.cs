using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoTienThuCOD.NopTienNganHang;
using Ext.Net;

namespace SoLieuBaoCao.TienCOD
{
    public partial class frmChiTietNopTien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                TuNgay = Request.QueryString["ntTuNgay"];
                DenNgay = Request.QueryString["ntDenNgay"];
                MaBuuCuc = Request.QueryString["ntMaDonVi"];

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
            daNopTienNganHang dNNH = new daNopTienNganHang();
         
            dNNH.TuNgay = DateTime.Parse(TuNgay);
            dNNH.DenNgay = DateTime.Parse(DenNgay);
            dNNH.MaBuuCuc = MaBuuCuc;
            stoChiTietNT.DataSource = dNNH.DanhSachTD();
            stoChiTietNT.DataBind();
        }
    }
}