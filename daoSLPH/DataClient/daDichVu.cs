using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DuLieuBCCP;
using LiteDB;

namespace daoSLPH.DataClient
{
    public class daDichVu
    {
        private daClient dCli = new daClient();

        public daDichVu()
        {
            dCli.Tao();
        }
            
        public void DocVaThem()
        {
            //Doc trong bccp
            daCauHinh dCH = new daCauHinh();
            daLayBangCuoc dLay = new daLayBangCuoc();
            dCH.Lay((int)daCauHinh.eCauHinh.Đường_Dẫn_BCCP);
            if (dCH.CauHinh != null)
            {
                dLay.FileConfigBCCP = dCH.CauHinh.GiaTri;
            }

            DataTable dt;
            dt = dLay.LayDSdichVu();
            //==============

            if (dt.Rows.Count > 0)
            {
                using (var db = new LiteDatabase(dCli.TenFileDichVu))
                {
                    var col = db.GetCollection<clsDichVu>(dCli.BangDichVu);
                    col.Delete(x => x.MaNhom == "BCCP");
                    int _ID;
                    try
                    {
                        _ID = col.Max();
                    }
                    catch
                    {
                        _ID= 0;
                    }
                    _ID = _ID + 1;

                    clsDichVu pDV;
                    DataRow dr;
                    for (int i=0;i<dt.Rows.Count;i++)
                    {
                        dr = dt.Rows[i];
                        pDV = new clsDichVu();
                        pDV.Ma = dr["ServiceCode"] == DBNull.Value ? "" : dr["ServiceCode"].ToString();
                        pDV.Ten = dr["ServiceName"] == DBNull.Value ? "" : dr["ServiceName"].ToString();
                        pDV.MaNhom = dr["ServiceTypeCode"] == DBNull.Value ? "" : dr["ServiceTypeCode"].ToString();
                        pDV.STTsx = i;
                        pDV.ID = _ID + i;

                        col.Insert(pDV);
                    }
                    col.EnsureIndex(x => x.ID);
                    db.Shrink();
                }
            }
        }

        public List<clsDichVu> LayDanhSach(string rMaNhom)
        {
            List<clsDichVu> lstPP = new List<clsDichVu>();
            using (var db = new LiteDatabase(dCli.TenFileDichVu))
            {
                var col = db.GetCollection<clsDichVu>(dCli.BangDichVu);
                lstPP = col.Find(x => x.MaNhom == rMaNhom).ToList();
            }

            return lstPP;
        }
    }

    public class clsDichVu
    {
        private int _ID;

        private string _Ma;

        private string _Ten;

        private string _MaNhom;

        private int _STTsx;

        public int ID { get => _ID; set => _ID = value; }
        public string Ma { get => _Ma; set => _Ma = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string MaNhom { get => _MaNhom; set => _MaNhom = value; }
        public int STTsx { get => _STTsx; set => _STTsx = value; }
    }
}
