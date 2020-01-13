using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoKeToanSoDu.SoDuCuoiNgay;
using daoKeToanSoDu.KeToanSoDu;
using daoKeToanSoDu.PhatSinhGiam;
using daoKeToanSoDu.Database;
using daoKeToanSoDu;
using daoKeToanSoDu.BaoCao;
using BaoBieu.SoDu;
using BaoBieu.GiayDeNghi;
using Ext.Net;

namespace SoLieuBaoCao.SoDu.SoDuCuoiNgay
{
    public partial class frmSoDuTienmatCuoiNgay : System.Web.UI.Page
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
                    btnThangTruoc.Visible = false;
                    btnThangSau.Visible = false;
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
            DateTime _tungay, _denngay, _ngayhtai;
            _ngayhtai = DateTime.Now;
            _tungay = daTienIch.NgayDauThang(NgayThang);
            _denngay = daTienIch.NgayCuoiThang(NgayThang);
            if (_ngayhtai<_tungay)
            {
                return;
            }
            if(_denngay>_ngayhtai)
            {
                _denngay = _ngayhtai;
            }

            stoSoDuTMCuoiNgay.DataSource = dSD.DanhSachNhap(UIHelper.daPhien.MaDonVi, _tungay, _denngay);
            stoSoDuTMCuoiNgay.DataBind();

            grdSoDuTMCuoiNgay.Title = "DANH SÁCH SỐ DƯ TIỀN MẶT THÁNG " + _tungay.Month.ToString() + " NĂM " + _tungay.Year.ToString();
        }
        #endregion

        #region Su kien
        protected void btnThangTruoc_Click(object sender, DirectEventArgs e)
        {
            NgayThang = NgayThang.AddMonths(-1);
            HienThiNhap();
        }

        protected void btnThangSau_Click(object sender, DirectEventArgs e)
        {
            NgayThang = NgayThang.AddMonths(1);
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
                dDKCT.DKCTra.Ngay = DateTime.Parse(node.Property("Ngay").Value.ToString());

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

        protected void InAn_Click(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesDCN"];
            if (json == "")
            {
                return;
            }

            daDuCuoiTienMat dDCTM = new daDuCuoiTienMat();
            daDuKienChiTra dDK = new daDuKienChiTra();

            sp_tblGiayDeNghiTiepQuy_DanhSachResult pt = new sp_tblGiayDeNghiTiepQuy_DanhSachResult();
            pt.TongSoDuTien = 0;
            pt.SoDuTienMat = 0;
            pt.SoDuTienMatTaiBuuCuc = 0;
            pt.SoDuTienMatTaiBDH = 0;
            pt.SoDuTienDangChuyen = 0;
            pt.dkctBangTienMat = 0;
            pt.DuKienChiTra = 0;
            pt.SoTienQuyKhacVay = 0;
            pt.SoTienVayQuyKhac = 0;
            dDCTM.TM.MaKeToanNgay = json;
            if(dDCTM.ThongTin()!=null)
            {
                pt.TongSoDuTien = dDCTM.TM.Cong;
                pt.SoDuTienMat = dDCTM.TM.TCBCTapTrung;
                pt.SoDuTienMatTaiBuuCuc = dDCTM.TM.TCBCThanhToanTaiDonVi;
                pt.SoDuTienMatTaiBDH = dDCTM.TM.TKBD;
                pt.SoDuTienDangChuyen = dDCTM.TM.KinhDoanh;
            }

            dDK.DKCTra.MaKeToanNgay = json;
            if(dDK.ThongTin()!=null)
            {
                pt.dkctBangTienMat = dDK.DKCTra.Cong;
                pt.DuKienChiTra = dDK.DKCTra.Cong;
            }

            pt.SoTienDeNghi = pt.DuKienChiTra - pt.TongSoDuTien;
            if(pt.SoTienDeNghi<0)
            {
                pt.SoTienDeNghi = 0;
            }

            pt.SoTienDeNghi = Math.Round((pt.SoTienDeNghi.Value) / 1000000, 0) * 1000000;

            DocSo.DocSo ds = new DocSo.DocSo();
            pt.BangChu = ds.DocSoDayDu(pt.SoTienDeNghi.ToString()) + " đồng";
            pt.Ngay = DateTime.Parse(json.Substring(10, 2) + "/" + json.Substring(12, 2) + "/" + json.Substring(6, 4));
            pt.NoiDung = "V/v đề nghị tiếp quỹ TCBC Ngày " + pt.Ngay.Value.AddDays(1).ToString("dd/MM/yyyy");
            pt.NoiLuuVB = "Bưu cục";
            
            daSoDuCuoiNgay dSDCK = new daSoDuCuoiNgay();
            if(dSDCK.ThongTinBuuCuc(UIHelper.daPhien.MaDonVi)!=null)
            {
                pt.TrinhDonVi = "Giám đốc " + dSDCK.BuuCuc.DonVi;
            }
            List<sp_tblGiayDeNghiTiepQuy_DanhSachResult> lstBC = new List<sp_tblGiayDeNghiTiepQuy_DanhSachResult>();
            lstBC.Add(pt);

            crGiayDeNghiTiepQuyBuuCuc rptGDN = new crGiayDeNghiTiepQuyBuuCuc();
            rptGDN.SetDataSource(daTienIch.ToDataTable(lstBC));

            rptGDN.SetParameterValue(0, dSDCK.BuuCuc.DonVi);
            rptGDN.SetParameterValue(1, dSDCK.BuuCuc.BuuCuc);
            rptGDN.SetParameterValue(2, dSDCK.BuuCuc.TenTat);
            string _tf;
            _tf = UIHelper.daPhien.TenFileInBaoCao("GiayDeNghiTiepQuy");
            rptGDN.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("~") + _tf);      
            string _url = UIHelper.daPhien.LayDiaChiURL(_tf);

            string script = "window.open('" + _url + "', '')";
            this.btnThangSau.AddScript(script);

            /*crBieuNhapBaoCaoNhanhDonVi rptBCN = new crBieuNhapBaoCaoNhanhDonVi();
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

            string script = "window.open('" + _url + "', '')";
            this.btnIn.AddScript(script);*/
        }

        protected void mnuitemInTonQuy_Click(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesSDTM"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _makt = "";
            DateTime _ngay=DateTime.Now;
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    _makt = row["MaKeToanNgay"];
                    _ngay = DateTime.Parse(row["Ngay"]);
                }
                catch
                {
                    _makt = "";
                }
            }
            if (_makt!="")
            {
                daBaoCaoSoDu dBCSD = new daBaoCaoSoDu();
                crTonQuyCuoiNgay rptTonQuy = new crTonQuyCuoiNgay();
                rptTonQuy.SetDataSource(dBCSD.TonQuyCuoiNgayBuuCuc(UIHelper.daPhien.MaDonVi, _ngay));

                daSoDuCuoiNgay dSDCK = new daSoDuCuoiNgay();
                dSDCK.ThongTinBuuCuc(UIHelper.daPhien.MaDonVi);

                rptTonQuy.SetParameterValue(0, dSDCK.BuuCuc.DonVi);
                rptTonQuy.SetParameterValue(1, dSDCK.BuuCuc.BuuCuc);
                rptTonQuy.SetParameterValue(2, "Ngày " + _ngay.ToString("dd/MM/yyyy"));
                rptTonQuy.SetParameterValue(3, 2);

                string _tf;
                _tf = UIHelper.daPhien.TenFileInBaoCao("TonQuyCuoiNgayBC");
                rptTonQuy.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("~") + _tf);
                string _url = UIHelper.daPhien.LayDiaChiURL(_tf);

                string script = "window.open('" + _url + "', '')";
                this.btnThangTruoc.AddScript(script);
            }
            
        }
        #endregion
    }
}