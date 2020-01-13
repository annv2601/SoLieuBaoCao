using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daoKeToanSoDu.Database
{
    public class clsBaoCao
    {
    }

    public partial class sp_tblKeToanSoDu_BaoCaoTonQuyResult
    {

        private string _STT;

        private string _Ten;

        private System.Nullable<decimal> _DinhMucLuuQuyTCBC_DonVi;

        private System.Nullable<decimal> _DinhMucLuuQuyTKBD_DonVi;

        private System.Nullable<decimal> _TCBCTapTrung;

        private System.Nullable<decimal> _TCBCThanhToanTaiDonVi;

        private System.Nullable<decimal> _TKBD;

        private System.Nullable<decimal> _KinhDoanh;

        private System.Nullable<decimal> _Cong;

        private string _GhiChu;

        private System.Nullable<bool> _Dam;

        private System.Nullable<bool> _Nghieng;

        public sp_tblKeToanSoDu_BaoCaoTonQuyResult()
        {
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_STT", DbType = "NVarChar(5)")]
        public string STT
        {
            get
            {
                return this._STT;
            }
            set
            {
                if ((this._STT != value))
                {
                    this._STT = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Ten", DbType = "NVarChar(255)")]
        public string Ten
        {
            get
            {
                return this._Ten;
            }
            set
            {
                if ((this._Ten != value))
                {
                    this._Ten = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DinhMucLuuQuyTCBC_DonVi", DbType = "Decimal(22,0)")]
        public System.Nullable<decimal> DinhMucLuuQuyTCBC_DonVi
        {
            get
            {
                return this._DinhMucLuuQuyTCBC_DonVi;
            }
            set
            {
                if ((this._DinhMucLuuQuyTCBC_DonVi != value))
                {
                    this._DinhMucLuuQuyTCBC_DonVi = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DinhMucLuuQuyTKBD_DonVi", DbType = "Decimal(22,0)")]
        public System.Nullable<decimal> DinhMucLuuQuyTKBD_DonVi
        {
            get
            {
                return this._DinhMucLuuQuyTKBD_DonVi;
            }
            set
            {
                if ((this._DinhMucLuuQuyTKBD_DonVi != value))
                {
                    this._DinhMucLuuQuyTKBD_DonVi = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TCBCTapTrung", DbType = "Decimal(22,0)")]
        public System.Nullable<decimal> TCBCTapTrung
        {
            get
            {
                return this._TCBCTapTrung;
            }
            set
            {
                if ((this._TCBCTapTrung != value))
                {
                    this._TCBCTapTrung = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TCBCThanhToanTaiDonVi", DbType = "Decimal(22,0)")]
        public System.Nullable<decimal> TCBCThanhToanTaiDonVi
        {
            get
            {
                return this._TCBCThanhToanTaiDonVi;
            }
            set
            {
                if ((this._TCBCThanhToanTaiDonVi != value))
                {
                    this._TCBCThanhToanTaiDonVi = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TKBD", DbType = "Decimal(22,0)")]
        public System.Nullable<decimal> TKBD
        {
            get
            {
                return this._TKBD;
            }
            set
            {
                if ((this._TKBD != value))
                {
                    this._TKBD = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_KinhDoanh", DbType = "Decimal(22,0)")]
        public System.Nullable<decimal> KinhDoanh
        {
            get
            {
                return this._KinhDoanh;
            }
            set
            {
                if ((this._KinhDoanh != value))
                {
                    this._KinhDoanh = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Cong", DbType = "Decimal(25,0)")]
        public System.Nullable<decimal> Cong
        {
            get
            {
                return this._Cong;
            }
            set
            {
                if ((this._Cong != value))
                {
                    this._Cong = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_GhiChu", DbType = "NVarChar(150)")]
        public string GhiChu
        {
            get
            {
                return this._GhiChu;
            }
            set
            {
                if ((this._GhiChu != value))
                {
                    this._GhiChu = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Dam", DbType = "Bit")]
        public System.Nullable<bool> Dam
        {
            get
            {
                return this._Dam;
            }
            set
            {
                if ((this._Dam != value))
                {
                    this._Dam = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Nghieng", DbType = "Bit")]
        public System.Nullable<bool> Nghieng
        {
            get
            {
                return this._Nghieng;
            }
            set
            {
                if ((this._Nghieng != value))
                {
                    this._Nghieng = value;
                }
            }
        }
    }
}
