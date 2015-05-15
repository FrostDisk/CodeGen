using System;
using System.Runtime.Serialization;

namespace CodeGen.Library.Formats
{
    /// <summary>
    /// NotSupportedTemplateTypeException
    /// </summary>
    [Serializable]
    public class NotSupportedTemplateTypeException : Exception
    {
        private const string _exceptionMessageFormat = "Section type {0} is not supported yet";

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSupportedTemplateTypeException"/> class.
        /// </summary>
        /// <param name="sectionType">Type of the section.</param>
        public NotSupportedTemplateTypeException(TemplateType sectionType)
            : base(string.Format(_exceptionMessageFormat, sectionType.ToString("F")))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSupportedTemplateTypeException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
        ///   
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
        protected NotSupportedTemplateTypeException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
