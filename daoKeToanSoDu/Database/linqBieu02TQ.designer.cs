﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace daoKeToanSoDu.Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KeToanSoDu")]
	public partial class linqBieu02TQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqBieu02TQDataContext() : 
				base(global::daoKeToanSoDu.Properties.Settings.Default.KeToanSoDuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqBieu02TQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqBieu02TQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqBieu02TQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqBieu02TQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBieuBaoCao02TQ_KhoaMo")]
		public int sp_tblBieuBaoCao02TQ_KhoaMo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KhoaMo", DbType="Bit")] System.Nullable<bool> khoaMo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiKhoa", DbType="NVarChar(50)")] string nguoiKhoa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, khoaMo, nguoiKhoa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBieuBaoCao02TQDuLieu_TongHopDuLieu")]
		public int sp_tblBieuBaoCao02TQDuLieu_TongHopDuLieu([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBieuBaoCao", DbType="Int")] System.Nullable<int> iDBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBieuBaoCao, ngay);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBieuBaoCao02TQ_Them")]
		public ISingleResult<sp_tblBieuBaoCao02TQ_ThemResult> sp_tblBieuBaoCao02TQ_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiBaoCao", DbType="Int")] System.Nullable<int> loaiBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TieuDeBaoCao", DbType="NVarChar(250)")] string tieuDeBaoCao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ngay, maDonVi, loaiBaoCao, tieuDeBaoCao);
			return ((ISingleResult<sp_tblBieuBaoCao02TQ_ThemResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBieuBaoCao02TQ_ThongTin")]
		public ISingleResult<sp_tblBieuBaoCao02TQ_ThongTinResult> sp_tblBieuBaoCao02TQ_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ngay, maDonVi);
			return ((ISingleResult<sp_tblBieuBaoCao02TQ_ThongTinResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBieuBaoCao02TQDuLieu_BaoCao")]
		public ISingleResult<sp_tblBieuBaoCao02TQDuLieu_BaoCaoResult> sp_tblBieuBaoCao02TQDuLieu_BaoCao([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBieuBaoCao", DbType="Int")] System.Nullable<int> iDBieuBaoCao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBieuBaoCao);
			return ((ISingleResult<sp_tblBieuBaoCao02TQDuLieu_BaoCaoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBieuBaoCao02TQDuLieu_ThongTin")]
		public ISingleResult<sp_tblBieuBaoCao02TQDuLieu_ThongTinResult> sp_tblBieuBaoCao02TQDuLieu_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBieuBaoCao", DbType="Int")] System.Nullable<int> iDBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBieuBaoCao, maDonVi);
			return ((ISingleResult<sp_tblBieuBaoCao02TQDuLieu_ThongTinResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblBieuBaoCao02TQ_ThemResult
	{
		
		private System.Nullable<decimal> _IDThem02TQ;
		
		public sp_tblBieuBaoCao02TQ_ThemResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDThem02TQ", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> IDThem02TQ
		{
			get
			{
				return this._IDThem02TQ;
			}
			set
			{
				if ((this._IDThem02TQ != value))
				{
					this._IDThem02TQ = value;
				}
			}
		}
	}
	
	public partial class sp_tblBieuBaoCao02TQ_ThongTinResult
	{
		
		private int _ID;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private string _MaDonVi;
		
		private System.Nullable<int> _LoaiBaoCao;
		
		private string _TieuDeBaoCao;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private System.Nullable<bool> _DaKhoa;
		
		private System.Nullable<System.DateTime> _NgayKhoa;
		
		private string _NguoiKhoa;
		
		public sp_tblBieuBaoCao02TQ_ThongTinResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngay", DbType="Date")]
		public System.Nullable<System.DateTime> Ngay
		{
			get
			{
				return this._Ngay;
			}
			set
			{
				if ((this._Ngay != value))
				{
					this._Ngay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="NVarChar(10)")]
		public string MaDonVi
		{
			get
			{
				return this._MaDonVi;
			}
			set
			{
				if ((this._MaDonVi != value))
				{
					this._MaDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiBaoCao", DbType="Int")]
		public System.Nullable<int> LoaiBaoCao
		{
			get
			{
				return this._LoaiBaoCao;
			}
			set
			{
				if ((this._LoaiBaoCao != value))
				{
					this._LoaiBaoCao = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDeBaoCao", DbType="NVarChar(250)")]
		public string TieuDeBaoCao
		{
			get
			{
				return this._TieuDeBaoCao;
			}
			set
			{
				if ((this._TieuDeBaoCao != value))
				{
					this._TieuDeBaoCao = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this._NgayTao = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaKhoa", DbType="Bit")]
		public System.Nullable<bool> DaKhoa
		{
			get
			{
				return this._DaKhoa;
			}
			set
			{
				if ((this._DaKhoa != value))
				{
					this._DaKhoa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayKhoa", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayKhoa
		{
			get
			{
				return this._NgayKhoa;
			}
			set
			{
				if ((this._NgayKhoa != value))
				{
					this._NgayKhoa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiKhoa", DbType="NVarChar(50)")]
		public string NguoiKhoa
		{
			get
			{
				return this._NguoiKhoa;
			}
			set
			{
				if ((this._NguoiKhoa != value))
				{
					this._NguoiKhoa = value;
				}
			}
		}
	}
	
	public partial class sp_tblBieuBaoCao02TQDuLieu_BaoCaoResult
	{
		
		private string _STT;
		
		private string _MaDonVi;
		
		private string _TenDonVi;
		
		private System.Nullable<decimal> _TonDauNgay;
		
		private System.Nullable<decimal> _SoDaThuDichVu;
		
		private System.Nullable<decimal> _SoDaChiDichVu;
		
		private System.Nullable<decimal> _VayQuyKhac;
		
		private System.Nullable<decimal> _QuyKhacVay;
		
		private System.Nullable<decimal> _SoDaNhanTiepQuy;
		
		private System.Nullable<decimal> _SoDaNopQuy;
		
		private System.Nullable<decimal> _SoDuTienCuoiNgay;
		
		private System.Nullable<decimal> _DuKienCacKhoanChiDichVu;
		
		private System.Nullable<decimal> _HanMucLuuQuy;
		
		private System.Nullable<decimal> _SoTiepCanTiepHoacNopQuy;
		
		private System.Nullable<decimal> _STTsx;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		public sp_tblBieuBaoCao02TQDuLieu_BaoCaoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", DbType="NVarChar(5)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="NVarChar(10)")]
		public string MaDonVi
		{
			get
			{
				return this._MaDonVi;
			}
			set
			{
				if ((this._MaDonVi != value))
				{
					this._MaDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonVi", DbType="NVarChar(50)")]
		public string TenDonVi
		{
			get
			{
				return this._TenDonVi;
			}
			set
			{
				if ((this._TenDonVi != value))
				{
					this._TenDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TonDauNgay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> TonDauNgay
		{
			get
			{
				return this._TonDauNgay;
			}
			set
			{
				if ((this._TonDauNgay != value))
				{
					this._TonDauNgay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaThuDichVu", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaThuDichVu
		{
			get
			{
				return this._SoDaThuDichVu;
			}
			set
			{
				if ((this._SoDaThuDichVu != value))
				{
					this._SoDaThuDichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaChiDichVu", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaChiDichVu
		{
			get
			{
				return this._SoDaChiDichVu;
			}
			set
			{
				if ((this._SoDaChiDichVu != value))
				{
					this._SoDaChiDichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VayQuyKhac", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> VayQuyKhac
		{
			get
			{
				return this._VayQuyKhac;
			}
			set
			{
				if ((this._VayQuyKhac != value))
				{
					this._VayQuyKhac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuyKhacVay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> QuyKhacVay
		{
			get
			{
				return this._QuyKhacVay;
			}
			set
			{
				if ((this._QuyKhacVay != value))
				{
					this._QuyKhacVay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaNhanTiepQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaNhanTiepQuy
		{
			get
			{
				return this._SoDaNhanTiepQuy;
			}
			set
			{
				if ((this._SoDaNhanTiepQuy != value))
				{
					this._SoDaNhanTiepQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaNopQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaNopQuy
		{
			get
			{
				return this._SoDaNopQuy;
			}
			set
			{
				if ((this._SoDaNopQuy != value))
				{
					this._SoDaNopQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienCuoiNgay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienCuoiNgay
		{
			get
			{
				return this._SoDuTienCuoiNgay;
			}
			set
			{
				if ((this._SoDuTienCuoiNgay != value))
				{
					this._SoDuTienCuoiNgay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DuKienCacKhoanChiDichVu", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DuKienCacKhoanChiDichVu
		{
			get
			{
				return this._DuKienCacKhoanChiDichVu;
			}
			set
			{
				if ((this._DuKienCacKhoanChiDichVu != value))
				{
					this._DuKienCacKhoanChiDichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HanMucLuuQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> HanMucLuuQuy
		{
			get
			{
				return this._HanMucLuuQuy;
			}
			set
			{
				if ((this._HanMucLuuQuy != value))
				{
					this._HanMucLuuQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTiepCanTiepHoacNopQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTiepCanTiepHoacNopQuy
		{
			get
			{
				return this._SoTiepCanTiepHoacNopQuy;
			}
			set
			{
				if ((this._SoTiepCanTiepHoacNopQuy != value))
				{
					this._SoTiepCanTiepHoacNopQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STTsx", DbType="Decimal(5,2)")]
		public System.Nullable<decimal> STTsx
		{
			get
			{
				return this._STTsx;
			}
			set
			{
				if ((this._STTsx != value))
				{
					this._STTsx = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InDam", DbType="Bit")]
		public System.Nullable<bool> InDam
		{
			get
			{
				return this._InDam;
			}
			set
			{
				if ((this._InDam != value))
				{
					this._InDam = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InNghieng", DbType="Bit")]
		public System.Nullable<bool> InNghieng
		{
			get
			{
				return this._InNghieng;
			}
			set
			{
				if ((this._InNghieng != value))
				{
					this._InNghieng = value;
				}
			}
		}
	}
	
	public partial class sp_tblBieuBaoCao02TQDuLieu_ThongTinResult
	{
		
		private System.Nullable<int> _IDBieuBaoCao;
		
		private string _STT;
		
		private string _MaDonVi;
		
		private string _TenDonVi;
		
		private System.Nullable<decimal> _TonDauNgay;
		
		private System.Nullable<decimal> _SoDaThuDichVu;
		
		private System.Nullable<decimal> _SoDaChiDichVu;
		
		private System.Nullable<decimal> _VayQuyKhac;
		
		private System.Nullable<decimal> _QuyKhacVay;
		
		private System.Nullable<decimal> _SoDaNhanTiepQuy;
		
		private System.Nullable<decimal> _SoDaNopQuy;
		
		private System.Nullable<decimal> _SoDuTienCuoiNgay;
		
		private System.Nullable<decimal> _DuKienCacKhoanChiDichVu;
		
		private System.Nullable<decimal> _HanMucLuuQuy;
		
		private System.Nullable<decimal> _SoTiepCanTiepHoacNopQuy;
		
		private System.Nullable<decimal> _STTsx;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblBieuBaoCao02TQDuLieu_ThongTinResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBieuBaoCao", DbType="Int")]
		public System.Nullable<int> IDBieuBaoCao
		{
			get
			{
				return this._IDBieuBaoCao;
			}
			set
			{
				if ((this._IDBieuBaoCao != value))
				{
					this._IDBieuBaoCao = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", DbType="NVarChar(5)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="NVarChar(10)")]
		public string MaDonVi
		{
			get
			{
				return this._MaDonVi;
			}
			set
			{
				if ((this._MaDonVi != value))
				{
					this._MaDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonVi", DbType="NVarChar(50)")]
		public string TenDonVi
		{
			get
			{
				return this._TenDonVi;
			}
			set
			{
				if ((this._TenDonVi != value))
				{
					this._TenDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TonDauNgay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> TonDauNgay
		{
			get
			{
				return this._TonDauNgay;
			}
			set
			{
				if ((this._TonDauNgay != value))
				{
					this._TonDauNgay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaThuDichVu", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaThuDichVu
		{
			get
			{
				return this._SoDaThuDichVu;
			}
			set
			{
				if ((this._SoDaThuDichVu != value))
				{
					this._SoDaThuDichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaChiDichVu", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaChiDichVu
		{
			get
			{
				return this._SoDaChiDichVu;
			}
			set
			{
				if ((this._SoDaChiDichVu != value))
				{
					this._SoDaChiDichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VayQuyKhac", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> VayQuyKhac
		{
			get
			{
				return this._VayQuyKhac;
			}
			set
			{
				if ((this._VayQuyKhac != value))
				{
					this._VayQuyKhac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuyKhacVay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> QuyKhacVay
		{
			get
			{
				return this._QuyKhacVay;
			}
			set
			{
				if ((this._QuyKhacVay != value))
				{
					this._QuyKhacVay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaNhanTiepQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaNhanTiepQuy
		{
			get
			{
				return this._SoDaNhanTiepQuy;
			}
			set
			{
				if ((this._SoDaNhanTiepQuy != value))
				{
					this._SoDaNhanTiepQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDaNopQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDaNopQuy
		{
			get
			{
				return this._SoDaNopQuy;
			}
			set
			{
				if ((this._SoDaNopQuy != value))
				{
					this._SoDaNopQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienCuoiNgay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienCuoiNgay
		{
			get
			{
				return this._SoDuTienCuoiNgay;
			}
			set
			{
				if ((this._SoDuTienCuoiNgay != value))
				{
					this._SoDuTienCuoiNgay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DuKienCacKhoanChiDichVu", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DuKienCacKhoanChiDichVu
		{
			get
			{
				return this._DuKienCacKhoanChiDichVu;
			}
			set
			{
				if ((this._DuKienCacKhoanChiDichVu != value))
				{
					this._DuKienCacKhoanChiDichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HanMucLuuQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> HanMucLuuQuy
		{
			get
			{
				return this._HanMucLuuQuy;
			}
			set
			{
				if ((this._HanMucLuuQuy != value))
				{
					this._HanMucLuuQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTiepCanTiepHoacNopQuy", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTiepCanTiepHoacNopQuy
		{
			get
			{
				return this._SoTiepCanTiepHoacNopQuy;
			}
			set
			{
				if ((this._SoTiepCanTiepHoacNopQuy != value))
				{
					this._SoTiepCanTiepHoacNopQuy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STTsx", DbType="Decimal(5,2)")]
		public System.Nullable<decimal> STTsx
		{
			get
			{
				return this._STTsx;
			}
			set
			{
				if ((this._STTsx != value))
				{
					this._STTsx = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InDam", DbType="Bit")]
		public System.Nullable<bool> InDam
		{
			get
			{
				return this._InDam;
			}
			set
			{
				if ((this._InDam != value))
				{
					this._InDam = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InNghieng", DbType="Bit")]
		public System.Nullable<bool> InNghieng
		{
			get
			{
				return this._InNghieng;
			}
			set
			{
				if ((this._InNghieng != value))
				{
					this._InNghieng = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayHeThong", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayHeThong
		{
			get
			{
				return this._NgayHeThong;
			}
			set
			{
				if ((this._NgayHeThong != value))
				{
					this._NgayHeThong = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
