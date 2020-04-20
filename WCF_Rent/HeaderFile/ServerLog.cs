using System;
using System.Text;
using System.IO;

namespace WCF_Rent.HeaderFile
{
    public static class ServerLog
    {
        //const string fullpath = localPath() + "log.txt";

        public const string ERROR_TYPE = "ERROR";
        public const string WARNING_TYPE = "WARNING";
        public const string NOTIFICATION_TYPE = "NOTIFICATION";

        private static string localPath()
        {
            string localpath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            int endpos = localpath.Length;
            int startpos = 0;

            for (int i = localpath.Length - 1; i > -1; i--)
            {
                if (localpath[i] == 'W')
                {
                    startpos = i;

                    break;
                }
            }

            //localpath.Remove(startpos, endpos - startpos);

            return localpath.Remove(startpos, endpos - startpos);
        }

        private static void fileLogCreate()
        {
            using (FileStream fileStream = File.Create(localPath() + "log.txt"))
            {
                string input = String.Format("\n[{0}] [{1}] {2}", NOTIFICATION_TYPE, DateTime.Now.ToString(), "Server log file created");
                byte[] info = new UTF8Encoding(true).GetBytes(input);

                fileStream.Write(info, 0, info.Length);
            }
        }

        public static void logAdd(string type, string message)
        {
            if (!File.Exists(localPath() + "log.txt"))
                fileLogCreate();

            using (StreamWriter streamWriter = new StreamWriter(localPath() + "log.txt", true, System.Text.Encoding.Default))
            {
                string input = String.Format("[{0}] [{1}] {2}", type, DateTime.Now.ToString(), message);
                streamWriter.WriteLine(input);
            }
        }

    }
}
