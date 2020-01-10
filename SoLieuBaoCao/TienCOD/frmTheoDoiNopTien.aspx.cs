using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoTienThuCOD.NopTienNganHang;
using daoTienThuCOD;
using Ext.Net;

namespace SoLieuBaoCao.TienCOD
{
    public partial class frmTheoDoiNopTien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Rieng
        private void HienThi(DateTime rTuNgay, DateTime rDenNgay)
        {
            daNopTienNganHang dNNH = new daNopTienNganHang();
            dNNH.MaBuuCuc = "";
            dNNH.MaDonVi = "";
            dNNH.TuNgay = rTuNgay;
            dNNH.DenNgay = rDenNgay;
            stoTDNopTien.DataSource = dNNH.DanhSachTDBuuCuc();
            stoTDNopTien.DataBind();
        }
        #endregion

        #region Su kien
        protected void btn30Ngay_Click(object sender, DirectEventArgs e)
        {
            DateTime rNgay = DateTime.Now;
            HienThi(rNgay.AddDays(-30), rNgay);
        }

        protected void btnTrongThang_Click(object sender, DirectEventArgs e)
        {
            DateTime rNgay = DateTime.Now;
            
            HienThi(daTienIch.NgayDauThang(Convert.ToInt16(rNgay.Month),rNgay.Year), daTienIch.NgayCuoiThang(Convert.ToInt16(rNgay.Month), rNgay.Year));
        }

        protected void btnHomQua_Click(object sender, DirectEventArgs e)
        {
            DateTime rNgay = DateTime.Now;
            rNgay = rNgay.AddDays(-1);
            HienThi(rNgay, rNgay);
        }

        protected void btnHomNay_Click(object sender, DirectEventArgs e)
        {
            DateTime rNgay = DateTime.Now;
            HienThi(rNgay, rNgay);
        }

        protected void grdTheoDoiNopTien_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesNT"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _MaBuuCuc = "0";
            DateTime _TuNgay=DateTime.Now, _DenNgay=DateTime.Now;
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    _MaBuuCuc = row["Ma"];
                    _TuNgay = DateTime.Parse(row["TuNgay"]);
                    _DenNgay = DateTime.Parse(row["DenNgay"]);
                }
                catch
                {
                    _MaBuuCuc = "0";
                }
            }

            if (_MaBuuCuc != "0")
            {
                string _url;
                _url = UIHelper.daPhien.LayDiaChiURL("/TienCOD/frmChiTietNopTien.aspx?ntTuNgay=" + _TuNgay.ToShortDateString() + "&&ntDenNgay=" + _DenNgay.ToShortDateString() + "&&ntMaDonVi=" + _MaBuuCuc);
                string script = "window.open('" + _url + "', '')";
                this.grdTheoDoiNopTien.AddScript(script);
            }
        }
        #endregion
    }
}