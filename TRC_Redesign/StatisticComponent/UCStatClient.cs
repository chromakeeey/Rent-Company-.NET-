using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign.StatisticComponent
{
    public partial class UCStatClient : UserControl
    {
        public Form1 mainWindow;
        private List<UCClientInfo> ucClients = new List<UCClientInfo>();

        public Account[] account;
        public int length = 0;
        private int yCoord = 0;
        private int top = 1;

        public void updateTop()
        {
            yCoord = 0;
            top = 1;

            foreach(var item in ucClients) { item.Visible = false; }
            ucClients.Clear();

            for (int i = length - 1; i != -1; i--)
            {
                ucClients.Add(new UCClientInfo());
                int index = ucClients.Count - 1;

                ucClients[i].setAccount(account[i], top);
                ucClients[i].Location = new Point(47, yCoord);
                ucClients[i].Visible = true;

                yCoord += 70;
                top++;
            }
        }

        public void updateAccounts()
        {
            account = mainWindow.serverData.client.topAccountMoney();
            length = account.Length;
        }

        public UCStatClient()
        {
            InitializeComponent();

        }
    }
}
