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
using daoTienThuCOD.DocVaDay;

using LaySoLieu.TienCOD;


namespace LaySoLieu
{
    public partial class frmTheoDoi : Form
    {
        public frmTheoDoi()
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

            string _tg = System.Configuration.ConfigurationManager.AppSettings["ThoiGianChay"].ToString();
            tmrChay.Interval = int.Parse(_tg) * 60 * 1000;
            tmrChay.Enabled = true;

            tmrChayHomTruoc.Interval=35 * 60 * 1000;
            tmrChayHomTruoc.Enabled = true;

            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Là_Bưu_cục_Phát);
            if (dCH.CauHinh != null)
            {
                if(dCH.CauHinh.GiaTri=="True" || dCH.CauHinh.GiaTri == "1")
                {
                    tmrChayPhat.Interval = 60 * 60 * 1000;
                    tmrChayPhat.Enabled = true;
                }
                else
                {
                    tmrLayBCCP.Interval = 20 * 60 * 1000;
                    tmrLayBCCP.Enabled = true;
                }
            }
            else
            {
                tmrLayBCCP.Interval = 20 * 60 * 1000;
                tmrLayBCCP.Enabled = true;
            }
            

            /*daCauHinh dCH = new daCauHinh();            
            //Lay thoi gian thu gom
            
            dCH.Lay((int)daCauHinh.eCauHinh.Giờ_Thu_Gom_Lần1);
            if (dCH.CauHinh != null)
            {
                GioThuGom1 = TimeSpan.Parse(dCH.CauHinh.GiaTri);
                tmrThuGom1.Interval = 60 * 1000;
                tmrThuGom1.Enabled = true;
            }

            dCH.Lay((int)daCauHinh.eCauHinh.Giờ_Thu_Gom_Lần2);
            if (dCH.CauHinh != null)
            {
                GioThuGom2 = TimeSpan.Parse(dCH.CauHinh.GiaTri);
                tmrThuGom2.Interval = 60 * 1000;
                tmrThuGom2.Enabled = true;
            }

            dCH.Lay((int)daCauHinh.eCauHinh.Giờ_Thu_Gom_Lần2);
            if (dCH.CauHinh != null)
            {
                GioThuGom2 = TimeSpan.Parse(dCH.CauHinh.GiaTri);
                tmrThuGom2.Interval = 60 * 1000;
                tmrThuGom2.Enabled = true;
            }*/
            //======================
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

        private DateTime NgayDen;
        private Int16 Ca;

        private bool LoadForm = false;
        #endregion

        #region Rieng
        private void DanhSachBaoCaoChon()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Ten", typeof(string));

            dt.Rows.Add(1, "Báo cáo kế toán");
            dt.Rows.Add(2, "Báo cáo Doanh thu BCCP");
            dt.Rows.Add(3, "Báo cáo Doanh thu Paypost");

            listBox1.DisplayMember = "Ten";
            listBox1.ValueMember = "ID";
            listBox1.DataSource = dt;

            listBox1.SelectedIndex = -1;
        }
        #endregion

        #region Su kien
        private void mnuitemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Là_Bưu_cục_Phát);
            if (dCH.CauHinh != null)
            {
                if (dCH.CauHinh.GiaTri == "True" || dCH.CauHinh.GiaTri == "1")
                {
                    frmQuanLyTienCOD csQLTienCOD = new frmQuanLyTienCOD();
                    dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);

                    if (dCH.CauHinh != null)
                    {
                        csQLTienCOD.MaBuuCuc = dCH.CauHinh.GiaTri;
                    }
                    csQLTienCOD.Show();
                }
                else
                {
                    frmBaoCao csBaoCao1 = new frmBaoCao();
                    csBaoCao1.Show();
                }
            }
            else
            {
                frmBaoCao csBaoCao = new frmBaoCao();
                csBaoCao.Show();
            }

            
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
            /*daThuMuc dTM = new daThuMuc();
            string rTenFile = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Đường_Dẫn_Paypost));
            if (dCH.CauHinh != null)
            {
                rTenFile = dCH.CauHinh.GiaTri;
            }

            rTenFile = rTenFile + "\\TRANSACTION";
            List<string> dsTM;
            dsTM = dTM.TimThuMucCoDuLieu(rTenFile);*/
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
                        _ip = n[n.Count-1].Address.ToString();
                    }
                }
            }
            MessageBox.Show(_ip);*/

            //string _ChMa;
            //_ChMa = daMaHoa.Encrypt("Data Source=10.10.200.167; Initial Catalog=SoLieuPhatHanh; User ID=LayDuLieu; Password=TuDong@SL*", true, "B0EA8F37-F4C0-464D-BDEB-49E5F3FE421C");
        }

        #endregion

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
            tmrChayHomTruoc.Enabled = false;
            if (DateTime.Now.Hour>9)
            {
                return;
            }
            
            Thread BackThreadPPHTu = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuNgayTruoc();
                }));
            BackThreadPPHTu.Start();

            Thread BackThreadBCCPHTu = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuBCCPHomTruoc();
                }));
            BackThreadBCCPHTu.Start();
        }

        public void DayDuLieuPayPost_DayXong(object sender, EventArgs e)
        {
        }
        #endregion

        #region BCCP

        private void tmrLayBCCP_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 16)
            {
                tmrLayBCCP.Enabled = false;
                Thread BackThread = new Thread(
                    new ThreadStart(() =>
                    {
                        DocVaGhiDuLieuBCCP();
                    }));
                BackThread.Start();
            }
        }

        private void DocVaGhiDuLieuBCCP()
        {
            DocDuLieuBCCP.NgayPhatHanh = DateTime.Now;
            DocDuLieuBCCP.DocDuLieuPhatHanh();
            DocDuLieuBCCP.LuuBangDuLieu();

            daPhatHanhBCCP dPHBCCP = new daPhatHanhBCCP();
            dPHBCCP.TT.MaBuuCuc = DocDuLieuBCCP.MaBuuCuc;
            dPHBCCP.TT.Ngay = DocDuLieuBCCP.NgayPhatHanh;
            if (dPHBCCP.ThongTinTT()!=null && dPHBCCP.TT.DaLay.Value)
            {
                return;
            }
           
            dPHBCCP.Xoa();
            dPHBCCP.ThemTT();

            DayBCCP.Chay();

            daDichVu dDV = new daDichVu();
            dDV.DocVaThem();            
        }

        private void DocVaGhiDuLieuBCCPHomTruoc()
        {
            DocDuLieuBCCP.NgayPhatHanh = DateTime.Now.AddDays(-1);
            DocDuLieuBCCP.DocDuLieuPhatHanh();
            DocDuLieuBCCP.LuuBangDuLieu();

            daPhatHanhBCCP dPHBCCP = new daPhatHanhBCCP();
            dPHBCCP.TT.MaBuuCuc = DocDuLieuBCCP.MaBuuCuc;
            dPHBCCP.TT.Ngay = DocDuLieuBCCP.NgayPhatHanh;
            
            dPHBCCP.Xoa();
            dPHBCCP.ThemTT();

            DayBCCP.Chay();

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

        }

        protected void DocDuLieuBCCP_Luu(object sender, EventArgs e)
        {

        }

        protected void DocDuLieuBCCP_KetThucLuu(object sender, EventArgs e)
        {

        }

        protected void DayBCCP_DayXong(object sender, EventArgs e)
        {
        
        }

        #endregion
        private void frmTheoDoi_Load(object sender, EventArgs e)
        {
            LoadForm = true;
            DanhSachBaoCaoChon();
            LoadForm = false;
        }

        #region Thu gom
        private void tmrThuGom1_Tick(object sender, EventArgs e)
        {
            /*tmrThuGom1.Enabled = false;
            Thread BackThread = new Thread(
                new ThreadStart(() =>
                {
                    DocVaGhiDuLieuBCCPGioThuGom();
                    DocVaGhiDuLieu();
                }));
            BackThread.Start();*/

            TimeSpan _tg1 = DateTime.Now.AddMinutes(-1).TimeOfDay;
            TimeSpan _tg2 = DateTime.Now.AddMinutes(1).TimeOfDay;

            if (_tg1 <= GioThuGom1 && _tg2 >= GioThuGom1)
            {
                tmrThuGom1.Enabled = false;
                Thread BackThread = new Thread(
                    new ThreadStart(() =>
                    {
                        DocVaGhiDuLieuBCCPGioThuGom();
                        DocVaGhiDuLieu();
                    }));
                BackThread.Start();
            }
        }

        private void tmrThuGom2_Tick(object sender, EventArgs e)
        {
            TimeSpan _tg1 = DateTime.Now.AddMinutes(-1).TimeOfDay;
            TimeSpan _tg2 = DateTime.Now.AddMinutes(1).TimeOfDay;

            if (_tg1 <= GioThuGom2 && _tg2 >= GioThuGom2)
            {
                tmrThuGom2.Enabled = false;
                Thread BackThread = new Thread(
                    new ThreadStart(() =>
                    {
                        DocVaGhiDuLieuBCCPGioThuGom();
                        DocVaGhiDuLieu();
                    }));
                BackThread.Start();
            }
        }

        private void tmrThuGom3_Tick(object sender, EventArgs e)
        {
            TimeSpan _tg1 = DateTime.Now.AddMinutes(-1).TimeOfDay;
            TimeSpan _tg2 = DateTime.Now.AddMinutes(1).TimeOfDay;

            if (_tg1 <= GioThuGom3 && _tg2 >= GioThuGom3)
            {
                tmrThuGom3.Enabled = false;
                Thread BackThread = new Thread(
                    new ThreadStart(() =>
                    {
                        DocVaGhiDuLieuBCCPGioThuGom();
                        DocVaGhiDuLieu();
                    }));
                BackThread.Start();
            }
        }
        #endregion

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!LoadForm)
            {
                /*Cursor = Cursors.WaitCursor;                
                daCauHinh dCH = new daCauHinh();
                DateTime _ngay = DateTime.Now;

                switch ((int)listBox1.SelectedValue)
                {
                    case 1:
                        daDuLieuBCCP dBCCP = new daDuLieuBCCP();
                        crBaoCaoKeToan rptBCKT = new crBaoCaoKeToan();                        
                        rptBCKT.SetDataSource(dBCCP.BaoCaoNgay(_ngay));
                                                
                        dCH.Lay((int)daCauHinh.eCauHinh.Tên_Đơn_Vị);
                        if (dCH.CauHinh != null)
                        {
                            rptBCKT.SetParameterValue(0, dCH.CauHinh.GiaTri);
                        }
                        else
                        {
                            rptBCKT.SetParameterValue(0, "Trung tâm");
                        }
                        dCH.Lay((int)daCauHinh.eCauHinh.Tên_Bưu_Cục);
                        if (dCH.CauHinh != null)
                        {
                            rptBCKT.SetParameterValue(1, dCH.CauHinh.GiaTri);
                        }
                        else
                        {
                            rptBCKT.SetParameterValue(1, "Bưu cục");
                        }
                        rptBCKT.SetParameterValue(2, "BÁO CÁO KẾ TOÁN DỊCH VỤ BCCP");
                        rptBCKT.SetParameterValue(3, "Ngày " + _ngay.ToString("dd/MM/yyyy"));
                        crystalReportViewer1.ReportSource = rptBCKT;
                        break;
                    case 2:
                        daSoLieuPhatHanhBCCP dSL = new daSoLieuPhatHanhBCCP();
                        dSL.TuNgay = _ngay;
                        dSL.DenNgay = _ngay;
                        dSL.LayNoiTinh();
                        dSL.LayLienTinh();
                        dSL.LayQuocTe();
                        dSL.TinhTong();

                        crTongHopPhatHanhMoi cTong = new crTongHopPhatHanhMoi();
                        cTong.SetDataSource(dSL.KetQua);

                        //cTong.SetParameterValue(0, dSL.MaBuuCuc);
                        cTong.SetParameterValue(0, dSL.TenBuuCuc + " : " + dSL.MaBuuCuc);
                        cTong.SetParameterValue(1, dSL.TuNgay.ToString("dd/MM/yyyy"));
                        cTong.SetParameterValue(2, dSL.DenNgay.ToString("dd/MM/yyyy"));
                        cTong.SetParameterValue(3, "");
                        crystalReportViewer1.ReportSource = cTong;
                        break;
                    case 3:
                        crDoanhThuPaypost rptPP = new crDoanhThuPaypost();
                        daDuLieuPayPost dPP = new daDuLieuPayPost();

                        rptPP.SetDataSource(dPP.BaoCao(_ngay));

                        dCH.Lay((int)daCauHinh.eCauHinh.Tên_Đơn_Vị);
                        if (dCH.CauHinh != null)
                        {
                            rptPP.SetParameterValue(0, dCH.CauHinh.GiaTri);
                        }
                        else
                        {
                            rptPP.SetParameterValue(0, "Trung tâm");
                        }
                        dCH.Lay((int)daCauHinh.eCauHinh.Tên_Bưu_Cục);
                        if (dCH.CauHinh != null)
                        {
                            rptPP.SetParameterValue(1, dCH.CauHinh.GiaTri);
                        }
                        else
                        {
                            rptPP.SetParameterValue(1, "Bưu cục");
                        }
                        rptPP.SetParameterValue(2, "BÁO CÁO KẾ TOÁN DỊCH VỤ Paypost");
                        rptPP.SetParameterValue(3, "Ngày " + _ngay.ToString("dd/MM/yyyy"));
                        crystalReportViewer1.ReportSource = rptPP;
                        break;
                }

                Cursor = Cursors.Default;*/
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuitemLayDanhMuc_Click(object sender, EventArgs e)
        {
            daDanhMucNVPP dDM = new daDanhMucNVPP();
            dDM.Doc();
            MessageBox.Show("Đã lấy danh mục Nghiệp vụ Paypost thành công!");
        }

        private void mnuitemLayDuLieu_Click(object sender, EventArgs e)
        {
            Form2 csTest = new Form2();
            csTest.Show();
        }

        #region So lieu Phat
        private void tmrChayPhat_Tick(object sender, EventArgs e)
        {
            int _gio = DateTime.Now.Hour;
            if((_gio>=10 && _gio<11)||(_gio>=15 && _gio<16))
            {
                NgayCa();
                SoLieuDiPhat.Ngay = NgayDen;
                SoLieuDiPhat.Ca = Ca;
                Thread BackThread = new Thread(
                    new ThreadStart(() =>
                    {
                        DocVaGhiDuLieuDen();
                        DocVaGhiDuLieuPhanHuongBTa();
                        DocVaGhiDuLieuChuyenHoan();
                    }));
                BackThread.Start();
            }
        }

        private void NgayCa()
        {
            NgayDen = DateTime.Now;
            if(NgayDen.Hour<12)
            {
                Ca = 1;
            }
            else
            {
                Ca = 2;
            }
        }

        private void DocVaGhiDuLieuDen()
        {
            SoLieuDiPhat.DocVaLuuSLDen();
        }

        private void DocVaGhiDuLieuPhanHuongBTa()
        {
            SoLieuDiPhat.DocVaLuuPhanBuuTa();
        }

        private void DocVaGhiDuLieuChuyenHoan()
        {
            if(Ca==2)
            {
                SoLieuDiPhat.DocVaLuuChuyenHoan();
            }
        }

        private void SoLieuDiPhat_Luu(object sender, EventArgs e)
        {

        }

        private void SoLieuDiPhat_LuuXong(object sender, EventArgs e)
        {

        }
        #endregion

        private void mnuitemSoLieuPhat_Click(object sender, EventArgs e)
        {
            frmQuanLyTienCOD csQLCOD = new frmQuanLyTienCOD();
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
            
            if (dCH.CauHinh != null)
            {
                csQLCOD.MaBuuCuc = dCH.CauHinh.GiaTri;
            }
            
            csQLCOD.Show();
        }
    }
}

