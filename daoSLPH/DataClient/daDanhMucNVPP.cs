using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using LiteDB;


namespace daoSLPH.DataClient
{
    public class daDanhMucNVPP
    {
        public void LayDanhMuc()
        {
            string rTenFile = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Đường_Dẫn_Paypost));
            if (dCH.CauHinh != null)
            {
                rTenFile = dCH.CauHinh.GiaTri;
            }

            rTenFile = rTenFile + "\\PAYPOST DICTIONARY\\PROVIDER_ACNT.DIC";

            object[] obj;
            IFormatter formatter = new BinaryFormatter();
            if (File.Exists(rTenFile))
            {
                Stream stream = new FileStream(rTenFile, System.IO.FileMode.Open, FileAccess.Read, FileShare.None);
                obj = (object[])formatter.Deserialize(stream);
                stream.Close();

                daClient dC = new daClient();
                dC.Tao();
                var db = new LiteDatabase(dC.TenFileNVPP);
                var col = db.GetCollection<bCauHinh>(dC.BangDanhMuc);
                bCauHinh pt;
                string[] str;
                int n=0;
                for (int i = 0; i < obj.Length; i++)
                {
                    str = obj[i].ToString().Split(';');
                    if(str[2]!="6")
                    {
                        pt = new bCauHinh();
                        n = n + 1;
                        pt.ID = n;
                        pt.Ma = str[3].Trim();
                        pt.GiaTri = str[4].Trim();
                        col.Insert(pt);
                    }
                }
                col.EnsureIndex(x => x.ID);
            }
        }

        public List<bCauHinh> Doc()
        {
            daClient dC = new daClient();
            dC.Tao();
            var db = new LiteDatabase(dC.TenFileNVPP);
            var col = db.GetCollection<bCauHinh>(dC.BangDanhMuc);
            return col.FindAll().OrderBy(x => x.Ma).ToList();
        }
    }
}
