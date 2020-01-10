using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DuLieuBCCP;

namespace daoSLPH.DataClient
{
    public class daDocDuLieuBCCP
    {
        #region "Khai báo"
        public event LuuDuLieuHandler Luu;
        public delegate void LuuDuLieuHandler(object sender, EventArgs e);
        public event KetThucLuuDuLieuHandler KetThucLuu;
        public delegate void KetThucLuuDuLieuHandler(object sender, EventArgs e);
        public DataTable BangDuLieu;
        public string MaBuuCuc;
        public DateTime NgayPhatHanh;
        #endregion

        public void DocDuLieuPhatHanh()
        {
            daCauHinh dCH = new daCauHinh();
            dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
            if (dCH.CauHinh != null)
            {
                MaBuuCuc = dCH.CauHinh.GiaTri;
            }

            daBuuGui dBG = new daBuuGui();
            dBG.SoHieuBuuCuc = MaBuuCuc;
            dBG.Ngay = NgayPhatHanh;

            dCH.Lay((int)daCauHinh.eCauHinh.Đường_Dẫn_BCCP);
            if(dCH.CauHinh!=null)
            {
                dBG.FileConfigBCCP = dCH.CauHinh.GiaTri;
            }

            BangDuLieu = dBG.DanhSachBuuGui();

            dCH.CauHinh.GiaTri = dBG.ChuoiKetNoiChay;
            dCH.CauHinh.ID = (int)daCauHinh.eCauHinh._Chuỗi_Kết_nối_Chạy;
            dCH.CauHinh.Ma = "ChuoiKetNoiBCCP";
            dCH.Them();
        }

        public void LuuBangDuLieu()
        {
            if (BangDuLieu.Rows.Count > 0)
            {
                daDuLieuBCCP dBCCP = new daDuLieuBCCP();

                dBCCP.Xoa(MaBuuCuc);

                for (int i = 0; i < BangDuLieu.Rows.Count; i++)
                {
                    dBCCP.Them(Chuyen1Dong(BangDuLieu.Rows[i], i + 1));
                    Luu(i, null);
                }
                KetThucLuu(BangDuLieu, null);
            }
        }

        private clsDuLieuBCCP Chuyen1Dong(DataRow dr,int i)
        {
            clsDuLieuBCCP ptBCCP = new clsDuLieuBCCP();

            ptBCCP.ID = i;
            ptBCCP.DaTruyen = false;
            ptBCCP.MaBuuCuc = MaBuuCuc;
            ptBCCP.NgayPhatHanh = NgayPhatHanh;
            ptBCCP.SoHieu = dr["SoHieu"].ToString();
            ptBCCP.MaDichVu = dr["MaDichVu"] == DBNull.Value ? "" : dr["MaDichVu"].ToString();
            ptBCCP.TenDichVu = dr["TenDichVu"] == DBNull.Value ? "" : dr["TenDichVu"].ToString();
            ptBCCP.MaBuuCucChapNhan = dr["MaBCChapNhan"] == DBNull.Value ? "" : dr["MaBCChapNhan"].ToString();
            try
            {
                ptBCCP.NgayGioChapNhan = DateTime.Parse(dr["NgayGioNhan"].ToString());
            }
            catch
            {
                ptBCCP.NgayGioChapNhan = NgayPhatHanh;
            }
            ptBCCP.LoaiBuuGui = dr["LoaiBuuGui"] == DBNull.Value ? "" : dr["LoaiBuuGui"].ToString();
            ptBCCP.MaBuuCucDong = dr["BuuCucNhanCT"] == DBNull.Value ? "" : dr["BuuCucNhanCT"].ToString();

            ptBCCP.SoChuyen = Convert.ToInt32(dr["SoChuyen"]);
            ptBCCP.SoTui = Convert.ToInt32(dr["SoTui"]);
            ptBCCP.MaDuongThu = dr["MaDuongThu"] == DBNull.Value ? "" : dr["MaDuongThu"].ToString();
            ptBCCP.TrongLuong = dr["TrongLuong"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["TrongLuong"]);
            ptBCCP.TrongLuongQuiDoi = dr["TrongLuongQuiDoi"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["TrongLuongQuiDoi"]);
            ptBCCP.MaTinhPhat = dr["MaTinhPhat"] == DBNull.Value ? "" : dr["MaTinhPhat"].ToString();
            ptBCCP.MaNuocPhat = dr["MaNuocPhat"] == DBNull.Value ? "" : dr["MaNuocPhat"].ToString();
            ptBCCP.MaKhachHang = dr["MaKhachHang"] == DBNull.Value ? "" : dr["MaKhachHang"].ToString();
            ptBCCP.TenKhachHang = dr["TenKhachHang"] == DBNull.Value ? "" : dr["TenKhachHang"].ToString();
            ptBCCP.DiaChiKhachHang = dr["DiaChiKhachHang"] == DBNull.Value ? "" : dr["DiaChiKhachHang"].ToString();
            ptBCCP.TenNguoiNhan = dr["TenNguoiNhan"] == DBNull.Value ? "" : dr["TenNguoiNhan"].ToString();
            ptBCCP.DiaChiNguoiNhan = dr["DiaChiNguoiNhan"] == DBNull.Value ? "" : dr["DiaChiNguoiNhan"].ToString();
            ptBCCP.CuocChinh = dr["CuocChinh"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["CuocChinh"]);
            ptBCCP.PhuPhiXD = dr["PhuPhiXD"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["PhuPhiXD"]);
            ptBCCP.PhuPhiVX = dr["PhuPhiVX"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["PhuPhiVX"]);
            ptBCCP.CuocCongThem = dr["CuocCongThem"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["CuocCongThem"]);
            ptBCCP.DichVuCongThem = dr["DichVuCongThem"] == DBNull.Value ? "" : dr["DichVuCongThem"].ToString();
            ptBCCP.SoTienCOD = dr["SoTienCOD"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["SoTienCOD"]);
            ptBCCP.CuocCOD = dr["CuocCOD"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["CuocCOD"]);
            ptBCCP.CuocCODVAT = dr["CuocCODVAT"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["CuocCODVAT"]);
            ptBCCP.GhiNo = dr["No"] == DBNull.Value ? false : Convert.ToBoolean(dr["No"]);
            if(ptBCCP.CuocCongThem<0)
            {
                ptBCCP.CuocCongThem = 0;
            }
            ptBCCP.TongCuoc = ptBCCP.CuocChinh + ptBCCP.PhuPhiVX + ptBCCP.PhuPhiXD + ptBCCP.CuocCongThem;

            ptBCCP.VAT = dr["VAT"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["VAT"]);
            ptBCCP.ThanhTien = dr["ThanhTien"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["ThanhTien"]);
            ptBCCP.NoiDungBuuGui = dr["NoiDungBuuGui"] == DBNull.Value ? "" : Convert.ToString(dr["NoiDungBuuGui"]);
            ptBCCP.GuiLo = dr["GuiLo"] == DBNull.Value ? false : Convert.ToBoolean(dr["GuiLo"]);
            ptBCCP.SoLo = dr["SoLo"] == DBNull.Value ? "" : Convert.ToString(dr["SoLo"]);

            return ptBCCP;
        }
    }
}
