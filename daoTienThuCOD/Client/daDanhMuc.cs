using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using daoTienThuCOD.Database;
using daoTienThuCOD.Khac;
using LiteDB;
using daoSLPH.DataClient;

namespace daoTienThuCOD.Client
{
    public class daDanhMuc
    {
        #region Danh muc Don Vi
        public void LayDanhMucDVi()
        {
            string rMaBuuCuc = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Mã_Bưu_Cục));
            if (dCH.CauHinh != null)
            {
                rMaBuuCuc = dCH.CauHinh.GiaTri;

                daBuuCuc dBC = new daBuuCuc();
                daClient dC = new daClient();
                dC.Tao();
                var db = new LiteDatabase(dC.TenFileNVPP);
                var col = db.GetCollection<sp_LayThongTinBuuCucResult>(dC.BangDanhMucDVi);
                dBC.BC.MaBuuCuc = rMaBuuCuc;
                if(dBC.ThongTin()!=null)
                {
                    col.Insert(1,dBC.BC);
                }
            }            
        }

        public sp_LayThongTinBuuCucResult LayDvi()
        {
            string rMaBuuCuc = "";
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Mã_Bưu_Cục));
            if (dCH.CauHinh != null)
            {
                rMaBuuCuc = dCH.CauHinh.GiaTri;
            }
            daClient dC = new daClient();
            dC.Tao();
            var db = new LiteDatabase(dC.TenFileNVPP);
            var col = db.GetCollection<sp_LayThongTinBuuCucResult>(dC.BangDanhMucDVi);
            return col.FindOne(x => x.MaBuuCuc == rMaBuuCuc);
        }
        #endregion

        #region Danh muc nguoi dung
        public void ThemDMND(sp_tblNopTienNganHang_ThongTinResult rND)
        {
            daClient dC = new daClient();
            dC.Tao();
            var db = new LiteDatabase(dC.TenFileNVPP);
            var col = db.GetCollection<sp_tblNopTienNganHang_ThongTinResult>(dC.BangDanhMucND);
            col.Delete(1);
            db.Shrink();
            col.Insert(1,rND);
        }

        public sp_tblNopTienNganHang_ThongTinResult LayND()
        {
            daClient dC = new daClient();
            dC.Tao();
            var db = new LiteDatabase(dC.TenFileNVPP);
            var col = db.GetCollection<sp_tblNopTienNganHang_ThongTinResult>(dC.BangDanhMucND);
            return col.FindById(1);
        }
        #endregion
    }
}
