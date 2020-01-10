using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.SoLieuDen;
using BarcodeLib;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucBuuGuiDenPhat : UserControl
    {
        public ucBuuGuiDenPhat()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
        }

        #region Khai bao
        public List<sp_tblSLDen_DanhSachResult> lstDen = new List<sp_tblSLDen_DanhSachResult>();
        private daBase _ThamSo = new daBase();
        private sp_tblSLDen_ThongTInResult _BGThamSo = new sp_tblSLDen_ThongTInResult();
        private daXuaBaoCao dXE = new daXuaBaoCao();
        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }
        public sp_tblSLDen_ThongTInResult BGThamSo { get => _BGThamSo; set => _BGThamSo = value; }
        #endregion

        #region Su kien
        private void ucBuuGuiDenPhat_Resize(object sender, EventArgs e)
        {
            btnXuatExcel.Top = this.Top + dgv.Top + dgv.ColumnHeadersHeight;
            btnInBaoCao.Top = btnXuatExcel.Top;
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
            dXE.grdDuLieu = dgv;
            dXE.XuatExcel();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {            
            dXE.grdDuLieu = dgv;
            dXE.mTieuDeBaoCao = "DANH SÁCH CHI TIẾT BƯU GỬI ĐẾN";
            dXE.InBaoCao();
        }

        private void dXE_Chay(object sender, EventArgs e)
        {
            
        }

        private void dXE_ChayXong(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Hien Thi
        public void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            Barcode b = new Barcode();
            Image img;

            b.IncludeLabel = false;

            for (int i = 0; i < lstDen.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;

                Dong.Cells["ItemCode"].Value = lstDen[i].ItemCode.ToString();

                
                img = b.Encode(BarcodeLib.TYPE.CODE128A, lstDen[i].ItemCode.ToString(), Color.Black, Color.White, 250, 50);
                Dong.Cells["MaVach"].Value = img;

                Dong.Cells["FromPOSCode"].Value = lstDen[i].FromPOSCode.ToString();
                Dong.Cells["MailTripNumber"].Value = lstDen[i].MailTripNumber.Value.ToString("#######");
                Dong.Cells["PostBagNumber"].Value = lstDen[i].PostBagNumber.Value.ToString("######");
                Dong.Cells["IncomingDate"].Value = lstDen[i].IncomingDate.Value;

                Dong.Cells["Weight"].Value=lstDen[i].Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["Value"].Value = lstDen[i].Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["SendingContent"].Value = lstDen[i].SendingContent;
                Dong.Cells["ReceiverFullname"].Value = lstDen[i].ReceiverFullname;
                Dong.Cells["ReceiverAddress"].Value = lstDen[i].ReceiverAddress;
                Dong.Cells["ReceiverTel"].Value = lstDen[i].ReceiverTel;
                Dong.Cells["DaPhat"].Value = lstDen[i].DaPhat;
                Dong.Cells["DaChuyenHoan"].Value = lstDen[i].DaChuyenHoan;
                Dong.Cells["DaHuy"].Value = lstDen[i].DaHuy;

                Dong.Height = 60;
            }            
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daSLDen dSLDen = new daSLDen();
            dSLDen.BGDen = BGThamSo;
            lstDen = dSLDen.lstDanhSach_ChuyenThu();
            HienThiDuLieu();
        }
        #endregion

        
    }
}
