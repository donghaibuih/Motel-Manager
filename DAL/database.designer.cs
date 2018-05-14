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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QUANLYNHATROHUYTHINH")]
	public partial class databaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCHITIETHOADON(CHITIETHOADON instance);
    partial void UpdateCHITIETHOADON(CHITIETHOADON instance);
    partial void DeleteCHITIETHOADON(CHITIETHOADON instance);
    partial void InsertCHITIETPHONG(CHITIETPHONG instance);
    partial void UpdateCHITIETPHONG(CHITIETPHONG instance);
    partial void DeleteCHITIETPHONG(CHITIETPHONG instance);
    partial void InsertDICHVU(DICHVU instance);
    partial void UpdateDICHVU(DICHVU instance);
    partial void DeleteDICHVU(DICHVU instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertKHACHTRO(KHACHTRO instance);
    partial void UpdateKHACHTRO(KHACHTRO instance);
    partial void DeleteKHACHTRO(KHACHTRO instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    partial void InsertPHONGTRO(PHONGTRO instance);
    partial void UpdatePHONGTRO(PHONGTRO instance);
    partial void DeletePHONGTRO(PHONGTRO instance);
    partial void InsertTAIKHOAN(TAIKHOAN instance);
    partial void UpdateTAIKHOAN(TAIKHOAN instance);
    partial void DeleteTAIKHOAN(TAIKHOAN instance);
    #endregion
		
		public databaseDataContext() : 
				base(global::DAL.Properties.Settings.Default.QUANLYNHATROHUYTHINHConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CHITIETHOADON> CHITIETHOADONs
		{
			get
			{
				return this.GetTable<CHITIETHOADON>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETPHONG> CHITIETPHONGs
		{
			get
			{
				return this.GetTable<CHITIETPHONG>();
			}
		}
		
		public System.Data.Linq.Table<DICHVU> DICHVUs
		{
			get
			{
				return this.GetTable<DICHVU>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<KHACHTRO> KHACHTROs
		{
			get
			{
				return this.GetTable<KHACHTRO>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		public System.Data.Linq.Table<PHONGTRO> PHONGTROs
		{
			get
			{
				return this.GetTable<PHONGTRO>();
			}
		}
		
		public System.Data.Linq.Table<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this.GetTable<TAIKHOAN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETHOADON")]
	public partial class CHITIETHOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHOADON;
		
		private string _TENDICHVU;
		
		private System.Nullable<int> _SOCU;
		
		private System.Nullable<int> _SOLUONG;
		
		private float _THANHTIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHOADONChanging(string value);
    partial void OnMAHOADONChanged();
    partial void OnTENDICHVUChanging(string value);
    partial void OnTENDICHVUChanged();
    partial void OnSOCUChanging(System.Nullable<int> value);
    partial void OnSOCUChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    partial void OnTHANHTIENChanging(float value);
    partial void OnTHANHTIENChanged();
    #endregion
		
		public CHITIETHOADON()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHOADON", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHOADON
		{
			get
			{
				return this._MAHOADON;
			}
			set
			{
				if ((this._MAHOADON != value))
				{
					this.OnMAHOADONChanging(value);
					this.SendPropertyChanging();
					this._MAHOADON = value;
					this.SendPropertyChanged("MAHOADON");
					this.OnMAHOADONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDICHVU", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TENDICHVU
		{
			get
			{
				return this._TENDICHVU;
			}
			set
			{
				if ((this._TENDICHVU != value))
				{
					this.OnTENDICHVUChanging(value);
					this.SendPropertyChanging();
					this._TENDICHVU = value;
					this.SendPropertyChanged("TENDICHVU");
					this.OnTENDICHVUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOCU", DbType="Int")]
		public System.Nullable<int> SOCU
		{
			get
			{
				return this._SOCU;
			}
			set
			{
				if ((this._SOCU != value))
				{
					this.OnSOCUChanging(value);
					this.SendPropertyChanging();
					this._SOCU = value;
					this.SendPropertyChanged("SOCU");
					this.OnSOCUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_THANHTIEN", DbType="Real NOT NULL")]
		public float THANHTIEN
		{
			get
			{
				return this._THANHTIEN;
			}
			set
			{
				if ((this._THANHTIEN != value))
				{
					this.OnTHANHTIENChanging(value);
					this.SendPropertyChanging();
					this._THANHTIEN = value;
					this.SendPropertyChanged("THANHTIEN");
					this.OnTHANHTIENChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETPHONG")]
	public partial class CHITIETPHONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAPHONG;
		
		private string _MAKHACH;
		
		private string _TENKHACH;
		
		private System.DateTime _NGAYSINH;
		
		private string _GIOITINH;
		
		private string _SODIENTHOAI;
		
		private string _DIACHITHUONGTRU;
		
		private string _SOCMND;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHONGChanging(string value);
    partial void OnMAPHONGChanged();
    partial void OnMAKHACHChanging(string value);
    partial void OnMAKHACHChanged();
    partial void OnTENKHACHChanging(string value);
    partial void OnTENKHACHChanged();
    partial void OnNGAYSINHChanging(System.DateTime value);
    partial void OnNGAYSINHChanged();
    partial void OnGIOITINHChanging(string value);
    partial void OnGIOITINHChanged();
    partial void OnSODIENTHOAIChanging(string value);
    partial void OnSODIENTHOAIChanged();
    partial void OnDIACHITHUONGTRUChanging(string value);
    partial void OnDIACHITHUONGTRUChanged();
    partial void OnSOCMNDChanging(string value);
    partial void OnSOCMNDChanged();
    #endregion
		
		public CHITIETPHONG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="NVarChar(60) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKHACH", DbType="NVarChar(60) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAKHACH
		{
			get
			{
				return this._MAKHACH;
			}
			set
			{
				if ((this._MAKHACH != value))
				{
					this.OnMAKHACHChanging(value);
					this.SendPropertyChanging();
					this._MAKHACH = value;
					this.SendPropertyChanged("MAKHACH");
					this.OnMAKHACHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKHACH", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string TENKHACH
		{
			get
			{
				return this._TENKHACH;
			}
			set
			{
				if ((this._TENKHACH != value))
				{
					this.OnTENKHACHChanging(value);
					this.SendPropertyChanging();
					this._TENKHACH = value;
					this.SendPropertyChanged("TENKHACH");
					this.OnTENKHACHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date NOT NULL")]
		public System.DateTime NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIOITINH", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string GIOITINH
		{
			get
			{
				return this._GIOITINH;
			}
			set
			{
				if ((this._GIOITINH != value))
				{
					this.OnGIOITINHChanging(value);
					this.SendPropertyChanging();
					this._GIOITINH = value;
					this.SendPropertyChanged("GIOITINH");
					this.OnGIOITINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SODIENTHOAI", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string SODIENTHOAI
		{
			get
			{
				return this._SODIENTHOAI;
			}
			set
			{
				if ((this._SODIENTHOAI != value))
				{
					this.OnSODIENTHOAIChanging(value);
					this.SendPropertyChanging();
					this._SODIENTHOAI = value;
					this.SendPropertyChanged("SODIENTHOAI");
					this.OnSODIENTHOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHITHUONGTRU", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string DIACHITHUONGTRU
		{
			get
			{
				return this._DIACHITHUONGTRU;
			}
			set
			{
				if ((this._DIACHITHUONGTRU != value))
				{
					this.OnDIACHITHUONGTRUChanging(value);
					this.SendPropertyChanging();
					this._DIACHITHUONGTRU = value;
					this.SendPropertyChanged("DIACHITHUONGTRU");
					this.OnDIACHITHUONGTRUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOCMND", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string SOCMND
		{
			get
			{
				return this._SOCMND;
			}
			set
			{
				if ((this._SOCMND != value))
				{
					this.OnSOCMNDChanging(value);
					this.SendPropertyChanging();
					this._SOCMND = value;
					this.SendPropertyChanged("SOCMND");
					this.OnSOCMNDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DICHVU")]
	public partial class DICHVU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TENDICHVU;
		
		private string _DONVITINH;
		
		private double _DONGIA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTENDICHVUChanging(string value);
    partial void OnTENDICHVUChanged();
    partial void OnDONVITINHChanging(string value);
    partial void OnDONVITINHChanged();
    partial void OnDONGIAChanging(double value);
    partial void OnDONGIAChanged();
    #endregion
		
		public DICHVU()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDICHVU", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TENDICHVU
		{
			get
			{
				return this._TENDICHVU;
			}
			set
			{
				if ((this._TENDICHVU != value))
				{
					this.OnTENDICHVUChanging(value);
					this.SendPropertyChanging();
					this._TENDICHVU = value;
					this.SendPropertyChanged("TENDICHVU");
					this.OnTENDICHVUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONVITINH", DbType="NVarChar(50)")]
		public string DONVITINH
		{
			get
			{
				return this._DONVITINH;
			}
			set
			{
				if ((this._DONVITINH != value))
				{
					this.OnDONVITINHChanging(value);
					this.SendPropertyChanging();
					this._DONVITINH = value;
					this.SendPropertyChanged("DONVITINH");
					this.OnDONVITINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Float NOT NULL")]
		public double DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHOADON;
		
		private string _MAKHACH;
		
		private string _MANHANVIEN;
		
		private string _MAPHONG;
		
		private System.DateTime _NGAYLAP;
		
		private double _TONGTIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHOADONChanging(string value);
    partial void OnMAHOADONChanged();
    partial void OnMAKHACHChanging(string value);
    partial void OnMAKHACHChanged();
    partial void OnMANHANVIENChanging(string value);
    partial void OnMANHANVIENChanged();
    partial void OnMAPHONGChanging(string value);
    partial void OnMAPHONGChanged();
    partial void OnNGAYLAPChanging(System.DateTime value);
    partial void OnNGAYLAPChanged();
    partial void OnTONGTIENChanging(double value);
    partial void OnTONGTIENChanged();
    #endregion
		
		public HOADON()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHOADON", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHOADON
		{
			get
			{
				return this._MAHOADON;
			}
			set
			{
				if ((this._MAHOADON != value))
				{
					this.OnMAHOADONChanging(value);
					this.SendPropertyChanging();
					this._MAHOADON = value;
					this.SendPropertyChanged("MAHOADON");
					this.OnMAHOADONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKHACH", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MAKHACH
		{
			get
			{
				return this._MAKHACH;
			}
			set
			{
				if ((this._MAKHACH != value))
				{
					this.OnMAKHACHChanging(value);
					this.SendPropertyChanging();
					this._MAKHACH = value;
					this.SendPropertyChanged("MAKHACH");
					this.OnMAKHACHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANHANVIEN", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MANHANVIEN
		{
			get
			{
				return this._MANHANVIEN;
			}
			set
			{
				if ((this._MANHANVIEN != value))
				{
					this.OnMANHANVIENChanging(value);
					this.SendPropertyChanging();
					this._MANHANVIEN = value;
					this.SendPropertyChanged("MANHANVIEN");
					this.OnMANHANVIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYLAP", DbType="Date NOT NULL")]
		public System.DateTime NGAYLAP
		{
			get
			{
				return this._NGAYLAP;
			}
			set
			{
				if ((this._NGAYLAP != value))
				{
					this.OnNGAYLAPChanging(value);
					this.SendPropertyChanging();
					this._NGAYLAP = value;
					this.SendPropertyChanged("NGAYLAP");
					this.OnNGAYLAPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TONGTIEN", DbType="Float NOT NULL")]
		public double TONGTIEN
		{
			get
			{
				return this._TONGTIEN;
			}
			set
			{
				if ((this._TONGTIEN != value))
				{
					this.OnTONGTIENChanging(value);
					this.SendPropertyChanging();
					this._TONGTIEN = value;
					this.SendPropertyChanged("TONGTIEN");
					this.OnTONGTIENChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHTRO")]
	public partial class KHACHTRO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAKHACH;
		
		private string _TENKHACH;
		
		private string _MAPHONG;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _GIOITINH;
		
		private string _SODIENTHOAI;
		
		private string _DIACHITHUONGTRU;
		
		private string _SOCMND;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAKHACHChanging(string value);
    partial void OnMAKHACHChanged();
    partial void OnTENKHACHChanging(string value);
    partial void OnTENKHACHChanged();
    partial void OnMAPHONGChanging(string value);
    partial void OnMAPHONGChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnGIOITINHChanging(string value);
    partial void OnGIOITINHChanged();
    partial void OnSODIENTHOAIChanging(string value);
    partial void OnSODIENTHOAIChanged();
    partial void OnDIACHITHUONGTRUChanging(string value);
    partial void OnDIACHITHUONGTRUChanged();
    partial void OnSOCMNDChanging(string value);
    partial void OnSOCMNDChanged();
    #endregion
		
		public KHACHTRO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKHACH", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAKHACH
		{
			get
			{
				return this._MAKHACH;
			}
			set
			{
				if ((this._MAKHACH != value))
				{
					this.OnMAKHACHChanging(value);
					this.SendPropertyChanging();
					this._MAKHACH = value;
					this.SendPropertyChanged("MAKHACH");
					this.OnMAKHACHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKHACH", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENKHACH
		{
			get
			{
				return this._TENKHACH;
			}
			set
			{
				if ((this._TENKHACH != value))
				{
					this.OnTENKHACHChanging(value);
					this.SendPropertyChanging();
					this._TENKHACH = value;
					this.SendPropertyChanged("TENKHACH");
					this.OnTENKHACHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIOITINH", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string GIOITINH
		{
			get
			{
				return this._GIOITINH;
			}
			set
			{
				if ((this._GIOITINH != value))
				{
					this.OnGIOITINHChanging(value);
					this.SendPropertyChanging();
					this._GIOITINH = value;
					this.SendPropertyChanged("GIOITINH");
					this.OnGIOITINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SODIENTHOAI", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string SODIENTHOAI
		{
			get
			{
				return this._SODIENTHOAI;
			}
			set
			{
				if ((this._SODIENTHOAI != value))
				{
					this.OnSODIENTHOAIChanging(value);
					this.SendPropertyChanging();
					this._SODIENTHOAI = value;
					this.SendPropertyChanged("SODIENTHOAI");
					this.OnSODIENTHOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHITHUONGTRU", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DIACHITHUONGTRU
		{
			get
			{
				return this._DIACHITHUONGTRU;
			}
			set
			{
				if ((this._DIACHITHUONGTRU != value))
				{
					this.OnDIACHITHUONGTRUChanging(value);
					this.SendPropertyChanging();
					this._DIACHITHUONGTRU = value;
					this.SendPropertyChanged("DIACHITHUONGTRU");
					this.OnDIACHITHUONGTRUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOCMND", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SOCMND
		{
			get
			{
				return this._SOCMND;
			}
			set
			{
				if ((this._SOCMND != value))
				{
					this.OnSOCMNDChanging(value);
					this.SendPropertyChanging();
					this._SOCMND = value;
					this.SendPropertyChanged("SOCMND");
					this.OnSOCMNDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANHANVIEN;
		
		private string _TENNHANVIEN;
		
		private string _DIACHI;
		
		private string _SODIENTHOAI;
		
		private string _CHUCVU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANHANVIENChanging(string value);
    partial void OnMANHANVIENChanged();
    partial void OnTENNHANVIENChanging(string value);
    partial void OnTENNHANVIENChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSODIENTHOAIChanging(string value);
    partial void OnSODIENTHOAIChanged();
    partial void OnCHUCVUChanging(string value);
    partial void OnCHUCVUChanged();
    #endregion
		
		public NHANVIEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANHANVIEN", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANHANVIEN
		{
			get
			{
				return this._MANHANVIEN;
			}
			set
			{
				if ((this._MANHANVIEN != value))
				{
					this.OnMANHANVIENChanging(value);
					this.SendPropertyChanging();
					this._MANHANVIEN = value;
					this.SendPropertyChanged("MANHANVIEN");
					this.OnMANHANVIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENNHANVIEN", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENNHANVIEN
		{
			get
			{
				return this._TENNHANVIEN;
			}
			set
			{
				if ((this._TENNHANVIEN != value))
				{
					this.OnTENNHANVIENChanging(value);
					this.SendPropertyChanging();
					this._TENNHANVIEN = value;
					this.SendPropertyChanged("TENNHANVIEN");
					this.OnTENNHANVIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SODIENTHOAI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SODIENTHOAI
		{
			get
			{
				return this._SODIENTHOAI;
			}
			set
			{
				if ((this._SODIENTHOAI != value))
				{
					this.OnSODIENTHOAIChanging(value);
					this.SendPropertyChanging();
					this._SODIENTHOAI = value;
					this.SendPropertyChanged("SODIENTHOAI");
					this.OnSODIENTHOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHUCVU", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string CHUCVU
		{
			get
			{
				return this._CHUCVU;
			}
			set
			{
				if ((this._CHUCVU != value))
				{
					this.OnCHUCVUChanging(value);
					this.SendPropertyChanging();
					this._CHUCVU = value;
					this.SendPropertyChanged("CHUCVU");
					this.OnCHUCVUChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHONGTRO")]
	public partial class PHONGTRO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAPHONG;
		
		private string _TRANGTHAI;
		
		private double _TIENPHONG;
		
		private int _SONGUOIO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHONGChanging(string value);
    partial void OnMAPHONGChanged();
    partial void OnTRANGTHAIChanging(string value);
    partial void OnTRANGTHAIChanged();
    partial void OnTIENPHONGChanging(double value);
    partial void OnTIENPHONGChanged();
    partial void OnSONGUOIOChanging(int value);
    partial void OnSONGUOIOChanged();
    #endregion
		
		public PHONGTRO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANGTHAI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TRANGTHAI
		{
			get
			{
				return this._TRANGTHAI;
			}
			set
			{
				if ((this._TRANGTHAI != value))
				{
					this.OnTRANGTHAIChanging(value);
					this.SendPropertyChanging();
					this._TRANGTHAI = value;
					this.SendPropertyChanged("TRANGTHAI");
					this.OnTRANGTHAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIENPHONG", DbType="Float NOT NULL")]
		public double TIENPHONG
		{
			get
			{
				return this._TIENPHONG;
			}
			set
			{
				if ((this._TIENPHONG != value))
				{
					this.OnTIENPHONGChanging(value);
					this.SendPropertyChanging();
					this._TIENPHONG = value;
					this.SendPropertyChanged("TIENPHONG");
					this.OnTIENPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SONGUOIO", DbType="Int NOT NULL")]
		public int SONGUOIO
		{
			get
			{
				return this._SONGUOIO;
			}
			set
			{
				if ((this._SONGUOIO != value))
				{
					this.OnSONGUOIOChanging(value);
					this.SendPropertyChanging();
					this._SONGUOIO = value;
					this.SendPropertyChanged("SONGUOIO");
					this.OnSONGUOIOChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAIKHOAN")]
	public partial class TAIKHOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANHANVIEN;
		
		private string _TENTAIKHOAN;
		
		private string _MATKHAU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANHANVIENChanging(string value);
    partial void OnMANHANVIENChanged();
    partial void OnTENTAIKHOANChanging(string value);
    partial void OnTENTAIKHOANChanged();
    partial void OnMATKHAUChanging(string value);
    partial void OnMATKHAUChanged();
    #endregion
		
		public TAIKHOAN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANHANVIEN", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANHANVIEN
		{
			get
			{
				return this._MANHANVIEN;
			}
			set
			{
				if ((this._MANHANVIEN != value))
				{
					this.OnMANHANVIENChanging(value);
					this.SendPropertyChanging();
					this._MANHANVIEN = value;
					this.SendPropertyChanged("MANHANVIEN");
					this.OnMANHANVIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENTAIKHOAN", DbType="NVarChar(60) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TENTAIKHOAN
		{
			get
			{
				return this._TENTAIKHOAN;
			}
			set
			{
				if ((this._TENTAIKHOAN != value))
				{
					this.OnTENTAIKHOANChanging(value);
					this.SendPropertyChanging();
					this._TENTAIKHOAN = value;
					this.SendPropertyChanged("TENTAIKHOAN");
					this.OnTENTAIKHOANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591