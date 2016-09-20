using CodeGen.Library.Formats;
using CodeGen.Plugin.Base;
using CodeGen.Properties;
using System;

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
        /// CleanEntityName
        /// </summary>
        public string CleanEntityName { get; private set; }

        public AspNetMvcCoreGenerator(PluginSettings settings, DatabaseEntity entity)
        {
            Settings = settings;
            Entity = entity;

            CleanEntityName = StringHelper.ConvertToSafeCodeName(StringHelper.RemovePrefix(entity.Name)).Replace("_", string.Empty);
            ModelClassName = string.Format("{0}{1}{2}", Settings[AspNetMvcCoreConstants.MODEL_PREFIX].Value, CleanEntityName, Settings[AspNetMvcCoreConstants.MODEL_SUFFIX].Value);
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
            template.ReplaceTag("NAMESPACE_MODEL", Settings[AspNetMvcCoreConstants.NAMESPACE_MODEL].Value, false);
            template.ReplaceTag("CLASS_NAME_MODEL", ModelClassName, false);

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
