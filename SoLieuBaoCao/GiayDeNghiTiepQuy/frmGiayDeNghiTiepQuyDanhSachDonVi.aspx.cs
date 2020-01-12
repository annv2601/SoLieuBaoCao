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
using BaoBieu.GiayDeNghi;
using Ext.Net;

namespace SoLieuBaoCao.GiayDeNghiTiepQuy
{
    public partial class frmGiayDeNghiTiepQuyDanhSachDonVi : System.Web.UI.Page
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
            
            stoGDNTQuy.DataSource = dGDN.DanhSach(NgayThang, NgayThang);
            stoGDNTQuy.DataBind();
            grdGDNTQuy.Title = "DANH SÁCH GIẤY ĐỀ NGHỊ TIẾP QUỸ CỦA CÁC ĐƠN VỊ TRONG NGÀY " + NgayThang.ToString("dd/MM/yyyy");
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

        protected void btnTongHop_Click(object sender, DirectEventArgs e)
        {
            /*daGiayDeNghi dGiay = new daGiayDeNghi();
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

            HienThiNhap();*/
        }
               
        protected void InAn_Click(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesGDN"];
            if (json == "")
            {
                return;
            }

            daSoDuCuoiNgay dSDCK = new daSoDuCuoiNgay();
            daGiayDeNghi dGDN = new daGiayDeNghi();
            dGDN.GDN.MaKeToanNgay = json;

            crGiayDeNghiTiepQuy rptGDN = new crGiayDeNghiTiepQuy();
            rptGDN.SetDataSource(dGDN.InPhieu());

            dSDCK.ThongTinBuuCuc(UIHelper.daPhien.MaDonVi);
            rptGDN.SetParameterValue(0, dSDCK.BuuCuc.DonVi);
            rptGDN.SetParameterValue(1, dSDCK.BuuCuc.BuuCuc);
            rptGDN.SetParameterValue(2, dSDCK.BuuCuc.TenTat);
            string _tf;
            _tf = UIHelper.daPhien.TenFileInBaoCao("GiayDeNghiTiepQuy");
            rptGDN.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("..") + _tf);
            string _url = UIHelper.daPhien.LayDiaChiURL(_tf);

            string script = "window.open('" + _url + "', '')";
            this.btnThangSau.AddScript(script);

        }

        protected void grdGDNTQuy_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesCTSTK"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _url = "";
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    _url = row["urlAnhBanIn"];
                }
                catch
                {
                    _url = "";
                }
            }
            if (_url != "")
            {
                ucAnhBKy1.MaKeToan = "";
                ucAnhBKy1.HienThiAnh(_url);
                wAnhBanKy.Show();
            }
        }
        #endregion
    }
}