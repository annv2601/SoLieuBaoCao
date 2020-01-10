using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.SoLieuDen;
using daoTienThuCOD.GiuLai;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class frmChiTietSLDen : Form
    {
        public frmChiTietSLDen()
        {
            InitializeComponent();
        }

        #region khai bao
        private daBase _ThamSo = new daBase();

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }

        #endregion

        public void HienThiDuLieu()
        {
            ucBuuGuiDenPhat1.HienThi();
        }

        public void HienThiChuaPhanHuong()
        {
            daSLDen dSLD = new daSLDen();
            dSLD.MaBuuCuc = ThamSo.MaBuuCuc;
            dSLD.Ngay = ThamSo.Ngay;
            List<sp_tblSLDen_DanhSachResult> lstCPH;
            lstCPH = dSLD.lstChuaPhanBuuTa();

            /*daBuuCucLuuGiu dBCLG = new daBuuCucLuuGiu();
            dBCLG.MaBuuCuc = ThamSo.MaBuuCuc;
            dBCLG.Ngay = ThamSo.Ngay;
            foreach(sp_tblSLDen_DanhSachResult pt in dBCLG.lstChuaPhanBuuTa())
            {
                lstCPH.Add(pt);
            }*/

            ucBuuGuiDenPhat1.lstDen = lstCPH;
            ucBuuGuiDenPhat1.HienThiDuLieu();
        }
    }
}
