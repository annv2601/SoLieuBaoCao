﻿using System;
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
        #endregion

        #region Su kien
        protected void DanhSachChiTieuMauBieuTD(object sender, StoreReadDataEventArgs e)
        {
            daChiTieuMauBieu dCTMB = new daChiTieuMauBieu();
            dCTMB.CTMB.IDMauBieu = int.Parse(cboBieuBaoCao.SelectedItem.Value);
            stoChiTieuMB.DataSource = dCTMB.DanhSach();
            stoChiTieuMB.DataBind();
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
    }
}