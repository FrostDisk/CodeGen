using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CodeGen.Configuration;
using CodeGen.Core;
using CodeGen.Domain;
using CodeGen.Plugin.Base;

namespace CodeGen.Utils
{
    public static class PluginsManager
    {
        public static void UpdatePluginList()
        {
            var settings = ProgramSettings.GetGlobalSettings();

            CheckAssembly(Assembly.GetExecutingAssembly(), settings, true);

            string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

            foreach (string pluginLocation in Directory.GetFiles(pluginsDirectory, "*.dll", SearchOption.AllDirectories))
            {
                Assembly assembly = Assembly.LoadFile(pluginLocation);

                CheckAssembly(assembly, settings);
            }
        }

        public static void CheckExistingPlugins()
        {
            var settings = ProgramSettings.GetGlobalSettings();

            string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

            foreach (var pluginAssembly in settings.PluginsSettings.Plugins)
            {
                if (!pluginAssembly.IsBase)
                {
                    try
                    {
                        string pluginLocation = Path.Combine(pluginsDirectory, pluginAssembly.File);
                        Assembly assembly = Assembly.LoadFile(pluginLocation);

                        bool isValidPlugin = false;
                        foreach (PluginType pluginType in pluginAssembly.Types)
                        {
                            try
                            {
                                Type type = assembly.GetType(pluginType.Name);

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
                        }
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
                }
                else
                {
                    bool isValidPlugin = false;
                    foreach (PluginType pluginType in pluginAssembly.Types)
                    {
                        try
                        {
                            Type type = Assembly.GetExecutingAssembly().GetType(pluginType.Name);

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

        public static List<SupportedType> GetCodeTemplates()
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

                        if (type != null)
                        {
                            var runnable = Activator.CreateInstance(type) as IGeneratorTemplate;
                            if (runnable != null && runnable.HaveCodeComponents)
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
                else
                {
                    foreach (PluginType pluginType in pluginAssembly.Types.Where(t => t.Enabled))
                    {
                        Type type = Assembly.GetExecutingAssembly().GetType(pluginType.Name);

                        var runnable = Activator.CreateInstance(type) as IGeneratorTemplate;
                        if (runnable != null && runnable.HaveCodeComponents)
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
            var accessModel = LoadPluginByName<IAccessModelController>(plugin.Assembly, plugin.Type);

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
                    return controller.GetCodeComponents();
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

        private static void CheckAssembly(Assembly assembly, GlobalSettings settings, bool isBase = false)
        {
            foreach (Type type in assembly.GetExportedTypes().Where(t => t.IsClass && !t.IsAbstract))
            {
                bool isValidPlugin = false;

                try
                {
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
                    string assemblyName = Path.GetFileName(assembly.Location);

                    var settingsAssembly = !isBase ? settings.PluginsSettings.Plugins.FirstOrDefault(a => a.File == assemblyName) : settings.PluginsSettings.Plugins.FirstOrDefault(a => a.IsBase);

                    if (settingsAssembly == null)
                    {
                        settingsAssembly = new PluginAssembly();
                        settingsAssembly.File = assemblyName;
                        settingsAssembly.Version = assembly.GetName().Version.ToString();
                        settingsAssembly.IsValid = true;
                        settingsAssembly.IsBase = isBase;

                        settings.PluginsSettings.Plugins.Add(settingsAssembly);
                    }

                    if (!settingsAssembly.Types.Exists(t => t.Name == type.FullName))
                    {
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

        private static T LoadPluginByName<T>(string assemblyFile, string pluginType) where T : class, IPluginBase
        {
            var settings = ProgramSettings.GetGlobalSettings();

            var globalAssembly = settings.PluginsSettings.Plugins.First(a => a.File == assemblyFile);

            if (string.IsNullOrWhiteSpace(assemblyFile) || globalAssembly.IsBase)
            {
                Type type = Assembly.GetExecutingAssembly().GetType(pluginType);

                return Activator.CreateInstance(type) as T;
            }
            else
            {
                string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

                string pluginLocation = Path.Combine(pluginsDirectory, assemblyFile);
                Assembly assembly = Assembly.LoadFile(pluginLocation);

                Type type = assembly.GetType(pluginType, true);

                return Activator.CreateInstance(type) as T;
            }
        }
    }
}
