using System.Linq;

namespace Icod.Orm.DbMap {

	/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterCollection"]/member[@name=""]/*'/>
	[System.Serializable]
	public class DbParameterCollection : NamedConfigurationElementCollectionBase<DbParameterElement> {

		#region .ctor
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor"]/*'/>
		public DbParameterCollection() : base() { 
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.ConfigurationElementCollectionBase`1"]/member[@name=".#ctor(System.Collections.IComparer)"]/*'/>
		public DbParameterCollection( System.Collections.IComparer comparer ) : base( comparer ) { 
		}
		#endregion .ctor


		#region methods
		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterCollection"]/member[@name="ToDbParameters(System.Data.Common.DbCommand)"]/*'/>
		public System.Collections.Generic.IEnumerable<System.Data.Common.DbParameter> ToDbParameters( System.Data.Common.DbCommand command ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			foreach ( var p in this.OfType<DbParameterElement>().Where( 
				x => null != x 
			) ) { 
				yield return p.ToDbParameter( command );
			}
		}
		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterCollection"]/member[@name="ToDbParameters(System.Data.Common.DbCommand,System.Action`1)"]/*'/>
		public System.Collections.Generic.IEnumerable<System.Data.Common.DbParameter> ToDbParameters( System.Data.Common.DbCommand command, System.Action<System.Data.Common.DbParameter> prepare ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			foreach ( var p in this.OfType<DbParameterElement>().Where( 
				x => null != x 
			) ) { 
				yield return p.ToDbParameter( command, prepare: prepare );
			}
		}
		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterCollection"]/member[@name="ToDbParameters(System.Data.Common.DbCommand,System.Object)"]/*'/>
		public System.Collections.Generic.IEnumerable<System.Data.Common.DbParameter> ToDbParameters( System.Data.Common.DbCommand command, System.Object @object ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( @object, nameof( @object ) );
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == @object ) {
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			var pi = this.GetInputProperties( @object.GetType() );
			foreach ( var p in this.OfType<DbParameterElement>().Where(
				x => null != x 
			) ) {
				if ( pi.ContainsKey( p ) ) {
					yield return p.ToDbParameter( command, pi[ p ], @object );
				} else {
					yield return p.ToDbParameter( command );
				}
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterCollection"]/member[@name="GetInputProperties(System.Type)"]/*'/>
		public System.Collections.Generic.IDictionary<DbParameterElement, System.Reflection.PropertyInfo> GetInputProperties( System.Type type ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( type, nameof( type ) );
#else
			if ( null == type ) {
				throw new System.ArgumentNullException( nameof( type ) );
			}
#endif
			var map = new System.Collections.Generic.Dictionary<DbParameterElement, System.Reflection.PropertyInfo>( this.Count );
			System.Reflection.PropertyInfo pi;
			foreach ( var p in this.OfType<DbParameterElement>().Where( 
				x => ( null != x ) 
			).Where( 
				x => ( 
					( System.Data.ParameterDirection.Input == x.Direction ) 
					|| ( System.Data.ParameterDirection.InputOutput == x.Direction ) 
				) 
			) ) { 
				pi = p.GetInputProperty( type );
				if ( null != pi ) { 
					map.Add( p, pi );
				}
			}
			return map;
		}
		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterCollection"]/member[@name="GetOutputProperties(System.Type)"]/*'/>
		public System.Collections.Generic.IDictionary<DbParameterElement, System.Reflection.PropertyInfo> GetOutputProperties( System.Type type ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( type, nameof( type ) );
#else
			if ( null == type ) {
				throw new System.ArgumentNullException( nameof( type ) );
			}
#endif
			var map = new System.Collections.Generic.Dictionary<DbParameterElement, System.Reflection.PropertyInfo>( this.Count );
			System.Reflection.PropertyInfo pi;
			foreach ( var p in this.OfType<DbParameterElement>().Where( 
				x => ( null != x ) 
			).Where( 
				x => ( 
					( System.Data.ParameterDirection.Output == x.Direction ) 
					|| ( System.Data.ParameterDirection.InputOutput == x.Direction ) 
					|| ( System.Data.ParameterDirection.ReturnValue == x.Direction ) 
				) 
			) ) { 
				pi = p.GetOutputProperty( type );
				if ( null != pi ) { 
					map.Add( p, pi );
				}
			}
			return map;
		}
		#endregion methods

	}

}