using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using daoSLPH.DataClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using PayPOST.Entity;
using daoSLPH.Untities;
using daoSLPH.DayDuLieu;
using daoSLPH.BCCP;
using daoTienThuCOD.DocVaDay;

namespace LaySoLieu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            DayDuLieuPayPost.Day += new daDayPaypost.DayHandler(DayDuLieuPayPost_Day);
            DocDuLieuPayPost.Ghi += new daDocDuLieuPayPost.GhiHandler(DocDuLieuPayPost_Ghi);
            DayDuLieuPayPost.DayXong += new daDayPaypost.DayXongHandler(DayDuLieuPayPost_DayXong);

            DayBCCP.Day += new daDayBCCP.DayHandler(DayBCCP_Day);
            DocDuLieuBCCP.Luu += new daDocDuLieuBCCP.LuuDuLieuHandler(DocDuLieuBCCP_Luu);
            DocDuLieuBCCP.KetThucLuu += new daDocDuLieuBCCP.KetThucLuuDuLieuHandler(DocDuLieuBCCP_KetThucLuu);
            DayBCCP.DayXong += new daDayBCCP.DayXongHandler(DayBCCP_DayXong);
            SoLieuDiPhat.Luu += new daSoLieuNhanVe.LuuHandler(SoLieuDiPhat_Luu);
            SoLieuDiPhat.LuuXong += new daSoLieuNhanVe.LuuXongHandler(SoLieuDiPhat_LuuXong);
        }

        #region Khai bao
        private daDayPaypost DayDuLieuPayPost = new daDayPaypost();
        private daDocDuLieuPayPost DocDuLieuPayPost = new daDocDuLieuPayPost();

        private daDayBCCP DayBCCP = new daDayBCCP();
        private daDocDuLieuBCCP DocDuLieuBCCP = new daDocDuLieuBCCP();
        private daSoLieuNhanVe SoLieuDiPhat = new daSoLieuNhanVe();

        private TimeSpan GioThuGom1;
        private TimeSpan GioThuGom2;
        private TimeSpan GioThuGom3;

        private bool LoadForm = false;
        #endregion

        #region Paypost
        private void tmrChay_Tick(object sender, EventArgs e)
        {
            
        }

        private void DocVaGhiDuLieu()
        {
            DocDuLieuPayPost.DocVaGhiDuLieu(txtTuNgay.Value, txtDenNgay.Value.AddDays(1));

            DayDuLieuPayPost.Xoa();

            DayDuLieuPayPost.Chay();
        }

        private void DocVaGhiDuLieuNgayTruoc()
        {
            DocDuLieuPayPost.DocVaGhiDuLieuNgay(DateTime.Now.AddDays(-1));

            DayDuLieuPayPost.Chay();

            daDuLieuPayPost dDLPP = new daDuLieuPayPost();
            dDLPP.Xoa(DateTime.Now.AddDays(-1));
            dDLPP.Dispose();
            dDLPP = null;
        }

        public void DayDuLieuPayPost_Day(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1)%100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;
        }

        public void DocDuLieuPayPost_Ghi(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1)%100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;
        }

        public void DayDuLieuPayPost_DayXong(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => {
                    pgb.Value = 100;
                    lblThongTin.Text = "Đã lấy dữ liệu Paypost xong";
                }));

        }

        #endregion

        #region BCCP
        private void DocVaGhiDuLieuBCCP()
        {
            daPhatHanhBCCP dPHBCCP = new daPhatHanhBCCP();
            DateTime _ngay;
            _ngay = txtTuNgay.Value;
            while(_ngay<=txtDenNgay.Value.AddDays(1))
            {
                DocDuLieuBCCP.NgayPhatHanh = _ngay;
                DocDuLieuBCCP.DocDuLieuPhatHanh();
                DocDuLieuBCCP.LuuBangDuLieu();

                
                dPHBCCP.TT.MaBuuCuc = DocDuLieuBCCP.MaBuuCuc;
                dPHBCCP.TT.Ngay = DocDuLieuBCCP.NgayPhatHanh;

                dPHBCCP.Xoa();
                //dPHBCCP.ThemTT();

                DayBCCP.Chay();

                _ngay = _ngay.AddDays(1);
            }
            

            daDichVu dDV = new daDichVu();
            dDV.DocVaThem();
        }

        private void DocVaGhiDuLieuBCCPGioThuGom()
        {
            DocDuLieuBCCP.NgayPhatHanh = DateTime.Now;
            DocDuLieuBCCP.DocDuLieuPhatHanh();
            DocDuLieuBCCP.LuuBangDuLieu();

            daPhatHanhBCCP dPHBCCP = new daPhatHanhBCCP();
            dPHBCCP.TT.MaBuuCuc = DocDuLieuBCCP.MaBuuCuc;
            dPHBCCP.TT.Ngay = DocDuLieuBCCP.NgayPhatHanh;

            dPHBCCP.Xoa();

            DayBCCP.Chay();
        }

        protected void DayBCCP_Day(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;
        }

        protected void DocDuLieuBCCP_Luu(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;
        }

        protected void DocDuLieuBCCP_KetThucLuu(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => {
                    pgb.Value = 100;
                    lblThongTin.Text = "Đẩy dữ liệu BCCP lên máy chủ .....";
                }));
        }

        protected void DayBCCP_DayXong(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => {
                    pgb.Value = 100;
                    lblThongTin.Text = "Đã lấy dữ liệu BCCP xong";
                }));
        }
        #endregion

        #region So lieu Phat
       
        private void DocVaGhiDuLieuDen()
        {
            SoLieuDiPhat.Ca = 1;
            SoLieuDiPhat.DocVaLuuSLDen();

            SoLieuDiPhat.Ca = 2;
            SoLieuDiPhat.DocVaLuuSLDen();
        }

        private void DocVaGhiDuLieuPhanHuongBTa()
        {
            SoLieuDiPhat.Ca = 1;
            SoLieuDiPhat.DocVaLuuPhanBuuTa();

            SoLieuDiPhat.Ca = 2;
            SoLieuDiPhat.DocVaLuuPhanBuuTa();
        }

        private void DocVaGhiDuLieuChuyenHoan()
        {
            SoLieuDiPhat.Ca = 2;
            SoLieuDiPhat.DocVaLuuChuyenHoan();
        }

        private void DocVaGhiDuLieuChuyenTiep()
        {
            SoLieuDiPhat.Ca = 2;
            SoLieuDiPhat.DocVaLuuChuyenTiep();
        }

        private void SoLieuDiPhat_Luu(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; }));
            else
                pgb.Value = (pgb.Value + 1) % 100;//100;

            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => {
                    lblThongTin.Text = sender.ToString();
                }));
        }

        private void SoLieuDiPhat_LuuXong(object sender, EventArgs e)
        {
            if (pgb.InvokeRequired)
                pgb.BeginInvoke(new Action(() => {
                    pgb.Value = 100;
                    lblThongTin.Text = sender.ToString();
                }));
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                /*daDocDuLieuPayPost dPP = new daDocDuLieuPayPost();
                dPP.DocGhi(openFileDialog1.FileName);*/
                LoadFile(openFileDialog1.FileName);
            }
        }

        public void LoadFile(string fileName)
        {
            object[] obj;
            IFormatter formatter = new BinaryFormatter();
            if (File.Exists(fileName))
            {
                Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                obj = (object[])formatter.Deserialize(stream);
                stream.Close();

                string x1 = "";
                string[] str;
                int n;
                daoSLCT.Data.daData dDT = new daoSLCT.Data.daData();

                for(int i=0;i<obj.Length;i++)
                {
                    x1 = obj[i].ToString();
                    str = x1.Split(';');

                    dDT.rPP.MaNhom = str[1];
                    dDT.rPP.TenNhom = str[2];
                    dDT.rPP.Ma = str[3];
                    dDT.rPP.Ten = str[4];

                    dDT.ThemNghiepVu();
                }

                MessageBox.Show("Xong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Là_Bưu_cục_Phát);
            if (dCH.CauHinh != null)
            {
                if (dCH.CauHinh.GiaTri == "True" || dCH.CauHinh.GiaTri == "1")
                {
                    MessageBox.Show("Đây là Bưu cục phát. Anh/chị phải sử dụng chức năng lấy dữ liệu phát");
                    return;
                }
            }

            //Lay BCCP            
            pgb.Value = 0;
            pgb.Maximum = 100;
            lblThongTin.Text = "Lấy dữ liệu BCCP .....";
            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuBCCP();
                    //MessageBox.Show("Lay BCCP xong");
                }));
            BackThread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Lay paypost
            pgb.Value = 0;
            pgb.Maximum = 100;
            lblThongTin.Text = "Lấy dữ liệu Paypost .....";

            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieu();
                    //MessageBox.Show("Lay Paypost xong");
                }));
            BackThread.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*daDocDuLieuPayPost dPP = new daDocDuLieuPayPost();
                dPP.DocGhi(openFileDialog1.FileName);*/
                LoadFile(openFileDialog1.FileName);
            }
        }

        private void btnLayDuLieuPhat_Click(object sender, EventArgs e)
        {
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Là_Bưu_cục_Phát);
            if (dCH.CauHinh == null)
            {
                MessageBox.Show("Bưu cục này không phải là Bưu cục phát");
                return;
            }
            else
            {
                if (dCH.CauHinh.GiaTri != "True")
                {
                    MessageBox.Show("Bưu cục này không phải là Bưu cục phát");
                    return;
                }
            }

            pgb.Value = 0;
            pgb.Maximum = 100;
            lblThongTin.Text = "Lấy dữ liệu Phát .....";
            SoLieuDiPhat.Ngay = txtTuNgay.Value;
            
            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuDen();
                    DocVaGhiDuLieuPhanHuongBTa();
                    DocVaGhiDuLieuChuyenHoan();
                    DocVaGhiDuLieuChuyenTiep();
                }));
            BackThread.Start();
        }
    }
}
