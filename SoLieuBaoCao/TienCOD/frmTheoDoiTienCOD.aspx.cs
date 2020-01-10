using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoTienThuCOD.KeToan;
using Ext.Net;

namespace SoLieuBaoCao.TienCOD
{
    public partial class frmTheoDoiTienCOD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                TuNgay = Request.QueryString["tcodTuNgay"];
                DenNgay = Request.QueryString["tcodDenNgay"];
                MaBuuCuc = Request.QueryString["tcodMaDonVi"];
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

        #region Rieng
        private void DanhSach()
        {
            daKeToanBuuCuc dKTBC = new daKeToanBuuCuc();
            dKTBC.TuNgay = DateTime.Parse(TuNgay);
            dKTBC.DenNgay = DateTime.Parse(DenNgay);
            dKTBC.MaDonVi = MaBuuCuc;
            stoTheoDoiTienCOD.DataSource = dKTBC.DanhSachDonVi();
            stoTheoDoiTienCOD.DataBind();
        }
        #endregion

        protected void btnHienThi_Click(object sender, DirectEventArgs e)
        {
            DanhSach();
        }
        
        protected void grdTheoDoiTienCOD_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesCODDV"];
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
                string _url="";
                //_url = UIHelper.daPhien.LayDiaChiURL("/SoLieuPhatHanh/frmChiTietPaypost.aspx?ppTuNgay=" + txtTuNgay.SelectedDate.ToShortDateString() + "&&ppDenNgay=" + txtDenNgay.SelectedDate.ToShortDateString() + "&&ppMaDonVi=" + _MaBuuCuc);
                string script = "window.open('" + _url + "', '')";
                this.grdTheoDoiTienCOD.AddScript(script);
            }
        }
    }
}