﻿using System;
using System.Linq;
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
        /// CleanEntityName
        /// </summary>
        public string CleanEntityName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGenerator"/> class.
        /// </summary>
        public BaseGenerator(PluginSettings settings, DatabaseEntity entity)
        {
            Settings = settings;
            Entity = entity;

            CleanEntityName = StringHelper.ConvertToSafeCodeName(StringHelper.RemovePrefix(entity.Name)).Replace("_", string.Empty);
            DomainClassName = string.Format("{0}{1}{2}", Settings[CodeBaseConstants.DOMAIN_PREFIX].Value, CleanEntityName, Settings[CodeBaseConstants.DOMAIN_SUFFIX].Value);
            DataAccessClassName = string.Format("{0}{1}{2}", Settings[CodeBaseConstants.DATAACCESS_PREFIX].Value, CleanEntityName, Settings[CodeBaseConstants.DATAACCESS_SUFFIX].Value);
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
            template.ReplaceTag("CREATION_DATE", GetSimpleDate(DateTime.Now), false);

            return template.Content;
        }

        /// <summary>
        /// Generars the codigo data access.
        /// </summary>
        /// <returns></returns>
        public string GenerateDataAccessCode()
        {
            TemplateFile template = TemplateFile.LoadTemplate(TemplateType.CS, Resources.class_DataAccess);

            TemplateSection sectionProperties = template.ExtractSection("PROPERTIES");
            TemplateSection sectionParameters = template.ExtractSection("PARAMETERS");

            TemplateSectionCollection propertiesSectionList = new TemplateSectionCollection();
            TemplateSectionCollection parameterSectionList = new TemplateSectionCollection();

            var instanceEntityName = StringHelper.ConverToInstanceName(CleanEntityName);

            foreach (var entityField in Entity.Fields)
            {
                TemplateSection propertySection = sectionParameters.ExtractSection(entityField.SimpleTypeName);
                propertySection.ReplaceTag("PARAMETERNAME", entityField.ColumnName);
                propertySection.ReplaceTag("PROPERTYNAME", entityField.ColumnName);
                propertySection.ReplaceTag("INSTANCE_NAME_DOMAIN", instanceEntityName, false);
                parameterSectionList.AddSection(propertySection);

                TemplateSection parameterSection = sectionProperties.ExtractSection(entityField.SimpleTypeName);
                parameterSection.ReplaceTag("PROPERTYNAME", entityField.ColumnName);
                parameterSection.ReplaceTag("COLUMNNAME", entityField.ColumnName);
                propertiesSectionList.AddSection(parameterSection);
            }

            template.ReplaceSection("PROPERTIES", propertiesSectionList);
            template.ReplaceSection("PARAMETERS", parameterSectionList);

            var primaryEntityField = Entity.Fields.First(f => f.IsPrimaryKey);

            template.ReplaceTag("PRIMARYKEY_DATATYPE", DataTypeHelper.GetCSharpType(primaryEntityField.SimpleTypeName), false);
            template.ReplaceTag("PRIMARYKEY_PARAMETERNAME", primaryEntityField.ColumnName, false);
            template.ReplaceTag("PRIMARYKEY_LOCAL_VARIABLE", StringHelper.ConverToInstanceName(StringHelper.ConvertToSafeCodeName(primaryEntityField.ColumnName)), false);

            template.ReplaceTag("NAMESPACE_DOMAIN", Settings[CodeBaseConstants.NAMESPACE_DOMAIN].Value, false);
            template.ReplaceTag("NAMESPACE_DATAACCESS", Settings[CodeBaseConstants.NAMESPACE_DATAACCESS].Value, false);
            template.ReplaceTag("NAMESPACE_DBHELPER", Settings[CodeBaseConstants.NAMESPACE_DBHELPER].Value, false);
            template.ReplaceTag("NAMESPACE_ACCESS_MODEL", Settings[CodeBaseConstants.NAMESPACE_ACCESS_MODEL].Value, false);

            template.ReplaceTag("INSTANCE_NAME_DOMAIN", instanceEntityName, false);
            template.ReplaceTag("CLASS_NAME_DOMAIN", DomainClassName, false);
            template.ReplaceTag("CLASS_NAME_DATAACCESS", DataAccessClassName, false);

            template.ReplaceTag("SAVE_STORED_PROCEDURE", string.Format("{0}{1}{2}", Settings[CodeBaseConstants.SAVE_PREFIX].Value, DomainClassName, Settings[CodeBaseConstants.SAVE_SUFFIX].Value), false);
            template.ReplaceTag("GETBYID_STORED_PROCEDURE", string.Format("{0}{1}{2}", Settings[CodeBaseConstants.GETBYID_PREFIX].Value, DomainClassName, Settings[CodeBaseConstants.GETBYID_SUFFIX].Value), false);
            template.ReplaceTag("LISTALL_STORED_PROCEDURE", string.Format("{0}{1}{2}", Settings[CodeBaseConstants.LISTALL_PREFIX].Value, DomainClassName, Settings[CodeBaseConstants.LISTALL_SUFFIX].Value), false);
            template.ReplaceTag("DELETE_STORED_PROCEDURE", string.Format("{0}{1}{2}", Settings[CodeBaseConstants.DELETE_PREFIX].Value, DomainClassName, Settings[CodeBaseConstants.DELETE_SUFFIX].Value), false);

            template.ReplaceTag("SAVE_METHODNAME", Settings[CodeBaseConstants.SAVE_METHODNAME].Value, false);
            template.ReplaceTag("GETBYID_METHODNAME", Settings[CodeBaseConstants.GETBYID_METHODNAME].Value, false);
            template.ReplaceTag("LISTALL_METHODNAME", Settings[CodeBaseConstants.LISTALL_METHODNAME].Value, false);
            template.ReplaceTag("DELETE_METHODNAME", Settings[CodeBaseConstants.DELETE_METHODNAME].Value, false);
            template.ReplaceTag("BUILDFUNCTION_METHODNAME", Settings[CodeBaseConstants.BUILDFUNCTION_METHODNAME].Value, false);

            template.ReplaceTag("DBHELPER_INSTANCEOBJECT", Settings[CodeBaseConstants.DBHELPER_INSTANCEOBJECT].Value, false);
            template.ReplaceTag("GETSCALAR_METHODNAME", Settings[CodeBaseConstants.GETSCALAR_METHODNAME].Value, false);
            template.ReplaceTag("GETENTITY_METHODNAME", Settings[CodeBaseConstants.GETENTITY_METHODNAME].Value, false);
            template.ReplaceTag("GETDATATABLE_METHODNAME", Settings[CodeBaseConstants.GETDATATABLE_METHODNAME].Value, false);
            template.ReplaceTag("EXECUTESP_METHODNAME", Settings[CodeBaseConstants.EXECUTESP_METHODNAME].Value, false);

            template.ReplaceTag("AUTHOR_NAME", Settings[CodeBaseConstants.AUTHOR_NAME].Value, false);
            template.ReplaceTag("CREATION_DATE", GetSimpleDate(DateTime.Now), false);

            return template.Content;
        }

        /// <summary>
        /// Obteners the fecha formateada.
        /// </summary>
        /// <returns></returns>
        public string GetSimpleDate(DateTime date)
        {
            return date.ToString("dd-MM-yyyy HH:mm");
        }
    }
}