using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.BieuBaoCao;
using Ext.Net;

namespace SoLieuBaoCao.BieuBaoCao
{
    public partial class frmBieuBaoCao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                DanhSachBaoCaoLap();
            }
        }

        #region Thuoc tinh
        #endregion

        #region Rieng
        private void DanhSachBaoCaoLap()
        {
            daBieuBaoCao dBBC = new daBieuBaoCao();
            dBBC.BieuBC.DonVi = "10000";
            stoBieuBaoCao.DataSource = dBBC.DanhSach();
            stoBieuBaoCao.DataBind();
        }
        #endregion
    }
}