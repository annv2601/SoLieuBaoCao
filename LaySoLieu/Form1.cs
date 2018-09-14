using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using daoSLPH.Untities;
using daoSLPH.DataClient;
using daoSLPH.DayDuLieu;
using daoSLPH.BCCP;

namespace LaySoLieu
{
    public partial class frmTheoDoi : Form
    {
        public frmTheoDoi()
        {
            InitializeComponent();

            DayDuLieuPayPost.Day += new daDayPaypost.DayHandler(DayDuLieuPayPost_Day);
            DocDuLieuPayPost.Ghi += new daDocDuLieuPayPost.GhiHandler(DocDuLieuPayPost_Ghi);

            DayBCCP.Day += new daDayBCCP.DayHandler(DayBCCP_Day);
            DocDuLieuBCCP.Luu += new daDocDuLieuBCCP.LuuDuLieuHandler(DocDuLieuBCCP_Luu);
            DocDuLieuBCCP.KetThucLuu += new daDocDuLieuBCCP.KetThucLuuDuLieuHandler(DocDuLieuBCCP_KetThucLuu);

            string _tg = System.Configuration.ConfigurationManager.AppSettings["ThoiGianChay"].ToString();
            tmrChay.Interval = int.Parse(_tg) * 60 * 1000;
            tmrChay.Enabled = true;

            tmrChayHomTruoc.Interval= 15 * 60 * 1000;
            tmrChayHomTruoc.Enabled = true;

            tmrLayBCCP.Interval = 3 * 60 * 1000;
            tmrLayBCCP.Enabled = true;
        }

        private daDayPaypost DayDuLieuPayPost = new daDayPaypost();
        private daDocDuLieuPayPost DocDuLieuPayPost = new daDocDuLieuPayPost();

        private daDayBCCP DayBCCP = new daDayBCCP();
        private daDocDuLieuBCCP DocDuLieuBCCP = new daDocDuLieuBCCP();

        private void mnuitemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void frmTheoDoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnLay_Click(object sender, EventArgs e)
        {
            daThuMuc dTM = new daThuMuc();
            dTM.TimThuMuc();
        }

        private void mnuitemThamSo_Click(object sender, EventArgs e)
        {
            HeThong.frmThamSoCauHinh csThamSo = new HeThong.frmThamSoCauHinh();
            csThamSo.KhoiTaoDanhSachChon();
            csThamSo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daThuMuc dTM = new daThuMuc();
            string rTenFile = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Đường_Dẫn_Paypost));
            if (dCH.CauHinh != null)
            {
                rTenFile = dCH.CauHinh.GiaTri;
            }

            rTenFile = rTenFile + "\\TRANSACTION";
            List<string> dsTM;
            dsTM = dTM.TimThuMucCoDuLieu(rTenFile);
            /*string mac = "";
            string _ip = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                        UnicastIPAddressInformationCollection n = nic.GetIPProperties().UnicastAddresses;
                        _ip = n[0].Address.ToString();
                    }
                }
            }
            MessageBox.Show(_ip);*/

            //string _ChMa;
            //_ChMa = daMaHoa.Encrypt("Data Source=10.10.200.167; Initial Catalog=SoLieuPhatHanh; User ID=LayDuLieu; Password=TuDong@SL*", true, "B0EA8F37-F4C0-464D-BDEB-49E5F3FE421C");
        }

        #region Paypost
        private void tmrChay_Tick(object sender, EventArgs e)
        {
            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieu();
                }));
            BackThread.Start();
        }

        private void DocVaGhiDuLieu()
        {
            DocDuLieuPayPost.DocVaGhiDuLieu();

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

        }

        public void DocDuLieuPayPost_Ghi(object sender, EventArgs e)
        {

        }

        private void tmrChayHomTruoc_Tick(object sender, EventArgs e)
        {
            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuNgayTruoc();
                }));
            BackThread.Start();
        }
        #endregion

        #region BCCP

        private void tmrLayBCCP_Tick(object sender, EventArgs e)
        {
            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuBCCP();
                }));
            BackThread.Start();
        }

        private void DocVaGhiDuLieuBCCP()
        {
            DocDuLieuBCCP.NgayPhatHanh = DateTime.Now.AddDays(-1);
            DocDuLieuBCCP.DocDuLieuPhatHanh();
            DocDuLieuBCCP.LuuBangDuLieu();

            daPhatHanhBCCP dPHBCCP = new daPhatHanhBCCP();
            dPHBCCP.TT.MaBuuCuc = DocDuLieuBCCP.MaBuuCuc;
            dPHBCCP.TT.Ngay = DocDuLieuBCCP.NgayPhatHanh;
            if (dPHBCCP.ThongTinTT()!=null && dPHBCCP.TT.DaLay.Value)
            {
                return;
            }

            dPHBCCP.ThemTT();

            DayBCCP.Chay();
        }

        protected void DayBCCP_Day(object sender, EventArgs e)
        {

        }

        protected void DocDuLieuBCCP_Luu(object sender, EventArgs e)
        {

        }

        protected void DocDuLieuBCCP_KetThucLuu(object sender, EventArgs e)
        {

        }
        #endregion
        private void frmTheoDoi_Load(object sender, EventArgs e)
        {
            
        }

    }
}
