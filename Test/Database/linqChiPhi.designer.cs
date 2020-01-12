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

namespace Test.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SoLieuBCOL")]
	public partial class linqChiPhiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqChiPhiDataContext() : 
				base(global::Test.Properties.Settings.Default.SoLieuBCOLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiPhiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiPhiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiPhiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiPhiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiPhi_Them")]
		public int sp_tblChiPhi_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ma", DbType="NVarChar(20)")] string ma, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ten", DbType="NVarChar(150)")] string ten, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DonViTinh", DbType="NVarChar(30)")] string donViTinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PhatSinhThuongXuyen", DbType="Float")] System.Nullable<double> phatSinhThuongXuyen, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PhatSinhPhanBo", DbType="Float")] System.Nullable<double> phatSinhPhanBo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TongCong", DbType="Float")] System.Nullable<double> tongCong)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi, ma, ten, donViTinh, phatSinhThuongXuyen, phatSinhPhanBo, tongCong);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiPhi_Xoa")]
		public int sp_tblChiPhi_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiPhi_ThongTin")]
		public ISingleResult<sp_tblChiPhi_ThongTinResult> sp_tblChiPhi_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ma", DbType="NVarChar(20)")] string ma)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi, ma);
			return ((ISingleResult<sp_tblChiPhi_ThongTinResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblChiPhi_ThongTinResult
	{
		
		private string _Ma;
		
		private string _Ten;
		
		private string _DonViTinh;
		
		private System.Nullable<double> _PhatSinhThuongXuyen;
		
		private System.Nullable<double> _PhatSinhPhanBo;
		
		private System.Nullable<double> _TongCong;
		
		private System.Nullable<short> _Thang;
		
		private System.Nullable<int> _Nam;
		
		private string _MaDonVi;
		
		public sp_tblChiPhi_ThongTinResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(150)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonViTinh", DbType="NVarChar(30)")]
		public string DonViTinh
		{
			get
			{
				return this._DonViTinh;
			}
			set
			{
				if ((this._DonViTinh != value))
				{
					this._DonViTinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhatSinhThuongXuyen", DbType="Float")]
		public System.Nullable<double> PhatSinhThuongXuyen
		{
			get
			{
				return this._PhatSinhThuongXuyen;
			}
			set
			{
				if ((this._PhatSinhThuongXuyen != value))
				{
					this._PhatSinhThuongXuyen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhatSinhPhanBo", DbType="Float")]
		public System.Nullable<double> PhatSinhPhanBo
		{
			get
			{
				return this._PhatSinhPhanBo;
			}
			set
			{
				if ((this._PhatSinhPhanBo != value))
				{
					this._PhatSinhPhanBo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongCong", DbType="Float")]
		public System.Nullable<double> TongCong
		{
			get
			{
				return this._TongCong;
			}
			set
			{
				if ((this._TongCong != value))
				{
					this._TongCong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thang", DbType="SmallInt")]
		public System.Nullable<short> Thang
		{
			get
			{
				return this._Thang;
			}
			set
			{
				if ((this._Thang != value))
				{
					this._Thang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nam", DbType="Int")]
		public System.Nullable<int> Nam
		{
			get
			{
				return this._Nam;
			}
			set
			{
				if ((this._Nam != value))
				{
					this._Nam = value;
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
	}
}
#pragma warning restore 1591