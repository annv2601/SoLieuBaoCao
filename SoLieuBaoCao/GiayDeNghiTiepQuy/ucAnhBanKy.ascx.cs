using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Ext.Net;
using daoKeToanSoDu.GiayDeNghi;

namespace SoLieuBaoCao.GiayDeNghiTiepQuy
{
    public partial class ucAnhBanKy : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string MaKeToan
        {
            get
            {
                return txtMaKeToan.Text;
            }
            set
            {
                txtMaKeToan.Text = value;
            }
        }

        protected void btnFileAnh_Click(object sender, DirectEventArgs e)
        {
            if(MaKeToan=="")
            {
                return;
            }
            string _tf = DateTime.Now.ToString("yyyyMMddHHmmss_") + btnFileAnh.PostedFile.FileName;
            string DuongDanFileAnh = TenFile(_tf);
            btnFileAnh.PostedFile.SaveAs(DuongDanFileAnh);

            FileInfo fileInfo = new FileInfo(DuongDanFileAnh);
            byte[] newBytes = new byte[fileInfo.Length];

            daGiayDeNghi dGiay = new daGiayDeNghi();
            dGiay.GDN.MaKeToanNgay = MaKeToan;
            dGiay.GDN.urlAnhBanIn = "\\DataAnh\\" + _tf;
            dGiay.CapNhatAnhBanKy();
            imgBanKy.ImageUrl = dGiay.GDN.urlAnhBanIn;
        }

        private string TenFile(string rTenFile)
        {
            string _TenFile;
            _TenFile = Server.MapPath("\\DataAnh\\");
            DirectoryInfo di = new DirectoryInfo(_TenFile);
            if (!di.Exists)
            {
                di.Create();
            }

            _TenFile = _TenFile + "\\" + rTenFile;


            return _TenFile;
        }

        public void HienThiAnh(string url)
        {
            imgBanKy.ImageUrl = url;
        }
    }
}