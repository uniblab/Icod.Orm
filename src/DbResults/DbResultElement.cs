using System.Linq;

namespace Icod.Orm.DbMap { 

	/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name=""]/*'/>
	[System.Serializable]
	public class DbResultElement : System.Configuration.ConfigurationElement, INamedConfigurationElement { 

		#region .ctor
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name=".#ctor"]/*'/>
		public DbResultElement() : base() {
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name=".#ctor(System.String)"]/*'/>
		public DbResultElement( System.String name ) : this() { 
			this.Name = name;
		}
		#endregion .ctor


		#region properties
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="Name"]/*'/>
		[System.Configuration.ConfigurationProperty( "name", DefaultValue = "", IsRequired = true, IsKey = true )]
		public System.String Name {
			get {
				return (System.String)this[ "name" ];
			}
			set {
				this[ "name" ] = value;
			}
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="Columns"]/*'/>
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
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetOrdinals(System.Data.Common.DbDataReader)"]/*'/>
		public System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> GetOrdinals( System.Data.Common.DbDataReader reader ) { 
			return this.Columns.GetOrdinals( reader );
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetProperties(System.Type)"]/*'/>
		public System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> GetProperties( System.Type type ) { 
			return this.Columns.GetProperties( type );
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="SetPropertyValues(System.Data.Common.DbDataReader,System.Object)"]/*'/>
		public void SetPropertyValues( System.Data.Common.DbDataReader reader, System.Object @object ) { 
			if ( null == @object ) { 
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			if ( reader.HasRows ) { 
				this.Columns.SetPropertyValues( reader, @object );
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="SetPropertyValues(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Object)"]/*'/>
		public void SetPropertyValues( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, System.Object @object ) { 
			if ( null == @object ) { 
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( ( null == properties ) || ( properties.Count <= 0 ) ) { 
				throw new System.ArgumentNullException( nameof( properties ) );
			} else if ( ( null == ordinals ) || ( ordinals.Count <= 0 ) ) { 
				throw new System.ArgumentNullException( nameof( ordinals ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			if ( reader.HasRows ) { 
				DbColumnCollection.SetPropertyValues( reader, ordinals, properties, @object );
			}
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult`1(System.Data.Common.DbDataReader,System.Object)"]/*'/>
		public void GetResult<R>( System.Data.Common.DbDataReader reader, R @object ) { 
			if ( null == @object ) { 
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			if ( reader.HasRows ) { 
				this.Columns.SetPropertyValues( reader, @object );
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult`1(System.Data.Common.DbDataReader,System.Func`1)"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader, System.Func<R> activator ) { 
			if ( null == activator ) { 
				throw new System.ArgumentNullException( nameof( activator ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			R r = default( R );
			if ( reader.HasRows ) { 
				r = activator();
				this.GetResult<R>( reader, r );
			}
			return r;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult`1(System.Data.Common.DbDataReader)"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader ) where R : new() {
			if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			return this.GetResult<R>( reader, () => new R() );
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult`1(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Object)"]/*'/>
		public void GetResult<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, R @object ) { 
			if ( null == @object ) { 
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}
			if ( reader.HasRows ) { 
				DbColumnCollection.SetPropertyValues( reader, ordinals, properties, @object );
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult`1(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Func`1)"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, System.Func<R> activator ) { 
			if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			R r = default( R );
			if ( reader.HasRows ) { 
				r = activator();
				this.GetResult<R>( reader, ordinals, properties, r );
			}
			return r;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResult`1(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2)"]/*'/>
		public R GetResult<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties ) where R : new() { 
			if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			return this.GetResult<R>( reader, ordinals, properties, () => new R() );
		}

		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults`1(System.Data.Common.DbDataReader,System.Func`1)"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader, System.Func<R> activator ) { 
			if ( null == activator ) { 
				throw new System.ArgumentNullException( nameof( activator ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			if ( reader.HasRows ) { 
				foreach ( var r in this.GetResults<R>( reader, this.Columns.GetOrdinals( reader ), this.Columns.GetProperties( typeof( R ) ), activator ) ) { 
					yield return r;
				}
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults`1(System.Data.Common.DbDataReader)"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader ) where R : new() { 
			if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			if ( reader.HasRows ) { 
				foreach( var r in this.GetResults<R>( reader, () => new R() ) ) { 
					yield return r;
				}
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults`1(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2,System.Func`1)"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties, System.Func<R> activator ) { 
			if ( null == activator ) { 
				throw new System.ArgumentNullException( nameof( activator ) );
			} else if ( null == properties ) { 
				throw new System.ArgumentNullException( nameof( properties ) );
			} else if ( null == ordinals ) { 
				throw new System.ArgumentNullException( nameof( ordinals ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			if ( reader.HasRows ) { 
				R r;
				while ( reader.Read() ) { 
					r = activator();
					this.GetResult<R>( reader, ordinals, properties, r );
					yield return r;
				}
			}
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbResultElement"]/member[@name="GetResults`1(System.Data.Common.DbDataReader,System.Collections.Generic.IDictionary`2,System.Collections.Generic.IDictionary`2)"]/*'/>
		public System.Collections.Generic.IEnumerable<R> GetResults<R>( System.Data.Common.DbDataReader reader, System.Collections.Generic.IDictionary<DbColumnElement, System.Int32> ordinals, System.Collections.Generic.IDictionary<DbColumnElement, System.Reflection.PropertyInfo> properties ) where R : new() { 
			if ( null == properties ) { 
				throw new System.ArgumentNullException( nameof( properties ) );
			} else if ( null == ordinals ) { 
				throw new System.ArgumentNullException( nameof( ordinals ) );
			} else if ( ( null == reader ) || reader.IsClosed ) { 
				throw new System.ArgumentNullException( nameof( reader ) );
			}

			if ( reader.HasRows ) { 
				foreach ( var r in this.GetResults<R>( reader, ordinals, properties, () => new R() ) ) { 
					yield return r;
				}
			}
		}
		#endregion methods

	}

}