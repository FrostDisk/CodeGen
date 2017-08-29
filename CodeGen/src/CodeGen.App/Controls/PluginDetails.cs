using System;
using System.Windows.Forms;
using CodeGen.Configuration;
using CodeGen.Properties;
using System.Diagnostics;
using System.Drawing;
using CodeGen.Utils;
using System.IO;
using NLog;

namespace CodeGen.Controls
{
    /// <summary>
    /// PluginDetails
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class PluginDetails : UserControl
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private PluginComponent _type;

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginDetails"/> class.
        /// </summary>
        public PluginDetails()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        /// <summary>
        /// Loads the type.
        /// </summary>
        /// <param name="component">The type.</param>
        public void LoadComponent(PluginComponent component)
        {
            _type = component;

            var globalSettings = ProgramSettings.GetGlobalSettings();

            Image icon = Resources.add_on;

            if (component.Icon != null)
            {
                icon = component.Icon;

                if (string.IsNullOrWhiteSpace(component.IconPath))
                {
                    component.IconPath = PluginsManager.SaveIconOnCache(component.Icon, globalSettings);
                }
            }
            else if (!string.IsNullOrWhiteSpace(component.IconPath))
            {
                string iconLocation = Path.Combine(globalSettings.DirectoriesSettings.CacheDirectory, component.IconPath);
                if (File.Exists(iconLocation))
                {
                    component.Icon = Image.FromFile(iconLocation);
                    icon = component.Icon;
                }
                else if (component.PluginInstance != null)
                {
                    component.Icon = component.PluginInstance.Icon;
                    component.IconPath = PluginsManager.SaveIconOnCache(component.Icon, globalSettings);
                    icon = component.Icon;
                }
                else
                {
                    component.IconPath = null;
                }
            }

            pictureTypeIcon.Image = icon;

            lblCreatedBy.Text = component.CreatedBy;
            lblVersion.Text = component.Version;

            Uri uriReleaseInfo;
            lnkReleasaeInfo.Visible = !string.IsNullOrWhiteSpace(component.ReleaseNotesUrl) && Uri.TryCreate(component.ReleaseNotesUrl, UriKind.Absolute, out uriReleaseInfo) && uriReleaseInfo.Scheme == Uri.UriSchemeHttp;

            Uri uriAuthorWebsite;
            lnkAuthorWebsite.Visible = !string.IsNullOrWhiteSpace(component.AuthorWebsiteUrl) && Uri.TryCreate(component.AuthorWebsiteUrl, UriKind.Absolute, out uriAuthorWebsite) && uriAuthorWebsite.Scheme == Uri.UriSchemeHttp;

            txtPluginDescription.Text = component.Description;
        }

        #endregion

        #region events

        private void lnkReleasaeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_type.ReleaseNotesUrl);
        }

        private void lnkAuthorWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_type.AuthorWebsiteUrl);
        }

        #endregion
    }
}
