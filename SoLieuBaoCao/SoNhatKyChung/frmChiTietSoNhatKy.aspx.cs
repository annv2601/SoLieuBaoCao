using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using daoSLKT.SoNhatKy;

namespace SoLieuBaoCao.SoNhatKyChung
{
    public partial class frmChiTietSoNhatKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                Thang = byte.Parse(Request.QueryString["snkcThang"]);
                Nam = int.Parse(Request.QueryString["snkcNam"]);
                MaDonVi = Request.QueryString["snkcMaDonVi"];
                ND = Request.QueryString["snkcND"];
                NgayHT = Request.QueryString["snkcNgayHT"];

                bool _LaNoCo = false;
                try
                {
                    _LaNoCo = true;
                    NoCo = bool.Parse(Request.QueryString["snkcNoCo"]);
                    TaiKhoan = Request.QueryString["snkcTaiKhoan"];
                }
                catch
                {
                    _LaNoCo = false;
                }

                if (_LaNoCo)
                {
                    DanhSachChiTiet2();
                }
                else
                {
                    DanhSachChiTiet();
                }
            }
        }

        #region Rieng
        private byte Thang
        {
            get { return byte.Parse(txtThang.Text); }
            set { txtThang.Text = value.ToString(); }
        }

        private int Nam
        {
            get { return int.Parse(txtNam.Text); }
            set { txtNam.Text = value.ToString(); }
        }

        private string MaDonVi
        {
            get {return txtMaDonVi.Text; }
            set { txtMaDonVi.Text = value; }
        }

        private string ND
        {
            get { return txtNoiDung.Text; }
            set { txtNoiDung.Text = value; }
        }

        private string NgayHT
        {
            get { return txtNgayHT.Text; }
            set { txtNgayHT.Text = value; }
        }

        private string TaiKhoan
        {
            get { return txtTaiKhoan.Text; }
            set { txtTaiKhoan.Text = value; }
        }

        private bool NoCo
        {
            get { return bool.Parse(txtNoCo.Text); }
            set { txtNoCo.Text = value.ToString(); }
        }
        #endregion

        private void DanhSachChiTiet()
        {
            daSoNhatKy dSNK = new daSoNhatKy();
            dSNK.SNK.Thang = Thang;
            dSNK.SNK.Nam = Nam;
            dSNK.SNK.MaDonVi = MaDonVi;
            dSNK.SNK.ND = ND;
            dSNK.SNK.NGAY_HT = NgayHT;

            stoSoNhatKyChungCT.DataSource = dSNK.DanhSachChiTiet();
            stoSoNhatKyChungCT.DataBind();
        }

        private void DanhSachChiTiet2()
        {
            daSoNhatKy dSNK = new daSoNhatKy();
            dSNK.SNK.Thang = Thang;
            dSNK.SNK.Nam = Nam;
            dSNK.SNK.MaDonVi = MaDonVi;
            dSNK.SNK.NGAY_HT = NgayHT;


            stoSoNhatKyChungCT.DataSource = dSNK.DanhSachChiTiet2(TaiKhoan, NoCo);
            stoSoNhatKyChungCT.DataBind();
        }
    }
}