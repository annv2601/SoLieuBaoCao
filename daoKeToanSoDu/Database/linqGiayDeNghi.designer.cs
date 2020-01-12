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

namespace daoKeToanSoDu.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KeToanSoDu")]
	public partial class linqGiayDeNghiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqGiayDeNghiDataContext() : 
				base(global::daoKeToanSoDu.Properties.Settings.Default.KeToanSoDuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqGiayDeNghiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqGiayDeNghiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqGiayDeNghiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqGiayDeNghiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblGiayDeNghiTiepQuy_CapNhatAnhBanKy")]
		public int sp_tblGiayDeNghiTiepQuy_CapNhatAnhBanKy([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKeToanNgay", DbType="NVarChar(20)")] string maKeToanNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(250)")] string urlAnhBanIn)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKeToanNgay, urlAnhBanIn);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblGiayDeNghiTiepQuy_ThongTin")]
		public ISingleResult<sp_tblGiayDeNghiTiepQuy_ThongTinResult> sp_tblGiayDeNghiTiepQuy_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKeToanNgay", DbType="NVarChar(20)")] string maKeToanNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKeToanNgay);
			return ((ISingleResult<sp_tblGiayDeNghiTiepQuy_ThongTinResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblGiayDeNghiTiepQuy_ThemSua")]
		public int sp_tblGiayDeNghiTiepQuy_ThemSua(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKeToanNgay", DbType="NVarChar(20)")] string maKeToanNgay, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoiDung", DbType="NVarChar(250)")] string noiDung, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TrinhDonVi", DbType="NVarChar(150)")] string trinhDonVi, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoTienDeNghi", DbType="Decimal(22,0)")] System.Nullable<decimal> soTienDeNghi, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BangChu", DbType="NVarChar(250)")] string bangChu, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDNganHang", DbType="Int")] System.Nullable<int> iDNganHang, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DuKienChiTra", DbType="Decimal(22,0)")] System.Nullable<decimal> duKienChiTra, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(22,0)")] System.Nullable<decimal> dkctBangTienMat, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(22,0)")] System.Nullable<decimal> dkctBangChuyenKhoan, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoTienVayQuyKhac", DbType="Decimal(22,0)")] System.Nullable<decimal> soTienVayQuyKhac, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoTienQuyKhacVay", DbType="Decimal(22,0)")] System.Nullable<decimal> soTienQuyKhacVay, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TongSoDuTien", DbType="Decimal(22,0)")] System.Nullable<decimal> tongSoDuTien, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoDuTienMat", DbType="Decimal(22,0)")] System.Nullable<decimal> soDuTienMat, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoDuTienMatTaiBuuCuc", DbType="Decimal(22,0)")] System.Nullable<decimal> soDuTienMatTaiBuuCuc, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoDuTienMatTaiBDH", DbType="Decimal(22,0)")] System.Nullable<decimal> soDuTienMatTaiBDH, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoDuTGNH", DbType="Decimal(22,0)")] System.Nullable<decimal> soDuTGNH, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoDuTienDangChuyen", DbType="Decimal(22,0)")] System.Nullable<decimal> soDuTienDangChuyen, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoiLuuVB", DbType="NVarChar(50)")] string noiLuuVB)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKeToanNgay, maDonVi, ngay, noiDung, trinhDonVi, soTienDeNghi, bangChu, iDNganHang, duKienChiTra, dkctBangTienMat, dkctBangChuyenKhoan, soTienVayQuyKhac, soTienQuyKhacVay, tongSoDuTien, soDuTienMat, soDuTienMatTaiBuuCuc, soDuTienMatTaiBDH, soDuTGNH, soDuTienDangChuyen, noiLuuVB);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblGiayDeNghiTiepQuy_DanhSach")]
		public ISingleResult<sp_tblGiayDeNghiTiepQuy_DanhSachResult> sp_tblGiayDeNghiTiepQuy_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaDonVi", DbType="NVarChar(10)")] string maDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maDonVi, tuNgay, denNgay);
			return ((ISingleResult<sp_tblGiayDeNghiTiepQuy_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblGiayDeNghiTiepQuy_DanhSachDonVi")]
		public ISingleResult<sp_tblGiayDeNghiTiepQuy_DanhSachDonViResult> sp_tblGiayDeNghiTiepQuy_DanhSachDonVi([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tuNgay, denNgay);
			return ((ISingleResult<sp_tblGiayDeNghiTiepQuy_DanhSachDonViResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblGiayDeNghiTiepQuy_ThongTinResult
	{
		
		private string _MaKeToanNgay;
		
		private string _MaDonVi;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private string _NoiDung;
		
		private string _TrinhDonVi;
		
		private System.Nullable<decimal> _SoTienDeNghi;
		
		private string _BangChu;
		
		private System.Nullable<int> _IDNganHang;
		
		private System.Nullable<decimal> _DuKienChiTra;
		
		private System.Nullable<decimal> _dkctBangTienMat;
		
		private System.Nullable<decimal> _dkctBangChuyenKhoan;
		
		private System.Nullable<decimal> _SoTienVayQuyKhac;
		
		private System.Nullable<decimal> _SoTienQuyKhacVay;
		
		private System.Nullable<decimal> _TongSoDuTien;
		
		private System.Nullable<decimal> _SoDuTienMat;
		
		private System.Nullable<decimal> _SoDuTienMatTaiBuuCuc;
		
		private System.Nullable<decimal> _SoDuTienMatTaiBDH;
		
		private System.Nullable<decimal> _SoDuTGNH;
		
		private System.Nullable<decimal> _SoDuTienDangChuyen;
		
		private string _urlAnhBanIn;
		
		private string _NoiLuuVB;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		public sp_tblGiayDeNghiTiepQuy_ThongTinResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKeToanNgay", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MaKeToanNgay
		{
			get
			{
				return this._MaKeToanNgay;
			}
			set
			{
				if ((this._MaKeToanNgay != value))
				{
					this._MaKeToanNgay = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(250)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrinhDonVi", DbType="NVarChar(150)")]
		public string TrinhDonVi
		{
			get
			{
				return this._TrinhDonVi;
			}
			set
			{
				if ((this._TrinhDonVi != value))
				{
					this._TrinhDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienDeNghi", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienDeNghi
		{
			get
			{
				return this._SoTienDeNghi;
			}
			set
			{
				if ((this._SoTienDeNghi != value))
				{
					this._SoTienDeNghi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BangChu", DbType="NVarChar(250)")]
		public string BangChu
		{
			get
			{
				return this._BangChu;
			}
			set
			{
				if ((this._BangChu != value))
				{
					this._BangChu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNganHang", DbType="Int")]
		public System.Nullable<int> IDNganHang
		{
			get
			{
				return this._IDNganHang;
			}
			set
			{
				if ((this._IDNganHang != value))
				{
					this._IDNganHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DuKienChiTra", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DuKienChiTra
		{
			get
			{
				return this._DuKienChiTra;
			}
			set
			{
				if ((this._DuKienChiTra != value))
				{
					this._DuKienChiTra = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dkctBangTienMat", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> dkctBangTienMat
		{
			get
			{
				return this._dkctBangTienMat;
			}
			set
			{
				if ((this._dkctBangTienMat != value))
				{
					this._dkctBangTienMat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dkctBangChuyenKhoan", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> dkctBangChuyenKhoan
		{
			get
			{
				return this._dkctBangChuyenKhoan;
			}
			set
			{
				if ((this._dkctBangChuyenKhoan != value))
				{
					this._dkctBangChuyenKhoan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienVayQuyKhac", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienVayQuyKhac
		{
			get
			{
				return this._SoTienVayQuyKhac;
			}
			set
			{
				if ((this._SoTienVayQuyKhac != value))
				{
					this._SoTienVayQuyKhac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienQuyKhacVay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienQuyKhacVay
		{
			get
			{
				return this._SoTienQuyKhacVay;
			}
			set
			{
				if ((this._SoTienQuyKhacVay != value))
				{
					this._SoTienQuyKhacVay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongSoDuTien", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> TongSoDuTien
		{
			get
			{
				return this._TongSoDuTien;
			}
			set
			{
				if ((this._TongSoDuTien != value))
				{
					this._TongSoDuTien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMat", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMat
		{
			get
			{
				return this._SoDuTienMat;
			}
			set
			{
				if ((this._SoDuTienMat != value))
				{
					this._SoDuTienMat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMatTaiBuuCuc", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMatTaiBuuCuc
		{
			get
			{
				return this._SoDuTienMatTaiBuuCuc;
			}
			set
			{
				if ((this._SoDuTienMatTaiBuuCuc != value))
				{
					this._SoDuTienMatTaiBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMatTaiBDH", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMatTaiBDH
		{
			get
			{
				return this._SoDuTienMatTaiBDH;
			}
			set
			{
				if ((this._SoDuTienMatTaiBDH != value))
				{
					this._SoDuTienMatTaiBDH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTGNH", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTGNH
		{
			get
			{
				return this._SoDuTGNH;
			}
			set
			{
				if ((this._SoDuTGNH != value))
				{
					this._SoDuTGNH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienDangChuyen", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienDangChuyen
		{
			get
			{
				return this._SoDuTienDangChuyen;
			}
			set
			{
				if ((this._SoDuTienDangChuyen != value))
				{
					this._SoDuTienDangChuyen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_urlAnhBanIn", DbType="NVarChar(250)")]
		public string urlAnhBanIn
		{
			get
			{
				return this._urlAnhBanIn;
			}
			set
			{
				if ((this._urlAnhBanIn != value))
				{
					this._urlAnhBanIn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiLuuVB", DbType="NVarChar(50)")]
		public string NoiLuuVB
		{
			get
			{
				return this._NoiLuuVB;
			}
			set
			{
				if ((this._NoiLuuVB != value))
				{
					this._NoiLuuVB = value;
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
	}
	
	public partial class sp_tblGiayDeNghiTiepQuy_DanhSachResult
	{
		
		private string _MaKeToanNgay;
		
		private string _MaDonVi;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private string _NoiDung;
		
		private string _TrinhDonVi;
		
		private System.Nullable<decimal> _SoTienDeNghi;
		
		private string _BangChu;
		
		private System.Nullable<int> _IDNganHang;
		
		private string _TenDonViHuong;
		
		private string _SoTaiKhoan;
		
		private string _NganHang;
		
		private string _PhongGiaoDich;
		
		private System.Nullable<decimal> _DuKienChiTra;
		
		private System.Nullable<decimal> _dkctBangTienMat;
		
		private System.Nullable<decimal> _dkctBangChuyenKhoan;
		
		private System.Nullable<decimal> _SoTienVayQuyKhac;
		
		private System.Nullable<decimal> _SoTienQuyKhacVay;
		
		private System.Nullable<decimal> _TongSoDuTien;
		
		private System.Nullable<decimal> _SoDuTienMat;
		
		private System.Nullable<decimal> _SoDuTienMatTaiBuuCuc;
		
		private System.Nullable<decimal> _SoDuTienMatTaiBDH;
		
		private System.Nullable<decimal> _SoDuTGNH;
		
		private System.Nullable<decimal> _SoDuTienDangChuyen;
		
		private string _urlAnhBanIn;
		
		private string _NoiLuuVB;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		public sp_tblGiayDeNghiTiepQuy_DanhSachResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKeToanNgay", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MaKeToanNgay
		{
			get
			{
				return this._MaKeToanNgay;
			}
			set
			{
				if ((this._MaKeToanNgay != value))
				{
					this._MaKeToanNgay = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(250)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrinhDonVi", DbType="NVarChar(150)")]
		public string TrinhDonVi
		{
			get
			{
				return this._TrinhDonVi;
			}
			set
			{
				if ((this._TrinhDonVi != value))
				{
					this._TrinhDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienDeNghi", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienDeNghi
		{
			get
			{
				return this._SoTienDeNghi;
			}
			set
			{
				if ((this._SoTienDeNghi != value))
				{
					this._SoTienDeNghi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BangChu", DbType="NVarChar(250)")]
		public string BangChu
		{
			get
			{
				return this._BangChu;
			}
			set
			{
				if ((this._BangChu != value))
				{
					this._BangChu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNganHang", DbType="Int")]
		public System.Nullable<int> IDNganHang
		{
			get
			{
				return this._IDNganHang;
			}
			set
			{
				if ((this._IDNganHang != value))
				{
					this._IDNganHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonViHuong", DbType="NVarChar(250)")]
		public string TenDonViHuong
		{
			get
			{
				return this._TenDonViHuong;
			}
			set
			{
				if ((this._TenDonViHuong != value))
				{
					this._TenDonViHuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTaiKhoan", DbType="NVarChar(20)")]
		public string SoTaiKhoan
		{
			get
			{
				return this._SoTaiKhoan;
			}
			set
			{
				if ((this._SoTaiKhoan != value))
				{
					this._SoTaiKhoan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NganHang", DbType="NVarChar(150)")]
		public string NganHang
		{
			get
			{
				return this._NganHang;
			}
			set
			{
				if ((this._NganHang != value))
				{
					this._NganHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhongGiaoDich", DbType="NVarChar(150)")]
		public string PhongGiaoDich
		{
			get
			{
				return this._PhongGiaoDich;
			}
			set
			{
				if ((this._PhongGiaoDich != value))
				{
					this._PhongGiaoDich = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DuKienChiTra", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DuKienChiTra
		{
			get
			{
				return this._DuKienChiTra;
			}
			set
			{
				if ((this._DuKienChiTra != value))
				{
					this._DuKienChiTra = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dkctBangTienMat", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> dkctBangTienMat
		{
			get
			{
				return this._dkctBangTienMat;
			}
			set
			{
				if ((this._dkctBangTienMat != value))
				{
					this._dkctBangTienMat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dkctBangChuyenKhoan", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> dkctBangChuyenKhoan
		{
			get
			{
				return this._dkctBangChuyenKhoan;
			}
			set
			{
				if ((this._dkctBangChuyenKhoan != value))
				{
					this._dkctBangChuyenKhoan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienVayQuyKhac", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienVayQuyKhac
		{
			get
			{
				return this._SoTienVayQuyKhac;
			}
			set
			{
				if ((this._SoTienVayQuyKhac != value))
				{
					this._SoTienVayQuyKhac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienQuyKhacVay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienQuyKhacVay
		{
			get
			{
				return this._SoTienQuyKhacVay;
			}
			set
			{
				if ((this._SoTienQuyKhacVay != value))
				{
					this._SoTienQuyKhacVay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongSoDuTien", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> TongSoDuTien
		{
			get
			{
				return this._TongSoDuTien;
			}
			set
			{
				if ((this._TongSoDuTien != value))
				{
					this._TongSoDuTien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMat", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMat
		{
			get
			{
				return this._SoDuTienMat;
			}
			set
			{
				if ((this._SoDuTienMat != value))
				{
					this._SoDuTienMat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMatTaiBuuCuc", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMatTaiBuuCuc
		{
			get
			{
				return this._SoDuTienMatTaiBuuCuc;
			}
			set
			{
				if ((this._SoDuTienMatTaiBuuCuc != value))
				{
					this._SoDuTienMatTaiBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMatTaiBDH", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMatTaiBDH
		{
			get
			{
				return this._SoDuTienMatTaiBDH;
			}
			set
			{
				if ((this._SoDuTienMatTaiBDH != value))
				{
					this._SoDuTienMatTaiBDH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTGNH", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTGNH
		{
			get
			{
				return this._SoDuTGNH;
			}
			set
			{
				if ((this._SoDuTGNH != value))
				{
					this._SoDuTGNH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienDangChuyen", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienDangChuyen
		{
			get
			{
				return this._SoDuTienDangChuyen;
			}
			set
			{
				if ((this._SoDuTienDangChuyen != value))
				{
					this._SoDuTienDangChuyen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_urlAnhBanIn", DbType="NVarChar(250)")]
		public string urlAnhBanIn
		{
			get
			{
				return this._urlAnhBanIn;
			}
			set
			{
				if ((this._urlAnhBanIn != value))
				{
					this._urlAnhBanIn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiLuuVB", DbType="NVarChar(50)")]
		public string NoiLuuVB
		{
			get
			{
				return this._NoiLuuVB;
			}
			set
			{
				if ((this._NoiLuuVB != value))
				{
					this._NoiLuuVB = value;
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
	}
	
	public partial class sp_tblGiayDeNghiTiepQuy_DanhSachDonViResult
	{
		
		private string _MaKeToanNgay;
		
		private string _MaDonVi;
		
		private string _TenDonVi;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private string _NoiDung;
		
		private string _TrinhDonVi;
		
		private System.Nullable<decimal> _SoTienDeNghi;
		
		private string _BangChu;
		
		private System.Nullable<int> _IDNganHang;
		
		private string _TenDonViHuong;
		
		private string _SoTaiKhoan;
		
		private string _NganHang;
		
		private string _PhongGiaoDich;
		
		private System.Nullable<decimal> _DuKienChiTra;
		
		private System.Nullable<decimal> _dkctBangTienMat;
		
		private System.Nullable<decimal> _dkctBangChuyenKhoan;
		
		private System.Nullable<decimal> _SoTienVayQuyKhac;
		
		private System.Nullable<decimal> _SoTienQuyKhacVay;
		
		private System.Nullable<decimal> _TongSoDuTien;
		
		private System.Nullable<decimal> _SoDuTienMat;
		
		private System.Nullable<decimal> _SoDuTienMatTaiBuuCuc;
		
		private System.Nullable<decimal> _SoDuTienMatTaiBDH;
		
		private System.Nullable<decimal> _SoDuTGNH;
		
		private System.Nullable<decimal> _SoDuTienDangChuyen;
		
		private string _urlAnhBanIn;
		
		private string _NoiLuuVB;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		public sp_tblGiayDeNghiTiepQuy_DanhSachDonViResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKeToanNgay", DbType="NVarChar(20)")]
		public string MaKeToanNgay
		{
			get
			{
				return this._MaKeToanNgay;
			}
			set
			{
				if ((this._MaKeToanNgay != value))
				{
					this._MaKeToanNgay = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonVi", DbType="NVarChar(80)")]
		public string TenDonVi
		{
			get
			{
				return this._TenDonVi;
			}
			set
			{
				if ((this._TenDonVi != value))
				{
					this._TenDonVi = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(250)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrinhDonVi", DbType="NVarChar(150)")]
		public string TrinhDonVi
		{
			get
			{
				return this._TrinhDonVi;
			}
			set
			{
				if ((this._TrinhDonVi != value))
				{
					this._TrinhDonVi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienDeNghi", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienDeNghi
		{
			get
			{
				return this._SoTienDeNghi;
			}
			set
			{
				if ((this._SoTienDeNghi != value))
				{
					this._SoTienDeNghi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BangChu", DbType="NVarChar(250)")]
		public string BangChu
		{
			get
			{
				return this._BangChu;
			}
			set
			{
				if ((this._BangChu != value))
				{
					this._BangChu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNganHang", DbType="Int")]
		public System.Nullable<int> IDNganHang
		{
			get
			{
				return this._IDNganHang;
			}
			set
			{
				if ((this._IDNganHang != value))
				{
					this._IDNganHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonViHuong", DbType="NVarChar(250)")]
		public string TenDonViHuong
		{
			get
			{
				return this._TenDonViHuong;
			}
			set
			{
				if ((this._TenDonViHuong != value))
				{
					this._TenDonViHuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTaiKhoan", DbType="NVarChar(20)")]
		public string SoTaiKhoan
		{
			get
			{
				return this._SoTaiKhoan;
			}
			set
			{
				if ((this._SoTaiKhoan != value))
				{
					this._SoTaiKhoan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NganHang", DbType="NVarChar(150)")]
		public string NganHang
		{
			get
			{
				return this._NganHang;
			}
			set
			{
				if ((this._NganHang != value))
				{
					this._NganHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhongGiaoDich", DbType="NVarChar(150)")]
		public string PhongGiaoDich
		{
			get
			{
				return this._PhongGiaoDich;
			}
			set
			{
				if ((this._PhongGiaoDich != value))
				{
					this._PhongGiaoDich = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DuKienChiTra", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> DuKienChiTra
		{
			get
			{
				return this._DuKienChiTra;
			}
			set
			{
				if ((this._DuKienChiTra != value))
				{
					this._DuKienChiTra = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dkctBangTienMat", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> dkctBangTienMat
		{
			get
			{
				return this._dkctBangTienMat;
			}
			set
			{
				if ((this._dkctBangTienMat != value))
				{
					this._dkctBangTienMat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dkctBangChuyenKhoan", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> dkctBangChuyenKhoan
		{
			get
			{
				return this._dkctBangChuyenKhoan;
			}
			set
			{
				if ((this._dkctBangChuyenKhoan != value))
				{
					this._dkctBangChuyenKhoan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienVayQuyKhac", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienVayQuyKhac
		{
			get
			{
				return this._SoTienVayQuyKhac;
			}
			set
			{
				if ((this._SoTienVayQuyKhac != value))
				{
					this._SoTienVayQuyKhac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienQuyKhacVay", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoTienQuyKhacVay
		{
			get
			{
				return this._SoTienQuyKhacVay;
			}
			set
			{
				if ((this._SoTienQuyKhacVay != value))
				{
					this._SoTienQuyKhacVay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongSoDuTien", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> TongSoDuTien
		{
			get
			{
				return this._TongSoDuTien;
			}
			set
			{
				if ((this._TongSoDuTien != value))
				{
					this._TongSoDuTien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMat", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMat
		{
			get
			{
				return this._SoDuTienMat;
			}
			set
			{
				if ((this._SoDuTienMat != value))
				{
					this._SoDuTienMat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMatTaiBuuCuc", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMatTaiBuuCuc
		{
			get
			{
				return this._SoDuTienMatTaiBuuCuc;
			}
			set
			{
				if ((this._SoDuTienMatTaiBuuCuc != value))
				{
					this._SoDuTienMatTaiBuuCuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienMatTaiBDH", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienMatTaiBDH
		{
			get
			{
				return this._SoDuTienMatTaiBDH;
			}
			set
			{
				if ((this._SoDuTienMatTaiBDH != value))
				{
					this._SoDuTienMatTaiBDH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTGNH", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTGNH
		{
			get
			{
				return this._SoDuTGNH;
			}
			set
			{
				if ((this._SoDuTGNH != value))
				{
					this._SoDuTGNH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDuTienDangChuyen", DbType="Decimal(22,0)")]
		public System.Nullable<decimal> SoDuTienDangChuyen
		{
			get
			{
				return this._SoDuTienDangChuyen;
			}
			set
			{
				if ((this._SoDuTienDangChuyen != value))
				{
					this._SoDuTienDangChuyen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_urlAnhBanIn", DbType="NVarChar(250)")]
		public string urlAnhBanIn
		{
			get
			{
				return this._urlAnhBanIn;
			}
			set
			{
				if ((this._urlAnhBanIn != value))
				{
					this._urlAnhBanIn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiLuuVB", DbType="NVarChar(50)")]
		public string NoiLuuVB
		{
			get
			{
				return this._NoiLuuVB;
			}
			set
			{
				if ((this._NoiLuuVB != value))
				{
					this._NoiLuuVB = value;
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
	}
}
#pragma warning restore 1591
