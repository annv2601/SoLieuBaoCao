using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.Client;
using daoTienThuCOD.Database;
using daoTienThuCOD.NopTienNganHang;
using daoTienThuCOD.KeToan;
using DocSo;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class frmBanKeNopTien : Form
    {
        public frmBanKeNopTien()
        {
            InitializeComponent();
        }

        #region Khai bao
        public int IDNopTien;
        private bool CoThayDoi = false;
        public double TongTienCo = 0;
        private double TongTienNop = 0;
        private daBase _ThamSo = new daBase();

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }

        #endregion

        #region Rieng
        private void HienThiThongTin(sp_tblNopTienNganHang_ThongTinResult pt)
        {
            txtNguoiGiao.Text = pt.NguoiGiao;
            txtCMNDNguoiGiao.Text = pt.CMND;
            txtChucDanhNguoiGiao.Text = pt.ChucDanh;
            try
            {
                txtNgayCapNguoGiao.Value = pt.NgayCap.Value;
            }
            catch { }
            txtNoiCapNguoiGiao.Text = pt.NoiCap;

            txtNguoiNhan.Text = pt.NguoiNhan;
            txtCMNDNguoiNhan.Text = pt.CMNDNguoiNhan;
            txtChucDanhNguoiNhan.Text = pt.ChucDanhNguoiNhan;
            try
            {
                txtNgayCapNguoiNhan.Value = pt.NgayCapCMNDNguoiNhan.Value;
            }
            catch { }
            txtNoiCapNguoiNhan.Text = pt.NoiCap;

            txtDiaDiemGiaoNhan.Text = pt.DiaDiemGiaoNhan;
            txtPhuongThucGiaoNhan.Text = pt.PhuongThucGiaoNhan;
            txtChiNhanhNganHang.Text = pt.ChiNhanhNganHangGiaoNhan;
        }
        #endregion

        #region Chung
        public void HienThiBanKe()
        {
            grdTaiKhoan1.IDNopTien = IDNopTien;
            grdTaiKhoan1.HienThi();

            grdMenhGia1.IDNopTien = IDNopTien;
            grdMenhGia1.HienThi();

            lblTongTienCo.Text= TongTienCo.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            lblBKNopTien.Text = "BẢN KÊ NỘP TIỀN NGÀY "+ThamSo.Ngay.ToString("dd/MM/yyyy");
        }

        public void HienThiNguoiDungSan()
        {
            daDanhMuc dDM = new daDanhMuc();
            sp_tblNopTienNganHang_ThongTinResult pt;
            pt = dDM.LayND();
            if(pt!=null)
            {
                HienThiThongTin(pt);
            }

        }

        public void KiemTraDaNopTien()
        {
            daNopTienNganHang dNNH = new daNopTienNganHang();
            dNNH.NTNH.Ngay = ThamSo.Ngay;
            dNNH.NTNH.MaBuuCuc = ThamSo.MaBuuCuc;
            IDNopTien = dNNH.KiemTra();
            if(IDNopTien==0)
            {
                btnCapNhat.Visible = true;
                btnIn.Visible = false;
            }
            else
            {
                btnCapNhat.Visible = false;
                btnIn.Visible = true;
            }
        }
        #endregion

        private void grdMenhGia1_Nhap(object sender, EventArgs e)
        {
            TongTienNop = Convert.ToDouble(sender);
            grdTaiKhoan1.GanSoTienTK(TongTienNop);

            btnCapNhat.Visible = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if(CoThayDoi)
            {
                daDanhMuc dDM = new daDanhMuc();
                sp_tblNopTienNganHang_ThongTinResult pt=new sp_tblNopTienNganHang_ThongTinResult();
                pt.NguoiGiao = txtNguoiGiao.Text.Trim();
                pt.CMND = txtCMNDNguoiGiao.Text.Trim();
                pt.ChucDanh = txtChucDanhNguoiGiao.Text.Trim();
                pt.NgayCap = txtNgayCapNguoGiao.Value;
                pt.NoiCap = txtNoiCapNguoiGiao.Text.Trim();

                pt.NguoiNhan = txtNguoiNhan.Text.Trim();
                pt.CMNDNguoiNhan = txtCMNDNguoiNhan.Text;
                pt.ChucDanhNguoiNhan = txtChucDanhNguoiNhan.Text;
                pt.NgayCapCMNDNguoiNhan = txtNgayCapNguoiNhan.Value;
                pt.NoiCapCMNDNguoiNhan = txtNoiCapNguoiNhan.Text.Trim();

                pt.DiaDiemGiaoNhan = txtDiaDiemGiaoNhan.Text.Trim();
                pt.PhuongThucGiaoNhan = txtPhuongThucGiaoNhan.Text.Trim();
                pt.ChiNhanhNganHangGiaoNhan = txtChiNhanhNganHang.Text.Trim();

                dDM.ThemDMND(pt);
            }

            if (TongTienNop<=0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Số tiền nộp không thể bằng 0 (không). Anh/chị không thể lập được bản kê nộp tiền!");
                return;
            }

            /*if(TongTienCo+30000<TongTienNop)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Số tiền nộp nhiều hơn số tiền có. Anh/chị không thể lập được bản kê nộp tiền!");
                return;
            }
            else
            {
                if (TongTienCo > TongTienNop+300000)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Đề nghị đơn vị phải nộp hết tiền về ngân hàng!");
                    return;
                }

                if (TongTienCo>TongTienNop)
                {
                    if(MessageBox.Show(this,"Số nộp tiền ít hơn số tiền có. Anh/chị có chắc chắn chỉ muốn nộp "+TongTienNop.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN")) +" này chứ?","Nộp tiền ngân hàng",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
                    {
                        Cursor = Cursors.Default;
                        return;
                    }
                }
            }*/

            if (TongTienCo > TongTienNop)
            {
                if (MessageBox.Show(this, "Số nộp tiền ít hơn số tiền có. Anh/chị có chắc chắn chỉ muốn nộp " + TongTienNop.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN")) + " này chứ?", "Nộp tiền ngân hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }

            daNopTienNganHang dNNH = new daNopTienNganHang();
            dNNH.NTNH.ID = 0;
            dNNH.NTNH.MaBuuCuc = ThamSo.MaBuuCuc;
            dNNH.NTNH.Ngay = ThamSo.Ngay;
            dNNH.NTNH.Gio = DateTime.Now.TimeOfDay;
            dNNH.NTNH.Lan = 1;
            dNNH.NTNH.NguoiGiao = txtNguoiGiao.Text.Trim();
            dNNH.NTNH.ChucDanh = txtChucDanhNguoiGiao.Text.Trim();
            dNNH.NTNH.CMND = txtCMNDNguoiGiao.Text.Trim();
            dNNH.NTNH.NgayCap = txtNgayCapNguoGiao.Value;
            dNNH.NTNH.NoiCap = txtNoiCapNguoiGiao.Text.Trim();
            dNNH.NTNH.NguoiNhan = txtNguoiNhan.Text.Trim();
            dNNH.NTNH.ChucDanhNguoiNhan = txtChucDanhNguoiNhan.Text.Trim();
            dNNH.NTNH.CMNDNguoiNhan = txtCMNDNguoiNhan.Text.Trim();
            dNNH.NTNH.NgayCapCMNDNguoiNhan = txtNgayCapNguoiNhan.Value;
            dNNH.NTNH.NoiCapCMNDNguoiNhan = txtNoiCapNguoiNhan.Text.Trim();
            dNNH.NTNH.TongTienNop = Convert.ToDecimal(TongTienNop);

            DocSo.DocSo _dso = new DocSo.DocSo();            
            dNNH.NTNH.BangChu = _dso.DocSoDayDu(dNNH.NTNH.TongTienNop.ToString())+" đồng chẵn";
            dNNH.NTNH.TongTienCo = Convert.ToDecimal(TongTienCo);
            dNNH.NTNH.DiaDiemGiaoNhan = txtDiaDiemGiaoNhan.Text.Trim();
            dNNH.NTNH.PhuongThucGiaoNhan = txtPhuongThucGiaoNhan.Text.Trim();
            dNNH.NTNH.ChiNhanhNganHangGiaoNhan = txtChiNhanhNganHang.Text.Trim();

            IDNopTien = dNNH.ThemSua();

            grdMenhGia1.IDNopTien = IDNopTien;
            grdMenhGia1.LuuDuLieu();

            grdTaiKhoan1.IDNopTien = IDNopTien;
            grdTaiKhoan1.LuuDuLieu();

            //Tong hop so lieu 
            daKeToanCuoiNgay dKTCN = new daKeToanCuoiNgay();
            dKTCN.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTCN.Ngay = ThamSo.Ngay;
            dKTCN.KetChuyen();

            /*daKeToanBuuTaNgay dKTBT = new daKeToanBuuTaNgay();
            dKTBT.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBT.Ngay = ThamSo.Ngay;
            dKTBT.KetChuyen();

            daKeToanBuuCuc dKTBC = new daKeToanBuuCuc();
            dKTBC.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBC.Ngay = ThamSo.Ngay;
            dKTBC.ketChuyen();*/
            //=======================

            btnCapNhat.Visible = false;
            btnIn.Visible = true;

            Cursor = Cursors.Default;
            MessageBox.Show("Bản kê đã được lập thành công!");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            daNopTienNganHang dNNH = new daNopTienNganHang();
            daNopTienNganHangMenhGia dNMG = new daNopTienNganHangMenhGia();
            daNopTienNganHangTaiKhoan dNTK = new daNopTienNganHangTaiKhoan();

            frmBanIn csBanIn = new frmBanIn();
            dNNH.NTNH.ID = IDNopTien;
            csBanIn.Bang1 = dNNH.DanhSach();

            daDanhMuc dDM = new daDanhMuc();
            sp_LayThongTinBuuCucResult pt = dDM.LayDvi();
            if (pt != null)
            {
                dNTK.MaDonVi = pt.MaDonVi;
            }
            dNTK.NTK.IDNopTien = IDNopTien;
            csBanIn.Bang2 = dNTK.DanhSach();

            dNMG.NMG.IDNopTien = IDNopTien;
            csBanIn.Bang3 = dNMG.DanhSach();

            csBanIn.HienThiBanInNopNganHang();
            csBanIn.Show();
        }

        private void txtNguoiGiao_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtCMNDNguoiGiao_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtNguoiNhan_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtCMNDNguoiNhan_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtChucDanhNguoiGiao_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtChucDanhNguoiNhan_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtNoiCapNguoiGiao_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtNoiCapNguoiNhan_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtNgayCapNguoGiao_ValueChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtNgayCapNguoiNhan_ValueChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtDiaDiemGiaoNhan_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }

        private void txtChiNhanhNganHang_TextChanged(object sender, EventArgs e)
        {
            CoThayDoi = true;
        }
    }
}
