using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign.CustomMessageBox
{
    public static class MsgBox
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon, Form1 objectForm)
        {
            DialogResult dgResult = DialogResult.None;

            switch (button)
            {
                case MessageBoxButtons.OK:
                    {
                        using (msgBoxOK messageBox = new msgBoxOK())
                        {
                            messageBox.Text = caption;
                            messageBox.Message = message;
                            messageBox.Caption = caption;
                            

                            switch (icon)
                            {
                                case MessageBoxIcon.Information: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Information; break;
                                case MessageBoxIcon.Error: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Error; break;
                                case MessageBoxIcon.Warning: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Warning; break;
                                case MessageBoxIcon.Question: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Question; break;
                            }

                            messageBox.setLocalTheme(objectForm);
                            dgResult = messageBox.ShowDialog();
                        }

                        break;
                    }

                case MessageBoxButtons.YesNo:
                    {
                        using (msgBoxYesNo messageBox = new msgBoxYesNo())
                        {
                            messageBox.Text = caption;
                            messageBox.Message = message;

                            switch (icon)
                            {
                                case MessageBoxIcon.Information: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Information; break;
                                case MessageBoxIcon.Error: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Error; break;
                                case MessageBoxIcon.Warning: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Warning; break;
                                case MessageBoxIcon.Question: messageBox.MessageIcon = TRC_Redesign.Properties.Resources.Question; break;
                            }

                            dgResult = messageBox.ShowDialog();
                        }

                        break;
                    }
            }

            return dgResult;
        }
    }
}
