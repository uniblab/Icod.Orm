using System.Linq;

namespace Icod.Orm {

	/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.PrepareElement"]/member[@name=""]/*'/>
	[System.Serializable]
	public class PrepareElement : System.Configuration.ConfigurationElement, INamedConfigurationElement {

		#region .ctor
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.PrepareElement"]/member[@name=".#ctor"]/*'/>
		public PrepareElement() : base() {
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.PrepareElement"]/member[@name=".#ctor(System.String)"]/*'/>
		public PrepareElement( System.String name ) : this() {
			this.Name = name;
		}
		#endregion .ctor


		#region properties
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.PrepareElement"]/member[@name="Name"]/*'/>
		[System.Configuration.ConfigurationProperty( "name", IsRequired = true, IsKey = true )]
		public System.String Name {
			get {
				return (System.String)this[ "name" ];
			}
			set {
				this[ "name" ] = value;
			}
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.PrepareElement"]/member[@name="Type"]/*'/>
		[System.Configuration.ConfigurationProperty( "type", DefaultValue = "", IsRequired = false, IsKey = true )]
		public System.String Type {
			get {
				return (System.String)this[ "type" ];
			}
			set {
				this[ "type" ] = value;
			}
		}
		#endregion properties

	}

}