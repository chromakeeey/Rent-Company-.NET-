using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Web.Hosting;

namespace WCF_Rent.Providers
{
    public enum LogStyle
    {
        Error = 0,
        Warning = 1,
        Information = 2
    }

    public static class Log
    {
        public static string AppPath;


        private static string StringError(LogStyle style)
        {
            if (style == LogStyle.Error)
                return "Error";

            if (style == LogStyle.Information)
                return "Information";

            if (style == LogStyle.Warning)
                return "Warning";

            return "null";
        }

        public static void Add(LogStyle style, string message)
        {
            if (!File.Exists(AppPath + "\\operationlog.txt"))
                CreateLog();

            using (StreamWriter streamWriter = new StreamWriter(AppPath + "\\operationlog.txt", true, System.Text.Encoding.Default))
            {
                string input = String.Format("[{0}] {1}: {2}",
                    StringError(style),
                    DateTime.Now,
                    message
                );

                streamWriter.WriteLine(input);
            }
        }

        private static void CreateLog()
        {
            using (FileStream fileStream = File.Create(AppPath + "\\operationlog.txt"))
            {
                string input = String.Format("[{0}] {1}: {2}\n",
                    StringError(LogStyle.Information),
                    DateTime.Now,
                    "File log created"
                );

                byte[] info = new UTF8Encoding(true).GetBytes(input);
                fileStream.Write(info, 0, info.Length);
            }
        }
    }
}
