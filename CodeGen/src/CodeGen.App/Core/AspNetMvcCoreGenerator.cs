using CodeGen.Library.Formats;
using CodeGen.Plugin.Base;
using CodeGen.Properties;
using System;
using System.Data;
using System.Linq;

namespace CodeGen.Core
{
    internal class AspNetMvcCoreGenerator
    {
        /// <summary>
        /// Settings
        /// </summary>
        public PluginSettings Settings { get; private set; }

        /// <summary>
        /// Entity
        /// </summary>
        public DatabaseEntity Entity { get; private set; }

        /// <summary>
        /// ModelClassName
        /// </summary>
        public string ModelClassName { get; private set; }

        /// <summary>
        /// ControllerClassName
        /// </summary>
        public string ControllerClassName { get; private set; }

        /// <summary>
        /// ViewName
        /// </summary>
        public string ViewName { get; private set; }

        /// <summary>
        /// CleanEntityName
        /// </summary>
        public string CleanEntityName { get; private set; }

        public AspNetMvcCoreGenerator(PluginSettings settings, DatabaseEntity entity)
        {
            Settings = settings;
            Entity = entity;

            CleanEntityName = StringHelper.ConvertToSafeCodeName(StringHelper.RemovePrefix(entity.Name)).Replace("_", string.Empty);
            ModelClassName = string.Format("{0}{1}{2}", Settings[AspNetMvcCoreConstants.MODEL_PREFIX].Value, CleanEntityName, Settings[AspNetMvcCoreConstants.MODEL_SUFFIX].Value);
            ControllerClassName = string.Format("{0}{1}{2}", Settings[AspNetMvcCoreConstants.CONTROLLER_PREFIX].Value, CleanEntityName, Settings[AspNetMvcCoreConstants.CONTROLLER_SUFFIX].Value);
            ViewName = string.Format("{0}{1}{2}", Settings[AspNetMvcCoreConstants.VIEW_PREFIX].Value, StringHelper.Pluralize(CleanEntityName), Settings[AspNetMvcCoreConstants.VIEW_SUFFIX].Value);

        }

        /// <summary>
        /// Generars the codigo domain.
        /// </summary>
        /// <returns></returns>
        public string GenerateCodeModel()
        {
            TemplateFile template = TemplateFile.LoadTemplate(TemplateType.CS, Resources.class_Model);

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
            template.ReplaceTag("NAMESPACE_MODELS", Settings[AspNetMvcCoreConstants.NAMESPACE_MODELS].Value, false);
            template.ReplaceTag("CLASS_NAME_MODEL", ModelClassName, false);

            template.ReplaceTag("AUTHOR_NAME", Settings[AspNetMvcCoreConstants.AUTHOR_NAME].Value, false);
            template.ReplaceTag("CREATION_DATE", GetSimpleDate(DateTime.Now), false);

            return template.Content;
        }

        internal string GenerateCodeController()
        {
            TemplateFile template = TemplateFile.LoadTemplate(TemplateType.CS, Resources.class_Controller);

            var instanceEntityName = StringHelper.ConverToInstanceName(CleanEntityName);

            var primaryEntityField = Entity.Fields.FirstOrDefault(f => f.IsPrimaryKey);
            if (primaryEntityField == null)
            {
                throw new DataException("Entity [" + Entity.Name + "] doesn't have primary key");
            }


            template.ReplaceTag("PRIMARYKEY_DATATYPE", DataTypeHelper.GetCSharpType(primaryEntityField.SimpleTypeName), false);
            template.ReplaceTag("PRIMARYKEY_PARAMETERNAME", primaryEntityField.ColumnName, false);
            template.ReplaceTag("PRIMARYKEY_LOCAL_VARIABLE", StringHelper.ConverToInstanceName(StringHelper.ConvertToSafeCodeName(primaryEntityField.ColumnName)), false);

            template.ReplaceTag("NAMESPACE_MODELS", Settings[AspNetMvcCoreConstants.NAMESPACE_MODELS].Value, false);
            template.ReplaceTag("NAMESPACE_CONTROLLER", Settings[AspNetMvcCoreConstants.NAMESPACE_CONTROLLER].Value, false);
            template.ReplaceTag("NAMESPACE_DBCONTEXT", Settings[AspNetMvcCoreConstants.NAMESPACE_DBCONTEXT].Value, false);

            template.ReplaceTag("INSTANCE_NAME_MODEL", instanceEntityName, false);
            template.ReplaceTag("CLASS_NAME_MODEL", ModelClassName, false);
            template.ReplaceTag("CLASS_NAME_CONTROLLER", ControllerClassName, false);
            template.ReplaceTag("VIEW_NAME", ViewName, false);
            template.ReplaceTag("PROPERTIES_MODEL", string.Join(",", Entity.Fields.Select(t => t.ColumnName)), false);

            template.ReplaceTag("DETAILS_METHODNAME", Settings[AspNetMvcCoreConstants.DETAILS_METHODNAME].Value, false);
            template.ReplaceTag("CREATE_METHODNAME", Settings[AspNetMvcCoreConstants.CREATE_METHODNAME].Value, false);
            template.ReplaceTag("EDIT_METHODNAME", Settings[AspNetMvcCoreConstants.EDIT_METHODNAME].Value, false);
            template.ReplaceTag("DELETE_METHODNAME", Settings[AspNetMvcCoreConstants.DELETE_METHODNAME].Value, false);

            template.ReplaceTag("DBCONTEXT_NAME", Settings[AspNetMvcCoreConstants.DBCONTEXT_NAME].Value, false);

            template.ReplaceTag("AUTHOR_NAME", Settings[AspNetMvcCoreConstants.AUTHOR_NAME].Value, false);
            template.ReplaceTag("CREATION_DATE", GetSimpleDate(DateTime.Now), false);

            return template.Content;
        }

        /// <summary>
        /// Obteners the fecha formateada.
        /// </summary>
        /// <returns></returns>
        internal string GetSimpleDate(DateTime date)
        {
            return date.ToString("dd-MM-yyyy");
        }
    }
}
