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
	public partial class linqChiTieuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqChiTieuDataContext() : 
				base(global::daoSLBC.Properties.Settings.Default.SoLieuBaoCaoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqChiTieuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuBaoCao_DanhSach")]
		public ISingleResult<sp_tblChiTieuBaoCao_DanhSachResult> sp_tblChiTieuBaoCao_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDNhom", DbType="Int")] System.Nullable<int> iDNhom)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDNhom);
			return ((ISingleResult<sp_tblChiTieuBaoCao_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblChiTieuBaoCao_ThongTin")]
		public ISingleResult<sp_tblChiTieuBaoCao_ThongTinResult> sp_tblChiTieuBaoCao_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<sp_tblChiTieuBaoCao_ThongTinResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblChiTieuBaoCao_DanhSachResult
	{
		
		private int _ID;
		
		private int _IDBieuBaoCao;
		
		private string _Ma;
		
		private string _Ten;
		
		private System.Nullable<int> _IDDonViTinh;
		
		private string _ThuTu;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		private System.Nullable<decimal> _STTsx;
		
		private System.Nullable<int> _IDChiTieuTren;
		
		private System.Nullable<System.DateTime> _NgayApDung;
		
		private System.Nullable<System.DateTime> _NgayKetThuc;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private string _NguoiTao;
		
		private System.Nullable<bool> _TuDong;
		
		private System.Nullable<int> _IDNhom;
		
		private System.Nullable<bool> _LaChiTieuDoanhThu;
		
		private System.Nullable<bool> _LaChiTieuChiPhi;
		
		public sp_tblChiTieuBaoCao_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBieuBaoCao", DbType="Int NOT NULL")]
		public int IDBieuBaoCao
		{
			get
			{
				return this._IDBieuBaoCao;
			}
			set
			{
				if ((this._IDBieuBaoCao != value))
				{
					this._IDBieuBaoCao = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDonViTinh", DbType="Int")]
		public System.Nullable<int> IDDonViTinh
		{
			get
			{
				return this._IDDonViTinh;
			}
			set
			{
				if ((this._IDDonViTinh != value))
				{
					this._IDDonViTinh = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieuTren", DbType="Int")]
		public System.Nullable<int> IDChiTieuTren
		{
			get
			{
				return this._IDChiTieuTren;
			}
			set
			{
				if ((this._IDChiTieuTren != value))
				{
					this._IDChiTieuTren = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayApDung", DbType="Date")]
		public System.Nullable<System.DateTime> NgayApDung
		{
			get
			{
				return this._NgayApDung;
			}
			set
			{
				if ((this._NgayApDung != value))
				{
					this._NgayApDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayKetThuc", DbType="Date")]
		public System.Nullable<System.DateTime> NgayKetThuc
		{
			get
			{
				return this._NgayKetThuc;
			}
			set
			{
				if ((this._NgayKetThuc != value))
				{
					this._NgayKetThuc = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TuDong", DbType="Bit")]
		public System.Nullable<bool> TuDong
		{
			get
			{
				return this._TuDong;
			}
			set
			{
				if ((this._TuDong != value))
				{
					this._TuDong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNhom", DbType="Int")]
		public System.Nullable<int> IDNhom
		{
			get
			{
				return this._IDNhom;
			}
			set
			{
				if ((this._IDNhom != value))
				{
					this._IDNhom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaChiTieuDoanhThu", DbType="Bit")]
		public System.Nullable<bool> LaChiTieuDoanhThu
		{
			get
			{
				return this._LaChiTieuDoanhThu;
			}
			set
			{
				if ((this._LaChiTieuDoanhThu != value))
				{
					this._LaChiTieuDoanhThu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaChiTieuChiPhi", DbType="Bit")]
		public System.Nullable<bool> LaChiTieuChiPhi
		{
			get
			{
				return this._LaChiTieuChiPhi;
			}
			set
			{
				if ((this._LaChiTieuChiPhi != value))
				{
					this._LaChiTieuChiPhi = value;
				}
			}
		}
	}
	
	public partial class sp_tblChiTieuBaoCao_ThongTinResult
	{
		
		private int _ID;
		
		private int _IDBieuBaoCao;
		
		private string _Ma;
		
		private string _Ten;
		
		private System.Nullable<int> _IDDonViTinh;
		
		private string _ThuTu;
		
		private System.Nullable<bool> _InDam;
		
		private System.Nullable<bool> _InNghieng;
		
		private System.Nullable<decimal> _STTsx;
		
		private System.Nullable<int> _IDChiTieuTren;
		
		private System.Nullable<System.DateTime> _NgayApDung;
		
		private System.Nullable<System.DateTime> _NgayKetThuc;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private string _NguoiTao;
		
		private System.Nullable<bool> _TuDong;
		
		private System.Nullable<int> _IDNhom;
		
		private System.Nullable<bool> _LaChiTieuDoanhThu;
		
		private System.Nullable<bool> _LaChiTieuChiPhi;
		
		public sp_tblChiTieuBaoCao_ThongTinResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBieuBaoCao", DbType="Int NOT NULL")]
		public int IDBieuBaoCao
		{
			get
			{
				return this._IDBieuBaoCao;
			}
			set
			{
				if ((this._IDBieuBaoCao != value))
				{
					this._IDBieuBaoCao = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDonViTinh", DbType="Int")]
		public System.Nullable<int> IDDonViTinh
		{
			get
			{
				return this._IDDonViTinh;
			}
			set
			{
				if ((this._IDDonViTinh != value))
				{
					this._IDDonViTinh = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChiTieuTren", DbType="Int")]
		public System.Nullable<int> IDChiTieuTren
		{
			get
			{
				return this._IDChiTieuTren;
			}
			set
			{
				if ((this._IDChiTieuTren != value))
				{
					this._IDChiTieuTren = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayApDung", DbType="Date")]
		public System.Nullable<System.DateTime> NgayApDung
		{
			get
			{
				return this._NgayApDung;
			}
			set
			{
				if ((this._NgayApDung != value))
				{
					this._NgayApDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayKetThuc", DbType="Date")]
		public System.Nullable<System.DateTime> NgayKetThuc
		{
			get
			{
				return this._NgayKetThuc;
			}
			set
			{
				if ((this._NgayKetThuc != value))
				{
					this._NgayKetThuc = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TuDong", DbType="Bit")]
		public System.Nullable<bool> TuDong
		{
			get
			{
				return this._TuDong;
			}
			set
			{
				if ((this._TuDong != value))
				{
					this._TuDong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNhom", DbType="Int")]
		public System.Nullable<int> IDNhom
		{
			get
			{
				return this._IDNhom;
			}
			set
			{
				if ((this._IDNhom != value))
				{
					this._IDNhom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaChiTieuDoanhThu", DbType="Bit")]
		public System.Nullable<bool> LaChiTieuDoanhThu
		{
			get
			{
				return this._LaChiTieuDoanhThu;
			}
			set
			{
				if ((this._LaChiTieuDoanhThu != value))
				{
					this._LaChiTieuDoanhThu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaChiTieuChiPhi", DbType="Bit")]
		public System.Nullable<bool> LaChiTieuChiPhi
		{
			get
			{
				return this._LaChiTieuChiPhi;
			}
			set
			{
				if ((this._LaChiTieuChiPhi != value))
				{
					this._LaChiTieuChiPhi = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
