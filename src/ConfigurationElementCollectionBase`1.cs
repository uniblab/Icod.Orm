/*
	ConfigurationElementCollectionBase<T> is the base class for
	working with ConfigurationElement instances in the Icod.Orm.
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

namespace Icod.Orm {

	/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=""]/*'/>
	[System.Serializable]
	public abstract class ConfigurationElementCollectionBase<T> : System.Configuration.ConfigurationElementCollection where T : System.Configuration.ConfigurationElement, new() { 

		#region .ctor
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor"]/*'/>
		protected ConfigurationElementCollectionBase() : base() { 
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor(System.Collections.IComparer)"]/*'/>
		protected ConfigurationElementCollectionBase( System.Collections.IComparer comparer ) : base( comparer ) { 
		}
		#endregion .ctor


		#region methods
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name="IndexOf(`0)"]/*'/>
		public virtual System.Int32 IndexOf( T element ) {
			return this.BaseIndexOf( element );
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name="CreateNewElement()"]/*'/>
		protected override System.Configuration.ConfigurationElement CreateNewElement() { 
			return new T();
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name="Add(`0)"]/*'/>
		public virtual void Add( T element ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( element, nameof( element ) );
#else
			if ( null == element ) {
				throw new System.ArgumentNullException( nameof( element ) );
			}
#endif
			this.BaseAdd( element );
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name="RemoveAt(System.Int32)"]/*'/>
		public virtual void RemoveAt( System.Int32 index ) {
#if NET8_0_OR_GREATER
			System.ArgumentOutOfRangeException.ThrowIfNegative( index, nameof( index ) );
			System.ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual( index, this.Count, nameof( index ) );
#else
			if ( index < 0 ) {
				throw new System.ArgumentOutOfRangeException( nameof( index ), index, System.String.Format( "{0} may not be negative.", nameof( index ) ) );
			} else if ( this.Count <= index ) {
				throw new System.ArgumentOutOfRangeException( nameof( index ), index, System.String.Format( "{0} may not be greater-than or equal-to {1}.", nameof( index ), this.Count ) );
			}
#endif
			this.BaseRemoveAt( index );
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name="Clear()"]/*'/>
		public virtual void Clear() { 
			this.BaseClear();
		}
		#endregion methods

	}

}