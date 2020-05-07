using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentTransportWPF.HeaderFile
{
    public class ClientData
    {
        public UiOperation uiOperation { get; set; }

        public ClientData(WindowMain mainWindow)
        {
            uiOperation = new UiOperation(mainWindow);
        }
    }
}
