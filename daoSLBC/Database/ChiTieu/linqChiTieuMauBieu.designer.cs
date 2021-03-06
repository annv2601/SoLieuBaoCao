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
	public partial class linqChiTieuMauBieuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqChiTieuMauBieuDataContext() : 
				base(global::daoSLBC.Properties.Settings.Default.SoLieuBaoCaoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMauBieuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMauBieuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMauBieuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuMauBieuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuTheoMauBieu_ThongTin")]
		public ISingleResult<sp_tblChiTieuTheoMauBieu_ThongTinResult> sp_tblChiTieuTheoMauBieu_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu);
			return ((ISingleResult<sp_tblChiTieuTheoMauBieu_ThongTinResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuTheoMauBieu_ThemSua")]
		public int sp_tblChiTieuTheoMauBieu_ThemSua([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ThuTu", DbType="NVarChar(10)")] string thuTu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="InDam", DbType="Bit")] System.Nullable<bool> inDam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="InNghieng", DbType="Bit")] System.Nullable<bool> inNghieng, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="STTsx", DbType="Decimal(18,3)")] System.Nullable<decimal> sTTsx, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NhapTay", DbType="Bit")] System.Nullable<bool> nhapTay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LayTuDong", DbType="Bit")] System.Nullable<bool> layTuDong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(50)")] string nguoiTao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, thuTu, inDam, inNghieng, sTTsx, nhapTay, layTuDong, nguoiTao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuTheoMauBieu_DanhSach")]
		public ISingleResult<sp_tblChiTieuTheoMauBieu_DanhSachResult> sp_tblChiTieuTheoMauBieu_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu);
			return ((ISingleResult<sp_tblChiTieuTheoMauBieu_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuTheoMauBieu_KhoiTao")]
		public int sp_tblChiTieuTheoMauBieu_KhoiTao([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(50)")] string nguoiTao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu, nguoiTao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuTheoMauBieu_Xoa")]
		public int sp_tblChiTieuTheoMauBieu_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMauBieu, iDChiTieu);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblChiTieuTheoMauBieu_ThongTinResult
	{
		
		private System.Nullable<int> _IDMauBieu;
		
		private System.Nullable<int> _IDChiTieu;
		
		private string _ThuTu;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		private System.Nullable<decimal> _STTsx;
		
		private System.Nullable<bool> _NhapTay;
		
		private System.Nullable<bool> _LayTuDong;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private string _NguoiTao;
		
		public sp_tblChiTieuTheoMauBieu_ThongTinResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThuTu", DbType="NVarChar(10)")]
		public string ThuTu
		{
			get
			{
				return this._ThuTu;
			}
			set
			{
				if ((this._ThuTu != value))
				{
					this._ThuTu = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STTsx", DbType="Decimal(18,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhapTay", DbType="Bit")]
		public System.Nullable<bool> NhapTay
		{
			get
			{
				return this._NhapTay;
			}
			set
			{
				if ((this._NhapTay != value))
				{
					this._NhapTay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LayTuDong", DbType="Bit")]
		public System.Nullable<bool> LayTuDong
		{
			get
			{
				return this._LayTuDong;
			}
			set
			{
				if ((this._LayTuDong != value))
				{
					this._LayTuDong = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiTao", DbType="NVarChar(50)")]
		public string NguoiTao
		{
			get
			{
				return this._NguoiTao;
			}
			set
			{
				if ((this._NguoiTao != value))
				{
					this._NguoiTao = value;
				}
			}
		}
	}
	
	public partial class sp_tblChiTieuTheoMauBieu_DanhSachResult
	{
		
		private System.Nullable<int> _IDMauBieu;
		
		private System.Nullable<int> _IDChiTieu;
		
		private string _Ma;
		
		private string _TenChiTieu;
		
		private string _ThuTu;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		private System.Nullable<decimal> _STTsx;
		
		private System.Nullable<bool> _NhapTay;
		
		private System.Nullable<bool> _LayTuDong;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private string _NguoiTao;
		
		public sp_tblChiTieuTheoMauBieu_DanhSachResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ma", DbType="NVarChar(20)")]
		public string Ma
		{
			get
			{
				return this._Ma;
			}
			set
			{
				if ((this._Ma != value))
				{
					this._Ma = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChiTieu", DbType="NVarChar(150)")]
		public string TenChiTieu
		{
			get
			{
				return this._TenChiTieu;
			}
			set
			{
				if ((this._TenChiTieu != value))
				{
					this._TenChiTieu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThuTu", DbType="NVarChar(10)")]
		public string ThuTu
		{
			get
			{
				return this._ThuTu;
			}
			set
			{
				if ((this._ThuTu != value))
				{
					this._ThuTu = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STTsx", DbType="Decimal(18,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhapTay", DbType="Bit")]
		public System.Nullable<bool> NhapTay
		{
			get
			{
				return this._NhapTay;
			}
			set
			{
				if ((this._NhapTay != value))
				{
					this._NhapTay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LayTuDong", DbType="Bit")]
		public System.Nullable<bool> LayTuDong
		{
			get
			{
				return this._LayTuDong;
			}
			set
			{
				if ((this._LayTuDong != value))
				{
					this._LayTuDong = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiTao", DbType="NVarChar(50)")]
		public string NguoiTao
		{
			get
			{
				return this._NguoiTao;
			}
			set
			{
				if ((this._NguoiTao != value))
				{
					this._NguoiTao = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
