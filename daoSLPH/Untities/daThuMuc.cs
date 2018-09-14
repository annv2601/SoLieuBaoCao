using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace daoSLPH.Untities
{    
    public class daThuMuc
    {
        public const string DichVuPaypost = "PayPOST Counter";

        public string TimThuMuc()
        {
            IEnumerable<string> dirs = Directory.EnumerateDirectories(@"C:\Program Files", "*", SearchOption.AllDirectories).Where(x => x.Contains(DichVuPaypost));
            string TenTM = "";
            foreach (string dir in dirs)
            {
                TenTM = dir;
            }
            return TenTM;
        }

        public List<string> TimThuMucCoDuLieu(string rDuongDan)
        {
            DirectoryInfo di = new DirectoryInfo(rDuongDan);
            List<string> lstKQ = new List<string>();
            foreach(DirectoryInfo pt in di.GetDirectories())
            {
                if(pt.LastAccessTime.ToShortDateString()==DateTime.Now.ToShortDateString())
                {
                    lstKQ.Add(pt.Name);
                }
            }
            return lstKQ;
        }
    }
}
