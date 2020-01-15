using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoKeToanSoDu.Bieu02TQ;
using daoKeToanSoDu;
using BaoBieu.GiayDeNghi;
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

        }
        #endregion
    }
}