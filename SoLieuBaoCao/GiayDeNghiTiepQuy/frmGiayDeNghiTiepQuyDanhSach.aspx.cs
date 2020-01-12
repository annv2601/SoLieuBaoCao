using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoKeToanSoDu.GiayDeNghi;
using daoKeToanSoDu.NganHang;
using daoKeToanSoDu.KeToanSoDu;
using daoKeToanSoDu;
using Ext.Net;

namespace SoLieuBaoCao.GiayDeNghiTiepQuy
{
    public partial class frmGiayDeNghiTiepQuyDanhSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                if (UIHelper.daPhien.DaDangNhap)
                {
                    NgayThang = DateTime.Now;
                    txtNgayTongHop.Value = DateTime.Now;
                    HienThiNhap();
                    
                }
                else
                {
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
            daGiayDeNghi dGDN = new daGiayDeNghi();
            DateTime _tungay, _denngay, _ngayhtai;
            _ngayhtai = DateTime.Now;
            _tungay = daTienIch.NgayDauThang(NgayThang);
            _denngay = daTienIch.NgayCuoiThang(NgayThang);
            if (_ngayhtai < _tungay)
            {
                return;
            }
            if (_denngay > _ngayhtai)
            {
                _denngay = _ngayhtai;
            }

            stoGDNTQuy.DataSource = dGDN.DanhSach(UIHelper.daPhien.MaDonVi, _tungay, _denngay);
            stoGDNTQuy.DataBind();
            grdGDNTQuy.Title = "DANH SÁCH GIẤY ĐỀ NGHỊ TRONG THÁNG " + _tungay.Month.ToString() + " NĂM " + _tungay.Year.ToString();
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

        protected void btnTongHop_Click(object sender, DirectEventArgs e)
        {
            daGiayDeNghi dGiay = new daGiayDeNghi();
            daNganHang dNH = new daNganHang();
            dNH.NHang.MaDonVi = UIHelper.daPhien.MaDonVi;
            dNH.NHang.IDNhom = (int)daNganHang.eNhomNganHang.NH_Đề_Nghị_Tiếp_Quỹ;
            if (dNH.ThongTin() == null)
            {
                X.Msg.Alert("Thiếu thông tin","Chưa khai thông tin Ngân hàng").Show();
                return;
            }

            dGiay.GDN.MaDonVi = UIHelper.daPhien.MaDonVi;
            dGiay.GDN.Ngay = txtNgayTongHop.SelectedDate;
            dGiay.GDN.IDNganHang = dNH.NHang.ID;

            dGiay.GDN.NoiDung = "V/v đề nghị tiếp quỹ TCBC Ngày" + txtNgayTongHop.SelectedDate.AddDays(1).ToString("dd/MM/yyyy");
            daSoDuCuoiNgay dSDCK = new daSoDuCuoiNgay();
            if (dSDCK.ThongTinBuuCuc(UIHelper.daPhien.MaDonVi) != null)
            {
                dGiay.GDN.TrinhDonVi = "Giám đốc " + dSDCK.BuuCuc.DonVi;
            }
            dGiay.GDN.NoiLuuVB = "Kế toán";

            dGiay.TongHop();

            string _makt;
            _makt = dGiay.GDN.MaDonVi+ dGiay.GDN.Ngay.Value.ToString("yyyyMMdd");
            dGiay.GDN.MaKeToanNgay = _makt;
            dGiay.ThongTin();

            DocSo.DocSo ds = new DocSo.DocSo();
            _makt = ds.DocSoDayDu(dGiay.GDN.SoTienDeNghi.ToString()) + " đồng";
            _makt = _makt.Trim();
            _makt = _makt.Replace("  ", " ");
            _makt = _makt.Substring(0, 1).ToUpper() + _makt.Substring(1,_makt.Length-1);
            dGiay.GDN.BangChu = _makt;
            dGiay.CapNhatBangChu();

            X.Msg.Alert("Hoàn thành", "Anh/Chị đã lập Giấy đề nghị Tiếp quỹ xong cho ngày "+dGiay.GDN.Ngay.Value.ToString("dd/MM/yyyy")).Show();

            HienThiNhap();
        }

        protected void btnNganHang_Click(object sender, DirectEventArgs e)
        {
            daNganHang dNH = new daNganHang();
            dNH.NHang.MaDonVi = UIHelper.daPhien.MaDonVi;
            dNH.NHang.IDNhom = (int)daNganHang.eNhomNganHang.NH_Đề_Nghị_Tiếp_Quỹ;
            if(dNH.ThongTin()!=null)
            {
                ucNganHang1.TenNganHang = dNH.NHang.NganHang;
                ucNganHang1.TenPhongGD = dNH.NHang.PhongGiaoDich;
                ucNganHang1.SoTaikhoan = dNH.NHang.SoTaiKhoan;
                ucNganHang1.TenDonViHuong = dNH.NHang.TenDonViHuong;
            }

            wNganHang.Show();
        }

        protected void btnCapNhatNH_Click(object sender, DirectEventArgs e)
        {
            daNganHang dNH = new daNganHang();
            dNH.NHang.ID = ucNganHang1.IDNganHang;
            dNH.NHang.MaDonVi = UIHelper.daPhien.MaDonVi;
            dNH.NHang.IDNhom = (int)daNganHang.eNhomNganHang.NH_Đề_Nghị_Tiếp_Quỹ;
            dNH.NHang.NganHang = ucNganHang1.TenNganHang;
            dNH.NHang.PhongGiaoDich = ucNganHang1.TenPhongGD;
            dNH.NHang.SoTaiKhoan = ucNganHang1.SoTaikhoan;
            dNH.NHang.TenDonViHuong = ucNganHang1.TenDonViHuong;

            dNH.ThemSua();
            X.Msg.Alert("","Đã cập nhật thông tin Ngân hàng!").Show();
        }

        protected void InAn_Click(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesGDN"];
            if (json == "")
            {
                return;
            }

            /*daDuCuoiTienMat dDCTM = new daDuCuoiTienMat();
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
            if (dDCTM.ThongTin() != null)
            {
                pt.TongSoDuTien = dDCTM.TM.Cong;
                pt.SoDuTienMat = dDCTM.TM.TCBCTapTrung;
                pt.SoDuTienMatTaiBuuCuc = dDCTM.TM.TCBCThanhToanTaiDonVi;
                pt.SoDuTienMatTaiBDH = dDCTM.TM.TKBD;
                pt.SoDuTienDangChuyen = dDCTM.TM.KinhDoanh;
            }

            dDK.DKCTra.MaKeToanNgay = json;
            if (dDK.ThongTin() != null)
            {
                pt.dkctBangTienMat = dDK.DKCTra.Cong;
                pt.DuKienChiTra = dDK.DKCTra.Cong;
            }

            pt.SoTienDeNghi = pt.DuKienChiTra - pt.TongSoDuTien;
            if (pt.SoTienDeNghi < 0)
            {
                pt.SoTienDeNghi = 0;
            }

            DocSo.DocSo ds = new DocSo.DocSo();
            pt.BangChu = ds.DocSoDayDu(pt.SoTienDeNghi.ToString()) + " đồng";
            pt.Ngay = DateTime.Parse(json.Substring(10, 2) + "/" + json.Substring(12, 2) + "/" + json.Substring(6, 4));
            pt.NoiDung = "V/v đề nghị tiếp quỹ TCBC Ngày " + pt.Ngay.Value.AddDays(1).ToString("dd/MM/yyyy");
            pt.NoiLuuVB = "Bưu cục";

            daSoDuCuoiNgay dSDCK = new daSoDuCuoiNgay();
            if (dSDCK.ThongTinBuuCuc(UIHelper.daPhien.MaDonVi) != null)
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
            this.btnThangSau.AddScript(script);*/

        }
        #endregion
    }
}