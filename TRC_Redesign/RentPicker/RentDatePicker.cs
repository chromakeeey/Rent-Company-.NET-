using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRC_Redesign.RentPicker
{
    public static class RentDatePicker
    {
        public static DateTime Show(string message, string caption, DateTime minDay, DateTime maxDay)
        {
            DateTime date;

            using (RentTimePicker rentDatePicker = new RentTimePicker())
            {
                rentDatePicker.Message = message;
                rentDatePicker.Caption = caption;

                rentDatePicker.dateTimePicker1.MinDate = minDay;
                rentDatePicker.dateTimePicker1.MaxDate = maxDay;

                rentDatePicker.ShowDialog();
                date = rentDatePicker.dateTimePicker1.Value;
            }

            return date;
        }
    }
}
