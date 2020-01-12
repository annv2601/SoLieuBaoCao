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

namespace daoSLBC.Database.DuLieuBaoCao
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
	public partial class linqDuLieuBaoCaoB0205DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqDuLieuBaoCaoB0205DataContext() : 
				base(global::daoSLBC.Properties.Settings.Default.SoLieuBaoCaoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaoCaoB0205DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaoCaoB0205DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaoCaoB0205DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaoCaoB0205DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoB0205_TinhDanSuat_STK1")]
		public int sp_tblDuLieuBaoCaoB0205_TinhDanSuat_STK1([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi, maBieuBaoCao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoB0205_LaySTK1")]
		public int sp_tblDuLieuBaoCaoB0205_LaySTK1([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonViSTK1", DbType="NVarChar(10)")] string maDonViSTK1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonViSTK1, maBieuBaoCao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoB0205_BaoCao")]
		public ISingleResult<sp_tblDuLieuBaoCaoB0205_BaoCaoResult> sp_tblDuLieuBaoCaoB0205_BaoCao([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao);
			return ((ISingleResult<sp_tblDuLieuBaoCaoB0205_BaoCaoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoB0205_KhoiTao")]
		public int sp_tblDuLieuBaoCaoB0205_KhoiTao([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiThaoTac", DbType="NVarChar(50)")] string nguoiThaoTac)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao, iDMauBieu, nguoiThaoTac);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblDuLieuBaoCaoB0205_BaoCaoResult
	{
		
		private string _ThuTu;
		
		private string _Ten;
		
		private string _DonViTinh;
		
		private string _MaSo;
		
		private System.Nullable<double> _SLDi;
		
		private System.Nullable<decimal> _DoanhThu;
		
		private System.Nullable<decimal> _DoanhThuLK;
		
		private System.Nullable<decimal> _ThueSuat;
		
		private System.Nullable<decimal> _ThueGTGT;
		
		private System.Nullable<decimal> _ThueGTGTLK;
		
		private System.Nullable<double> _SLNVu;
		
		private System.Nullable<double> _SLDen;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		private System.Nullable<bool> _InDamNghieng;
		
		private int _IDChiTieu;
		
		private string _MaBieuBaoCao;
		
		public sp_tblDuLieuBaoCaoB0205_BaoCaoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThuTu", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonViTinh", DbType="NVarChar(100)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSo", DbType="NVarChar(20)")]
		public string MaSo
		{
			get
			{
				return this._MaSo;
			}
			set
			{
				if ((this._MaSo != value))
				{
					this._MaSo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLDi", DbType="Float")]
		public System.Nullable<double> SLDi
		{
			get
			{
				return this._SLDi;
			}
			set
			{
				if ((this._SLDi != value))
				{
					this._SLDi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoanhThu", DbType="Decimal(25,0)")]
		public System.Nullable<decimal> DoanhThu
		{
			get
			{
				return this._DoanhThu;
			}
			set
			{
				if ((this._DoanhThu != value))
				{
					this._DoanhThu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoanhThuLK", DbType="Decimal(25,0)")]
		public System.Nullable<decimal> DoanhThuLK
		{
			get
			{
				return this._DoanhThuLK;
			}
			set
			{
				if ((this._DoanhThuLK != value))
				{
					this._DoanhThuLK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThueSuat", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> ThueSuat
		{
			get
			{
				return this._ThueSuat;
			}
			set
			{
				if ((this._ThueSuat != value))
				{
					this._ThueSuat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThueGTGT", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> ThueGTGT
		{
			get
			{
				return this._ThueGTGT;
			}
			set
			{
				if ((this._ThueGTGT != value))
				{
					this._ThueGTGT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThueGTGTLK", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> ThueGTGTLK
		{
			get
			{
				return this._ThueGTGTLK;
			}
			set
			{
				if ((this._ThueGTGTLK != value))
				{
					this._ThueGTGTLK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLNVu", DbType="Float")]
		public System.Nullable<double> SLNVu
		{
			get
			{
				return this._SLNVu;
			}
			set
			{
				if ((this._SLNVu != value))
				{
					this._SLNVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLDen", DbType="Float")]
		public System.Nullable<double> SLDen
		{
			get
			{
				return this._SLDen;
			}
			set
			{
				if ((this._SLDen != value))
				{
					this._SLDen = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InDamNghieng", DbType="Bit")]
		public System.Nullable<bool> InDamNghieng
		{
			get
			{
				return this._InDamNghieng;
			}
			set
			{
				if ((this._InDamNghieng != value))
				{
					this._InDamNghieng = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieu", DbType="Int NOT NULL")]
		public int IDChiTieu
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBieuBaoCao", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string MaBieuBaoCao
		{
			get
			{
				return this._MaBieuBaoCao;
			}
			set
			{
				if ((this._MaBieuBaoCao != value))
				{
					this._MaBieuBaoCao = value;
				}
			}
		}
	}
}
#pragma warning restore 1591