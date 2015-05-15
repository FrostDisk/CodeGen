using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGen.Controls
{
    public partial class TemplateParameter : UserControl
    {
        #region properties

        private string _savedValue;

        [Browsable(true)]
        public string ParameterName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        [Browsable(true)]
        public string ParameterCode
        {
            get { return lblCode.Text; }
            set { lblCode.Text = value; }
        }

        [Browsable(true)]
        public string ParameterValue
        {
            get { return txtValue.Text; }
            set
            {
                if (!IsUpdated && value != _savedValue)
                {
                    _savedValue = ParameterValue;
                    IsUpdated = true;
                }
                IsDefaultValue = value != DefaultValue;
                txtValue.Text = value;
            }
        }

        public bool IsUpdated { get; set; }

        [Browsable(true)]
        public string DefaultValue { get; set; }

        public bool IsDefaultValue { get; private set; }

        [Browsable(true)]
        public string Tooltip
        {
            get { return toolTipParameter.GetToolTip(txtValue); }
            set { toolTipParameter.SetToolTip(txtValue, value); }
        }

        [Browsable(true)]
        public bool ReadOnly
        {
            get { return txtValue.ReadOnly; }
            set { txtValue.ReadOnly = value; }
        }

        [Browsable(true)]
        public bool Required { get; set; }

        #endregion

        #region initialization

        public TemplateParameter()
        {
            InitializeComponent();

            Required = true;
            IsDefaultValue = ParameterValue == DefaultValue;
        }

        #endregion

        #region methods

        public bool Validate()
        {
            if (!Required)
            {
                return true;
            }

            return !string.IsNullOrWhiteSpace(txtValue.Text);
        }

        public void RestoreValue()
        {
            if (IsUpdated)
            {
                ParameterValue = _savedValue;
                IsUpdated = false;
            }

        }

        #endregion

        #region events
        #endregion
    }
}
