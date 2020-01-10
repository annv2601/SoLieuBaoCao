using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.NopTienNganHang;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class grdMenhGia : UserControl
    {
        public grdMenhGia()
        {
            InitializeComponent();
        }

        #region Khai bao
        private List<sp_tblNopTienNganHangMenhGia_DanhSachResult> lstMG = new List<sp_tblNopTienNganHangMenhGia_DanhSachResult>();
        public int IDNopTien;
        public decimal TongTien;

        public event NhapHandler Nhap;
        public delegate void NhapHandler(object sender, EventArgs e);
        #endregion

        #region Rieng
        private void CanChinh()
        {
           
        }

        private void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            for (int i = 0; i < lstMG.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;
                Dong.Cells["Ten"].Value = lstMG[i].Ten;

                Dong.Cells["SoLuong"].Value = lstMG[i].SoLuong.ToString("######");
                Dong.Cells["SoTien"].Value = lstMG[i].SoTien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

                Dong.Height = 28;
                Dong.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Regular);
            }

            //Dong tong cong
            Dong = dgv.Rows[dgv.Rows.Add()];

            Dong.Cells["STT"].Value = lstMG.Count;
            Dong.Cells["Ten"].Value = "Tổng cộng";

            TongTien = lstMG.Sum(x => x.SoTien);
            Dong.Cells["SoTien"].Value = TongTien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            Dong.Height = 35;
            Dong.ReadOnly = true;

            Dong.DefaultCellStyle.Font = new Font("Arial", 20, FontStyle.Bold);
            //=======================
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daNopTienNganHangMenhGia dNMG = new daNopTienNganHangMenhGia();
            dNMG.NMG.IDNopTien = IDNopTien;
            lstMG = dNMG.lstDanhSach();

            HienThiDuLieu();
        }

        public void LuuDuLieu()
        {
            daNopTienNganHangMenhGia dNMG = new daNopTienNganHangMenhGia();
            dNMG.NMG.IDNopTien = IDNopTien;
            dNMG.Xoa();
            foreach(sp_tblNopTienNganHangMenhGia_DanhSachResult pt in lstMG)
            {
                if(pt.SoLuong!=0 && pt.SoTien!=0)
                {
                    dNMG.NMG = pt;
                    dNMG.NMG.IDNopTien = IDNopTien;
                    dNMG.Them();
                }
            }
        }
        #endregion

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i =Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["STT"].Value);
            try
            {
                lstMG[i].SoLuong = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
            catch
            {
                lstMG[i].SoLuong = 0;
            }
            lstMG[i].SoTien = lstMG[i].SoLuong * lstMG[i].MenhGia.Value;
            dgv.Rows[e.RowIndex].Cells["SoTien"].Value = lstMG[i].SoTien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            TongTien = lstMG.Sum(x => x.SoTien);
            dgv.Rows[lstMG.Count].Cells["SoTien"].Value = TongTien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));

            Nhap(TongTien, null);
        }
    }
}
