using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using daoSLPH.Untities;
using Newtonsoft.Json;
using PAYPOST.LOG;
//using PAYPOST.HC;

namespace daoSLPH.DataClient
{
    public class daDocDuLieuPayPost
    {
        public event GhiHandler Ghi;
        public delegate void GhiHandler(object sender, EventArgs e);

        private bool KiemTraCoTonTaiFile(string rTenFile)
        {
            FileInfo fi = new FileInfo(rTenFile);
            if(fi.Exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DocVaGhiDuLieu()
        {
            string rTenFile = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Đường_Dẫn_Paypost));
            if (dCH.CauHinh != null)
            {
                rTenFile = dCH.CauHinh.GiaTri;
            }

            rTenFile = rTenFile + "\\TRANSACTION";

            List<string> dsThuMuc;
            daThuMuc dTM = new daThuMuc();
            dsThuMuc = dTM.TimThuMucCoDuLieu(rTenFile);

            DateTime _NgayPhatHanh = DateTime.Now;
            string _rTenFileDL="";
            for (int i=0;i<dsThuMuc.Count;i++)
            {
                _rTenFileDL = rTenFile + "\\" + dsThuMuc[i] + "\\" + _NgayPhatHanh.ToString("yyyyMMdd") + ".log";
                if (KiemTraCoTonTaiFile(_rTenFileDL))
                {
                    DocGhi(_rTenFileDL, _NgayPhatHanh);
                }
            }
            
        }

        public void DocVaGhiDuLieu(DateTime rTuNgay, DateTime rDenNgay)
        {
            daDuLieuPayPost dDLPP = new daDuLieuPayPost();
            dDLPP.XoaTatCa();

            string rTenFile = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Đường_Dẫn_Paypost));
            if (dCH.CauHinh != null)
            {
                rTenFile = dCH.CauHinh.GiaTri;
            }

            rTenFile = rTenFile + "\\TRANSACTION";

            List<string> dsThuMuc;
            daThuMuc dTM = new daThuMuc();
            dsThuMuc = dTM.TimThuMucCoDuLieu(rTenFile);

            DateTime _NgayPhatHanh;// = DateTime.Now;
            string _rTenFileDL = "";
            int i;
            _NgayPhatHanh = rTuNgay;
            while(_NgayPhatHanh<=rDenNgay)
            {
                for (i = 0; i < dsThuMuc.Count; i++)
                {
                    _rTenFileDL = rTenFile + "\\" + dsThuMuc[i] + "\\" + _NgayPhatHanh.ToString("yyyyMMdd") + ".log";
                    if (KiemTraCoTonTaiFile(_rTenFileDL))
                    {
                        DocGhi(_rTenFileDL, _NgayPhatHanh);
                    }
                }
                _NgayPhatHanh = _NgayPhatHanh.AddDays(1);
            }
            
        }

        public void DocVaGhiDuLieuNgay(DateTime rNgay)
        {
            string rTenFile = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Đường_Dẫn_Paypost));
            if (dCH.CauHinh != null)
            {
                rTenFile = dCH.CauHinh.GiaTri;
            }

            rTenFile = rTenFile + "\\TRANSACTION";

            List<string> dsThuMuc;
            daThuMuc dTM = new daThuMuc();
            dsThuMuc = dTM.TimThuMucCoDuLieu(rTenFile);

            DateTime _NgayPhatHanh = rNgay;
            string _rTenFileDL = "";
            for (int i = 0; i < dsThuMuc.Count; i++)
            {
                _rTenFileDL = rTenFile + "\\" + dsThuMuc[i] + "\\" + _NgayPhatHanh.ToString("yyyyMMdd") + ".log";
                if (KiemTraCoTonTaiFile(_rTenFileDL))
                {
                    DocGhi(_rTenFileDL, _NgayPhatHanh);
                }
            }
        }

        private void DocGhi(string rTenFile, DateTime rNgay)
        {
            Transactions transactions = null;
            try
            {
                transactions = ObjectXMLSerializer<Transactions>.Load(rTenFile, SerializedFormat.Binary);
            }
            catch
            {
                transactions = new Transactions();
                transactions.Transaction = new PAYPOST.LOG.Transaction[0];
            }
            Transaction[] array = new Transaction[transactions.Transaction.Length];
            transactions.Transaction.CopyTo(array, 0);

            daDuLieuPayPost dDLPP = new daDuLieuPayPost();
            clsDuLieuPP ptPP = new clsDuLieuPP();
            Transaction dlDoc;
            for (int i = 0; i < array.Length; i++)
            {
                dlDoc = array[i];
                ptPP = dDLPP.Tim(dlDoc.TranID);
                if (ptPP != null)
                {
                    if (ptPP.TranTime != dlDoc.TranTime)
                    {
                        ptPP.DaTruyen = false;
                        dDLPP.Them(ptPP);
                    }
                }
                else
                {
                    ptPP = new clsDuLieuPP();
                    ptPP.NgayPhatHanh = rNgay;
                    ptPP.TranTime = dlDoc.TranTime;
                    ptPP.TranCat = dlDoc.TranCat;
                    ptPP.InvokedFrom = dlDoc.InvokedFrom;
                    ptPP.TranID = dlDoc.TranID;
                    ptPP.PAC = dlDoc.PAC;
                    ptPP.AccountID = dlDoc.AccountID;
                    ptPP.TranAmount = dlDoc.TranAmount;
                    ptPP.SenderName = dlDoc.SenderName;
                    ptPP.AddInfo1 = dlDoc.AddInfo1;
                    ptPP.AddInfo2 = dlDoc.AddInfo2;
                    ptPP.AddInfo3 = dlDoc.AddInfo3;
                    ptPP.AddInfo4 = dlDoc.AddInfo4;
                    ptPP.AddInfo5 = dlDoc.AddInfo5;
                    ptPP.AddInfo6 = dlDoc.AddInfo6;
                    ptPP.AddInfo7 = dlDoc.AddInfo7;
                    ptPP.AddInfo8 = dlDoc.AddInfo8;
                    ptPP.Fee = dlDoc.Fee;
                    ptPP.Add_Info_Fee_01 = dlDoc.Add_Info_Fee_01;
                    ptPP.Add_Info_Fee_02 = dlDoc.Add_Info_Fee_02;
                    ptPP.Add_Info_Fee_03 = dlDoc.Add_Info_Fee_03;
                    ptPP.Add_Info_Fee_04 = dlDoc.Add_Info_Fee_04;
                    ptPP.Add_Info_Fee_05 = dlDoc.Add_Info_Fee_05;

                    dDLPP.Them(ptPP);
                }

                Ghi(ptPP, null);
            }
        }

        public void DocVaGhiDuLieu_LuuGiu()
        {
            string rTenFile="";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Đường_Dẫn_Paypost));
            if(dCH.CauHinh!=null)
            {
                rTenFile = dCH.CauHinh.GiaTri;
            }

            rTenFile = rTenFile + "\\TRANSACTION";

            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Tên_Đăng_nhập_Paypost));
            if (dCH.CauHinh != null)
            {
                rTenFile = rTenFile + "\\" + dCH.CauHinh.GiaTri;
            }

            DateTime _NgayPhatHanh = DateTime.Now;

            rTenFile = rTenFile + "\\" + _NgayPhatHanh.ToString("yyyyMMdd") + ".log";

            if (KiemTraCoTonTaiFile(rTenFile))
            {
                Transactions transactions = null;
                try
                {
                    transactions = ObjectXMLSerializer<Transactions>.Load(rTenFile, SerializedFormat.Binary);
                }
                catch
                {
                    transactions = new Transactions();
                    transactions.Transaction = new PAYPOST.LOG.Transaction[0];
                }
                Transaction[] array = new Transaction[transactions.Transaction.Length];
                transactions.Transaction.CopyTo(array, 0);

                daDuLieuPayPost dDLPP = new daDuLieuPayPost();
                clsDuLieuPP ptPP = new clsDuLieuPP();
                Transaction dlDoc;
                for(int i=0;i<array.Length;i++)
                {
                    dlDoc = array[i];
                    ptPP = dDLPP.Tim(dlDoc.TranID);
                    if(ptPP!=null)
                    {
                        if(ptPP.TranTime!=dlDoc.TranTime)
                        {
                            ptPP.DaTruyen = false;
                            dDLPP.Them(ptPP);
                        }
                    }
                    else
                    {
                        ptPP = new clsDuLieuPP();
                        ptPP.NgayPhatHanh = _NgayPhatHanh;
                        ptPP.TranTime = dlDoc.TranTime;
                        ptPP.TranCat = dlDoc.TranCat;
                        ptPP.InvokedFrom = dlDoc.InvokedFrom;
                        ptPP.TranID = dlDoc.TranID;
                        ptPP.PAC = dlDoc.PAC;
                        ptPP.AccountID = dlDoc.AccountID;
                        ptPP.TranAmount = dlDoc.TranAmount;
                        ptPP.SenderName = dlDoc.SenderName;
                        ptPP.AddInfo1 = dlDoc.AddInfo1;
                        ptPP.AddInfo2 = dlDoc.AddInfo2;
                        ptPP.AddInfo3 = dlDoc.AddInfo3;
                        ptPP.AddInfo4 = dlDoc.AddInfo4;
                        ptPP.AddInfo5 = dlDoc.AddInfo5;
                        ptPP.AddInfo6 = dlDoc.AddInfo6;
                        ptPP.AddInfo7 = dlDoc.AddInfo7;
                        ptPP.AddInfo8 = dlDoc.AddInfo8;
                        ptPP.Fee = dlDoc.Fee;
                        ptPP.Add_Info_Fee_01 = dlDoc.Add_Info_Fee_01;
                        ptPP.Add_Info_Fee_02 = dlDoc.Add_Info_Fee_02;
                        ptPP.Add_Info_Fee_03 = dlDoc.Add_Info_Fee_03;
                        ptPP.Add_Info_Fee_04 = dlDoc.Add_Info_Fee_04;
                        ptPP.Add_Info_Fee_05 = dlDoc.Add_Info_Fee_05;

                        dDLPP.Them(ptPP);
                    }

                    Ghi(ptPP, null);
                }
            }
        }

        public void DocGhi(string rTenFile)
        {
            Transactions transactions = null;
            try
            {
                transactions = ObjectXMLSerializer<Transactions>.Load(rTenFile, SerializedFormat.Binary);
            }
            catch
            {
                transactions = new Transactions();
                transactions.Transaction = new PAYPOST.LOG.Transaction[0];
            }
            Transaction[] array = new Transaction[transactions.Transaction.Length];
            transactions.Transaction.CopyTo(array, 0);
        }
    }
}
