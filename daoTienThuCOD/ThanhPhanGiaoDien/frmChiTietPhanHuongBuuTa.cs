using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class frmChiTietPhanHuongBuuTa : Form
    {
        public frmChiTietPhanHuongBuuTa()
        {
            InitializeComponent();
        }


        #region Khai bao
        private sp_tblPhanBuuTaTHop_DanhSachResult _CTBT = new sp_tblPhanBuuTaTHop_DanhSachResult();
        private bool _TheoBuuTa;

        public sp_tblPhanBuuTaTHop_DanhSachResult CTBT { get => _CTBT; set => _CTBT = value; }
        public bool TheoBuuTa { get => _TheoBuuTa; set => _TheoBuuTa = value; }

        #endregion

        #region Rieng
        private void HienThiThongTin()
        {
            lblNgay.Visible = true;
            lblCa.Visible = true;
            lblBuuTa.Visible = true;            
            txtNgay.Visible = true;
            txtCa.Visible = true;
            txtBuuTa.Visible = true;

            txtNgay.Text = CTBT.Ngay.Value.ToString("dd/MM/yyyy");
            txtCa.Text = CTBT.Ca.ToString();
            txtBuuTa.Text = CTBT.FullName;
            txtSoBuuGui.Text=CTBT.SoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            txtTongTienCOD.Text = CTBT.Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            if (TheoBuuTa)
            {                
                lblChuyenThu.Visible = false;
                txtChuyenThu.Visible = false;
            }
            else
            {
                lblChuyenThu.Visible = true;
                txtChuyenThu.Visible = true;

                txtChuyenThu.Text = CTBT.MailTripNumber.Value.ToString("#######");
            }
        }
        #endregion

        private void frmChiTietPhanHuongBuuTa_Resize(object sender, EventArgs e)
        {
            grdPHBTa.Height = this.Height - groupBox1.Height - 10;
        }

        public void HienThiDuLieu()
        {
            grdPHBTa.PHBT = CTBT;
            HienThiThongTin();
            grdPHBTa.HienThi(TheoBuuTa);
        }
    }
}
