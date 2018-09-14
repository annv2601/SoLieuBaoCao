using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
}
