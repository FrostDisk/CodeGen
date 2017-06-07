using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using {NAMESPACE_DOMAIN};
using {NAMESPACE_DBHELPER};
using {NAMESPACE_ACCESS_MODEL};

//------------------------------------------------------------------------------
// <auto-generated>
//     Este codigo fue generado por una herramienta.
//
//     Los cambios en este archivo podrian causar un comportamiento incorrecto y se perderan si
//     se vuelve a generar el codigo
// </auto-generated>
//------------------------------------------------------------------------------

namespace {NAMESPACE_DATAACCESS}
{
    /// <summary>
    /// Clase Acceso de Datos {CLASS_NAME_DATAACCESS}
    /// </summary>
    /// <author>{AUTHOR_NAME}</author>
    /// <created>{CREATION_DATE}</created>
    /// <remarks>
    /// Esta clase fue generada por una herramienta
    /// </remarks>
    public static class {CLASS_NAME_DATAACCESS}
    {
        #region metodos base

        /// <summary>
        /// Guarda una Entidad del tipo <see cref="{CLASS_NAME_DOMAIN}"/> en la Base de Datos
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{INSTANCE_NAME_DOMAIN}">Referencia a <see cref="{CLASS_NAME_DOMAIN}"/>.</param>
        /// <returns>Clave Primaria</returns>
        public static {PRIMARYKEY_DATATYPE} {SAVE_METHODNAME}({CLASS_NAME_DOMAIN} {INSTANCE_NAME_DOMAIN})
        {
            Parametros parametros = new Parametros
            {
                /*-- BEGIN SECTION PARAMETERS */
                /*-- BEGIN SECTION INT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION NCHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION NVARCHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION IMAGE */
                /*-- END SECTION PARAMETERS */
            };

            return {DBHELPER_INSTANCEOBJECT}.{GETSCALAR_METHODNAME}<{PRIMARYKEY_DATATYPE}>("{SAVE_STORED_PROCEDURE}", parametros);
        }
		
        /// <summary>
        /// Guarda una Entidad del tipo <see cref="{CLASS_NAME_DOMAIN}"/> en la Base de Datos
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{INSTANCE_NAME_DOMAIN}">Referencia a <see cref="{CLASS_NAME_DOMAIN}"/>.</param>
        /// <returns>Clave Primaria</returns>
        public static async Task<{PRIMARYKEY_DATATYPE}> {SAVE_METHODNAME}{ASYNC_METHODS_SUFFIX}({CLASS_NAME_DOMAIN} {INSTANCE_NAME_DOMAIN})
        {
            Parametros parametros = new Parametros
            {
                /*-- BEGIN SECTION PARAMETERS_ASYNC */
                /*-- BEGIN SECTION INT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION NCHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION NVARCHAR AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */new Parametro("@{VAR.PARAMETERNAME}", {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME}),
                /*-- END SECTION IMAGE */
                /*-- END SECTION PARAMETERS_ASYNC */
            };

            return await {DBHELPER_INSTANCEOBJECT}.{GETSCALAR_ASYNC_METHODNAME}<{PRIMARYKEY_DATATYPE}>("{SAVE_STORED_PROCEDURE}", parametros);
        }

        /// <summary>
        /// Recupera una Entidad del tipo <see cref="{CLASS_NAME_DOMAIN}"/> de la Base de Datos dado un ID
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Referencia a una instancia del <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static {CLASS_NAME_DOMAIN} {GETBYID_METHODNAME}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parametro parametro = new Parametro("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return {DBHELPER_INSTANCEOBJECT}.{GETENTITY_METHODNAME}("{GETBYID_STORED_PROCEDURE}", parametro, {BUILDFUNCTION_METHODNAME});
        }
		
        /// <summary>
        /// Recupera una Entidad del tipo <see cref="{CLASS_NAME_DOMAIN}"/> de la Base de Datos dado un ID
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Referencia a una instancia del <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static async Task<{CLASS_NAME_DOMAIN}> {GETBYID_METHODNAME}{ASYNC_METHODS_SUFFIX}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parametro parametro = new Parametro("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return await {DBHELPER_INSTANCEOBJECT}.{GETENTITY_ASYNC_METHODNAME}("{GETBYID_STORED_PROCEDURE}", parametro, {BUILDFUNCTION_METHODNAME});
        }

        /// <summary>
        /// Lista todas las entidades del tipo <see cref="{CLASS_NAME_DOMAIN}"/> de la Base de Datos
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <returns><see cref="DataTable"/> con todos los objetos.</returns>
        public static DataTable {LISTALL_METHODNAME}()
        {
            return {DBHELPER_INSTANCEOBJECT}.{GETDATATABLE_METHODNAME}("{LISTALL_STORED_PROCEDURE}");
        }

        /// <summary>
        /// Lista todas las entidades del tipo <see cref="{CLASS_NAME_DOMAIN}"/> de la Base de Datos
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <returns><see cref="DataTable"/> con todos los objetos.</returns>
        public static async Task<DataTable> {LISTALL_METHODNAME}{ASYNC_METHODS_SUFFIX}()
        {
            return await {DBHELPER_INSTANCEOBJECT}.{GETDATATABLE_ASYNC_METHODNAME}("{LISTALL_STORED_PROCEDURE}");
        }
		
        /// <summary>
        /// Elimina una Entidad del tipo <see cref="{CLASS_NAME_DOMAIN}"/> de la Base de Datos dado un ID
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Referencia a una clase <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static int {DELETE_METHODNAME}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parametro parametro = new Parametro("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return {DBHELPER_INSTANCEOBJECT}.{EXECUTESP_METHODNAME}("{DELETE_STORED_PROCEDURE}", parametro);
        }

        /// <summary>
        /// Elimina una Entidad del tipo <see cref="{CLASS_NAME_DOMAIN}"/> de la Base de Datos dado un ID
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">ID de {CLASS_NAME_DOMAIN}.</param>
        /// <returns>Referencia a una clase <see cref="{CLASS_NAME_DOMAIN}"/>.</returns>
        public static async Task<int> {DELETE_METHODNAME}{ASYNC_METHODS_SUFFIX}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            Parametro parametro = new Parametro("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

            return await {DBHELPER_INSTANCEOBJECT}.{EXECUTESP_ASYNC_METHODNAME}("{DELETE_STORED_PROCEDURE}", parametro);
        }
		
        #endregion

        #region metodos adicionales
        #endregion

        #region constructor
        private static {CLASS_NAME_DOMAIN} {BUILDFUNCTION_METHODNAME}(IDataReader fila)
        {
            return new {CLASS_NAME_DOMAIN}
            {
                /*-- BEGIN SECTION PROPERTIES */
                /*-- BEGIN SECTION INT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt32(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt64(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(fila["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(fila["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDecimal(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION NCHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION NVARCHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value && Convert.ToBoolean(fila["{VAR.COLUMNNAME}"]),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? TimeSpan.Parse(Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]).ToLongTimeString()) : new TimeSpan(0),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION IMAGE */
                /*-- END SECTION PROPERTIES */
            };
        }
		
        private static async Task<{CLASS_NAME_DOMAIN}> {BUILDFUNCTION_METHODNAME}{ASYNC_METHODS_SUFFIX}(IDataReader fila)
        {
            return new {CLASS_NAME_DOMAIN}
            {
                /*-- BEGIN SECTION PROPERTIES_ASYNC */
                /*-- BEGIN SECTION INT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt32(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION INT */
                /*-- BEGIN SECTION BIGINT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt64(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION SMALLINT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(fila["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION TINYINT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToInt16(fila["{VAR.COLUMNNAME}"]) : (short)0,
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION DECIMAL AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDecimal(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION REAL AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION FLOAT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0.0f,
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION DOUBLE AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION DOUBLE */
                /*-- BEGIN SECTION MONEY AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDouble(fila["{VAR.COLUMNNAME}"]) : 0,
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION CHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION NCHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION VARCHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION NVARCHAR AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION TEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION NTEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION MEDIUMTEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION MEDIUMTEXT */
                /*-- BEGIN SECTION LONGTEXT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION LONGTEXT */
                /*-- BEGIN SECTION ENUM AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"].ToString() : string.Empty,
                /*-- END SECTION ENUM */
                /*-- BEGIN SECTION BIT AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value && Convert.ToBoolean(fila["{VAR.COLUMNNAME}"]),
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION DATETIME AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DATE AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]) : new DateTime(1900, 1, 1),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? TimeSpan.Parse(Convert.ToDateTime(fila["{VAR.COLUMNNAME}"]).ToLongTimeString()) : new TimeSpan(0),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION BLOB AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION BLOB */
                /*-- BEGIN SECTION LONGBLOB AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION LONGBLOB */
                /*-- BEGIN SECTION IMAGE AS VAR */{VAR.PROPERTYNAME} = fila["{VAR.COLUMNNAME}"] != DBNull.Value ? fila["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION IMAGE */
                /*-- END SECTION PROPERTIES_ASYNC */
            };
        }
        #endregion
    }
}
