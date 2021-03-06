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

namespace daoSLBC.Database.ChiTieu
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SoLieuBaoCao")]
	public partial class linqChiTieuMSCTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqChiTieuMSCTDataContext() : 
				base(global::daoSLBC.Properties.Settings.Default.SoLieuBaoCaoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMSCTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMSCTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMSCTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMSCTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuGhepMSCTCong_DanhSach")]
		public ISingleResult<sp_tblChiTieuGhepMSCTCong_DanhSachResult> sp_tblChiTieuGhepMSCTCong_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiSoLieu", DbType="NVarChar(20)")] string loaiSoLieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, loaiSoLieu);
			return ((ISingleResult<sp_tblChiTieuGhepMSCTCong_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuGhepMSCTTru_Xoa")]
		public int sp_tblChiTieuGhepMSCTTru_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MSCT", DbType="NVarChar(20)")] string mSCT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiSoLieu", DbType="NVarChar(20)")] string loaiSoLieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, mSCT, loaiSoLieu);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuGhepMSCTCong_Them")]
		public int sp_tblChiTieuGhepMSCTCong_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MSCT", DbType="NVarChar(20)")] string mSCT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiSoLieu", DbType="NVarChar(20)")] string loaiSoLieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, mSCT, loaiSoLieu);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuGhepMSCTCong_Xoa")]
		public int sp_tblChiTieuGhepMSCTCong_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MSCT", DbType="NVarChar(20)")] string mSCT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiSoLieu", DbType="NVarChar(20)")] string loaiSoLieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, mSCT, loaiSoLieu);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuGhepMSCTTru_DanhSach")]
		public ISingleResult<sp_tblChiTieuGhepMSCTTru_DanhSachResult> sp_tblChiTieuGhepMSCTTru_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiSoLieu", DbType="NVarChar(20)")] string loaiSoLieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, loaiSoLieu);
			return ((ISingleResult<sp_tblChiTieuGhepMSCTTru_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuGhepMSCTTru_Them")]
		public int sp_tblChiTieuGhepMSCTTru_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MSCT", DbType="NVarChar(20)")] string mSCT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiSoLieu", DbType="NVarChar(20)")] string loaiSoLieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, mSCT, loaiSoLieu);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblChiTieuGhepMSCTCong_DanhSachResult
	{
		
		private System.Nullable<long> _STT;
		
		private System.Nullable<int> _IDMauBieu;
		
		private System.Nullable<int> _IDChiTieu;
		
		private string _MSCT;
		
		private string _TenMSCT;
		
		private string _LoaiSoLieu;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblChiTieuGhepMSCTCong_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMauBieu", DbType="Int")]
		public System.Nullable<int> IDMauBieu
		{
			get
			{
				return this._IDMauBieu;
			}
			set
			{
				if ((this._IDMauBieu != value))
				{
					this._IDMauBieu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieu", DbType="Int")]
		public System.Nullable<int> IDChiTieu
		{
			get
			{
				return this._IDChiTieu;
			}
			set
			{
				if ((this._IDChiTieu != value))
				{
					this._IDChiTieu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSCT", DbType="NVarChar(20)")]
		public string MSCT
		{
			get
			{
				return this._MSCT;
			}
			set
			{
				if ((this._MSCT != value))
				{
					this._MSCT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMSCT", DbType="NVarChar(80)")]
		public string TenMSCT
		{
			get
			{
				return this._TenMSCT;
			}
			set
			{
				if ((this._TenMSCT != value))
				{
					this._TenMSCT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiSoLieu", DbType="NVarChar(20)")]
		public string LoaiSoLieu
		{
			get
			{
				return this._LoaiSoLieu;
			}
			set
			{
				if ((this._LoaiSoLieu != value))
				{
					this._LoaiSoLieu = value;
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
	
	public partial class sp_tblChiTieuGhepMSCTTru_DanhSachResult
	{
		
		private System.Nullable<long> _STT;
		
		private System.Nullable<int> _IDMauBieu;
		
		private System.Nullable<int> _IDChiTieu;
		
		private string _MSCT;
		
		private string _TenMSCT;
		
		private string _LoaiSoLieu;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblChiTieuGhepMSCTTru_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMauBieu", DbType="Int")]
		public System.Nullable<int> IDMauBieu
		{
			get
			{
				return this._IDMauBieu;
			}
			set
			{
				if ((this._IDMauBieu != value))
				{
					this._IDMauBieu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieu", DbType="Int")]
		public System.Nullable<int> IDChiTieu
		{
			get
			{
				return this._IDChiTieu;
			}
			set
			{
				if ((this._IDChiTieu != value))
				{
					this._IDChiTieu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSCT", DbType="NVarChar(20)")]
		public string MSCT
		{
			get
			{
				return this._MSCT;
			}
			set
			{
				if ((this._MSCT != value))
				{
					this._MSCT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMSCT", DbType="NVarChar(80)")]
		public string TenMSCT
		{
			get
			{
				return this._TenMSCT;
			}
			set
			{
				if ((this._TenMSCT != value))
				{
					this._TenMSCT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiSoLieu", DbType="NVarChar(20)")]
		public string LoaiSoLieu
		{
			get
			{
				return this._LoaiSoLieu;
			}
			set
			{
				if ((this._LoaiSoLieu != value))
				{
					this._LoaiSoLieu = value;
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
