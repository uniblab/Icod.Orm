namespace Icod.Orm.DbMap {

	/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name=""]/*'/>
	public interface IDbColumn : IColumnName {

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="Name"]/*'/>
		System.String Name {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="TypeCode"]/*'/>
		System.TypeCode TypeCode {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="DbType"]/*'/>
		System.Data.DbType DbType {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="SqlDbType"]/*'/>
		System.Data.SqlDbType SqlDbType {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="OleDbType"]/*'/>
		System.Data.OleDb.OleDbType OleDbType {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="OdbcType"]/*'/>
		System.Data.Odbc.OdbcType OdbcType {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="ConvertTo"]/*'/>
		System.TypeCode ConvertTo {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="IsNullable"]/*'/>
		System.Boolean IsNullable {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="Skip"]/*'/>
		System.Boolean Skip {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="IsRequired"]/*'/>
		System.Boolean IsRequired {
			get;
			set;
		}

		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="GetValue(System.Data.IDataReader)"]/*'/>
		System.Object GetValue( System.Data.IDataReader reader );
		/// <include file='.\Doc\Interfaces\XmlDoc.xml' path='/types/type[@name="Icod.Orm.DbMap.IDbColumn"]/member[@name="GetValue(System.Data.IDataReader,System.Int32)"]/*'/>
		System.Object GetValue( System.Data.IDataReader reader, System.Int32 ordinal );

	}

}