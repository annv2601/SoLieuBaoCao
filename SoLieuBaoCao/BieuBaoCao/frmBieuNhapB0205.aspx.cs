using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using daoSLBC.DuLieuBaoCao;
using daoSLBC.BieuBaoCao;
using daoSLBC.DanhMuc;
using daoSLBC.Database.DuLieuBaoCao;
using daoSLBC.SoLieuNgoai;
using Ext.Net;
using BaoBieu.BaoCaoB0205;
using BaoBieu;

namespace SoLieuBaoCao.BieuBaoCao
{
    public partial class frmBieuNhapB0205 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                if(UIHelper.daPhien.DaDangNhap)
                {
                    if(Request.QueryString["MaBieuNhapB0205"] !=null)
                    {
                        MaBieuBaoCao = Request.QueryString["MaBieuNhapB0205"].ToString();
                        Nam = int.Parse(Request.QueryString["NamBieuNhapB0205"]);
                        IDMauBieu = int.Parse(Request.QueryString["IDMauBieuBieuNhapB0205"]);
                        Thang = byte.Parse(Request.QueryString["ThangBieuNhapB0205"]);
                        
                        DanhSachNhap();
                    }
                }
            }
        }

        #region Rieng
        private string MaBieuBaoCao
        {
            get
            {
                return Session["MaBieuBaoCaoNhapB0205"].ToString();
            }
            set
            {
                Session["MaBieuBaoCaoNhapB0205"] = value;
            }
        }

        private byte Thang
        {
            get
            {
                return (byte)Session["ThangNhapB0205"];
            }
            set
            {
                Session["ThangNhapB0205"] = value;
            }
        }

        private int Nam
        {
            get
            {
                return (int)Session["NamNhapB0205"];
            }
            set
            {
                Session["NamNhapB0205"] = value;
            }
        }

        private int IDMauBieu
        {
            get
            {
                return (int)Session["IDMauBieuNhapB0205"];
            }
            set
            {
                Session["IDMauBieuNhapB0205"] = value;
            }
        }

        private void DanhSachNhap()
        {
            daDuLieuBaoCaoB0205 dB0205 = new daDuLieuBaoCaoB0205();
            dB0205.MaBieuBaoCao = MaBieuBaoCao;

            stoNhapB0205.DataSource = dB0205.DanhSach();
            stoNhapB0205.DataBind();
        }
        #endregion

        #region Su kien        

        protected void btnKhoiTaoLaiBaoCao_Click(object sender, DirectEventArgs e)
        {
            X.Msg.Confirm("Thông báo", "Anh/chị có chắc chắn muốn khởi tạo lại báo cáo này không? Việc khởi tạo lại sẽ xóa hết dữ liệu cũ", new MessageBoxButtonsConfig
            {
                Yes = new MessageBoxButtonConfig
                {
                    Handler = "App.direct.DoYes()",
                    Text = "Có chắc chắn"
                },
                No = new MessageBoxButtonConfig
                {
                    Handler = "App.direct.DoNo()",
                    Text = "Không"
                }
            }).Show();
            
        }
        [DirectMethod]
        public void DoYes()
        {
            daTrangThaiBaoCao dTTBC = new daTrangThaiBaoCao();
            daDuLieuBaoCaoB0205 dB0205 = new daDuLieuBaoCaoB0205();

            dTTBC.TT.MaBaoCao = MaBieuBaoCao;
            dTTBC.TT.IDTrangThai = (int)daDanhMuc.eTrangThai.Khởi_tạo_lại_Báo_cáo;
            dTTBC.TT.TenTrangThai = "Khởi tạo lại Báo cáo";
            dTTBC.TT.NguoiThucHien = UIHelper.daPhien.MaNSD + ":" + UIHelper.daPhien.TenNguoiSuDung;

            dB0205.MaBieuBaoCao = MaBieuBaoCao;
            dB0205.IDMauBieu = IDMauBieu;
            dB0205.Thang = Thang;
            dB0205.Nam = Nam;
            dB0205.MaDonVi = UIHelper.daPhien.MaDonVi;
            dB0205.MaDonViSTK1 = UIHelper.daPhien.ThongTinDN.MaSTK1;
            dB0205.NguoiThucHien = UIHelper.daPhien.MaNSD + ":" + UIHelper.daPhien.TenNguoiSuDung;

            dB0205.KhoiTao();

            daSoLieuSTK1 dSLSTK1 = new daSoLieuSTK1();
            dSLSTK1.Thang = Thang;
            dSLSTK1.Nam = Nam;
            dSLSTK1.MaDonViSTK1 = UIHelper.daPhien.ThongTinDN.MaSTK1;
            dSLSTK1.LaySoLieuSTK1_DonVi();

            dB0205.LaySoLieuSTK1();

            dB0205.TinhDanSuat();

            DanhSachNhap();
        }

        [DirectMethod]
        public void DoNo()
        {
        }

        protected void grdBieuNhapB0205_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesCTSTK"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _IDChiTieu="0";
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    _IDChiTieu = row["IDChiTieu"];
                }
                catch
                {
                    _IDChiTieu = "0";
                }
            }

            if (_IDChiTieu != "0")
            {
                string _url = UIHelper.daPhien.LayDiaChiURL("/BieuBaoCao/frmChiTietB0205.aspx?BieuBaoCaoSTK1=" + MaBieuBaoCao + "&&ChiTieuSTK1=" + _IDChiTieu);
                string script = "window.open('" + _url + "', '')";
                this.btnIn.AddScript(script);
            }
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

        #region Bao cao, Xuat Excel
        protected void btnIn_CLick(object sender, DirectEventArgs e)
        {
            daDuLieuBaoCaoB0205 dDLB0205 = new daDuLieuBaoCaoB0205();
            dDLB0205.MaBieuBaoCao = MaBieuBaoCao;

            crB0205 rptB0205 = new crB0205();
            rptB0205.SetDataSource(dDLB0205.DanhSach());

            
            rptB0205.SetParameterValue(0, UIHelper.daPhien.ThongTinDN.TenDonVi);
            rptB0205.SetParameterValue(1, "");
            rptB0205.SetParameterValue(2, "BƯU ĐIỆN THÀNH PHỐ HÀ NỘI");
            rptB0205.SetParameterValue(3, "");
            rptB0205.SetParameterValue(4, "");

            rptB0205.SetParameterValue(5, "SẢN LƯỢNG, DOANH THU VÀ THUẾ GIÁ TRỊ GIA TĂNG");
            rptB0205.SetParameterValue(6, "Tháng " + Thang.ToString() + " Năm " + Nam.ToString());
            rptB0205.SetParameterValue(7, UIHelper.daPhien.TenNguoiSuDung);

            string _tf;
            _tf = UIHelper.daPhien.TenFileInBaoCao("BaoCaoB0205");
            rptB0205.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("..") + _tf); 
            string _url = UIHelper.daPhien.LayDiaChiURL(_tf);

            string script = "window.open('"+_url+"', '')";
            this.btnIn.AddScript(script);
        }

        protected void btnXuatExcel_Click(object sender, DirectEventArgs e)
        {
            daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "BaoCaoB0205DonVi" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            dXuatE.TenFileMau = dXuatE.DuongDan + "\\Resource\\FileMauExcel\\MauBaoCaoB0205.xls";

            daDuLieuBaoCaoB0205 dB0205 = new daDuLieuBaoCaoB0205();
            dB0205.MaBieuBaoCao = MaBieuBaoCao;

            DataTable dt = dB0205.DanhSach();
            try
            {
                dt.Columns.Remove("ThuTu");    
                dt.Columns.Remove("InDam");
                dt.Columns.Remove("InNghieng");
                dt.Columns.Remove("InDamNghieng");
                dt.Columns.Remove("IDChiTieu");
                dt.Columns.Remove("MaBieuBaoCao");
            }
            catch { }
            dXuatE.DuLieu = dt;

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatFileExcel_TheoMau());
            Response.Redirect(_url);
        }
        #endregion
    }
}