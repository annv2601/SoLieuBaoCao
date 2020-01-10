using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.KeToan;
using daoTienThuCOD.Khac;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucKeToanBuuTa : UserControl
    {
        public ucKeToanBuuTa()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
        }

        #region Khai bao
        private List<sp_tblKeToan_DanhSachResult> lstKTBT = new List<sp_tblKeToan_DanhSachResult>();
        private daBase _ThamSo = new daBase();

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }
        private daXuaBaoCao dXE = new daXuaBaoCao();
        #endregion

        #region Rieng
        private void DanhSachBuuTa()
        {
            daBuuTa dBT = new daBuuTa();
            cboBuuTa.DisplayMember = "TenBuuTa";
            cboBuuTa.ValueMember = "MaBuuTa";
            dBT.MaBuuCuc = ThamSo.MaBuuCuc;
            cboBuuTa.DataSource = dBT.DanhSachChon();
            cboBuuTa.SelectedIndex = -1;
        }

        private void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            for (int i = 0; i < lstKTBT.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;
                Dong.Cells["Ngay"].Value = lstKTBT[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["MaBuuTa"].Value = lstKTBT[i].MaBuuTa.ToString();
                Dong.Cells["Ten"].Value = lstKTBT[i].Ten.ToString();

                
                Dong.Cells["DuDauSanLuong"].Value = lstKTBT[i].DuDauSanLuong.Value.ToString("######");                
                Dong.Cells["DuDauSoTien"].Value = lstKTBT[i].DuDauSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NhanMoiSanLuong"].Value = lstKTBT[i].NhanMoiSanLuong.Value.ToString("######");
                Dong.Cells["NhanMoiSoTien"].Value = lstKTBT[i].NhanMoiSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["TraSanLuong"].Value = lstKTBT[i].TraSanLuong.Value.ToString("######");
                Dong.Cells["TraSoTien"].Value = lstKTBT[i].TraSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ChuyenHoanSanLuong"].Value = lstKTBT[i].ChuyenHoanSanLuong.Value.ToString("######");
                Dong.Cells["ChuyenHoanSoTien"].Value = lstKTBT[i].ChuyenHoanSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["PSGiamKhacSanLuong"].Value = lstKTBT[i].PSGiamKhacSanLuong.Value.ToString("######");
                Dong.Cells["PSGiamKhacSoTien"].Value = lstKTBT[i].PSGiamKhacSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["DuCuoiSanLuong"].Value = lstKTBT[i].DuCuoiSanLuong.Value.ToString("######");
                Dong.Cells["DuCuoiSoTien"].Value = lstKTBT[i].DuCuoiSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 25;
            }

            //Dong tong cong
            Dong = dgv.Rows[dgv.Rows.Add()];

            Dong.Cells["STT"].Value = lstKTBT.Count;
            Dong.Cells["Ngay"].Value = "";
            Dong.Cells["MaBuuTa"].Value = "";
            Dong.Cells["Ten"].Value = "Tổng cộng";

            Dong.Cells["DuDauSanLuong"].Value = lstKTBT.FindAll(n => n.Ngay.Value.ToString("dd/MM/yyy") == txtTuNgay.Value.ToString("dd/MM/yyyy")).ToList().Sum(x => x.DuDauSanLuong).Value.ToString("######");
            Dong.Cells["DuDauSoTien"].Value = lstKTBT.FindAll(n => n.Ngay.Value.ToString("dd/MM/yyy") == txtTuNgay.Value.ToString("dd/MM/yyyy")).ToList().Sum(x => x.DuDauSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["NhanMoiSanLuong"].Value = lstKTBT.Sum(x => x.NhanMoiSanLuong).Value.ToString("######");
            Dong.Cells["NhanMoiSoTien"].Value = lstKTBT.Sum(x => x.NhanMoiSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["TraSanLuong"].Value = lstKTBT.Sum(x => x.TraSanLuong).Value.ToString("######");
            Dong.Cells["TraSoTien"].Value = lstKTBT.Sum(x => x.TraSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["ChuyenHoanSanLuong"].Value = lstKTBT.Sum(x => x.ChuyenHoanSanLuong).Value.ToString("######");
            Dong.Cells["ChuyenHoanSoTien"].Value = lstKTBT.Sum(x => x.ChuyenHoanSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["PSGiamKhacSanLuong"].Value = lstKTBT.Sum(x => x.PSGiamKhacSanLuong).Value.ToString("######");
            Dong.Cells["PSGiamKhacSoTien"].Value = lstKTBT.Sum(x => x.PSGiamKhacSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            DateTime _ngay;
            if (lstKTBT.Count > 0)
            {
                _ngay = lstKTBT[0].Ngay.Value;
            }
            else
            {
                _ngay = txtDenNgay.Value;
            }
            Dong.Cells["DuCuoiSanLuong"].Value = lstKTBT.FindAll(n => n.Ngay.Value.ToString("dd/MM/yyy") == _ngay.ToString("dd/MM/yyyy")).ToList().Sum(x => x.DuCuoiSanLuong).Value.ToString("######");
            Dong.Cells["DuCuoiSoTien"].Value = lstKTBT.FindAll(n => n.Ngay.Value.ToString("dd/MM/yyy") == _ngay.ToString("dd/MM/yyyy")).ToList().Sum(x => x.DuCuoiSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            //lstKTBT.FindAll(n => n.Ngay.Value.ToString("dd/MM/yyy") == txtDenNgay.Value.ToString("dd/MM/yyyy")).Sum;
            //List<sp_tblKeToan_DanhSachResult> lst1 = lstKTBT.FindAll(n => n.Ngay.Value.ToString("dd/MM/yyy") == txtDenNgay.Value.ToString("dd/MM/yyyy")).ToList();

            Dong.Height = 30;

            Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            //=======================
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daKeToanBuuTa dKTBT = new daKeToanBuuTa();
            dKTBT.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBT.TuNgay = ThamSo.TuNgay;
            dKTBT.DenNgay = ThamSo.DenNgay;

            lstKTBT = dKTBT.lstDanhSachBuuCuc();
            HienThiDuLieu();

            DanhSachBuuTa();
        }
        #endregion

        private void ucBuuGuiDenPhat_Resize(object sender, EventArgs e)
        {
            dgv.Height = this.Height - groupBox1.Height - 10;
            btnXuatExcel.Top = this.Top + dgv.Top + dgv.ColumnHeadersHeight;
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            System.Drawing.Font rowFont = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            daKeToanBuuTa dKTBT = new daKeToanBuuTa();
            dKTBT.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBT.TuNgay = txtTuNgay.Value;
            dKTBT.DenNgay = txtDenNgay.Value;

            if (cboBuuTa.SelectedValue == null || cboBuuTa.SelectedValue.ToString() == "" || cboBuuTa.SelectedValue.ToString() == "000000")
            {
                lstKTBT = dKTBT.lstDanhSachBuuCuc();
            }
            else
            {
                dKTBT.MaBuuTa = cboBuuTa.SelectedValue.ToString();
                lstKTBT = dKTBT.lstDanhSachBuuTa();
            }
            
            HienThiDuLieu();
            if (lstKTBT.Count == 0)
            {
                MessageBox.Show("Không có số liệu!");
            }
        }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            daKeToanBuuTa dKTBT = new daKeToanBuuTa();
            dKTBT.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBT.Ngay = txtTuNgay.Value;
            dKTBT.KetChuyen();

            dKTBT.TuNgay = txtTuNgay.Value;
            dKTBT.DenNgay = txtTuNgay.Value;

            lstKTBT = dKTBT.lstDanhSachBuuCuc();
            HienThiDuLieu();

            MessageBox.Show("Đã tổng hợp xong số liệu cho Ngày "+txtTuNgay.Value.ToString("dd/MM/yyyy"));
        }

        private void dgv_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X >= this.Left && e.X <= this.Left + 150) && (e.Y >= this.Top + dgv.ColumnHeadersHeight && e.Y <= this.Top + dgv.ColumnHeadersHeight + 40))
            {
                btnXuatExcel.Visible = true;
            }
            else
            {
                btnXuatExcel.Visible = false;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            dXE.grdDuLieu = dgv;
            dXE.XuatExcel();
        }

        private void dXE_Chay(object sender, EventArgs e)
        {
            
        }

        private void dXE_ChayXong(object sender, EventArgs e)
        {
            
        }

        private void btnKeToanBuuCuc_Click(object sender, EventArgs e)
        {
            frmKeToanBuuCuc csKTBC = new frmKeToanBuuCuc();
            csKTBC.cVuHoiBuuCuc.ThamSo.MaBuuCuc = ThamSo.MaBuuCuc;
            csKTBC.cVuHoiBuuCuc.ThamSo.Ngay = DateTime.Now;
            csKTBC.cVuHoiBuuCuc.HienThi();
            csKTBC.Show();
        }
    }
}
