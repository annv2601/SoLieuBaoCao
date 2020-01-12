using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoKeToanSoDu.DinhMucLuuQuy;
using daoKeToanSoDu;
using Ext.Net;

namespace SoLieuBaoCao.SoDu.DinhMucLuuQuy
{
    public partial class frmDinhMucLuuQuy : System.Web.UI.Page
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
            daDinhMucLuuQuy dDMLQ = new daDinhMucLuuQuy();
            stoDinhMucLuuQuy.DataSource = dDMLQ.DanhSach(UIHelper.daPhien.MaDonVi, DateTime.Now);
            stoDinhMucLuuQuy.DataBind();
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

        [DirectMethod(Namespace = "BangNhapDMLQX")]
        public void Edit(int id, string field, string oldvalue, string newvalue, object BangSD)
        {
            Newtonsoft.Json.Linq.JObject node = JSON.Deserialize<Newtonsoft.Json.Linq.JObject>(BangSD.ToString());

            daDinhMucLuuQuy dDMLQ = new daDinhMucLuuQuy();
            dDMLQ.DMuc.MaBuuCuc = node.Property("MaBuuCuc").Value.ToString();
            dDMLQ.DMuc.GhiChu = node.Property("GhiChu").Value.ToString();

            try
            {
                dDMLQ.DMuc.DinhMucLuuQuyTCBC = decimal.Parse(node.Property("DinhMucLuuQuyTCBC").Value.ToString());
            }
            catch { dDMLQ.DMuc.DinhMucLuuQuyTCBC = 0; }
            try
            {
                dDMLQ.DMuc.DinhMucLuuQuyTCBC_DonVi = decimal.Parse(node.Property("DinhMucLuuQuyTCBC_DonVi").Value.ToString());
            }
            catch { dDMLQ.DMuc.DinhMucLuuQuyTCBC_DonVi = 0; }
            try
            {
                dDMLQ.DMuc.DinhMucLuuQuyTKBD = decimal.Parse(node.Property("DinhMucLuuQuyTKBD").Value.ToString());
            }
            catch { dDMLQ.DMuc.DinhMucLuuQuyTKBD = 0; }
            try
            {
                dDMLQ.DMuc.DinhMucLuuQuyTKBD_DonVi = decimal.Parse(node.Property("DinhMucLuuQuyTKBD_DonVi").Value.ToString());
            }
            catch { dDMLQ.DMuc.DinhMucLuuQuyTKBD_DonVi = 0; }


            dDMLQ.ThemSua(true);


            grdDinhMucLuuQuy.GetStore().GetById(id).Commit();
        }
        #endregion
    }
}