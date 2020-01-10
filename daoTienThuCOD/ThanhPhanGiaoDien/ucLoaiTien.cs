using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucLoaiTien : UserControl
    {
        public ucLoaiTien()
        {
            InitializeComponent();
        }

        #region Thuoc tinh
        public string TenLoaiTien
        {
            get { return lblLoaiTien.Text; }
            set { lblLoaiTien.Text = value; }
        }

        public int SoTo
        {
            get
            {
                return int.Parse(txtSoTo.Text.Replace(",", "").Replace(".", ""));
            }
            set
            {
                txtSoTo.Text=value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
        }

        public decimal ThanhTien
        {
            get
            {
                return decimal.Parse(lblThanhTien.Text.Replace(",", "").Replace(".", ""));
            }
            set
            {
                lblThanhTien.Text= value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
        }
        #endregion

        #region Khai bao
        public int MenhGia=0;
        #endregion

        #region Su kien
        private void ucLoaiTien_Resize(object sender, EventArgs e)
        {
            int DoDai, ChieuCao;
            DoDai = this.Width;
            ChieuCao = this.Height;

            lblLoaiTien.Height = ChieuCao;
            lblLoaiTien.Top = this.Top;
            lblLoaiTien.Left = 0;
            lblLoaiTien.Width = DoDai / 3;

            txtSoTo.Height = ChieuCao;
            txtSoTo.Top = this.Top;
            txtSoTo.Left = DoDai / 3;
            txtSoTo.Width = DoDai / 3;

            lblThanhTien.Height = ChieuCao;
            lblThanhTien.Top = this.Top;
            lblThanhTien.Left = 2 * DoDai / 3;
            lblThanhTien.Width = DoDai / 3;
        }

        private void txtSoTo_Enter(object sender, EventArgs e)
        {
            txtSoTo.BackColor = Color.Turquoise;
            txtSoTo.SelectAll();
        }

        private void txtSoTo_Leave(object sender, EventArgs e)
        {
            txtSoTo.BackColor = Color.White;
        }

        private void txtSoTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            string _soto;
            _soto = txtSoTo.Text.Replace(".", "").Replace(",", "");
            int _st;
            if(int.TryParse(_soto,out _st))
            {
                decimal _thanhtien;
                _thanhtien = _st * MenhGia;
                ThanhTien = _thanhtien;
            }
            else
            {
                ThanhTien = 0;
            }
        }
        #endregion
    }
}
