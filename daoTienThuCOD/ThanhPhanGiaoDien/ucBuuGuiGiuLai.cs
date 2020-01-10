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
    public partial class ucBuuGuiGiuLai : UserControl
    {
        public ucBuuGuiGiuLai()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
        }

        #region Khai bao
        public event HienThiHandler Hien;
        public delegate void HienThiHandler(object sender, EventArgs e);
        public event HienThiXongHandler HienXong;
        public delegate void HienThiXongHandler(object sender, EventArgs e);

        private sp_tblPhanBuuTa_DanhSach_THopResult _PHBT = new sp_tblPhanBuuTa_DanhSach_THopResult();
        public List<sp_tblBuuCucGiuLai_DanhSachResult> lstPHBT = new List<sp_tblBuuCucGiuLai_DanhSachResult>();

        public sp_tblPhanBuuTa_DanhSach_THopResult PHBT { get => _PHBT; set => _PHBT = value; }
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

                Dong.Cells["MaBuuTa"].Value = lstPHBT[i].MaBuuTa.ToString();
                Dong.Cells["TenBuuTa"].Value = lstPHBT[i].TenBuuTa.ToString();
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
                Hien(i, null);
            }
            HienXong(null, null);
        }

        public void ThemBuuGui(sp_tblBuuCucGiuLai_DanhSachResult rBG)
        {           
            DataGridViewRow Dong;
            Barcode b = new Barcode();
            Image img;

            b.IncludeLabel = false;

            lstPHBT.Add(rBG);

            //Dong = dgv.Rows[dgv.Rows.Add()];
            dgv.Rows.Insert(0);
            Dong = dgv.Rows[0];

            Dong.Cells["STT"].Value = lstPHBT.Count-1;

            Dong.Cells["MaBuuTa"].Value = rBG.MaBuuTa.ToString();
            Dong.Cells["TenBuuTa"].Value = rBG.TenBuuTa.ToString();
            Dong.Cells["ItemCode"].Value = rBG.ItemCode.ToString();


            img = b.Encode(BarcodeLib.TYPE.CODE128A, rBG.ItemCode.ToString(), Color.Black, Color.White, 250, 50);
            Dong.Cells["MaVach"].Value = img;

            Dong.Cells["MailTripNumber"].Value = rBG.MailTripNumber.Value.ToString("#######");
            Dong.Cells["PostBagNumber"].Value = rBG.PostBagNumber.Value.ToString("######");
            Dong.Cells["IncomingDate"].Value = rBG.IncomingDate.Value;

            Dong.Cells["Weight"].Value = rBG.Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["Value"].Value = rBG.Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["SendingContent"].Value = rBG.SendingContent;
            Dong.Cells["ReceiverFullname"].Value = rBG.ReceiverFullname;
            Dong.Cells["ReceiverAddress"].Value = rBG.ReceiverAddress;
            Dong.Cells["ReceiverTel"].Value = rBG.ReceiverTel;
            Dong.Cells["DaPhat"].Value = rBG.DaPhat;
            Dong.Cells["DaChuyenHoan"].Value = rBG.DaChuyenHoan;

            Dong.Height = 60;
        }
        #endregion

        #region Chung
        public void HienThiDuLieuBTaTraLai(List<sp_tblBuuTaTraLai_DanhSachResult> lst)
        {            
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            Barcode b = new Barcode();
            Image img;

            b.IncludeLabel = false;

            for (int i = 0; i < lst.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;

                Dong.Cells["MaBuuTa"].Value = lst[i].MaBuuTa.ToString();
                Dong.Cells["TenBuuTa"].Value = lst[i].FullName.ToString();
                Dong.Cells["ItemCode"].Value = lst[i].ItemCode.ToString();


                img = b.Encode(BarcodeLib.TYPE.CODE128A, lst[i].ItemCode.ToString(), Color.Black, Color.White, 250, 50);
                Dong.Cells["MaVach"].Value = img;

                Dong.Cells["MailTripNumber"].Value = lst[i].MailTripNumber.Value.ToString("#######");
                Dong.Cells["PostBagNumber"].Value = lst[i].PostBagNumber.Value.ToString("######");
                Dong.Cells["IncomingDate"].Value = lst[i].IncomingDate.Value;

                Dong.Cells["Weight"].Value = lst[i].Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["Value"].Value = lst[i].Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["SendingContent"].Value = lst[i].SendingContent;
                Dong.Cells["ReceiverFullname"].Value = lst[i].ReceiverFullname;
                Dong.Cells["ReceiverAddress"].Value = lst[i].ReceiverAddress;
                Dong.Cells["ReceiverTel"].Value = lst[i].ReceiverTel;
                Dong.Cells["DaPhat"].Value = lst[i].DaPhat;
                Dong.Cells["DaChuyenHoan"].Value = lst[i].DaChuyenHoan;

                Dong.Height = 60;
                Hien(i, null);
            }
            HienXong(null, null);
        }

        public void HienThiDuLieuBuuCucDuCuoi(List<sp_tblBuuCucDuCuoi_DanhSachResult> lst)
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            Barcode b = new Barcode();
            Image img;

            b.IncludeLabel = false;

            for (int i = 0; i < lst.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;

                Dong.Cells["MaBuuTa"].Value = lst[i].MaBuuTa.ToString();
                Dong.Cells["TenBuuTa"].Value = lst[i].FullName.ToString();
                Dong.Cells["ItemCode"].Value = lst[i].ItemCode.ToString();


                img = b.Encode(BarcodeLib.TYPE.CODE128A, lst[i].ItemCode.ToString(), Color.Black, Color.White, 250, 50);
                Dong.Cells["MaVach"].Value = img;

                Dong.Cells["MailTripNumber"].Value = lst[i].MailTripNumber.Value.ToString("#######");
                Dong.Cells["PostBagNumber"].Value = lst[i].PostBagNumber.Value.ToString("######");
                Dong.Cells["IncomingDate"].Value = lst[i].IncomingDate.Value;

                Dong.Cells["Weight"].Value = lst[i].Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["Value"].Value = lst[i].Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["SendingContent"].Value = lst[i].SendingContent;
                Dong.Cells["ReceiverFullname"].Value = lst[i].ReceiverFullname;
                Dong.Cells["ReceiverAddress"].Value = lst[i].ReceiverAddress;
                Dong.Cells["ReceiverTel"].Value = lst[i].ReceiverTel;
                Dong.Cells["DaPhat"].Value = lst[i].DaPhat;
                Dong.Cells["DaChuyenHoan"].Value = lst[i].DaChuyenHoan;

                Dong.Height = 60;
                Hien(i, null);
            }
            HienXong(null, null);
        }

        public void HienThiDuLieuBuuCucDuDau(List<sp_tblBuuCucDuDau_DanhSachResult> lst)
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            Barcode b = new Barcode();
            Image img;

            b.IncludeLabel = false;

            for (int i = 0; i < lst.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;

                Dong.Cells["MaBuuTa"].Value = lst[i].MaBuuTa.ToString();
                Dong.Cells["TenBuuTa"].Value = lst[i].FullName.ToString();
                Dong.Cells["ItemCode"].Value = lst[i].ItemCode.ToString();


                img = b.Encode(BarcodeLib.TYPE.CODE128A, lst[i].ItemCode.ToString(), Color.Black, Color.White, 250, 50);
                Dong.Cells["MaVach"].Value = img;

                Dong.Cells["MailTripNumber"].Value = lst[i].MailTripNumber.Value.ToString("#######");
                Dong.Cells["PostBagNumber"].Value = lst[i].PostBagNumber.Value.ToString("######");
                Dong.Cells["IncomingDate"].Value = lst[i].IncomingDate.Value;

                Dong.Cells["Weight"].Value = lst[i].Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["Value"].Value = lst[i].Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["SendingContent"].Value = lst[i].SendingContent;
                Dong.Cells["ReceiverFullname"].Value = lst[i].ReceiverFullname;
                Dong.Cells["ReceiverAddress"].Value = lst[i].ReceiverAddress;
                Dong.Cells["ReceiverTel"].Value = lst[i].ReceiverTel;
                Dong.Cells["DaPhat"].Value = lst[i].DaPhat;
                Dong.Cells["DaChuyenHoan"].Value = lst[i].DaChuyenHoan;

                Dong.Height = 60;
                Hien(i, null);
            }
            HienXong(null, null);
        }
        #endregion
    }
}
