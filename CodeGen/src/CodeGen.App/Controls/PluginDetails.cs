using System;
using System.Windows.Forms;
using CodeGen.Configuration;
using CodeGen.Properties;
using System.Diagnostics;

namespace CodeGen.Controls
{
    public partial class PluginDetails : UserControl
    {
        #region properties

        private PluginType _type;

        #endregion

        #region initialization

        public PluginDetails()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadType(PluginType type)
        {
            _type = type;
            pictureTypeIcon.Image = type.Icon == null ? Resources.add_on : type.Icon;

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
