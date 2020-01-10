using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using BarcodeLib;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class grdChuyenHoanChuyenTiep : UserControl
    {
        public grdChuyenHoanChuyenTiep()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
        }

        #region Khai bao
        public List<sp_tblChuyenHoan_DanhSachResult> lstCH = new List<sp_tblChuyenHoan_DanhSachResult>();
        private daXuaBaoCao dXE = new daXuaBaoCao();
        #endregion

        #region Chung
        public void HienThiDuLieu()
        {
            pgb.Visible = true;
            pgb.Maximum = lstCH.Count + 1;
            pgb.Value = 0;

            dgv.Rows.Clear();
            DataGridViewRow Dong;
            Barcode b = new Barcode();
            Image img;

            b.IncludeLabel = false;

            for (int i = 0; i < lstCH.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;

                Dong.Cells["ItemCode"].Value = lstCH[i].ItemCode.ToString();


                img = b.Encode(BarcodeLib.TYPE.CODE128A, lstCH[i].ItemCode.ToString(), Color.Black, Color.White, 250, 50);
                Dong.Cells["MaVach"].Value = img;

                Dong.Cells["NgayChuyenHoan"].Value = lstCH[i].NgayChuyenHoan.Value;
                Dong.Cells["LyDo"].Value = lstCH[i].LyDo;

                Dong.Cells["Weight"].Value = lstCH[i].Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["SoTienCOD"].Value = lstCH[i].SoTienCOD.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ReceiverFullname"].Value = lstCH[i].ReceiverFullname;
                Dong.Cells["ReceiverAddress"].Value = lstCH[i].ReceiverAddress;
                Dong.Cells["ReceiverTel"].Value = lstCH[i].ReceiverTel;
                Dong.Cells["TongCuoc"].Value = lstCH[i].TongCuoc.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["VAT"].Value = lstCH[i].VAT.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["ThanhTien"].Value = lstCH[i].ThanhTien.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 60;

                if (i == 10)
                {
                    dgv.Refresh();
                }
                pgb.Value = pgb.Value + 1;
            }
            pgb.Visible = false;
        }
        #endregion

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

        private void dXE_Chay(object sender, EventArgs e)
        {
            pgb.Value = pgb.Value + 1;
        }

        private void dXE_ChayXong(object sender, EventArgs e)
        {
            pgb.Visible = false;
        }
    }
}
