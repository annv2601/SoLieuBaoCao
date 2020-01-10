using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.GiuLai;
using daoTienThuCOD.KeToan;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class frmBuuGuiGiuLai : Form
    {
        public frmBuuGuiGiuLai()
        {
            InitializeComponent();
        }

        #region Khai bao
        private daBase _ThamSo = new daBase();

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }
        #endregion

        #region Chung
        public void HienThiBuuTaTraLai()
        {
            this.Text = "Danh sách Bưu gửi Bưu tá trả lại";

            daBuuTaGiuLai dBCLG = new daBuuTaGiuLai();
            dBCLG.MaBuuCuc = ThamSo.MaBuuCuc;
            dBCLG.MaBuuTa = ThamSo.MaBuuTa;
            dBCLG.TuNgay = ThamSo.TuNgay;
            dBCLG.DenNgay = ThamSo.DenNgay;

            ucBuuGuiGiuLai1.HienThiDuLieuBTaTraLai(dBCLG.lstDanhSachTra());
        }

        public void HienThiDuCuoiBuuCuc()
        {
            this.Text = "Danh sách Bưu gửi tồn cuối ngày";

            daKeToanCuoiNgay dBCLG = new daKeToanCuoiNgay();
            dBCLG.MaBuuCuc = ThamSo.MaBuuCuc;
            dBCLG.Ngay = ThamSo.Ngay;

            ucBuuGuiGiuLai1.HienThiDuLieuBuuCucDuCuoi(dBCLG.lstDuCuoiCTiet());
        }

        public void HienThiDuDauBuuCuc()
        {
            this.Text = "Danh sách Bưu gửi mang sang từ hôm trước";

            daKeToanCuoiNgay dBCLG = new daKeToanCuoiNgay();
            dBCLG.MaBuuCuc = ThamSo.MaBuuCuc;
            dBCLG.Ngay = ThamSo.Ngay;

            ucBuuGuiGiuLai1.HienThiDuLieuBuuCucDuDau(dBCLG.lstDuDauCTiet());
        }
        #endregion

        private void ucBuuGuiGiuLai1_Hien(object sender, EventArgs e)
        {

        }

        private void ucBuuGuiGiuLai1_HienXong(object sender, EventArgs e)
        {

        }
    }
}
