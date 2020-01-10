using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using Test.Database;

using Newtonsoft.Json;
//using PAYPOST.COD.LIB;
using PAYPOST.DIC.DATA;
using PAYPOST.DIC.FORMS;
//using PayPOST.Entity;
using PAYPOST.HC;
//using PAYPOST.MTA;
//using PayPOST.Security;
using System.Net;
using PAYPOST.LOG;


namespace Test
{
    public partial class frmSoNhatKy : Form
    {
        private string rTenFile;
        private daB0205KeToan dB0205 = new daB0205KeToan();
        private daB02KTNV dB02 = new daB02KTNV();
        private daChiPhi dCP = new daChiPhi();

        public frmSoNhatKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HSSFWorkbook wb;
            HSSFSheet sh;


            using (var fs = new FileStream(rTenFile, FileMode.Open, FileAccess.Read))
            {
                wb = new HSSFWorkbook(fs);
            }

            sh = (HSSFSheet)wb.GetSheet(cbo.SelectedValue.ToString());
            int _DongCuoi = sh.LastRowNum;
            IRow row;
            daSoNhatKy dSNK = new daSoNhatKy();
            dSNK.SNK.Thang = byte.Parse(txtThang.Text.Trim());
            dSNK.SNK.Nam = int.Parse(txtNam.Text.Trim());
            dSNK.SNK.NgayHeThong = DateTime.Now;
            pgb.Maximum = _DongCuoi;
            for (int i = 1; i <= _DongCuoi; i++)
            {
                row = sh.GetRow(i);
                if (row == null)
                {
                    break;
                }
                dSNK.SNK.NGAY_HT = row.GetCell(0).StringCellValue;
                dSNK.SNK.SO_CT = row.GetCell(1).StringCellValue;
                dSNK.SNK.NGAY_CT = row.GetCell(2).StringCellValue;
                dSNK.SNK.ND = row.GetCell(3).StringCellValue;
                dSNK.SNK.TK_NO = row.GetCell(4).StringCellValue;
                dSNK.SNK.TKE_NO = row.GetCell(5).StringCellValue;
                dSNK.SNK.DTU_NO = row.GetCell(6).StringCellValue;
                dSNK.SNK.SP_NO = row.GetCell(7).StringCellValue;
                dSNK.SNK.TK_CO = row.GetCell(8).StringCellValue;
                dSNK.SNK.TKE_CO = row.GetCell(9).StringCellValue;
                dSNK.SNK.DTU_CO = row.GetCell(10).StringCellValue;
                dSNK.SNK.SP_CO = row.GetCell(11).StringCellValue;
                try
                {
                    dSNK.SNK.TIEN_NO = row.GetCell(12).NumericCellValue;
                }
                catch { dSNK.SNK.TIEN_NO = 0; }
                try
                {
                    dSNK.SNK.TIEN_CO = row.GetCell(13).NumericCellValue;
                }
                catch { dSNK.SNK.TIEN_CO = 0; }
                dSNK.SNK.MA_DVI = row.GetCell(14).StringCellValue;
                dSNK.SNK.NOTE = row.GetCell(15).StringCellValue;
                dSNK.SNK.MaDonVi = "";
                dSNK.SNK.MaNSD = "";

                dSNK.Them();
                pgb.Value = i;
            }

            MessageBox.Show("Da xong");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rTenFile = openFileDialog1.FileName;
                //Lay danh sach sheet trong Excel
                HSSFWorkbook wb;

                using (var fs = new FileStream(rTenFile, FileMode.Open, FileAccess.Read))
                {
                    wb = new HSSFWorkbook(fs);
                }
                List<string> lstSh = new List<string>();
                for (int i = 0; i < wb.Count; i++)
                {
                    lstSh.Add(wb.GetSheetName(i));
                }
                cbo.DataSource = lstSh;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Transactions transactions = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rTenFile = openFileDialog1.FileName;               
            }
            
            try
            {
                transactions = ObjectXMLSerializer<Transactions>.Load(rTenFile, SerializedFormat.Binary);
            }
            catch
            {
                transactions = new Transactions();
                transactions.Transaction = new PAYPOST.LOG.Transaction[0];
            }
            //LOG.DateFrom = LOG.DateFrom.AddDays(1.0);
            Transaction[] array = new Transaction[transactions.Transaction.Length];
            transactions.Transaction.CopyTo(array, 0);*/
        }



        public void ResponseObject(string refType, string baseURL, string inputParam)
        {
            /*string value = "";
            ResponseObject result;
            try
            {
                string apiByRefType = "api/SEARCH/SearchGeneralAPI";// CODInquiry.GetApiByRefType(refType);
                string str = baseURL + apiByRefType;
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    webClient.Headers["API_KEY"] = "FEDDAC470DD50A8A6767CE42C6392713E9BFBB9DDAD3974FC9A3D6D30E144D53";
                    webClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", "");
                    webClient.Encoding = Encoding.UTF8;
                    string str2 = "inputParam=" + inputParam + "&PageIndex=1&PageSize=50";
                    CODRequest cODRequest = new CODRequest();
                    cODRequest.InputPara = inputParam;
                    cODRequest.PageIndex = 1;
                    cODRequest.PageSize = 50;
                    value = webClient.UploadString(str + "?" + str2, "POST");
                }
                result = JsonConvert.DeserializeObject<ResponseObject>(value);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể kết nối đến dịch vụ của máy chủ. Hãy kiểm tra lại !" + ex.Message);
            }
            finally
            {
                GC.Collect();
            }*/

        }

        private void btnLuuB0205_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                string _DD = folderBrowserDialog1.SelectedPath;
                
                dB0205.SLDT.Thang = byte.Parse(txtThang.Text.Trim());
                dB0205.SLDT.Nam = int.Parse(txtNam.Text.Trim());

                pgb.Maximum = 500;
                DirectoryInfo di = new DirectoryInfo(_DD);
                FileInfo[] lstFile;
                lstFile = di.GetFiles();

                if (lstFile.Count() > 0)
                {
                    dB0205.Xoa();
                    foreach (FileInfo _f in lstFile)
                    {
                        if (_f.Extension == "xlsx")
                        {
                            LuuB02051FileXLSX(_f.FullName);
                        }
                        else
                        {
                            LuuB02051File(_f.FullName);
                        }
                    }

                    dB0205.GanMaTrung();
                }
            }
        }

        private void LuuB0205()
        {
            pgb.Maximum = 100;
            DirectoryInfo di = new DirectoryInfo(rTenFile);
            FileInfo[] lstFile;
            lstFile = di.GetFiles();
            foreach(FileInfo _f in lstFile)
            {
                LuuB02051File(_f.FullName);
            }
        }

        private void LuuB02051File(string _tenfile)
        {
            FileInfo fi = new FileInfo(_tenfile);
            string _MaDV = fi.Name.Split('.')[0];
            

            HSSFWorkbook wb;
            HSSFSheet sh;


            using (var fs = new FileStream(_tenfile, FileMode.Open, FileAccess.Read))
            {
                wb = new HSSFWorkbook(fs);
            }

            sh = (HSSFSheet)wb.GetSheet("Sheet_0");
            int _DongCuoi = sh.LastRowNum;
            IRow row;

            dB0205.SLDT.MaDonVi = _MaDV;

            //pgb.Maximum = _DongCuoi + 1;
            for (int i = 1; i <= _DongCuoi; i++)
            {
                row = sh.GetRow(i);
                if (row == null)
                {
                    break;
                }
                try { dB0205.SLDT.NHOM = int.Parse(row.GetCell(0).StringCellValue); } catch { dB0205.SLDT.NHOM = 0; }
                dB0205.SLDT.MA_DT = row.GetCell(1).StringCellValue;
                dB0205.SLDT.TEN = row.GetCell(2).StringCellValue;
                dB0205.SLDT.TEN_PHU = row.GetCell(3).StringCellValue;
                dB0205.SLDT.DV = row.GetCell(4).StringCellValue;
                try { dB0205.SLDT.S_L = row.GetCell(5).NumericCellValue; } catch { dB0205.SLDT.S_L = 0; }
                try { dB0205.SLDT.D_T = row.GetCell(6).NumericCellValue; } catch { dB0205.SLDT.D_T = 0; }
                try { dB0205.SLDT.LK = row.GetCell(7).NumericCellValue; } catch { dB0205.SLDT.LK = 0; }
                try { dB0205.SLDT.T_SUAT = row.GetCell(8).NumericCellValue; } catch { dB0205.SLDT.T_SUAT = 0; }
                try { dB0205.SLDT.THUE = row.GetCell(9).NumericCellValue; } catch { dB0205.SLDT.THUE = 0; }
                try { dB0205.SLDT.LK_THUE = row.GetCell(10).NumericCellValue; } catch { dB0205.SLDT.LK_THUE = 0; }
                try { dB0205.SLDT.SL_DI = row.GetCell(11).NumericCellValue; } catch { dB0205.SLDT.SL_DI = 0; }
                try { dB0205.SLDT.SL_DEN = row.GetCell(12).NumericCellValue; } catch { dB0205.SLDT.SL_DEN = 0; }
                dB0205.SLDT.NHOM1 = row.GetCell(13).StringCellValue;
                dB0205.SLDT.IN_KHONG = row.GetCell(14).StringCellValue;
                dB0205.SLDT.CAP = row.GetCell(15).StringCellValue;
                try { dB0205.SLDT.TT = row.GetCell(16).NumericCellValue; } catch { dB0205.SLDT.TT = 0; }
                dB0205.SLDT.TSUAT = row.GetCell(17).StringCellValue;

                dB0205.Them();
                //pgb.Value = i;
                if (pgb.InvokeRequired)
                    pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; lblThongTin.Text = "Đơn vị " + _MaDV; }));
                else
                {
                    pgb.Value = (pgb.Value + 1) % 500;//100;
                }
            }
        }

        private void LuuB02051FileXLSX(string _tenfile)
        {
            FileInfo fi = new FileInfo(_tenfile);
            string _MaDV = fi.Name.Split('.')[0];

            XSSFWorkbook wb;
            XSSFSheet sh;


            using (var fs = new FileStream(_tenfile, FileMode.Open, FileAccess.Read))
            {
                wb = new XSSFWorkbook(fs);
            }

            sh = (XSSFSheet)wb.GetSheet("Sheet_0");
            int _DongCuoi = sh.LastRowNum;
            IRow row;

            dB0205.SLDT.MaDonVi = _MaDV;

            //pgb.Maximum = _DongCuoi + 1;
            for (int i = 1; i <= _DongCuoi; i++)
            {
                row = sh.GetRow(i);
                if (row == null)
                {
                    break;
                }
                try { dB0205.SLDT.NHOM = int.Parse(row.GetCell(0).StringCellValue); } catch { dB0205.SLDT.NHOM = 0; }
                dB0205.SLDT.MA_DT = row.GetCell(1).StringCellValue;
                dB0205.SLDT.TEN = row.GetCell(2).StringCellValue;
                dB0205.SLDT.TEN_PHU = row.GetCell(3).StringCellValue;
                dB0205.SLDT.DV = row.GetCell(4).StringCellValue;
                try { dB0205.SLDT.S_L = row.GetCell(5).NumericCellValue; } catch { dB0205.SLDT.S_L = 0; }
                try { dB0205.SLDT.D_T = row.GetCell(6).NumericCellValue; } catch { dB0205.SLDT.D_T = 0; }
                try { dB0205.SLDT.LK = row.GetCell(7).NumericCellValue; } catch { dB0205.SLDT.LK = 0; }
                try { dB0205.SLDT.T_SUAT = row.GetCell(8).NumericCellValue; } catch { dB0205.SLDT.T_SUAT = 0; }
                try { dB0205.SLDT.THUE = row.GetCell(9).NumericCellValue; } catch { dB0205.SLDT.THUE = 0; }
                try { dB0205.SLDT.LK_THUE = row.GetCell(10).NumericCellValue; } catch { dB0205.SLDT.LK_THUE = 0; }
                try { dB0205.SLDT.SL_DI = row.GetCell(11).NumericCellValue; } catch { dB0205.SLDT.SL_DI = 0; }
                try { dB0205.SLDT.SL_DEN = row.GetCell(12).NumericCellValue; } catch { dB0205.SLDT.SL_DEN = 0; }
                dB0205.SLDT.NHOM1 = row.GetCell(13).StringCellValue;
                dB0205.SLDT.IN_KHONG = row.GetCell(14).StringCellValue;
                dB0205.SLDT.CAP = row.GetCell(15).StringCellValue;
                try { dB0205.SLDT.TT = row.GetCell(16).NumericCellValue; } catch { dB0205.SLDT.TT = 0; }
                dB0205.SLDT.TSUAT = row.GetCell(17).StringCellValue;

                dB0205.Them();
                //pgb.Value = i;
                if (pgb.InvokeRequired)
                    pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 100; lblThongTin.Text = "Đơn vị " + _MaDV; }));
                else
                {
                    pgb.Value = (pgb.Value + 1) % 500;//100;
                }
            }
        }

        private void frmSoNhatKy_Load(object sender, EventArgs e)
        {
            lblThongTin.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuB02KTNV_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "D://Data//";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string _DD = folderBrowserDialog1.SelectedPath;

                dB02.B02.Thang = byte.Parse(txtThang.Text.Trim());
                dB02.B02.Nam = int.Parse(txtNam.Text.Trim());

                pgb.Maximum = 500;
                DirectoryInfo di = new DirectoryInfo(_DD);
                FileInfo[] lstFile;
                lstFile = di.GetFiles();

                if (lstFile.Count() > 0)
                {
                    foreach (FileInfo _f in lstFile)
                    {
                        DocB02KTNV(_f.FullName);
                    }                   
                }
            }
        }

        private void DocB02KTNV(string _tenfile)
        {
            FileInfo fi = new FileInfo(_tenfile);
            string _MaDV = fi.Name.Split('.')[0];


            //HSSFWorkbook wb;
            XSSFWorkbook wb;            
            //HSSFSheet sh;
            XSSFSheet sh;
            
            using (var fs = new FileStream(_tenfile, FileMode.Open, FileAccess.Read))
            {
                wb = new XSSFWorkbook(fs);
            }

            sh = (XSSFSheet)wb.GetSheet("B02-05");
            int _DongCuoi = sh.LastRowNum;
            IRow row;

            dB02.B02.MaDonVi = _MaDV;
            dB02.Xoa();

            //pgb.Maximum = _DongCuoi + 1;
            for (int i = 12; i <= _DongCuoi; i++)
            {
                row = sh.GetRow(i);
                if (row == null)
                {
                    break;
                }

                dB02.B02.ChiTieu = row.GetCell(0).StringCellValue;
                if (dB02.B02.ChiTieu != "")
                {
                    dB02.B02.DonViTinh = row.GetCell(1).StringCellValue;
                    dB02.B02.MaSo = row.GetCell(2).StringCellValue;
                    try
                    {
                        dB02.B02.SanLuong = Convert.ToDecimal(row.GetCell(3).ToString());
                    }
                    catch { dB02.B02.SanLuong = 0; }
                    try
                    {
                        dB02.B02.DoanhThuPS = Convert.ToDecimal(row.GetCell(4).ToString());
                    }
                    catch { dB02.B02.DoanhThuPS = 0; }
                    try { 
                        dB02.B02.DoanhThuLK = Convert.ToDecimal(row.GetCell(5).ToString());
                    }
                    catch { dB02.B02.DoanhThuLK = 0; }
                    dB02.B02.ThueSuat = row.GetCell(6).ToString();
                    try
                    {
                        dB02.B02.ThuePS = Convert.ToDecimal(row.GetCell(7).ToString());
                    }
                    catch { dB02.B02.ThuePS = 0; }
                    try
                    {
                        dB02.B02.ThueLK = Convert.ToDecimal(row.GetCell(8).ToString());
                    }
                    catch { dB02.B02.ThueLK = 0; }
                    try
                    {
                        dB02.B02.SanLuongNghiepVuDi = Convert.ToDecimal(row.GetCell(9).ToString());
                    }
                    catch { dB02.B02.SanLuongNghiepVuDi = 0; }
                    try
                    {
                        dB02.B02.SanLuongDen = Convert.ToDecimal(row.GetCell(10).ToString());
                    }
                    catch { dB02.B02.SanLuongDen = 0; }

                    dB02.Them();
                }

                if (pgb.InvokeRequired)
                    pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 500; lblThongTin.Text = "Đơn vị " + _MaDV; }));
                else
                {
                    pgb.Value = (pgb.Value + 1) % 500;//100;
                }
            }
        }

        private void btnLuuChiPhi_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "D://Data//";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string _DD = folderBrowserDialog1.SelectedPath;

                dCP.CP.Thang = byte.Parse(txtThang.Text.Trim());
                dCP.CP.Nam = int.Parse(txtNam.Text.Trim());

                //dCP.Xoa();

                pgb.Maximum = 500;
                DirectoryInfo di = new DirectoryInfo(_DD);
                FileInfo[] lstFile;
                lstFile = di.GetFiles();

                if (lstFile.Count() > 0)
                {
                    foreach (FileInfo _f in lstFile)
                    {
                        DocChiPhiBCOL(_f.FullName);
                    }
                }

                MessageBox.Show("Đã xong!");
            }
        }

        private void DocChiPhiBCOL(string _tenfile)
        {
            FileInfo fi = new FileInfo(_tenfile);
            string _MaDV = fi.Name.Split('.')[0];


            //HSSFWorkbook wb;
            XSSFWorkbook wb;
            //HSSFSheet sh;
            XSSFSheet sh;

            using (var fs = new FileStream(_tenfile, FileMode.Open, FileAccess.Read))
            {
                wb = new XSSFWorkbook(fs);
            }

            sh = (XSSFSheet)wb.GetSheet("Sheet 0");
            int _DongCuoi = sh.LastRowNum;
            IRow row;

            dCP.CP.MaDonVi = _MaDV;
            dCP.Xoa();

            //pgb.Maximum = _DongCuoi + 1;
            for (int i = 7; i <= _DongCuoi; i++)
            {
                row = sh.GetRow(i);
                if (row == null)
                {
                    break;
                }

                dCP.CP.Ma = row.GetCell(0).StringCellValue;
                if (dCP.CP.Ma != "")
                {
                    dCP.CP.DonViTinh = row.GetCell(2).StringCellValue;
                    dCP.CP.Ten = row.GetCell(1).StringCellValue;

                    try
                    {
                        dCP.CP.PhatSinhThuongXuyen = Convert.ToDouble(row.GetCell(3).ToString());
                    }
                    catch { dCP.CP.PhatSinhThuongXuyen = 0; }
                    try
                    {
                        dCP.CP.PhatSinhPhanBo = Convert.ToDouble(row.GetCell(4).ToString());
                    }
                    catch { dCP.CP.PhatSinhPhanBo = 0; }

                    dCP.CP.TongCong = dCP.CP.PhatSinhPhanBo + dCP.CP.PhatSinhThuongXuyen;

                    dCP.Them();
                }

                if (pgb.InvokeRequired)
                    pgb.BeginInvoke(new Action(() => { pgb.Value = (pgb.Value + 1) % 500; lblThongTin.Text = "Đơn vị " + _MaDV; }));
                else
                {
                    pgb.Value = (pgb.Value + 1) % 500;//100;
                }
            }
        }
    }
}
