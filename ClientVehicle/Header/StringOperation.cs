using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientVehicle.Header
{
    public static class StringOperation
    {
        public static bool IsValidMail(string value)
        {
            bool MainChar = false;
            int IndexChar = -1;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != '@')
                    continue;

                IndexChar = i;
                MainChar = true;

                break;
            }

            if (!MainChar)
                return false;

            bool DotChar = false;

            for (int i = IndexChar; i < value.Length; i++)
            {
                if (value[i] != '.')
                    continue;

                DotChar = true;
                break;
            }

            return DotChar;
        }

        public static bool IsOnlyDigit(string value)
        {
            foreach (char i in value)
            {
                if (i < '0' || i > '9')
                    return false;
            }

            return true;
        }

        public static bool IsValidPhone(string value)
        {
            if (value.Length != 13)
                return false;

            if (value[0] != '+')
                return false;

            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] < '0' || value[i] > '9')
                    return false;
            }

            return true;
        }
        
        public static string Random(int Length)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, Length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
