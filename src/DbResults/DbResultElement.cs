/*
	DbResultElement maps a result set to a collection of objects.
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

using System;

namespace Icod.Orm.DbMap { 

	/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name=""]/*'/>
	[System.Serializable]
	public class DbResultElement : System.Configuration.ConfigurationElement, INamedConfigurationElement {

		#region .ctor
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name=".#ctor"]/*'/>
		public DbResultElement() : base() {
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name=".#ctor(System.String)"]/*'/>
		public DbResultElement( System.String name ) : this() { 
			this.Name = name;
		}
		#endregion .ctor


		#region properties
		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.INamedConfigurationElement"]/member[@name="Name"]/*'/>
		[System.Configuration.ConfigurationProperty( "name", DefaultValue = "", IsRequired = true, IsKey = true )]
		public System.String Name {
			get {
				return (System.String)this[ "name" ];
			}
			set {
				this[ "name" ] = value;
			}
		}

		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="Columns"]/*'/>
		[System.Configuration.ConfigurationProperty( "", IsDefaultCollection = true, IsRequired = false )]
		[System.Configuration.ConfigurationCollection( typeof( DbColumnCollection ),
			AddItemName = "add",
			ClearItemsName = "clear",
			RemoveItemName = "remove"
		)]
		public DbColumnCollection Columns {
			get {
				return (DbColumnCollection)this[ "" ];
			}
		}
		#endregion propertoes


		#region methods
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="GetOrdinals(System.Data.Common.DbDataReader)"]/*'/>
		public System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> GetOrdinals( System.Data.Common.DbDataReader reader ) { 
			return this.Columns.GetOrdinals( reader );
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="GetProperties(System.Type)"]/*'/>
		public System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> GetProperties( System.Type type ) { 
			return this.Columns.GetProperties( type );
		}

		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="SetPropertyValues(System.Data.Common.DbDataReader,System.Object)"]/*'/>
		public void SetPropertyValues( System.Data.Common.DbDataReader reader, System.Object @object ) { 
			if ( reader.HasRows ) { 
				this.Columns.SetPropertyValues( reader, @object );
			}
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="SetPropertyValues(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Object)"]/*'/>
		public void SetPropertyValues( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, System.Object @object ) { 
			if ( reader.HasRows ) { 
				DbColumnCollection.SetPropertyValues( reader, ordinals, properties, @object );
			}
		}

		#region GetResult
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult{R}(System.Data.Common.DbDataReader,{R})"]/*'/>
		public void GetResult<R>( System.Data.Common.DbDataReader reader, R @object ) {
			this.Columns.SetPropertyValues( reader, @object );
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult{R}(System.Data.Common.DbDataReader,System.Func{R})"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader, System.Func<R> activator ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( activator, nameof( activator ) );
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == activator ) {
				throw new System.ArgumentNullException( nameof( activator ) );
			} else if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif

			R r = default( R );
			if ( reader.HasRows ) { 
				r = activator();
				this.GetResult<R>( reader, r );
			}
			return r;
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult{R}(System.Data.Common.DbDataReader)"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader ) where R : new() {
			return this.GetResult<R>( reader, () => new R() );
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult{R}(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,{R})"]/*'/>
		public void GetResult<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, R @object ) {
			DbColumnCollection.SetPropertyValues( reader, ordinals, properties, @object );
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult{R}(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Func{R})"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, System.Func<R> activator ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( activator, nameof( activator ) );
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == activator ) {
				throw new System.ArgumentNullException( nameof( activator ) );
			} else if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif

			R r = default( R );
			if ( reader.HasRows ) { 
				r = activator();
				this.GetResult<R>( reader, ordinals, properties, r );
			}
			return r;
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult{R}(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2)"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties ) where R : new() {
			return this.GetResult<R>( reader, ordinals, properties, () => new R() );
		}
		#endregion GetResult

		#region GetResults
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults{R}(System.Data.Common.DbDataReader,System.Func{R})"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader, System.Func<R> activator ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( activator, nameof( activator ) );
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == activator ) {
				throw new System.ArgumentNullException( nameof( activator ) );
			} else if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif

			if ( reader.HasRows ) {
				foreach ( var r in this.GetResults<R>( reader, this.Columns.GetOrdinals( reader ), this.Columns.GetProperties( typeof( R ) ), activator ) ) {
					yield return r;
				}
			}
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults{R}(System.Data.Common.DbDataReader)"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader ) where R : new() {
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

			if ( reader.HasRows ) { 
				foreach( var r in this.GetResults<R>( reader, () => new R() ) ) { 
					yield return r;
				}
			}
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults{R}(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Func{R})"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, System.Func<R> activator ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( activator, nameof( activator ) );
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == activator ) {
				throw new System.ArgumentNullException( nameof( activator ) );
			} else if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif

			if ( reader.HasRows ) {
				R r;
				while ( reader.Read() ) {
					r = activator();
					this.GetResult<R>( reader, ordinals, properties, r );
					yield return r;
				}
			}
		}
		/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults{R}(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2)"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties ) where R : new() {
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

			if ( reader.HasRows ) { 
				foreach ( var r in this.GetResults<R>( reader, ordinals, properties, () => new R() ) ) { 
					yield return r;
				}
			}
		}
		#endregion GetResults
		#endregion methods

	}

}