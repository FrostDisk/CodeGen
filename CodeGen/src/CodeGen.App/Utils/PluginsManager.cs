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
            var settings = ProgramSettings.GetGlobalSettings();

            return settings.PluginsSettings.Plugins.Count() > 0;
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
            // Get current global settings
            var settings = ProgramSettings.GetGlobalSettings();

            // Check Active Assembly (Base Plugin)
            CheckAssembly(null, Assembly.GetExecutingAssembly(), settings, true);

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
        /// 
        /// </summary>
        /// <param name="pluginLocation"></param>
        public static void ImportPlugin(string pluginLocation)
        {
            // Get current global settings
            var settings = ProgramSettings.GetGlobalSettings();

            string extension = Path.GetExtension(pluginLocation) ?? string.Empty;

            if (extension.EndsWith(".zip"))
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
                    if (CheckAssembly(relativePluginLocation, assembly, settings, false, false))
                    {
                        string pluginTargetDirectory = Path.Combine(settings.DirectoriesSettings.PluginsDirectory, shortUniqueName);

                        if (!Directory.Exists(pluginTargetDirectory))
                        {
                            Directory.Move(pluginTempDirectory, pluginTargetDirectory);
                        }
                    }
                }
            }
            else if (extension.EndsWith(".dll"))
            {
                byte[] assemblyBytes = File.ReadAllBytes(pluginLocation);
                Assembly assembly = Assembly.Load(assemblyBytes);

                // Check each assembly for plugins
                if (CheckAssembly(null, assembly, settings, false, false))
                {
                    string pluginTargetLocation = Path.Combine(settings.DirectoriesSettings.PluginsDirectory, Path.GetFileName(pluginLocation));

                    File.Copy(pluginLocation, pluginTargetLocation);
                }
            }
        }

        /// <summary>
        /// Checks the existing plugins in the global settings.
        /// </summary>
        public static void CheckExistingPlugins()
        {
            // Get current global settings
            var settings = ProgramSettings.GetGlobalSettings();

            // Get DefaultPluginsLocation
            string pluginsDirectory = settings.DirectoriesSettings.PluginsDirectory;

            foreach (var pluginAssembly in settings.PluginsSettings.Plugins)
            {
                // Base plugins means that the assembly is part of the application
                // and don't need to be loaded again
                if (!pluginAssembly.IsBase)
                {
                    try
                    {
                        // Load the assembly from the plugin folder
                        string pluginLocation = Path.Combine(pluginsDirectory, pluginAssembly.File);

                        byte[] assemblyBytes = File.ReadAllBytes(pluginLocation);
                        Assembly assembly = Assembly.Load(assemblyBytes);

                        bool isValidPlugin = false;
                        foreach (PluginType pluginType in pluginAssembly.Types)
                        {
                            try
                            {
                                Type type = assembly.GetType(pluginType.Class);

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
                            catch(Exception)
                            {
                                isValidPlugin = false;
                            }
                            pluginType.IsValid = isValidPlugin;
                            pluginType.Enabled = isValidPlugin && pluginType.Enabled;
                        } // -- fin foreach (PluginType pluginType in pluginAssembly.Types)
                    }
                    catch(Exception)
                    {
                        pluginAssembly.IsValid = false;
                        pluginAssembly.Types.ForEach(t =>
                        {
                            t.Enabled = false;
                            t.IsValid = false;
                        });
                    }
                } // -- fin if (!pluginAssembly.IsBase)
                else
                {
                    bool isValidPlugin = false;
                    foreach (PluginType pluginType in pluginAssembly.Types)
                    {
                        try
                        {
                            // Base classes are part of the executing assembly
                            Type type = Assembly.GetExecutingAssembly().GetType(pluginType.Class);

                            // Try to create an instance of the type and check
                            // if inherit from IPluginBase interface
                            object runnable = Activator.CreateInstance(type);
                            if (runnable is IPluginBase)
                            {
                                isValidPlugin = true;
                            }
                        }
                        catch(Exception)
                        {
                            isValidPlugin = false;
                        }

                        pluginType.IsValid = isValidPlugin;
                        pluginType.Enabled = isValidPlugin && pluginType.Enabled;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the supported database controllers.
        /// </summary>
        /// <returns></returns>
        public static List<SupportedType> GetSupportedAccessModelControllers()
        {
            var supportedTypes = new List<SupportedType>();

            var activeControllerInstances = GetAllPluginInstances<IAccessModelController>();

            foreach (var controller in activeControllerInstances)
            {
                Type type = controller.GetType();

                string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

                supportedTypes.Add(new SupportedType
                {
                    Name = string.Format("{0} ({1})", controller.Title, controller.Version),
                    Guid = guid,
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
        public static List<SupportedType> GetSupportedTemplates<T>() where T : class, IGeneratorTemplate
        {
            var supportedTypes = new List<SupportedType>();

            var activeGeneratorPluginInstances = GetAllPluginInstances<T>();

            foreach (T generator in activeGeneratorPluginInstances)
            {
                Type type = generator.GetType();

                string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

                supportedTypes.Add(new SupportedType
                {
                    Name = string.Format("{0} ({1})", generator.Title, generator.Version),
                    Guid = guid,
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
        public static EnumDatabaseTypes GetDataBaseType(SupportedType accessModelType)
        {
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
        /// <param name="connectionString">The connection string.</param>
        /// <param name="plugin">The plugin.</param>
        /// <returns></returns>
        public static List<string> GetTableListFromPlugin(string connectionString, ProjectPlugin plugin)
        {
            var accessModel = GetPluginInstance<IAccessModelController>(plugin.Guid, plugin.Type);
            if (accessModel != null)
            {
                accessModel.Load(connectionString);

                return accessModel.GetTableList();
            }
            return new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="plugin"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static DatabaseEntity GetEntityInfoFromPlugin(string connectionString, ProjectPlugin plugin, string tableName)
        {
            var accessModel = GetPluginInstance<IAccessModelController>(plugin.Guid, plugin.Type);
            if (accessModel != null)
            {
                if (!accessModel.IsLoaded)
                {
                    accessModel.Load(connectionString);
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
        public static List<GeneratorComponent> GetComponents(SupportedType generatorItem)
        {
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
        public static bool CheckIfPluginHaveOptions(SupportedType generatorItem)
        {
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
        public static bool CheckIfPluginHaveCustomConnectionStringsForm(SupportedType accessModelItem)
        {
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
        /// <param name="pluginBase"></param>
        /// <returns></returns>
        public static bool CheckIfPluginIsBase(IPluginBase pluginBase)
        {
            var settings = ProgramSettings.GetGlobalSettings();

            var type = pluginBase.GetType();

            var assembly = settings.PluginsSettings.Plugins.FirstOrDefault(a => a.File == Path.GetFileName(type.Assembly.Location));

            if (assembly != null)
            {
                return assembly.IsBase;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorItem"></param>
        /// <returns></returns>
        public static bool ShowTemplateOptions(SupportedType generatorItem)
        {
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
        public static PluginSettings GetSettingsFromPlugin(SupportedType generatorItem)
        {
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
        /// <param name="generatorItem"></param>
        /// <param name="settings"></param>
        public static void UpdateSettingsForPlugin(SupportedType generatorItem, PluginSettings settings)
        {
            if (generatorItem != null)
            {
                var template = generatorItem.Item as IGeneratorTemplate;
                if (template != null)
                {
                    template.UpdateSettings(settings);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatorItem"></param>
        /// <param name="project"></param>
        public static void UpdateProjectSettingsForPlugin(SupportedType generatorItem, Project project)
        {
            if (generatorItem != null)
            {
                var template = generatorItem.Item as IGeneratorTemplate;
                if (template != null)
                {
                    var type = template.GetType();

                    string guid = ((GuidAttribute)(type.Assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0])).Value;

                    var pluginProperties = ProjectController.GetPluginProperties(project, guid, type.FullName);

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
        /// <param name="isBase">if set to <c>true</c> the assembly means that are base (part of the application).</param>
        /// <param name="addToSettings"></param>
        private static bool CheckAssembly(string relativeLocation, Assembly assembly, GlobalSettings settings, bool isBase = false, bool addToSettings = true)
        {
            bool isValidAssembly = false;
            bool isNew = false;

            // Check all public non-abstract classes
            foreach (Type type in assembly.GetExportedTypes().Where(t => t.IsClass && !t.IsAbstract))
            {
                PluginType pluginType = new PluginType();

                bool isValidPlugin = false;

                try
                {
                    // Try to create an instance and check if inherit for IPluginBase interface
                    var instance = assembly.CreateInstance(type.FullName) as IPluginBase;
                    if (instance != null)
                    {
                        pluginType.Title = instance.Title;
                        pluginType.CreatedBy = instance.CreatedBy;
                        pluginType.Icon = instance.Icon;
                        pluginType.Description = instance.Description;
                        pluginType.Version = instance.Version;
                        pluginType.ReleaseNotesUrl = instance.ReleaseNotesUrl;
                        pluginType.AuthorWebsiteUrl = instance.AuthorWebsiteUrl;
                        pluginType.DateInstalled = DateTime.Now;
                        pluginType.Class = type.FullName;
                        pluginType.Enabled = isBase;
                        pluginType.IsValid = true;

                        if (instance is IGeneratorTemplate)
                        {
                            pluginType.Base = "GeneratorTemplate";
                        }
                        else if (instance is IAccessModelController)
                        {
                            pluginType.Base = "AccessModelController";
                        }

                        isValidPlugin = true;
                    }
                }
                catch(Exception)
                {
                    isValidPlugin = false;
                }

                if (isValidPlugin)
                {
                    isValidAssembly = true;

                    // Get Assembly fileName
                    string assemblyName = assembly.GetName().Name;
                    string guid = ((GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0]).Value;

                    // Check if assembly was already registered in the global settings
                    var settingsAssembly = settings.PluginsSettings.Plugins.FirstOrDefault(a => a.Guid == guid);

                    // if not add to the list
                    if (settingsAssembly == null)
                    {
                        IAssemblyDetails assemblyDetails = GetAssemblyDetails(assembly);

                        settingsAssembly = new PluginAssembly();
                        settingsAssembly.Title = assemblyName;
                        settingsAssembly.Guid = guid;
                        settingsAssembly.Version = assembly.GetName().Version.ToString();
                        settingsAssembly.File = isBase ? assemblyName : relativeLocation;
                        settingsAssembly.IsValid = true;
                        settingsAssembly.IsBase = isBase;

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
                            settings.PluginsSettings.Plugins.Add(settingsAssembly);
                        }

                        isNew = true;
                    }

                    // Check if the Class was already registered in the assembly 
                    if (!settingsAssembly.Types.Exists(t => t.Class == type.FullName) && addToSettings)
                    {
                        // if not add to the list
                        settingsAssembly.Types.Add(pluginType);

                        isNew = true;
                    }
                }
            }

            return isValidAssembly && isNew;
        }

        private static IAssemblyDetails GetAssemblyDetails(Assembly assembly)
        {
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
                catch
                {
                    return null;
                }
            }

            return null;
        }

        private static List<T> GetAllPluginInstances<T>() where T : class, IPluginBase
        {
            List<T> list = new List<T>();

            // Get the global settings
            var settings = ProgramSettings.GetGlobalSettings();

            foreach (var pluginAssembly in settings.PluginsSettings.Plugins.Where(p => p.IsValid))
            {
                foreach (var pluginType in pluginAssembly.Types.Where(t => t.Enabled))
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
                            // Base Assembly means that are part of the application (not an external file)
                            if (pluginAssembly.IsBase)
                            {
                                pluginAssembly.AssemblyInstance = Assembly.GetExecutingAssembly();
                                pluginAssembly.IsLoaded = true;
                            }

                            // Is not a base assembly and need to be loaded from the plugins directory
                            else
                            {
                                string pluginsDirectory = settings.DirectoriesSettings.PluginsDirectory;

                                string pluginLocation = Path.Combine(pluginsDirectory, pluginAssembly.File);

                                pluginAssembly.AssemblyInstance = Assembly.LoadFile(pluginLocation);
                                pluginAssembly.IsLoaded = true;
                            }
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
        /// <param name="pluginType">Type of the plugin.</param>
        /// <returns>Instance object of the plugin</returns>
        private static T GetPluginInstance<T>(string assemblyGuid, string pluginType) where T : class, IPluginBase
        {
            // Get the global settings
            var settings = ProgramSettings.GetGlobalSettings();

            // Find the Assembly in the global settings
            var globalAssembly = settings.PluginsSettings.Plugins.First(a => a.Guid == assemblyGuid);

            // Find the type in the assembly
            var globalAssemblyType = globalAssembly.Types.First(t => t.Class == pluginType);

            // If the type instance was already loaded, returns the instance
            if (globalAssemblyType.IsLoaded)
            {
                return (T) globalAssemblyType.PluginInstance;
            }

            // If the assembly is not loaded we need to create an instance
            if (!globalAssembly.IsLoaded)
            {
                // Base Assembly means that are part of the application (not an external file)
                if (globalAssembly.IsBase)
                {
                    globalAssembly.AssemblyInstance = Assembly.GetExecutingAssembly();
                    globalAssembly.IsLoaded = true;
                }

                // Is not a base assembly and need to be loaded from the plugins directory
                else
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
            }

            Type type = globalAssembly.AssemblyInstance.GetType(pluginType);

            // Create the new instance of the plugin and save it in the global settings (for later use)
            globalAssemblyType.PluginInstance = (T) Activator.CreateInstance(type);
            globalAssemblyType.IsLoaded = true;

            // returns the instance of the plugin
            return (T) globalAssemblyType.PluginInstance;
        }

        /// <summary>
        /// Saves the Assembly Icon cache in disk
        /// </summary>
        /// <param name="icon">The icon.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>File Path of the Icon</returns>
        public static string SaveIconOnCache(Image icon, GlobalSettings settings)
        {
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
