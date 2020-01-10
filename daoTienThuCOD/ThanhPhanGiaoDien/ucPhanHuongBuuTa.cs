using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.PhanHuongBuuTa;
using BarcodeLib;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucPhanHuongBuuTa : UserControl
    {
        public ucPhanHuongBuuTa()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
        }

        #region Khai bao
        private sp_tblPhanBuuTaTHop_DanhSachResult _PHBT = new sp_tblPhanBuuTaTHop_DanhSachResult();
        public List<sp_tblPhanBuuTa_DanhSach_BuuTaResult> lstPHBT = new List<sp_tblPhanBuuTa_DanhSach_BuuTaResult>();

        public sp_tblPhanBuuTaTHop_DanhSachResult PHBT { get => _PHBT; set => _PHBT = value; }
        private daXuaBaoCao dXE = new daXuaBaoCao();
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
            dXE.mTieuDeBaoCao = "DANH SÁCH CHI TIẾT BƯU GỬI PHÂN HƯỚNG CHO BƯU TÁ";
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

            for (int i = 0; i < lstPHBT.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;

                Dong.Cells["ItemCode"].Value = lstPHBT[i].ItemCode.ToString();


                img = b.Encode(BarcodeLib.TYPE.CODE128A, lstPHBT[i].ItemCode.ToString(), Color.Black, Color.White, 250, 50);
                Dong.Cells["MaVach"].Value = img;

                Dong.Cells["MailTripNumber"].Value = lstPHBT[i].MailTripNumber.Value.ToString("#######");
                Dong.Cells["PostBagNumber"].Value = lstPHBT[i].PostBagNumber.Value.ToString("######");
                Dong.Cells["IncomingDate"].Value = lstPHBT[i].IncomingDate.Value;

                Dong.Cells["Weight"].Value = lstPHBT[i].Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["Value"].Value = lstPHBT[i].Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["SendingContent"].Value = lstPHBT[i].SendingContent;
                Dong.Cells["ReceiverFullname"].Value = lstPHBT[i].ReceiverFullname;
                Dong.Cells["ReceiverAddress"].Value = lstPHBT[i].ReceiverAddress;
                Dong.Cells["ReceiverTel"].Value = lstPHBT[i].ReceiverTel;
                Dong.Cells["DaPhat"].Value = lstPHBT[i].DaPhat;
                Dong.Cells["DaChuyenHoan"].Value = lstPHBT[i].DaChuyenHoan;

                Dong.Height = 60;
            }
        }
        #endregion

        #region Chung
        public void HienThi(bool TheoBuuTa)
        {
            daPhanBuuTa dPBT = new daPhanBuuTa();
            dPBT.BGPhat.FromPoscode = PHBT.FromPoscode;
            dPBT.BGPhat.Ngay = PHBT.Ngay;
            dPBT.BGPhat.Ca = PHBT.Ca;
            dPBT.BGPhat.ToPoscode = PHBT.ToPoscode;
            dPBT.BGPhat.ServiceCode = PHBT.ServiceCode;
            dPBT.BGPhat.MailTripNumber = PHBT.MailTripNumber;
            dPBT.BGPhat.PostBagNumber = PHBT.PostBagNumber;

            if(TheoBuuTa)
            {
                lstPHBT = dPBT.lstDanhSach_BuuTa();
            }
            else
            {
                lstPHBT = dPBT.lstDanhSach_ChuyenThu();
            }

            HienThiDuLieu();
        }
        #endregion

        
    }
}
