using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.NopTienNganHang;
using daoTienThuCOD.Client;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class grdTaiKhoan : UserControl
    {
        public grdTaiKhoan()
        {
            InitializeComponent();
        }

        #region Khai bao
        private List<sp_tblNopTienNganHangTaiKhoan_DanhSachResult> lstTK = new List<sp_tblNopTienNganHangTaiKhoan_DanhSachResult>();
        public int IDNopTien;
        public decimal TongTien;
        public int ViTri=0;
        #endregion

        #region Rieng
        private void CanChinh()
        {

        }

        private void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            for (int i = 0; i < lstTK.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;
                Dong.Cells["SoTaiKhoan"].Value = lstTK[i].SoTaiKhoan;

                Dong.Cells["TenTaiKhoan"].Value = lstTK[i].TenTaiKhoan;
                Dong.Cells["SoTien"].Value = lstTK[i].SoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 28;
                Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Regular);
            }

            //Dong tong cong
            Dong = dgv.Rows[dgv.Rows.Add()];

            Dong.Cells["STT"].Value = lstTK.Count;
            Dong.Cells["SoTaiKhoan"].Value = "Tổng cộng";

            TongTien = lstTK.Sum(x => x.SoTien.Value);
            Dong.Cells["SoTien"].Value = TongTien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            Dong.Height = 35;
            Dong.ReadOnly = true;

            Dong.DefaultCellStyle.Font = new Font("Arial", 20, FontStyle.Bold);
            //=======================
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daDanhMuc dDM = new daDanhMuc();
            sp_LayThongTinBuuCucResult _DV = dDM.LayDvi();

            daNopTienNganHangTaiKhoan dNTK = new daNopTienNganHangTaiKhoan();
            dNTK.NTK.IDNopTien = IDNopTien;
            if(_DV!=null)
            {
                dNTK.MaDonVi = _DV.MaDonVi;
            }
            lstTK = dNTK.lstDanhSach();

            HienThiDuLieu();
        }

        public void GanSoTienTK(double rSoTien)
        {
            lstTK[ViTri].SoTien = Convert.ToDecimal(rSoTien);
            for(int i=0;i<dgv.RowCount;i++)
            {
                if(Convert.ToInt32(dgv.Rows[i].Cells["STT"].Value)==ViTri)
                {
                    dgv.Rows[i].Cells["SoTien"].Value= lstTK[ViTri].SoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                    break;
                }
            }
        }

        public void LuuDuLieu()
        {
            daNopTienNganHangTaiKhoan dNTK = new daNopTienNganHangTaiKhoan();
            dNTK.NTK.IDNopTien = IDNopTien;
            dNTK.Xoa();
            foreach(sp_tblNopTienNganHangTaiKhoan_DanhSachResult pt in lstTK)
            {
                if(pt.SoTien!=0)
                {
                    dNTK.NTK = pt;
                    dNTK.NTK.IDNopTien = IDNopTien;
                    dNTK.Them();
                }
            }
        }
        #endregion
    }
}
