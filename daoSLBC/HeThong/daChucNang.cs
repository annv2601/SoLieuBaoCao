using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using daoSLBC.Core;
using daoSLBC.Database.HeThong;

namespace daoSLBC.HeThong
{
    public class daChucNang
    {
        private linqChucNangDataContext lCN = new linqChucNangDataContext();
        private sp_tblChucNang_ThongTinResult _CN = new sp_tblChucNang_ThongTinResult();

        public sp_tblChucNang_ThongTinResult CN { get => _CN; set => _CN = value; }

        public List<sp_tblChucNang_DanhSachResult> lstDanhSach()
        {
            return lCN.sp_tblChucNang_DanhSach(CN.Nhom).ToList();
        }

        public List<sp_tblChucNang_DanhSach_TheoCapTrenResult> lstDanhSachTheoCapTren(int IDTren, int CapHienThi)
        {
            return lCN.sp_tblChucNang_DanhSach_TheoCapTren(IDTren, CapHienThi).ToList();
        }
    }
}
