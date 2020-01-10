using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.ChuyenHoan;
using daoTienThuCOD.DocVaDay;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucChuyenHoanChuyenTiep : UserControl
    {
        public ucChuyenHoanChuyenTiep()
        {
            InitializeComponent();
            SoLieuDiPhat.Luu += new daSoLieuNhanVe.LuuHandler(SoLieuDiPhat_Luu);
            SoLieuDiPhat.LuuXong += new daSoLieuNhanVe.LuuXongHandler(SoLieuDiPhat_LuuXong);
        }

        #region Khai bao
        private daSoLieuNhanVe SoLieuDiPhat = new daSoLieuNhanVe();
        private daBase _ThamSo = new daBase();

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }

        #endregion

        #region Rieng
        private void DocVaGhiDuLieuChuyenHoan()
        {
            SoLieuDiPhat.Ca = 2;
            SoLieuDiPhat.DocVaLuuChuyenHoan();
        }

        private void DocVaGhiDuLieuChuyenTiep()
        {
            SoLieuDiPhat.Ca = 2;
            SoLieuDiPhat.DocVaLuuChuyenTiep();
        }
        #endregion

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            daChuyenHoan dCH = new daChuyenHoan();
            dCH.MaBuuCuc = ThamSo.MaBuuCuc;
            dCH.TuNgay = txtNgay.Value;
            dCH.DenNgay = txtNgay.Value;
            grdChuyenHoan1.lstCH = dCH.lstDanhSach();
            grdChuyenHoan1.HienThiDuLieu();

            daChuyenTiep dCT = new daChuyenTiep();
            dCT.MaBuuCuc = ThamSo.MaBuuCuc;
            dCT.TuNgay = txtNgay.Value;
            dCT.DenNgay = txtNgay.Value;
            grdChuyenTiep1.lstCH = dCT.lstDanhSach();
            grdChuyenTiep1.HienThiDuLieu();
        }

        private void ucChuyenHoanChuyenTiep_Resize(object sender, EventArgs e)
        {
            tabControl1.Height = this.Height - groupBox1.Height - 10;
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            pgb.Value = 0;
            pgb.Maximum = 100;
            pgb.Visible = true;
            SoLieuDiPhat.Ngay = txtNgay.Value;

            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuChuyenHoan();
                    DocVaGhiDuLieuChuyenTiep();
                }));
            BackThread.Start();
        }

        private void SoLieuDiPhat_Luu(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;
        }

        private void SoLieuDiPhat_LuuXong(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => {
                    pgb.Visible = false;

                    btnHienThi_Click(sender, e);
                }));
        }
    }
}
