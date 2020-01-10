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
    public partial class ucKeToanCuoiNgayBuuTa : UserControl
    {
        public ucKeToanCuoiNgayBuuTa()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
            //csBCGL.KetThuc += new frmBuuCucGiuLai.KetThucHandler(csBCGL_KetThuc);
        }

        #region Khai bao
        //private frmBuuCucGiuLai csBCGL = new frmBuuCucGiuLai();        

        private List<sp_tblKeToanBuuTaCuoiNgay_DanhSachResult> lstKTBT = new List<sp_tblKeToanBuuTaCuoiNgay_DanhSachResult>();
        private daBase _ThamSo = new daBase();

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }
        private daXuaBaoCao dXE = new daXuaBaoCao();
        #endregion

        #region Rieng        

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
                Dong.Cells["TenBuuTa"].Value = lstKTBT[i].TenBuuTa.ToString();
                                
                Dong.Cells["NhanMoiSanLuong"].Value = lstKTBT[i].NhanMoiSanLuong.Value.ToString("######");
                Dong.Cells["NhanMoiSoTien"].Value = lstKTBT[i].NhanMoiSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["TraSanLuong"].Value = lstKTBT[i].TraSanLuong.Value.ToString("######");
                Dong.Cells["TraSoTien"].Value = lstKTBT[i].TraSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ChuyenHoanSanLuong"].Value = lstKTBT[i].ChuyenHoanSanLuong.Value.ToString("######");
                Dong.Cells["ChuyenHoanSoTien"].Value = lstKTBT[i].ChuyenHoanSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["TraLaiSanLuong"].Value = lstKTBT[i].TraLaiSanLuong.Value.ToString("######");
                Dong.Cells["TraLaiSoTien"].Value = lstKTBT[i].TraLaiSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ChuyenTiepSanLuong"].Value = lstKTBT[i].ChuyenTiepSanLuong.Value.ToString("######");
                Dong.Cells["ChuyenTiepSoTien"].Value = lstKTBT[i].ChuyenTiepSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 25;
            }

            //Dong tong cong
            Dong = dgv.Rows[dgv.Rows.Add()];

            Dong.Cells["STT"].Value = lstKTBT.Count;
            Dong.Cells["Ngay"].Value = "";
            Dong.Cells["MaBuuTa"].Value = "";
            Dong.Cells["TenBuuTa"].Value = "Tổng cộng";

            
            Dong.Cells["NhanMoiSanLuong"].Value = lstKTBT.Sum(x => x.NhanMoiSanLuong).Value.ToString("######");
            Dong.Cells["NhanMoiSoTien"].Value = lstKTBT.Sum(x => x.NhanMoiSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["TraSanLuong"].Value = lstKTBT.Sum(x => x.TraSanLuong).Value.ToString("######");
            Dong.Cells["TraSoTien"].Value = lstKTBT.Sum(x => x.TraSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["ChuyenHoanSanLuong"].Value = lstKTBT.Sum(x => x.ChuyenHoanSanLuong).Value.ToString("######");
            Dong.Cells["ChuyenHoanSoTien"].Value = lstKTBT.Sum(x => x.ChuyenHoanSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["TraLaiSanLuong"].Value = lstKTBT.Sum(x => x.TraLaiSanLuong).Value.ToString("######");
            Dong.Cells["TraLaiSoTien"].Value = lstKTBT.Sum(x => x.TraLaiSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["ChuyenTiepSanLuong"].Value = lstKTBT.Sum(x => x.ChuyenTiepSanLuong).Value.ToString("######");
            Dong.Cells["ChuyenTiepSoTien"].Value = lstKTBT.Sum(x => x.ChuyenTiepSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            Dong.Height = 30;

            Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            //=======================
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daKeToanCuoiNgay dKTBT = new daKeToanCuoiNgay();
            dKTBT.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBT.TuNgay = ThamSo.TuNgay;
            dKTBT.DenNgay = ThamSo.DenNgay;
            dKTBT.Ngay = ThamSo.TuNgay;

            lstKTBT = dKTBT.BuuTa_DanhSach();
            HienThiDuLieu();
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
            daKeToanCuoiNgay dKTBT = new daKeToanCuoiNgay();
            dKTBT.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBT.TuNgay = txtTuNgay.Value;
            dKTBT.DenNgay = txtTuNgay.Value;
            dKTBT.Ngay = txtTuNgay.Value;

            lstKTBT = dKTBT.BuuTa_DanhSach();
            
            HienThiDuLieu();
            if (lstKTBT.Count == 0)
            {
                MessageBox.Show("Không có số liệu!");
            }
        }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            daKeToanCuoiNgay dKTBT = new daKeToanCuoiNgay();
            dKTBT.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBT.Ngay = txtTuNgay.Value;
            dKTBT.KetChuyen();

            dKTBT.TuNgay = txtTuNgay.Value;
            dKTBT.DenNgay = txtTuNgay.Value;

            lstKTBT = dKTBT.BuuTa_DanhSach();
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

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            int i = Convert.ToInt32(dgv.CurrentRow.Cells["STT"].Value);
            sp_tblKeToanBuuTaCuoiNgay_DanhSachResult _ch;
            _ch = lstKTBT[i];
            
            switch (dgv.CurrentCell.ColumnIndex)
            {
                case 1:
                    break;
                case 3:
                    frmChiTietPhanHuongBuuTa csCTPHBT = new frmChiTietPhanHuongBuuTa();
                    csCTPHBT.TheoBuuTa = true;
                    csCTPHBT.CTBT.Ngay = _ch.Ngay;
                    csCTPHBT.CTBT.Ca = 1;
                    csCTPHBT.CTBT.FullName = _ch.TenBuuTa;
                    csCTPHBT.CTBT.SoLuong = _ch.NhanMoiSanLuong;
                    csCTPHBT.CTBT.Value = Convert.ToDouble(_ch.NhanMoiSoTien);

                    csCTPHBT.CTBT.FromPoscode = ThamSo.MaBuuCuc;
                    csCTPHBT.CTBT.Ngay = _ch.Ngay;
                    csCTPHBT.CTBT.ToPoscode = _ch.MaBuuTa.Substring(6,_ch.MaBuuTa.Length-6);

                    csCTPHBT.HienThiDuLieu();
                    csCTPHBT.Show();
                    break;
                case 4:
                    frmChiTietPhanHuongBuuTa csCTPHBTT = new frmChiTietPhanHuongBuuTa();
                    csCTPHBTT.TheoBuuTa = true;
                    csCTPHBTT.CTBT.Ngay = _ch.Ngay;
                    csCTPHBTT.CTBT.Ca = 1;
                    csCTPHBTT.CTBT.FullName = _ch.TenBuuTa;
                    csCTPHBTT.CTBT.SoLuong = _ch.NhanMoiSanLuong;
                    csCTPHBTT.CTBT.Value = Convert.ToDouble(_ch.NhanMoiSoTien);

                    csCTPHBTT.CTBT.FromPoscode = ThamSo.MaBuuCuc;
                    csCTPHBTT.CTBT.Ngay = _ch.Ngay;
                    csCTPHBTT.CTBT.ToPoscode = _ch.MaBuuTa.Substring(6, _ch.MaBuuTa.Length - 6);

                    csCTPHBTT.HienThiDuLieu();
                    csCTPHBTT.Show();
                    break;
                case 5:

                    break;
                case 11:
                    frmBuuGuiGiuLai csBCGL = new frmBuuGuiGiuLai();
                    csBCGL.ThamSo.MaBuuCuc = _ch.MaBuuCuc;
                    csBCGL.ThamSo.MaBuuTa = _ch.MaBuuTa;
                    csBCGL.ThamSo.TuNgay = _ch.Ngay.Value;
                    csBCGL.ThamSo.DenNgay = _ch.Ngay.Value;
                    csBCGL.HienThiBuuTaTraLai();
                    csBCGL.Show();
                    break;
                case 12:
                    frmBuuGuiGiuLai csBCGLt = new frmBuuGuiGiuLai();
                    csBCGLt.ThamSo.MaBuuCuc = _ch.MaBuuCuc;
                    csBCGLt.ThamSo.MaBuuTa = _ch.MaBuuTa;
                    csBCGLt.ThamSo.TuNgay = _ch.Ngay.Value;
                    csBCGLt.ThamSo.DenNgay = _ch.Ngay.Value;
                    csBCGLt.HienThiBuuTaTraLai();
                    csBCGLt.Show();
                    break;
            }
        }

        private void csBCGL_KetThuc(object sender, EventArgs e)
        {
            btnHienThi_Click(sender, e);
        }

        private void btnVuHoiBC_Click(object sender, EventArgs e)
        {
            frmKeToanBuuCuc csKTBC = new frmKeToanBuuCuc();
            csKTBC.cVuHoiBuuCuc.ThamSo.MaBuuCuc = ThamSo.MaBuuCuc;
            csKTBC.cVuHoiBuuCuc.ThamSo.Ngay = txtTuNgay.Value;
            csKTBC.cVuHoiBuuCuc.HienThi();
            csKTBC.Show();
        }
    }
}
