using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoSLPH.Database;
using LiteDB;

namespace daoSLPH.DataClient
{
    public class daLogLanLayDuLieu
    {
        public void Them(clsLan ptLan)
        {
            daClient dC = new daClient();
            dC.Tao();

            using (var db = new LiteDatabase(dC.TenFileLogLay))
            {
                var col = db.GetCollection<clsLan>(dC.BangLanLay);
                if (ptLan.ID == 0)
                {
                    try
                    {
                        ptLan.ID = col.Max() + 1;
                    }
                    catch
                    {
                        ptLan.ID = 1;
                    }
                    col.Insert(ptLan);
                    col.EnsureIndex(x => x.ID);
                }
                else
                {
                    col.Update(ptLan.ID,ptLan);
                }
            }
        }
    }

    public class clsLan:sp_tblLanLayDuLieu_ThongTinResult
    {
        private int _ID;

        public int ID { get => _ID; set => _ID = value; }
    }
}
