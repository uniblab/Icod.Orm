using Icod.Helpers;
using System;

namespace Icod.Orm.DbMap {

	/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name=""]/*'/>
	[System.Serializable]
	public class DbParameterElement : System.Configuration.ConfigurationElement, INamedConfigurationElement {

		#region .ctor
		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name=".#ctor"]/*'/>
		public DbParameterElement() : base() {
		}
		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name=".#ctor(System.String)"]/*'/>
		public DbParameterElement( System.String name ) : this() {
			this.Name = name;
		}
		#endregion .ctor


		#region properties
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.NamedConfigurationElementCollectionBase`1"]/member[@name="Name"]/*'/>
		[System.Configuration.ConfigurationProperty( "name", DefaultValue = "", IsRequired = true, IsKey = true )]
		public System.String Name {
			get {
				return (System.String)this[ "name" ];
			}
			set {
				this[ "name" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="DbType"]/*'/>
		[System.Configuration.ConfigurationProperty( "dbType", DefaultValue = System.Data.DbType.AnsiString, IsRequired = false )]
		public System.Data.DbType DbType {
			get {
				return (System.Data.DbType)this[ "dbType" ];
			}
			set {
				this[ "dbType" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="Direction"]/*'/>
		[System.Configuration.ConfigurationProperty( "direction", DefaultValue = System.Data.ParameterDirection.Input, IsRequired = false )]
		public System.Data.ParameterDirection Direction {
			get {
				return (System.Data.ParameterDirection)this[ "direction" ];
			}
			set {
				this[ "direction" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ParameterName"]/*'/>
		[System.Configuration.ConfigurationProperty( "parameterName", IsRequired = true )]
		public System.String ParameterName {
			get {
				return (System.String)this[ "parameterName" ];
			}
			set {
				this[ "parameterName" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="Size"]/*'/>
		[System.Configuration.ConfigurationProperty( "size", DefaultValue = (System.Int32)0, IsRequired = false )]
		public System.Int32 Size {
			get {
				return (System.Int32)this[ "size" ];
			}
			set {
				this[ "size" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="Scale"]/*'/>
		[System.Configuration.ConfigurationProperty( "scale", DefaultValue = (System.Byte)0, IsRequired = false )]
		public System.Byte Scale {
			get {
				return (System.Byte)this[ "scale" ];
			}
			set {
				this[ "scale" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="Precision"]/*'/>
		[System.Configuration.ConfigurationProperty( "precision", DefaultValue = (System.Byte)0, IsRequired = false )]
		public System.Byte Precision {
			get {
				return (System.Byte)this[ "precision" ];
			}
			set {
				this[ "precision" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="SourceColumn"]/*'/>
		[System.Configuration.ConfigurationProperty( "sourceColumn", DefaultValue = "", IsRequired = false )]
		public System.String SourceColumn {
			get {
				return (System.String)this[ "sourceColumn" ];
			}
			set {
				this[ "sourceColumn" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="SourceColumnNullMapping"]/*'/>
		[System.Configuration.ConfigurationProperty( "sourceColumnNullMapping", DefaultValue = "false", IsRequired = false )]
		public System.Boolean SourceColumnNullMapping {
			get {
				return (System.Boolean)this[ "sourceColumnNullMapping" ];
			}
			set {
				this[ "sourceColumnNullMapping" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="PropertyName"]/*'/>
		[System.Configuration.ConfigurationProperty( "propertyName", DefaultValue = "", IsRequired = false, IsKey = false )]
		public System.String PropertyName {
			get {
				return (System.String)this[ "propertyName" ];
			}
			set {
				this[ "propertyName" ] = value;
			}
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="Prepare"]/*'/>
		[System.Configuration.ConfigurationProperty( "prepare", DefaultValue = (PrepareElement)null, IsRequired = false, IsKey = false )]
		public PrepareElement Prepare {
			get {
				return (PrepareElement)this[ "prepare" ];
			}
			set {
				this[ "prepare" ] = value;
			}
		}
		#endregion properties


		#region methods
		private void ExecutePrepareCallback( System.Data.Common.DbCommand command, System.Data.Common.DbParameter parameter ) {
			var pe = this.Prepare;
			if ( null == pe ) {
				return;
			}
			var mn = pe.Name.TrimToNull();
			if ( System.String.IsNullOrEmpty( mn ) ) {
				return;
			}
			var tn = pe.Type.TrimToNull();
			if ( System.String.IsNullOrEmpty( tn ) ) {
				tn = System.Reflection.Assembly.GetEntryAssembly().EntryPoint.DeclaringType.AssemblyQualifiedName;
				if ( System.String.IsNullOrEmpty( tn ) ) {
					return;
				}
			}
			var t = System.Type.GetType( tn, false );
			if ( null == t ) {
				return;
			}
			var m = t.GetMethod( mn, System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static, null, new System.Type[ 2 ] {
				typeof( System.Object ),
				typeof( DbPrepareParameterEventArgs )
			}, null );
			if ( null == m ) {
				return;
			}
			_ = m.Invoke( null, new System.Object[ 2 ] {
				this,
				new DbPrepareParameterEventArgs( command, parameter, this )
			} );
		}

		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand)"]/*'/>
		public System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			var output = command.CreateParameter();
			if ( null != output ) {
				output.DbType = this.DbType;
				output.Direction = this.Direction;
				output.ParameterName = this.ParameterName;
				output.Size = this.Size;
				var sourceCol = this.SourceColumn;
				if ( !System.String.IsNullOrEmpty( sourceCol ) ) {
					output.SourceColumn = sourceCol;
				}
				output.SourceColumnNullMapping = this.SourceColumnNullMapping;
				var iDbDataParameter = ( output as System.Data.IDbDataParameter );
				if ( null != iDbDataParameter ) {
					iDbDataParameter.Precision = this.Precision;
					iDbDataParameter.Scale = this.Scale;
				}
			}

			this.ExecutePrepareCallback( command, output );

			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand,System.Action`1)"]/*'/>
		public System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command, System.Action<System.Data.Common.DbParameter> prepare ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			var output = this.ToDbParameter( command );
			prepare?.Invoke( output );
			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand,System.Object)"]/*'/>
		public System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command, System.Object value ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			var output = this.ToDbParameter( command );
			output.Value = value ?? System.DBNull.Value;
			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand,System.Reflection.PropertyInfo,System.Object)"]/*'/>
		public System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command, System.Reflection.PropertyInfo property, System.Object @object ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( @object, nameof( @object ) );
			System.ArgumentNullException.ThrowIfNull( property, nameof( property ) );
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == @object ) {
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( null == property ) {
				throw new System.ArgumentNullException( nameof( property ) );
			} else if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			return this.ToDbParameter( command, property.GetValue( @object, null ) );
		}


		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="GetInputProperty(System.Type)"]/*'/>
		public System.Reflection.PropertyInfo GetInputProperty( System.Type type ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( type, nameof( type ) );
#else
			if ( null == type ) {
				throw new System.ArgumentNullException( nameof( type ) );
			}
#endif
			System.Reflection.PropertyInfo output = null;
			if (
				( System.Data.ParameterDirection.Input == this.Direction )
				|| ( System.Data.ParameterDirection.InputOutput == this.Direction )
			) {
				try {
					System.String name = this.PropertyName;
					if ( System.String.IsNullOrEmpty( name ) ) {
						name = this.Name;
					}
					output = type.GetProperty( name, System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.GetProperty );
				} catch ( System.Exception ) {
					;
				}
			}
			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="GetOutputProperty(System.Type)"]/*'/>
		public System.Reflection.PropertyInfo GetOutputProperty( System.Type type ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( type, nameof( type ) );
#else
			if ( null == type ) {
				throw new System.ArgumentNullException( nameof( type ) );
			}
#endif
			System.Reflection.PropertyInfo output = null;
			if (
				( System.Data.ParameterDirection.Output == this.Direction )
				|| ( System.Data.ParameterDirection.InputOutput == this.Direction )
				|| ( System.Data.ParameterDirection.ReturnValue == this.Direction )
			) {
				try {
					System.String name = this.PropertyName;
					if ( System.String.IsNullOrEmpty( name ) ) {
						name = this.Name;
					}
					output = type.GetProperty( name, System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.SetProperty );
				} catch ( System.Exception ) {
					;
				}
			}
			return output;
		}
		#endregion methods


		#region static methods
		/// <include file='.\Doc\DbCommands\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand,Icod.Orm.DbMap.DbParameterElement)"]/*'/>
		public static System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command, DbParameterElement element ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
			System.ArgumentNullException.ThrowIfNull( element, nameof( element ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			} else if ( null == element ) {
				throw new System.ArgumentNullException( nameof( element ) );
			}
#endif
			var output = command.CreateParameter();
			if ( null != output ) {
				output.DbType = element.DbType;
				output.Direction = element.Direction;
				output.ParameterName = element.ParameterName;
				output.Size = element.Size;
				var sourceCol = element.SourceColumn;
				if ( !System.String.IsNullOrEmpty( sourceCol ) ) {
					output.SourceColumn = sourceCol;
				}
				output.SourceColumnNullMapping = element.SourceColumnNullMapping;
				var iDbDataParameter = ( output as System.Data.IDbDataParameter );
				if ( null != iDbDataParameter ) {
					iDbDataParameter.Precision = element.Precision;
					iDbDataParameter.Scale = element.Scale;
				}
			}

			element.ExecutePrepareCallback( command, output );

			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand,Icod.Orm.DbMap.DbParameterElement,System.Action`1)"]/*'/>
		public static System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command, Icod.Orm.DbMap.DbParameterElement element, System.Action<System.Data.Common.DbParameter> prepare ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
			System.ArgumentNullException.ThrowIfNull( element, nameof( element ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			} else if ( null == element ) {
				throw new System.ArgumentNullException( nameof( element ) );
			}
#endif
			var output = element.ToDbParameter( command );
			prepare?.Invoke( output );
			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand,Icod.Orm.DbMap.DbParameterElement,System.Object)"]/*'/>
		public static System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command, Icod.Orm.DbMap.DbParameterElement element, System.Object value ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
			System.ArgumentNullException.ThrowIfNull( element, nameof( element ) );
#else
			if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			} else if ( null == element ) {
				throw new System.ArgumentNullException( nameof( element ) );
			}
#endif
			var output = element.ToDbParameter( command );
			output.Value = value ?? System.DBNull.Value;
			return output;
		}
		/// <include file='.\Doc\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.DbParameterElement"]/member[@name="ToDbParameter(System.Data.Common.DbCommand,Icod.Orm.DbMap.DbParameterElement,System.Reflection.PropertyInfo,System.Object)"]/*'/>
		public static System.Data.Common.DbParameter ToDbParameter( System.Data.Common.DbCommand command, Icod.Orm.DbMap.DbParameterElement element, System.Reflection.PropertyInfo property, System.Object @object ) {
#if NET8_0_OR_GREATER
			System.ArgumentNullException.ThrowIfNull( @object, nameof( @object ) );
			System.ArgumentNullException.ThrowIfNull( element, nameof( element ) );
			System.ArgumentNullException.ThrowIfNull( property, nameof( property ) );
			System.ArgumentNullException.ThrowIfNull( command, nameof( command ) );
#else
			if ( null == @object ) {
				throw new System.ArgumentNullException( nameof( @object ) );
			} else if ( null == element ) {
				throw new System.ArgumentNullException( nameof( element ) );
			} else if ( null == property ) {
				throw new System.ArgumentNullException( nameof( property ) );
			} else if ( null == command ) {
				throw new System.ArgumentNullException( nameof( command ) );
			}
#endif
			return element.ToDbParameter( command, property.GetValue( @object, null ) );
		}
		#endregion static meethods

	}

}