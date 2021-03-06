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
	public partial class linqSoDuTGNHCuoiNgayDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqSoDuTGNHCuoiNgayDataContext() : 
				base(global::daoKeToanSoDu.Properties.Settings.Default.KeToanSoDuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoDuTGNHCuoiNgayDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoDuTGNHCuoiNgayDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoDuTGNHCuoiNgayDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoDuTGNHCuoiNgayDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoDuTGNHCuoiNgay_DanhSachNhap")]
		public ISingleResult<sp_tblSoDuTGNHCuoiNgay_DanhSachNhapResult> sp_tblSoDuTGNHCuoiNgay_DanhSachNhap([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, tuNgay, denNgay);
			return ((ISingleResult<sp_tblSoDuTGNHCuoiNgay_DanhSachNhapResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoDuTGNHCuoiNgay_ThongTin")]
		public ISingleResult<sp_tblSoDuTGNHCuoiNgay_ThongTinResult> sp_tblSoDuTGNHCuoiNgay_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKeToanNgay", DbType="NVarChar(20)")] string maKeToanNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKeToanNgay);
			return ((ISingleResult<sp_tblSoDuTGNHCuoiNgay_ThongTinResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoDuTGNHCuoiNgay_KhoaMo")]
		public int sp_tblSoDuTGNHCuoiNgay_KhoaMo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKeToanNgay", DbType="NVarChar(20)")] string maKeToanNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Khoa", DbType="Bit")] System.Nullable<bool> khoa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiKhoa", DbType="NVarChar(20)")] string nguoiKhoa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKeToanNgay, khoa, nguoiKhoa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoDuTGNHCuoiNgay_ThemSua")]
		public int sp_tblSoDuTGNHCuoiNgay_ThemSua([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKeToanNgay", DbType="NVarChar(20)")] string maKeToanNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TCBCTapTrung", DbType="Decimal(22,0)")] System.Nullable<decimal> tCBCTapTrung, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TCBCThanhToanTaiDonVi", DbType="Decimal(22,0)")] System.Nullable<decimal> tCBCThanhToanTaiDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TKBD", DbType="Decimal(22,0)")] System.Nullable<decimal> tKBD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KinhDoanh", DbType="Decimal(22,0)")] System.Nullable<decimal> kinhDoanh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cong", DbType="Decimal(25,0)")] System.Nullable<decimal> cong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GhiChu", DbType="NVarChar(250)")] string ghiChu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKeToanNgay, maBuuCuc, ngay, tCBCTapTrung, tCBCThanhToanTaiDonVi, tKBD, kinhDoanh, cong, ghiChu);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoDuTGNHCuoiNgay_DanhSachDonVi")]
		public ISingleResult<sp_tblSoDuTGNHCuoiNgay_DanhSachDonViResult> sp_tblSoDuTGNHCuoiNgay_DanhSachDonVi([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maDonVi, ngay);
			return ((ISingleResult<sp_tblSoDuTGNHCuoiNgay_DanhSachDonViResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblSoDuTGNHCuoiNgay_DanhSachNhapResult
	{
		
		private System.Nullable<long> _STT;
		
		private string _MaKeToanNgay;
		
		private string _MaBuuCuc;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTCBC;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTKBD;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTCBC_DonVi;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTKBD_DonVi;
		
		private System.Nullable<decimal> _TCBCTapTrung;
		
		private System.Nullable<decimal> _TCBCThanhToanTaiDonVi;
		
		private System.Nullable<decimal> _TKBD;
		
		private System.Nullable<decimal> _KinhDoanh;
		
		private System.Nullable<decimal> _Cong;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _Khoa;
		
		public sp_tblSoDuTGNHCuoiNgay_DanhSachNhapResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", DbType="BigInt")]
		public System.Nullable<long> STT
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKeToanNgay", DbType="NVarChar(20)")]
		public string MaKeToanNgay
		{
			get
			{
				return this._MaKeToanNgay;
			}
			set
			{
				if ((this._MaKeToanNgay != value))
				{
					this._MaKeToanNgay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBuuCuc", DbType="NVarChar(10)")]
		public string MaBuuCuc
		{
			get
			{
				return this._MaBuuCuc;
			}
			set
			{
				if ((this._MaBuuCuc != value))
				{
					this._MaBuuCuc = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTCBC", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DinhMucLuuQuyTCBC
		{
			get
			{
				return this._DinhMucLuuQuyTCBC;
			}
			set
			{
				if ((this._DinhMucLuuQuyTCBC != value))
				{
					this._DinhMucLuuQuyTCBC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTKBD", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DinhMucLuuQuyTKBD
		{
			get
			{
				return this._DinhMucLuuQuyTKBD;
			}
			set
			{
				if ((this._DinhMucLuuQuyTKBD != value))
				{
					this._DinhMucLuuQuyTKBD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTCBC_DonVi", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTKBD_DonVi", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCBCTapTrung", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCBCThanhToanTaiDonVi", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKBD", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KinhDoanh", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cong", DbType="Decimal(25,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Khoa", DbType="Bit")]
		public System.Nullable<bool> Khoa
		{
			get
			{
				return this._Khoa;
			}
			set
			{
				if ((this._Khoa != value))
				{
					this._Khoa = value;
				}
			}
		}
	}
	
	public partial class sp_tblSoDuTGNHCuoiNgay_ThongTinResult
	{
		
		private string _MaKeToanNgay;
		
		private string _MaBuuCuc;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private System.Nullable<decimal> _TCBCTapTrung;
		
		private System.Nullable<decimal> _TCBCThanhToanTaiDonVi;
		
		private System.Nullable<decimal> _TKBD;
		
		private System.Nullable<decimal> _KinhDoanh;
		
		private System.Nullable<decimal> _Cong;
		
		private string _GhiChu;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private System.Nullable<System.DateTime> _NgaySua;
		
		private System.Nullable<bool> _Khoa;
		
		private string _NguoiKhoa;
		
		private System.Nullable<System.DateTime> _NgayKhoa;
		
		public sp_tblSoDuTGNHCuoiNgay_ThongTinResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKeToanNgay", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MaKeToanNgay
		{
			get
			{
				return this._MaKeToanNgay;
			}
			set
			{
				if ((this._MaKeToanNgay != value))
				{
					this._MaKeToanNgay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBuuCuc", DbType="NVarChar(10)")]
		public string MaBuuCuc
		{
			get
			{
				return this._MaBuuCuc;
			}
			set
			{
				if ((this._MaBuuCuc != value))
				{
					this._MaBuuCuc = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCBCTapTrung", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCBCThanhToanTaiDonVi", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKBD", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KinhDoanh", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cong", DbType="Decimal(25,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySua", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySua
		{
			get
			{
				return this._NgaySua;
			}
			set
			{
				if ((this._NgaySua != value))
				{
					this._NgaySua = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Khoa", DbType="Bit")]
		public System.Nullable<bool> Khoa
		{
			get
			{
				return this._Khoa;
			}
			set
			{
				if ((this._Khoa != value))
				{
					this._Khoa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiKhoa", DbType="NVarChar(20)")]
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
	}
	
	public partial class sp_tblSoDuTGNHCuoiNgay_DanhSachDonViResult
	{
		
		private System.Nullable<long> _STT;
		
		private string _MaKeToanNgay;
		
		private string _MaBuuCuc;
		
		private string _TenDonVi;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTCBC;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTKBD;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTCBC_DonVi;
		
		private System.Nullable<decimal> _DinhMucLuuQuyTKBD_DonVi;
		
		private System.Nullable<decimal> _TCBCTapTrung;
		
		private System.Nullable<decimal> _TCBCThanhToanTaiDonVi;
		
		private System.Nullable<decimal> _TKBD;
		
		private System.Nullable<decimal> _KinhDoanh;
		
		private System.Nullable<decimal> _Cong;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _Khoa;
		
		public sp_tblSoDuTGNHCuoiNgay_DanhSachDonViResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", DbType="BigInt")]
		public System.Nullable<long> STT
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKeToanNgay", DbType="NVarChar(20)")]
		public string MaKeToanNgay
		{
			get
			{
				return this._MaKeToanNgay;
			}
			set
			{
				if ((this._MaKeToanNgay != value))
				{
					this._MaKeToanNgay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBuuCuc", DbType="NVarChar(10)")]
		public string MaBuuCuc
		{
			get
			{
				return this._MaBuuCuc;
			}
			set
			{
				if ((this._MaBuuCuc != value))
				{
					this._MaBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonVi", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTCBC", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DinhMucLuuQuyTCBC
		{
			get
			{
				return this._DinhMucLuuQuyTCBC;
			}
			set
			{
				if ((this._DinhMucLuuQuyTCBC != value))
				{
					this._DinhMucLuuQuyTCBC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTKBD", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DinhMucLuuQuyTKBD
		{
			get
			{
				return this._DinhMucLuuQuyTKBD;
			}
			set
			{
				if ((this._DinhMucLuuQuyTKBD != value))
				{
					this._DinhMucLuuQuyTKBD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTCBC_DonVi", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhMucLuuQuyTKBD_DonVi", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCBCTapTrung", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCBCThanhToanTaiDonVi", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKBD", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KinhDoanh", DbType="Decimal(22,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cong", DbType="Decimal(25,0)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Khoa", DbType="Bit")]
		public System.Nullable<bool> Khoa
		{
			get
			{
				return this._Khoa;
			}
			set
			{
				if ((this._Khoa != value))
				{
					this._Khoa = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
