using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using daoSLPH.Database;
using LiteDB;

namespace daoSLPH.DataClient
{
    public class daDuLieuPayPost
    {
        public void Them(clsDuLieuPP ptDLPP)
        {
            daClient dC = new daClient();
            dC.Tao();

            using (var db = new LiteDatabase(dC.TenFileDuLieuPP))
            {
                var col = db.GetCollection<clsDuLieuPP>(dC.BangDuLieuPP);
                if (ptDLPP.ID == 0)
                {
                    try
                    {
                        ptDLPP.ID = col.Max() + 1;
                    }
                    catch
                    {
                        ptDLPP.ID = 1;
                    }
                    ptDLPP.DaTruyen = false;
                    col.Insert(ptDLPP);
                    col.EnsureIndex(x => x.ID);
                }
                else
                {
                    col.Update(ptDLPP.ID,ptDLPP);
                }
            }
        }

        public clsDuLieuPP Tim(string rTranID)
        {
            daClient dC = new daClient();
            dC.Tao();
            clsDuLieuPP _kqtim=new clsDuLieuPP();
            using (var db = new LiteDatabase(dC.TenFileDuLieuPP))
            {
                var col = db.GetCollection<clsDuLieuPP>(dC.BangDuLieuPP);
                _kqtim = col.FindOne(x => x.TranID == rTranID);
            }
            
            return _kqtim;
        }

        public List<clsDuLieuPP> LayDanhSachChuaTruyen()
        {
            daClient dC = new daClient();
            dC.Tao();
            List<clsDuLieuPP> lstPP = new List<clsDuLieuPP>();
            using (var db = new LiteDatabase(dC.TenFileDuLieuPP))
            {
                var col = db.GetCollection<clsDuLieuPP>(dC.BangDuLieuPP);
                lstPP = col.Find(x => x.DaTruyen == false).ToList();
            }

            return lstPP;
        }

        public DataTable BaoCao(DateTime rNgay)
        {
            //Dich vu
            List<bCauHinh> lstDV = new List<bCauHinh>();
            daDanhMucNVPP dDM = new daDanhMucNVPP();
            lstDV = dDM.Doc();
            //===========

            daClient dC = new daClient();
            dC.Tao();
            List<clsDuLieuPP> lstPPThu = new List<clsDuLieuPP>();
            List<clsDuLieuPP> lstPPChi = new List<clsDuLieuPP>();
            List<clsBaoCaoPP> lst = new List<clsBaoCaoPP>();
            clsBaoCaoPP bc;
            using (var db = new LiteDatabase(dC.TenFileDuLieuPP))
            {
                var col = db.GetCollection<clsDuLieuPP>(dC.BangDuLieuPP);
                foreach (bCauHinh dm in lstDV)
                {
                    lstPPThu = col.Find(x => x.NgayPhatHanh.Value.ToShortDateString() == rNgay.ToShortDateString() && x.PAC.Trim() == dm.Ma && (x.InvokedFrom == "THU" || x.InvokedFrom == "NORMAL")).ToList();
                    lstPPChi = col.Find(x => x.NgayPhatHanh.Value.ToShortDateString() == rNgay.ToShortDateString() && x.PAC.Trim() == dm.Ma && x.InvokedFrom == "CHI").ToList();
                    bc = new clsBaoCaoPP();
                    bc.Ma = dm.Ma;
                    bc.Ten = dm.GiaTri;
                    bc.Thu = lstPPThu.Sum(t => t.TranAmount.Value);
                    bc.Chi = lstPPChi.Sum(c => c.TranAmount.Value);
                    if (bc.Thu != 0 || bc.Chi != 0)
                    {
                        lst.Add(bc);
                    }
                }
                

            }

            return daTienIch.ToDataTable(lst);
        }

        public void Xoa(DateTime rNgay)
        {
            daClient dC = new daClient();
            dC.Tao();
            
            using (var db = new LiteDatabase(dC.TenFileDuLieuPP))
            {
                var col = db.GetCollection<clsDuLieuPP>(dC.BangDuLieuPP);
                col.Delete(x => x.NgayPhatHanh.Value <= daTienIch.CuoiNgay(rNgay) && x.DaTruyen==true);
                db.Shrink();
            }
        }

        public void XoaTatCa()
        {
            daClient dC = new daClient();
            dC.Tao();

            using (var db = new LiteDatabase(dC.TenFileDuLieuPP))
            {
                var col = db.GetCollection<clsDuLieuPP>(dC.BangDuLieuPP);
                col.Delete(x => x.DaTruyen == true);
                db.Shrink();
            }
        }

        private bool disposed;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    
                }
            }

            disposed = true;
        }
    }

    public class clsDuLieuPP:sp_tblPhatHanhPayPost_ThongTinResult
    {
        private int _ID;

        private bool _DaTruyen;

        public int ID { get => _ID; set => _ID = value; }
        public bool DaTruyen { get => _DaTruyen; set => _DaTruyen = value; }
    }

    public class clsBaoCaoPP
    {
        private string _Ma;

        private string _Ten;

        private double _Thu;

        private double _Chi;

        public string Ma { get => _Ma; set => _Ma = value; }
        public double Thu { get => _Thu; set => _Thu = value; }
        public double Chi { get => _Chi; set => _Chi = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
    }
}
