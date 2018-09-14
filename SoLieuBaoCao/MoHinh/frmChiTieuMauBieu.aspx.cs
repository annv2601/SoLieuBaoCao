using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.DanhMuc;
using daoSLBC.ChiTieu;
using Ext.Net;

namespace SoLieuBaoCao.MoHinh
{
    public partial class frmChiTieuMauBieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                DanhSachMauBieu();
            }
        }

        #region Rieng
        private void DanhSachMauBieu()
        {
            daMauBieu dMB = new daMauBieu();
            stoMauBieu.DataSource = dMB.DanhSach();
            stoMauBieu.DataBind();
        }

        public int Nhom
        {
            get { return int.Parse(txtNhom.Text); }
            set { txtNhom.Text = value.ToString(); }
        }
        #endregion

        #region Su kien
        protected void DanhSachChiTieuMauBieuTD(object sender, StoreReadDataEventArgs e)
        {
            daChiTieuMauBieu dCTMB = new daChiTieuMauBieu();
            dCTMB.CTMB.IDMauBieu = int.Parse(cboBieuBaoCao.SelectedItem.Value);
            stoChiTieuMB.DataSource = dCTMB.DanhSach();
            stoChiTieuMB.DataBind();

            daMauBieu dMB = new daMauBieu();
            dMB.MB.ID = int.Parse(cboBieuBaoCao.SelectedItem.Value);
            dMB.ThongTin();
            Nhom = dMB.MB.Nhom.Value;
        }

        [DirectMethod(Namespace = "BangChiTieuMBX")]
        public void Edit(int id, string field, string oldvalue, string newvalue, object BangCTMB)
        {
            daChiTieuMauBieu dCTMB = new daChiTieuMauBieu();
            dCTMB.CTMB.IDMauBieu = int.Parse(cboBieuBaoCao.SelectedItem.Value);
            dCTMB.CTMB.IDChiTieu = id;

            Newtonsoft.Json.Linq.JObject node = JSON.Deserialize<Newtonsoft.Json.Linq.JObject>(BangCTMB.ToString());

            try { dCTMB.CTMB.ThuTu = node.Property("ThuTu").Value.ToString();}
            catch { }
            try { dCTMB.CTMB.InDam = Boolean.Parse(node.Property("InDam").Value.ToString()); }
            catch { dCTMB.CTMB.InDam = false; }
            try { dCTMB.CTMB.InNghieng = Boolean.Parse(node.Property("InNghieng").Value.ToString()); }
            catch { dCTMB.CTMB.InNghieng = false; }
            try { dCTMB.CTMB.STTsx = Decimal.Parse(node.Property("STTsx").Value.ToString()); }
            catch { dCTMB.CTMB.STTsx = 0; }
            try { dCTMB.CTMB.NhapTay = Boolean.Parse(node.Property("NhapTay").Value.ToString()); }
            catch { dCTMB.CTMB.NhapTay =false; }

            dCTMB.ThemSua();
            grdChiTieuMB.GetStore().GetById(id).Commit();
        }

        protected void grdChiTieuMB_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesCT"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            ucChiTieuMB1.IDmauBieu = int.Parse(cboBieuBaoCao.SelectedItem.Value);
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    ucChiTieuMB1.IDChiTieu = int.Parse(row["IDChiTieu"]);
                    ucChiTieuMB1.ThuTu = row["ThuTu"];
                    ucChiTieuMB1.InDam = bool.Parse(row["InDam"]);
                    ucChiTieuMB1.InNghieng = bool.Parse(row["InNghieng"]);
                    ucChiTieuMB1.NhapTay = bool.Parse(row["NhapTay"]);
                    ucChiTieuMB1.STTsx = Decimal.Parse(row["STTsx"]);

                    ucChiTieuMB1.TenChiTieu = row["TenChiTieu"] + " : " + row["Ma"];
                }
                catch
                {
                    ucChiTieuMB1.IDChiTieu = 0;
                }
            }
            if (ucChiTieuMB1.IDChiTieu == 0)
            {
                X.Msg.Alert("","Anh/Chị phải chọn một chỉ tiêu trước đã!").Show();
            }
            else
            {
                ucChiTieuMB1.DanhSachDanSuatCong();
                ucChiTieuMB1.DanhSachDanSuatNhan();
                ucChiTieuMB1.DanhSachDanSuatTru();
                ucChiTieuMB1.DanhSachMSCTCong();
                ucChiTieuMB1.DanhSachMSCTTru();
                wChiTieuMauBieu.Show();
            }
        }

        protected Field OnCreateFilterableField(object sender, ColumnBase column, Field defaultField)
        {
            if (column.DataIndex == "Id")
            {
                ((TextField)defaultField).Icon = Icon.Magnifier;
            }

            return defaultField;
        }
        #endregion

        #region Su kien control
        [DirectMethod(Namespace = "BangDanSuatCongX")]
        public void EditDSCong(int id, string field, string oldvalue, string newvalue, object BangCTMB)
        {
            daChiTieu dCT = new daChiTieu();
            dCT.CTTim.Ma = newvalue;
            dCT.CTTim.Nhom = Nhom;

            daChiTieuDanSuat dDS = new daChiTieuDanSuat();
            dDS.PT.IDMauBieu = ucChiTieuMB1.IDmauBieu;
            dDS.PT.IDChiTieu = ucChiTieuMB1.IDChiTieu;

            if (newvalue=="")
            {
                dDS.PT.MaChiTieuDanSuat = oldvalue;
                dDS.XoaDanSuatCong();
                ucChiTieuMB1.DSCongOK(id, true);
                return;
            }

            if (dCT.Tim() == null)
            {
                ucChiTieuMB1.DSCongOK(id, false);
                X.Msg.Alert("", "Không tìm thấy chỉ tiêu dẫn suất có mã là: " + newvalue).Show();
            }
            else
            {                
                dDS.PT.IDChiTieuDanSuat = dCT.CTTim.ID;
                dDS.PT.MaChiTieuDanSuat = newvalue.ToUpper();
                dDS.PT.HeSo = 1;

                dDS.ThemDanSuatCong();
                ucChiTieuMB1.DSCongOK(id, true);
            }
        }

        [DirectMethod(Namespace = "BangDanSuatTruX")]
        public void EditDSTru(int id, string field, string oldvalue, string newvalue, object BangCTMB)
        {
            daChiTieu dCT = new daChiTieu();
            dCT.CTTim.Ma = newvalue;
            dCT.CTTim.Nhom = Nhom;

            daChiTieuDanSuat dDS = new daChiTieuDanSuat();
            dDS.PT.IDMauBieu = ucChiTieuMB1.IDmauBieu;
            dDS.PT.IDChiTieu = ucChiTieuMB1.IDChiTieu;

            if (newvalue == "")
            {
                dDS.PT.MaChiTieuDanSuat = oldvalue;
                dDS.XoaDanSuatTru();
                ucChiTieuMB1.DSruOK(id, true);
                return;
            }

            if (dCT.Tim() == null)
            {
                ucChiTieuMB1.DSruOK(id, false);
                X.Msg.Alert("", "Không tìm thấy chỉ tiêu dẫn suất có mã là: " + newvalue).Show();
            }
            else
            {
                dDS.PT.IDChiTieuDanSuat = dCT.CTTim.ID;
                dDS.PT.MaChiTieuDanSuat = newvalue.ToUpper();
                dDS.PT.HeSo = 1;

                dDS.ThemDanSuatTru();
                ucChiTieuMB1.DSruOK(id, true);
            }
        }

        [DirectMethod(Namespace = "BangDanSuatNhanX")]
        public void EditDSNhan(int id, string field, string oldvalue, string newvalue, object BangCTMB)
        {
            if (field != "MaChiTieuDanSuat")
            {
                return;
            }
            daChiTieu dCT = new daChiTieu();
            dCT.CTTim.Ma = newvalue;
            dCT.CTTim.Nhom = Nhom;

            daChiTieuDanSuat dDS = new daChiTieuDanSuat();
            dDS.PT.IDMauBieu = ucChiTieuMB1.IDmauBieu;
            dDS.PT.IDChiTieu = ucChiTieuMB1.IDChiTieu;

            if (newvalue == "")
            {
                dDS.PT.MaChiTieuDanSuat = oldvalue;
                dDS.XoaDanSuatNhan();
                ucChiTieuMB1.DSNhanOK(id, true);
                return;
            }

            if (dCT.Tim() == null)
            {
                ucChiTieuMB1.DSNhanOK(id, false);
                X.Msg.Alert("", "Không tìm thấy chỉ tiêu dẫn suất có mã là: " + newvalue).Show();
            }
            else
            {                
                dDS.PT.IDChiTieuDanSuat = dCT.CTTim.ID;
                dDS.PT.MaChiTieuDanSuat = newvalue.ToUpper();

                Newtonsoft.Json.Linq.JObject node = JSON.Deserialize<Newtonsoft.Json.Linq.JObject>(BangCTMB.ToString());
                try
                {
                    dDS.PT.HeSo = Decimal.Parse(node.Property("HeSo").Value.ToString());
                }
                catch
                {
                    dDS.PT.HeSo = 1;
                }


                dDS.ThemDanSuatNhan();
                ucChiTieuMB1.DSNhanOK(id, true);
            }
        }

        [DirectMethod(Namespace = "BangMSCTCongX")]
        public void EditMSCTCong(int id, string field, string oldvalue, string newvalue, object BangCTMB)
        {
            daChiTieu dCT = new daChiTieu();
            dCT.MSCT.MSCT = newvalue;

            daChiTieuMSCT dMSCT = new daChiTieuMSCT();
            dMSCT.PT.IDMauBieu = ucChiTieuMB1.IDmauBieu;
            dMSCT.PT.IDChiTieu = ucChiTieuMB1.IDChiTieu;

            if (newvalue == "")
            {
                dMSCT.PT.MSCT = oldvalue;
                dMSCT.XoaMSCTCong();
                ucChiTieuMB1.MSCTCongOK(id, true);
                return;
            }

            if (dCT.TimMSCT() == null)
            {
                ucChiTieuMB1.MSCTCongOK(id, false);
                X.Msg.Alert("", "Không tìm thấy chỉ tiêu trong STK1 có mã là: " + newvalue).Show();
            }
            else
            {
                dMSCT.PT.MSCT = newvalue;

                dMSCT.ThemMSCTCong();
                ucChiTieuMB1.MSCTCongOK(id, true);
            }
        }

        [DirectMethod(Namespace = "BangMSCTTruX")]
        public void EditMSCTTru(int id, string field, string oldvalue, string newvalue, object BangCTMB)
        {
            daChiTieu dCT = new daChiTieu();
            dCT.MSCT.MSCT = newvalue;

            daChiTieuMSCT dMSCT = new daChiTieuMSCT();
            dMSCT.PT.IDMauBieu = ucChiTieuMB1.IDmauBieu;
            dMSCT.PT.IDChiTieu = ucChiTieuMB1.IDChiTieu;

            if (newvalue == "")
            {
                dMSCT.PT.MSCT = oldvalue;
                dMSCT.XoaMSCTTru();
                ucChiTieuMB1.MSCTTruOK(id, true);
                return;
            }

            if (dCT.TimMSCT() == null)
            {
                ucChiTieuMB1.MSCTTruOK(id, false);
                X.Msg.Alert("", "Không tìm thấy chỉ tiêu trong STK1 có mã là: " + newvalue).Show();
            }
            else
            {
                dMSCT.PT.MSCT = newvalue;

                dMSCT.ThemMSCTTru();
                ucChiTieuMB1.MSCTTruOK(id, true);
            }
        }
        #endregion
    }
}