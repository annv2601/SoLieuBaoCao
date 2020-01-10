using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaoBieu.NopTienNganHang;
using daoTienThuCOD.Client;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class frmBanIn : Form
    {
        public frmBanIn()
        {
            InitializeComponent();
        }

        #region Khai bao
        public DataTable Bang1;
        public DataTable Bang2;
        public DataTable Bang3;
        #endregion

        #region Chung
        public void HienThiBanInNopNganHang()
        {
            crNopTienNganHang rptNOPNH = new crNopTienNganHang();
            rptNOPNH.SetDataSource(Bang1);
            rptNOPNH.Subreports[0].SetDataSource(Bang3);
            rptNOPNH.Subreports[1].SetDataSource(Bang2);

            daDanhMuc dDM = new daDanhMuc();
            sp_LayThongTinBuuCucResult pt = dDM.LayDvi();
            if(pt!=null)
            {
                rptNOPNH.SetParameterValue(0, "BƯU ĐIỆN THÀNH PHỐ HÀ NỘI");
                rptNOPNH.SetParameterValue(1, pt.DonVi);
                rptNOPNH.SetParameterValue(2, pt.BuuCuc);
            }
            else
            {
                rptNOPNH.SetParameterValue(0, "BƯU ĐIỆN THÀNH PHỐ HÀ NỘI");
                rptNOPNH.SetParameterValue(1, "");
                rptNOPNH.SetParameterValue(2, "");
            }
            crystalReportViewer1.ReportSource = rptNOPNH;
        }
        #endregion

        private void frmBanIn_Resize(object sender, EventArgs e)
        {
            crystalReportViewer1.Height = this.Height - btnIn.Height - 20;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }
    }
}
