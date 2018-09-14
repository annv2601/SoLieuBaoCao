using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using LiteDB;

namespace daoSLPH.DataClient
{
    public class daCauHinh
    {
        public enum eCauHinh
        {
            Mã_Bưu_Cục=1,
            Tên_Bưu_Cục=2,
            Đường_Dẫn_Paypost=3,
            Tên_Đăng_nhập_Paypost=4,
            Đường_Dẫn_BCCP=5
        }

        public List<bCauHinh> lstBangThamSo=new List<bCauHinh>();
        private bCauHinh _CauHinh = new bCauHinh();

        public bCauHinh CauHinh { get => _CauHinh; set => _CauHinh = value; }

        public daCauHinh()
        {
            bCauHinh pCH;
            pCH = new bCauHinh();
            pCH.ID = 1;
            pCH.Ma = "MaBuuCuc";
            pCH.GiaTri = "Mã Bưu cục";
            lstBangThamSo.Add(pCH);

            pCH = new bCauHinh();
            pCH.ID = 2;
            pCH.Ma = "TenBuuCuc";
            pCH.GiaTri = "Tên Bưu cục";
            lstBangThamSo.Add(pCH);

            pCH = new bCauHinh();
            pCH.ID = 3;
            pCH.Ma = "DuongDanPayPost";
            pCH.GiaTri = "Đường dẫn Paypost";
            lstBangThamSo.Add(pCH);

            pCH = new bCauHinh();
            pCH.ID = 4;
            pCH.Ma = "TenDangNhapPayPost";
            pCH.GiaTri = "Tên đăng nhập Paypost";
            lstBangThamSo.Add(pCH);

            pCH = new bCauHinh();
            pCH.ID = 5;
            pCH.Ma = "DuongDanBCCP";
            pCH.GiaTri = "Đường dẫn BCCP";
            lstBangThamSo.Add(pCH);
        }

        public string TimMaThamSo(int rID)
        {
            string _Ma = "";
            foreach(bCauHinh pt in lstBangThamSo)
            {
                if(pt.ID==rID)
                {
                    _Ma = pt.Ma;
                    break;
                }
            }
            return _Ma;
        }

        public void Them()
        {
            daClient dC = new daClient();
            dC.Tao();

            using (var db = new LiteDatabase(dC.TenFileCauHinh))
            {
                var col = db.GetCollection<bCauHinh>(dC.BangCauHinh);
                if (CauHinh.ID == 0)
                {
                    try
                    {
                        CauHinh.ID = col.Max() + 1;
                    }
                    catch
                    {
                        CauHinh.ID = 1;
                    }
                    col.Insert(CauHinh);
                    col.EnsureIndex(x => x.ID);
                }
                else
                {
                    col.Update(CauHinh.ID,CauHinh);
                }
            }
        }

        public bCauHinh Lay(string rMa)
        {
            daClient dC = new daClient();
            dC.Tao();

            using (var db = new LiteDatabase(dC.TenFileCauHinh))
            {
                var col = db.GetCollection<bCauHinh>(dC.BangCauHinh);
                CauHinh = col.FindOne(x => x.Ma == rMa);
            }
            return CauHinh;
        }

        public bCauHinh Lay(int rID)
        {
            return Lay(TimMaThamSo(rID));
        }
    }
}

