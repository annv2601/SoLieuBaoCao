using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using daoSLBC.DanhMuc;
using Ext.Net;

namespace SoLieuBaoCao.BieuBaoCao
{
    public partial class ucBieuBaoCao : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                DanhSachThang();
                DanhSachMau();
            }
        }

        #region Thuoc tinh
        public int IDMauBieuDinhNghia
        {
            get
            {
                return int.Parse(slbMauBieuDinhNghia.SelectedItem.Value);
            }
            set
            {
                slbMauBieuDinhNghia.SelectedItems.Clear();
                if(value<=0)
                {
                    slbMauBieuDinhNghia.SelectedItems.Add(new Ext.Net.ListItem { Text = string.Empty, Mode = ParameterMode.Raw });
                }
                else
                {
                    slbMauBieuDinhNghia.SelectedItems.Add(new Ext.Net.ListItem { Value=value.ToString(), Mode = ParameterMode.Raw });
                }
                slbMauBieuDinhNghia.UpdateSelectedItems();
            }
        }

        public byte Thang
        {
            get
            {
                return byte.Parse(slbThang.SelectedItem.Value);
            }
            set
            {
                slbThang.SelectedItems.Clear();
                if (value <= 0)
                {
                    slbThang.SelectedItems.Add(new Ext.Net.ListItem { Text = string.Empty, Mode = ParameterMode.Raw });
                }
                else
                {
                    slbThang.SelectedItems.Add(new Ext.Net.ListItem { Value = value.ToString(), Mode = ParameterMode.Raw });
                }
                slbThang.UpdateSelectedItems();
            }
        }

        public int Nam
        {
            get
            {
                return Convert.ToInt32(txtNam.Number);
            }
            set
            {
                txtNam.Number = Convert.ToDouble(value);
            }
        }
        #endregion

        #region Ham
        public void KhoiTao()
        {
            DateTime _ngay;
            _ngay = DateTime.Now;
            IDMauBieuDinhNghia = 1;
            Thang = Convert.ToByte(_ngay.Month);
            Nam = _ngay.Year;
        }

        private void DanhSachThang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(byte));
            dt.Columns.Add("Ten", typeof(string));

            for(int i=1;i<=12;i++)
            {
                dt.Rows.Add(i, "Tháng " + i.ToString());
            }

            stoThang.DataSource = dt;
            stoThang.DataBind();
        }

        private void DanhSachMau()
        {
            daMauBieu dMB = new daMauBieu();
            stoBieuDN.DataSource = dMB.DanhSach();
            stoBieuDN.DataBind();

            IDMauBieuDinhNghia = 1;
        }
        #endregion
        
    }
}