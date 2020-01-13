using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoKeToanSoDu.SoDuCuoiNgay;
using daoKeToanSoDu.KeToanSoDu;
using daoKeToanSoDu.PhatSinhGiam;
using daoKeToanSoDu;
using daoKeToanSoDu.BaoCao;
using BaoBieu.SoDu;
using Ext.Net;

namespace SoLieuBaoCao.SoDu.SoDuCuoiNgay
{
    public partial class frmSoDuTienmatCuoiNgayDonVi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                if (UIHelper.daPhien.DaDangNhap)
                {
                    NgayThang = DateTime.Now;

                    HienThiNhap();
                    
                }
                else
                {
                    btnNgayTruoc.Visible = false;
                    btnNgaySau.Visible = false;
                    X.Msg.Alert("", "Anh/chị chưa đăng nhập vào phần mềm!").Show();
                }
            }
        }

        #region Thuoc tinh
        private DateTime NgayThang
        {
            get
            {
                return DateTime.Parse(txtNgayThang.Text);
            }
            set
            {
                txtNgayThang.Text = value.ToString();
            }
        }
        #endregion

        #region Danh sach
        private void HienThiNhap()
        {
            daSoDuCuoiNgay dSD = new daSoDuCuoiNgay();
                        
            stoSoDuTMCuoiNgay.DataSource = dSD.DanhSachDonVi(UIHelper.daPhien.MaDonVi, NgayThang);
            stoSoDuTMCuoiNgay.DataBind();

            grdSoDuTMCuoiNgay.Title = "DANH SÁCH SỐ DƯ TIỀN MẶT CÁC ĐƠN VỊ TRỰC THUỘC NGÀY " + NgayThang.ToString("dd/MM/yyyy");
        }
        #endregion

        #region Su kien
        protected void btnThangTruoc_Click(object sender, DirectEventArgs e)
        {
            NgayThang = NgayThang.AddDays(-1);
            HienThiNhap();
        }

        protected void btnThangSau_Click(object sender, DirectEventArgs e)
        {
            NgayThang = NgayThang.AddDays(1);
            HienThiNhap();
        }

        [DirectMethod(Namespace = "BangNhapSDCNX")]
        public void Edit(int id, string field, string oldvalue, string newvalue, object BangSD)
        {
            Newtonsoft.Json.Linq.JObject node = JSON.Deserialize<Newtonsoft.Json.Linq.JObject>(BangSD.ToString());

            if(field.Substring(0,2)=="dk")
            {
                daDuKienChiTra dDKCT = new daDuKienChiTra();
                dDKCT.DKCTra.MaKeToanNgay = node.Property("MaKeToanNgay").Value.ToString();
                dDKCT.DKCTra.MaBuuCuc = node.Property("MaBuuCuc").Value.ToString();
                dDKCT.DKCTra.Ngay = NgayThang;

                try
                {
                    dDKCT.DKCTra.TCBCTapTrung = decimal.Parse(node.Property("dkTCBCTapTrung").Value.ToString());
                }
                catch { dDKCT.DKCTra.TCBCTapTrung = 0; }
                try
                {
                    dDKCT.DKCTra.TCBCThanhToanTaiDonVi = decimal.Parse(node.Property("dkTCBCThanhToanTaiDonVi").Value.ToString());
                }
                catch { dDKCT.DKCTra.TCBCThanhToanTaiDonVi = 0; }
                try
                {
                    dDKCT.DKCTra.TKBD = decimal.Parse(node.Property("dkTKBD").Value.ToString());
                }
                catch { dDKCT.DKCTra.TKBD = 0; }
                try
                {
                    dDKCT.DKCTra.KinhDoanh = decimal.Parse(node.Property("dkKinhDoanh").Value.ToString());
                }
                catch { dDKCT.DKCTra.KinhDoanh = 0; }
                try
                {
                    dDKCT.DKCTra.Cong = decimal.Parse(node.Property("dkCong").Value.ToString());
                }
                catch { dDKCT.DKCTra.Cong = 0; }

                dDKCT.ThemSua();
            }
            else
            {
                daDuCuoiTienMat dDC = new daDuCuoiTienMat();
                dDC.TM.MaKeToanNgay = node.Property("MaKeToanNgay").Value.ToString();
                dDC.TM.MaBuuCuc = node.Property("MaBuuCuc").Value.ToString();
                dDC.TM.Ngay = DateTime.Parse(node.Property("Ngay").Value.ToString());

                try
                {
                    dDC.TM.TCBCTapTrung = decimal.Parse(node.Property("TCBCTapTrung").Value.ToString());
                }
                catch { dDC.TM.TCBCTapTrung = 0; }
                try
                {
                    dDC.TM.TCBCThanhToanTaiDonVi = decimal.Parse(node.Property("TCBCThanhToanTaiDonVi").Value.ToString());
                }
                catch { dDC.TM.TCBCThanhToanTaiDonVi = 0; }
                try
                {
                    dDC.TM.TKBD = decimal.Parse(node.Property("TKBD").Value.ToString());
                }
                catch { dDC.TM.TKBD = 0; }
                try
                {
                    dDC.TM.KinhDoanh = decimal.Parse(node.Property("KinhDoanh").Value.ToString());
                }
                catch { dDC.TM.KinhDoanh = 0; }
                try
                {
                    dDC.TM.Cong = decimal.Parse(node.Property("Cong").Value.ToString());
                }
                catch { dDC.TM.Cong = 0; }

                dDC.ThemSua();
            }

            grdSoDuTMCuoiNgay.GetStore().GetById(id).Commit();
        }

        protected void btnInTonQuy_Click(object sender, DirectEventArgs e)
        {
            daBaoCaoSoDu dBCSD = new daBaoCaoSoDu();
            crTonQuyCuoiNgay rptTonQuy = new crTonQuyCuoiNgay();
            rptTonQuy.SetDataSource(dBCSD.TonQuyCuoiNgay(UIHelper.daPhien.MaDonVi, NgayThang));

            daSoDuCuoiNgay dSDCK = new daSoDuCuoiNgay();
            dSDCK.ThongTinBuuCuc(UIHelper.daPhien.MaDonVi);

            rptTonQuy.SetParameterValue(0, dSDCK.BuuCuc.DonVi);
            rptTonQuy.SetParameterValue(1, dSDCK.BuuCuc.BuuCuc);
            rptTonQuy.SetParameterValue(2, "Ngày " + NgayThang.ToString("dd/MM/yyyy"));
            rptTonQuy.SetParameterValue(3, 1);

            string _tf;
            _tf = UIHelper.daPhien.TenFileInBaoCao("TonQuyCuoiNgay");
            rptTonQuy.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("~") + _tf);
            string _url = UIHelper.daPhien.LayDiaChiURL(_tf);

            string script = "window.open('" + _url + "', '')";
            this.btnInTonQuy.AddScript(script);
        }
        #endregion
    }
}