using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using daoSLTH.KhachHang;
using Ext.Net;

namespace SoLieuBaoCao.DoanhThuKhachHang
{
    public partial class frmKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                DanhSachNhom();
                txtMaDonVi.Text = "1100";
            }
        }

        #region Rieng
        private void DanhSachNhom()
        {
            daKhachHang dKH = new daKhachHang();
            stoNhom.DataSource = dKH.DanhSachDanhMuc();
            stoNhom.DataBind();

            slbNhom.SelectedItem.Index = 0;
        }

        private void DanhSachKhachHang(DateTime rTuNgay, DateTime rDenNgay)
        {
            daKhachHang dKH = new daKhachHang();
            dKH.KH.Nhom = slbNhom.SelectedItem.Value;
            dKH.MaDonVi = txtMaDonVi.Text.Trim();
            dKH.TuNgay = rTuNgay;
            dKH.DenNgay = rDenNgay;

            stoKhachHang.DataSource = dKH.DanhSach();
            stoKhachHang.DataBind();
        }
        #endregion

        #region Su kien
        protected void btnTuDauTuan_Click(object sender, EventArgs e)
        {
            DateTime rNgay = DateTime.Now;
            DanhSachKhachHang(UIHelper.daPhien.NgayDauTuan(rNgay), rNgay);
        }

        protected void btnTuDauThang_Click(object sender, EventArgs e)
        {
            DateTime rNgay = DateTime.Now;
            DanhSachKhachHang(UIHelper.daPhien.NgayDauThang(rNgay), rNgay);
        }

        protected void btnTuDauNam_Click(object sender, EventArgs e)
        {
            DateTime rNgay = DateTime.Now;
            DanhSachKhachHang(UIHelper.daPhien.NgayDauNam(rNgay), rNgay);
        }


        protected Field OnCreateFilterableField(object sender, ColumnBase column, Field defaultField)
        {
            if (column.DataIndex == "Id")
            {
                ((TextField)defaultField).Icon = Icon.Magnifier;
            }

            return defaultField;
        }

        [DirectMethod(Namespace = "BangKHX")]
        public void Edit(int id, string field, string oldvalue, string newvalue, object BangKH)
        {
            daKhachHang dKH = new daKhachHang();
            Newtonsoft.Json.Linq.JObject node = JSON.Deserialize<Newtonsoft.Json.Linq.JObject>(BangKH.ToString());

            dKH.KH.MaBuuCuc= node.Property("MaBuuCuc").Value.ToString();
            dKH.KH.MaKhachHang= node.Property("MaKhachHang").Value.ToString();

            try
            {                
                dKH.KH.NgayPhatSinhDoanhThu = DateTime.Parse(node.Property("NgayPhatSinhDoanhThu").Value.ToString());
                dKH.CapNhatNgay();
                grdKhachHang.GetStore().GetById(id).Commit();
            }
            catch
            {
                X.Msg.Alert("","Nhập sai định dạng ngày!").Show();
                grdKhachHang.GetStore().GetById(id).Reject();
            }
        }
        #endregion
    }
}