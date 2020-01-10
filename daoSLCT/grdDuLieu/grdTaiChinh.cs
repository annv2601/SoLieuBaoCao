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
    public partial class grdTaiChinh : UserControl
    {
        public grdTaiChinh()
        {
            InitializeComponent();
        }

        public List<sp_tblTaiChinhTapChung_BaoCaoResult> lstTC = new List<sp_tblTaiChinhTapChung_BaoCaoResult>();

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

        public void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            for (int i = 0; i < lstTC.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["Ngay"].Value = lstTC[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["MaDichVu"].Value = lstTC[i].MaDichVu;
                Dong.Cells["TenDichVu"].Value = lstTC[i].TenDichVu;

                Dong.Cells["TienThu"].Value = lstTC[i].TienThu == null ? "" : lstTC[i].TienThu.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["TienChi"].Value = lstTC[i].TienChi == null ? "" : lstTC[i].TienChi.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["TienKinhDoanhGhiNo"].Value = lstTC[i].TienKinhDoanhGhiNo == null ? "" : lstTC[i].TienKinhDoanhGhiNo.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["TienKinhDoanhTienMat"].Value = lstTC[i].TienKinhDoanhTienMat == null ? "" : lstTC[i].TienKinhDoanhTienMat.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                if (lstTC[i].InDam.Value)
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
