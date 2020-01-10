using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Threading;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.TraTien;
using daoTienThuCOD.Client;
using daoSLPH.DataClient;
using daoSLPH.DayDuLieu;
using BarcodeLib;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucTraTienCOD : UserControl
    {
        public ucTraTienCOD()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);

            DayDuLieuPayPost.Day += new daDayPaypost.DayHandler(DayDuLieuPayPost_Day);
            DocDuLieuPayPost.Ghi += new daDocDuLieuPayPost.GhiHandler(DocDuLieuPayPost_Ghi);
            DayDuLieuPayPost.DayXong += new daDayPaypost.DayXongHandler(DayDuLieuPayPost_DayXong);
        }

        #region Khai bao
        private daDocDuLieuPayPost DocDuLieuPayPost = new daDocDuLieuPayPost();
        private daDayPaypost DayDuLieuPayPost = new daDayPaypost();
        private List<sp_tblTraTien_DanhSachResult> lstTraTien = new List<sp_tblTraTien_DanhSachResult>();
        private daBase _ThamSo = new daBase();

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }
        private daXuaBaoCao dXE = new daXuaBaoCao();
        private double TongSoTien=0;
        #endregion

        #region Hien Thi
        private void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            Barcode b = new Barcode();
            Image img;

            b.IncludeLabel = false;

            for (int i = 0; i < lstTraTien.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;
                Dong.Cells["Ngay"].Value = lstTraTien[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["AccountID"].Value = lstTraTien[i].AccountID.ToString();

                img = b.Encode(BarcodeLib.TYPE.CODE128A, lstTraTien[i].AccountID.ToString(), Color.Black, Color.White, 250, 50);
                Dong.Cells["MaVach"].Value = img;

                Dong.Cells["TranTime"].Value = lstTraTien[i].TranTime.ToString();
              
                Dong.Cells["TranAmount"].Value = lstTraTien[i].TranAmount.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 60;

                pgb.Value = (pgb.Value + 1)%pgb.Maximum;
            }

            //Dong tong cong
            Dong = dgv.Rows[dgv.Rows.Add()];

            Dong.Cells["STT"].Value = lstTraTien.Count;
            Dong.Cells["Ngay"].Value = "Tổng cộng";
            TongSoTien = lstTraTien.Sum(x => x.TranAmount.Value);
            Dong.Cells["TranAmount"].Value = TongSoTien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            Dong.Height = 50;

            Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            //=======================

            lblTongSoBuuGui.Text = lstTraTien.Count().ToString();
            lblTongSoTien.Text = TongSoTien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daTraTien dTTien = new daTraTien();
            dTTien.MaBuuCuc = ThamSo.MaBuuCuc;
            dTTien.TuNgay = ThamSo.TuNgay;
            dTTien.DenNgay = ThamSo.DenNgay;

            lstTraTien = dTTien.lstDanhSach();
            HienThiDuLieu();
        }
        #endregion

        #region Lay paypost
        private void LayPP()
        {
            //Lay paypost
            pgb.Value = 0;
            pgb.Maximum = 100;
            pgb.Visible = true;
            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieu();
                    //MessageBox.Show("Lay Paypost xong");
                }));
            BackThread.Start();
        }

        private void DocVaGhiDuLieu()
        {
            DocDuLieuPayPost.DocVaGhiDuLieu(txtTuNgay.Value, txtTuNgay.Value.AddDays(1));

            DayDuLieuPayPost.Xoa();

            DayDuLieuPayPost.Chay();
        }

        public void DayDuLieuPayPost_Day(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;
        }

        public void DocDuLieuPayPost_Ghi(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;
        }

        public void DayDuLieuPayPost_DayXong(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => {
                    pgb.Value = 100;
                    

                    daTraTien dTTien = new daTraTien();
                    dTTien.MaBuuCuc = ThamSo.MaBuuCuc;
                    dTTien.Ngay = txtTuNgay.Value;
                    dTTien.LaySoLieu();

                    dTTien.CapNhatTrangThai();

                    dTTien.TuNgay = txtTuNgay.Value;
                    dTTien.DenNgay = txtTuNgay.Value;
                    lstTraTien = dTTien.lstDanhSach();
                    HienThiDuLieu();

                    pgb.Visible = false;

                    MessageBox.Show("Đã lấy số liệu trả tiền ngày " + txtTuNgay.Value.ToString("dd/MM/yyyy"));
                }));

        }
        #endregion

        #region Su kien

        private void ucBuuGuiDenPhat_Resize(object sender, EventArgs e)
        {
            dgv.Height = this.Height - groupBox1.Height - 10;
            btnXuatExcel.Top = this.Top + dgv.Top + dgv.ColumnHeadersHeight;
            btnInBaoCao.Top = btnXuatExcel.Top;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            daTraTien dTTien = new daTraTien();
            dTTien.MaBuuCuc = ThamSo.MaBuuCuc;
            dTTien.TuNgay = txtTuNgay.Value;
            dTTien.DenNgay = txtDenNgay.Value;

            pgb.Visible = true;

            lstTraTien = dTTien.lstDanhSach();

            pgb.Minimum = 0;
            pgb.Maximum = lstTraTien.Count;
            pgb.Minimum = 0;

            HienThiDuLieu();

            pgb.Visible = false;
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

        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            daTraTien dTTien = new daTraTien();
            dTTien.MaBuuCuc = ThamSo.MaBuuCuc;
            dTTien.Ngay = txtTuNgay.Value;
            dTTien.CapNhatTrangThai();
            MessageBox.Show("Đã cập nhật xong trạng thái trả tiền cho ngày "+txtTuNgay.Value.ToString("dd/MM/yyyy"));
        }

        private void btnTongHopDuLieu_Click(object sender, EventArgs e)
        {
            LayPP();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            pgb.Visible = true;
            dXE.grdDuLieu = dgv;
            pgb.Maximum = dgv.RowCount + 3;
            dXE.XuatExcel();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {            
            dXE.grdDuLieu = dgv;
            dXE.mTieuDeBaoCao = "DANH SÁCH CHI TIẾT BƯU GỬI ĐẾN";
            dXE.InBaoCao();
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
        #endregion

        private void btnNopTien_Click(object sender, EventArgs e)
        {
            if (TongSoTien==0)
            {
                MessageBox.Show("Anh/chị không có tiền để nộp!");
                return;
            }
            daDanhMuc dDM = new daDanhMuc();
            if (dDM.LayDvi()==null)
            {
                dDM.LayDanhMucDVi();                
            }

            //int _IDNTien = 0;
            frmBanKeNopTien csBKNTien = new frmBanKeNopTien();

            csBKNTien.HienThiNguoiDungSan();
            /*if (_IDNTien==0)
            {
                csBKNTien.HienThiNguoiDungSan();
            }*/

            csBKNTien.TongTienCo = TongSoTien;
            csBKNTien.ThamSo.MaBuuCuc = ThamSo.MaBuuCuc;
            csBKNTien.ThamSo.Ngay = txtTuNgay.Value;
            //csBKNTien.IDNopTien = _IDNTien;
            csBKNTien.KiemTraDaNopTien();
            csBKNTien.HienThiBanKe();
            
            csBKNTien.Show();
        }
    }
}
