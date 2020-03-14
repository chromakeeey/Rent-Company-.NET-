using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRC_Redesign.InputBoxes
{
    public static class ComboBoxGet
    {
        public static string Show(string message, List<string> collection)
        {
            string value;

            using (InputComboBox inputComboBox = new InputComboBox())
            {
                inputComboBox.Message = message;
                inputComboBox.cb_value.Items.AddRange(collection.ToArray());

                inputComboBox.ShowDialog();
                value = inputComboBox.cb_value.Text;
            }

            return value;
        }
    }
}
