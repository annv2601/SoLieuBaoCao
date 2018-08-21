using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.BieuBaoCao;
using daoSLBC.DanhMuc;
using Ext.Net;

namespace SoLieuBaoCao.BieuBaoCao
{
    public partial class frmBieuBaoCao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                if (UIHelper.daPhien.DaDangNhap)
                {
                    DanhSachBaoCaoLap();
                }
                else
                {
                    X.Msg.Alert("","Anh/chị chưa đăng nhập vào phần mềm!").Show();
                }
            }
        }

        #region Thuoc tinh
        #endregion

        #region Rieng
        private void DanhSachBaoCaoLap()
        {
            daBieuBaoCao dBBC = new daBieuBaoCao();
            dBBC.BieuBC.DonVi = UIHelper.daPhien.MaDonVi;
            stoBieuBaoCao.DataSource = dBBC.DanhSach();
            stoBieuBaoCao.DataBind();
        }
        #endregion

        #region Su kien
        protected void BieuBaoCao_DBClick(object sender, DirectEventArgs e)
        {
            string json = e.ExtraParams["Values"];
            if (json == "")
            {
                return;
            }
            Dictionary<string, string>[] companies = JSON.Deserialize<Dictionary<string, string>[]>(json);
            string _MaBC = "";
            foreach (Dictionary<string, string> row in companies)
            {
                _MaBC = row["MaBaoCao"].ToString();
            }
            if (_MaBC=="")
            {
                X.Msg.Alert("","ANh/chị hãy click chuột vào một biểu tượng!").Show();
                return;
            }

            if (_MaBC == "000000")
            {
                ucBieuBC1.KhoiTao();
                wTaoBieuBaoCao.Show();
            }
            else
            {

            }
        }

        protected void btnTaoBaoCao_Click(object sender, DirectEventArgs e)
        {
            daBieuBaoCao dBBC = new daBieuBaoCao();
            daTrangThaiBaoCao dTTBC = new daTrangThaiBaoCao();

            dBBC.BieuBC.Thang = ucBieuBC1.Thang;
            dBBC.BieuBC.Nam = ucBieuBC1.Nam;
            dBBC.BieuBC.IDBieuDinhNghia = ucBieuBC1.IDMauBieuDinhNghia;
            dBBC.BieuBC.DonVi = UIHelper.daPhien.MaDonVi;
            dBBC.BieuBC.TrangThai = (int)daDanhMuc.eTrangThai.Nhập_số_liệu;
            dBBC.SinhMaBaoCao();

            dTTBC.TT.MaBaoCao = dBBC.BieuBC.MaBaoCao;
            dTTBC.TT.IDTrangThai = (int)daDanhMuc.eTrangThai.Nhập_số_liệu;


        }
        #endregion
    }
}