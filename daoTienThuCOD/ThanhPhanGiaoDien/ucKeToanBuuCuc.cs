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
using daoSLPH.Untities;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucKeToanBuuCuc : UserControl
    {
        public ucKeToanBuuCuc()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
        }

        #region Khai bao
        private List<sp_tblKeToanBuuCucCuoiNgay_DanhSachResult> lstKTBT = new List<sp_tblKeToanBuuCucCuoiNgay_DanhSachResult>();
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
                Dong.Cells["MaBuuCuc"].Value = lstKTBT[i].MaBuuCuc.ToString();
                                
                Dong.Cells["DuDauSanLuong"].Value = lstKTBT[i].DuDauSanLuong.Value.ToString("######");                
                Dong.Cells["DuDauSoTien"].Value = lstKTBT[i].DuDauSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NhanMoiSanLuong"].Value = lstKTBT[i].NhanMoiSanLuong.Value.ToString("######");
                Dong.Cells["NhanMoiSoTien"].Value = lstKTBT[i].NhanMoiSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["PhanBuuTaSanLuong"].Value = lstKTBT[i].PhanBuuTaSanLuong.Value.ToString("######");
                Dong.Cells["PhanBuuTaSoTien"].Value = lstKTBT[i].PhanBuuTaSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["TraSanLuong"].Value = lstKTBT[i].TraSanLuong.Value.ToString("######");
                Dong.Cells["TraSoTien"].Value = lstKTBT[i].TraSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ChuyenHoanSanLuong"].Value = lstKTBT[i].ChuyenHoanSanLuong.Value.ToString("######");
                Dong.Cells["ChuyenHoanSoTien"].Value = lstKTBT[i].ChuyenHoanSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ChuyenTiepSanLuong"].Value = lstKTBT[i].ChuyenTiepSanLuong.Value.ToString("######");
                Dong.Cells["ChuyenTiepSoTien"].Value = lstKTBT[i].ChuyenTiepSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["DuCuoiSanLuong"].Value = lstKTBT[i].DuCuoiSanLuong.Value.ToString("######");
                Dong.Cells["DuCuoiSoTien"].Value = lstKTBT[i].DuCuoiSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 25;
            }

            //Dong tong cong
            if (lstKTBT.Count > 0)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = lstKTBT.Count;
                Dong.Cells["Ngay"].Value = "";
                Dong.Cells["MaBuuCuc"].Value = "";

                Dong.Cells["DuDauSanLuong"].Value = lstKTBT[lstKTBT.Count-1].DuDauSanLuong.Value.ToString("######");
                Dong.Cells["DuDauSoTien"].Value = lstKTBT[lstKTBT.Count-1].DuDauSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["NhanMoiSanLuong"].Value = lstKTBT.Sum(x => x.NhanMoiSanLuong).Value.ToString("######");
                Dong.Cells["NhanMoiSoTien"].Value = lstKTBT.Sum(x => x.NhanMoiSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["PhanBuuTaSanLuong"].Value = lstKTBT.Sum(x => x.PhanBuuTaSanLuong).Value.ToString("######");
                Dong.Cells["PhanBuuTaSoTien"].Value = lstKTBT.Sum(x => x.PhanBuuTaSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["TraSanLuong"].Value = lstKTBT.Sum(x => x.TraSanLuong).Value.ToString("######");
                Dong.Cells["TraSoTien"].Value = lstKTBT.Sum(x => x.TraSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ChuyenHoanSanLuong"].Value = lstKTBT.Sum(x => x.ChuyenHoanSanLuong).Value.ToString("######");
                Dong.Cells["ChuyenHoanSoTien"].Value = lstKTBT.Sum(x => x.ChuyenHoanSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ChuyenTiepSanLuong"].Value = lstKTBT.Sum(x => x.ChuyenTiepSanLuong).Value.ToString("######");
                Dong.Cells["ChuyenTiepSoTien"].Value = lstKTBT.Sum(x => x.ChuyenTiepSoTien).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["DuCuoiSanLuong"].Value = lstKTBT[0].DuCuoiSanLuong.Value.ToString("######");
                Dong.Cells["DuCuoiSoTien"].Value = lstKTBT[0].DuCuoiSoTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 30;

                Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            }
            //=======================
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            txtTuNgay.Value = daTienIch.NgayDauThang(Convert.ToByte(ThamSo.Ngay.Month), ThamSo.Ngay.Year);
            txtDenNgay.Value = ThamSo.Ngay;

            daKeToanCuoiNgay dKTBC = new daKeToanCuoiNgay();
            dKTBC.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBC.TuNgay = txtTuNgay.Value;
            dKTBC.DenNgay = txtDenNgay.Value;

            lstKTBT = dKTBC.BuuCuc_DanhSach();
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
            daKeToanCuoiNgay dKTBC = new daKeToanCuoiNgay();
            dKTBC.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBC.TuNgay = txtTuNgay.Value;
            dKTBC.DenNgay = txtDenNgay.Value;

            lstKTBT = dKTBC.BuuCuc_DanhSach();
                        
            HienThiDuLieu();
            if (lstKTBT.Count == 0)
            {
                MessageBox.Show("Không có số liệu!");
            }
        }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            /*daKeToanBuuCuc dKTBC = new daKeToanBuuCuc();
            dKTBC.MaBuuCuc = ThamSo.MaBuuCuc;
            dKTBC.Ngay = txtTuNgay.Value;

            dKTBC.ketChuyen();

            dKTBC.TuNgay = txtTuNgay.Value;
            dKTBC.DenNgay = txtTuNgay.Value;

            lstKTBT = dKTBC.lstDanhSachBuuCuc();
            HienThiDuLieu();

            MessageBox.Show("Đã tổng hợp xong số liệu cho Ngày "+txtTuNgay.Value.ToString("dd/MM/yyyy"));*/
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

        private void btnChotSoLieu_Click(object sender, EventArgs e)
        {
            daTrangThaiKeToan dTT = new daTrangThaiKeToan();
            dTT.MaBuuCuc = ThamSo.MaBuuCuc;
            dTT.Ngay = txtTuNgay.Value;
            if(dTT.LayNgayChot()!=null)
            {
                if (dTT.NgayChot.Ngay.Value.AddDays(1).ToShortDateString() == txtTuNgay.Value.ToShortDateString())
                {
                    dTT.TThai.MaBuuCuc = ThamSo.MaBuuCuc;
                    dTT.TThai.Ngay = txtTuNgay.Value;

                    daThongTinMay dTTM = new daThongTinMay();                    
                    dTT.TThai.DiaChiIP = dTTM.DiaChiIP;
                    dTT.TThai.TenMay = dTTM.TenMay;
                    dTT.TThai.MAC = dTTM.MAC;
                    dTT.TThai.ChotSoLieu = true;
                    dTT.Them();
                    MessageBox.Show("Hoàn thành chốt số liệu ngày " + txtTuNgay.Value.ToString("dd/MM/yyyy"));
                }
                else
                {
                    MessageBox.Show("Số liệu đã được chốt vào ngày " + dTT.NgayChot.Ngay.Value.ToString("dd/MM/yyyy")+". Anh/chị không thể chốt số liệu vào ngày "+ txtTuNgay.Value.ToString("dd/MM/yyyy"));
                }
            }
            else
            {
                if (txtTuNgay.Value.Year == 2018)
                {
                    dTT.TThai.MaBuuCuc = ThamSo.MaBuuCuc;
                    dTT.TThai.Ngay = txtTuNgay.Value;

                    daThongTinMay dTTM = new daThongTinMay();
                    dTT.TThai.DiaChiIP = dTTM.DiaChiIP;
                    dTT.TThai.TenMay = dTTM.TenMay;
                    dTT.TThai.MAC = dTTM.MAC;
                    dTT.TThai.ChotSoLieu = true;
                    dTT.Them();
                    MessageBox.Show("Hoàn thành chốt số liệu ngày " + txtTuNgay.Value.ToString("dd/MM/yyyy"));
                }
                else
                {
                    MessageBox.Show("Anh/chị chưa chốt số liệu ngày nào. Xin hãy liên hệ với quản trị!");
                }
            }
        }

        private void btnQuanLyChotSoLieu_Click(object sender, EventArgs e)
        {
            frmDanhSachNgayChot csDSNgayChot = new frmDanhSachNgayChot();
            csDSNgayChot.MaBuuCuc = ThamSo.MaBuuCuc;
            daTrangThaiKeToan dTT = new daTrangThaiKeToan();
            dTT.MaBuuCuc = ThamSo.MaBuuCuc;
            csDSNgayChot.lstNgayChot = dTT.lstDanhSach();
            csDSNgayChot.HienThiDuLieu();
            csDSNgayChot.Show();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dgv.CurrentRow.Cells["STT"].Value);
            sp_tblKeToanBuuCucCuoiNgay_DanhSachResult _ch;
            _ch = lstKTBT[i];
            frmBuuGuiGiuLai csBGGLai = new frmBuuGuiGiuLai();
            csBGGLai.ThamSo.MaBuuCuc = ThamSo.MaBuuCuc;
            csBGGLai.ThamSo.Ngay = _ch.Ngay.Value;
            switch (dgv.CurrentCell.ColumnIndex)
            {
                case 2:
                    csBGGLai.HienThiDuDauBuuCuc();
                    csBGGLai.Show();
                    break;
                case 3:
                    csBGGLai.HienThiDuDauBuuCuc();
                    csBGGLai.Show();
                    break;
                case 4:
                    
                    break;
                case 5:

                    break;
                case 11:
                    
                    break;
                case 12:
                    
                    break;
                case 14:
                    csBGGLai.HienThiDuCuoiBuuCuc();
                    csBGGLai.Show();
                    break;
                case 15:
                    csBGGLai.HienThiDuCuoiBuuCuc();
                    csBGGLai.Show();
                    break;
            }
        }
    }
}
