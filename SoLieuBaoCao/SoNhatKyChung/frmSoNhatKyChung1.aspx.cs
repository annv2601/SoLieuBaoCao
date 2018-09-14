using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using daoSLKT.SoNhatKy;
using Ext.Net;

namespace SoLieuBaoCao.SoNhatKyChung
{
    public partial class frmSoNhatKyChung1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                TongHopNoCo = false;
                dsThangNam();
            }
        }

        #region Rieng
        private bool TongHopNoCo
        {
            get { return bool.Parse(txtNoCo.Text); }
            set { txtNoCo.Text = value.ToString(); }
        }

        private void dsThangNam()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Ten", typeof(string));

            int i = 0;
            for(i=1;i<=12;i++)
            {
                dt.Rows.Add(i, "Tháng " + i.ToString());
            }
            stoThang.DataSource = dt;
            stoThang.DataBind();

            DataTable dt1 = new DataTable();
            dt1 = dt.Clone();
            for (i = DateTime.Now.Year-1; i <= DateTime.Now.Year; i++)
            {
                dt1.Rows.Add(i, "Năm " + i.ToString());
            }
            stoNam.DataSource = dt1;
            stoNam.DataBind();
        }

        private void DanhSachTongHop1()
        {
            if (slbThang.SelectedItem.Value == null || slbNam.SelectedItem.Value == null)
            {
                return;
            }
            daSoNhatKy dSNK = new daSoNhatKy();
            dSNK.SNK.Thang = byte.Parse(slbThang.SelectedItem.Value);
            dSNK.SNK.Nam = int.Parse(slbNam.SelectedItem.Value);
            dSNK.SNK.MaDonVi = txtMaDonVi.Text.Trim();

            stoSoNhatKyChung.DataSource = dSNK.TongHop1();
            stoSoNhatKyChung.DataBind();            
        }

        private void DanhSachTongHop2()
        {
            if(slbThang.SelectedItem.Value==null || slbNam.SelectedItem.Value==null)
            {
                return;
            }
            daSoNhatKy dSNK = new daSoNhatKy();
            dSNK.SNK.Thang = byte.Parse(slbThang.SelectedItem.Value);
            dSNK.SNK.Nam = int.Parse(slbNam.SelectedItem.Value);
            dSNK.SNK.MaDonVi = txtMaDonVi.Text.Trim();

            bool _NoCo=false;
            if(chkNo.Checked)
            {
                _NoCo = true;
            }

            if(chkCo.Checked)
            {
                _NoCo = false;
            }

            stoSoNhatKyChung.DataSource = dSNK.TongHop2(_NoCo);
            stoSoNhatKyChung.DataBind();            
        }
        #endregion

        protected void btnHienThi_Click(object sender, DirectEventArgs e)
        {
            DanhSachTongHop1();
            TongHopNoCo = false;
        }

        protected void grdSoNhatKyChung_ClickDup(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["ValuesSNKC"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _nd = "", _NgayHT="", _TaiKhoan="";
            bool _NoCo = false;
            
            foreach (Dictionary<string, string> row in companies)
            {
                try
                {
                    _nd = row["ND"];
                    _NgayHT = row["NGAY_HT"];
                    if (chkNo.Checked)
                    {
                        _TaiKhoan = row["TK_NO"];
                        _NoCo = true;
                    }
                    if(chkCo.Checked)
                    {
                        _TaiKhoan = row["TK_CO"];
                        _NoCo = false;
                    }
                }
                catch
                {
                    _nd = "0";
                }
            }

            if (_nd != "0")
            {
                string _url;
                if (TongHopNoCo)
                {
                    _url = UIHelper.daPhien.LayDiaChiURL("/SoNhatKyChung/frmChiTietSoNhatKy.aspx?snkcThang=" + slbThang.SelectedItem.Value + "&&snkcNam=" + slbNam.SelectedItem.Value + "&&snkcMaDonVi=" + txtMaDonVi.Text.Trim() + "&&snkcND=" + _nd + "&&snkcNgayHT=" + _NgayHT + "&&snkcTaiKhoan=" + _TaiKhoan + "&&snkcNoCo=" + _NoCo);
                }
                else
                {
                    _url = UIHelper.daPhien.LayDiaChiURL("/SoNhatKyChung/frmChiTietSoNhatKy.aspx?snkcThang=" + slbThang.SelectedItem.Value + "&&snkcNam=" + slbNam.SelectedItem.Value + "&&snkcMaDonVi=" + txtMaDonVi.Text.Trim() + "&&snkcND=" + _nd + "&&snkcNgayHT=" + _NgayHT);
                }
                string script = "window.open('" + _url + "', '')";
                this.grdSoNhatKyChung.AddScript(script);
            }
        }

        protected void chkNoCo_Change(object sender, DirectEventArgs e)
        {
            DanhSachTongHop2();
            TongHopNoCo = true;
        }

        protected Field OnCreateFilterableField(object sender, ColumnBase column, Field defaultField)
        {
            if (column.DataIndex == "Id")
            {
                ((TextField)defaultField).Icon = Icon.Magnifier;
            }

            return defaultField;
        }
    }
}
