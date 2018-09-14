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
using System.IO;
using Test.Database;

using Newtonsoft.Json;
using PAYPOST.COD.LIB;
using PAYPOST.DIC.DATA;
using PAYPOST.DIC.FORMS;
//using PayPOST.Entity;
using PAYPOST.HC;
using PAYPOST.MTA;
using PayPOST.Security;
using System.Net;
using PAYPOST.LOG;


namespace Test
{
    public partial class frmSoNhatKy : Form
    {
        private string rTenFile;

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
            for (int i=1;i<=_DongCuoi;i++)
            {
                row = sh.GetRow(i);
                if(row==null)
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
                List<string> lstSh=new List<string>();
                for(int i=0;i<wb.Count;i++)
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
            string value = "";
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
            }
            
        }

    }
}
