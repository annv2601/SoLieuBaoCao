using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using daoKeToanSoDu.Bieu02TQ;
using daoKeToanSoDu;
using BaoBieu.GiayDeNghi;
using BaoBieu;
using Ext.Net;

namespace SoLieuBaoCao.GiayDeNghiTiepQuy
{
    public partial class frmBieu02TQDanhSach : System.Web.UI.Page
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
            daBieu02TQ dB = new daBieu02TQ();
            dB.B02.Ngay = txtNgayTongHop.SelectedDate;
            dB.B02.MaDonVi = UIHelper.daPhien.MaDonVi;
            if(dB.ThongTin()==null)
            {
                dB.B02.LoaiBaoCao = (int)daBieu02TQ.eLoaiBaoCao.B02TQ;
                dB.B02.TieuDeBaoCao = "TỔNG HỢP NHU CẦU THU VÀ TIẾP QUỸ TẠI CÁC ĐƠN VỊ THUỘC TỈNH";
                dB.Them();

                dB.DuLieu.B02DLieu.IDBieuBaoCao = dB.B02.ID;
                dB.DuLieu.TongHopSoLieu(dB.B02.Ngay.Value.AddDays(-1));
            }
            dB.DuLieu.B02DLieu.IDBieuBaoCao = dB.B02.ID;
            stoB02.DataSource = dB.DuLieu.BaoCao();
            stoB02.DataBind();

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

        protected void DanhSachB02TQ(object sender, StoreReadDataEventArgs e)
        {
            HienThiNhap();
        }

        protected void btnTongHop_Click(object sender, DirectEventArgs e)
        {
            daBieu02TQ dB = new daBieu02TQ();
            dB.B02.Ngay = txtNgayTongHop.SelectedDate;
            dB.B02.MaDonVi = UIHelper.daPhien.MaDonVi;
            if (dB.ThongTin() == null)
            {
                dB.B02.LoaiBaoCao = (int)daBieu02TQ.eLoaiBaoCao.B02TQ;
                dB.B02.TieuDeBaoCao = "TỔNG HỢP NHU CẦU THU VÀ TIẾP QUỸ TẠI CÁC ĐƠN VỊ THUỘC TỈNH";
                dB.Them();
            }

            dB.DuLieu.B02DLieu.IDBieuBaoCao = dB.B02.ID;
            dB.DuLieu.TongHopSoLieu(dB.B02.Ngay.Value.AddDays(-1));

            X.Msg.Alert("Hoàn thành", "Anh/Chị đã tổng hợp báo cáo 02-TQ cho ngày "+dB.B02.Ngay.Value.ToString("dd/MM/yyyy")).Show();

            stoB02.DataSource = dB.DuLieu.BaoCao();
            stoB02.DataBind();
        }

        protected void btnInAn_Click(object sender, DirectEventArgs e)
        {
            daBieu02TQ dB = new daBieu02TQ();
            dB.B02.Ngay = txtNgayTongHop.SelectedDate;
            dB.B02.MaDonVi = UIHelper.daPhien.MaDonVi;
            if (dB.ThongTin() == null)
            {
                X.Msg.Alert("","Báo cáo ngày "+ dB.B02.Ngay.Value.ToString("dd/MM/yyyy")+" chưa được lập!").Show();
                return;
            }

            crBieu02TQ rptBieu02 = new crBieu02TQ();
            dB.DuLieu.B02DLieu.IDBieuBaoCao = dB.B02.ID;
            rptBieu02.SetDataSource(dB.DuLieu.BaoCao());

            rptBieu02.SetParameterValue(0, UIHelper.daPhien.TenNguoiSuDung);
            rptBieu02.SetParameterValue(1, dB.B02.TieuDeBaoCao);
            DateTime _na = dB.B02.Ngay.Value;
            rptBieu02.SetParameterValue(2, "Ngày " + _na.Day.ToString() + " tháng " + _na.Month.ToString() + " năm " + _na.Year.ToString());

            string _tf;
            _tf = UIHelper.daPhien.TenFileInBaoCao("NhuCauTiepQuyTinh");
            rptBieu02.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("..") + _tf);
            string _url = UIHelper.daPhien.LayDiaChiURL(_tf);

            string script = "window.open('" + _url + "', '')";
            this.btnInAn.AddScript(script);
        }

        protected void btnXuatExcel_Click(object sender, DirectEventArgs e)
        {
            daBieu02TQ dB = new daBieu02TQ();
            dB.B02.Ngay = txtNgayTongHop.SelectedDate;
            dB.B02.MaDonVi = UIHelper.daPhien.MaDonVi;
            if (dB.ThongTin() == null)
            {
                X.Msg.Alert("", "Báo cáo ngày " + dB.B02.Ngay.Value.ToString("dd/MM/yyyy") + " chưa được lập!").Show();
                return;
            }
            DataTable dt;
            dB.DuLieu.B02DLieu.IDBieuBaoCao = dB.B02.ID;
            dt = dB.DuLieu.BaoCao();
            try
            {
                dt.Columns.Remove("MaDonVi");
                dt.Columns.Remove("InDam");
                dt.Columns.Remove("InNghieng");
                dt.Columns.Remove("STTsx");
            }
            catch { }

            daXuatExcel dXuatE = new daXuatExcel();
            dXuatE.TenFileExcel = "NhuCauTiepQuyTinh" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".xls";
            dXuatE.DuongDan = Server.MapPath("..");

            dXuatE.TenFileMau = dXuatE.DuongDan + "\\Resource\\FileMauExcel\\Mau02TQ.xls";

            dXuatE.DuLieu = dt;
            dXuatE.TenDonVi = UIHelper.daPhien.TenNguoiSuDung;
            dXuatE.NgayHienThi = "Ngày " + dB.B02.Ngay.Value.ToString("dd/MM/yyyy");

            string _url = UIHelper.daPhien.LayDiaChiURL(dXuatE.XuatFileExcel_TheoMau());
            Response.Redirect(_url);
        }
        #endregion
    }
}