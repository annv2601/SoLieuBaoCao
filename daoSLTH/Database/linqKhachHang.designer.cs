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

namespace daoSLTH.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SoLieuTongHop")]
	public partial class linqKhachHangDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqKhachHangDataContext() : 
				base(global::daoSLTH.Properties.Settings.Default.SoLieuTongHopConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqKhachHangDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqKhachHangDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqKhachHangDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqKhachHangDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblKhachHang_CapNhat_NgayPhatSinhDoanhThu")]
		public int sp_tblKhachHang_CapNhat_NgayPhatSinhDoanhThu([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhachHang", DbType="NVarChar(20)")] string maKhachHang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, maKhachHang, ngay);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDanhMuc_DanhSach")]
		public ISingleResult<sp_tblDanhMuc_DanhSachResult> sp_tblDanhMuc_DanhSach()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_tblDanhMuc_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblKhachHang_DanhSach")]
		public ISingleResult<sp_tblKhachHang_DanhSachResult> sp_tblKhachHang_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nhom", DbType="NVarChar(10)")] string nhom, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay, nhom, maDonVi);
			return ((ISingleResult<sp_tblKhachHang_DanhSachResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblDanhMuc_DanhSachResult
	{
		
		private int _ID;
		
		private string _Ma;
		
		private string _Ten;
		
		public sp_tblDanhMuc_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ma", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(100)")]
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
	}
	
	public partial class sp_tblKhachHang_DanhSachResult
	{
		
		private System.Nullable<long> _ID;
		
		private string _MaBuuCuc;
		
		private string _BuuCuc;
		
		private string _Nhom;
		
		private string _NhomKH;
		
		private string _MaKhachHang;
		
		private string _TenKhachHang;
		
		private string _DiaChiKhachHang;
		
		private System.Nullable<System.DateTime> _NgayPhatSinhDoanhThu;
		
		public sp_tblKhachHang_DanhSachResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="BigInt")]
		public System.Nullable<long> ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuuCuc", DbType="NVarChar(255)")]
		public string BuuCuc
		{
			get
			{
				return this._BuuCuc;
			}
			set
			{
				if ((this._BuuCuc != value))
				{
					this._BuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nhom", DbType="NVarChar(10)")]
		public string Nhom
		{
			get
			{
				return this._Nhom;
			}
			set
			{
				if ((this._Nhom != value))
				{
					this._Nhom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhomKH", DbType="NVarChar(100)")]
		public string NhomKH
		{
			get
			{
				return this._NhomKH;
			}
			set
			{
				if ((this._NhomKH != value))
				{
					this._NhomKH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NVarChar(20)")]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this._MaKhachHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(100)")]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this._TenKhachHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChiKhachHang", DbType="NVarChar(200)")]
		public string DiaChiKhachHang
		{
			get
			{
				return this._DiaChiKhachHang;
			}
			set
			{
				if ((this._DiaChiKhachHang != value))
				{
					this._DiaChiKhachHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayPhatSinhDoanhThu", DbType="Date")]
		public System.Nullable<System.DateTime> NgayPhatSinhDoanhThu
		{
			get
			{
				return this._NgayPhatSinhDoanhThu;
			}
			set
			{
				if ((this._NgayPhatSinhDoanhThu != value))
				{
					this._NgayPhatSinhDoanhThu = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
