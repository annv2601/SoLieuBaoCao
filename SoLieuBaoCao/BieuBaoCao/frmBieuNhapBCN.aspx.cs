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
//using BaoBieu.BieuNhap;
//using BaoBieu;

namespace SoLieuBaoCao.BieuBaoCao
{
    public partial class frmBieuNhapBCN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                if(UIHelper.daPhien.DaDangNhap)
                {
                    if(Request.QueryString["MaBieuNhapBCN"] !=null)
                    {
                        MaBieuBaoCao = Request.QueryString["MaBieuNhapBCN"].ToString();
                        Nam = int.Parse(Request.QueryString["NamBieuNhapBCN"]);
                        IDMauBieu = int.Parse(Request.QueryString["IDMauBieuBieuNhapBCN"]);
                        Thang = byte.Parse(Request.QueryString["ThangBieuNhapBCN"]);
                        
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
                return Session["MaBieuBaoCaoNhapBCN"].ToString();
            }
            set
            {
                Session["MaBieuBaoCaoNhapBCN"] = value;
            }
        }

        private byte Thang
        {
            get
            {
                return (byte)Session["ThangNhapBCN"];
            }
            set
            {
                Session["ThangNhapBCN"] = value;
            }
        }

        private int Nam
        {
            get
            {
                return (int)Session["NamNhapBCN"];
            }
            set
            {
                Session["NamNhapBCN"] = value;
            }
        }

        private int IDMauBieu
        {
            get
            {
                return (int)Session["IDMauBieuNhapBCN"];
            }
            set
            {
                Session["IDMauBieuNhapBCN"] = value;
            }
        }

        private void DanhSachNhap()
        {
            daDuLieuBCN dBCN = new daDuLieuBCN();
            dBCN.MaBieuBaoCao = MaBieuBaoCao;
            dBCN.Nam = Nam;
            dBCN.MaDonVi = UIHelper.daPhien.MaDonVi;

            stoNhapBCN.DataSource = dBCN.DanhSachNhapBCN();
            stoNhapBCN.DataBind();
        }
        #endregion

        #region Su kien
        [DirectMethod(Namespace = "BangNhapBCNX")]
        public void Edit(int id, string field, string oldvalue, string newvalue, object BangBCN)
        {
            daDuLieuBCN dBCN = new daDuLieuBCN();
            dBCN.BCN.MaBieuBaoCao = MaBieuBaoCao;
            dBCN.BCN.IDChiTieu = id;
            dBCN.BCN.SoLieuNhap = decimal.Parse(newvalue);
            dBCN.BCN.NguoiNhapBCN= UIHelper.daPhien.MaNSD + ":" + UIHelper.daPhien.TenNguoiSuDung;
            dBCN.CapNhatNhap();

            grdBieuNhapBCN.GetStore().GetById(id).Commit();

            List<clsTinhDanSuat> lstTinh;
            dBCN.IDMauBieu = IDMauBieu;
            dBCN.BCN.SoLieuNhap = dBCN.BCN.SoLieuNhap - decimal.Parse(oldvalue);
            lstTinh = dBCN.TinhDanSuatNhap();

            foreach(clsTinhDanSuat t in lstTinh)
            {
                grdBieuNhapBCN.GetStore().GetById(t.IDChiTieu).Set("SoLieuNhap", t.SoLieuNhap);
                grdBieuNhapBCN.GetStore().GetById(t.IDChiTieu).Commit();
            }
        }

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
            daDuLieuBCN dBCN = new daDuLieuBCN();

            dTTBC.TT.MaBaoCao = MaBieuBaoCao;
            dTTBC.TT.IDTrangThai = (int)daDanhMuc.eTrangThai.Khởi_tạo_lại_Báo_cáo;
            dTTBC.TT.TenTrangThai = "Khởi tạo lại Báo cáo";
            dTTBC.TT.NguoiThucHien = UIHelper.daPhien.MaNSD + ":" + UIHelper.daPhien.TenNguoiSuDung;

            dBCN.BCN.MaBieuBaoCao = MaBieuBaoCao;
            dBCN.IDMauBieu = IDMauBieu;
            dBCN.Thang = Thang;
            dBCN.Nam = Nam;
            dBCN.MaDonVi = UIHelper.daPhien.MaDonVi;
            dBCN.MaDonViSTK1 = UIHelper.daPhien.ThongTinDN.MaSTK1;
            dBCN.MaBieuBaoCao = MaBieuBaoCao;

            dTTBC.Them();

            dBCN.KhoiTao();

            //Lay so lieu ben stk1 sang
            /*daSoLieuSTK1 dSLSTK1 = new daSoLieuSTK1();
            dSLSTK1.Thang = Thang;
            dSLSTK1.Nam = Nam;
            dSLSTK1.MaDonViSTK1= UIHelper.daPhien.ThongTinDN.MaSTK1;
            dSLSTK1.LaySoLieuSTK1_DonVi();*/
            //=================

            dBCN.LaySTK1();

            dBCN.TinhDanSuatSTK1();

            //Cap nhat Doanh thu, CHi phi
            daBieuBaoCao dBBC = new daBieuBaoCao();
            dBBC.BieuBC.MaBaoCao = MaBieuBaoCao;
            dBBC.CapNhatDoanhThuChiPhi(true);
            //============================

            DanhSachNhap();
        }

        [DirectMethod]
        public void DoNo()
        {
        }

        protected void btnLayThucHien_Click(object sender, DirectEventArgs e)
        {
            daDuLieuBCN dBCN = new daDuLieuBCN();

            dBCN.BCN.MaBieuBaoCao = MaBieuBaoCao;
            dBCN.IDMauBieu = IDMauBieu;
            dBCN.Thang = Thang;
            dBCN.Nam = Nam;
            dBCN.MaDonVi = UIHelper.daPhien.MaDonVi;
            dBCN.MaDonViSTK1 = UIHelper.daPhien.ThongTinDN.MaSTK1;
            dBCN.MaBieuBaoCao = MaBieuBaoCao;

            dBCN.LaySTK1ThucHien();

            dBCN.TinhDanSuatThucHien();

            //Cap nhat Doanh thu, CHi phi
            daBieuBaoCao dBBC = new daBieuBaoCao();
            dBBC.BieuBC.MaBaoCao = MaBieuBaoCao;
            dBBC.CapNhatDoanhThuChiPhi(false);
            //============================

            DanhSachNhap();
        }

        protected void grdBieuNhapBCN_ClickDup(object sender, DirectEventArgs e)
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
                string _url = UIHelper.daPhien.LayDiaChiURL("/BieuBaoCao/frmChiTietSoLieuSTK1.aspx?BieuBaoCaoSTK1=" + MaBieuBaoCao + "&&ChiTieuSTK1=" + _IDChiTieu);
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
            /*daDuLieuBCN dBCN = new daDuLieuBCN();
            dBCN.MaBieuBaoCao = MaBieuBaoCao;
            dBCN.Nam = Nam;
            dBCN.MaDonVi = UIHelper.daPhien.MaDonVi;

            crBieuNhapBaoCaoNhanhDonVi rptBCN = new crBieuNhapBaoCaoNhanhDonVi();
            rptBCN.SetDataSource(dBCN.DanhSachNhapBCN());

            rptBCN.SetParameterValue(0, "BƯU ĐIỆN THÀNH PHỐ HÀ NỘI");
            rptBCN.SetParameterValue(1, UIHelper.daPhien.ThongTinDN.TenDonVi);
            rptBCN.SetParameterValue(2, "BÁO CÁO NHANH TÌNH HÌNH SẢN XUẤT KINH DOANH CỦA ĐƠN VỊ");
            rptBCN.SetParameterValue(3, "Tháng " + Thang.ToString() + " Năm " + Nam.ToString());
            rptBCN.SetParameterValue(4, UIHelper.daPhien.TenNguoiSuDung);

            string _tf;
            _tf = UIHelper.daPhien.TenFileInBaoCao("SoLieu");
            rptBCN.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("..") + _tf);
            //string _url = UIHelper.daPhien.LayDiaChiURL("/BaoCao/frmHienThiBaoCao.aspx") + "?TenFilePDF=" + _tf;            
            string _url = UIHelper.daPhien.LayDiaChiURL(_tf);

            string script = "window.open('"+_url+"', '')";
            this.btnIn.AddScript(script);*/
        }

        protected void btnXuatExcel_Click(object sender, DirectEventArgs e)
        {
            /*daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "BaoCaoNhanhDonVi" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            dXuatE.TenFileMau = dXuatE.DuongDan + "\\Resource\\FileMauExcel\\MauBoaoCaoNhanhDonVi.xls";

            daDuLieuBCN dBCN = new daDuLieuBCN();
            dBCN.MaBieuBaoCao = MaBieuBaoCao;
            dBCN.Nam = Nam;
            dBCN.MaDonVi = UIHelper.daPhien.MaDonVi;
            DataTable dt= dBCN.DanhSachNhapBCN();
            try
            {
                dt.Columns.Remove("MaBieuBaoCao");
                dt.Columns.Remove("IDChiTieu");
                dt.Columns.Remove("SoLieuPhanBo");
                dt.Columns.Remove("LuyKe");
                dt.Columns.Remove("STTsx");
                dt.Columns.Remove("InDam");
                dt.Columns.Remove("InNghieng");
                dt.Columns.Remove("NhapTay");
            }
            catch { }
            dXuatE.DuLieu = dt;

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatFileExcel_TheoMau());
            Response.Redirect(_url);*/
        }
        #endregion
    }
}