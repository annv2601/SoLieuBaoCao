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
    public partial class frmTheoDoiTyLeTienCOD : System.Web.UI.Page
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
            daKeToanBuuCuc dKTBC = new daKeToanBuuCuc();
            dKTBC.TuNgay = txtTuNgay.SelectedDate;
            dKTBC.DenNgay = txtDenNgay.SelectedDate;
            dKTBC.MaDonVi = "";
            stoTheoDoiTienCOD.DataSource = dKTBC.DanhSachTyLe();
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
                    _MaBuuCuc = row["Ma"];                   
                }
                catch
                {
                    _MaBuuCuc = "";
                }
            }

            if (_MaBuuCuc != "")
            {
                string _url;
                _url = UIHelper.daPhien.LayDiaChiURL("/TienCOD/frmTheoDoiTienCOD.aspx?tcodTuNgay=" + txtTuNgay.SelectedDate.ToShortDateString() + "&&tcodDenNgay=" + txtDenNgay.SelectedDate.ToShortDateString() + "&&tcodMaDonVi=" + _MaBuuCuc);
                string script = "window.open('" + _url + "', '')";
                this.grdTheoDoiTienCOD.AddScript(script);
            }
        }
    }
}