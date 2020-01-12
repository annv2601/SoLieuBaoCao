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
	public partial class linqDuLieuBaocaoTapHopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqDuLieuBaocaoTapHopDataContext() : 
				base(global::daoSLBC.Properties.Settings.Default.SoLieuBaoCaoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaocaoTapHopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaocaoTapHopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaocaoTapHopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDuLieuBaocaoTapHopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoNhanhTapHop_ChiTietDonVi")]
		public ISingleResult<clsChiTietDonViTapHop> sp_tblDuLieuBaoCaoNhanhTapHop_ChiTietDonVi([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LoaiDuLieu", DbType="Int")] System.Nullable<int> loaiDuLieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao, loaiDuLieu);
			return ((ISingleResult<clsChiTietDonViTapHop>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoNhanhTapHop_TapHop")]
		public int sp_tblDuLieuBaoCaoNhanhTapHop_TapHop([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LaBCN", DbType="Bit")] System.Nullable<bool> laBCN)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao, laBCN);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCao")]
		public ISingleResult<sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCaoResult> sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCao([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nam", DbType="Int")] System.Nullable<int> nam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao, nam, maDonVi);
			return ((ISingleResult<sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCaoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoNhanhTapHop_KhoiTao")]
		public int sp_tblDuLieuBaoCaoNhanhTapHop_KhoiTao([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMauBieu", DbType="Int")] System.Nullable<int> iDMauBieu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao, iDMauBieu);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoNhanhTapHop_CapNhatBaoCao")]
		public int sp_tblDuLieuBaoCaoNhanhTapHop_CapNhatBaoCao([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoLieuNhap", DbType="Decimal(25,3)")] System.Nullable<decimal> soLieuNhap, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiNhapBCN", DbType="NVarChar(50)")] string nguoiNhapBCN)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao, iDChiTieu, soLieuNhap, nguoiNhapBCN);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblDuLieuBaoCaoNhanhTapHop_CapNhatThucHien")]
		public int sp_tblDuLieuBaoCaoNhanhTapHop_CapNhatThucHien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBieuBaoCao", DbType="NVarChar(16)")] string maBieuBaoCao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDChiTieu", DbType="Int")] System.Nullable<int> iDChiTieu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoLieuThucHien", DbType="Decimal(25,3)")] System.Nullable<decimal> soLieuThucHien, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiNhapTH", DbType="NVarChar(50)")] string nguoiNhapTH)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBieuBaoCao, iDChiTieu, soLieuThucHien, nguoiNhapTH);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCaoResult
	{
		
		private string _MaBieuBaoCao;
		
		private int _IDChiTieu;
		
		private string _ThuTu;
		
		private string _TenChiTieu;
		
		private string _MaSoChiTieu;
		
		private System.Nullable<decimal> _KeHoachGiao;
		
		private System.Nullable<decimal> _SoLieuSTK1;
		
		private System.Nullable<decimal> _SoLieuNhap;
		
		private System.Nullable<decimal> _SoLieuPhanBo;
		
		private System.Nullable<decimal> _CongSoLieuBCN;
		
		private System.Nullable<decimal> _SoLieuThucHien;
		
		private System.Nullable<decimal> _STTsx;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		private bool _NhapTay;
		
		public sp_tblDuLieuBaoCaoNhanhTapHop_DanhSachBaoCaoResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSoChiTieu", DbType="NVarChar(20)")]
		public string MaSoChiTieu
		{
			get
			{
				return this._MaSoChiTieu;
			}
			set
			{
				if ((this._MaSoChiTieu != value))
				{
					this._MaSoChiTieu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeHoachGiao", DbType="Decimal(25,0)")]
		public System.Nullable<decimal> KeHoachGiao
		{
			get
			{
				return this._KeHoachGiao;
			}
			set
			{
				if ((this._KeHoachGiao != value))
				{
					this._KeHoachGiao = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLieuSTK1", DbType="Decimal(25,3)")]
		public System.Nullable<decimal> SoLieuSTK1
		{
			get
			{
				return this._SoLieuSTK1;
			}
			set
			{
				if ((this._SoLieuSTK1 != value))
				{
					this._SoLieuSTK1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLieuNhap", DbType="Decimal(25,3)")]
		public System.Nullable<decimal> SoLieuNhap
		{
			get
			{
				return this._SoLieuNhap;
			}
			set
			{
				if ((this._SoLieuNhap != value))
				{
					this._SoLieuNhap = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLieuPhanBo", DbType="Decimal(25,3)")]
		public System.Nullable<decimal> SoLieuPhanBo
		{
			get
			{
				return this._SoLieuPhanBo;
			}
			set
			{
				if ((this._SoLieuPhanBo != value))
				{
					this._SoLieuPhanBo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongSoLieuBCN", DbType="Decimal(26,3)")]
		public System.Nullable<decimal> CongSoLieuBCN
		{
			get
			{
				return this._CongSoLieuBCN;
			}
			set
			{
				if ((this._CongSoLieuBCN != value))
				{
					this._CongSoLieuBCN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLieuThucHien", DbType="Decimal(25,3)")]
		public System.Nullable<decimal> SoLieuThucHien
		{
			get
			{
				return this._SoLieuThucHien;
			}
			set
			{
				if ((this._SoLieuThucHien != value))
				{
					this._SoLieuThucHien = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhapTay", DbType="Bit NOT NULL")]
		public bool NhapTay
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
	}
}
#pragma warning restore 1591