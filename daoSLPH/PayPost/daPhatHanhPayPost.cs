using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLPH.Database;

namespace daoSLPH.PayPost
{
    public class daPhatHanhPayPost
    {
        private linqPhatHanhPayPostDataContext lPP = new linqPhatHanhPayPostDataContext();
        private sp_tblPhatHanhPayPost_ThongTinResult _PaPo = new sp_tblPhatHanhPayPost_ThongTinResult();

        public sp_tblPhatHanhPayPost_ThongTinResult PaPo { get => _PaPo; set => _PaPo = value; }

        public void Them()
        {
            lPP.sp_tblPhatHanhPayPost_Them(PaPo.MaBuuCuc,
                PaPo.NgayPhatHanh,
                PaPo.MAC,
                PaPo.TranTime,
                PaPo.TranCat,
                PaPo.InvokedFrom,
                PaPo.TranID,
                PaPo.PAC,
                PaPo.AccountID,
                PaPo.TranAmount,
                PaPo.SenderName,
                PaPo.AddInfo1,
                PaPo.AddInfo2,
                PaPo.AddInfo3,
                PaPo.AddInfo4,
                PaPo.AddInfo5,
                PaPo.AddInfo6,
                PaPo.AddInfo7,
                PaPo.AddInfo8,
                PaPo.Fee,
                PaPo.Add_Info_Fee_01,
                PaPo.Add_Info_Fee_02,
                PaPo.Add_Info_Fee_03,
                PaPo.Add_Info_Fee_04,
                PaPo.Add_Info_Fee_05);
        }
    }
}
