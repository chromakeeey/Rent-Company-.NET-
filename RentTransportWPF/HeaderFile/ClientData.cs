using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentTransportWPF.ServiceRent;

namespace RentTransportWPF.HeaderFile
{
    public class ClientData
    {
        public UiOperation uiOperation { get; set; }
        public Account Account { get; set; }

        public ClientData(WindowMain mainWindow)
        {
            uiOperation = new UiOperation(mainWindow);
        }

        public void setAccount(Account item)
        {
            Account = item;

            uiOperation.mainWindow.text_Login.Text = item.login;

            uiOperation.mainWindow.label_IsAdmin.Visibility = item.level != 0
                ? System.Windows.Visibility.Visible
                : System.Windows.Visibility.Hidden;

            uiOperation.mainWindow.text_FullName.Text = String.Format("{0} {1}",
                item.secondname, item.name);

            
        }
    }
}
