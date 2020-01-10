using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using daoSLCT.Database;

namespace daoSLCT.grdDuLieu
{
    public partial class grdDoanhThuBCCP : UserControl
    {
        public grdDoanhThuBCCP()
        {
            InitializeComponent();
        }

        public List<sp_tblKinhDoanhGhiNo_BaoCaoResult> lstGN = new List<sp_tblKinhDoanhGhiNo_BaoCaoResult>();
        public List<sp_tblKinhDoanhTiemMat_BaoCaoResult> lstTM = new List<sp_tblKinhDoanhTiemMat_BaoCaoResult>();
        public List<sp_tblKinhDoanhGhiNoKhachHang_BaoCaoResult> lstKH = new List<sp_tblKinhDoanhGhiNoKhachHang_BaoCaoResult>();

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

        public void HienThiDuLieuGhiNo()
        {
            dgv.Rows.Clear();

            dgv.Columns["MaKhachHangCRM"].Visible = false;
            dgv.Columns["TenKhachHangCRM"].Visible = false;

            DataGridViewRow Dong;
            for (int i = 0; i < lstGN.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];
                
                Dong.Cells["Ngay"].Value = lstGN[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["MaDichVu"].Value = lstGN[i].MaDichVu;
                Dong.Cells["TenDichVu"].Value = lstGN[i].TenDichVu;

                Dong.Cells["NTSoLuong"].Value = lstGN[i].NTSoLuong == null ? "" : lstGN[i].NTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTTrongLuong"].Value = lstGN[i].NTTrongLuong == null ? "" : lstGN[i].NTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTSoTienCOD"].Value = lstGN[i].NTSoTienCOD == null ? "" : lstGN[i].NTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTCuoc"].Value = lstGN[i].NTCuoc == null ? "" : lstGN[i].NTCuoc.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTVAT"].Value = lstGN[i].NTVAT == null ? "" : lstGN[i].NTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTThanhTien"].Value = lstGN[i].NTThanhTien == null ? "" : lstGN[i].NTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTThanhTienCOD"].Value = lstGN[i].NTThanhTienCOD == null ? "" : lstGN[i].NTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["LTSoLuong"].Value = lstGN[i].LTSoLuong == null ? "" : lstGN[i].LTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTTrongLuong"].Value = lstGN[i].LTTrongLuong == null ? "" : lstGN[i].LTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTSoTienCOD"].Value = lstGN[i].LTSoTienCOD == null ? "" : lstGN[i].LTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTCuoc"].Value = lstGN[i].LTVAT == null ? "" : lstGN[i].LTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTVAT"].Value = lstGN[i].LTVAT == null ? "" : lstGN[i].LTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTThanhTien"].Value = lstGN[i].LTThanhTien == null ? "" : lstGN[i].LTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTThanhTienCOD"].Value = lstGN[i].LTThanhTienCOD == null ? "" : lstGN[i].LTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["QTSoLuong"].Value = lstGN[i].QTSoLuong == null ? "" : lstGN[i].QTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTTrongLuong"].Value = lstGN[i].QTTrongLuong == null ? "" : lstGN[i].QTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTSoTienCOD"].Value = lstGN[i].QTSoTienCOD == null ? "" : lstGN[i].QTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTCuoc"].Value = lstGN[i].QTCuoc == null ? "" : lstGN[i].QTCuoc.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTVAT"].Value = lstGN[i].QTVAT == null ? "" : lstGN[i].QTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTThanhTien"].Value = lstGN[i].QTThanhTien == null ? "" : lstGN[i].QTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTThanhTienCOD"].Value = lstGN[i].QTThanhTienCOD == null ? "" : lstGN[i].QTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["STT"].Value = i;

                if (lstGN[i].InDam.Value)
                {
                    Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
                }                
            }
        }

        public void HienThiDuLieuTienMat()
        {
            dgv.Rows.Clear();

            dgv.Columns["MaKhachHangCRM"].Visible = false;
            dgv.Columns["TenKhachHangCRM"].Visible = false;

            DataGridViewRow Dong;
            for (int i = 0; i < lstTM.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];
                
                Dong.Cells["Ngay"].Value = lstTM[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["MaDichVu"].Value = lstTM[i].MaDichVu;
                Dong.Cells["TenDichVu"].Value = lstTM[i].TenDichVu;

                Dong.Cells["NTSoLuong"].Value = lstTM[i].NTSoLuong == null ? "" : lstTM[i].NTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTTrongLuong"].Value = lstTM[i].NTTrongLuong == null ? "" : lstTM[i].NTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTSoTienCOD"].Value = lstTM[i].NTSoTienCOD == null ? "" : lstTM[i].NTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTCuoc"].Value = lstTM[i].NTCuoc == null ? "" : lstTM[i].NTCuoc.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTVAT"].Value = lstTM[i].NTVAT == null ? "" : lstTM[i].NTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTThanhTien"].Value = lstTM[i].NTThanhTien == null ? "" : lstTM[i].NTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTThanhTienCOD"].Value = lstTM[i].NTThanhTienCOD == null ? "" : lstTM[i].NTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["LTSoLuong"].Value = lstTM[i].LTSoLuong == null ? "" : lstTM[i].LTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTTrongLuong"].Value = lstTM[i].LTTrongLuong == null ? "" : lstTM[i].LTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTSoTienCOD"].Value = lstTM[i].LTSoTienCOD == null ? "" : lstTM[i].LTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTCuoc"].Value = lstTM[i].LTVAT == null ? "" : lstTM[i].LTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTVAT"].Value = lstTM[i].LTVAT == null ? "" : lstTM[i].LTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTThanhTien"].Value = lstTM[i].LTThanhTien == null ? "" : lstTM[i].LTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTThanhTienCOD"].Value = lstTM[i].LTThanhTienCOD == null ? "" : lstTM[i].LTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["QTSoLuong"].Value = lstTM[i].QTSoLuong == null ? "" : lstTM[i].QTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTTrongLuong"].Value = lstTM[i].QTTrongLuong == null ? "" : lstTM[i].QTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTSoTienCOD"].Value = lstTM[i].QTSoTienCOD == null ? "" : lstTM[i].QTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTCuoc"].Value = lstTM[i].QTCuoc == null ? "" : lstTM[i].QTCuoc.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTVAT"].Value = lstTM[i].QTVAT == null ? "" : lstTM[i].QTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTThanhTien"].Value = lstTM[i].QTThanhTien == null ? "" : lstTM[i].QTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTThanhTienCOD"].Value = lstTM[i].QTThanhTienCOD == null ? "" : lstTM[i].QTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["STT"].Value = i;

                if (lstTM[i].InDam.Value)
                {
                    Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
                }
            }
        }

        public void HienThiDuLieuGhiNoKhachHang()
        {
            dgv.Rows.Clear();
            
            dgv.Columns["MaKhachHangCRM"].Visible = true;
            dgv.Columns["TenKhachHangCRM"].Visible = true;

            DataGridViewRow Dong;
            for (int i = 0; i < lstKH.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["Ngay"].Value = lstKH[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["MaDichVu"].Value = lstKH[i].MaDichVu;
                Dong.Cells["TenDichVu"].Value = lstKH[i].TenDichVu;
                Dong.Cells["MaKhachHangCRM"].Value = lstKH[i].MaKhachHangCRM;
                Dong.Cells["TenKhachHangCRM"].Value = lstKH[i].TenKhachHangCRM;

                Dong.Cells["NTSoLuong"].Value = lstKH[i].NTSoLuong == null ? "" : lstKH[i].NTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTTrongLuong"].Value = lstKH[i].NTTrongLuong == null ? "" : lstKH[i].NTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTSoTienCOD"].Value = lstKH[i].NTSoTienCOD == null ? "" : lstKH[i].NTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTCuoc"].Value = lstKH[i].NTCuoc == null ? "" : lstKH[i].NTCuoc.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTVAT"].Value = lstKH[i].NTVAT == null ? "" : lstKH[i].NTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTThanhTien"].Value = lstKH[i].NTThanhTien == null ? "" : lstKH[i].NTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["NTThanhTienCOD"].Value = lstKH[i].NTThanhTienCOD == null ? "" : lstKH[i].NTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["LTSoLuong"].Value = lstKH[i].LTSoLuong == null ? "" : lstKH[i].LTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTTrongLuong"].Value = lstKH[i].LTTrongLuong == null ? "" : lstKH[i].LTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTSoTienCOD"].Value = lstKH[i].LTSoTienCOD == null ? "" : lstKH[i].LTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTCuoc"].Value = lstKH[i].LTVAT == null ? "" : lstKH[i].LTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTVAT"].Value = lstKH[i].LTVAT == null ? "" : lstKH[i].LTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTThanhTien"].Value = lstKH[i].LTThanhTien == null ? "" : lstKH[i].LTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["LTThanhTienCOD"].Value = lstKH[i].LTThanhTienCOD == null ? "" : lstKH[i].LTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["QTSoLuong"].Value = lstKH[i].QTSoLuong == null ? "" : lstKH[i].QTSoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTTrongLuong"].Value = lstKH[i].QTTrongLuong == null ? "" : lstKH[i].QTTrongLuong.Value.ToString("N3", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTSoTienCOD"].Value = lstKH[i].QTSoTienCOD == null ? "" : lstKH[i].QTSoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTCuoc"].Value = lstKH[i].QTCuoc == null ? "" : lstKH[i].QTCuoc.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTVAT"].Value = lstKH[i].QTVAT == null ? "" : lstKH[i].QTVAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTThanhTien"].Value = lstKH[i].QTThanhTien == null ? "" : lstKH[i].QTThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["QTThanhTienCOD"].Value = lstKH[i].QTThanhTienCOD == null ? "" : lstKH[i].QTThanhTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Cells["STT"].Value = i;

                if (lstKH[i].InDam.Value)
                {
                    Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
                }
            }
        }

        private void dgv_Resize(object sender, EventArgs e)
        {
            btnXuatExcel.Top = this.Top + dgv.ColumnHeadersHeight;
            btnInBaoCao.Top = btnXuatExcel.Top;
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

            if ((e.X >= btnInBaoCao.Left && e.X <= btnInBaoCao.Left + 150) && (e.Y >= this.Top + dgv.ColumnHeadersHeight && e.Y <= this.Top + dgv.ColumnHeadersHeight + 40))
            {
                btnInBaoCao.Visible = true;
            }
            else
            {
                btnInBaoCao.Visible = false;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            daXuatExcel dXE = new daXuatExcel();
            dXE.grdDuLieu = dgv;
            dXE.XuatExcel();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            daXuatExcel dXE = new daXuatExcel();
            dXE.grdDuLieu = dgv;
            dXE.mTieuDeBaoCao = "BÁO CÁO DÒNG TIỀN PHÁT SINH";
            dXE.InBaoCao();
        }
    }
}
