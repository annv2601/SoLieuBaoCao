using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using daoTienThuCOD.Database;

namespace daoTienThuCOD.ChuyenHoan
{
    public class daChuyenTiep:daBase
    {
        private linqChuyenTiepDataContext lCT = new linqChuyenTiepDataContext();
        private sp_tblChuyenTiep_DanhSachResult _CTiep = new sp_tblChuyenTiep_DanhSachResult();

        public sp_tblChuyenTiep_DanhSachResult CTiep { get => _CTiep; set => _CTiep = value; }

        public void Xoa()
        {
            lCT.sp_tblChuyenTiep_Xoa(MaBuuCuc, Ngay);
        }

        public void Them()
        {
            lCT.sp_tblChuyenTiep_Them(CTiep.Ngay,
                CTiep.Ca,
                CTiep.MaBuuCuc,
                CTiep.ItemCode,
                CTiep.ReceiverFullname,
                CTiep.ReceiverAddress,
                CTiep.ReceiverTel,
                CTiep.Weight,
                CTiep.SoTienCOD,
                CTiep.TongCuoc,
                CTiep.VAT,
                CTiep.ThanhTien,
                CTiep.LyDo,
                CTiep.NgayChuyenHoan);
        }

        public void CapNhatTrangThai()
        {
            lCT.sp_tblChuyenTiep_CapNhatTrangThai(MaBuuCuc, Ngay);
        }
        
        public List<sp_tblChuyenHoan_DanhSachResult> lstDanhSach()
        {
            List<sp_tblChuyenTiep_DanhSachResult> lst;
            lst = lCT.sp_tblChuyenTiep_DanhSach(MaBuuCuc, TuNgay, DenNgay).ToList();
            AutoMapper.Mapper.CreateMap<sp_tblChuyenTiep_DanhSachResult, sp_tblChuyenHoan_DanhSachResult>();

            return AutoMapper.Mapper.Map<List<sp_tblChuyenHoan_DanhSachResult>>(lst);
        }
    }
}
