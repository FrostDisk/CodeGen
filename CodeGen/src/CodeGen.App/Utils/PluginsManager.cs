using CodeGen.Configuration;
using CodeGen.Core;
using CodeGen.Data;
using CodeGen.Domain;
using CodeGen.Library.Formats;
using CodeGen.Plugin.Base;
using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CodeGen.Utils
{
    /// <summary>
    /// Class to manage all comunication between the application and the plugins
    /// </summary>
    public static class PluginsManager
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Checks if Plugins are Loaded into Global Settings
        /// </summary>
        /// <returns></returns>
        public static bool CheckIfPluginsAreLoaded()
        {
            _logger.Trace("PluginsManager.CheckIfPluginsAreLoaded()");

            var settings = ProgramSettings.GetGlobalSettings();

            return settings.Assemblies.Count() > 0;
        }

        /// <summary>
        /// Updates the plugin list in the global settings.
        /// </summary>
        /// <remarks>
        /// This method scan all the .dll files in the DefaultPluginsLocation folder 
        /// and tries to find if there are plugins that haven't been registered in the
        /// global settings
        /// </remarks>
        public static void UpdatePluginList()
        {
            _logger.Trace("PluginsManager.UpdatePluginList()");

            // Get current global settings
            var settings = ProgramSettings.GetGlobalSettings();

            // Get DefaultPluginsLocation
            string pluginsDirectory = settings.DirectoriesSettings.PluginsDirectory;

            Uri pluginsDirectoryUri = new Uri(pluginsDirectory, UriKind.Absolute);

            // Get all DLL inside the directory
            foreach (string pluginLocation in Directory.GetFiles(pluginsDirectory, "*.dll", SearchOption.AllDirectories))
            {
                Uri pluginLocationUri = new Uri(pluginLocation, UriKind.Absolute);

                byte[] assemblyBytes = File.ReadAllBytes(pluginLocation);
                Assembly assembly = Assembly.Load(assemblyBytes);

                string relativePluginLocation = pluginsDirectoryUri.MakeRelativeUri(pluginLocationUri).ToString();

                // Check each assembly for plugins
                CheckAssembly(relativePluginLocation, assembly, settings);
            }
        }

        /// <summary>
        /// Imports the plugin.
        /// </summary>
        /// <param name="pluginLocation">The plugin location.</param>
        /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
        public static void ImportPlugin(string pluginLocation, bool overwrite = false)
        {
            _logger.Trace("PluginsManager.ImportPlugin('{0}')", pluginLocation);

            // Get current global settings
            var settings = ProgramSettings.GetGlobalSettings();

            string extension = Path.GetExtension(pluginLocation) ?? string.Empty;

            if (extension.EndsWith(".zip", StringComparison.InvariantCultureIgnoreCase))
            {
                string shortUniqueName = StringHelper.CreateUniqueName(Path.GetFileNameWithoutExtension(pluginLocation));

                string tempDirectory = settings.DirectoriesSettings.TempDirectory;

                string pluginTempDirectory = Path.Combine(tempDirectory, shortUniqueName);

                Uri pluginTempDirectoryUri = new Uri(tempDirectory, UriKind.Absolute);

                if (!Directory.Exists(pluginTempDirectory))
                {
                    Directory.CreateDirectory(pluginTempDirectory);
                }

                ZipFile.ExtractToDirectory(pluginLocation, pluginTempDirectory);

                foreach (string extractedPluginLocation in Directory.GetFiles(pluginTempDirectory, "*.dll", SearchOption.AllDirectories))
                {
                    Uri pluginLocationUri = new Uri(extractedPluginLocation, UriKind.Absolute);

                    byte[] assemblyBytes = File.ReadAllBytes(extractedPluginLocation);
                    Assembly assembly = Assembly.Load(assemblyBytes);

                    string relativePluginLocation = pluginTempDirectoryUri.MakeRelativeUri(pluginLocationUri).ToString();

                    // Check each assembly for plugins
                    if (CheckAssembly(relativePluginLocation, assembly, settings, false))
                    {
                        string pluginTargetDirectory = Path.Combine(settings.DirectoriesSettings.PluginsDirectory, shortUniqueName);

                        if (!Directory.Exists(pluginTargetDirectory))
                        {
                            Directory.Move(pluginTempDirectory, pluginTargetDirectory);
                        }
                    }
                }
            }
            else if (extension.EndsWith(".dll", StringComparison.InvariantCultureIgnoreCase))
            {
                byte[] assemblyBytes = File.ReadAllBytes(pluginLocation);
                Assembly assembly = Assembly.Load(assemblyBytes);

                // Check each assembly for plugins
                if (CheckAssembly(null, assembly, settings, false))
                {
                    string pluginTargetLocation = Path.Combine(settings.DirectoriesSettings.PluginsDirectory, Path.GetFileName(pluginLocation));

                    File.Copy(pluginLocation, pluginTargetLocation, overwrite);
                }
            }
        }

        /// <summary>
        /// Checks the existing plugins in the global settings.
        /// </summary>
        public static void CheckExistingPlugins()
        {
            _logger.Trace("PluginsManager.CheckExistingPlugins()");

            // Get current global settings
            var settings = ProgramSettings.GetGlobalSettings();

            // Get DefaultPluginsLocation
            string pluginsDirectory = settings.DirectoriesSettings.PluginsDirectory;

            foreach (var pluginAssembly in settings.Assemblies)
            {
                try
                {
                    // Load the assembly from the plugin folder
                    string pluginLocation = Path.Combine(pluginsDirectory, pluginAssembly.File);

                    byte[] assemblyBytes = File.ReadAllBytes(pluginLocation);
                    Assembly assembly = Assembly.Load(assemblyBytes);

                    bool isValidPlugin = false;
                    foreach (Configuration.GlobalPlugin pluginComponent in pluginAssembly.Plugins)
                    {
                        try
                        {
                            Type type = assembly.GetType(pluginComponent.Class);

                            // Try to create an instance of the type and check
                            // if inherit from IPluginBase interface
                            object runnable = Activator.CreateInstance(type);
                            if (runnable is IPluginBase)
                            {
                                isValidPlugin = true;

                                if (type != null)
                                {
                                    pluginAssembly.Version = type.Assembly.GetName().Version.ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.Error(ex, ex.Message);
                            isValidPlugin = false;
                        }
                        pluginComponent.IsValid = isValidPlugin;
                        pluginComponent.Enabled = isValidPlugin && pluginComponent.Enabled;
                    } // -- fin foreach (PluginType pluginType in pluginAssembly.Types)
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, ex.Message);
                    pluginAssembly.IsValid = false;
                    pluginAssembly.Plugins.ForEach(t =>
                    {
                        t.Enabled = false;
                        t.IsValid = false;
                    });
                }
            }
        }

        /// <summary>
        /// Gets the supported database controllers.
        /// </summary>
        /// <returns></returns>
        public static List<SupportedPluginComponent> GetSupportedAccessModelControllers()
        {
            _logger.Trace("PluginsManager.GetSupportedAccessModelControllers()");

            var supportedTypes = new List<SupportedPluginComponent>();

            var activeControllerInstances = GetAllPluginInstances<IAccessModelController>();

            foreach (var controller in activeControllerInstances)
            {
                Type type = controller.GetType();

                string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

                supportedTypes.Add(new SupportedPluginComponent
                {
                    Name = string.Format("{0} ({1})", controller.Title, controller.Version),
                    Guid = guid,
                    Assembly = type.Assembly.FullName,
                    Type = type.FullName,
                    Item = controller
                });
            }

            return supportedTypes;
        }

        /// <summary>
        /// Gets the supported templates.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<SupportedPluginComponent> GetSupportedTemplates<T>(ProjectController controller) where T : class, IGeneratorTemplate
        {
            _logger.Trace("PluginsManager.GetSupportedTemplates()");

            var supportedTypes = new List<SupportedPluginComponent>();

            var activeGeneratorPluginInstances = GetAllPluginInstances<T>();

            var pluginController = GetPluginInstance<IAccessModelController>(controller.Guid, controller.Plugin);

            foreach (T generator in activeGeneratorPluginInstances.Where(g => g.CompatibleControllers.Any(c => c.Equals(pluginController.DatabaseTypeCode, StringComparison.InvariantCultureIgnoreCase) || c.Equals("Any", StringComparison.InvariantCultureIgnoreCase))))
            {
                Type type = generator.GetType();

                string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

                supportedTypes.Add(new SupportedPluginComponent
                {
                    Name = string.Format("{0} ({1})", generator.Title, generator.Version),
                    Guid = guid,
                    Assembly = type.Assembly.FullName,
                    Type = type.FullName,
                    Item = generator
                });
            }

            return supportedTypes;
        }

        /// <summary>
        /// Gets the type of the data base.
        /// </summary>
        /// <param name="accessModelType">Type of the access model.</param>
        /// <returns></returns>
        public static EnumDatabaseTypes GetDataBaseType(SupportedPluginComponent accessModelType)
        {
            _logger.Trace("PluginsManager.GetDataBaseType('{0}')", accessModelType.Assembly);

            if (accessModelType != null)
            {
                var controller = accessModelType.Item as IAccessModelController;
                if (controller != null)
                {
                    return (EnumDatabaseTypes) Enum.Parse(typeof (EnumDatabaseTypes), controller.DatabaseTypeCode);
                }
            }

            return default(EnumDatabaseTypes);
        }

        /// <summary>
        /// Gets the table list from plugin.
        /// </summary>
        /// <param name="controller">The plugin.</param>
        /// <returns></returns>
        public static List<string> GetTableListFromPlugin(ProjectController controller)
        {
            _logger.Trace("PluginsManager.GetTableListFromPlugin('{0}')", controller.Plugin);

            var accessModel = GetPluginInstance<IAccessModelController>(controller.Guid, controller.Plugin);
            if (accessModel != null)
            {
                accessModel.Load(controller.ConnectionString);

                return accessModel.GetTableList();
            }
            return new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static DatabaseEntity GetEntityInfoFromPlugin(ProjectController controller, string tableName)
        {
            _logger.Trace("PluginsManager.GetEntityInfoFromPlugin('{0}', '{1}')", controller.Plugin, tableName);

            var accessModel = GetPluginInstance<IAccessModelController>(controller.Guid, controller.Plugin);
            if (accessModel != null)
            {
                if (!accessModel.IsLoaded)
                {
                    accessModel.Load(controller.ConnectionString);
                }

                return accessModel.GetEntityInfo(tableName);
            }
            return new DatabaseEntity();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorItem"></param>
        /// <returns></returns>
        public static List<GeneratorComponent> GetComponents(SupportedPluginComponent generatorItem)
        {
            _logger.Trace("PluginsManager.GetComponents()");

            if (generatorItem != null)
            {
                var template = generatorItem.Item as IGeneratorTemplate;
                if (template != null)
                {
                    return template.GetComponents();
                }
            }

            return new List<GeneratorComponent>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorItem"></param>
        /// <returns></returns>
        public static bool CheckIfPluginHaveOptions(SupportedPluginComponent generatorItem)
        {
            _logger.Trace("PluginsManager.CheckIfPluginHaveOptions()");

            if (generatorItem != null)
            {
                var template = generatorItem.Item as IGeneratorTemplate;
                if (template != null)
                {
                    return template.HaveOptions;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessModelItem"></param>
        /// <returns></returns>
        public static bool CheckIfPluginHaveCustomConnectionStringsForm(SupportedPluginComponent accessModelItem)
        {
            _logger.Trace("PluginsManager.CheckIfPluginHaveCustomConnectionStringsForm()");

            if (accessModelItem != null)
            {
                var controller = accessModelItem.Item as IAccessModelController;
                if (controller != null)
                {
                    return controller.HaveCustomConnectionStringForm;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorItem"></param>
        /// <returns></returns>
        public static bool ShowTemplateOptions(SupportedPluginComponent generatorItem)
        {
            _logger.Trace("PluginsManager.ShowTemplateOptions()");

            if (generatorItem != null)
            {
                var template = generatorItem.Item as IGeneratorTemplate;
                if (template != null)
                {
                    return template.ShowOptionsForm();
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorItem"></param>
        /// <returns></returns>
        public static PluginSettings GetSettingsFromPlugin(SupportedPluginComponent generatorItem)
        {
            _logger.Trace("PluginsManager.GetSettingsFromPlugin()");

            if (generatorItem != null)
            {
                var template = generatorItem.Item as IGeneratorTemplate;
                if (template != null)
                {
                    return template.Settings;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorComponent"></param>
        /// <param name="settings"></param>
        public static void UpdateSettingsForPlugin(SupportedPluginComponent generatorComponent, PluginSettings settings)
        {
            _logger.Trace("PluginsManager.UpdateSettingsForPlugin()");

            if (generatorComponent != null)
            {
                var template = generatorComponent.Item as IGeneratorTemplate;
                if (template != null)
                {
                    template.UpdateSettings(settings);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorComponent"></param>
        /// <param name="project"></param>
        public static void UpdateProjectSettingsForPlugin(SupportedPluginComponent generatorComponent, Project project)
        {
            _logger.Trace("PluginsManager.UpdateProjectSettingsForPlugin()");

            if (generatorComponent != null)
            {
                var template = generatorComponent.Item as IGeneratorTemplate;
                if (template != null)
                {
                    var type = template.GetType();

                    string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

                    var pluginProperties = Data.ProjectsController.GetPluginProperties(project, guid);

                    if (pluginProperties != null && pluginProperties.Parameters != null)
                    {
                        PluginSettings settings = new PluginSettings();
                        foreach (PluginParameter parameter in pluginProperties.Parameters)
                        {
                            var value = new PluginSettingValue();
                            value.Key = parameter.Code;
                            value.Value = parameter.Value;
                            value.UseDefault = parameter.UseDefault;
                            value.Type = parameter.Type;
                            settings.Add(value);
                        }

                        template.UpdateSettings(settings);
                    }
                }
            }
        }

        /// <summary>
        /// Verify the Assembly looking for classes that are compatible plugins and
        /// then register it in the global settings
        /// </summary>
        /// <param name="relativeLocation"></param>
        /// <param name="assembly">The assembly.</param>
        /// <param name="settings">The global settings.</param>
        /// <param name="addToSettings"></param>
        private static bool CheckAssembly(string relativeLocation, Assembly assembly, GlobalSettings settings, bool addToSettings = true)
        {
            _logger.Trace("PluginsManager.CheckAssembly()");

            bool isValidAssembly = false;
            bool isNew = false;

            // Check all public non-abstract classes
            foreach (Type type in assembly.GetExportedTypes().Where(t => t.IsClass && !t.IsAbstract))
            {
                Configuration.GlobalPlugin pluginComponent = new Configuration.GlobalPlugin();

                bool isValidPlugin = false;

                try
                {
                    // Try to create an instance and check if inherit for IPluginBase interface
                    var instance = assembly.CreateInstance(type.FullName) as IPluginBase;
                    if (instance != null)
                    {
                        pluginComponent.Title = instance.Title;
                        pluginComponent.CreatedBy = instance.CreatedBy;
                        pluginComponent.Icon = instance.Icon;
                        pluginComponent.Description = instance.Description;
                        pluginComponent.Version = instance.Version;
                        pluginComponent.ReleaseNotesUrl = instance.ReleaseNotesUrl;
                        pluginComponent.AuthorWebsiteUrl = instance.AuthorWebsiteUrl;
                        pluginComponent.Class = type.FullName;
                        pluginComponent.Enabled = true;
                        pluginComponent.IsValid = true;

                        if (instance is IGeneratorTemplate)
                        {
                            pluginComponent.Base = "GeneratorTemplate";
                        }
                        else if (instance is IAccessModelController)
                        {
                            pluginComponent.Base = "AccessModelController";
                        }

                        isValidPlugin = true;
                    }
                }
                catch(Exception ex)
                {
                    _logger.Error(ex, ex.Message);
                    isValidPlugin = false;
                }

                if (isValidPlugin)
                {
                    isValidAssembly = true;

                    // Get Assembly fileName
                    string assemblyName = assembly.GetName().Name;
                    string guid = ((GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0]).Value;

                    // Check if assembly was already registered in the global settings
                    var settingsAssembly = settings.Assemblies.FirstOrDefault(a => a.Guid.Equals(guid, StringComparison.InvariantCultureIgnoreCase));

                    // if not add to the list
                    if (settingsAssembly == null)
                    {
                        settingsAssembly = new GlobalAssembly();
                        settingsAssembly.Title = assemblyName;
                        settingsAssembly.Guid = guid;
                        settingsAssembly.Version = assembly.GetName().Version.ToString();
                        settingsAssembly.File = relativeLocation;
                        settingsAssembly.DateInstalled = DateTime.Now;
                        settingsAssembly.IsValid = true;

                        IAssemblyDetails assemblyDetails = GetAssemblyDetails(assembly);
                        if (assemblyDetails != null)
                        {
                            settingsAssembly.Title = assemblyDetails.Title;
                            settingsAssembly.Version = assemblyDetails.Version;
                            settingsAssembly.Description = assemblyDetails.Description;
                            settingsAssembly.Author = assemblyDetails.Author;
                            settingsAssembly.Url = assemblyDetails.Url;
                        }

                        if (addToSettings)
                        {
                            settings.Assemblies.Add(settingsAssembly);
                        }

                        isNew = true;
                    }

                    // Check if the Class was already registered in the assembly 
                    if (!settingsAssembly.Plugins.Exists(t => t.Class.Equals(type.FullName, StringComparison.InvariantCultureIgnoreCase)) && addToSettings)
                    {
                        // if not add to the list
                        settingsAssembly.Plugins.Add(pluginComponent);

                        isNew = true;
                    }
                }
            }

            return isValidAssembly && isNew;
        }

        private static IAssemblyDetails GetAssemblyDetails(Assembly assembly)
        {
            _logger.Trace("PluginsManager.GetAssemblyDetails()");

            foreach (Type type in assembly.GetExportedTypes().Where(t => t.IsClass && !t.IsAbstract))
            {
                try
                {
                    // Try to create an instance and check if inherit for IPluginBase interface
                    var instance = Activator.CreateInstance(type) as IAssemblyDetails;
                    if (instance != null)
                    {
                        return instance;
                    }
                }
                catch(Exception ex)
                {
                    _logger.Error(ex, ex.Message);
                    return null;
                }
            }

            return null;
        }

        private static List<T> GetAllPluginInstances<T>() where T : class, IPluginBase
        {
            _logger.Trace("PluginsManager.GetAllPluginInstances()");

            List<T> list = new List<T>();

            // Get the global settings
            var settings = ProgramSettings.GetGlobalSettings();

            foreach (var pluginAssembly in settings.Assemblies.Where(p => p.IsValid))
            {
                foreach (var pluginType in pluginAssembly.Plugins.Where(t => t.Enabled))
                {
                    // If the type instance was already loaded, returns the instance
                    if (pluginType.IsLoaded)
                    {
                        T instance = pluginType.PluginInstance as T;
                        if (instance != null)
                        {
                            list.Add(instance);
                        }
                    }
                    else 
                    {
                        if (!pluginAssembly.IsLoaded)
                        {
                            string pluginsDirectory = settings.DirectoriesSettings.PluginsDirectory;

                            string pluginLocation = Path.Combine(pluginsDirectory, pluginAssembly.File);

                            pluginAssembly.AssemblyInstance = Assembly.LoadFile(pluginLocation);
                            pluginAssembly.IsLoaded = true;
                        }

                        Type type = pluginAssembly.AssemblyInstance.GetType(pluginType.Class);

                        var instance = Activator.CreateInstance(type) as T;
                        if (instance != null)
                        {
                            list.Add(instance);
                            pluginType.PluginInstance = instance;
                            pluginType.IsLoaded = true;
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Gets the plugin instance from the global settins.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemblyGuid">The assembly file name.</param>
        /// <param name="pluginComponent">Type of the plugin.</param>
        /// <returns>Instance object of the plugin</returns>
        private static T GetPluginInstance<T>(string assemblyGuid, string pluginComponent) where T : class, IPluginBase
        {
            _logger.Trace("PluginsManager.GetPluginInstance()");

            // Get the global settings
            var settings = ProgramSettings.GetGlobalSettings();

            // Find the Assembly in the global settings
            var globalAssembly = settings.Assemblies.First(a => a.Guid.SequenceEqual(assemblyGuid));

            // Find the type in the assembly
            var globalAssemblyComponent = globalAssembly.Plugins.First(t => t.Class.Equals(pluginComponent, StringComparison.InvariantCultureIgnoreCase));

            // If the type instance was already loaded, returns the instance
            if (globalAssemblyComponent.IsLoaded)
            {
                return (T) globalAssemblyComponent.PluginInstance;
            }

            // If the assembly is not loaded we need to create an instance
            if (!globalAssembly.IsLoaded)
            {
                string pluginsDirectory = settings.DirectoriesSettings.PluginsDirectory;

                string pluginLocation = Path.Combine(pluginsDirectory, globalAssembly.File);

                if (File.Exists(pluginLocation))
                {
                    globalAssembly.AssemblyInstance = Assembly.LoadFile(pluginLocation);
                    globalAssembly.IsLoaded = true;
                }
                else
                {
                    return null;
                }
            }

            Type type = globalAssembly.AssemblyInstance.GetType(pluginComponent);

            var instance = Activator.CreateInstance(type);

            // Create the new instance of the plugin and save it in the global settings (for later use)
            globalAssemblyComponent.PluginInstance = (T)instance;
            globalAssemblyComponent.IsLoaded = true;

            // returns the instance of the plugin
            return (T) globalAssemblyComponent.PluginInstance;
        }

        /// <summary>
        /// Saves the Assembly Icon cache in disk
        /// </summary>
        /// <param name="icon">The icon.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>File Path of the Icon</returns>
        public static string SaveIconOnCache(Image icon, GlobalSettings settings)
        {
            _logger.Trace("PluginsManager.SaveIconOnCache()");

            if (icon != null)
            {
                const string imageExtension = ".png";

                string uniqueGuid = Guid.NewGuid().ToString("N"); // Remove -
                string iconFilename = uniqueGuid + imageExtension;

                string iconCacheLocation = Path.Combine(settings.DirectoriesSettings.CacheDirectory, iconFilename);

                int index = 1;
                while (File.Exists(iconCacheLocation))
                {
                    iconFilename = uniqueGuid + "_" + index + imageExtension;
                    iconCacheLocation = Path.Combine(settings.DirectoriesSettings.CacheDirectory, iconFilename);
                    index += 1;
                }

                icon.Save(iconCacheLocation, ImageFormat.Png);

                return iconFilename;
            }
            return null;
        }
    }
}
