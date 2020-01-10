using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.DuLieuBaoCao;
using Ext.Net;
//using BaoBieu;

namespace SoLieuBaoCao.BieuBaoCao
{
    public partial class frmChiTietSoLieuSTK1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Ext.Net.X.IsAjaxRequest)
            {
                if(UIHelper.daPhien.DaDangNhap)
                {
                    MaBieuBaoCao = Request.QueryString["BieuBaoCaoSTK1"];
                    IDChiTieu = int.Parse(Request.QueryString["ChiTieuSTK1"]);
                    HienThiChiTiet(MaBieuBaoCao,IDChiTieu);
                }
            }
        }

        private string MaBieuBaoCao
        {
            get
            {
                return txtMaBieuBaoCao.Text;
            }
            set
            {
                txtMaBieuBaoCao.Text = value;
            }
        }

        private int IDChiTieu
        {
            get
            {
                return int.Parse(txtIDChiTieu.Text);
            }
            set
            {
                txtIDChiTieu.Text = value.ToString();
            }
        }

        private void HienThiChiTiet(string rMaBieuBaoCao, int rIDChiTieu)
        {
            daDuLieuChiTietSTK dCTSTK = new daDuLieuChiTietSTK();
            dCTSTK.MaBieuBaoCao = rMaBieuBaoCao;
            dCTSTK.IDChiTieu = rIDChiTieu;

            stoChiTietDichVuSTK1.DataSource = dCTSTK.dsChiTietDichVu();
            stoChiTietDichVuSTK1.DataBind();

            stoChiTietDichVuNgay.DataSource = dCTSTK.dsChiTietDichVuNgay();
            stoChiTietDichVuNgay.DataBind();

            stoChiTietBuuCucNgay.DataSource = dCTSTK.dsChiTietBuuCucNgay();
            stoChiTietBuuCucNgay.DataBind();
        }

        protected void btnXuatExcelDV_Click(object sender, DirectEventArgs e)
        {

        }

        protected void btnXuatExcelDVNgay_Click(object sender, DirectEventArgs e)
        {
            /*daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "ChiTietDichVuTheoNgay" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            dXuatE.TenFileMau = dXuatE.DuongDan + "\\Resource\\FileMauExcel\\MauChiTietSTK1.xls";

            daDuLieuChiTietSTK dCTSTK = new daDuLieuChiTietSTK();
            dCTSTK.MaBieuBaoCao = MaBieuBaoCao;
            dCTSTK.IDChiTieu = IDChiTieu;

            dXuatE.DuLieu = dCTSTK.dsChiTietDichVuNgay();

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatFileExcel_TheoMau());
            Response.Redirect(_url);*/
        }

        protected void btnXuatExcelBCNgay_Click(object sender, DirectEventArgs e)
        {
            /*daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "ChiTietbuuCucTheoNgay" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            dXuatE.TenFileMau = dXuatE.DuongDan + "\\Resource\\FileMauExcel\\MauChiTietSTK1.xls";

            daDuLieuChiTietSTK dCTSTK = new daDuLieuChiTietSTK();
            dCTSTK.MaBieuBaoCao = MaBieuBaoCao;
            dCTSTK.IDChiTieu = IDChiTieu;

            dXuatE.DuLieu = dCTSTK.dsChiTietBuuCucNgay();

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatFileExcel_TheoMau());
            Response.Redirect(_url);*/
        }
    }
}