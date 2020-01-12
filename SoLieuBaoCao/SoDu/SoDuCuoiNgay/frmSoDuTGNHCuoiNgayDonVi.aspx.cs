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
using Ext.Net;

namespace SoLieuBaoCao.SoDu.SoDuCuoiNgay
{
    public partial class frmSoDuTGNHCuoiNgayDonVi : System.Web.UI.Page
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
            DaDuCuoiTGNH dTGNH = new DaDuCuoiTGNH();

            stoSoDuTGNHCuoiNgay.DataSource = dTGNH.DanhSachDonVi(UIHelper.daPhien.MaDonVi, NgayThang);
            stoSoDuTGNHCuoiNgay.DataBind();

            grdSoDuTGNHCuoiNgay.Title = "DANH SÁCH SỐ DƯ TIỀN MẶT CÁC ĐƠN VỊ TRỰC THUỘC NGÀY " + NgayThang.ToString("dd/MM/yyyy");
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

            DaDuCuoiTGNH dTGNH = new DaDuCuoiTGNH();
            dTGNH.TGNH.MaKeToanNgay = node.Property("MaKeToanNgay").Value.ToString();
            dTGNH.TGNH.MaBuuCuc = node.Property("MaBuuCuc").Value.ToString();
            dTGNH.TGNH.Ngay = NgayThang;

            try
            {
                dTGNH.TGNH.TCBCTapTrung = decimal.Parse(node.Property("TCBCTapTrung").Value.ToString());
            }
            catch { dTGNH.TGNH.TCBCTapTrung = 0; }
            try
            {
                dTGNH.TGNH.TCBCThanhToanTaiDonVi = decimal.Parse(node.Property("TCBCThanhToanTaiDonVi").Value.ToString());
            }
            catch { dTGNH.TGNH.TCBCThanhToanTaiDonVi = 0; }
            try
            {
                dTGNH.TGNH.TKBD = decimal.Parse(node.Property("TKBD").Value.ToString());
            }
            catch { dTGNH.TGNH.TKBD = 0; }
            try
            {
                dTGNH.TGNH.KinhDoanh = decimal.Parse(node.Property("KinhDoanh").Value.ToString());
            }
            catch { dTGNH.TGNH.KinhDoanh = 0; }
            try
            {
                dTGNH.TGNH.Cong = decimal.Parse(node.Property("Cong").Value.ToString());
            }
            catch { dTGNH.TGNH.Cong = 0; }

            dTGNH.Them();

            grdSoDuTGNHCuoiNgay.GetStore().GetById(id).Commit();
        }
        #endregion
    }
}