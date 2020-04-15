using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Media;


using TRC_Redesign.ServiceRent;
using TRC_Redesign.CashChecks;


namespace TRC_Redesign.header
{
    public class ClientData
    {
        public Form1 mainWindow;
        public UI ui = new UI();
        public Account account;
        public CheckData checkData = new CheckData();

        // Forms
        public VehicleInfo vehicleinfo = new VehicleInfo();
        public login Login = new login();
        public CheckStartRent checkStartRent = new CheckStartRent();

        private string applogPath = AppDomain.CurrentDomain.BaseDirectory + @"\applog.txt";
        private string notificationPath = AppDomain.CurrentDomain.BaseDirectory + @"sounds\notification.mp3";

        public void addTxtLog(string message)
        {
            if ( !File.Exists(applogPath) )
                createTxtLog();

            using (StreamWriter streamWriter = new StreamWriter(applogPath, true, System.Text.Encoding.Default))
            {
                string input = String.Format("\n[{0}] {1}", DateTime.Now.ToString(), message);
                streamWriter.WriteLine(input);
            }
        }

        private void createTxtLog()
        {
            using (FileStream fileStream = File.Create(applogPath))
            {
                string input = String.Format("[{0}] {1}", DateTime.Now.ToString(), "Log file created");
                byte[] info = new UTF8Encoding(true).GetBytes(input);

                fileStream.Write(info, 0, info.Length);
            }
        }

        public void showPanelMessage(string message)
        {
            int tick = 0;
            Timer timer = new Timer();

            mainWindow.lbl_message.Text = message;
            mainWindow.panel_message.Visible = true;

            timer.Tick += new EventHandler((sender, e) =>
            {
                tick++;

                if (tick > 5)
                {
                    mainWindow.panel_message.Visible = false;
                    timer.Stop();
                }
            });

            timer.Interval = 700;
            timer.Start();
        }
    }
}
