using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoSLPH.Database;
using LiteDB;

namespace daoSLPH.DataClient
{
    public class daDuLieuBCCP
    {
        private daClient dCli = new daClient();
        public daDuLieuBCCP()
        {
            dCli.Tao();
        }
        public void Them(clsDuLieuBCCP ptBCCP)
        {
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                col.Insert(ptBCCP);
                col.EnsureIndex(x => x.ID);
            }
        }

        public void Them(List<clsDuLieuBCCP> lstBCCP)
        {
            int i = 1;
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                foreach (clsDuLieuBCCP pt in lstBCCP)
                {
                    pt.ID = i;
                    pt.DaTruyen = false;
                    col.Insert(pt);
                    i = i + 1;
                }
                col.EnsureIndex(x => x.ID);
            }
        }

        public void CapNhat(clsDuLieuBCCP ptBCCP)
        {
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                col.Update(ptBCCP.ID, ptBCCP);
            }
        }

        public List<clsDuLieuBCCP> LayDanhSachChuaTruyen()
        {
            List<clsDuLieuBCCP> lstBCCP = new List<clsDuLieuBCCP>();
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                lstBCCP = col.Find(x => x.DaTruyen == false).ToList();
            }

            return lstBCCP;
        }

        public void Xoa(string rMaBC)
        {
            using (var db = new LiteDatabase(dCli.TenFileDuLieuBCCP))
            {
                var col = db.GetCollection<clsDuLieuBCCP>(dCli.BangDuLieuBCCP);
                col.Delete(x=>x.MaBuuCuc==rMaBC);
                db.Shrink();
            }
        }
    }

    public class clsDuLieuBCCP:sp_tblPhatHanhBCCP_ThongTinResult
    {
        private int _ID;

        private bool _DaTruyen;

        public int ID { get => _ID; set => _ID = value; }
        public bool DaTruyen { get => _DaTruyen; set => _DaTruyen = value; }
    }
}
