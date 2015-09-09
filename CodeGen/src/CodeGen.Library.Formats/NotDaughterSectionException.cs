using System;
using System.Runtime.Serialization;

namespace CodeGen.Library.Formats
{
    /// <summary>
    /// NotDaughterSectionException
    /// </summary>
    [Serializable]
    public class NotDaughterSectionException : Exception
    {
        private const string _exceptionMessageFormat = "Section {0} isn't daughter of section {1}";

        /// <summary>
        /// Initializes a new instance of the <see cref="NotDaughterSectionException"/> class.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="parentSectionName">Name of the parent section.</param>
        public NotDaughterSectionException(string sectionName, string parentSectionName)
            : base(string.Format(_exceptionMessageFormat, sectionName, parentSectionName))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotDaughterSectionException"/> class.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="parentSectionName">Name of the parent section.</param>
        /// <param name="inner">The inner.</param>
        public NotDaughterSectionException(string sectionName, string parentSectionName, Exception inner)
            : base(string.Format(_exceptionMessageFormat, sectionName, parentSectionName), inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotDaughterSectionException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
        ///   
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
        protected NotDaughterSectionException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
