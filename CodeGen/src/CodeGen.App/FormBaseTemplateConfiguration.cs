using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeGen.Controls;
using CodeGen.Library.Formats;
using CodeGen.Plugin.Base;
using CodeGen.Utils;
using NLog;

namespace CodeGen
{
    /// <summary>
    /// Base Template Configuration Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormBaseTemplateConfiguration : Form
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private static FormBaseTemplateConfiguration _instance;

        /// <summary>
        /// Singleton Instance of this Class
        /// </summary>
        public static FormBaseTemplateConfiguration Instance
        {
            get { return _instance ?? (_instance = new FormBaseTemplateConfiguration()); }
        }

        private Dictionary<string, ITemplateParameter> _parameters;

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="FormBaseTemplateConfiguration"/> class.
        /// </summary>
        public FormBaseTemplateConfiguration()
        {
            InitializeComponent();
            PopulateDictionary();

            paramAuthorName.ParameterValue = Environment.UserName;
        }

        #endregion

        #region methods

        /// <summary>
        /// Replace the 'MyProject' name
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        public void ReplaceMyProject(string projectName)
        {
            string safeName = StringHelper.ConvertToSafeCodeName(projectName);

            foreach (var entry in _parameters)
            {
                if (!string.IsNullOrWhiteSpace(entry.Value.ParameterValue))
                {
                    entry.Value.UpdateValue(entry.Value.ParameterValue.Replace("MyProject", safeName));
                }
            }
        }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <returns></returns>
        public PluginSettings GetSettings()
        {
            PluginSettings settings = new PluginSettings();

            foreach (var entry in _parameters)
            {
                PluginSettingValue value = new PluginSettingValue();
                value.Key = entry.Value.ParameterCode;
                value.Value = entry.Value.ParameterValue;
                value.UseDefault = entry.Value.IsDefaultValue;
                value.Type = typeof (string);
                settings.Add(value);
            }

            return settings;
        }

        /// <summary>
        /// Save the settings 
        /// </summary>
        /// <param name="restartValues">if set to <c>true</c> [restart values].</param>
        public void FinishSetting(bool restartValues = false)
        {
            foreach (var entry in _parameters)
            {
                if (restartValues)
                {
                    entry.Value.RestoreValue();
                }
                else
                {
                    entry.Value.IsUpdated = false;
                }
            }
        }

        /// <summary>
        /// Updates the setting.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="value">The value.</param>
        public void UpdateSetting(string code, string value)
        {
            if (_parameters.ContainsKey(code))
            {
                ITemplateParameter parameter = _parameters[code];
                if (parameter != null && !string.IsNullOrWhiteSpace(value))
                {
                    parameter.UpdateValue(value);
                }
            }
        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <param name="showMessages">if set to <c>true</c> [show messages].</param>
        /// <returns></returns>
        public bool ValidateForm(bool showMessages = true)
        {
            List<string> messages = new List<string>();

            foreach (var entry in _parameters)
            {
                if (!entry.Value.ValidateForm())
                {
                    messages.Add(string.Format("Parameter {0} is required", entry.Value.ParameterName));
                }
            }

            if (messages.Count > 0)
            {
                if (showMessages)
                {
                    MessageBoxHelper.ValidationMessage(string.Join(Environment.NewLine, messages));
                }
                return false;
            }
            return true;
        }

        private void PopulateDictionary(bool checkIfNull = true)
        {
            if (!checkIfNull || _parameters == null)
            {
                _parameters = new Dictionary<string, ITemplateParameter>();
            }

            var parameters = new List<ITemplateParameter>();
            parameters.AddRange(GetParameters(this));

            foreach (ITemplateParameter parameter in parameters)
            {
                _parameters[parameter.ParameterCode] = parameter;
            }
        }

        private List<ITemplateParameter> GetParameters(Control control)
        {
            var parameters = new List<ITemplateParameter>();

            var parameter = control as ITemplateParameter;
            if (parameter != null)
            {
                parameters.Add(parameter);
            }

            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    parameters.AddRange(GetParameters(childControl));
                }
            }

            return parameters;
        }

        #endregion

        #region events

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                FinishSetting(false);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FinishSetting(true);
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
