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
	public partial class linqChiTieuDanSuatDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqChiTieuDanSuatDataContext() : 
				base(global::daoSLBC.Properties.Settings.Default.SoLieuBaoCaoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDanSuatDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDanSuatDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDanSuatDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDanSuatDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatCong_DanhSach")]
		public ISingleResult<sp_tblChiTieuDanSuatCong_DanhSachResult> sp_tblChiTieuDanSuatCong_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu);
			return ((ISingleResult<sp_tblChiTieuDanSuatCong_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatTru_Them")]
		public int sp_tblChiTieuDanSuatTru_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieuDanSuat", DbType="Int")] System.Nullable<int> iDChiTieuDanSuat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaChiTieuDanSuat", DbType="NVarChar(20)")] string maChiTieuDanSuat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HeSo", DbType="Decimal(16,3)")] System.Nullable<decimal> heSo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu, iDChiTieuDanSuat, maChiTieuDanSuat, heSo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatCong_Them")]
		public int sp_tblChiTieuDanSuatCong_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieuDanSuat", DbType="Int")] System.Nullable<int> iDChiTieuDanSuat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaChiTieuDanSuat", DbType="NVarChar(20)")] string maChiTieuDanSuat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HeSo", DbType="Decimal(16,3)")] System.Nullable<decimal> heSo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu, iDChiTieuDanSuat, maChiTieuDanSuat, heSo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatNhan_DanhSach")]
		public ISingleResult<sp_tblChiTieuDanSuatNhan_DanhSachResult> sp_tblChiTieuDanSuatNhan_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu);
			return ((ISingleResult<sp_tblChiTieuDanSuatNhan_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatNhan_Them")]
		public int sp_tblChiTieuDanSuatNhan_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieuDanSuat", DbType="Int")] System.Nullable<int> iDChiTieuDanSuat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaChiTieuDanSuat", DbType="NVarChar(20)")] string maChiTieuDanSuat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HeSo", DbType="Decimal(16,3)")] System.Nullable<decimal> heSo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu, iDChiTieuDanSuat, maChiTieuDanSuat, heSo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatTru_DanhSach")]
		public ISingleResult<sp_tblChiTieuDanSuatTru_DanhSachResult> sp_tblChiTieuDanSuatTru_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu);
			return ((ISingleResult<sp_tblChiTieuDanSuatTru_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatNhan_Xoa")]
		public int sp_tblChiTieuDanSuatNhan_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaChiTieuDanSuat", DbType="NVarChar(20)")] string maChiTieuDanSuat)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu, maChiTieuDanSuat);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatTru_Xoa")]
		public int sp_tblChiTieuDanSuatTru_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaChiTieuDanSuat", DbType="NVarChar(20)")] string maChiTieuDanSuat)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu, maChiTieuDanSuat);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuDanSuatCong_Xoa")]
		public int sp_tblChiTieuDanSuatCong_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDmauBieu", DbType="Int")] System.Nullable<int> iDmauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaChiTieuDanSuat", DbType="NVarChar(20)")] string maChiTieuDanSuat)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDmauBieu, iDChiTieu, maChiTieuDanSuat);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblChiTieuDanSuatCong_DanhSachResult
	{
		
		private System.Nullable<long> _STT;
		
		private System.Nullable<int> _IDMauBieu;
		
		private System.Nullable<int> _IDChiTieu;
		
		private System.Nullable<int> _IDChiTieuDanSuat;
		
		private string _MaChiTieuDanSuat;
		
		private string _TenChiTieuDanSuat;
		
		private System.Nullable<decimal> _HeSo;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblChiTieuDanSuatCong_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieuDanSuat", DbType="Int")]
		public System.Nullable<int> IDChiTieuDanSuat
		{
			get
			{
				return this._IDChiTieuDanSuat;
			}
			set
			{
				if ((this._IDChiTieuDanSuat != value))
				{
					this._IDChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChiTieuDanSuat", DbType="NVarChar(20)")]
		public string MaChiTieuDanSuat
		{
			get
			{
				return this._MaChiTieuDanSuat;
			}
			set
			{
				if ((this._MaChiTieuDanSuat != value))
				{
					this._MaChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChiTieuDanSuat", DbType="NVarChar(150)")]
		public string TenChiTieuDanSuat
		{
			get
			{
				return this._TenChiTieuDanSuat;
			}
			set
			{
				if ((this._TenChiTieuDanSuat != value))
				{
					this._TenChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeSo", DbType="Decimal(16,3)")]
		public System.Nullable<decimal> HeSo
		{
			get
			{
				return this._HeSo;
			}
			set
			{
				if ((this._HeSo != value))
				{
					this._HeSo = value;
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
	
	public partial class sp_tblChiTieuDanSuatNhan_DanhSachResult
	{
		
		private System.Nullable<long> _STT;
		
		private System.Nullable<int> _IDMauBieu;
		
		private System.Nullable<int> _IDChiTieu;
		
		private System.Nullable<int> _IDChiTieuDanSuat;
		
		private string _MaChiTieuDanSuat;
		
		private string _TenChiTieuDanSuat;
		
		private System.Nullable<decimal> _HeSo;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblChiTieuDanSuatNhan_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieuDanSuat", DbType="Int")]
		public System.Nullable<int> IDChiTieuDanSuat
		{
			get
			{
				return this._IDChiTieuDanSuat;
			}
			set
			{
				if ((this._IDChiTieuDanSuat != value))
				{
					this._IDChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChiTieuDanSuat", DbType="NVarChar(20)")]
		public string MaChiTieuDanSuat
		{
			get
			{
				return this._MaChiTieuDanSuat;
			}
			set
			{
				if ((this._MaChiTieuDanSuat != value))
				{
					this._MaChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChiTieuDanSuat", DbType="NVarChar(150)")]
		public string TenChiTieuDanSuat
		{
			get
			{
				return this._TenChiTieuDanSuat;
			}
			set
			{
				if ((this._TenChiTieuDanSuat != value))
				{
					this._TenChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeSo", DbType="Decimal(16,3)")]
		public System.Nullable<decimal> HeSo
		{
			get
			{
				return this._HeSo;
			}
			set
			{
				if ((this._HeSo != value))
				{
					this._HeSo = value;
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
	
	public partial class sp_tblChiTieuDanSuatTru_DanhSachResult
	{
		
		private System.Nullable<long> _STT;
		
		private System.Nullable<int> _IDMauBieu;
		
		private System.Nullable<int> _IDChiTieu;
		
		private System.Nullable<int> _IDChiTieuDanSuat;
		
		private string _MaChiTieuDanSuat;
		
		private string _TenChiTieuDanSuat;
		
		private System.Nullable<decimal> _HeSo;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblChiTieuDanSuatTru_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieuDanSuat", DbType="Int")]
		public System.Nullable<int> IDChiTieuDanSuat
		{
			get
			{
				return this._IDChiTieuDanSuat;
			}
			set
			{
				if ((this._IDChiTieuDanSuat != value))
				{
					this._IDChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChiTieuDanSuat", DbType="NVarChar(20)")]
		public string MaChiTieuDanSuat
		{
			get
			{
				return this._MaChiTieuDanSuat;
			}
			set
			{
				if ((this._MaChiTieuDanSuat != value))
				{
					this._MaChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChiTieuDanSuat", DbType="NVarChar(150)")]
		public string TenChiTieuDanSuat
		{
			get
			{
				return this._TenChiTieuDanSuat;
			}
			set
			{
				if ((this._TenChiTieuDanSuat != value))
				{
					this._TenChiTieuDanSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeSo", DbType="Decimal(16,3)")]
		public System.Nullable<decimal> HeSo
		{
			get
			{
				return this._HeSo;
			}
			set
			{
				if ((this._HeSo != value))
				{
					this._HeSo = value;
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
