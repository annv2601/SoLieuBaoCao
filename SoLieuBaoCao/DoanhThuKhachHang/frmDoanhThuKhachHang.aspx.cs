using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Ext.Net;
using daoSLTH.DoanhThuKhachHang;
using BaoBieu;
using SoLieuBaoCao.UIHelper;

namespace SoLieuBaoCao.DoanhThuKhachHang
{
    public partial class frmDoanhThuKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                txtTuNgay.SelectedDate = UIHelper.daPhien.NgayDauTuan(DateTime.Now);
                txtDenNgay.SelectedDate = DateTime.Now;
                txtMaDonVi.Text = "1100";
            }
        }

        #region "Rieng"
        private DataTable DoanhThuCTiet()
        {
            daDoanhThuKH dDT = new daDoanhThuKH();
            dDT.TuNgay = txtTuNgay.SelectedDate;
            dDT.DenNgay = txtDenNgay.SelectedDate;
            dDT.MaDonVi = txtMaDonVi.Text.Trim();

            return dDT.DanhSach();
        }
        #endregion

        #region Su kien
        protected void btnHienThi_Click(object sender, DirectEventArgs e)
        {
            stoKhachHang.DataSource = DoanhThuCTiet();
            stoKhachHang.DataBind();
        }

        protected void btnXuatExcel_Click(object sender, DirectEventArgs e)
        {
            daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "DoanhThu" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            dXuatE.TenFileMau = dXuatE.DuongDan + "\\Resource\\FileMauExcel\\MauDoanhThuCTiet.xls";

            dXuatE.DuLieu = DoanhThuCTiet();

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatFileExcel_TheoMau());
            Response.Redirect(_url);
        }

        protected void btnTongHop_Click(object sender, DirectEventArgs e)
        {
            daDoanhThuKH dDT = new daDoanhThuKH();
            dDT.TuNgay = txtTuNgay.SelectedDate;
            dDT.DenNgay = txtTuNgay.SelectedDate;

            dDT.TongHop();

            X.Msg.Alert("","Đã Tổng hợp xong số liệu của ngày "+txtTuNgay.SelectedDate.ToString("dd/MM/yyyy")).Show();
        }

        protected void btnTheoDoiDonViCot_Click(object sender, DirectEventArgs e)
        {
            daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "TheoDoiDoanhThu" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            daTheoDoiDoanhThu dDT = new daTheoDoiDoanhThu();
            dDT.TuNgay = txtTuNgay.SelectedDate;
            dDT.DenNgay = txtDenNgay.SelectedDate;
            dDT.MaDonVi = txtMaDonVi.Text.Trim();

            dXuatE.DuLieu = dDT.BaoCaoDonViCot();

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatExcelCotDong());
            Response.Redirect(_url);
        }

        protected Field OnCreateFilterableField(object sender, ColumnBase column, Field defaultField)
        {
            if (column.DataIndex == "Id")
            {
                ((TextField)defaultField).Icon = Icon.Magnifier;
            }

            return defaultField;
        }
        #endregion
    }
}