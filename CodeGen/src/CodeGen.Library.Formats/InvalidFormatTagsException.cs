using System;
using System.Runtime.Serialization;

namespace CodeGen.Library.Formats
{
    /// <summary>
    /// InvalidFormatTagsException
    /// </summary>
    [Serializable]
    public class InvalidFormatTagsException : Exception
    {
        private const string _exceptionMessageFormat = "Section {0} has invalid tags formats";

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidFormatTagsException"/> class.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        public InvalidFormatTagsException(string sectionName)
            : base(string.Format(_exceptionMessageFormat, sectionName))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidFormatTagsException"/> class.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="inner">The inner.</param>
        public InvalidFormatTagsException(string sectionName, Exception inner)
            : base(string.Format(_exceptionMessageFormat, sectionName), inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidFormatTagsException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
        ///   
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
        protected InvalidFormatTagsException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
