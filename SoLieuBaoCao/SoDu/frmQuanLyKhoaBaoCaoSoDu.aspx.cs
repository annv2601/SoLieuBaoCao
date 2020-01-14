using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.HeThong;
using daoKeToanSoDu.SoDuCuoiNgay;
using Ext.Net;

namespace SoLieuBaoCao.SoDu
{
    public partial class frmQuanLyKhoaBaoCaoSoDu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                txtNgay.SelectedDate = DateTime.Now;
                DanhSachDonVi();
            }
        }

        #region Ham
        private void DanhSachDonVi()
        {
            daDangNhap dDN = new daDangNhap();
            stoDonVi.DataSource = dDN.DanhSachDonVi();
            stoDonVi.DataBind();
        }
        #endregion

        #region Su kien
        protected void DanhSachTrangThaiKhoa(object sender, StoreReadDataEventArgs e)
        {
            if(slbDonVi.SelectedItem.Value==null)
            {
                return;
            }
            daDuCuoiTienMat dDCTM = new daDuCuoiTienMat();
            stoKhoaSoDuTMCuoiNgay.DataSource = dDCTM.DanhSachDonVi(slbDonVi.SelectedItem.Value, txtNgay.SelectedDate);
            stoKhoaSoDuTMCuoiNgay.DataBind();
        }

        [DirectMethod(Namespace = "BangNhapKhoaX")]
        public void Edit(int id, string field, string oldvalue, string newvalue, object BangSD)
        {
            daDuCuoiTienMat dDCTM = new daDuCuoiTienMat();
            Newtonsoft.Json.Linq.JObject node = JSON.Deserialize<Newtonsoft.Json.Linq.JObject>(BangSD.ToString());
            dDCTM.TM.MaKeToanNgay = node.Property("MaKeToanNgay").Value.ToString();
            dDCTM.TM.Khoa = bool.Parse(newvalue);
            dDCTM.TM.NguoiKhoa = UIHelper.daPhien.TenNguoiSuDung;

            dDCTM.KhoaMo();
            stoKhoaSoDuTMCuoiNgay.Reload();
        }
            #endregion
    }
}