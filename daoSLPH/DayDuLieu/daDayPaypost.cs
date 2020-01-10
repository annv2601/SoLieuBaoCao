using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoSLPH.DataClient;
using daoSLPH.PayPost;
using daoSLPH.LanLayDuLieu;
using daoSLPH.Untities;

namespace daoSLPH.DayDuLieu
{
    public class daDayPaypost
    {
        public event DayHandler Day;
        public delegate void DayHandler(object sender, EventArgs e);
        public event DayXongHandler DayXong;
        public delegate void DayXongHandler(object sender, EventArgs e);

        public void Chay()
        {
            clsLan ptLog = new clsLan();
            ptLog.ThoiGianBatDau = DateTime.Now;

            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Mã_Bưu_Cục));
            if (dCH.CauHinh != null)
            {
                ptLog.MaBuuCuc = dCH.CauHinh.GiaTri;
            }


            daThongTinMay dTTM = new daThongTinMay();
            ptLog.MAC = dTTM.MAC;
            ptLog.DiaChiIP = dTTM.DiaChiIP;

            daPhatHanhPayPost dPHPP = new daPhatHanhPayPost();

            daDuLieuPayPost dPP = new daDuLieuPayPost();
            List<clsDuLieuPP> lstTruyen = new List<clsDuLieuPP>();
            lstTruyen = dPP.LayDanhSachChuaTruyen();
            ptLog.SoLuong = 0;
            ptLog.TongTien = 0;
            dPHPP.PaPo.MaBuuCuc = ptLog.MaBuuCuc;
            //dPHPP.Xoa();
            foreach (clsDuLieuPP ptPP in lstTruyen)
            {                
                dPHPP.PaPo.NgayPhatHanh = ptPP.NgayPhatHanh;
                dPHPP.PaPo.MAC = dTTM.MAC;
                dPHPP.PaPo.TranTime = ptPP.TranTime;
                dPHPP.PaPo.TranCat = ptPP.TranCat;
                dPHPP.PaPo.InvokedFrom = ptPP.InvokedFrom;
                dPHPP.PaPo.TranID = ptPP.TranID;
                dPHPP.PaPo.PAC = ptPP.PAC;
                dPHPP.PaPo.AccountID = ptPP.AccountID;
                dPHPP.PaPo.TranAmount = ptPP.TranAmount;
                dPHPP.PaPo.SenderName = ptPP.SenderName;
                dPHPP.PaPo.AddInfo1 = ptPP.AddInfo1;
                dPHPP.PaPo.AddInfo2 = ptPP.AddInfo2;
                dPHPP.PaPo.AddInfo3 = ptPP.AddInfo3;
                dPHPP.PaPo.AddInfo4 = ptPP.AddInfo4;
                dPHPP.PaPo.AddInfo5 = ptPP.AddInfo5;
                dPHPP.PaPo.AddInfo6 = ptPP.AddInfo6;
                dPHPP.PaPo.AddInfo7 = ptPP.AddInfo7;
                dPHPP.PaPo.AddInfo8 = ptPP.AddInfo8;
                dPHPP.PaPo.Fee = ptPP.Fee;
                dPHPP.PaPo.Add_Info_Fee_01 = ptPP.Add_Info_Fee_01;
                dPHPP.PaPo.Add_Info_Fee_02 = ptPP.Add_Info_Fee_02;
                dPHPP.PaPo.Add_Info_Fee_03 = ptPP.Add_Info_Fee_03;
                dPHPP.PaPo.Add_Info_Fee_04 = ptPP.Add_Info_Fee_04;
                dPHPP.PaPo.Add_Info_Fee_05 = ptPP.Add_Info_Fee_05;

                dPHPP.Them();

                //Danh dau da truyen
                ptPP.DaTruyen = true;
                dPP.Them(ptPP);

                ptLog.SoLuong = ptLog.SoLuong + 1;
                ptLog.TongTien = ptLog.TongTien.Value + Convert.ToDecimal(ptPP.TranAmount.Value);

                Day(ptPP, null);
            }
            
            daLogLanLayDuLieu dLog = new daLogLanLayDuLieu();
            ptLog.DichVu = "PayPost";
            ptLog.ThoiGianKetThuc = DateTime.Now;            
            dLog.Them(ptLog);

            if (ptLog.SoLuong != 0)
            {
                daLanLayDuLieu dLan = new daLanLayDuLieu();
                dLan.LanLay.MaBuuCuc = ptLog.MaBuuCuc;
                dLan.LanLay.MAC = ptLog.MAC;
                dLan.LanLay.DiaChiIP = ptLog.DiaChiIP;
                dLan.LanLay.DichVu = ptLog.DichVu;
                dLan.LanLay.SoLuong = ptLog.SoLuong;
                dLan.LanLay.TongTien = ptLog.TongTien;
                dLan.LanLay.ThoiGianBatDau = ptLog.ThoiGianBatDau;
                dLan.LanLay.ThoiGianKetThuc = ptLog.ThoiGianKetThuc;
                dLan.Them();
            }

            DayXong(null, null);
        }

        public void Xoa()
        {
            daThongTinMay dTTM = new daThongTinMay();
            
            daPhatHanhPayPost dPHPP = new daPhatHanhPayPost();
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Mã_Bưu_Cục));
            if (dCH.CauHinh != null)
            {
                dPHPP.PaPo.MaBuuCuc = dCH.CauHinh.GiaTri;
            }
            dPHPP.PaPo.MAC = dTTM.MAC;
            dPHPP.Xoa();
        }
    }
}
