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

namespace daoSLKT.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SoLieuKeToan")]
	public partial class linqSoNhatKyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqSoNhatKyDataContext() : 
				base(global::daoSLKT.Properties.Settings.Default.SoLieuKeToanConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoNhatKyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoNhatKyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoNhatKyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqSoNhatKyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoNhatKy_TongHop1")]
		public ISingleResult<sp_tblSoNhatKy_TongHop1Result> sp_tblSoNhatKy_TongHop1([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(20)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi);
			return ((ISingleResult<sp_tblSoNhatKy_TongHop1Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoNhatKy_ChiTiet")]
		public ISingleResult<sp_tblSoNhatKy_ChiTietResult> sp_tblSoNhatKy_ChiTiet([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(20)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ND", DbType="NVarChar(MAX)")] string nD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NGAY_HT", DbType="NVarChar(20)")] string nGAY_HT)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi, nD, nGAY_HT);
			return ((ISingleResult<sp_tblSoNhatKy_ChiTietResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoNhatKy_TongHop2")]
		public ISingleResult<sp_tblSoNhatKy_TongHop2Result> sp_tblSoNhatKy_TongHop2([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(20)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoCo", DbType="Bit")] System.Nullable<bool> noCo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi, noCo);
			return ((ISingleResult<sp_tblSoNhatKy_TongHop2Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblSoNhatKy_ChiTiet2")]
		public ISingleResult<sp_tblSoNhatKy_ChiTiet2Result> sp_tblSoNhatKy_ChiTiet2([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Thang", DbType="SmallInt")] System.Nullable<short> thang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(20)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayHT", DbType="NVarChar(20)")] string ngayHT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TaiKhoan", DbType="NVarChar(20)")] string taiKhoan, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoCo", DbType="Bit")] System.Nullable<bool> noCo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), thang, nam, maDonVi, ngayHT, taiKhoan, noCo);
			return ((ISingleResult<sp_tblSoNhatKy_ChiTiet2Result>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblSoNhatKy_TongHop1Result
	{
		
		private System.Nullable<long> _STT;
		
		private string _NGAY_HT;
		
		private string _NGAY_CT;
		
		private string _ND;
		
		private string _TK_NO;
		
		private string _TK_CO;
		
		private System.Nullable<double> _TIEN_NO;
		
		private System.Nullable<double> _TIEN_CO;
		
		private string _MaDonVi;
		
		public sp_tblSoNhatKy_TongHop1Result()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_HT", DbType="NVarChar(20)")]
		public string NGAY_HT
		{
			get
			{
				return this._NGAY_HT;
			}
			set
			{
				if ((this._NGAY_HT != value))
				{
					this._NGAY_HT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_CT", DbType="NVarChar(20)")]
		public string NGAY_CT
		{
			get
			{
				return this._NGAY_CT;
			}
			set
			{
				if ((this._NGAY_CT != value))
				{
					this._NGAY_CT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ND", DbType="NVarChar(MAX)")]
		public string ND
		{
			get
			{
				return this._ND;
			}
			set
			{
				if ((this._ND != value))
				{
					this._ND = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_NO", DbType="NVarChar(20)")]
		public string TK_NO
		{
			get
			{
				return this._TK_NO;
			}
			set
			{
				if ((this._TK_NO != value))
				{
					this._TK_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_CO", DbType="NVarChar(20)")]
		public string TK_CO
		{
			get
			{
				return this._TK_CO;
			}
			set
			{
				if ((this._TK_CO != value))
				{
					this._TK_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_NO", DbType="Float")]
		public System.Nullable<double> TIEN_NO
		{
			get
			{
				return this._TIEN_NO;
			}
			set
			{
				if ((this._TIEN_NO != value))
				{
					this._TIEN_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_CO", DbType="Float")]
		public System.Nullable<double> TIEN_CO
		{
			get
			{
				return this._TIEN_CO;
			}
			set
			{
				if ((this._TIEN_CO != value))
				{
					this._TIEN_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="NVarChar(20)")]
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
	
	public partial class sp_tblSoNhatKy_ChiTietResult
	{
		
		private System.Nullable<long> _STT;
		
		private string _NGAY_HT;
		
		private string _SO_CT;
		
		private string _NGAY_CT;
		
		private string _ND;
		
		private string _TK_NO;
		
		private string _TKE_NO;
		
		private string _DTU_NO;
		
		private string _SP_NO;
		
		private string _TK_CO;
		
		private string _TKE_CO;
		
		private string _DTU_CO;
		
		private string _SP_CO;
		
		private System.Nullable<double> _TIEN_NO;
		
		private System.Nullable<double> _TIEN_CO;
		
		private string _MA_DVI;
		
		private string _NOTE;
		
		private string _MaDonVi;
		
		private string _MaNSD;
		
		private System.Nullable<short> _Thang;
		
		private System.Nullable<int> _Nam;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblSoNhatKy_ChiTietResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_HT", DbType="NVarChar(20)")]
		public string NGAY_HT
		{
			get
			{
				return this._NGAY_HT;
			}
			set
			{
				if ((this._NGAY_HT != value))
				{
					this._NGAY_HT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SO_CT", DbType="NVarChar(200)")]
		public string SO_CT
		{
			get
			{
				return this._SO_CT;
			}
			set
			{
				if ((this._SO_CT != value))
				{
					this._SO_CT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_CT", DbType="NVarChar(20)")]
		public string NGAY_CT
		{
			get
			{
				return this._NGAY_CT;
			}
			set
			{
				if ((this._NGAY_CT != value))
				{
					this._NGAY_CT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ND", DbType="NVarChar(MAX)")]
		public string ND
		{
			get
			{
				return this._ND;
			}
			set
			{
				if ((this._ND != value))
				{
					this._ND = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_NO", DbType="NVarChar(20)")]
		public string TK_NO
		{
			get
			{
				return this._TK_NO;
			}
			set
			{
				if ((this._TK_NO != value))
				{
					this._TK_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKE_NO", DbType="NVarChar(20)")]
		public string TKE_NO
		{
			get
			{
				return this._TKE_NO;
			}
			set
			{
				if ((this._TKE_NO != value))
				{
					this._TKE_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTU_NO", DbType="NVarChar(20)")]
		public string DTU_NO
		{
			get
			{
				return this._DTU_NO;
			}
			set
			{
				if ((this._DTU_NO != value))
				{
					this._DTU_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_NO", DbType="NVarChar(20)")]
		public string SP_NO
		{
			get
			{
				return this._SP_NO;
			}
			set
			{
				if ((this._SP_NO != value))
				{
					this._SP_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_CO", DbType="NVarChar(20)")]
		public string TK_CO
		{
			get
			{
				return this._TK_CO;
			}
			set
			{
				if ((this._TK_CO != value))
				{
					this._TK_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKE_CO", DbType="NVarChar(20)")]
		public string TKE_CO
		{
			get
			{
				return this._TKE_CO;
			}
			set
			{
				if ((this._TKE_CO != value))
				{
					this._TKE_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTU_CO", DbType="NVarChar(20)")]
		public string DTU_CO
		{
			get
			{
				return this._DTU_CO;
			}
			set
			{
				if ((this._DTU_CO != value))
				{
					this._DTU_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_CO", DbType="NVarChar(20)")]
		public string SP_CO
		{
			get
			{
				return this._SP_CO;
			}
			set
			{
				if ((this._SP_CO != value))
				{
					this._SP_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_NO", DbType="Float")]
		public System.Nullable<double> TIEN_NO
		{
			get
			{
				return this._TIEN_NO;
			}
			set
			{
				if ((this._TIEN_NO != value))
				{
					this._TIEN_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_CO", DbType="Float")]
		public System.Nullable<double> TIEN_CO
		{
			get
			{
				return this._TIEN_CO;
			}
			set
			{
				if ((this._TIEN_CO != value))
				{
					this._TIEN_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MA_DVI", DbType="NVarChar(20)")]
		public string MA_DVI
		{
			get
			{
				return this._MA_DVI;
			}
			set
			{
				if ((this._MA_DVI != value))
				{
					this._MA_DVI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOTE", DbType="NVarChar(MAX)")]
		public string NOTE
		{
			get
			{
				return this._NOTE;
			}
			set
			{
				if ((this._NOTE != value))
				{
					this._NOTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNSD", DbType="NVarChar(20)")]
		public string MaNSD
		{
			get
			{
				return this._MaNSD;
			}
			set
			{
				if ((this._MaNSD != value))
				{
					this._MaNSD = value;
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
	
	public partial class sp_tblSoNhatKy_TongHop2Result
	{
		
		private System.Nullable<long> _STT;
		
		private string _NGAY_HT;
		
		private string _NGAY_CT;
		
		private string _ND;
		
		private string _TK_NO;
		
		private string _TK_CO;
		
		private System.Nullable<double> _TIEN_NO;
		
		private System.Nullable<double> _TIEN_CO;
		
		private string _MaDonVi;
		
		public sp_tblSoNhatKy_TongHop2Result()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_HT", DbType="NVarChar(20)")]
		public string NGAY_HT
		{
			get
			{
				return this._NGAY_HT;
			}
			set
			{
				if ((this._NGAY_HT != value))
				{
					this._NGAY_HT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_CT", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string NGAY_CT
		{
			get
			{
				return this._NGAY_CT;
			}
			set
			{
				if ((this._NGAY_CT != value))
				{
					this._NGAY_CT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ND", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string ND
		{
			get
			{
				return this._ND;
			}
			set
			{
				if ((this._ND != value))
				{
					this._ND = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_NO", DbType="NVarChar(20)")]
		public string TK_NO
		{
			get
			{
				return this._TK_NO;
			}
			set
			{
				if ((this._TK_NO != value))
				{
					this._TK_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_CO", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string TK_CO
		{
			get
			{
				return this._TK_CO;
			}
			set
			{
				if ((this._TK_CO != value))
				{
					this._TK_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_NO", DbType="Float")]
		public System.Nullable<double> TIEN_NO
		{
			get
			{
				return this._TIEN_NO;
			}
			set
			{
				if ((this._TIEN_NO != value))
				{
					this._TIEN_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_CO", DbType="Float")]
		public System.Nullable<double> TIEN_CO
		{
			get
			{
				return this._TIEN_CO;
			}
			set
			{
				if ((this._TIEN_CO != value))
				{
					this._TIEN_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="NVarChar(20)")]
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
	
	public partial class sp_tblSoNhatKy_ChiTiet2Result
	{
		
		private System.Nullable<long> _STT;
		
		private string _NGAY_HT;
		
		private string _SO_CT;
		
		private string _NGAY_CT;
		
		private string _ND;
		
		private string _TK_NO;
		
		private string _TKE_NO;
		
		private string _DTU_NO;
		
		private string _SP_NO;
		
		private string _TK_CO;
		
		private string _TKE_CO;
		
		private string _DTU_CO;
		
		private string _SP_CO;
		
		private System.Nullable<double> _TIEN_NO;
		
		private System.Nullable<double> _TIEN_CO;
		
		private string _MA_DVI;
		
		private string _NOTE;
		
		private string _MaDonVi;
		
		private string _MaNSD;
		
		private System.Nullable<short> _Thang;
		
		private System.Nullable<int> _Nam;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblSoNhatKy_ChiTiet2Result()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_HT", DbType="NVarChar(20)")]
		public string NGAY_HT
		{
			get
			{
				return this._NGAY_HT;
			}
			set
			{
				if ((this._NGAY_HT != value))
				{
					this._NGAY_HT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SO_CT", DbType="NVarChar(200)")]
		public string SO_CT
		{
			get
			{
				return this._SO_CT;
			}
			set
			{
				if ((this._SO_CT != value))
				{
					this._SO_CT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_CT", DbType="NVarChar(20)")]
		public string NGAY_CT
		{
			get
			{
				return this._NGAY_CT;
			}
			set
			{
				if ((this._NGAY_CT != value))
				{
					this._NGAY_CT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ND", DbType="NVarChar(MAX)")]
		public string ND
		{
			get
			{
				return this._ND;
			}
			set
			{
				if ((this._ND != value))
				{
					this._ND = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_NO", DbType="NVarChar(20)")]
		public string TK_NO
		{
			get
			{
				return this._TK_NO;
			}
			set
			{
				if ((this._TK_NO != value))
				{
					this._TK_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKE_NO", DbType="NVarChar(20)")]
		public string TKE_NO
		{
			get
			{
				return this._TKE_NO;
			}
			set
			{
				if ((this._TKE_NO != value))
				{
					this._TKE_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTU_NO", DbType="NVarChar(20)")]
		public string DTU_NO
		{
			get
			{
				return this._DTU_NO;
			}
			set
			{
				if ((this._DTU_NO != value))
				{
					this._DTU_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_NO", DbType="NVarChar(20)")]
		public string SP_NO
		{
			get
			{
				return this._SP_NO;
			}
			set
			{
				if ((this._SP_NO != value))
				{
					this._SP_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK_CO", DbType="NVarChar(20)")]
		public string TK_CO
		{
			get
			{
				return this._TK_CO;
			}
			set
			{
				if ((this._TK_CO != value))
				{
					this._TK_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKE_CO", DbType="NVarChar(20)")]
		public string TKE_CO
		{
			get
			{
				return this._TKE_CO;
			}
			set
			{
				if ((this._TKE_CO != value))
				{
					this._TKE_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTU_CO", DbType="NVarChar(20)")]
		public string DTU_CO
		{
			get
			{
				return this._DTU_CO;
			}
			set
			{
				if ((this._DTU_CO != value))
				{
					this._DTU_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_CO", DbType="NVarChar(20)")]
		public string SP_CO
		{
			get
			{
				return this._SP_CO;
			}
			set
			{
				if ((this._SP_CO != value))
				{
					this._SP_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_NO", DbType="Float")]
		public System.Nullable<double> TIEN_NO
		{
			get
			{
				return this._TIEN_NO;
			}
			set
			{
				if ((this._TIEN_NO != value))
				{
					this._TIEN_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEN_CO", DbType="Float")]
		public System.Nullable<double> TIEN_CO
		{
			get
			{
				return this._TIEN_CO;
			}
			set
			{
				if ((this._TIEN_CO != value))
				{
					this._TIEN_CO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MA_DVI", DbType="NVarChar(20)")]
		public string MA_DVI
		{
			get
			{
				return this._MA_DVI;
			}
			set
			{
				if ((this._MA_DVI != value))
				{
					this._MA_DVI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOTE", DbType="NVarChar(MAX)")]
		public string NOTE
		{
			get
			{
				return this._NOTE;
			}
			set
			{
				if ((this._NOTE != value))
				{
					this._NOTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNSD", DbType="NVarChar(20)")]
		public string MaNSD
		{
			get
			{
				return this._MaNSD;
			}
			set
			{
				if ((this._MaNSD != value))
				{
					this._MaNSD = value;
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