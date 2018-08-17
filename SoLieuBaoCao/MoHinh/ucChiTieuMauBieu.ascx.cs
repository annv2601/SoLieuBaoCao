using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoLieuBaoCao.MoHinh
{
    public partial class ucChiTieuMauBieu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Thuoc tinh
        public int IDChiTieu
        {
            get { return int.Parse(txtIDChiTieuMauBieu.Text); }
            set { txtIDChiTieuMauBieu.Text = value.ToString(); }
        }

        public int IDmauBieu
        {
            get { return int.Parse(txtIDMauBieu.Text); }
            set { txtIDMauBieu.Text = value.ToString(); }
        }

        public string TenChiTieu
        {
            set { txtTenChiTieu.Text = value; }
        }

        public string ThuTu
        {
            get { return txtThuTu.Text; }
            set { txtThuTu.Text = value; }
        }

        public bool InDam
        {
            get { return chkInDam.Checked; }
            set { chkInDam.Checked = value; }
        }

        public bool InNghieng
        {
            get { return chkInNghieng.Checked; }
            set { chkInNghieng.Checked = value; }
        }

        public bool NhapTay
        {
            get { return chkNhapTay.Checked; }
            set { chkNhapTay.Checked = value; }
        }

        public decimal STTsx
        {
            get { return Convert.ToDecimal(txtSTTsx.Number); }
            set { txtSTTsx.Number = Convert.ToDouble(value); }
        }
        #endregion

        #region Ham
        public void KhoiTao()
        {
            IDChiTieu = 0;
            IDmauBieu = 0;
            ThuTu = "";
            InDam = false;
            InNghieng = false;
            NhapTay = false;
            STTsx = 9;
        }
        #endregion
    }
}