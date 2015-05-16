﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CodeGen.Configuration;
using CodeGen.Core;
using CodeGen.Data;
using CodeGen.Domain;
using CodeGen.Plugin.Base;

namespace CodeGen.Utils
{
    /// <summary>
    /// Class to manage all comunication between the application and the plugins
    /// </summary>
    public static class PluginsManager
    {
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
            CheckAssembly(Assembly.GetExecutingAssembly(), settings, true);

            // Get DefaultPluginsLocation
            string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

            // Get all DLL inside the directory
            foreach (string pluginLocation in Directory.GetFiles(pluginsDirectory, "*.dll", SearchOption.AllDirectories))
            {
                Assembly assembly = Assembly.LoadFile(pluginLocation);

                // Check each assembly for plugins
                CheckAssembly(assembly, settings);
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
            string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

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
                        Assembly assembly = Assembly.LoadFile(pluginLocation);

                        bool isValidPlugin = false;
                        foreach (PluginType pluginType in pluginAssembly.Types)
                        {
                            try
                            {
                                Type type = assembly.GetType(pluginType.Name);

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
                            catch
                            {
                                isValidPlugin = false;
                            }
                            pluginType.IsValid = isValidPlugin;
                            pluginType.Enabled = isValidPlugin && pluginType.Enabled;
                        } // -- fin foreach (PluginType pluginType in pluginAssembly.Types)
                    }
                    catch
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
                            Type type = Assembly.GetExecutingAssembly().GetType(pluginType.Name);

                            // Try to create an instance of the type and check
                            // if inherit from IPluginBase interface
                            object runnable = Activator.CreateInstance(type);
                            if (runnable is IPluginBase)
                            {
                                isValidPlugin = true;
                            }
                        }
                        catch
                        {
                            isValidPlugin = false;
                        }

                        pluginType.IsValid = isValidPlugin;
                        pluginType.Enabled = isValidPlugin && pluginType.Enabled;
                    }
                }
            }
        }

        public static List<SupportedType> GetDatabaseTypes()
        {
            var supportedTypes = new List<SupportedType>();

            var settings = ProgramSettings.GetGlobalSettings();

            string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

            foreach (var pluginAssembly in settings.PluginsSettings.Plugins.Where(p => p.IsValid))
            {
                if (!pluginAssembly.IsBase)
                {
                    string pluginLocation = Path.Combine(pluginsDirectory, pluginAssembly.File);
                    Assembly assembly = Assembly.LoadFile(pluginLocation);

                    foreach (PluginType pluginType in pluginAssembly.Types.Where(t => t.Enabled))
                    {
                        Type type = assembly.GetType(pluginType.Name);

                        var runnable = Activator.CreateInstance(type) as IAccessModelController;
                        if (runnable != null)
                        {
                            supportedTypes.Add(new SupportedType
                            {
                                Assembly = pluginAssembly.File,
                                Name = runnable.Name,
                                Type = pluginType.Name
                            });
                        }
                    }
                }
                else
                {
                    foreach (PluginType pluginType in pluginAssembly.Types.Where(t => t.Enabled))
                    {
                        Type type = Assembly.GetExecutingAssembly().GetType(pluginType.Name);

                        if (type != null)
                        {
                            var runnable = Activator.CreateInstance(type) as IAccessModelController;
                            if (runnable != null)
                            {
                                supportedTypes.Add(new SupportedType
                                {
                                    Assembly = pluginAssembly.File,
                                    Name = runnable.Name,
                                    Type = pluginType.Name,
                                    Item = runnable
                                });
                            }
                        }
                    }
                }
            }

            return supportedTypes;
        }

        public static List<SupportedType> GetSupportedTemplates<T>() where T : class, IGeneratorTemplate
        {
            var supportedTypes = new List<SupportedType>();

            var activeGeneratorPluginInstances = GetAllPluginInstances<T>();

            foreach (T generator in activeGeneratorPluginInstances)
            {
                Type type = generator.GetType();

                supportedTypes.Add(new SupportedType
                {
                    Assembly = Path.GetFileName(type.Assembly.Location),
                    Name = generator.Name,
                    Type = type.FullName,
                    Item = generator
                });
            }

            return supportedTypes;
        }

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

        public static List<string> GetTableListFromPlugin(string connectionString, ProjectPlugin plugin)
        {
            var accessModel = GetPluginInstance<IAccessModelController>(plugin.Assembly, plugin.Type);

            accessModel.Load(connectionString);

            return accessModel.GetTableList();
        }

        public static List<GeneratorComponent> GetComponents(SupportedType generatorItem)
        {
            if (generatorItem != null)
            {
                var controller = generatorItem.Item as IGeneratorTemplate;
                if (controller != null)
                {
                    return controller.GetComponents();
                }
            }

            return new List<GeneratorComponent>();
        }

        public static bool CheckIfPluginHaveOptions(SupportedType generatorItem)
        {
            if (generatorItem != null)
            {
                var controller = generatorItem.Item as IGeneratorTemplate;
                if (controller != null)
                {
                    return controller.HaveOptions;
                }
            }

            return false;
        }

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

        public static bool ShowTemplateOptions(SupportedType generatorItem)
        {
            if (generatorItem != null)
            {
                var controller = generatorItem.Item as IGeneratorTemplate;
                if (controller != null)
                {
                    return controller.ShowOptionsForm();
                }
            }
            return false;
        }

        public static PluginSettings GetSettingsFromPlugin(SupportedType generatorItem)
        {
            if (generatorItem != null)
            {
                var controller = generatorItem.Item as IGeneratorTemplate;
                if (controller != null)
                {
                    return controller.Settings;
                }
            }
            return null;
        }

        public static void UpdateSettingsForPlugin(SupportedType generatorItem, PluginSettings settings)
        {
            if (generatorItem != null)
            {
                var controller = generatorItem.Item as IGeneratorTemplate;
                if (controller != null)
                {
                    controller.UpdateSettings(settings);
                }
            }
        }

        public static void UpdateProjectSettingsForPlugin(SupportedType generatorItem, Project project)
        {
            if (generatorItem != null)
            {
                var controller = generatorItem.Item as IGeneratorTemplate;
                if (controller != null)
                {
                    var type = controller.GetType();
                    var assemblyFile = Path.GetFileName(type.Assembly.Location);

                    var pluginProperties = ProjectController.GetPluginProperties(project, assemblyFile, type.FullName);

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

                        controller.UpdateSettings(settings);
                    }
                }
            }
        }

        /// <summary>
        /// Verify the Assembly looking for classes that are compatible plugins and
        /// then register it in the global settings
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <param name="settings">The global settings.</param>
        /// <param name="isBase">if set to <c>true</c> the assembly means that are base (part of the application).</param>
        private static void CheckAssembly(Assembly assembly, GlobalSettings settings, bool isBase = false)
        {
            // Check all public non-abstract classes
            foreach (Type type in assembly.GetExportedTypes().Where(t => t.IsClass && !t.IsAbstract))
            {
                bool isValidPlugin = false;

                try
                {
                    // Try to create an instance and check if inherit for IPluginBase interface
                    object runnable = Activator.CreateInstance(type);
                    if (runnable is IPluginBase)
                    {
                        isValidPlugin = true;
                    }
                }
                catch
                {
                    isValidPlugin = false;
                }

                if (isValidPlugin)
                {
                    // Get Assembly fileName
                    string assemblyName = Path.GetFileName(assembly.Location);

                    // Check if assembly was already registered in the global settings
                    var settingsAssembly = settings.PluginsSettings.Plugins.FirstOrDefault(a => a.File == assemblyName);

                    // if not add to the list
                    if (settingsAssembly == null)
                    {
                        settingsAssembly = new PluginAssembly();
                        settingsAssembly.File = assemblyName;
                        settingsAssembly.Version = assembly.GetName().Version.ToString();
                        settingsAssembly.IsValid = true;
                        settingsAssembly.IsBase = isBase;

                        settings.PluginsSettings.Plugins.Add(settingsAssembly);
                    }

                    // Check if the Class was already registered in the assembly 
                    if (!settingsAssembly.Types.Exists(t => t.Name == type.FullName))
                    {
                        // if not add to the list
                        settingsAssembly.Types.Add(new PluginType
                        {
                            Name = type.FullName,
                            Enabled = isBase,
                            IsValid = true,
                        });
                    }
                }
            }
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
                                string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

                                string pluginLocation = Path.Combine(pluginsDirectory, pluginAssembly.File);

                                pluginAssembly.AssemblyInstance = Assembly.LoadFile(pluginLocation);
                                pluginAssembly.IsLoaded = true;
                            }
                        }

                        Type type = pluginAssembly.AssemblyInstance.GetType(pluginType.Name);

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
        /// <param name="assemblyFile">The assembly file name.</param>
        /// <param name="pluginType">Type of the plugin.</param>
        /// <returns>Instance object of the plugin</returns>
        private static T GetPluginInstance<T>(string assemblyFile, string pluginType) where T : class, IPluginBase
        {
            // Get the global settings
            var settings = ProgramSettings.GetGlobalSettings();

            // Find the Assembly in the global settings
            var globalAssembly = settings.PluginsSettings.Plugins.First(a => a.File == assemblyFile);

            // Find the type in the assembly
            var globalAssemblyType = globalAssembly.Types.First(t => t.Name == pluginType);

            // If the type instance was already loaded, returns the instance
            if (globalAssemblyType.IsLoaded)
            {
                return (T) globalAssemblyType.PluginInstance;
            }

            // If the assembly is not loaded we need to create an instance
            if (!globalAssembly.IsLoaded)
            {
                // Base Assembly means that are part of the application (not an external file)
                if (string.IsNullOrWhiteSpace(assemblyFile) || globalAssembly.IsBase)
                {
                    globalAssembly.AssemblyInstance = Assembly.GetExecutingAssembly();
                    globalAssembly.IsLoaded = true;
                }

                // Is not a base assembly and need to be loaded from the plugins directory
                else
                {
                    string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

                    string pluginLocation = Path.Combine(pluginsDirectory, assemblyFile);

                    globalAssembly.AssemblyInstance = Assembly.LoadFile(pluginLocation);
                    globalAssembly.IsLoaded = true;
                }
            }

            Type type = globalAssembly.AssemblyInstance.GetType(pluginType);

            // Create the new instance of the plugin and save it in the global settings (for later use)
            globalAssemblyType.PluginInstance = (T) Activator.CreateInstance(type);
            globalAssemblyType.IsLoaded = true;

            // returns the instance of the plugin
            return (T) globalAssemblyType.PluginInstance;
        }
    }
}
