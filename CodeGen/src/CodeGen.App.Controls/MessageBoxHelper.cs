using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGen.App.Controls
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
    }
}
