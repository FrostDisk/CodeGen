using System;
using System.Runtime.Serialization;

namespace CodeGen.Library.Formats
{
    /// <summary>
    /// SectionNotFoundException
    /// </summary>
    [Serializable]
    public class SectionNotFoundException : Exception
    {
        private const string _exceptionMessageFormat = "Section {0} does not contain a daughter section named {1}";

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionNotFoundException"/> class.
        /// </summary>
        /// <param name="parentSectionName">Name of the parent section.</param>
        /// <param name="sectionName">Name of the section.</param>
        public SectionNotFoundException(string parentSectionName, string sectionName)
            : base(string.Format(_exceptionMessageFormat, parentSectionName, sectionName))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionNotFoundException"/> class.
        /// </summary>
        /// <param name="parentSectionName">Name of the parent section.</param>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="inner">The inner.</param>
        public SectionNotFoundException(string parentSectionName, string sectionName, Exception inner)
            : base(string.Format(_exceptionMessageFormat, parentSectionName, sectionName), inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionNotFoundException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
        ///   
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
        protected SectionNotFoundException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
