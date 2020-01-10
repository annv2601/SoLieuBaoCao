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

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class ucBuuGuiDenPhatTHop : UserControl
    {
        public ucBuuGuiDenPhatTHop()
        {
            InitializeComponent();
            dXE.Xuat += new daXuaBaoCao.XuatHandler(dXE_Chay);
            dXE.XuatXong += new daXuaBaoCao.XuatXongHandler(dXE_ChayXong);
        }

        #region Khai bao
        //private List<sp_tblSLDen_DanhSach_THopResult> lstDen = new List<sp_tblSLDen_DanhSach_THopResult>();
        private List<sp_tblSLDenTHop_DanhSachResult> lstDen = new List<sp_tblSLDenTHop_DanhSachResult>();
        private daBase _ThamSo = new daBase();
        private daXuaBaoCao dXE = new daXuaBaoCao();
        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }
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
            daSLDenTHop dSLDen = new daSLDenTHop();
            dSLDen.MaBuuCuc = ThamSo.MaBuuCuc;
            dSLDen.TuNgay = txtTuNgay.Value;
            dSLDen.DenNgay = txtDenNgay.Value;
            dSLDen.Ca = ThamSo.Ca;

            lstDen = dSLDen.lstDanhSach();
            HienThiDuLieu();
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
            dXE.mTieuDeBaoCao = "DANH SÁCH TỔNG HỢP BƯU GỬI ĐẾN";
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
        private void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            for (int i = 0; i < lstDen.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;
                Dong.Cells["Ngay"].Value = lstDen[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["Ca"].Value = lstDen[i].Ca.ToString();

                Dong.Cells["ServiceCode"].Value = lstDen[i].ServiceCode.ToString();
                Dong.Cells["FromPOSCode"].Value = lstDen[i].FromPoscode.ToString();
                Dong.Cells["MailTripNumber"].Value = lstDen[i].MailTripNumber.Value.ToString("######");
                Dong.Cells["PostBagNumber"].Value = lstDen[i].PostBagNumber.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["IncomingDate"].Value = lstDen[i].IncomingDate.Value;

                Dong.Cells["SoLuong"].Value = lstDen[i].SoLuong.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["Weight"].Value=lstDen[i].Weight.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                Dong.Cells["Value"].Value = lstDen[i].Value.Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 25;
            }

            //Dong tong cong
            Dong = dgv.Rows[dgv.Rows.Add()];

            Dong.Cells["STT"].Value = lstDen.Count;
            Dong.Cells["Ngay"].Value = "Tổng cộng";
            Dong.Cells["Ca"].Value = "";

            Dong.Cells["ServiceCode"].Value = "";
            Dong.Cells["FromPOSCode"].Value = "";
            Dong.Cells["MailTripNumber"].Value = "";
            Dong.Cells["PostBagNumber"].Value = "";
            Dong.Cells["IncomingDate"].Value = "";

            Dong.Cells["SoLuong"].Value = lstDen.Sum(x=>x.SoLuong).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["Weight"].Value = lstDen.Sum(x=>x.Weight).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            Dong.Cells["Value"].Value = lstDen.Sum(x=>x.Value).Value.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            Dong.Height = 30;            
            
            Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            //=======================
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daSLDenTHop dSLDen = new daSLDenTHop();
            dSLDen.MaBuuCuc = ThamSo.MaBuuCuc;
            dSLDen.TuNgay = ThamSo.TuNgay;
            dSLDen.DenNgay = ThamSo.DenNgay;
            dSLDen.Ca = ThamSo.Ca;

            lstDen = dSLDen.lstDanhSach();
            HienThiDuLieu();
        }
        #endregion

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            frmChiTietSLDen csCTSLD = new frmChiTietSLDen();
            int i = Convert.ToInt32(dgv.CurrentRow.Cells["STT"].Value);
            sp_tblSLDenTHop_DanhSachResult pt = lstDen[i];
            csCTSLD.ucBuuGuiDenPhat1.BGThamSo.ToPOSCode = ThamSo.MaBuuCuc;
            csCTSLD.ucBuuGuiDenPhat1.BGThamSo.Ngay = pt.Ngay;
            csCTSLD.ucBuuGuiDenPhat1.BGThamSo.MailTripNumber = pt.MailTripNumber;
            csCTSLD.ucBuuGuiDenPhat1.BGThamSo.PostBagNumber = pt.PostBagNumber;
            csCTSLD.ucBuuGuiDenPhat1.BGThamSo.ServiceCode = pt.ServiceCode;
            csCTSLD.ucBuuGuiDenPhat1.BGThamSo.FromPOSCode = pt.FromPoscode;

            csCTSLD.HienThiDuLieu();
            csCTSLD.Show();
        }

        
    }
}
