using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Xml;
using {NAMESPACE_DOMAIN};
using {NAMESPACE_DBHELPER};
using {NAMESPACE_ACCESS_MODEL};

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace {NAMESPACE_DATAACCESS}
{
    /// <summary>
    /// DataAccess Class {CLASS_NAME_DATAACCESS}
    /// </summary>
    /// <author>{AUTHOR_NAME}</author>
    /// <created>{CREATION_DATE}</created>
    /// <remarks>
    /// This class was generated by a tool.
    /// </remarks>
    public static class {CLASS_NAME_DATAACCESS}
    {
        #region base methods

        /// <summary>
        /// Save Entity <see cref="{CLASS_NAME_DOMAIN}"/> into Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{INSTANCE_NAME_DOMAIN}">Reference to <see cref="{CLASS_NAME_DOMAIN}"/>.</param>
        /// <returns>Entity PrimaryKey</returns>
        public static {PRIMARYKEY_DATATYPE} {SAVE_METHODNAME}({CLASS_NAME_DOMAIN} {INSTANCE_NAME_DOMAIN})
        {
            ParameterCollection parameters = new ParameterCollection
            {
                /*-- BEGIN SECTION PARAMETERS */
                /*-- BEGIN SECTION INT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION NCHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION XML AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION XML */
                /*-- BEGIN SECTION NVARCHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION IMAGE */
                /*-- END SECTION PARAMETERS */
            };

            return {DBHELPER_INSTANCEOBJECT}.{GETSCALAR_METHODNAME}<{PRIMARYKEY_DATATYPE}>("{SAVE_STORED_PROCEDURE}", parameters);
        }
		
        /// <summary>
        /// Save Entity <see cref="{CLASS_NAME_DOMAIN}"/> into Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{INSTANCE_NAME_DOMAIN}">Reference to <see cref="{CLASS_NAME_DOMAIN}"/>.</param>
        /// <returns>Entity PrimaryKey</returns>
        public static async Task<{PRIMARYKEY_DATATYPE}> {SAVE_METHODNAME}{ASYNC_METHODS_SUFFIX}({CLASS_NAME_DOMAIN} {INSTANCE_NAME_DOMAIN})
        {
            ParameterCollection parameters = new ParameterCollection
            {
                /*-- BEGIN SECTION PARAMETERS_ASYNC */
                /*-- BEGIN SECTION INT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION XML AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION XML */
                /*-- BEGIN SECTION NCHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION NVARCHAR AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */new Parameter("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION IMAGE */
                /*-- END SECTION PARAMETERS_ASYNC */
            };

            return await {DBHELPER_INSTANCEOBJECT}.{GETSCALAR_ASYNC_METHODNAME}<{PRIMARYKEY_DATATYPE}>("{SAVE_STORED_PROCEDURE}", parameters);
        }

        /// <summary>
        /// Get a <see cref="{CLASS_NAME_DOMAIN}"/> entity from Database by Primary Key ID
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Reference to a new instance of <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static {CLASS_NAME_DOMAIN} {GETBYID_METHODNAME}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parameter parameter = new Parameter("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return {DBHELPER_INSTANCEOBJECT}.{GETENTITY_METHODNAME}("{GETBYID_STORED_PROCEDURE}", parameter, {BUILDFUNCTION_METHODNAME});
        }

        /// <summary>
        /// Get a <see cref="{CLASS_NAME_DOMAIN}"/> entity from Database by Primary Key ID
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Reference to a new instance of <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static async Task<{CLASS_NAME_DOMAIN}> {GETBYID_METHODNAME}{ASYNC_METHODS_SUFFIX}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parameter parameter = new Parameter("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return await {DBHELPER_INSTANCEOBJECT}.{GETENTITY_ASYNC_METHODNAME}("{GETBYID_STORED_PROCEDURE}", parameter, {BUILDFUNCTION_METHODNAME}{ASYNC_METHODS_SUFFIX});
        }
		
        /// <summary>
        /// List all Entities from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <returns><see cref="DataTable"/> with all the objects.</returns>
        public static DataTable {LISTALL_METHODNAME}()
        {
            return {DBHELPER_INSTANCEOBJECT}.{GETDATATABLE_METHODNAME}("{LISTALL_STORED_PROCEDURE}");
        }

        /// <summary>
        /// List all Entities from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <returns><see cref="DataTable"/> with all the objects.</returns>
        public static async Task<DataTable> {LISTALL_METHODNAME}{ASYNC_METHODS_SUFFIX}()
        {
            return await {DBHELPER_INSTANCEOBJECT}.{GETDATATABLE_ASYNC_METHODNAME}("{LISTALL_STORED_PROCEDURE}");
        }
		
        /// <summary>
        /// Delete a Entity from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Reference to a instance of <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static void {DELETE_METHODNAME}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parameter parameter = new Parameter("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return {DBHELPER_INSTANCEOBJECT}.{EXECUTESP_METHODNAME}("{DELETE_STORED_PROCEDURE}", parameter);
        }

        /// <summary>
        /// Delete a Entity from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Reference to a instance of <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static async Task {DELETE_METHODNAME}{ASYNC_METHODS_SUFFIX}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parameter parameter = new Parameter("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return await {DBHELPER_INSTANCEOBJECT}.{EXECUTESP_ASYNC_METHODNAME}("{DELETE_STORED_PROCEDURE}", parameter);
        }
		
        #endregion

        #region aditional methods
        #endregion

        #region builder
        private static {CLASS_NAME_DOMAIN} {BUILDFUNCTION_METHODNAME}(IDataReader row)
        {
            return new {CLASS_NAME_DOMAIN}
            {
                /*-- BEGIN SECTION PROPERTIES */
                /*-- BEGIN SECTION INT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt32(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt64(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(row["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(row["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDecimal(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION NCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION XML AS VAR */{VAR.COLUMNNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? new Func<XmlDocument>(() => { var x = new XmlDocument(); x.LoadXml(row["{VAR.COLUMNNAME}"].ToString()); return x; })() : new XmlDocument(),
                /*-- END SECTION XML */
                /*-- BEGIN SECTION NVARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value && Convert.ToBoolean(row["{VAR.COLUMNNAME}"]),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(row["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(row["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(row["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? TimeSpan.Parse(Convert.ToDateTime(row["{VAR.COLUMNNAME}"]).ToLongTimeString()) : new TimeSpan(0),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION IMAGE */
                /*-- END SECTION PROPERTIES */
            };
        }
		
        private static async Task<{CLASS_NAME_DOMAIN}> {BUILDFUNCTION_METHODNAME}{ASYNC_METHODS_SUFFIX}(IDataReader row)
        {
            return new {CLASS_NAME_DOMAIN}
            {
                /*-- BEGIN SECTION PROPERTIES_ASYNC */
                /*-- BEGIN SECTION INT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt32(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt64(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(row["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(row["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDecimal(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(row["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION NCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION XML AS VAR */{VAR.COLUMNNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? new Func<XmlDocument>(() => { var x = new XmlDocument(); x.LoadXml(row["{VAR.COLUMNNAME}"].ToString()); return x; })() : new XmlDocument(),
                /*-- END SECTION XML */
                /*-- BEGIN SECTION NVARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value && Convert.ToBoolean(row["{VAR.COLUMNNAME}"]),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(row["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(row["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(row["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? TimeSpan.Parse(Convert.ToDateTime(row["{VAR.COLUMNNAME}"]).ToLongTimeString()) : new TimeSpan(0),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION IMAGE */
                /*-- END SECTION PROPERTIES_ASYNC */
            };
        }
        #endregion
    }
}
