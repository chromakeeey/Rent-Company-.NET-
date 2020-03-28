using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.ServiceModel;

using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;


namespace TRC_Redesign.header
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public class ServerData : IServiceRentCallback
    {
        public Form1 mainWindow;
        public bool is_connected = false;
        public ServiceRentClient client;
        public int client_id;

        public void onDeleteVehicle(Vehicle vehicleObject)
        {
            if (mainWindow.vehicleInfo.Visible)
            {
                if (vehicleObject.plate == mainWindow.vehicleInfo.vehicle.plate)
                {
                    mainWindow.Invoke((MethodInvoker)delegate
                    {
                        mainWindow.vehicleInfo.Hide();

                        mainWindow.vehicleInfo.createDialog("Автомобіль який ви переглядаєте був видалений адміністратором.",
                            "Видалення автомобіля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
            }

            if (!mainWindow.admin_page1.vehicleEdit.pnl_empty.Visible)
            {
                if (mainWindow.admin_page1.vehicleEdit.vehicle.plate == vehicleObject.plate)
                {
                    mainWindow.Invoke((MethodInvoker)delegate
                    {
                        mainWindow.admin_page1.vehicleEdit.pnl_empty.Visible = true;
                        mainWindow.clientData.showPanelMessage("Автомобіль, який Ви редагували був видалений.");
                    });

                    //mainWindow.admin_page1.vehicleEdit.infoHide();
                    //mainWindow.clientData.showPanelMessage("Автомобіль, який Ви редагували був видалений.");
                }
            }
        }

        public void onSaveVehicle(Vehicle vehicleObject)
        {
            if (mainWindow.vehicleInfo.Visible)
            {
                if (vehicleObject.plate == mainWindow.vehicleInfo.vehicle.plate)
                {
                    if (vehicleObject.clientid == mainWindow.clientData.account.id)
                        return;

                    mainWindow.Invoke((MethodInvoker)delegate
                    {
                        mainWindow.vehicleInfo.setVehicle(vehicleObject);

                        mainWindow.vehicleInfo.createDialog("Автомобіль який ви переглядаєте був змінений. Інформація оновлена.",
                            "Зміна інформації автомобіля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
            }

            if (mainWindow.admin_page1.vehicleEdit.pnl_empty.Visible)
            {
                if (mainWindow.admin_page1.vehicleEdit.vehicle.plate == vehicleObject.plate)
                {
                    mainWindow.Invoke((MethodInvoker)delegate
                    {
                        mainWindow.admin_page1.vehicleEdit.pnl_empty.Visible = true;
                        mainWindow.clientData.showPanelMessage("Автомобіль, який Ви редагували був змінений.");
                    });

                    //mainWindow.admin_page1.vehicleEdit.infoHide();
                    //mainWindow.clientData.showPanelMessage("Автомобіль, який Ви редагували був змінений.");
                }
            }
        }

        public void uploadImage(string path, Vehicle vehicleObject)
        {
            string name = vehicleObject.plate;
            string extenstion = Path.GetExtension(path);
            byte[] buffer = File.ReadAllBytes(path);

            client.uploadVehicleImage(buffer, name, extenstion);
        }

        public void connect()
        {
            client = new ServiceRentClient(new System.ServiceModel.InstanceContext(this));
            client_id = client.userConnect();
            is_connected = true;
        }
        public void disconnect()
        {
            if (is_connected)
            {
                client.userDisconnect(client_id);
                client = null;
                is_connected = false;
            }
        }

        public void sendNotification(string message)
        {
            mainWindow.clientData.showPanelMessage(message);
        }

        /*public void uploadImage(Image path)
        {
            File file = new File();

            file.Content = System.IO.File.ReadAllBytes(path);
            file.Name = System.IO.Path.GetFileName(path);

            client.uploadVehicleImage(file);
        }*/


    }
}
