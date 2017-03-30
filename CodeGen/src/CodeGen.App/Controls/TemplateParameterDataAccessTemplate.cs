using System;
using System.ComponentModel;
using System.Windows.Forms;
using CodeGen.Library.Formats;

namespace CodeGen.Controls
{
    /// <summary>
    /// TemplateParameterDataAccessTemplate
    /// </summary>
    /// <seealso cref="UserControl" />
    /// <seealso cref="ITemplateParameter" />
    public partial class TemplateParameterDataAccessTemplate : UserControl, ITemplateParameter
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
            get
            {
                if (radioDataAccessTemplateEnglish.Checked) return "en";
                if (radioDataAccessTemplateSpanish.Checked) return "es";
                return "default";
            }
            set
            {
                radioDataAccessTemplateDefault.Checked = value.Equals("default") || (!value.Equals("en") && !value.Equals("es"));
                radioDataAccessTemplateEnglish.Checked = value.Equals("en");
                radioDataAccessTemplateSpanish.Checked = value.Equals("es");
            }
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
            get { return toolTipParameter.GetToolTip(radioDataAccessTemplateDefault); }
            set { toolTipParameter.SetToolTip(radioDataAccessTemplateDefault, value); }
        }

        /// <summary>
        /// ReadOnly
        /// </summary>
        [Browsable(true)]
        public bool ReadOnly
        {
            get { return false; }
            set
            {
                radioDataAccessTemplateDefault.Enabled = !value;
                radioDataAccessTemplateEnglish.Enabled = !value;
                radioDataAccessTemplateSpanish.Enabled = !value;
            }
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
        public TemplateParameterDataAccessTemplate()
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

            ParameterValue = value;
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

            return !radioDataAccessTemplateDefault.Checked
                || !radioDataAccessTemplateEnglish.Checked
                || !radioDataAccessTemplateSpanish.Checked;
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

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ParameterCode + " = \"" + ParameterValue + "\"";
        }

        #endregion

        #region events

        private void txtValue_Enter(object sender, EventArgs e)
        {
            if (!IsUpdated)
            {
                _savedValue = ParameterValue;
            }
        }

        #endregion
    }
}
