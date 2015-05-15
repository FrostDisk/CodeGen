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
using CodeGen.Plugin.Base;
using CodeGen.Utils;

namespace CodeGen
{
    public partial class FormCSharpCodeConfiguration : Form
    {
        #region properties

        private Dictionary<string, TemplateParameter> _parameters;

        #endregion

        #region initialization

        public FormCSharpCodeConfiguration()
        {
            InitializeComponent();
            PopulateDictionary();
        }

        #endregion

        #region methods

        public PluginSettings GetSettings()
        {
            PluginSettings settings = new PluginSettings();

            foreach (var entry in _parameters)
            {
                PluginSettingValue value = new PluginSettingValue();
                value.Key = entry.Value.ParameterCode;
                value.Value = entry.Value.ParameterValue;
                value.UseDefault = entry.Value.IsDefaultValue;
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
            TemplateParameter parameter = _parameters[code];
            if (parameter != null)
            {
                parameter.ParameterValue = value;
            }
        }

        private bool ValidateForm()
        {
            List<string> messages = new List<string>();

            foreach (var entry in _parameters)
            {
                if (!entry.Value.Validate())
                {
                    messages.Add(string.Format("Parameter {0} is required",entry.Value.ParameterName));
                }
            }

            if (messages.Count > 0)
            {
                MessageBoxHelper.ValidationMessage(string.Join(Environment.NewLine, messages));
                return false;
            }
            return true;
        }

        private void PopulateDictionary(bool checkIfNull = true)
        {
            if (!checkIfNull || _parameters == null)
            {
                _parameters = new Dictionary<string, TemplateParameter>();
            }

            List<TemplateParameter> parameters = new List<TemplateParameter>();
            parameters.AddRange(GetParameters(this));

            foreach (TemplateParameter parameter in parameters)
            {
                _parameters[parameter.ParameterCode] = parameter;
            }
        }

        private List<TemplateParameter> GetParameters(Control control)
        {
            List<TemplateParameter> parameters = new List<TemplateParameter>();

            TemplateParameter parameter = control as TemplateParameter;
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