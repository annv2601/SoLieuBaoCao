using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoSLPH.DataClient;

namespace LaySoLieu.HeThong
{
    public partial class frmThamSoCauHinh : Form
    {
        public frmThamSoCauHinh()
        {
            InitializeComponent();
        }

        private string MaThamSo = "";
        private int IDCauHinh = 0;

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtGiaTri.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public void KhoiTaoDanhSachChon()
        {
            daCauHinh dCH = new daCauHinh();
            cboThamSo.DisplayMember = "GiaTri";
            cboThamSo.ValueMember = "ID";

            cboThamSo.DataSource = dCH.lstBangThamSo;
        }

        private void cboThamSo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboThamSo.SelectedValue == null)
            {
                IDCauHinh = 0;
                MaThamSo = "";
                txtGiaTri.Text = "";
            }
            else
            {
                daCauHinh dCH = new daCauHinh();
                MaThamSo = dCH.TimMaThamSo(int.Parse(cboThamSo.SelectedValue.ToString()));
                dCH.Lay(MaThamSo);
                if (dCH.CauHinh != null)
                {
                    IDCauHinh = dCH.CauHinh.ID;
                    txtGiaTri.Text = dCH.CauHinh.GiaTri;
                }
                else
                {
                    IDCauHinh = 0;
                    txtGiaTri.Text = "";
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {            
            daCauHinh dCH = new daCauHinh();
            dCH.CauHinh.GiaTri = txtGiaTri.Text.Trim();
            if(dCH.CauHinh.GiaTri!="" && MaThamSo!="")
            {
                dCH.CauHinh.ID = IDCauHinh;
                dCH.CauHinh.Ma = MaThamSo;
                dCH.Them();
                MessageBox.Show("Cập nhật thành công tham số "+cboThamSo.SelectedText);
            }
            else
            {
                MessageBox.Show("Không đủ dữ liệu để cập nhật tham số");
            }
        }
    }
}
