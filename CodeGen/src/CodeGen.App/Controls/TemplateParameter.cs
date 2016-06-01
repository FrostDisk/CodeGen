using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Library.Formats;

namespace CodeGen.Controls
{
    /// <summary>
    /// TemplateParameter
    /// </summary>
    /// <seealso cref="UserControl" />
    /// <seealso cref="ITemplateParameter" />
    public partial class TemplateParameter : UserControl, ITemplateParameter
    {
        #region properties

        private string _savedValue;

        /// <summary>
        /// ParameterName
        /// </summary>
        [Browsable(true)]
        public string ParameterName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        /// <summary>
        /// ParameterCode
        /// </summary>
        [Browsable(true)]
        public string ParameterCode
        {
            get { return lblCode.Text; }
            set { lblCode.Text = value; }
        }

        /// <summary>
        /// ParameterValue
        /// </summary>
        [Browsable(true)]
        public string ParameterValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        /// <summary>
        /// IsUpdated
        /// </summary>
        public bool IsUpdated { get; set; }

        /// <summary>
        /// DefaultValue
        /// </summary>
        [Browsable(true)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// IsDefaultValue
        /// </summary>
        public bool IsDefaultValue { get; private set; }

        /// <summary>
        /// Type
        /// </summary>
        public Type Type { get { return typeof (string); } }

        /// <summary>
        /// Tooltip
        /// </summary>
        [Browsable(true)]
        public string Tooltip
        {
            get { return toolTipParameter.GetToolTip(txtValue); }
            set { toolTipParameter.SetToolTip(txtValue, value); }
        }

        /// <summary>
        /// ReadOnly
        /// </summary>
        [Browsable(true)]
        public bool ReadOnly
        {
            get { return txtValue.ReadOnly; }
            set { txtValue.ReadOnly = value; }
        }

        /// <summary>
        /// Required
        /// </summary>
        [Browsable(true)]
        public bool Required { get; set; }

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateParameter"/> class.
        /// </summary>
        public TemplateParameter()
        {
            InitializeComponent();

            Required = true;
            IsDefaultValue = ParameterValue == DefaultValue;
        }

        #endregion

        #region methods

        /// <summary>
        /// Updates the value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void UpdateValue(string value)
        {
            if (!IsUpdated && !StringHelper.AreEquals(value, _savedValue))
            {
                _savedValue = ParameterValue;
                IsUpdated = true;
            }
            IsDefaultValue = StringHelper.AreEquals(value, DefaultValue);
            txtValue.Text = value;
        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
        public bool ValidateForm()
        {
            if (!Required)
            {
                return true;
            }

            return !string.IsNullOrWhiteSpace(txtValue.Text);
        }

        /// <summary>
        /// Restores the value.
        /// </summary>
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

        private void txtValue_Enter(object sender, EventArgs e)
        {
            if (!IsUpdated)
            {
                _savedValue = txtValue.Text;
            }
        }

        private void txtValue_Leave(object sender, EventArgs e)
        {
            UpdateValue(txtValue.Text);
        }

        #endregion
    }
}
