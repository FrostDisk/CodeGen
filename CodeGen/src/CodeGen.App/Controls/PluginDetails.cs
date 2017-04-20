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

        private PluginType _type;

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
        /// <param name="type">The type.</param>
        public void LoadType(PluginType type)
        {
            _type = type;

            var globalSettings = ProgramSettings.GetGlobalSettings();

            Image icon = Resources.add_on;

            if (type.Icon != null)
            {
                icon = type.Icon;

                if (string.IsNullOrWhiteSpace(type.IconPath))
                {
                    type.IconPath = PluginsManager.SaveIconOnCache(type.Icon, globalSettings);
                }
            }
            else if (!string.IsNullOrWhiteSpace(type.IconPath))
            {
                string iconLocation = Path.Combine(globalSettings.DirectoriesSettings.CacheDirectory, type.IconPath);
                if (File.Exists(iconLocation))
                {
                    type.Icon = Image.FromFile(iconLocation);
                    icon = type.Icon;
                }
                else if (type.PluginInstance != null)
                {
                    type.Icon = type.PluginInstance.Icon;
                    type.IconPath = PluginsManager.SaveIconOnCache(type.Icon, globalSettings);
                    icon = type.Icon;
                }
                else
                {
                    type.IconPath = null;
                }
            }

            pictureTypeIcon.Image = icon;

            lblCreatedBy.Text = type.CreatedBy;
            lblDateInstalled.Text = type.DateInstalled.ToShortDateString();
            lblVersion.Text = type.Version;

            Uri uriReleaseInfo;
            lnkReleasaeInfo.Visible = !string.IsNullOrWhiteSpace(type.ReleaseNotesUrl) && Uri.TryCreate(type.ReleaseNotesUrl, UriKind.Absolute, out uriReleaseInfo) && uriReleaseInfo.Scheme == Uri.UriSchemeHttp;

            Uri uriAuthorWebsite;
            lnkAuthorWebsite.Visible = !string.IsNullOrWhiteSpace(type.AuthorWebsiteUrl) && Uri.TryCreate(type.AuthorWebsiteUrl, UriKind.Absolute, out uriAuthorWebsite) && uriAuthorWebsite.Scheme == Uri.UriSchemeHttp;

            txtPluginDescription.Text = type.Description;
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
