using System;
using System.Windows.Forms;

namespace CodeGen.Utils
{
    /// <summary>
    /// MessageBoxHelper
    /// </summary>
    public static class MessageBoxHelper
    {
        /// <summary>
        /// ValidationMessage
        /// </summary>
        /// <param name="message"></param>
        /// <param name="subject"></param>
        public static void ValidationMessage(string message, string subject = "Validation")
        {
            MessageBox.Show(message, subject, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// ValidationQuestion
        /// </summary>
        /// <param name="question"></param>
        /// <param name="subject"></param>
        /// <returns></returns>
        public static bool ValidationQuestion(string question, string subject = "Question")
        {
            return MessageBox.Show(question, subject, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>
        /// ProcessException
        /// </summary>
        /// <param name="ex"></param>
        public static void ProcessException(Exception ex)
        {
#if DEBUG
            MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

        }

        /// <summary>
        /// ShowGeneratedFileMessage
        /// </summary>
        /// <param name="fileName"></param>
        public static void ShowGeneratedFileMessage(string fileName)
        {
            MessageBox.Show("File saved on location: " + fileName, "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
