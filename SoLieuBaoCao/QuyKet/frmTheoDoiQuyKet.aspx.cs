using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using daoSLTH.KetSat;
using daoSLTH.TrangThaiDoaiSoat;

namespace SoLieuBaoCao.QuyKet
{
    public partial class frmTheoDoiQuyKet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {

            }
        }

        protected void DanhSachTheoDoi(object sender, StoreReadDataEventArgs e)
        {
            if(txtTuNgay.SelectedDate==null || txtDenNgay.SelectedDate==null)
            {
                return;
            }
            daKetSat dKS = new daKetSat();
            dKS.TuNgay = txtTuNgay.SelectedDate;
            dKS.DenNgay = txtDenNgay.SelectedDate;
            stoQuyKet.DataSource = dKS.DanhSachTheoDoi();
            stoQuyKet.DataBind();
        }

        protected void btnTongHop_Click(object sender, DirectEventArgs e)
        {
            if(txtTuNgay.SelectedDate==null)
            {
                X.Msg.Alert("", "Bạn chưa chọn Ngày!").Show();
                return;
            }

            daTrangThaiDoiSoat dTT = new daTrangThaiDoiSoat();
            dTT.TT.Ngay = txtTuNgay.SelectedDate;
            dTT.KhoiTao();

            daKetSat dKS = new daKetSat();
            dKS.Ngay = txtTuNgay.SelectedDate;
            dKS.TongHopPhatSinh();

            dKS.TongHop();
            X.Msg.Alert("", "Tổng hợp số liệu thành công!").Show();
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