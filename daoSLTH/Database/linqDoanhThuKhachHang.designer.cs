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
	public partial class linqDoanhThuKhachHangDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqDoanhThuKhachHangDataContext() : 
				base(global::daoSLTH.Properties.Settings.Default.SoLieuTongHopConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqDoanhThuKhachHangDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDoanhThuKhachHangDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDoanhThuKhachHangDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDoanhThuKhachHangDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDoanhThuKhachHangDichVu_BaoCao_CTiet")]
		public ISingleResult<sp_tblDoanhThuKhachHangDichVu_BaoCao_CTietResult> sp_tblDoanhThuKhachHangDichVu_BaoCao_CTiet([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay, maDonVi);
			return ((ISingleResult<sp_tblDoanhThuKhachHangDichVu_BaoCao_CTietResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDoanhThuKhachHangDichVu_TongHopSoLieu_ThoiGian")]
		public int sp_tblDoanhThuKhachHangDichVu_TongHopSoLieu_ThoiGian([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDoanhThuKhachHangDichVu_TongHopSoLieu")]
		public int sp_tblDoanhThuKhachHangDichVu_TongHopSoLieu([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDoiSoat", DbType="NVarChar(20)")] string maDoiSoat)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maDoiSoat);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblDoanhThuKhachHangDichVu_BaoCao_CTietResult
	{
		
		private string _MaBuuCuc;
		
		private string _MaCRM;
		
		private string _Nhom;
		
		private string _TenNhom;
		
		private string _TenKhachHang;
		
		private System.Nullable<int> _EMS_TNuoc_SL;
		
		private System.Nullable<decimal> _EMS_TNuoc_KL;
		
		private System.Nullable<decimal> _EMS_TNuoc_DT;
		
		private System.Nullable<int> _EMS_QTe_SL;
		
		private System.Nullable<decimal> _EMS_QTe_KL;
		
		private System.Nullable<decimal> _EMS_QTe_DT;
		
		private System.Nullable<int> _EMS_COD_SL;
		
		private System.Nullable<decimal> _EMS_COD_KL;
		
		private System.Nullable<decimal> _EMS_COD_DT;
		
		private System.Nullable<int> _EMS_HCC_SL;
		
		private System.Nullable<decimal> _EMS_HCC_KL;
		
		private System.Nullable<decimal> _EMS_HCC_DT;
		
		private System.Nullable<int> _BK_TNuoc_SL;
		
		private System.Nullable<decimal> _BK_TNuoc_KL;
		
		private System.Nullable<decimal> _BK_TNuoc_DT;
		
		private System.Nullable<int> _BK_QTe_SL;
		
		private System.Nullable<decimal> _BK_QTe_KL;
		
		private System.Nullable<decimal> _BK_QTe_DT;
		
		private System.Nullable<int> _BK_COD_SL;
		
		private System.Nullable<decimal> _BK_COD_KL;
		
		private System.Nullable<decimal> _BK_COD_DT;
		
		private System.Nullable<int> _BPBD_TNuoc_SL;
		
		private System.Nullable<decimal> _BPBD_TNuoc_KL;
		
		private System.Nullable<decimal> _BPBD_TNuoc_DT;
		
		private System.Nullable<int> _BPBD_QTe_SL;
		
		private System.Nullable<decimal> _BPBD_QTe_KL;
		
		private System.Nullable<decimal> _BPBD_QTe_DT;
		
		private System.Nullable<int> _Logis_TNuoc_SL;
		
		private System.Nullable<decimal> _Logis_TNuoc_KL;
		
		private System.Nullable<decimal> _Logis_TNuoc_DT;
		
		private System.Nullable<int> _Logis_COD_SL;
		
		private System.Nullable<decimal> _Logis_COD_KL;
		
		private System.Nullable<decimal> _Logis_COD_DT;
		
		private System.Nullable<int> _KT1_SL;
		
		private System.Nullable<decimal> _KT1_KL;
		
		private System.Nullable<decimal> _KT1_DT;
		
		private System.Nullable<int> _ePacket_SL;
		
		private System.Nullable<decimal> _ePacket_KL;
		
		private System.Nullable<decimal> _ePacket_DT;
		
		private System.Nullable<decimal> _Tong_SL;
		
		private System.Nullable<decimal> _Tong_KL;
		
		private System.Nullable<decimal> _Tong_DT;
		
		public sp_tblDoanhThuKhachHangDichVu_BaoCao_CTietResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaCRM", DbType="NVarChar(20)")]
		public string MaCRM
		{
			get
			{
				return this._MaCRM;
			}
			set
			{
				if ((this._MaCRM != value))
				{
					this._MaCRM = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhom", DbType="NVarChar(100)")]
		public string TenNhom
		{
			get
			{
				return this._TenNhom;
			}
			set
			{
				if ((this._TenNhom != value))
				{
					this._TenNhom = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_TNuoc_SL", DbType="Int")]
		public System.Nullable<int> EMS_TNuoc_SL
		{
			get
			{
				return this._EMS_TNuoc_SL;
			}
			set
			{
				if ((this._EMS_TNuoc_SL != value))
				{
					this._EMS_TNuoc_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_TNuoc_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_TNuoc_KL
		{
			get
			{
				return this._EMS_TNuoc_KL;
			}
			set
			{
				if ((this._EMS_TNuoc_KL != value))
				{
					this._EMS_TNuoc_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_TNuoc_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_TNuoc_DT
		{
			get
			{
				return this._EMS_TNuoc_DT;
			}
			set
			{
				if ((this._EMS_TNuoc_DT != value))
				{
					this._EMS_TNuoc_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_QTe_SL", DbType="Int")]
		public System.Nullable<int> EMS_QTe_SL
		{
			get
			{
				return this._EMS_QTe_SL;
			}
			set
			{
				if ((this._EMS_QTe_SL != value))
				{
					this._EMS_QTe_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_QTe_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_QTe_KL
		{
			get
			{
				return this._EMS_QTe_KL;
			}
			set
			{
				if ((this._EMS_QTe_KL != value))
				{
					this._EMS_QTe_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_QTe_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_QTe_DT
		{
			get
			{
				return this._EMS_QTe_DT;
			}
			set
			{
				if ((this._EMS_QTe_DT != value))
				{
					this._EMS_QTe_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_COD_SL", DbType="Int")]
		public System.Nullable<int> EMS_COD_SL
		{
			get
			{
				return this._EMS_COD_SL;
			}
			set
			{
				if ((this._EMS_COD_SL != value))
				{
					this._EMS_COD_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_COD_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_COD_KL
		{
			get
			{
				return this._EMS_COD_KL;
			}
			set
			{
				if ((this._EMS_COD_KL != value))
				{
					this._EMS_COD_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_COD_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_COD_DT
		{
			get
			{
				return this._EMS_COD_DT;
			}
			set
			{
				if ((this._EMS_COD_DT != value))
				{
					this._EMS_COD_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_HCC_SL", DbType="Int")]
		public System.Nullable<int> EMS_HCC_SL
		{
			get
			{
				return this._EMS_HCC_SL;
			}
			set
			{
				if ((this._EMS_HCC_SL != value))
				{
					this._EMS_HCC_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_HCC_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_HCC_KL
		{
			get
			{
				return this._EMS_HCC_KL;
			}
			set
			{
				if ((this._EMS_HCC_KL != value))
				{
					this._EMS_HCC_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMS_HCC_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> EMS_HCC_DT
		{
			get
			{
				return this._EMS_HCC_DT;
			}
			set
			{
				if ((this._EMS_HCC_DT != value))
				{
					this._EMS_HCC_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_TNuoc_SL", DbType="Int")]
		public System.Nullable<int> BK_TNuoc_SL
		{
			get
			{
				return this._BK_TNuoc_SL;
			}
			set
			{
				if ((this._BK_TNuoc_SL != value))
				{
					this._BK_TNuoc_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_TNuoc_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BK_TNuoc_KL
		{
			get
			{
				return this._BK_TNuoc_KL;
			}
			set
			{
				if ((this._BK_TNuoc_KL != value))
				{
					this._BK_TNuoc_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_TNuoc_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BK_TNuoc_DT
		{
			get
			{
				return this._BK_TNuoc_DT;
			}
			set
			{
				if ((this._BK_TNuoc_DT != value))
				{
					this._BK_TNuoc_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_QTe_SL", DbType="Int")]
		public System.Nullable<int> BK_QTe_SL
		{
			get
			{
				return this._BK_QTe_SL;
			}
			set
			{
				if ((this._BK_QTe_SL != value))
				{
					this._BK_QTe_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_QTe_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BK_QTe_KL
		{
			get
			{
				return this._BK_QTe_KL;
			}
			set
			{
				if ((this._BK_QTe_KL != value))
				{
					this._BK_QTe_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_QTe_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BK_QTe_DT
		{
			get
			{
				return this._BK_QTe_DT;
			}
			set
			{
				if ((this._BK_QTe_DT != value))
				{
					this._BK_QTe_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_COD_SL", DbType="Int")]
		public System.Nullable<int> BK_COD_SL
		{
			get
			{
				return this._BK_COD_SL;
			}
			set
			{
				if ((this._BK_COD_SL != value))
				{
					this._BK_COD_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_COD_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BK_COD_KL
		{
			get
			{
				return this._BK_COD_KL;
			}
			set
			{
				if ((this._BK_COD_KL != value))
				{
					this._BK_COD_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BK_COD_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BK_COD_DT
		{
			get
			{
				return this._BK_COD_DT;
			}
			set
			{
				if ((this._BK_COD_DT != value))
				{
					this._BK_COD_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPBD_TNuoc_SL", DbType="Int")]
		public System.Nullable<int> BPBD_TNuoc_SL
		{
			get
			{
				return this._BPBD_TNuoc_SL;
			}
			set
			{
				if ((this._BPBD_TNuoc_SL != value))
				{
					this._BPBD_TNuoc_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPBD_TNuoc_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BPBD_TNuoc_KL
		{
			get
			{
				return this._BPBD_TNuoc_KL;
			}
			set
			{
				if ((this._BPBD_TNuoc_KL != value))
				{
					this._BPBD_TNuoc_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPBD_TNuoc_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BPBD_TNuoc_DT
		{
			get
			{
				return this._BPBD_TNuoc_DT;
			}
			set
			{
				if ((this._BPBD_TNuoc_DT != value))
				{
					this._BPBD_TNuoc_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPBD_QTe_SL", DbType="Int")]
		public System.Nullable<int> BPBD_QTe_SL
		{
			get
			{
				return this._BPBD_QTe_SL;
			}
			set
			{
				if ((this._BPBD_QTe_SL != value))
				{
					this._BPBD_QTe_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPBD_QTe_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BPBD_QTe_KL
		{
			get
			{
				return this._BPBD_QTe_KL;
			}
			set
			{
				if ((this._BPBD_QTe_KL != value))
				{
					this._BPBD_QTe_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPBD_QTe_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> BPBD_QTe_DT
		{
			get
			{
				return this._BPBD_QTe_DT;
			}
			set
			{
				if ((this._BPBD_QTe_DT != value))
				{
					this._BPBD_QTe_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logis_TNuoc_SL", DbType="Int")]
		public System.Nullable<int> Logis_TNuoc_SL
		{
			get
			{
				return this._Logis_TNuoc_SL;
			}
			set
			{
				if ((this._Logis_TNuoc_SL != value))
				{
					this._Logis_TNuoc_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logis_TNuoc_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Logis_TNuoc_KL
		{
			get
			{
				return this._Logis_TNuoc_KL;
			}
			set
			{
				if ((this._Logis_TNuoc_KL != value))
				{
					this._Logis_TNuoc_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logis_TNuoc_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Logis_TNuoc_DT
		{
			get
			{
				return this._Logis_TNuoc_DT;
			}
			set
			{
				if ((this._Logis_TNuoc_DT != value))
				{
					this._Logis_TNuoc_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logis_COD_SL", DbType="Int")]
		public System.Nullable<int> Logis_COD_SL
		{
			get
			{
				return this._Logis_COD_SL;
			}
			set
			{
				if ((this._Logis_COD_SL != value))
				{
					this._Logis_COD_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logis_COD_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Logis_COD_KL
		{
			get
			{
				return this._Logis_COD_KL;
			}
			set
			{
				if ((this._Logis_COD_KL != value))
				{
					this._Logis_COD_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logis_COD_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Logis_COD_DT
		{
			get
			{
				return this._Logis_COD_DT;
			}
			set
			{
				if ((this._Logis_COD_DT != value))
				{
					this._Logis_COD_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KT1_SL", DbType="Int")]
		public System.Nullable<int> KT1_SL
		{
			get
			{
				return this._KT1_SL;
			}
			set
			{
				if ((this._KT1_SL != value))
				{
					this._KT1_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KT1_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> KT1_KL
		{
			get
			{
				return this._KT1_KL;
			}
			set
			{
				if ((this._KT1_KL != value))
				{
					this._KT1_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KT1_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> KT1_DT
		{
			get
			{
				return this._KT1_DT;
			}
			set
			{
				if ((this._KT1_DT != value))
				{
					this._KT1_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ePacket_SL", DbType="Int")]
		public System.Nullable<int> ePacket_SL
		{
			get
			{
				return this._ePacket_SL;
			}
			set
			{
				if ((this._ePacket_SL != value))
				{
					this._ePacket_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ePacket_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> ePacket_KL
		{
			get
			{
				return this._ePacket_KL;
			}
			set
			{
				if ((this._ePacket_KL != value))
				{
					this._ePacket_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ePacket_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> ePacket_DT
		{
			get
			{
				return this._ePacket_DT;
			}
			set
			{
				if ((this._ePacket_DT != value))
				{
					this._ePacket_DT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tong_SL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Tong_SL
		{
			get
			{
				return this._Tong_SL;
			}
			set
			{
				if ((this._Tong_SL != value))
				{
					this._Tong_SL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tong_KL", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Tong_KL
		{
			get
			{
				return this._Tong_KL;
			}
			set
			{
				if ((this._Tong_KL != value))
				{
					this._Tong_KL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tong_DT", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Tong_DT
		{
			get
			{
				return this._Tong_DT;
			}
			set
			{
				if ((this._Tong_DT != value))
				{
					this._Tong_DT = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
