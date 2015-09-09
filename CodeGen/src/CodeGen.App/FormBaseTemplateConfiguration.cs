﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Controls;
using CodeGen.Library.Formats;
using CodeGen.Plugin.Base;
using CodeGen.Utils;

namespace CodeGen
{
    public partial class FormBaseTemplateConfiguration : Form
    {
        #region properties

        private static FormBaseTemplateConfiguration _instance;

        public static FormBaseTemplateConfiguration Instance
        {
            get { return _instance ?? (_instance = new FormBaseTemplateConfiguration()); }
        }

        private Dictionary<string, ITemplateParameter> _parameters;

        #endregion

        #region initialization

        public FormBaseTemplateConfiguration()
        {
            InitializeComponent();
            PopulateDictionary();

            paramAuthorName.ParameterValue = Environment.UserName;
        }

        #endregion

        #region methods

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

        public void UpdateSetting(string code, string value)
        {
            ITemplateParameter parameter = _parameters[code];
            if (parameter != null && !string.IsNullOrWhiteSpace(value))
            {
                parameter.UpdateValue(value);
            }
        }

        public bool ValidateForm(bool showMessages = true)
        {
            List<string> messages = new List<string>();

            foreach (var entry in _parameters)
            {
                if (!entry.Value.Validate())
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
