﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace лаба2_Медиа
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aero")]
	public partial class AeroDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertVideos(Videos instance);
    partial void UpdateVideos(Videos instance);
    partial void DeleteVideos(Videos instance);
    #endregion
		
		public AeroDataContext() : 
				base(global::лаба2_Медиа.Properties.Settings.Default.aeroConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AeroDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AeroDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AeroDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AeroDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Videos> Videos
		{
			get
			{
				return this.GetTable<Videos>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Videos")]
	public partial class Videos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FileName;
		
		private System.Nullable<int> _Width;
		
		private System.Nullable<int> _Heigth;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnWidthChanging(System.Nullable<int> value);
    partial void OnWidthChanged();
    partial void OnHeigthChanging(System.Nullable<int> value);
    partial void OnHeigthChanged();
    #endregion
		
		public Videos()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="Int")]
		public System.Nullable<int> Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				if ((this._Width != value))
				{
					this.OnWidthChanging(value);
					this.SendPropertyChanging();
					this._Width = value;
					this.SendPropertyChanged("Width");
					this.OnWidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Heigth", DbType="Int")]
		public System.Nullable<int> Heigth
		{
			get
			{
				return this._Heigth;
			}
			set
			{
				if ((this._Heigth != value))
				{
					this.OnHeigthChanging(value);
					this.SendPropertyChanging();
					this._Heigth = value;
					this.SendPropertyChanged("Heigth");
					this.OnHeigthChanged();
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
