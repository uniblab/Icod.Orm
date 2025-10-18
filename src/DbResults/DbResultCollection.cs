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

	/// <include file='.\Doc\DbResults\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultCollection"]/member[@name=""]/*'/>
	[System.Serializable]
	public class DbResultCollection : NamedConfigurationElementCollectionBase<DbResultElement> {

		#region .ctor
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name=".#ctor"]/*'/>
		public DbResultCollection() : base() {
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name=".#ctor(System.Collections.IComparer)"]/*'/>
		public DbResultCollection( System.Collections.IComparer comparer ) : base( comparer ) {
		}
		#endregion .ctor

	}

}