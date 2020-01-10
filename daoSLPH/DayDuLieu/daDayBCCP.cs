using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoSLPH.DataClient;
using daoSLPH.BCCP;
using daoSLPH.LanLayDuLieu;
using daoSLPH.Untities;

namespace daoSLPH.DayDuLieu
{
    public class daDayBCCP
    {
        public event DayHandler Day;
        public delegate void DayHandler(object sender, EventArgs e);
        public event DayXongHandler DayXong;
        public delegate void DayXongHandler(object sender, EventArgs e);

        public void Chay()
        {
            daCauHinh dCH = new daCauHinh();
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Lấy_BCCP));
            bool _LayBCCP = false;
            if (dCH.CauHinh != null)
            {
                try
                {
                    _LayBCCP = bool.Parse(dCH.CauHinh.GiaTri);
                }
                catch { }
            }
            if (!_LayBCCP)
            {
                //May nay khong lay BCCP
                return;
            }

            clsLan ptLog = new clsLan();
            ptLog.ThoiGianBatDau = DateTime.Now;
                        
            dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh.Mã_Bưu_Cục));
            if (dCH.CauHinh != null)
            {
                ptLog.MaBuuCuc = dCH.CauHinh.GiaTri;
            }


            daThongTinMay dTTM = new daThongTinMay();
            ptLog.MAC = dTTM.MAC;
            ptLog.DiaChiIP = dTTM.DiaChiIP;

            daPhatHanhBCCP dPHBCCP = new daPhatHanhBCCP();

            daDuLieuBCCP dBCCP = new daDuLieuBCCP();
            List<clsDuLieuBCCP> lstTruyen = new List<clsDuLieuBCCP>();
            lstTruyen = dBCCP.LayDanhSachChuaTruyen();
            
            foreach (clsDuLieuBCCP ptBCCP in lstTruyen)
            {
                dPHBCCP.PH.MaBuuCuc = ptLog.MaBuuCuc;
                dPHBCCP.PH.NgayPhatHanh = ptBCCP.NgayPhatHanh;
                dPHBCCP.PH.MAC = ptBCCP.MAC;
                dPHBCCP.PH.SoHieu = ptBCCP.SoHieu;
                dPHBCCP.PH.MaDichVu = ptBCCP.MaDichVu;
                dPHBCCP.PH.TenDichVu = ptBCCP.TenDichVu;
                dPHBCCP.PH.LoaiBuuGui = ptBCCP.LoaiBuuGui;
                dPHBCCP.PH.SoChuyen = ptBCCP.SoChuyen;
                dPHBCCP.PH.SoTui = ptBCCP.SoTui;
                dPHBCCP.PH.MaDuongThu = ptBCCP.MaDuongThu;
                dPHBCCP.PH.MaBuuCucChapNhan = ptBCCP.MaBuuCucChapNhan;
                dPHBCCP.PH.NgayGioChapNhan = ptBCCP.NgayGioChapNhan;
                dPHBCCP.PH.MaBuuCucDong = ptBCCP.MaBuuCucDong;
                dPHBCCP.PH.NgayGioDong = ptBCCP.NgayGioDong;
                dPHBCCP.PH.TrongLuong = ptBCCP.TrongLuong;
                dPHBCCP.PH.TrongLuongQuiDoi = ptBCCP.TrongLuongQuiDoi;
                dPHBCCP.PH.MaTinhPhat = ptBCCP.MaTinhPhat;
                dPHBCCP.PH.MaNuocPhat = ptBCCP.MaNuocPhat;
                dPHBCCP.PH.MaKhachHang = ptBCCP.MaKhachHang;
                dPHBCCP.PH.TenKhachHang = ptBCCP.TenKhachHang;
                dPHBCCP.PH.DiaChiKhachHang = ptBCCP.DiaChiKhachHang;
                dPHBCCP.PH.TenNguoiNhan = ptBCCP.TenNguoiNhan;
                dPHBCCP.PH.DiaChiNguoiNhan = ptBCCP.DiaChiNguoiNhan;
                dPHBCCP.PH.CuocChinh = ptBCCP.CuocChinh;
                dPHBCCP.PH.PhuPhiXD = ptBCCP.PhuPhiXD;
                dPHBCCP.PH.PhuPhiVX = ptBCCP.PhuPhiVX;
                dPHBCCP.PH.CuocCongThem = ptBCCP.CuocCongThem;
                dPHBCCP.PH.DichVuCongThem = ptBCCP.DichVuCongThem;
                dPHBCCP.PH.SoTienCOD = ptBCCP.SoTienCOD;
                dPHBCCP.PH.CuocCOD = ptBCCP.CuocCOD;
                dPHBCCP.PH.VAT = ptBCCP.VAT;
                dPHBCCP.PH.CuocCODVAT = ptBCCP.CuocCODVAT;
                dPHBCCP.PH.ThanhTien = ptBCCP.ThanhTien;
                dPHBCCP.PH.TongCuoc = ptBCCP.TongCuoc;
                dPHBCCP.PH.GhiNo = ptBCCP.GhiNo;
                dPHBCCP.PH.NoiDungBuuGui = ptBCCP.NoiDungBuuGui;
                dPHBCCP.PH.GuiLo = ptBCCP.GuiLo;
                dPHBCCP.PH.SoLo = ptBCCP.SoLo;

                dPHBCCP.ThemPH();

                //Danh dau da truyen
                ptBCCP.DaTruyen = true;
                dBCCP.CapNhat(ptBCCP);

                Day(ptBCCP, null);
            }

            ptLog.SoLuong = lstTruyen.Count;

            daLogLanLayDuLieu dLog = new daLogLanLayDuLieu();
            ptLog.DichVu = "BCCP";
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

                dCH.Lay(dCH.TimMaThamSo((int)daCauHinh.eCauHinh._Chuỗi_Kết_nối_Chạy));
                if (dCH.CauHinh != null)
                {
                    dLan.LanLay.ChuoiKetNoi = dCH.CauHinh.GiaTri;
                }
                dLan.LanLay.ChuoiKetNoi = "";

                dLan.Them();
            }
            try
            {
                DayXong(null, null);
            }
            catch { }
        }
    }
}
