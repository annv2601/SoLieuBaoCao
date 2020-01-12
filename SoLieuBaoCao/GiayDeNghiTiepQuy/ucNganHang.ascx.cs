using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoLieuBaoCao.GiayDeNghiTiepQuy
{
    public partial class ucNganHang : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int IDNganHang
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

        public string TenNganHang
        {
            get
            {
                return txtTenNganHang.Text.Trim();
            }
            set
            {
                txtTenNganHang.Text = value;
            }
        }

        public string TenPhongGD
        {
            get
            {
                return txtPhongGD.Text.Trim();
            }
            set
            {
                txtPhongGD.Text = value;
            }
        }

        public string SoTaikhoan
        {
            get
            {
                return txtSoTK.Text.Trim();
            }
            set
            {
                txtSoTK.Text = value;
            }
        }

        public string TenDonViHuong
        {
            get
            {
                return txtDonViHuong.Text.Trim();
            }
            set
            {
                txtDonViHuong.Text = value;
            }
        }

        public void KhoiTao()
        {
            IDNganHang = 0;
            TenNganHang = "";
            TenPhongGD = "";
            SoTaikhoan = "";
            TenDonViHuong = "";
        }
    }
}