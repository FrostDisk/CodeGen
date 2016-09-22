using System.Collections.Generic;

namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// IGeneratorTemplate
    /// </summary>
    public interface IGeneratorTemplate : IPluginBase
    {
        /// <summary>
        /// HaveOptions
        /// </summary>
        bool HaveOptions { get; }

        /// <summary>
        /// IsLoaded
        /// </summary>
        bool IsLoaded { get; }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="projectName"></param>
        void Load(string projectName);

        /// <summary>
        /// ShowOptionsForm
        /// </summary>
        /// <returns></returns>
        bool ShowOptionsForm();

        /// <summary>
        /// GetComponents
        /// </summary>
        /// <returns></returns>
        List<GeneratorComponent> GetComponents();

        /// <summary>
        /// GenerateFileName
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="component"></param>
        /// <returns></returns>
        string GenerateFileName(DatabaseEntity entity, GeneratorComponent component);

        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="component"></param>
        /// <returns></returns>
        string Generate(DatabaseEntity entity, GeneratorComponent component);
    }
}
