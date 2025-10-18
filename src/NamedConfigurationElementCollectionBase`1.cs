using System.Linq;
using Icod.Helpers;

namespace Icod.Orm {

	/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name=""]/*'/>
	[System.Serializable]
	public abstract class NamedConfigurationElementCollectionBase<T> : Icod.Orm.ConfigurationElementCollectionBase<T> where T : System.Configuration.ConfigurationElement, INamedConfigurationElement, new() {

		#region .ctor
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor"]/*'/>
		protected NamedConfigurationElementCollectionBase() : base() { 
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor(System.Collections.IComparer)"]/*'/>
		protected NamedConfigurationElementCollectionBase( System.Collections.IComparer comparer ) : base( comparer ) { 
		}
		#endregion .ctor


		#region properties
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="CollectionType"]/*'/>
		public override System.Configuration.ConfigurationElementCollectionType CollectionType { 
			get { 
				return System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="this[System.Int32]"]/*'/>
		public virtual T this[ System.Int32 index ] { 
			get { 
				return (T)this.BaseGet( index );
			}
			set { 
				if ( null != this.BaseGet( index ) ) { 
					this.BaseRemoveAt( index );
				}
				this.BaseAdd( index, value );
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="this[System.String]"]/*'/>
		new public virtual T this[ System.String name ] { 
			get { 
				return (T)this.BaseGet( name );
			}
		}
		#endregion properties


		#region methods
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="CreateNewElement(System.String)"]/*'/>
		protected override System.Configuration.ConfigurationElement CreateNewElement( System.String elementName ) {
			T output = new T {
				Name = elementName
			};
			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="GetElementKey(System.Configuration.ConfigurationElement)"]/*'/>
		protected override System.Object GetElementKey( System.Configuration.ConfigurationElement element ) { 
			return ( (T)element ).Name;
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="Remove(`0)"]/*'/>
		public virtual void Remove( T element ) { 
			if ( null == element ) { 
				return;
			}
			if ( 0 <= this.IndexOf( element ) ) { 
				this.BaseRemove( element.Name );
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="Remove(System.String)"]/*'/>
		public virtual void Remove( System.String key ) {
			this.BaseRemove( key.TrimToNull() );
		}
		#endregion methods

	}

}