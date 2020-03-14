using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRC_Redesign.InputBoxes
{
    public static class TextBoxGet
    {
        public static string Show(string message)
        {
            string value;

            using ( InputTextBox inputTextBox = new InputTextBox() )
            {
                inputTextBox.Message = message;

                inputTextBox.ShowDialog();
                value = inputTextBox.tb_value.Text;
            }

            return value;
        }
    }
}
