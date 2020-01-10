using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.Khac
{
    public class daBuuTa:daBase
    {
        private linqBuuTaDataContext lBTa = new linqBuuTaDataContext();
        private sp_tblBuuTa_ThongTinResult _BTa = new sp_tblBuuTa_ThongTinResult();

        public sp_tblBuuTa_ThongTinResult BTa { get => _BTa; set => _BTa = value; }

        public sp_tblBuuTa_ThongTinResult ThongTin()
        {
            try
            {
                BTa = lBTa.sp_tblBuuTa_ThongTin(BTa.MaBuuCuc, BTa.MaBuuTa).Single();
                return BTa;
            }
            catch
            {
                return null;
            }
        }

        public void Them()
        {
            lBTa.sp_tblBuuTa_Them(BTa.MaBuuCuc, BTa.MaBuuTa, BTa.TenBuuTa, BTa.DienThoai1, BTa.DienThoai2);
        }

        public DataTable DanhSach()
        {
            List<sp_tblBuuTa_DanhSachResult> lst;
            lst = lBTa.sp_tblBuuTa_DanhSach(MaBuuCuc).ToList();
            return daTienIch.ToDataTable(lst);
        }

        public DataTable DanhSachChon()
        {
            List<sp_tblBuuTa_DanhSachResult> lst;
            lst = lBTa.sp_tblBuuTa_DanhSach(MaBuuCuc).ToList();
            sp_tblBuuTa_DanhSachResult bt = new sp_tblBuuTa_DanhSachResult();
            bt.MaBuuCuc = MaBuuCuc;
            bt.MaBuuTa = "000000";
            bt.TenBuuTa = "--- Tất cả ---";
            lst.Add(bt);
            return daTienIch.ToDataTable(lst);
        }
    }
}
