using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.ThanhPhanGiaoDien;

namespace LaySoLieu.TienCOD
{
    public partial class frmQuanLyTienCOD : Form
    {
        public frmQuanLyTienCOD()
        {
            InitializeComponent();
        }

        #region Khai bao
        ucBuuGuiDenPhatTHop uBGDenPhat = new ucBuuGuiDenPhatTHop();
        ucPhanHuongBuuTaTHop uPhanHuongBuuTa = new ucPhanHuongBuuTaTHop();
        ucTraTienCOD uTraTienCOD = new ucTraTienCOD();
        //ucBuuGuiChuyenHoan uChuyenHoan = new ucBuuGuiChuyenHoan();
        ucChuyenHoanChuyenTiep uChuyenHoan = new ucChuyenHoanChuyenTiep();
        ucKeToanCuoiNgayBuuTa uKeToanBuuTa = new ucKeToanCuoiNgayBuuTa();

        public string MaBuuCuc;
        DateTime Ngay = DateTime.Now;
        #endregion

        #region giao dien chung
        private void frmQuanLyTienCOD_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void frmQuanLyTienCOD_Resize(object sender, EventArgs e)
        {
            btnDong.Left = this.Width - btnDong.Width - 10;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Den Phat
        private void btnBuuGuiDenPhat_Click(object sender, EventArgs e)
        {
            uBGDenPhat.Dock = DockStyle.Fill;
            try
            {
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            catch { }
            uBGDenPhat.ThamSo.MaBuuCuc = MaBuuCuc;
            uBGDenPhat.ThamSo.TuNgay = Ngay;
            uBGDenPhat.ThamSo.DenNgay = Ngay;
            uBGDenPhat.HienThi();
            splitContainer1.Panel2.Controls.Add(uBGDenPhat);
        }
        #endregion

        #region Phan huong buu ta
        private void btnPhanHuongBuuTa_Click(object sender, EventArgs e)
        {
            uPhanHuongBuuTa.Dock = DockStyle.Fill;
            try
            {
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            catch { }
            uPhanHuongBuuTa.ThamSo.MaBuuCuc = MaBuuCuc;
            uPhanHuongBuuTa.ThamSo.TuNgay = Ngay;
            uPhanHuongBuuTa.ThamSo.DenNgay = Ngay;
            uPhanHuongBuuTa.HienThi();
            splitContainer1.Panel2.Controls.Add(uPhanHuongBuuTa);
        }
        #endregion

        #region Chuyen hoan
        private void btnBuuGuiChuyenHoan_Click(object sender, EventArgs e)
        {
            uChuyenHoan.Dock = DockStyle.Fill;
            try
            {
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            catch { }
            uChuyenHoan.ThamSo.MaBuuCuc = MaBuuCuc;
            uChuyenHoan.ThamSo.TuNgay = Ngay;
            uChuyenHoan.ThamSo.DenNgay = Ngay;
            
            splitContainer1.Panel2.Controls.Add(uChuyenHoan);
        }
        #endregion

        #region Thu tien COD
        private void btnBuuGuiDaThuTienCOD_Click(object sender, EventArgs e)
        {
            uTraTienCOD.Dock = DockStyle.Fill;
            try
            {
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            catch { }
            uTraTienCOD.ThamSo.MaBuuCuc = MaBuuCuc;
            uTraTienCOD.ThamSo.TuNgay = Ngay;
            uTraTienCOD.ThamSo.DenNgay = Ngay;
            uTraTienCOD.HienThi();
            splitContainer1.Panel2.Controls.Add(uTraTienCOD);
        }
        #endregion

        #region Vu hoi
        private void btnVuHoiBuuTa_Click(object sender, EventArgs e)
        {
            uKeToanBuuTa.Dock = DockStyle.Fill;
            try
            {
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            catch { }
            uKeToanBuuTa.ThamSo.MaBuuCuc = MaBuuCuc;
            uKeToanBuuTa.ThamSo.TuNgay = Ngay;
            uKeToanBuuTa.ThamSo.DenNgay = Ngay;
            uKeToanBuuTa.HienThi();
            splitContainer1.Panel2.Controls.Add(uKeToanBuuTa);
        }
        #endregion
    }
}
