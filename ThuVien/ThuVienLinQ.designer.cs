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

namespace ThuVien
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibraryDb")]
	public partial class ThuVienLinQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDOCGIA(DOCGIA instance);
    partial void UpdateDOCGIA(DOCGIA instance);
    partial void DeleteDOCGIA(DOCGIA instance);
    partial void InsertMUONSACH(MUONSACH instance);
    partial void UpdateMUONSACH(MUONSACH instance);
    partial void DeleteMUONSACH(MUONSACH instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    partial void InsertQUANTRIVIEN(QUANTRIVIEN instance);
    partial void UpdateQUANTRIVIEN(QUANTRIVIEN instance);
    partial void DeleteQUANTRIVIEN(QUANTRIVIEN instance);
    partial void InsertSACH(SACH instance);
    partial void UpdateSACH(SACH instance);
    partial void DeleteSACH(SACH instance);
    partial void InsertSACHMUON(SACHMUON instance);
    partial void UpdateSACHMUON(SACHMUON instance);
    partial void DeleteSACHMUON(SACHMUON instance);
    #endregion
		
		public ThuVienLinQDataContext() : 
				base(global::ThuVien.Properties.Settings.Default.LibraryDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ThuVienLinQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ThuVienLinQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ThuVienLinQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ThuVienLinQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DOCGIA> DOCGIAs
		{
			get
			{
				return this.GetTable<DOCGIA>();
			}
		}
		
		public System.Data.Linq.Table<MUONSACH> MUONSACHes
		{
			get
			{
				return this.GetTable<MUONSACH>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		public System.Data.Linq.Table<QUANTRIVIEN> QUANTRIVIENs
		{
			get
			{
				return this.GetTable<QUANTRIVIEN>();
			}
		}
		
		public System.Data.Linq.Table<SACH> SACHes
		{
			get
			{
				return this.GetTable<SACH>();
			}
		}
		
		public System.Data.Linq.Table<SACHMUON> SACHMUONs
		{
			get
			{
				return this.GetTable<SACHMUON>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DOCGIA")]
	public partial class DOCGIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _madg;
		
		private string _tendg;
		
		private System.Nullable<System.DateTime> _ngaysinh;
		
		private string _gioitinh;
		
		private string _cmnd;
		
		private string _diachi;
		
		private string _sdt;
		
		private string _capnhat;
		
		private EntitySet<MUONSACH> _MUONSACHes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadgChanging(string value);
    partial void OnmadgChanged();
    partial void OntendgChanging(string value);
    partial void OntendgChanged();
    partial void OnngaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngaysinhChanged();
    partial void OngioitinhChanging(string value);
    partial void OngioitinhChanged();
    partial void OncmndChanging(string value);
    partial void OncmndChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OncapnhatChanging(string value);
    partial void OncapnhatChanged();
    #endregion
		
		public DOCGIA()
		{
			this._MUONSACHes = new EntitySet<MUONSACH>(new Action<MUONSACH>(this.attach_MUONSACHes), new Action<MUONSACH>(this.detach_MUONSACHes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madg", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string madg
		{
			get
			{
				return this._madg;
			}
			set
			{
				if ((this._madg != value))
				{
					this.OnmadgChanging(value);
					this.SendPropertyChanging();
					this._madg = value;
					this.SendPropertyChanged("madg");
					this.OnmadgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tendg", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string tendg
		{
			get
			{
				return this._tendg;
			}
			set
			{
				if ((this._tendg != value))
				{
					this.OntendgChanging(value);
					this.SendPropertyChanging();
					this._tendg = value;
					this.SendPropertyChanged("tendg");
					this.OntendgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaysinh", DbType="Date")]
		public System.Nullable<System.DateTime> ngaysinh
		{
			get
			{
				return this._ngaysinh;
			}
			set
			{
				if ((this._ngaysinh != value))
				{
					this.OnngaysinhChanging(value);
					this.SendPropertyChanging();
					this._ngaysinh = value;
					this.SendPropertyChanged("ngaysinh");
					this.OnngaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioitinh", DbType="NVarChar(3) NOT NULL", CanBeNull=false)]
		public string gioitinh
		{
			get
			{
				return this._gioitinh;
			}
			set
			{
				if ((this._gioitinh != value))
				{
					this.OngioitinhChanging(value);
					this.SendPropertyChanging();
					this._gioitinh = value;
					this.SendPropertyChanged("gioitinh");
					this.OngioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cmnd", DbType="Char(9) NOT NULL", CanBeNull=false)]
		public string cmnd
		{
			get
			{
				return this._cmnd;
			}
			set
			{
				if ((this._cmnd != value))
				{
					this.OncmndChanging(value);
					this.SendPropertyChanging();
					this._cmnd = value;
					this.SendPropertyChanged("cmnd");
					this.OncmndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="VarChar(11)")]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_capnhat", DbType="NChar(10)")]
		public string capnhat
		{
			get
			{
				return this._capnhat;
			}
			set
			{
				if ((this._capnhat != value))
				{
					this.OncapnhatChanging(value);
					this.SendPropertyChanging();
					this._capnhat = value;
					this.SendPropertyChanged("capnhat");
					this.OncapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DOCGIA_MUONSACH", Storage="_MUONSACHes", ThisKey="madg", OtherKey="madg")]
		public EntitySet<MUONSACH> MUONSACHes
		{
			get
			{
				return this._MUONSACHes;
			}
			set
			{
				this._MUONSACHes.Assign(value);
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
		
		private void attach_MUONSACHes(MUONSACH entity)
		{
			this.SendPropertyChanging();
			entity.DOCGIA = this;
		}
		
		private void detach_MUONSACHes(MUONSACH entity)
		{
			this.SendPropertyChanging();
			entity.DOCGIA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MUONSACH")]
	public partial class MUONSACH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idmuons;
		
		private string _manv;
		
		private string _madg;
		
		private System.DateTime _ngaymuon;
		
		private System.DateTime _ngaytra;
		
		private int _soluong;
		
		private System.Nullable<bool> _trangthai;
		
		private string _capnhat;
		
		private EntitySet<SACHMUON> _SACHMUONs;
		
		private EntityRef<DOCGIA> _DOCGIA;
		
		private EntityRef<NHANVIEN> _NHANVIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidmuonsChanging(int value);
    partial void OnidmuonsChanged();
    partial void OnmanvChanging(string value);
    partial void OnmanvChanged();
    partial void OnmadgChanging(string value);
    partial void OnmadgChanged();
    partial void OnngaymuonChanging(System.DateTime value);
    partial void OnngaymuonChanged();
    partial void OnngaytraChanging(System.DateTime value);
    partial void OnngaytraChanged();
    partial void OnsoluongChanging(int value);
    partial void OnsoluongChanged();
    partial void OntrangthaiChanging(System.Nullable<bool> value);
    partial void OntrangthaiChanged();
    partial void OncapnhatChanging(string value);
    partial void OncapnhatChanged();
    #endregion
		
		public MUONSACH()
		{
			this._SACHMUONs = new EntitySet<SACHMUON>(new Action<SACHMUON>(this.attach_SACHMUONs), new Action<SACHMUON>(this.detach_SACHMUONs));
			this._DOCGIA = default(EntityRef<DOCGIA>);
			this._NHANVIEN = default(EntityRef<NHANVIEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idmuons", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idmuons
		{
			get
			{
				return this._idmuons;
			}
			set
			{
				if ((this._idmuons != value))
				{
					this.OnidmuonsChanging(value);
					this.SendPropertyChanging();
					this._idmuons = value;
					this.SendPropertyChanged("idmuons");
					this.OnidmuonsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manv", DbType="Char(5) NOT NULL", CanBeNull=false)]
		public string manv
		{
			get
			{
				return this._manv;
			}
			set
			{
				if ((this._manv != value))
				{
					if (this._NHANVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmanvChanging(value);
					this.SendPropertyChanging();
					this._manv = value;
					this.SendPropertyChanged("manv");
					this.OnmanvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madg", DbType="Char(5) NOT NULL", CanBeNull=false)]
		public string madg
		{
			get
			{
				return this._madg;
			}
			set
			{
				if ((this._madg != value))
				{
					if (this._DOCGIA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmadgChanging(value);
					this.SendPropertyChanging();
					this._madg = value;
					this.SendPropertyChanged("madg");
					this.OnmadgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaymuon", DbType="Date NOT NULL")]
		public System.DateTime ngaymuon
		{
			get
			{
				return this._ngaymuon;
			}
			set
			{
				if ((this._ngaymuon != value))
				{
					this.OnngaymuonChanging(value);
					this.SendPropertyChanging();
					this._ngaymuon = value;
					this.SendPropertyChanged("ngaymuon");
					this.OnngaymuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaytra", DbType="Date NOT NULL")]
		public System.DateTime ngaytra
		{
			get
			{
				return this._ngaytra;
			}
			set
			{
				if ((this._ngaytra != value))
				{
					this.OnngaytraChanging(value);
					this.SendPropertyChanging();
					this._ngaytra = value;
					this.SendPropertyChanged("ngaytra");
					this.OnngaytraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int NOT NULL")]
		public int soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trangthai", DbType="Bit")]
		public System.Nullable<bool> trangthai
		{
			get
			{
				return this._trangthai;
			}
			set
			{
				if ((this._trangthai != value))
				{
					this.OntrangthaiChanging(value);
					this.SendPropertyChanging();
					this._trangthai = value;
					this.SendPropertyChanged("trangthai");
					this.OntrangthaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_capnhat", DbType="NChar(10)")]
		public string capnhat
		{
			get
			{
				return this._capnhat;
			}
			set
			{
				if ((this._capnhat != value))
				{
					this.OncapnhatChanging(value);
					this.SendPropertyChanging();
					this._capnhat = value;
					this.SendPropertyChanged("capnhat");
					this.OncapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MUONSACH_SACHMUON", Storage="_SACHMUONs", ThisKey="idmuons", OtherKey="idmuons")]
		public EntitySet<SACHMUON> SACHMUONs
		{
			get
			{
				return this._SACHMUONs;
			}
			set
			{
				this._SACHMUONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DOCGIA_MUONSACH", Storage="_DOCGIA", ThisKey="madg", OtherKey="madg", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public DOCGIA DOCGIA
		{
			get
			{
				return this._DOCGIA.Entity;
			}
			set
			{
				DOCGIA previousValue = this._DOCGIA.Entity;
				if (((previousValue != value) 
							|| (this._DOCGIA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DOCGIA.Entity = null;
						previousValue.MUONSACHes.Remove(this);
					}
					this._DOCGIA.Entity = value;
					if ((value != null))
					{
						value.MUONSACHes.Add(this);
						this._madg = value.madg;
					}
					else
					{
						this._madg = default(string);
					}
					this.SendPropertyChanged("DOCGIA");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_MUONSACH", Storage="_NHANVIEN", ThisKey="manv", OtherKey="manv", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public NHANVIEN NHANVIEN
		{
			get
			{
				return this._NHANVIEN.Entity;
			}
			set
			{
				NHANVIEN previousValue = this._NHANVIEN.Entity;
				if (((previousValue != value) 
							|| (this._NHANVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHANVIEN.Entity = null;
						previousValue.MUONSACHes.Remove(this);
					}
					this._NHANVIEN.Entity = value;
					if ((value != null))
					{
						value.MUONSACHes.Add(this);
						this._manv = value.manv;
					}
					else
					{
						this._manv = default(string);
					}
					this.SendPropertyChanged("NHANVIEN");
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
		
		private void attach_SACHMUONs(SACHMUON entity)
		{
			this.SendPropertyChanging();
			entity.MUONSACH = this;
		}
		
		private void detach_SACHMUONs(SACHMUON entity)
		{
			this.SendPropertyChanging();
			entity.MUONSACH = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _manv;
		
		private string _tennv;
		
		private string _gioitinh;
		
		private string _diachi;
		
		private string _cmnd;
		
		private string _email;
		
		private string _dienthoai;
		
		private string _capnhat;
		
		private EntitySet<MUONSACH> _MUONSACHes;
		
		private EntityRef<QUANTRIVIEN> _QUANTRIVIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmanvChanging(string value);
    partial void OnmanvChanged();
    partial void OntennvChanging(string value);
    partial void OntennvChanged();
    partial void OngioitinhChanging(string value);
    partial void OngioitinhChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OncmndChanging(string value);
    partial void OncmndChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndienthoaiChanging(string value);
    partial void OndienthoaiChanged();
    partial void OncapnhatChanging(string value);
    partial void OncapnhatChanged();
    #endregion
		
		public NHANVIEN()
		{
			this._MUONSACHes = new EntitySet<MUONSACH>(new Action<MUONSACH>(this.attach_MUONSACHes), new Action<MUONSACH>(this.detach_MUONSACHes));
			this._QUANTRIVIEN = default(EntityRef<QUANTRIVIEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manv", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string manv
		{
			get
			{
				return this._manv;
			}
			set
			{
				if ((this._manv != value))
				{
					this.OnmanvChanging(value);
					this.SendPropertyChanging();
					this._manv = value;
					this.SendPropertyChanged("manv");
					this.OnmanvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tennv", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string tennv
		{
			get
			{
				return this._tennv;
			}
			set
			{
				if ((this._tennv != value))
				{
					this.OntennvChanging(value);
					this.SendPropertyChanging();
					this._tennv = value;
					this.SendPropertyChanged("tennv");
					this.OntennvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioitinh", DbType="NVarChar(3) NOT NULL", CanBeNull=false)]
		public string gioitinh
		{
			get
			{
				return this._gioitinh;
			}
			set
			{
				if ((this._gioitinh != value))
				{
					this.OngioitinhChanging(value);
					this.SendPropertyChanging();
					this._gioitinh = value;
					this.SendPropertyChanged("gioitinh");
					this.OngioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cmnd", DbType="Char(9) NOT NULL", CanBeNull=false)]
		public string cmnd
		{
			get
			{
				return this._cmnd;
			}
			set
			{
				if ((this._cmnd != value))
				{
					this.OncmndChanging(value);
					this.SendPropertyChanging();
					this._cmnd = value;
					this.SendPropertyChanged("cmnd");
					this.OncmndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dienthoai", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string dienthoai
		{
			get
			{
				return this._dienthoai;
			}
			set
			{
				if ((this._dienthoai != value))
				{
					this.OndienthoaiChanging(value);
					this.SendPropertyChanging();
					this._dienthoai = value;
					this.SendPropertyChanged("dienthoai");
					this.OndienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_capnhat", DbType="NChar(10)")]
		public string capnhat
		{
			get
			{
				return this._capnhat;
			}
			set
			{
				if ((this._capnhat != value))
				{
					this.OncapnhatChanging(value);
					this.SendPropertyChanging();
					this._capnhat = value;
					this.SendPropertyChanged("capnhat");
					this.OncapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_MUONSACH", Storage="_MUONSACHes", ThisKey="manv", OtherKey="manv")]
		public EntitySet<MUONSACH> MUONSACHes
		{
			get
			{
				return this._MUONSACHes;
			}
			set
			{
				this._MUONSACHes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_QUANTRIVIEN", Storage="_QUANTRIVIEN", ThisKey="manv", OtherKey="manv", IsUnique=true, IsForeignKey=false)]
		public QUANTRIVIEN QUANTRIVIEN
		{
			get
			{
				return this._QUANTRIVIEN.Entity;
			}
			set
			{
				QUANTRIVIEN previousValue = this._QUANTRIVIEN.Entity;
				if (((previousValue != value) 
							|| (this._QUANTRIVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QUANTRIVIEN.Entity = null;
						previousValue.NHANVIEN = null;
					}
					this._QUANTRIVIEN.Entity = value;
					if ((value != null))
					{
						value.NHANVIEN = this;
					}
					this.SendPropertyChanged("QUANTRIVIEN");
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
		
		private void attach_MUONSACHes(MUONSACH entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = this;
		}
		
		private void detach_MUONSACHes(MUONSACH entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QUANTRIVIEN")]
	public partial class QUANTRIVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _manv;
		
		private string _matkhau;
		
		private EntityRef<NHANVIEN> _NHANVIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmanvChanging(string value);
    partial void OnmanvChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    #endregion
		
		public QUANTRIVIEN()
		{
			this._NHANVIEN = default(EntityRef<NHANVIEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manv", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string manv
		{
			get
			{
				return this._manv;
			}
			set
			{
				if ((this._manv != value))
				{
					if (this._NHANVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmanvChanging(value);
					this.SendPropertyChanging();
					this._manv = value;
					this.SendPropertyChanged("manv");
					this.OnmanvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="Char(5) NOT NULL", CanBeNull=false)]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_QUANTRIVIEN", Storage="_NHANVIEN", ThisKey="manv", OtherKey="manv", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public NHANVIEN NHANVIEN
		{
			get
			{
				return this._NHANVIEN.Entity;
			}
			set
			{
				NHANVIEN previousValue = this._NHANVIEN.Entity;
				if (((previousValue != value) 
							|| (this._NHANVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHANVIEN.Entity = null;
						previousValue.QUANTRIVIEN = null;
					}
					this._NHANVIEN.Entity = value;
					if ((value != null))
					{
						value.QUANTRIVIEN = this;
						this._manv = value.manv;
					}
					else
					{
						this._manv = default(string);
					}
					this.SendPropertyChanged("NHANVIEN");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SACH")]
	public partial class SACH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _masach;
		
		private string _tensach;
		
		private string _theloai;
		
		private string _mota;
		
		private string _namxb;
		
		private string _nhaxuatban;
		
		private string _tacgia;
		
		private System.Nullable<int> _soluong;
		
		private string _capnhat;
		
		private EntitySet<SACHMUON> _SACHMUONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmasachChanging(string value);
    partial void OnmasachChanged();
    partial void OntensachChanging(string value);
    partial void OntensachChanged();
    partial void OntheloaiChanging(string value);
    partial void OntheloaiChanged();
    partial void OnmotaChanging(string value);
    partial void OnmotaChanged();
    partial void OnnamxbChanging(string value);
    partial void OnnamxbChanged();
    partial void OnnhaxuatbanChanging(string value);
    partial void OnnhaxuatbanChanged();
    partial void OntacgiaChanging(string value);
    partial void OntacgiaChanged();
    partial void OnsoluongChanging(System.Nullable<int> value);
    partial void OnsoluongChanged();
    partial void OncapnhatChanging(string value);
    partial void OncapnhatChanged();
    #endregion
		
		public SACH()
		{
			this._SACHMUONs = new EntitySet<SACHMUON>(new Action<SACHMUON>(this.attach_SACHMUONs), new Action<SACHMUON>(this.detach_SACHMUONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masach", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string masach
		{
			get
			{
				return this._masach;
			}
			set
			{
				if ((this._masach != value))
				{
					this.OnmasachChanging(value);
					this.SendPropertyChanging();
					this._masach = value;
					this.SendPropertyChanged("masach");
					this.OnmasachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tensach", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tensach
		{
			get
			{
				return this._tensach;
			}
			set
			{
				if ((this._tensach != value))
				{
					this.OntensachChanging(value);
					this.SendPropertyChanging();
					this._tensach = value;
					this.SendPropertyChanged("tensach");
					this.OntensachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_theloai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string theloai
		{
			get
			{
				return this._theloai;
			}
			set
			{
				if ((this._theloai != value))
				{
					this.OntheloaiChanging(value);
					this.SendPropertyChanging();
					this._theloai = value;
					this.SendPropertyChanged("theloai");
					this.OntheloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mota", DbType="NVarChar(100)")]
		public string mota
		{
			get
			{
				return this._mota;
			}
			set
			{
				if ((this._mota != value))
				{
					this.OnmotaChanging(value);
					this.SendPropertyChanging();
					this._mota = value;
					this.SendPropertyChanged("mota");
					this.OnmotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namxb", DbType="Char(4)")]
		public string namxb
		{
			get
			{
				return this._namxb;
			}
			set
			{
				if ((this._namxb != value))
				{
					this.OnnamxbChanging(value);
					this.SendPropertyChanging();
					this._namxb = value;
					this.SendPropertyChanged("namxb");
					this.OnnamxbChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nhaxuatban", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nhaxuatban
		{
			get
			{
				return this._nhaxuatban;
			}
			set
			{
				if ((this._nhaxuatban != value))
				{
					this.OnnhaxuatbanChanging(value);
					this.SendPropertyChanging();
					this._nhaxuatban = value;
					this.SendPropertyChanged("nhaxuatban");
					this.OnnhaxuatbanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tacgia", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tacgia
		{
			get
			{
				return this._tacgia;
			}
			set
			{
				if ((this._tacgia != value))
				{
					this.OntacgiaChanging(value);
					this.SendPropertyChanging();
					this._tacgia = value;
					this.SendPropertyChanged("tacgia");
					this.OntacgiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int")]
		public System.Nullable<int> soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_capnhat", DbType="NChar(10)")]
		public string capnhat
		{
			get
			{
				return this._capnhat;
			}
			set
			{
				if ((this._capnhat != value))
				{
					this.OncapnhatChanging(value);
					this.SendPropertyChanging();
					this._capnhat = value;
					this.SendPropertyChanged("capnhat");
					this.OncapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SACH_SACHMUON", Storage="_SACHMUONs", ThisKey="masach", OtherKey="masach")]
		public EntitySet<SACHMUON> SACHMUONs
		{
			get
			{
				return this._SACHMUONs;
			}
			set
			{
				this._SACHMUONs.Assign(value);
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
		
		private void attach_SACHMUONs(SACHMUON entity)
		{
			this.SendPropertyChanging();
			entity.SACH = this;
		}
		
		private void detach_SACHMUONs(SACHMUON entity)
		{
			this.SendPropertyChanging();
			entity.SACH = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SACHMUON")]
	public partial class SACHMUON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idmuons;
		
		private string _masach;
		
		private EntityRef<MUONSACH> _MUONSACH;
		
		private EntityRef<SACH> _SACH;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidmuonsChanging(int value);
    partial void OnidmuonsChanged();
    partial void OnmasachChanging(string value);
    partial void OnmasachChanged();
    #endregion
		
		public SACHMUON()
		{
			this._MUONSACH = default(EntityRef<MUONSACH>);
			this._SACH = default(EntityRef<SACH>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idmuons", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idmuons
		{
			get
			{
				return this._idmuons;
			}
			set
			{
				if ((this._idmuons != value))
				{
					if (this._MUONSACH.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidmuonsChanging(value);
					this.SendPropertyChanging();
					this._idmuons = value;
					this.SendPropertyChanged("idmuons");
					this.OnidmuonsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masach", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string masach
		{
			get
			{
				return this._masach;
			}
			set
			{
				if ((this._masach != value))
				{
					if (this._SACH.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmasachChanging(value);
					this.SendPropertyChanging();
					this._masach = value;
					this.SendPropertyChanged("masach");
					this.OnmasachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MUONSACH_SACHMUON", Storage="_MUONSACH", ThisKey="idmuons", OtherKey="idmuons", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public MUONSACH MUONSACH
		{
			get
			{
				return this._MUONSACH.Entity;
			}
			set
			{
				MUONSACH previousValue = this._MUONSACH.Entity;
				if (((previousValue != value) 
							|| (this._MUONSACH.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MUONSACH.Entity = null;
						previousValue.SACHMUONs.Remove(this);
					}
					this._MUONSACH.Entity = value;
					if ((value != null))
					{
						value.SACHMUONs.Add(this);
						this._idmuons = value.idmuons;
					}
					else
					{
						this._idmuons = default(int);
					}
					this.SendPropertyChanged("MUONSACH");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SACH_SACHMUON", Storage="_SACH", ThisKey="masach", OtherKey="masach", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public SACH SACH
		{
			get
			{
				return this._SACH.Entity;
			}
			set
			{
				SACH previousValue = this._SACH.Entity;
				if (((previousValue != value) 
							|| (this._SACH.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SACH.Entity = null;
						previousValue.SACHMUONs.Remove(this);
					}
					this._SACH.Entity = value;
					if ((value != null))
					{
						value.SACHMUONs.Add(this);
						this._masach = value.masach;
					}
					else
					{
						this._masach = default(string);
					}
					this.SendPropertyChanged("SACH");
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
