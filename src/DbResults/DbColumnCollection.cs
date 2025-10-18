/*
	DbColumnCollection contains DbColumnElement instances.
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

using System.Linq;

namespace Icod.Orm.DbMap {

	/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name=""]/*'/>
	[System.Serializable]
	public class DbColumnCollection : NamedConfigurationElementCollectionBase<DbColumnElement> {

		#region .ctor
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor"]/*'/>
		public DbColumnCollection() : base() {
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor(System.Collections.IComparer)"]/*'/>
		public DbColumnCollection( System.Collections.IComparer comparer ) : base( comparer ) {
		}
		#endregion .ctor


		#region methods
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="GetOrdinals(System.Data.Common.DbDataReader)"]/*'/>
		public System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> GetOrdinals( System.Data.Common.DbDataReader reader ) {
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

			var map = new System.Collections.Generic.Dictionary<DbColumnElement, System.Int32>( System.Math.Max( 1, this.Count ) );
			foreach ( var c in this.OfType<DbColumnElement>().Where(
				x => ( null != x )
			) ) {
				if ( c.IsRequired ) {
					map.Add( c, c.GetOrdinal( reader ) );
				} else {
					if ( c.TryGetOrdinal( reader, out System.Int32 ordinal ) ) {
						map.Add( c, ordinal );
					}
				}
			}
			return map;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="TryGetOrdinals(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2@)"]/*'/>
		public System.Boolean TryGetOrdinals( System.Data.Common.DbDataReader reader, out System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals ) {
			ordinals = null;

			var output = false;
			try {
				ordinals = this.GetOrdinals( reader );
				output = true;
			} catch ( System.Exception ) {
				;
			}

			return output;
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="GetProperties(System.Type)"]/*'/>
		public System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> GetProperties( System.Type type ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( type, nameof( type ) );
#else
			if ( null == type ) {
				throw new System.ArgumentNullException( nameof( type ) );
			}
#endif

			var map = new System.Collections.Generic.Dictionary<DbColumnElement, System.Reflection.PropertyInfo>( System.Math.Max( 1, this.Count ) );
			foreach ( var c in this.OfType<DbColumnElement>().Where(
				x => ( null != x )
			) ) {
				if ( c.TryGetProperty( type, out System.Reflection.PropertyInfo pi ) ) {
					map.Add( c, pi );
				}
			}
			return map;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="TryGetProperties(System.Type,System.Collections.Generic.IDictionary`2@)"]/*'/>
		public System.Boolean TryGetProperties( System.Type type, out System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties ) {
			properties = null;

			var output = false;
			try {
				properties = this.GetProperties( type );
				output = true;
			} catch ( System.Exception ) {
				;
			}
			return output;
		}
		#endregion methods


		#region static methods
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="SetPropertyValues(System.Data.Common.DbDataReader,System.Object)"]/*'/>
		public void SetPropertyValues( System.Data.Common.DbDataReader reader, System.Object @object ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( @object, nameof( @object ) );
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == @object ) {
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif

			if ( reader.HasRows ) {
				DbColumnCollection.SetPropertyValues( reader, this.GetOrdinals( reader ), this.GetProperties( @object.GetType() ), @object );
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbColumnCollection"]/member[@name="SetPropertyValues(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Object)"]/*'/>
		public static void SetPropertyValues( 
			System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, 
			System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, 
			System.Object @object 
		) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( @object, nameof( @object ) );
			System.ArgumentNullException.ThrowIfNull( properties, nameof( properties ) );
			System.ArgumentNullException.ThrowIfNull( ordinals, nameof( ordinals ) );
			System.ArgumentNullException.ThrowIfNull( reader, nameof( reader ) );
			System.ObjectDisposedException.ThrowIf( reader.IsClosed, reader );
#else
			if ( null == @object ) {
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( null == properties ) {
				throw new System.ArgumentNullException( nameof( properties ) );
			} else if ( null == ordinals ) {
				throw new System.ArgumentNullException( nameof( ordinals ) );
			} else if ( null == reader ) {
				throw new System.ArgumentNullException( nameof( reader ) );
			} else if ( reader.IsClosed ) {
				throw new System.ObjectDisposedException( nameof( reader ) );
			}
#endif
			if ( ordinals.Count <= 0 ) {
				throw new System.ArgumentException( "The collection may not be empty.", nameof( ordinals ) );
			} else if ( properties.Count <= 0 ) {
				throw new System.ArgumentException( "The collection may not be empty.", nameof( properties ) );
			}

			if ( reader.HasRows ) {
				System.Int32 fc = reader.FieldCount;
				System.Int32 o;
				DbColumnElement key;
				foreach ( var kvp in properties.Where<System.Collections.Generic.KeyValuePair<DbColumnElement, System.Reflection.PropertyInfo>>(
					x => {
						if ( null == x.Value ) {
							return false;
						}
						var k = x.Key;
						if ( k.Skip ) {
							return false;
						}
						if ( !ordinals.ContainsKey( k ) ) {
							return false;
						}
						o = ordinals[ k ];
						return (
							( 0 <= o ) && ( o < fc )
						);
					}
				) ) {
					key = kvp.Key;
					key.SetPropertyValue( reader, ordinals[ kvp.Key ], kvp.Value, @object );
				}
			}
		}
		#endregion static methods

	}

}