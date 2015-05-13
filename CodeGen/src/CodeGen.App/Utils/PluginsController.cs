using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CodeGen.App.Controls;
using CodeGen.Configuration;
using CodeGen.Plugin.Base;

namespace CodeGen.Utils
{
    public static class PluginsController
    {
        public static void UpdatePlugins()
        {
            var settings = ProgramSettings.GetGlobalSettings();

            CheckAssembly(typeof(SqlServerController).Assembly, settings, true);

            string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

            foreach (string pluginLocation in Directory.GetFiles(pluginsDirectory, "*.dll", SearchOption.AllDirectories))
            {
                Assembly assembly = Assembly.LoadFile(pluginLocation);

                CheckAssembly(assembly, settings);
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
                catch (Exception ex)
                {
                    isValidPlugin = false;
                }

                if (isValidPlugin)
                {
                    string assemblyName = Path.GetFileName(assembly.Location);
                    if (!settings.PluginsSettings.Plugins.Exists(p => p.Assembly == assemblyName  && p.Type == type.Name))
                    {
                        settings.PluginsSettings.Plugins.Add(new Configuration.Plugin
                        {
                            Assembly = assemblyName,
                            Version = assembly.GetName().Version.ToString(),
                            Type = type.Name,
                            Enabled = isBase,
                            IsValid = true,
                            IsBase = isBase
                        });
                    }
                }
            }
        }

        public static void CheckExistingPlugins()
        {
            var settings = ProgramSettings.GetGlobalSettings();

            string pluginsDirectory = settings.DirectoriesSettings.DefaultPluginsLocation;

            foreach (var plugin in settings.PluginsSettings.Plugins)
            {
                bool isValidPlugin = false;

                Type type;
                if (!plugin.IsBase)
                {
                    string pluginLocation = Path.Combine(pluginsDirectory, plugin.Assembly);
                    Assembly assembly = Assembly.LoadFile(pluginLocation);

                    type = assembly.GetType(plugin.Type);
                }
                else
                {
                    type = Type.GetType(plugin.Type);
                }

                try
                {
                    object runnable = Activator.CreateInstance(type);
                    if (runnable is IPluginBase)
                    {
                        isValidPlugin = true;
                    }
                }
                catch (Exception ex)
                {
                    isValidPlugin = false;
                }

                if (type != null)
                {
                    plugin.Version = type.Assembly.GetName().Version.ToString();
                }
                plugin.IsValid = isValidPlugin;
                plugin.Enabled = isValidPlugin && plugin.Enabled;
            }
        }
    }
}
