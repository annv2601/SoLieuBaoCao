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

namespace daoTienThuCOD.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TienCOD")]
	public partial class linqChuyenTiepDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqChuyenTiepDataContext() : 
				base(global::daoTienThuCOD.Properties.Settings.Default.TienCODConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqChuyenTiepDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChuyenTiepDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChuyenTiepDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChuyenTiepDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChuyenTiep_CapNhatTrangThai")]
		public int sp_tblChuyenTiep_CapNhatTrangThai([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, ngay);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChuyenTiep_DanhSach")]
		public ISingleResult<sp_tblChuyenTiep_DanhSachResult> sp_tblChuyenTiep_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, tuNgay, denNgay);
			return ((ISingleResult<sp_tblChuyenTiep_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChuyenTiep_Them")]
		public int sp_tblChuyenTiep_Them([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ca", DbType="SmallInt")] System.Nullable<short> ca, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ItemCode", DbType="NVarChar(20)")] string itemCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReceiverFullname", DbType="NVarChar(250)")] string receiverFullname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReceiverAddress", DbType="NVarChar(250)")] string receiverAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReceiverTel", DbType="NVarChar(50)")] string receiverTel, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Weight", DbType="Float")] System.Nullable<double> weight, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoTienCOD", DbType="Float")] System.Nullable<double> soTienCOD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TongCuoc", DbType="Float")] System.Nullable<double> tongCuoc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VAT", DbType="Float")] System.Nullable<double> vAT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ThanhTien", DbType="Float")] System.Nullable<double> thanhTien, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LyDo", DbType="NVarChar(150)")] string lyDo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayChuyenHoan", DbType="DateTime")] System.Nullable<System.DateTime> ngayChuyenHoan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ngay, ca, maBuuCuc, itemCode, receiverFullname, receiverAddress, receiverTel, weight, soTienCOD, tongCuoc, vAT, thanhTien, lyDo, ngayChuyenHoan);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChuyenTiep_Xoa")]
		public int sp_tblChuyenTiep_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, ngay);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblChuyenTiep_DanhSachResult
	{
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private System.Nullable<short> _Ca;
		
		private string _MaBuuCuc;
		
		private string _ItemCode;
		
		private string _ReceiverFullname;
		
		private string _ReceiverAddress;
		
		private string _ReceiverTel;
		
		private System.Nullable<double> _Weight;
		
		private System.Nullable<double> _SoTienCOD;
		
		private System.Nullable<double> _TongCuoc;
		
		private System.Nullable<double> _VAT;
		
		private System.Nullable<double> _ThanhTien;
		
		private string _LyDo;
		
		private System.Nullable<System.DateTime> _NgayChuyenHoan;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblChuyenTiep_DanhSachResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ca", DbType="SmallInt")]
		public System.Nullable<short> Ca
		{
			get
			{
				return this._Ca;
			}
			set
			{
				if ((this._Ca != value))
				{
					this._Ca = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemCode", DbType="NVarChar(20)")]
		public string ItemCode
		{
			get
			{
				return this._ItemCode;
			}
			set
			{
				if ((this._ItemCode != value))
				{
					this._ItemCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverFullname", DbType="NVarChar(250)")]
		public string ReceiverFullname
		{
			get
			{
				return this._ReceiverFullname;
			}
			set
			{
				if ((this._ReceiverFullname != value))
				{
					this._ReceiverFullname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverAddress", DbType="NVarChar(255)")]
		public string ReceiverAddress
		{
			get
			{
				return this._ReceiverAddress;
			}
			set
			{
				if ((this._ReceiverAddress != value))
				{
					this._ReceiverAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverTel", DbType="NVarChar(50)")]
		public string ReceiverTel
		{
			get
			{
				return this._ReceiverTel;
			}
			set
			{
				if ((this._ReceiverTel != value))
				{
					this._ReceiverTel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Float")]
		public System.Nullable<double> Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this._Weight = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienCOD", DbType="Float")]
		public System.Nullable<double> SoTienCOD
		{
			get
			{
				return this._SoTienCOD;
			}
			set
			{
				if ((this._SoTienCOD != value))
				{
					this._SoTienCOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongCuoc", DbType="Float")]
		public System.Nullable<double> TongCuoc
		{
			get
			{
				return this._TongCuoc;
			}
			set
			{
				if ((this._TongCuoc != value))
				{
					this._TongCuoc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VAT", DbType="Float")]
		public System.Nullable<double> VAT
		{
			get
			{
				return this._VAT;
			}
			set
			{
				if ((this._VAT != value))
				{
					this._VAT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float")]
		public System.Nullable<double> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this._ThanhTien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LyDo", DbType="NVarChar(150)")]
		public string LyDo
		{
			get
			{
				return this._LyDo;
			}
			set
			{
				if ((this._LyDo != value))
				{
					this._LyDo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayChuyenHoan", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayChuyenHoan
		{
			get
			{
				return this._NgayChuyenHoan;
			}
			set
			{
				if ((this._NgayChuyenHoan != value))
				{
					this._NgayChuyenHoan = value;
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
