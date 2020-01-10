using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using daoTienThuCOD.SoLieuDen;
using Ext.Net;
using BaoBieu;

namespace SoLieuBaoCao.TienCOD
{
    public partial class frmTheoDoiTienCODGiaTri_CTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                TuNgay = Request.QueryString["gtTuNgay"];
                DenNgay = Request.QueryString["gtDenNgay"];
                MaBuuCuc = Request.QueryString["gtMaDonVi"];
                SoTien = Request.QueryString["gtSoTien"];
                GiaTri = Request.QueryString["gtGiaTri"];

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

        private string SoTien
        {
            get { return txtSoTien.Text; }
            set { txtSoTien.Text = value; }
        }

        private string GiaTri
        {
            get { return txtGiaTri.Text; }
            set { txtGiaTri.Text = value; }
        }
        #endregion

        private void DanhSach()
        {
            daSLDenBGGTri dBGGT = new daSLDenBGGTri();

            dBGGT.TuNgay = DateTime.Parse(TuNgay);
            dBGGT.DenNgay = DateTime.Parse(DenNgay);
            dBGGT.MaBuuCuc = MaBuuCuc;
            dBGGT.MaDonVi = MaBuuCuc;
            Double _gt, _st;
            _gt = Convert.ToDouble(GiaTri);
            _st = Convert.ToDouble(SoTien);
            _st = _st / 2;
            stoChiTietNT.DataSource = dBGGT.DanhSachCTiet(_gt - 500000, _gt + 500000);
            stoChiTietNT.DataBind();
        }

        protected void btnXuatExcel_Click(object sender, DirectEventArgs e)
        {
            daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "BuuGuiPhatCODGiaTriLon" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            dXuatE.TenFileMau = dXuatE.DuongDan + "\\Resource\\FileMauExcel\\MauBGGTri.xls";

            daSLDenBGGTri dBGGT = new daSLDenBGGTri();

            dBGGT.TuNgay = DateTime.Parse(TuNgay);
            dBGGT.DenNgay = DateTime.Parse(DenNgay);
            dBGGT.MaBuuCuc = MaBuuCuc;
            dBGGT.MaDonVi = MaBuuCuc;
            Double _gt, _st;
            _gt = Convert.ToDouble(GiaTri);
            _st = Convert.ToDouble(SoTien);
            _st = _st / 2;
            DataTable dt = dBGGT.DanhSachCTiet(_gt - 500000, _gt + 500000);
            try
            {
                dt.Columns.Remove("Year");
                dt.Columns.Remove("DaPhat");
                dt.Columns.Remove("DaChuyenHoan");
                dt.Columns.Remove("DaHuy");
                dt.Columns.Remove("LyDo");
                dt.Columns.Remove("NgayHuy");
            }
            catch { }

            dXuatE.DuLieu = dt;

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatFileExcel_TheoMau());
            Response.Redirect(_url);
        }
    }
}