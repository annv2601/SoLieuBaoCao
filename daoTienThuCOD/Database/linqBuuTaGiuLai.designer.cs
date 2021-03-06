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
	public partial class linqBuuTaGiuLaiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public linqBuuTaGiuLaiDataContext() : 
				base(global::daoTienThuCOD.Properties.Settings.Default.TienCODConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqBuuTaGiuLaiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqBuuTaGiuLaiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqBuuTaGiuLaiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqBuuTaGiuLaiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBuuTaGiuLai_DanhSach")]
		public ISingleResult<sp_tblBuuTaGiuLai_DanhSachResult> sp_tblBuuTaGiuLai_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, tuNgay, denNgay);
			return ((ISingleResult<sp_tblBuuTaGiuLai_DanhSachResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBuuTaGiuLai_Xoa")]
		public int sp_tblBuuTaGiuLai_Xoa([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ItemCode", DbType="NVarChar(20)")] string itemCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, itemCode, ngay);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBuuTaGiuLai_Them")]
		public int sp_tblBuuTaGiuLai_Them(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ngay", DbType="Date")] System.Nullable<System.DateTime> ngay, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FromPoscode", DbType="NVarChar(10)")] string fromPoscode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ItemCode", DbType="NVarChar(20)")] string itemCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ServiceCode", DbType="NVarChar(5)")] string serviceCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ToPoscode", DbType="NVarChar(10)")] string toPoscode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MailTripNumber", DbType="Int")] System.Nullable<int> mailTripNumber, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PostBagNumber", DbType="Int")] System.Nullable<int> postBagNumber, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PostBagTypeCode", DbType="NVarChar(10)")] string postBagTypeCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IncomingDate", DbType="DateTime")] System.Nullable<System.DateTime> incomingDate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Year", DbType="NVarChar(8)")] string year, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PostmanCode", DbType="NVarChar(30)")] string postmanCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullName", DbType="NVarChar(50)")] string fullName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeliverRouteName", DbType="NVarChar(20)")] string deliverRouteName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReceiverFullname", DbType="NVarChar(250)")] string receiverFullname, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReceiverAddress", DbType="NVarChar(250)")] string receiverAddress, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReceiverTel", DbType="NVarChar(50)")] string receiverTel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Weight", DbType="Float")] System.Nullable<double> weight, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="WeightConvert", DbType="Float")] System.Nullable<double> weightConvert, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SendingContent", DbType="NVarChar(250)")] string sendingContent, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Value", DbType="Float")] System.Nullable<double> value, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuTa", DbType="NVarChar(30)")] string maBuuTa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ngay, fromPoscode, itemCode, serviceCode, toPoscode, mailTripNumber, postBagNumber, postBagTypeCode, incomingDate, year, postmanCode, fullName, deliverRouteName, receiverFullname, receiverAddress, receiverTel, weight, weightConvert, sendingContent, value, maBuuTa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBuuTaGiuLai_ThongTin")]
		public ISingleResult<sp_tblBuuTaGiuLai_ThongTinResult> sp_tblBuuTaGiuLai_ThongTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ItemCode", DbType="NVarChar(20)")] string itemCode)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, itemCode);
			return ((ISingleResult<sp_tblBuuTaGiuLai_ThongTinResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_tblBuuTaTraLai_DanhSach")]
		public ISingleResult<sp_tblBuuTaTraLai_DanhSachResult> sp_tblBuuTaTraLai_DanhSach([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuCuc", DbType="NVarChar(10)")] string maBuuCuc, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBuuTa", DbType="NVarChar(30)")] string maBuuTa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="Date")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="Date")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBuuCuc, maBuuTa, tuNgay, denNgay);
			return ((ISingleResult<sp_tblBuuTaTraLai_DanhSachResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_tblBuuTaGiuLai_DanhSachResult
	{
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private string _FromPoscode;
		
		private string _ItemCode;
		
		private string _ServiceCode;
		
		private string _ToPoscode;
		
		private System.Nullable<int> _MailTripNumber;
		
		private System.Nullable<int> _PostBagNumber;
		
		private string _PostBagTypeCode;
		
		private System.Nullable<System.DateTime> _IncomingDate;
		
		private string _Year;
		
		private string _PostmanCode;
		
		private string _FullName;
		
		private string _DeliverRouteName;
		
		private string _ReceiverFullname;
		
		private string _ReceiverAddress;
		
		private string _ReceiverTel;
		
		private System.Nullable<double> _Weight;
		
		private System.Nullable<double> _WeightConvert;
		
		private string _SendingContent;
		
		private System.Nullable<double> _Value;
		
		private string _MaBuuTa;
		
		private System.Nullable<bool> _DaPhat;
		
		private System.Nullable<bool> _DaChuyenHoan;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		private string _TenBuuTa;
		
		public sp_tblBuuTaGiuLai_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromPoscode", DbType="NVarChar(10)")]
		public string FromPoscode
		{
			get
			{
				return this._FromPoscode;
			}
			set
			{
				if ((this._FromPoscode != value))
				{
					this._FromPoscode = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceCode", DbType="NVarChar(5)")]
		public string ServiceCode
		{
			get
			{
				return this._ServiceCode;
			}
			set
			{
				if ((this._ServiceCode != value))
				{
					this._ServiceCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToPoscode", DbType="NVarChar(30)")]
		public string ToPoscode
		{
			get
			{
				return this._ToPoscode;
			}
			set
			{
				if ((this._ToPoscode != value))
				{
					this._ToPoscode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailTripNumber", DbType="Int")]
		public System.Nullable<int> MailTripNumber
		{
			get
			{
				return this._MailTripNumber;
			}
			set
			{
				if ((this._MailTripNumber != value))
				{
					this._MailTripNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostBagNumber", DbType="Int")]
		public System.Nullable<int> PostBagNumber
		{
			get
			{
				return this._PostBagNumber;
			}
			set
			{
				if ((this._PostBagNumber != value))
				{
					this._PostBagNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostBagTypeCode", DbType="NVarChar(10)")]
		public string PostBagTypeCode
		{
			get
			{
				return this._PostBagTypeCode;
			}
			set
			{
				if ((this._PostBagTypeCode != value))
				{
					this._PostBagTypeCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IncomingDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> IncomingDate
		{
			get
			{
				return this._IncomingDate;
			}
			set
			{
				if ((this._IncomingDate != value))
				{
					this._IncomingDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(8)")]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostmanCode", DbType="NVarChar(30)")]
		public string PostmanCode
		{
			get
			{
				return this._PostmanCode;
			}
			set
			{
				if ((this._PostmanCode != value))
				{
					this._PostmanCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(50)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeliverRouteName", DbType="NVarChar(20)")]
		public string DeliverRouteName
		{
			get
			{
				return this._DeliverRouteName;
			}
			set
			{
				if ((this._DeliverRouteName != value))
				{
					this._DeliverRouteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverFullname", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WeightConvert", DbType="Float")]
		public System.Nullable<double> WeightConvert
		{
			get
			{
				return this._WeightConvert;
			}
			set
			{
				if ((this._WeightConvert != value))
				{
					this._WeightConvert = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SendingContent", DbType="NVarChar(255)")]
		public string SendingContent
		{
			get
			{
				return this._SendingContent;
			}
			set
			{
				if ((this._SendingContent != value))
				{
					this._SendingContent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Float")]
		public System.Nullable<double> Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBuuTa", DbType="NVarChar(30)")]
		public string MaBuuTa
		{
			get
			{
				return this._MaBuuTa;
			}
			set
			{
				if ((this._MaBuuTa != value))
				{
					this._MaBuuTa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaPhat", DbType="Bit")]
		public System.Nullable<bool> DaPhat
		{
			get
			{
				return this._DaPhat;
			}
			set
			{
				if ((this._DaPhat != value))
				{
					this._DaPhat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaChuyenHoan", DbType="Bit")]
		public System.Nullable<bool> DaChuyenHoan
		{
			get
			{
				return this._DaChuyenHoan;
			}
			set
			{
				if ((this._DaChuyenHoan != value))
				{
					this._DaChuyenHoan = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBuuTa", DbType="NVarChar(50)")]
		public string TenBuuTa
		{
			get
			{
				return this._TenBuuTa;
			}
			set
			{
				if ((this._TenBuuTa != value))
				{
					this._TenBuuTa = value;
				}
			}
		}
	}
	
	public partial class sp_tblBuuTaGiuLai_ThongTinResult
	{
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private string _FromPoscode;
		
		private string _ItemCode;
		
		private string _ServiceCode;
		
		private string _ToPoscode;
		
		private System.Nullable<int> _MailTripNumber;
		
		private System.Nullable<int> _PostBagNumber;
		
		private string _PostBagTypeCode;
		
		private System.Nullable<System.DateTime> _IncomingDate;
		
		private string _Year;
		
		private string _PostmanCode;
		
		private string _FullName;
		
		private string _DeliverRouteName;
		
		private string _ReceiverFullname;
		
		private string _ReceiverAddress;
		
		private string _ReceiverTel;
		
		private System.Nullable<double> _Weight;
		
		private System.Nullable<double> _WeightConvert;
		
		private string _SendingContent;
		
		private System.Nullable<double> _Value;
		
		private string _MaBuuTa;
		
		private System.Nullable<bool> _DaPhat;
		
		private System.Nullable<bool> _DaChuyenHoan;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblBuuTaGiuLai_ThongTinResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromPoscode", DbType="NVarChar(10)")]
		public string FromPoscode
		{
			get
			{
				return this._FromPoscode;
			}
			set
			{
				if ((this._FromPoscode != value))
				{
					this._FromPoscode = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceCode", DbType="NVarChar(5)")]
		public string ServiceCode
		{
			get
			{
				return this._ServiceCode;
			}
			set
			{
				if ((this._ServiceCode != value))
				{
					this._ServiceCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToPoscode", DbType="NVarChar(30)")]
		public string ToPoscode
		{
			get
			{
				return this._ToPoscode;
			}
			set
			{
				if ((this._ToPoscode != value))
				{
					this._ToPoscode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailTripNumber", DbType="Int")]
		public System.Nullable<int> MailTripNumber
		{
			get
			{
				return this._MailTripNumber;
			}
			set
			{
				if ((this._MailTripNumber != value))
				{
					this._MailTripNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostBagNumber", DbType="Int")]
		public System.Nullable<int> PostBagNumber
		{
			get
			{
				return this._PostBagNumber;
			}
			set
			{
				if ((this._PostBagNumber != value))
				{
					this._PostBagNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostBagTypeCode", DbType="NVarChar(10)")]
		public string PostBagTypeCode
		{
			get
			{
				return this._PostBagTypeCode;
			}
			set
			{
				if ((this._PostBagTypeCode != value))
				{
					this._PostBagTypeCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IncomingDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> IncomingDate
		{
			get
			{
				return this._IncomingDate;
			}
			set
			{
				if ((this._IncomingDate != value))
				{
					this._IncomingDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(8)")]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostmanCode", DbType="NVarChar(30)")]
		public string PostmanCode
		{
			get
			{
				return this._PostmanCode;
			}
			set
			{
				if ((this._PostmanCode != value))
				{
					this._PostmanCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(50)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeliverRouteName", DbType="NVarChar(20)")]
		public string DeliverRouteName
		{
			get
			{
				return this._DeliverRouteName;
			}
			set
			{
				if ((this._DeliverRouteName != value))
				{
					this._DeliverRouteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverFullname", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WeightConvert", DbType="Float")]
		public System.Nullable<double> WeightConvert
		{
			get
			{
				return this._WeightConvert;
			}
			set
			{
				if ((this._WeightConvert != value))
				{
					this._WeightConvert = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SendingContent", DbType="NVarChar(255)")]
		public string SendingContent
		{
			get
			{
				return this._SendingContent;
			}
			set
			{
				if ((this._SendingContent != value))
				{
					this._SendingContent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Float")]
		public System.Nullable<double> Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBuuTa", DbType="NVarChar(30)")]
		public string MaBuuTa
		{
			get
			{
				return this._MaBuuTa;
			}
			set
			{
				if ((this._MaBuuTa != value))
				{
					this._MaBuuTa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaPhat", DbType="Bit")]
		public System.Nullable<bool> DaPhat
		{
			get
			{
				return this._DaPhat;
			}
			set
			{
				if ((this._DaPhat != value))
				{
					this._DaPhat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaChuyenHoan", DbType="Bit")]
		public System.Nullable<bool> DaChuyenHoan
		{
			get
			{
				return this._DaChuyenHoan;
			}
			set
			{
				if ((this._DaChuyenHoan != value))
				{
					this._DaChuyenHoan = value;
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
	
	public partial class sp_tblBuuTaTraLai_DanhSachResult
	{
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private System.Nullable<short> _Ca;
		
		private string _FromPoscode;
		
		private string _ItemCode;
		
		private string _ServiceCode;
		
		private string _ToPoscode;
		
		private System.Nullable<int> _MailTripNumber;
		
		private System.Nullable<int> _PostBagNumber;
		
		private string _PostBagTypeCode;
		
		private System.Nullable<System.DateTime> _IncomingDate;
		
		private string _Year;
		
		private string _PostmanCode;
		
		private string _FullName;
		
		private string _DeliverRouteName;
		
		private string _ReceiverFullname;
		
		private string _ReceiverAddress;
		
		private string _ReceiverTel;
		
		private System.Nullable<double> _Weight;
		
		private System.Nullable<double> _WeightConvert;
		
		private string _SendingContent;
		
		private System.Nullable<double> _Value;
		
		private string _MaBuuTa;
		
		private System.Nullable<bool> _DaPhat;
		
		private System.Nullable<bool> _DaChuyenHoan;
		
		private System.Nullable<System.DateTime> _NgayHeThong;
		
		public sp_tblBuuTaTraLai_DanhSachResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromPoscode", DbType="NVarChar(10)")]
		public string FromPoscode
		{
			get
			{
				return this._FromPoscode;
			}
			set
			{
				if ((this._FromPoscode != value))
				{
					this._FromPoscode = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceCode", DbType="NVarChar(5)")]
		public string ServiceCode
		{
			get
			{
				return this._ServiceCode;
			}
			set
			{
				if ((this._ServiceCode != value))
				{
					this._ServiceCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToPoscode", DbType="NVarChar(30)")]
		public string ToPoscode
		{
			get
			{
				return this._ToPoscode;
			}
			set
			{
				if ((this._ToPoscode != value))
				{
					this._ToPoscode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailTripNumber", DbType="Int")]
		public System.Nullable<int> MailTripNumber
		{
			get
			{
				return this._MailTripNumber;
			}
			set
			{
				if ((this._MailTripNumber != value))
				{
					this._MailTripNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostBagNumber", DbType="Int")]
		public System.Nullable<int> PostBagNumber
		{
			get
			{
				return this._PostBagNumber;
			}
			set
			{
				if ((this._PostBagNumber != value))
				{
					this._PostBagNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostBagTypeCode", DbType="NVarChar(10)")]
		public string PostBagTypeCode
		{
			get
			{
				return this._PostBagTypeCode;
			}
			set
			{
				if ((this._PostBagTypeCode != value))
				{
					this._PostBagTypeCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IncomingDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> IncomingDate
		{
			get
			{
				return this._IncomingDate;
			}
			set
			{
				if ((this._IncomingDate != value))
				{
					this._IncomingDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(8)")]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostmanCode", DbType="NVarChar(30)")]
		public string PostmanCode
		{
			get
			{
				return this._PostmanCode;
			}
			set
			{
				if ((this._PostmanCode != value))
				{
					this._PostmanCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(50)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeliverRouteName", DbType="NVarChar(20)")]
		public string DeliverRouteName
		{
			get
			{
				return this._DeliverRouteName;
			}
			set
			{
				if ((this._DeliverRouteName != value))
				{
					this._DeliverRouteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverFullname", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WeightConvert", DbType="Float")]
		public System.Nullable<double> WeightConvert
		{
			get
			{
				return this._WeightConvert;
			}
			set
			{
				if ((this._WeightConvert != value))
				{
					this._WeightConvert = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SendingContent", DbType="NVarChar(255)")]
		public string SendingContent
		{
			get
			{
				return this._SendingContent;
			}
			set
			{
				if ((this._SendingContent != value))
				{
					this._SendingContent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Float")]
		public System.Nullable<double> Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBuuTa", DbType="NVarChar(30)")]
		public string MaBuuTa
		{
			get
			{
				return this._MaBuuTa;
			}
			set
			{
				if ((this._MaBuuTa != value))
				{
					this._MaBuuTa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaPhat", DbType="Bit")]
		public System.Nullable<bool> DaPhat
		{
			get
			{
				return this._DaPhat;
			}
			set
			{
				if ((this._DaPhat != value))
				{
					this._DaPhat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaChuyenHoan", DbType="Bit")]
		public System.Nullable<bool> DaChuyenHoan
		{
			get
			{
				return this._DaChuyenHoan;
			}
			set
			{
				if ((this._DaChuyenHoan != value))
				{
					this._DaChuyenHoan = value;
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
