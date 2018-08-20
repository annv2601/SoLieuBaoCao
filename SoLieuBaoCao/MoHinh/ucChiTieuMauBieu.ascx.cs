using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.ChiTieu;
using Ext.Net;

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

        public void DanhSachDanSuatCong()
        {
            daChiTieuDanSuat dCTDS = new daChiTieuDanSuat();
            dCTDS.PT.IDMauBieu = IDmauBieu;
            dCTDS.PT.IDChiTieu = IDChiTieu;

            stoDSCong.DataSource = dCTDS.DanhSachDanSuatCong();
            stoDSCong.DataBind();
        }

        public void DanhSachDanSuatTru()
        {
            daChiTieuDanSuat dCTDS = new daChiTieuDanSuat();
            dCTDS.PT.IDMauBieu = IDmauBieu;
            dCTDS.PT.IDChiTieu = IDChiTieu;

            stoDSTru.DataSource = dCTDS.DanhSachDanSuatTru();
            stoDSTru.DataBind();
        }

        public void DanhSachDanSuatNhan()
        {
            daChiTieuDanSuat dCTDS = new daChiTieuDanSuat();
            dCTDS.PT.IDMauBieu = IDmauBieu;
            dCTDS.PT.IDChiTieu = IDChiTieu;

            stoDSNhan.DataSource = dCTDS.DanhSachDanSuatNhan();
            stoDSNhan.DataBind();
        }

        public void DanhSachMSCTCong()
        {
            daChiTieuMSCT dMSCT = new daChiTieuMSCT();
            dMSCT.PT.IDMauBieu = IDmauBieu;
            dMSCT.PT.IDChiTieu = IDChiTieu;

            stoMSCTCong.DataSource = dMSCT.DanhSachMSCTCong();
            stoMSCTCong.DataBind();
        }

        public void DanhSachMSCTTru()
        {
            daChiTieuMSCT dMSCT = new daChiTieuMSCT();
            dMSCT.PT.IDMauBieu = IDmauBieu;
            dMSCT.PT.IDChiTieu = IDChiTieu;

            stoMSCTTru.DataSource = dMSCT.DanhSachMSCTTru();
            stoMSCTTru.DataBind();
        }
        #endregion

        #region commit SO lieu
        public void DSCongOK(int id, bool OK)
        {
            if(OK)
            {
                grdDanSuatCong.GetStore().GetById(id).Commit();
            }
            else
            {
                grdDanSuatCong.GetStore().GetById(id).Reject();
            }
        }

        public void DSruOK(int id, bool OK)
        {
            if (OK)
            {
                grdDanSuatTru.GetStore().GetById(id).Commit();
            }
            else
            {
                grdDanSuatTru.GetStore().GetById(id).Reject();
            }
        }

        public void DSNhanOK(int id, bool OK)
        {
            if (OK)
            {
                grdDanSuatNhan.GetStore().GetById(id).Commit();
            }
            else
            {
                grdDanSuatNhan.GetStore().GetById(id).Reject();
            }
        }

        public void MSCTCongOK(int id, bool OK)
        {
            if (OK)
            {
                grdMSCTCong.GetStore().GetById(id).Commit();
            }
            else
            {
                grdMSCTCong.GetStore().GetById(id).Reject();
            }
        }

        public void MSCTTruOK(int id, bool OK)
        {
            if (OK)
            {
                grdMSCTTru.GetStore().GetById(id).Commit();
            }
            else
            {
                grdMSCTTru.GetStore().GetById(id).Reject();
            }
        }
        #endregion

        #region Su kien
        protected void btnCapNhatChiTieuMauBieu_Click(object sender, DirectEventArgs e)
        {
            daChiTieuMauBieu dCTMB = new daChiTieuMauBieu();
            dCTMB.CTMB.IDMauBieu = IDmauBieu;
            dCTMB.CTMB.IDChiTieu = IDChiTieu;
            
            try { dCTMB.CTMB.ThuTu = ThuTu; }
            catch { }
            try { dCTMB.CTMB.InDam = InDam; }
            catch { dCTMB.CTMB.InDam = false; }
            try { dCTMB.CTMB.InNghieng = InNghieng; }
            catch { dCTMB.CTMB.InNghieng = false; }
            try { dCTMB.CTMB.STTsx = STTsx; }
            catch { dCTMB.CTMB.STTsx = 0; }
            try { dCTMB.CTMB.NhapTay = NhapTay; }
            catch { dCTMB.CTMB.NhapTay = false; }

            dCTMB.ThemSua();
            X.Msg.Alert("","Anh/chị đã cập nhật thành công thông tin chỉ tiêu!").Show();
        }
        #endregion
    }
}