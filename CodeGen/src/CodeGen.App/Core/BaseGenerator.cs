using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGen.Library.Formats;
using CodeGen.Plugin.Base;
using CodeGen.Properties;

namespace CodeGen.Core
{
    public class BaseGenerator
    {
        /// <summary>
        /// Configuracion
        /// </summary>
        public PluginSettings Settings { get; private set; }

        /// <summary>
        /// Clase
        /// </summary>
        public DatabaseEntity Entity { get; private set; }

        /// <summary>
        /// NombreClaseDomain
        /// </summary>
        public string DomainClassName { get; set; }

        /// <summary>
        /// NombreClaseDataAccess
        /// </summary>
        public string DataAccessClassName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGenerator"/> class.
        /// </summary>
        public BaseGenerator(PluginSettings settings, DatabaseEntity entity)
        {
            Settings = settings;
            Entity = entity;
        }

        /// <summary>
        /// Generars the codigo domain.
        /// </summary>
        /// <returns></returns>
        public string GenerateDomainCode()
        {
            TemplateFile template = TemplateFile.LoadTemplate(TemplateType.CS, Resources.class_Domain);

            TemplateSection sectionProperties = template.ExtractSection("PROPERTIES");
            TemplateSection sectionParameters = template.ExtractSection("PARAMETERS");

            TemplateSectionCollection propertiesSectionList = new TemplateSectionCollection();
            TemplateSectionCollection parametersSectionList = new TemplateSectionCollection();

            foreach (var entityField in Entity.Fields)
            {
                TemplateSection propertySection = sectionProperties.ExtractSection(entityField.SimpleTypeName);
                propertySection.ReplaceTag("PROPERTYNAME", entityField.ColumnName);
                propertiesSectionList.AddSection(propertySection);

                TemplateSection parameterSection = sectionParameters.ExtractSection(entityField.SimpleTypeName);
                parameterSection.ReplaceTag("PROPERTYNAME", entityField.ColumnName);
                parametersSectionList.AddSection(parameterSection);
            }

            template.ReplaceSection("PROPERTIES", propertiesSectionList);
            template.ReplaceSection("PARAMETERS", parametersSectionList);
            template.ReplaceTag("NAMESPACE_DOMAIN", Settings[CodeBaseConstants.NAMESPACE_DOMAIN].Value, false);
            template.ReplaceTag("CLASS_NAME_DOMAIN", DomainClassName, false);

            template.ReplaceTag("AUTHOR_NAME", Settings[CodeBaseConstants.AUTHOR_NAME].Value, false);
            template.ReplaceTag("CREATION_DATE", ObtenerFechaFormateada(), false);

            return template.Content;
        }

        /// <summary>
        /// Generars the codigo data access.
        /// </summary>
        /// <returns></returns>
        public string GenerateDataAccessCode()
        {
            TemplateFile template = TemplateFile.LoadTemplate(TemplateType.CS, Resources.class_DataAccess);

            TemplateSection seccionPropiedades = template.ExtractSection("PROPERTIES");
            TemplateSection seccionParametros = template.ExtractSection("PARAMETERS");

            TemplateSectionCollection listaSeccionesPropiedades = new TemplateSectionCollection();
            TemplateSectionCollection listaSeccionesParametros = new TemplateSectionCollection();

            foreach (var entityField in Entity.Fields)
            {
                TemplateSection seccionParametro = seccionParametros.ExtractSection(entityField.SimpleTypeName);
                seccionParametro.ReplaceTag("NOMBREPARAMETRO", entityField.ColumnName);
                seccionParametro.ReplaceTag("NOMBREPROPIEDAD", entityField.ColumnName);
                //seccionParametro.ReplaceTag("NOMBRE_INSTANCIA_DOMAIN", Entity.NombreInstancia, false);
                listaSeccionesParametros.AddSection(seccionParametro);

                TemplateSection seccionPropiedad = seccionPropiedades.ExtractSection(entityField.SimpleTypeName);
                seccionPropiedad.ReplaceTag("NOMBREPROPIEDAD", entityField.ColumnName);
                seccionPropiedad.ReplaceTag("NOMBRECOLUMNA", entityField.ColumnName);
                listaSeccionesPropiedades.AddSection(seccionPropiedad);
            }

            template.ReplaceSection("PROPERTIES", listaSeccionesPropiedades);
            template.ReplaceSection("PARAMETERS", listaSeccionesParametros);

            //template.ReplaceTag("NAMESPACE_DOMAIN", Settings[CodeBaseConstants.NAMESPACE_DOMAIN].Value, false);
            //template.ReplaceTag("NAMESPACE_DATAACCESS", Settings[CodeBaseConstants.NAMESPACE_DATAACCESS].Value, false);
            //template.ReplaceTag("NAMESPACE_DBHELPER", Settings[eParametros.NAMESPACE_DBHELPER], false);
            //template.ReplaceTag("INSTANCIA_DBHELPER", Settings[eParametros.INSTANCIA_DBHELPER], false);
            //template.ReplaceTag("NAMESPACE_GDK_DATA", Settings[eParametros.NAMESPACE_GDK_DATA], false);

            //template.ReplaceTag("VARIABLE_PRIMARIA_PARAMETRO", Proyecto.IDTipoServidor == (int)eTipoServidor.MYSQL ? Entity.ClavePrimaria.NombreParametroMySql : Entity.ClavePrimaria.NombreParametroSqlServer, false);
            //template.ReplaceTag("VARIABLE_PRIMARIA_LOCAL", Entity.ClavePrimaria.NombrePropiedadLocal, false);
            //template.ReplaceTag("VARIABLE_PRIMARIA_TIPODATO", TipoDatoHelper.ObtenerValor(Entity.ClavePrimaria.TipoDato), false);

            //template.ReplaceTag("NOMBRE_INSTANCIA_DOMAIN", Entity.NombreInstancia, false);
            //template.ReplaceTag("NOMBRE_CLASE_DOMAIN", DomainClassName, false);
            //template.ReplaceTag("NOMBRE_CLASE_DATAACCESS", DataAccessClassName, false);

            //template.ReplaceTag("NOMBRE_PROCEDIMIENTO_GUARDAR", Entity.NombreProcedimientoGuardar, false);
            //template.ReplaceTag("NOMBRE_PROCEDIMIENTO_OBTENERPORID", Entity.NombreProcedimientoObtenerPorID, false);
            //template.ReplaceTag("NOMBRE_PROCEDIMIENTO_LISTAR", Entity.NombreProcedimientoListar, false);

            template.ReplaceTag("AUTHOR_NAME", Settings[CodeBaseConstants.AUTHOR_NAME].Value, false);
            template.ReplaceTag("CREATION_DATE", ObtenerFechaFormateada(), false);

            return template.Content;
        }

        /// <summary>
        /// Obteners the fecha formateada.
        /// </summary>
        /// <returns></returns>
        public string ObtenerFechaFormateada()
        {
            return DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}
