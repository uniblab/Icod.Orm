/*
	DbColumnElement maps a database column to an object property.
*/
/*
    Icod.Orm is the lght-weight and super-efficient ORM by Icod.
    Copyright (C) 2025  Timothy J. Bruce

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 3 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
    USA
 
*/

using Icod.Helpers;

namespace Icod.Orm.DbMap {

	/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name=""]/*'/>
	[System.Serializable]
	public class DbColumnElement : System.Configuration.ConfigurationElement, INamedConfigurationElement, IDbColumn {

		#region .ctor
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name=".#ctor"]/*'/>
		public DbColumnElement() : base() {
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name=".#ctor(System.String)"]/*'/>
		public DbColumnElement( System.String name ) : this() {
			this.Name = name;
		}
		#endregion .ctor


		#region properties
		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.INamedConfigurationElement"]/member[@name="Name"]/*'/>
		[System.Configuration.ConfigurationProperty( "name", IsRequired = true, IsKey = true )]
		public System.String Name {
			get {
				return (System.String)this[ "name" ];
			}
			set {
				this[ "name" ] = value.TrimToNull();
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IColumnName"]/member[@name="ColumnName"]/*'/>
		[System.Configuration.ConfigurationProperty( "columnName", DefaultValue = (System.String)null, IsRequired = false )]
		public System.String ColumnName {
			get {
				return (System.String)this[ "columnName" ];
			}
			set {
				this[ "columnName" ] = value.TrimToNull();
			}
		}

		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name="PropertyName"]/*'/>
		[System.Configuration.ConfigurationProperty( "propertyName", DefaultValue = (System.String)null, IsRequired = false )]
		public System.String PropertyName {
			get {
				return (System.String)this[ "propertyName" ];
			}
			set {
				this[ "propertyName" ] = value.TrimToNull();
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="TypeCode"]/*'/>
		[System.Configuration.ConfigurationProperty( "typeCode", DefaultValue = System.TypeCode.Object, IsRequired = false )]
		public System.TypeCode TypeCode {
			get {
				return (System.TypeCode)this[ "typeCode" ];
			}
			set {
				this[ "typeCode" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="DbType"]/*'/>
		[System.Configuration.ConfigurationProperty( "dbType", DefaultValue = System.Data.DbType.Object, IsRequired = false )]
		public System.Data.DbType DbType {
			get {
				return (System.Data.DbType)this[ "dbType" ];
			}
			set {
				this[ "dbType" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="SqlDbType"]/*'/>
		[System.Configuration.ConfigurationProperty( "sqlDbType", DefaultValue = System.Data.SqlDbType.Variant, IsRequired = false )]
		public System.Data.SqlDbType SqlDbType {
			get {
				return (System.Data.SqlDbType)this[ "sqlDbType" ];
			}
			set {
				this[ "sqlDbType" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="OleDbType"]/*'/>
		[System.Configuration.ConfigurationProperty( "oleDbType", DefaultValue = System.Data.OleDb.OleDbType.Variant, IsRequired = false )]
		public System.Data.OleDb.OleDbType OleDbType {
			get {
				return (System.Data.OleDb.OleDbType)this[ "oleDbType" ];
			}
			set {
				this[ "oleDbType" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="OdbcType"]/*'/>
		[System.Configuration.ConfigurationProperty( "odbcType", DefaultValue = (System.Data.Odbc.OdbcType)0, IsRequired = false )]
		public System.Data.Odbc.OdbcType OdbcType {
			get {
				return (System.Data.Odbc.OdbcType)this[ "odbcType" ];
			}
			set {
				this[ "odbcType" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="ConvertTo"]/*'/>
		[System.Configuration.ConfigurationProperty( "convertTo", DefaultValue = System.TypeCode.Object, IsRequired = false )]
		public System.TypeCode ConvertTo {
			get {
				return (System.TypeCode)this[ "convertTo" ];
			}
			set {
				this[ "convertTo" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="IsNullable"]/*'/>
		[System.Configuration.ConfigurationProperty( "isNullable", DefaultValue = false, IsRequired = false )]
		public System.Boolean IsNullable {
			get {
				return (System.Boolean)this[ "isNullable" ];
			}
			set {
				this[ "isNullable" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="Skip"]/*'/>
		[System.Configuration.ConfigurationProperty( "skip", DefaultValue = false, IsRequired = false )]
		public System.Boolean Skip {
			get {
				return (System.Boolean)this[ "skip" ];
			}
			set {
				this[ "skip" ] = value;
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="IsRequired"]/*'/>
		[System.Configuration.ConfigurationProperty( "isRequired", DefaultValue = false, IsRequired = false )]
		public System.Boolean IsRequired {
			get {
				return (System.Boolean)this[ "isRequired" ];
			}
			set {
				this[ "isRequired" ] = value;
			}
		}
		#endregion properties


		#region methods
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name="GetOrdinal(System.Data.Common.DbDataReader)"]/*'/>
		public System.Int32 GetOrdinal( System.Data.IDataReader reader ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif
			return reader.GetOrdinal( this );
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name="TryGetOrdinal(System.Data.Common.DbDataReader,System.Int32@)"]/*'/>
		public System.Boolean TryGetOrdinal( System.Data.IDataReader reader, out System.Int32 ordinal ) {
			ordinal = -1;
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif
			return reader.TryGetOrdinal( this, out ordinal );
		}

		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name="GetProperty(System.Type)"]/*'/>
		public System.Reflection.PropertyInfo GetProperty( System.Type type ) {
			var propertyName = this.PropertyName;
			if ( System.String.IsNullOrEmpty( propertyName ) ) {
				propertyName = this.Name;
			}
			return type.GetProperty( propertyName, System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.SetProperty );
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name="TryGetProperty(System.Type,System.Reflection.PropertyInfo@)"]/*'/>
		public System.Boolean TryGetProperty( System.Type type, out System.Reflection.PropertyInfo property ) {
			property = null;

			System.Boolean output = false;
			try {
				property = this.GetProperty( type );
				output = true;
			} catch ( System.Exception ) {
				;
			}
			return output;
		}

		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnElement"]/member[@name="SetPropertyValue(System.Data.Common.DbDataReader,System.Int32,System.Reflection.PropertyInfo,System.Object)"]/*'/>
		public void SetPropertyValue( System.Data.IDataReader reader, System.Int32 ordinal, System.Reflection.PropertyInfo property, System.Object @object ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( @object, nameof( @object ) );
			System.ArgumentNullException.ThrowIfNull( property, nameof( property ) );
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
			System.ArgumentOutOfRangeException.ThrowIfNegative( ordinal, nameof( ordinal ) );
			System.ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( ordinal, reader.FieldCount, nameof( ordinal ) );
#else
			if ( null == @object ) {
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( null == property ) {
				throw new System.ArgumentNullException( nameof( property ) );
			} else if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			} else if (
				( ordinal < 0 )
				|| ( reader.FieldCount <= ordinal )
			) {
				throw new System.ArgumentNullException( "ordinal" );
			}
#endif
			if ( !this.Skip ) {
				property.SetValue( @object, this.GetValue( reader, ordinal ), null );
			}
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="GetValue(System.Data.IDataReader)"]/*'/>
		public System.Object GetValue( System.Data.IDataReader reader ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
#else
			if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			}
#endif
			return reader.IsClosed
				? throw new System.ObjectDisposedException( nameof( reader ) )
				: reader.GetValue( this )
			;
		}
		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="GetValue(System.Data.IDataReader,System.Int32)"]/*'/>
		public System.Object GetValue( System.Data.IDataReader reader, System.Int32 ordinal ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
#else
			if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			}
#endif
			return reader.IsClosed
				? throw new System.ObjectDisposedException( nameof( reader ) )
				: reader.GetValue( this, ordinal )
			;
		}
		#endregion methods

	}

}