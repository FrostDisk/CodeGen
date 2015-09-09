using System;
using System.Windows.Forms;

namespace CodeGen.Utils
{
    internal static class MessageBoxHelper
    {
        public static void ValidationMessage(string message, string subject = "Validation")
        {
            MessageBox.Show(message, subject, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ValidationQuestion(string question, string subject = "Question")
        {
            return MessageBox.Show(question, subject, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void ProcessException(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
