using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.GiuLai;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class frmBuuCucGiuLai : Form
    {
        public frmBuuCucGiuLai()
        {
            InitializeComponent();            
        }

        #region Khai bao
        private List<int> lstThuTu=new List<int>();
        private List<sp_tblBuuCucGiuLai_DanhSachResult> lstGiuLai = new List<sp_tblBuuCucGiuLai_DanhSachResult>();
        private daBase _ThamSo = new daBase();
        public event KetThucHandler KetThuc;
        public delegate void KetThucHandler(object sender, EventArgs e);

        public daBase ThamSo { get => _ThamSo; set => _ThamSo = value; }
        #endregion

        #region Rieng
        private int TimBuuGuiDeGiuLai(string _SH)
        {
            int kq = -1;          
            for (int i=0;i<lstGiuLai.Count;i++)
            {
                if(lstGiuLai[i].ItemCode==_SH)
                {
                    kq = i;
                    break;
                }
            }
            return kq;
        }
        #endregion

        #region Chung
        public void HienThi()
        {
            daBuuCucLuuGiu dBCLG = new daBuuCucLuuGiu();
            dBCLG.MaBuuCuc = ThamSo.MaBuuCuc;
            dBCLG.MaBuuTa = ThamSo.MaBuuTa;
            dBCLG.TuNgay = ThamSo.TuNgay;
            dBCLG.DenNgay = ThamSo.DenNgay;

            lstGiuLai = dBCLG.lstDanhSachBuuTa();
            grdBuuGuiGiuLai1.lstPHBT = lstGiuLai;
            grdBuuGuiGiuLai1.HienThiDuLieu();
        }
        #endregion

        private void frmBuuCucGiuLai_Resize(object sender, EventArgs e)
        {
            grdBuuGuiGiuLai1.Height = this.Height - groupBox1.Height - 10;
        }

        private void btnCapNhatBuuTaGiuLai_Click(object sender, EventArgs e)
        {
            daBuuCucLuuGiu dBCLG = new daBuuCucLuuGiu();
            daBuuTaGiuLai dBTGL = new daBuuTaGiuLai();
            int vitri;
            for (int k= 0;k < lstThuTu.Count;k++)
            {
                vitri = lstThuTu[k];
                dBTGL.Giu.Ngay = lstGiuLai[vitri].Ngay;
                dBTGL.Giu.FromPoscode = lstGiuLai[vitri].FromPoscode;
                dBTGL.Giu.ItemCode = lstGiuLai[vitri].ItemCode;
                dBTGL.Giu.ServiceCode = lstGiuLai[vitri].ServiceCode;
                dBTGL.Giu.ToPoscode = lstGiuLai[vitri].ToPoscode;
                dBTGL.Giu.MailTripNumber = lstGiuLai[vitri].MailTripNumber;
                dBTGL.Giu.PostBagNumber = lstGiuLai[vitri].PostBagNumber;
                dBTGL.Giu.PostBagTypeCode = lstGiuLai[vitri].PostBagTypeCode;
                dBTGL.Giu.IncomingDate = lstGiuLai[vitri].IncomingDate;
                dBTGL.Giu.Year = lstGiuLai[vitri].Year;
                dBTGL.Giu.PostmanCode = lstGiuLai[vitri].PostmanCode;
                dBTGL.Giu.FullName = lstGiuLai[vitri].FullName;
                dBTGL.Giu.DeliverRouteName = lstGiuLai[vitri].DeliverRouteName;
                dBTGL.Giu.ReceiverFullname = lstGiuLai[vitri].ReceiverFullname;
                dBTGL.Giu.ReceiverAddress = lstGiuLai[vitri].ReceiverAddress;
                dBTGL.Giu.ReceiverTel = lstGiuLai[vitri].ReceiverTel;
                dBTGL.Giu.Weight = lstGiuLai[vitri].Weight;
                dBTGL.Giu.WeightConvert = lstGiuLai[vitri].WeightConvert;
                dBTGL.Giu.SendingContent = lstGiuLai[vitri].SendingContent;
                dBTGL.Giu.Value = lstGiuLai[vitri].Value;
                dBTGL.Giu.MaBuuTa = lstGiuLai[vitri].MaBuuTa;

                dBTGL.Them();

                dBCLG.MaBuuCuc = lstGiuLai[vitri].FromPoscode;
                dBCLG.Ngay = lstGiuLai[vitri].Ngay.Value;
                dBCLG.Luu.ItemCode = lstGiuLai[vitri].ItemCode;
                dBCLG.Xoa();

                lstGiuLai.RemoveAt(vitri);
            }
            
            lstThuTu = new List<int>();
            grdBuuGuiGiuLai1.lstPHBT = new List<sp_tblBuuCucGiuLai_DanhSachResult>();
            grdBuuGuiGiuLai1.HienThiDuLieu();

            MessageBox.Show("Đã chuyển bưu gửi cho bưu tá đi phát tiếp thành công!");
        }

        private void chkToanBuuCuc_CheckedChanged(object sender, EventArgs e)
        {
            daBuuCucLuuGiu dBCLG = new daBuuCucLuuGiu();
            dBCLG.MaBuuCuc = ThamSo.MaBuuCuc;
            dBCLG.MaBuuTa = ThamSo.MaBuuTa;
            dBCLG.TuNgay = ThamSo.TuNgay;
            dBCLG.DenNgay = ThamSo.DenNgay;

            if (chkToanBuuCuc.Checked)
            {
                lstGiuLai = dBCLG.lstDanhSach();
            }
            else
            {
                lstGiuLai = dBCLG.lstDanhSachBuuTa();
            }
            grdBuuGuiGiuLai1.lstPHBT = lstGiuLai;
            pgb.Visible = true;
            pgb.Maximum = lstGiuLai.Count + 1;
            pgb.Value = 0;
            grdBuuGuiGiuLai1.HienThiDuLieu();

            lstThuTu = new List<int>();
        }

        private void grdBuuGuiGiuLai1_Hien(object sender, EventArgs e)
        {
            pgb.Value = pgb.Value + 1;
        }

        private void grdBuuGuiGiuLai1_HienXong(object sender, EventArgs e)
        {
            pgb.Visible = false;
        }

        private void txtSoHieu_Enter(object sender, EventArgs e)
        {
            txtSoHieu.BackColor = Color.PaleTurquoise;
            //txtSoHieu.SelectedText = txtSoHieu.Text;
            //txtSoHieu.SelectionStart = 0;
            //txtSoHieu.SelectionLength = txtSoHieu.Text.Length;
            txtSoHieu.SelectAll();
        }

        private void txtSoHieu_Leave(object sender, EventArgs e)
        {
            txtSoHieu.BackColor = Color.White;
        }

        private void txtSoHieu_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                int _kqTim = TimBuuGuiDeGiuLai(txtSoHieu.Text.Trim().ToUpper());
                if (_kqTim!=-1)
                {
                    for(int k=0;k<lstThuTu.Count;k++)
                    {
                        if(lstThuTu[k]==_kqTim)
                        {
                            MessageBox.Show("Bưu gửi này đã có trong danh sách!");
                            txtSoHieu.SelectAll();
                            return;
                        }
                    }
                    lstThuTu.Add(_kqTim);
                    if(lstThuTu.Count==1)
                    {
                        grdBuuGuiGiuLai1.lstPHBT = new List<sp_tblBuuCucGiuLai_DanhSachResult>();
                        grdBuuGuiGiuLai1.lstPHBT.Add(lstGiuLai[_kqTim]);
                        grdBuuGuiGiuLai1.HienThiDuLieu();
                        btnCapNhatBuuTaGiuLai.Visible = true;
                    }
                    else
                    {
                        grdBuuGuiGiuLai1.ThemBuuGui(lstGiuLai[_kqTim]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bưu gửi có số hiệu "+txtSoHieu.Text.Trim().ToUpper());
                }
                txtSoHieu.SelectAll();
            }
        }

        private void txtSoHieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBuuCucGiuLai_FormClosing(object sender, FormClosingEventArgs e)
        {
            KetThuc(null, null);
            e.Cancel = true;
            this.Hide();
        }
    }
}
