using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.BieuBaoCao;
using daoSLBC.DanhMuc;
using daoSLBC.DuLieuBaoCao;
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

        private Ext.Net.Window CuaSoChucNang(string rTieuDe, string Url)
        {
            Ext.Net.Window _CSo = new Ext.Net.Window();
            ComponentLoader _Loader = new ComponentLoader();
            _Loader.Url = Url;
            _Loader.Mode = LoadMode.Frame;
            _Loader.LoadMask.ShowMask = true;
            _Loader.LoadMask.Msg = "Đang xử lý .....";

            _CSo.ID = "IDwNhapBCN";
            _CSo.Title = rTieuDe;
            _CSo.TitleAlign = TitleAlign.Center;
            _CSo.AutoRender = true;
            _CSo.Maximizable = false;
            _CSo.Icon = Icon.BookAddressesEdit;
            _CSo.Width = 1200;
            _CSo.Height = 600;
            _CSo.Loader = _Loader;

            return _CSo;
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
            string _Thang="1", _Nam="0", _IDMauBieu="0";
            foreach (Dictionary<string, string> row in companies)
            {
                _MaBC = row["MaBaoCao"].ToString();
                try
                {
                    _Thang = row["Thang"].ToString();
                    _Nam = row["Nam"].ToString();
                    _IDMauBieu = row["IDBieuDinhNghia"].ToString();
                }
                catch { }
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
                Ext.Net.Window CSo = new Ext.Net.Window();
                switch(_IDMauBieu)
                {
                    case "1":
                        CSo = CuaSoChucNang("Nhập dữ liệu báo cáo nhanh Tháng " + _Thang + " Năm " + _Nam, "frmBieuNhapBCN.aspx?ThangBieuNhapBCN=" + _Thang + "&&NamBieuNhapBCN=" + _Nam + "&&MaBieuNhapBCN=" + _MaBC + "&&IDMauBieuBieuNhapBCN=" + _IDMauBieu);
                        break;
                    case "3":
                        CSo = CuaSoChucNang("Báo cáo B02-05 " + _Thang + " Năm " + _Nam, "frmBieuNhapB0205.aspx?ThangBieuNhapB0205=" + _Thang + "&&NamBieuNhapB0205=" + _Nam + "&&MaBieuNhapB0205=" + _MaBC + "&&IDMauBieuBieuNhapB0205=" + _IDMauBieu);
                        break;
                }
                this.Form.Controls.Add(CSo);
                CSo.Render();
                CSo.Show();
            }
        }

        protected void btnTaoBaoCao_Click(object sender, DirectEventArgs e)
        {
            daBieuBaoCao dBBC = new daBieuBaoCao();
            daTrangThaiBaoCao dTTBC = new daTrangThaiBaoCao();
            daDuLieuBCN dBCN = new daDuLieuBCN();

            dBBC.BieuBC.Thang = ucBieuBC1.Thang;
            dBBC.BieuBC.Nam = ucBieuBC1.Nam;
            dBBC.BieuBC.IDBieuDinhNghia = ucBieuBC1.IDMauBieuDinhNghia;
            dBBC.BieuBC.DonVi = UIHelper.daPhien.MaDonVi;
            dBBC.BieuBC.TrangThai = (int)daDanhMuc.eTrangThai.Nhập_số_liệu;
            dBBC.SinhMaBaoCao();

            dTTBC.TT.MaBaoCao = dBBC.BieuBC.MaBaoCao;
            dTTBC.TT.IDTrangThai = (int)daDanhMuc.eTrangThai.Nhập_số_liệu;
            dTTBC.TT.TenTrangThai = "Nhập số liệu";
            dTTBC.TT.NguoiThucHien = UIHelper.daPhien.MaNSD + ":" + UIHelper.daPhien.TenNguoiSuDung;

            dBCN.BCN.MaBieuBaoCao = dBBC.BieuBC.MaBaoCao;
            dBCN.IDMauBieu = dBBC.BieuBC.IDBieuDinhNghia.Value;
            dBCN.Thang = ucBieuBC1.Thang;
            dBCN.Nam = ucBieuBC1.Nam;
            dBCN.MaDonVi = UIHelper.daPhien.MaDonVi;
            dBCN.MaDonViSTK1 = UIHelper.daPhien.ThongTinDN.MaSTK1;
            dBCN.MaBieuBaoCao= dBBC.BieuBC.MaBaoCao;

            if (dBBC.ThongTin() == null)
            {
                dBBC.Them();

                dTTBC.Them();

                switch(dBBC.BieuBC.IDBieuDinhNghia)
                {
                    case 1:
                        dBCN.KhoiTao();

                        dBCN.LaySTK1();

                        dBCN.TinhDanSuatSTK1();
                        break;
                    case 3:
                        daDuLieuBaoCaoB0205 dB0205 = new daDuLieuBaoCaoB0205();
                        dB0205.MaBieuBaoCao = dBBC.BieuBC.MaBaoCao;
                        dB0205.IDMauBieu = dBBC.BieuBC.IDBieuDinhNghia.Value;
                        dB0205.Thang = (byte)dBBC.BieuBC.Thang;
                        dB0205.Nam = dBBC.BieuBC.Nam.Value;
                        dB0205.MaDonVi = UIHelper.daPhien.MaDonVi;
                        dB0205.MaDonViSTK1 = UIHelper.daPhien.ThongTinDN.MaSTK1;
                        dB0205.NguoiThucHien = UIHelper.daPhien.MaNSD + ":" + UIHelper.daPhien.TenNguoiSuDung;

                        dB0205.KhoiTao();

                        dB0205.LaySoLieuSTK1();

                        dB0205.TinhDanSuat();
                        break;
                }
                

                DanhSachBaoCaoLap();
            }

            wTaoBieuBaoCao.Hide();
        }
        #endregion
    }
}