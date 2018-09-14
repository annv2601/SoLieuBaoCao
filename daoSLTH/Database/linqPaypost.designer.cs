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
	public partial class linqPaypostDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqPaypostDataContext() : 
				base(global::daoSLTH.Properties.Settings.Default.SoLieuTongHopConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqPaypostDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqPaypostDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqPaypostDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqPaypostDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblPaypostBuuCuc_ChiTiet")]
		public ISingleResult<sp_tblPaypostBuuCuc_ChiTietResult> sp_tblPaypostBuuCuc_ChiTiet([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDoiSoat", DbType="NVarChar(20)")] string maDoiSoat)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maDoiSoat);
			return ((ISingleResult<sp_tblPaypostBuuCuc_ChiTietResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblPaypostBuuCuc_DanhSach")]
		public ISingleResult<sp_tblPaypostBuuCuc_DanhSachResult> sp_tblPaypostBuuCuc_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay, maDonVi);
			return ((ISingleResult<sp_tblPaypostBuuCuc_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblPaypostBuuCuc_TongHop")]
		public int sp_tblPaypostBuuCuc_TongHop([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayHienTai", DbType="Bit")] System.Nullable<bool> ngayHienTai)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ngay, ngayHienTai);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblPaypostBuuCuc_DanhSach_BuuCuc")]
		public ISingleResult<sp_tblPaypostBuuCuc_DanhSach_BuuCucResult> sp_tblPaypostBuuCuc_DanhSach_BuuCuc([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay, maBuuCuc);
			return ((ISingleResult<sp_tblPaypostBuuCuc_DanhSach_BuuCucResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblPaypostBuuCuc_ChiTiet_GiaiDoan")]
		public ISingleResult<sp_tblPaypostBuuCuc_ChiTiet_GiaiDoanResult> sp_tblPaypostBuuCuc_ChiTiet_GiaiDoan([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(20)")] string maBuuCuc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay, maBuuCuc);
			return ((ISingleResult<sp_tblPaypostBuuCuc_ChiTiet_GiaiDoanResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblPayPostLoai_DanhSach")]
		public ISingleResult<sp_tblPayPostLoai_DanhSachResult> sp_tblPayPostLoai_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay, maDonVi);
			return ((ISingleResult<sp_tblPayPostLoai_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblPayPostLoai_DanhSach_BuuCuc")]
		public ISingleResult<sp_tblPayPostLoai_DanhSach_BuuCucResult> sp_tblPayPostLoai_DanhSach_BuuCuc([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay, maBuuCuc);
			return ((ISingleResult<sp_tblPayPostLoai_DanhSach_BuuCucResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblPaypostBuuCuc_ChiTietResult
	{
		
		private string _MaDoiSoat;
		
		private string _TranTime;
		
		private string _TranCat;
		
		private string _InvokedFrom;
		
		private string _TranID;
		
		private string _PAC;
		
		private string _DichVu;
		
		private string _AccountID;
		
		private System.Nullable<double> _TranAmount;
		
		private string _SenderName;
		
		private string _AddInfo1;
		
		private string _AddInfo2;
		
		private string _AddInfo3;
		
		private string _AddInfo4;
		
		private string _AddInfo5;
		
		private string _AddInfo6;
		
		private string _AddInfo7;
		
		private string _AddInfo8;
		
		private string _Fee;
		
		private string _Add_Info_Fee_01;
		
		private string _Add_Info_Fee_02;
		
		private string _Add_Info_Fee_03;
		
		private string _Add_Info_Fee_04;
		
		private string _Add_Info_Fee_05;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblPaypostBuuCuc_ChiTietResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDoiSoat", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MaDoiSoat
		{
			get
			{
				return this._MaDoiSoat;
			}
			set
			{
				if ((this._MaDoiSoat != value))
				{
					this._MaDoiSoat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranTime", DbType="NVarChar(30)")]
		public string TranTime
		{
			get
			{
				return this._TranTime;
			}
			set
			{
				if ((this._TranTime != value))
				{
					this._TranTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranCat", DbType="NVarChar(10)")]
		public string TranCat
		{
			get
			{
				return this._TranCat;
			}
			set
			{
				if ((this._TranCat != value))
				{
					this._TranCat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvokedFrom", DbType="NVarChar(20)")]
		public string InvokedFrom
		{
			get
			{
				return this._InvokedFrom;
			}
			set
			{
				if ((this._InvokedFrom != value))
				{
					this._InvokedFrom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranID", DbType="NVarChar(50)")]
		public string TranID
		{
			get
			{
				return this._TranID;
			}
			set
			{
				if ((this._TranID != value))
				{
					this._TranID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PAC", DbType="NVarChar(20)")]
		public string PAC
		{
			get
			{
				return this._PAC;
			}
			set
			{
				if ((this._PAC != value))
				{
					this._PAC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DichVu", DbType="NVarChar(50)")]
		public string DichVu
		{
			get
			{
				return this._DichVu;
			}
			set
			{
				if ((this._DichVu != value))
				{
					this._DichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="NVarChar(50)")]
		public string AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this._AccountID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranAmount", DbType="Float")]
		public System.Nullable<double> TranAmount
		{
			get
			{
				return this._TranAmount;
			}
			set
			{
				if ((this._TranAmount != value))
				{
					this._TranAmount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SenderName", DbType="NVarChar(50)")]
		public string SenderName
		{
			get
			{
				return this._SenderName;
			}
			set
			{
				if ((this._SenderName != value))
				{
					this._SenderName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo1", DbType="NVarChar(50)")]
		public string AddInfo1
		{
			get
			{
				return this._AddInfo1;
			}
			set
			{
				if ((this._AddInfo1 != value))
				{
					this._AddInfo1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo2", DbType="NVarChar(50)")]
		public string AddInfo2
		{
			get
			{
				return this._AddInfo2;
			}
			set
			{
				if ((this._AddInfo2 != value))
				{
					this._AddInfo2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo3", DbType="NVarChar(50)")]
		public string AddInfo3
		{
			get
			{
				return this._AddInfo3;
			}
			set
			{
				if ((this._AddInfo3 != value))
				{
					this._AddInfo3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo4", DbType="NVarChar(50)")]
		public string AddInfo4
		{
			get
			{
				return this._AddInfo4;
			}
			set
			{
				if ((this._AddInfo4 != value))
				{
					this._AddInfo4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo5", DbType="NVarChar(50)")]
		public string AddInfo5
		{
			get
			{
				return this._AddInfo5;
			}
			set
			{
				if ((this._AddInfo5 != value))
				{
					this._AddInfo5 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo6", DbType="NVarChar(50)")]
		public string AddInfo6
		{
			get
			{
				return this._AddInfo6;
			}
			set
			{
				if ((this._AddInfo6 != value))
				{
					this._AddInfo6 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo7", DbType="NVarChar(50)")]
		public string AddInfo7
		{
			get
			{
				return this._AddInfo7;
			}
			set
			{
				if ((this._AddInfo7 != value))
				{
					this._AddInfo7 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo8", DbType="NVarChar(50)")]
		public string AddInfo8
		{
			get
			{
				return this._AddInfo8;
			}
			set
			{
				if ((this._AddInfo8 != value))
				{
					this._AddInfo8 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fee", DbType="NVarChar(50)")]
		public string Fee
		{
			get
			{
				return this._Fee;
			}
			set
			{
				if ((this._Fee != value))
				{
					this._Fee = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_01", DbType="NVarChar(50)")]
		public string Add_Info_Fee_01
		{
			get
			{
				return this._Add_Info_Fee_01;
			}
			set
			{
				if ((this._Add_Info_Fee_01 != value))
				{
					this._Add_Info_Fee_01 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_02", DbType="NVarChar(50)")]
		public string Add_Info_Fee_02
		{
			get
			{
				return this._Add_Info_Fee_02;
			}
			set
			{
				if ((this._Add_Info_Fee_02 != value))
				{
					this._Add_Info_Fee_02 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_03", DbType="NVarChar(50)")]
		public string Add_Info_Fee_03
		{
			get
			{
				return this._Add_Info_Fee_03;
			}
			set
			{
				if ((this._Add_Info_Fee_03 != value))
				{
					this._Add_Info_Fee_03 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_04", DbType="NVarChar(50)")]
		public string Add_Info_Fee_04
		{
			get
			{
				return this._Add_Info_Fee_04;
			}
			set
			{
				if ((this._Add_Info_Fee_04 != value))
				{
					this._Add_Info_Fee_04 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_05", DbType="NVarChar(50)")]
		public string Add_Info_Fee_05
		{
			get
			{
				return this._Add_Info_Fee_05;
			}
			set
			{
				if ((this._Add_Info_Fee_05 != value))
				{
					this._Add_Info_Fee_05 = value;
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
	
	public partial class sp_tblPaypostBuuCuc_DanhSachResult
	{
		
		private string _DonVi;
		
		private string _MaBuuCuc;
		
		private string _TenBuuCuc;
		
		private string _TenBuuCucGop;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<decimal> _DoanhThu;
		
		public sp_tblPaypostBuuCuc_DanhSachResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonVi", DbType="NVarChar(80)")]
		public string DonVi
		{
			get
			{
				return this._DonVi;
			}
			set
			{
				if ((this._DonVi != value))
				{
					this._DonVi = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCuc", DbType="NVarChar(80)")]
		public string TenBuuCuc
		{
			get
			{
				return this._TenBuuCuc;
			}
			set
			{
				if ((this._TenBuuCuc != value))
				{
					this._TenBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCucGop", DbType="NVarChar(103)")]
		public string TenBuuCucGop
		{
			get
			{
				return this._TenBuuCucGop;
			}
			set
			{
				if ((this._TenBuuCucGop != value))
				{
					this._TenBuuCucGop = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this._SoLuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoanhThu", DbType="Decimal(38,0)")]
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
	}
	
	public partial class sp_tblPaypostBuuCuc_DanhSach_BuuCucResult
	{
		
		private string _DonVi;
		
		private string _MaBuuCuc;
		
		private string _TenBuuCuc;
		
		private string _TenBuuCucGop;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<decimal> _DoanhThu;
		
		public sp_tblPaypostBuuCuc_DanhSach_BuuCucResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonVi", DbType="NVarChar(80)")]
		public string DonVi
		{
			get
			{
				return this._DonVi;
			}
			set
			{
				if ((this._DonVi != value))
				{
					this._DonVi = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCuc", DbType="NVarChar(80)")]
		public string TenBuuCuc
		{
			get
			{
				return this._TenBuuCuc;
			}
			set
			{
				if ((this._TenBuuCuc != value))
				{
					this._TenBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCucGop", DbType="NVarChar(103)")]
		public string TenBuuCucGop
		{
			get
			{
				return this._TenBuuCucGop;
			}
			set
			{
				if ((this._TenBuuCucGop != value))
				{
					this._TenBuuCucGop = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this._SoLuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoanhThu", DbType="Decimal(38,0)")]
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
	}
	
	public partial class sp_tblPaypostBuuCuc_ChiTiet_GiaiDoanResult
	{
		
		private string _MaDoiSoat;
		
		private string _Ngay;
		
		private string _TranTime;
		
		private string _TranCat;
		
		private string _InvokedFrom;
		
		private string _TranID;
		
		private string _PAC;
		
		private string _DichVu;
		
		private string _AccountID;
		
		private System.Nullable<double> _TranAmount;
		
		private string _SenderName;
		
		private string _AddInfo1;
		
		private string _AddInfo2;
		
		private string _AddInfo3;
		
		private string _AddInfo4;
		
		private string _AddInfo5;
		
		private string _AddInfo6;
		
		private string _AddInfo7;
		
		private string _AddInfo8;
		
		private string _Fee;
		
		private string _Add_Info_Fee_01;
		
		private string _Add_Info_Fee_02;
		
		private string _Add_Info_Fee_03;
		
		private string _Add_Info_Fee_04;
		
		private string _Add_Info_Fee_05;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblPaypostBuuCuc_ChiTiet_GiaiDoanResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDoiSoat", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MaDoiSoat
		{
			get
			{
				return this._MaDoiSoat;
			}
			set
			{
				if ((this._MaDoiSoat != value))
				{
					this._MaDoiSoat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngay", DbType="NVarChar(10)")]
		public string Ngay
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranTime", DbType="NVarChar(30)")]
		public string TranTime
		{
			get
			{
				return this._TranTime;
			}
			set
			{
				if ((this._TranTime != value))
				{
					this._TranTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranCat", DbType="NVarChar(10)")]
		public string TranCat
		{
			get
			{
				return this._TranCat;
			}
			set
			{
				if ((this._TranCat != value))
				{
					this._TranCat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvokedFrom", DbType="NVarChar(20)")]
		public string InvokedFrom
		{
			get
			{
				return this._InvokedFrom;
			}
			set
			{
				if ((this._InvokedFrom != value))
				{
					this._InvokedFrom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranID", DbType="NVarChar(50)")]
		public string TranID
		{
			get
			{
				return this._TranID;
			}
			set
			{
				if ((this._TranID != value))
				{
					this._TranID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PAC", DbType="NVarChar(20)")]
		public string PAC
		{
			get
			{
				return this._PAC;
			}
			set
			{
				if ((this._PAC != value))
				{
					this._PAC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DichVu", DbType="NVarChar(50)")]
		public string DichVu
		{
			get
			{
				return this._DichVu;
			}
			set
			{
				if ((this._DichVu != value))
				{
					this._DichVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="NVarChar(50)")]
		public string AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this._AccountID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranAmount", DbType="Float")]
		public System.Nullable<double> TranAmount
		{
			get
			{
				return this._TranAmount;
			}
			set
			{
				if ((this._TranAmount != value))
				{
					this._TranAmount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SenderName", DbType="NVarChar(50)")]
		public string SenderName
		{
			get
			{
				return this._SenderName;
			}
			set
			{
				if ((this._SenderName != value))
				{
					this._SenderName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo1", DbType="NVarChar(50)")]
		public string AddInfo1
		{
			get
			{
				return this._AddInfo1;
			}
			set
			{
				if ((this._AddInfo1 != value))
				{
					this._AddInfo1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo2", DbType="NVarChar(50)")]
		public string AddInfo2
		{
			get
			{
				return this._AddInfo2;
			}
			set
			{
				if ((this._AddInfo2 != value))
				{
					this._AddInfo2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo3", DbType="NVarChar(50)")]
		public string AddInfo3
		{
			get
			{
				return this._AddInfo3;
			}
			set
			{
				if ((this._AddInfo3 != value))
				{
					this._AddInfo3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo4", DbType="NVarChar(50)")]
		public string AddInfo4
		{
			get
			{
				return this._AddInfo4;
			}
			set
			{
				if ((this._AddInfo4 != value))
				{
					this._AddInfo4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo5", DbType="NVarChar(50)")]
		public string AddInfo5
		{
			get
			{
				return this._AddInfo5;
			}
			set
			{
				if ((this._AddInfo5 != value))
				{
					this._AddInfo5 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo6", DbType="NVarChar(50)")]
		public string AddInfo6
		{
			get
			{
				return this._AddInfo6;
			}
			set
			{
				if ((this._AddInfo6 != value))
				{
					this._AddInfo6 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo7", DbType="NVarChar(50)")]
		public string AddInfo7
		{
			get
			{
				return this._AddInfo7;
			}
			set
			{
				if ((this._AddInfo7 != value))
				{
					this._AddInfo7 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddInfo8", DbType="NVarChar(50)")]
		public string AddInfo8
		{
			get
			{
				return this._AddInfo8;
			}
			set
			{
				if ((this._AddInfo8 != value))
				{
					this._AddInfo8 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fee", DbType="NVarChar(50)")]
		public string Fee
		{
			get
			{
				return this._Fee;
			}
			set
			{
				if ((this._Fee != value))
				{
					this._Fee = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_01", DbType="NVarChar(50)")]
		public string Add_Info_Fee_01
		{
			get
			{
				return this._Add_Info_Fee_01;
			}
			set
			{
				if ((this._Add_Info_Fee_01 != value))
				{
					this._Add_Info_Fee_01 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_02", DbType="NVarChar(50)")]
		public string Add_Info_Fee_02
		{
			get
			{
				return this._Add_Info_Fee_02;
			}
			set
			{
				if ((this._Add_Info_Fee_02 != value))
				{
					this._Add_Info_Fee_02 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_03", DbType="NVarChar(50)")]
		public string Add_Info_Fee_03
		{
			get
			{
				return this._Add_Info_Fee_03;
			}
			set
			{
				if ((this._Add_Info_Fee_03 != value))
				{
					this._Add_Info_Fee_03 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_04", DbType="NVarChar(50)")]
		public string Add_Info_Fee_04
		{
			get
			{
				return this._Add_Info_Fee_04;
			}
			set
			{
				if ((this._Add_Info_Fee_04 != value))
				{
					this._Add_Info_Fee_04 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Add_Info_Fee_05", DbType="NVarChar(50)")]
		public string Add_Info_Fee_05
		{
			get
			{
				return this._Add_Info_Fee_05;
			}
			set
			{
				if ((this._Add_Info_Fee_05 != value))
				{
					this._Add_Info_Fee_05 = value;
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
	
	public partial class sp_tblPayPostLoai_DanhSachResult
	{
		
		private string _DonVi;
		
		private string _MaBuuCuc;
		
		private string _TenBuuCuc;
		
		private string _TenBuuCucGop;
		
		private System.Nullable<int> _SoLuongThu;
		
		private System.Nullable<decimal> _SoTienThu;
		
		private System.Nullable<int> _SoLuongChi;
		
		private System.Nullable<decimal> _SoTienChi;
		
		private System.Nullable<int> _SoLuongNormal;
		
		private System.Nullable<decimal> _SoTienNormal;
		
		public sp_tblPayPostLoai_DanhSachResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonVi", DbType="NVarChar(80)")]
		public string DonVi
		{
			get
			{
				return this._DonVi;
			}
			set
			{
				if ((this._DonVi != value))
				{
					this._DonVi = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCuc", DbType="NVarChar(80)")]
		public string TenBuuCuc
		{
			get
			{
				return this._TenBuuCuc;
			}
			set
			{
				if ((this._TenBuuCuc != value))
				{
					this._TenBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCucGop", DbType="NVarChar(103)")]
		public string TenBuuCucGop
		{
			get
			{
				return this._TenBuuCucGop;
			}
			set
			{
				if ((this._TenBuuCucGop != value))
				{
					this._TenBuuCucGop = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongThu", DbType="Int")]
		public System.Nullable<int> SoLuongThu
		{
			get
			{
				return this._SoLuongThu;
			}
			set
			{
				if ((this._SoLuongThu != value))
				{
					this._SoLuongThu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienThu", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> SoTienThu
		{
			get
			{
				return this._SoTienThu;
			}
			set
			{
				if ((this._SoTienThu != value))
				{
					this._SoTienThu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongChi", DbType="Int")]
		public System.Nullable<int> SoLuongChi
		{
			get
			{
				return this._SoLuongChi;
			}
			set
			{
				if ((this._SoLuongChi != value))
				{
					this._SoLuongChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienChi", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> SoTienChi
		{
			get
			{
				return this._SoTienChi;
			}
			set
			{
				if ((this._SoTienChi != value))
				{
					this._SoTienChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongNormal", DbType="Int")]
		public System.Nullable<int> SoLuongNormal
		{
			get
			{
				return this._SoLuongNormal;
			}
			set
			{
				if ((this._SoLuongNormal != value))
				{
					this._SoLuongNormal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienNormal", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> SoTienNormal
		{
			get
			{
				return this._SoTienNormal;
			}
			set
			{
				if ((this._SoTienNormal != value))
				{
					this._SoTienNormal = value;
				}
			}
		}
	}
	
	public partial class sp_tblPayPostLoai_DanhSach_BuuCucResult
	{
		
		private string _DonVi;
		
		private string _MaBuuCuc;
		
		private string _TenBuuCuc;
		
		private string _TenBuuCucGop;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private System.Nullable<int> _SoLuongThu;
		
		private System.Nullable<decimal> _SoTienThu;
		
		private System.Nullable<int> _SoLuongChi;
		
		private System.Nullable<decimal> _SoTienChi;
		
		private System.Nullable<int> _SoLuongNormal;
		
		private System.Nullable<decimal> _SoTienNormal;
		
		public sp_tblPayPostLoai_DanhSach_BuuCucResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonVi", DbType="NVarChar(80)")]
		public string DonVi
		{
			get
			{
				return this._DonVi;
			}
			set
			{
				if ((this._DonVi != value))
				{
					this._DonVi = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCuc", DbType="NVarChar(80)")]
		public string TenBuuCuc
		{
			get
			{
				return this._TenBuuCuc;
			}
			set
			{
				if ((this._TenBuuCuc != value))
				{
					this._TenBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuCucGop", DbType="NVarChar(103)")]
		public string TenBuuCucGop
		{
			get
			{
				return this._TenBuuCucGop;
			}
			set
			{
				if ((this._TenBuuCucGop != value))
				{
					this._TenBuuCucGop = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongThu", DbType="Int")]
		public System.Nullable<int> SoLuongThu
		{
			get
			{
				return this._SoLuongThu;
			}
			set
			{
				if ((this._SoLuongThu != value))
				{
					this._SoLuongThu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienThu", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> SoTienThu
		{
			get
			{
				return this._SoTienThu;
			}
			set
			{
				if ((this._SoTienThu != value))
				{
					this._SoTienThu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongChi", DbType="Int")]
		public System.Nullable<int> SoLuongChi
		{
			get
			{
				return this._SoLuongChi;
			}
			set
			{
				if ((this._SoLuongChi != value))
				{
					this._SoLuongChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienChi", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> SoTienChi
		{
			get
			{
				return this._SoTienChi;
			}
			set
			{
				if ((this._SoTienChi != value))
				{
					this._SoTienChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongNormal", DbType="Int")]
		public System.Nullable<int> SoLuongNormal
		{
			get
			{
				return this._SoLuongNormal;
			}
			set
			{
				if ((this._SoLuongNormal != value))
				{
					this._SoLuongNormal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienNormal", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> SoTienNormal
		{
			get
			{
				return this._SoTienNormal;
			}
			set
			{
				if ((this._SoTienNormal != value))
				{
					this._SoTienNormal = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
