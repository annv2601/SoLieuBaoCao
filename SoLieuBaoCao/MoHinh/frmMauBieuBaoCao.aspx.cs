using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.DanhMuc;
using Ext.Net;
using SoLieuBaoCao.UIHelper;

namespace SoLieuBaoCao.MoHinh
{
    public partial class frmMauBieuBaoCao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest && UIHelper.daPhien.DaDangNhap)
            {
                DanhSachmauBieu();
            }
        }

        #region Rieng
        private void DanhSachmauBieu()
        {
            daMauBieu dMB = new daMauBieu();
            stoMauBieu.DataSource = dMB.DanhSach();
            stoMauBieu.DataBind();
        }
        #endregion

        #region Su kien
        protected void txtThemMauBieuMoi_Click(object sender, DirectEventArgs e)
        {
            ucMauBieu1.KhoiTao();
            wMauBieu.Show();
        }

        protected void grdMauBieu_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesMB"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    ucMauBieu1.IDMauBieuBaoCao = int.Parse(row["ID"].ToString());
                    ucMauBieu1.Ma = row["Ma"].ToString();
                    ucMauBieu1.Ten = row["Ten"].ToString();
                    ucMauBieu1.TenTat = row["TenTat"].ToString();
                    ucMauBieu1.TieuDe1 = row["TieuDe1"].ToString();
                    ucMauBieu1.TieuDe2 = row["TieuDe2"].ToString();
                    ucMauBieu1.TieuDe3 = row["TieuDe3"].ToString();
                    ucMauBieu1.Muc = int.Parse(row["Muc"].ToString());
                    ucMauBieu1.Cap = int.Parse(row["Cap"].ToString());
                    ucMauBieu1.Nhom = int.Parse(row["Nhom"].ToString());
                    ucMauBieu1.NgayApDung = DateTime.Parse(row["NgayApDung"].ToString());
                    ucMauBieu1.NgayKetThuc = DateTime.Parse(row["NgayKetThuc"].ToString());
                    ucMauBieu1.GhiChu = row["GhiChu"].ToString();
                }
                catch
                {
                    ucMauBieu1.IDMauBieuBaoCao = 0;
                }
            }
            if (ucMauBieu1.IDMauBieuBaoCao == 0)
            {
                X.Msg.Alert("", "ANh/chị hãy chọn mẫu biểu!").Show();
                return;
            }
            else
            {
                wMauBieu.Show();
            }
        }

        protected void btnCapNhat_Click(object sender, DirectEventArgs e)
        {
            daMauBieu dMB = new daMauBieu();
            dMB.MB.ID = ucMauBieu1.IDMauBieuBaoCao;
            dMB.MB.Ma = ucMauBieu1.Ma;
            dMB.MB.Ten = ucMauBieu1.Ten;
            dMB.MB.TenTat = ucMauBieu1.TenTat;
            dMB.MB.TieuDe1 = ucMauBieu1.TieuDe1;
            dMB.MB.TieuDe2 = ucMauBieu1.TieuDe2;
            dMB.MB.TieuDe3 = ucMauBieu1.TieuDe3;
            dMB.MB.Muc = ucMauBieu1.Muc;
            dMB.MB.Cap = ucMauBieu1.Cap;
            dMB.MB.Nhom = ucMauBieu1.Nhom;
            dMB.MB.NgayApDung = ucMauBieu1.NgayApDung;
            dMB.MB.NgayKetThuc = ucMauBieu1.NgayKetThuc;
            dMB.MB.GhiChu = ucMauBieu1.GhiChu;
            dMB.MB.NguoiTao = daPhien.MaNSD + ":" + daPhien.TenNguoiSuDung;

            dMB.ThemSua();
            DanhSachmauBieu();
            wMauBieu.Hide();
        }
        #endregion
    }
}