using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoLieuBaoCao.MoHinh
{
    public partial class ucBieuBaoCao : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Thuoc tinh
        public int IDMauBieuBaoCao
        {
            get
            {
                return int.Parse(txtID.Text);
            }
            set
            {
                txtID.Text = value.ToString();
            }
        }

        public string Ma
        {
            get { return txtMa.Text.Trim(); }
            set { txtMa.Text = value; }
        }

        public string Ten
        {
            get { return txtTen.Text.Trim(); }
            set { txtTen.Text = value; }
        }

        public string TenTat
        {
            get { return txtTenTat.Text.Trim(); }
            set { txtTenTat.Text = value; }
        }
        public string TieuDe1
        {
            get { return txtTieuDe1.Text.Trim(); }
            set { txtTieuDe1.Text = value; }
        }
        public string TieuDe2
        {
            get { return txtTieuDe2.Text.Trim(); }
            set { txtTieuDe2.Text = value; }
        }
        public string TieuDe3
        {
            get { return txtTieuDe3.Text.Trim(); }
            set { txtTieuDe3.Text = value; }
        }
        public string GhiChu
        {
            get { return txtGhiChu.Text.Trim(); }
            set { txtGhiChu.Text = value; }
        }

        public int Muc
        {
            get { return Convert.ToInt32(txtMuc.Number); }
            set { txtMuc.Number = Convert.ToDouble(value); }
        }

        public int Cap
        {
            get { return Convert.ToInt32(txtCap.Number); }
            set { txtCap.Number = Convert.ToDouble(value); }
        }

        public int Nhom
        {
            get { return Convert.ToInt32(txtNhom.Number); }
            set { txtNhom.Number = Convert.ToDouble(value); }
        }

        public DateTime NgayApDung
        {
            get { return txtNgayApDung.SelectedDate; }
            set { txtNgayApDung.SelectedDate = value; }
        }

        public DateTime NgayKetThuc
        {
            get { return txtNgayKetThuc.SelectedDate; }
            set { txtNgayKetThuc.SelectedDate = value; }
        }

        #endregion

        public void KhoiTao()
        {
            IDMauBieuBaoCao = 0;
            Ma = "";
            Ten = "";
            TenTat = "";
            TieuDe1 = "";
            TieuDe2 = "";
            TieuDe3 = "";
            GhiChu = "";
            Muc = 1;
            Cap = 1;
            Nhom = 1;

            DateTime _ngay = DateTime.Now;
            NgayApDung = DateTime.Parse("01/01/"+_ngay.Year.ToString());
            NgayKetThuc = DateTime.Parse("12/31/" + _ngay.Year.ToString());
        }
    }
}