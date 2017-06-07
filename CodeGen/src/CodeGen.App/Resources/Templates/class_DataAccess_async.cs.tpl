using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml;
using {NAMESPACE_DOMAIN};

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
            {PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE} = default({PRIMARYKEY_DATATYPE});
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{SAVE_STORED_PROCEDURE}";

                    /*-- BEGIN SECTION PARAMETERS */
                    /*-- BEGIN SECTION BIGINT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.BigInt) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION BIGINT */
                    /*-- BEGIN SECTION BINARY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Binary) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION BINARY */
                    /*-- BEGIN SECTION BIT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Bit) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION BIT */
                    /*-- BEGIN SECTION CHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Char) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION CHAR */
                    /*-- BEGIN SECTION DATETIME AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.DateTime) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATETIME */
                    /*-- BEGIN SECTION DECIMAL AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Decimal) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DECIMAL */
                    /*-- BEGIN SECTION FLOAT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Float) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION FLOAT */
                    /*-- BEGIN SECTION IMAGE AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Image) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION IMAGE */
                    /*-- BEGIN SECTION INT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Int) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION INT */
                    /*-- BEGIN SECTION MONEY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Money) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION MONEY */
                    /*-- BEGIN SECTION NCHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.NChar) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION NCHAR */
                    /*-- BEGIN SECTION NTEXT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.NText) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION NTEXT */
                    /*-- BEGIN SECTION NVARCHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.NVarChar) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION NVARCHAR */
                    /*-- BEGIN SECTION REAL AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Real) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION REAL */
                    /*-- BEGIN SECTION UNIQUEIDENTIFIER AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.UniqueIdentifier) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION UNIQUEIDENTIFIER */
                    /*-- BEGIN SECTION SMALLDATETIME AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.SmallDateTime) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION SMALLDATETIME */
                    /*-- BEGIN SECTION SMALLINT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.SmallInt) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION SMALLINT */
                    /*-- BEGIN SECTION SMALLMONEY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.SmallMoney) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION SMALLMONEY */
                    /*-- BEGIN SECTION TEXT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Text) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TEXT */
                    /*-- BEGIN SECTION TIMESTAMP AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Timestamp) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TIMESTAMP */
                    /*-- BEGIN SECTION TINYINT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.TinyInt) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TINYINT */
                    /*-- BEGIN SECTION VARBINARY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.VarBinary) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION VARBINARY */
                    /*-- BEGIN SECTION VARCHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.VarChar) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION VARCHAR */
                    /*-- BEGIN SECTION XML AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Xml) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION XML */
                    /*-- BEGIN SECTION DATE AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Date) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATE */
                    /*-- BEGIN SECTION TIME AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Time) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TIME */
                    /*-- BEGIN SECTION DATETIME2 AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.DateTime2) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATETIME2 */
                    /*-- BEGIN SECTION DATETIMEOFFSET AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.DateTimeOffset) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATETIMEOFFSET */
                    /*-- END SECTION PARAMETERS */

                    {PRIMARYKEY_LOCAL_VARIABLE} = ({PRIMARYKEY_DATATYPE})command.ExecuteScalar();
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return {PRIMARYKEY_LOCAL_VARIABLE};
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
            {PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE} = default({PRIMARYKEY_DATATYPE});
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                await connection.OpenAsync();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{SAVE_STORED_PROCEDURE}";

                    /*-- BEGIN SECTION PARAMETERS_ASYNC */
                    /*-- BEGIN SECTION BIGINT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.BigInt) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION BIGINT */
                    /*-- BEGIN SECTION BINARY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Binary) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION BINARY */
                    /*-- BEGIN SECTION BIT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Bit) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION BIT */
                    /*-- BEGIN SECTION CHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Char) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION CHAR */
                    /*-- BEGIN SECTION DATETIME AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.DateTime) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATETIME */
                    /*-- BEGIN SECTION DECIMAL AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Decimal) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DECIMAL */
                    /*-- BEGIN SECTION FLOAT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Float) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION FLOAT */
                    /*-- BEGIN SECTION IMAGE AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Image) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION IMAGE */
                    /*-- BEGIN SECTION INT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Int) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION INT */
                    /*-- BEGIN SECTION MONEY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Money) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION MONEY */
                    /*-- BEGIN SECTION NCHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.NChar) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION NCHAR */
                    /*-- BEGIN SECTION NTEXT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.NText) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION NTEXT */
                    /*-- BEGIN SECTION NVARCHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.NVarChar) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION NVARCHAR */
                    /*-- BEGIN SECTION REAL AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Real) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION REAL */
                    /*-- BEGIN SECTION UNIQUEIDENTIFIER AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.UniqueIdentifier) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION UNIQUEIDENTIFIER */
                    /*-- BEGIN SECTION SMALLDATETIME AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.SmallDateTime) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION SMALLDATETIME */
                    /*-- BEGIN SECTION SMALLINT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.SmallInt) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION SMALLINT */
                    /*-- BEGIN SECTION SMALLMONEY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.SmallMoney) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION SMALLMONEY */
                    /*-- BEGIN SECTION TEXT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Text) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TEXT */
                    /*-- BEGIN SECTION TIMESTAMP AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Timestamp) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TIMESTAMP */
                    /*-- BEGIN SECTION TINYINT AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.TinyInt) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TINYINT */
                    /*-- BEGIN SECTION VARBINARY AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.VarBinary) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION VARBINARY */
                    /*-- BEGIN SECTION VARCHAR AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.VarChar) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION VARCHAR */
                    /*-- BEGIN SECTION XML AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Xml) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION XML */
                    /*-- BEGIN SECTION DATE AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Date) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATE */
                    /*-- BEGIN SECTION TIME AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.Time) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION TIME */
                    /*-- BEGIN SECTION DATETIME2 AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.DateTime2) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATETIME2 */
                    /*-- BEGIN SECTION DATETIMEOFFSET AS VAR */command.Parameters.Add(new SqlParameter("@{VAR.PARAMETERNAME}", SqlDbType.DateTimeOffset) { Value = {INSTANCE_NAME_DOMAIN}.{VAR.PROPERTYNAME} });
                    /*-- END SECTION DATETIMEOFFSET */
                    /*-- END SECTION PARAMETERS_ASYNC */

                    {PRIMARYKEY_LOCAL_VARIABLE} = await ({PRIMARYKEY_DATATYPE})command.ExecuteScalarAsync();
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return {PRIMARYKEY_LOCAL_VARIABLE};
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
            {CLASS_NAME_DOMAIN} {INSTANCE_NAME_DOMAIN} = new {CLASS_NAME_DOMAIN}();

            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{GETBYID_STORED_PROCEDURE}";
                    command.Parameters.AddWithValue("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            {INSTANCE_NAME_DOMAIN} = {BUILDFUNCTION_METHODNAME}(reader);
                        }
                    }
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return {INSTANCE_NAME_DOMAIN};
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
            {CLASS_NAME_DOMAIN} {INSTANCE_NAME_DOMAIN} = new {CLASS_NAME_DOMAIN}();

            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                await connection.OpenAsync();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{GETBYID_STORED_PROCEDURE}";
                    command.Parameters.AddWithValue("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

                    using (IDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            {INSTANCE_NAME_DOMAIN} = await {BUILDFUNCTION_METHODNAME}(reader);
                        }
                    }
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return {INSTANCE_NAME_DOMAIN};
        }
		
        /// <summary>
        /// List all Entities from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <returns><see cref="DataTable"/> with all the objects.</returns>
        public static DataTable {LISTALL_METHODNAME}()
        {
            DataTable table = new DataTable("Results");

            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{LISTALL_STORED_PROCEDURE}";

                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return table;
        }

        /// <summary>
        /// List all Entities from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <returns><see cref="DataTable"/> with all the objects.</returns>
        public static async Task<DataTable> {LISTALL_METHODNAME}{ASYNC_METHODS_SUFFIX}()
        {
            DataTable table = new DataTable("Results");

            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                await connection.OpenAsync();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{LISTALL_STORED_PROCEDURE}";

                    IDataReader reader = await command.ExecuteReaderAsync();
                    table.Load(reader);
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return table;
        }
		
        /// <summary>
        /// Delete a Entity from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">PrimaryKey of {CLASS_NAME_DOMAIN}.</param>
        public static void {DELETE_METHODNAME}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{DELETE_STORED_PROCEDURE}";
                    command.Parameters.AddWithValue("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
		
        /// <summary>
        /// Delete a Entity from Database
        /// </summary>
        /// <author>{AUTHOR_NAME}</author>
        /// <created>{CREATION_DATE}</created>
        /// <param name="{PRIMARYKEY_LOCAL_VARIABLE}">PrimaryKey of {CLASS_NAME_DOMAIN}.</param>
        public static async Task {DELETE_METHODNAME}{ASYNC_METHODS_SUFFIX}({PRIMARYKEY_DATATYPE} {PRIMARYKEY_LOCAL_VARIABLE})
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                await connection.OpenAsync();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "{DELETE_STORED_PROCEDURE}";
                    command.Parameters.AddWithValue("@{PRIMARYKEY_PARAMETERNAME}", {PRIMARYKEY_LOCAL_VARIABLE});

                    await command.ExecuteNonQueryAsync();
                }
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
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
                /*-- BEGIN SECTION BIGINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (long)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION BINARY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION BINARY */
                /*-- BEGIN SECTION BIT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value && (bool)row["{VAR.COLUMNNAME}"],
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION CHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (char[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION DATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(1900, 1, 1),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DECIMAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (decimal)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION FLOAT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (float)row["{VAR.COLUMNNAME}"] : 0.0f,
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION IMAGE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION IMAGE */
                /*-- BEGIN SECTION INT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (int)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION INT */
                /*-- BEGIN SECTION MONEY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (decimal)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION NCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (char[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION NTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION NVARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION REAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (float)row["{VAR.COLUMNNAME}"] : 0.0f,
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION UNIQUEIDENTIFIER AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (Guid)row["{VAR.COLUMNNAME}"] : new Guid(),
                /*-- END SECTION UNIQUEIDENTIFIER */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION SMALLINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (short)row["{VAR.COLUMNNAME}"] : (short)0,
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION SMALLMONEY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (decimal)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION SMALLMONEY */
                /*-- BEGIN SECTION TEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION TINYINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte)row["{VAR.COLUMNNAME}"] : (byte)0,
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION VARBINARY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION VARBINARY */
                /*-- BEGIN SECTION VARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION XML AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? new Func<XmlDocument>(() => { var x = new XmlDocument(); x.LoadXml(row["{VAR.COLUMNNAME}"].ToString()); return x; })() : new XmlDocument(),
                /*-- END SECTION XML */
                /*-- BEGIN SECTION DATE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (TimeSpan)row["{VAR.COLUMNNAME}"] : new TimeSpan(0),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION DATETIME2 AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(),
                /*-- END SECTION DATETIME2 */
                /*-- BEGIN SECTION DATETIMEOFFSET AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTimeOffset)row["{VAR.COLUMNNAME}"] : new DateTimeOffset(),
                /*-- END SECTION DATETIMEOFFSET */
                /*-- END SECTION PROPERTIES */
            };
        }
		
        private static async Task<{CLASS_NAME_DOMAIN}> {BUILDFUNCTION_METHODNAME}{ASYNC_METHODS_SUFFIX}(IDataReader row)
        {
            return new {CLASS_NAME_DOMAIN}
            {
                /*-- BEGIN SECTION PROPERTIES_ASYNC */
                /*-- BEGIN SECTION BIGINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (long)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION BIGINT */
                /*-- BEGIN SECTION BINARY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION BINARY */
                /*-- BEGIN SECTION BIT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value && (bool)row["{VAR.COLUMNNAME}"],
                /*-- END SECTION BIT */
                /*-- BEGIN SECTION CHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (char[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION CHAR */
                /*-- BEGIN SECTION DATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(1900, 1, 1),
                /*-- END SECTION DATETIME */
                /*-- BEGIN SECTION DECIMAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (decimal)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION DECIMAL */
                /*-- BEGIN SECTION FLOAT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (float)row["{VAR.COLUMNNAME}"] : 0.0f,
                /*-- END SECTION FLOAT */
                /*-- BEGIN SECTION IMAGE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION IMAGE */
                /*-- BEGIN SECTION INT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (int)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION INT */
                /*-- BEGIN SECTION MONEY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (decimal)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION MONEY */
                /*-- BEGIN SECTION NCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (char[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION NCHAR */
                /*-- BEGIN SECTION NTEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION NTEXT */
                /*-- BEGIN SECTION NVARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION NVARCHAR */
                /*-- BEGIN SECTION REAL AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (float)row["{VAR.COLUMNNAME}"] : 0.0f,
                /*-- END SECTION REAL */
                /*-- BEGIN SECTION UNIQUEIDENTIFIER AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (Guid)row["{VAR.COLUMNNAME}"] : new Guid(),
                /*-- END SECTION UNIQUEIDENTIFIER */
                /*-- BEGIN SECTION SMALLDATETIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(),
                /*-- END SECTION SMALLDATETIME */
                /*-- BEGIN SECTION SMALLINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (short)row["{VAR.COLUMNNAME}"] : (short)0,
                /*-- END SECTION SMALLINT */
                /*-- BEGIN SECTION SMALLMONEY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (decimal)row["{VAR.COLUMNNAME}"] : 0,
                /*-- END SECTION SMALLMONEY */
                /*-- BEGIN SECTION TEXT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION TEXT */
                /*-- BEGIN SECTION TIMESTAMP AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION TIMESTAMP */
                /*-- BEGIN SECTION TINYINT AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte)row["{VAR.COLUMNNAME}"] : (byte)0,
                /*-- END SECTION TINYINT */
                /*-- BEGIN SECTION VARBINARY AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (byte[])row["{VAR.COLUMNNAME}"] : null,
                /*-- END SECTION VARBINARY */
                /*-- BEGIN SECTION VARCHAR AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (string)row["{VAR.COLUMNNAME}"] : string.Empty,
                /*-- END SECTION VARCHAR */
                /*-- BEGIN SECTION XML AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? new Func<XmlDocument>(() => { var x = new XmlDocument(); x.LoadXml(row["{VAR.COLUMNNAME}"].ToString()); return x; })() : new XmlDocument(),
                /*-- END SECTION XML */
                /*-- BEGIN SECTION DATE AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(),
                /*-- END SECTION DATE */
                /*-- BEGIN SECTION TIME AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (TimeSpan)row["{VAR.COLUMNNAME}"] : new TimeSpan(0),
                /*-- END SECTION TIME */
                /*-- BEGIN SECTION DATETIME2 AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTime)row["{VAR.COLUMNNAME}"] : new DateTime(),
                /*-- END SECTION DATETIME2 */
                /*-- BEGIN SECTION DATETIMEOFFSET AS VAR */{VAR.PROPERTYNAME} = row["{VAR.COLUMNNAME}"] != DBNull.Value ? (DateTimeOffset)row["{VAR.COLUMNNAME}"] : new DateTimeOffset(),
                /*-- END SECTION DATETIMEOFFSET */
                /*-- END SECTION PROPERTIES_ASYNC */
            };
        }
        #endregion

        #region connection
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["{CONNECTIONSTRING_KEY}"].ConnectionString;
        }
        #endregion
    }
}
