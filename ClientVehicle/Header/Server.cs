using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;

using System.Windows.Media.Imaging;
using ClientVehicle.ServerReference;
using ClientVehicle.Dialogs.DialogsVehicle;
using ClientVehicle.Dialogs.DialogsUser;
using System.Windows.Threading;

namespace ClientVehicle.Header
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public class Server : IServiceRentCallback
    {
        public ServiceRentClient ConnectProvider { get; private set; }

        public bool ConnectStatus { get; private set; }

        public int ClientId { get; private set; }

        public void InitializeConnection()
        {
            try
            {
                ConnectProvider = new ServiceRentClient(new System.ServiceModel.InstanceContext(this));
                ClientId = ConnectProvider.userConnect();
                ConnectStatus = true;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Під'єднання до сервера неможливе. Сталась помилка (немає інтернету або сервер недоступний)");
                Client.ApplicationShutdown();
            }
        }

        public void userDisconnect()
        {
            if (ConnectStatus)
            {
                ConnectProvider.userDisconnect(ClientId);
                ConnectProvider = null;
                ConnectStatus = false;
            }
        }

        public static BitmapImage BytesToBitmapImage(byte[] stream)
        {
            var image = new BitmapImage();

            using (var memory = new MemoryStream(stream))
            {
                memory.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = memory;
                image.EndInit();
            }

            image.Freeze();
            return image;
        }

        public void OnUserEdit(User Item, User[] numerable)
        {
            Action a = () =>
            {
                if (Client.IsLogin())
                {
                    List<User> sortedApplication = (from i in numerable where i.Status != 0 && i.Status != 3 select i).ToList();
                    Items.UpdateAUser(Items.ucAUser.SearchAsLogin(sortedApplication));
                    Items.UpdateAUserHeader(numerable.ToList());

                    if (ApplicationUser.Dialog.Item.Id == Item.Id && ApplicationUser.Dialog.Visibility == System.Windows.Visibility.Visible)
                    {
                        ApplicationUser.Dialog.Hide();
                    }

                    if (UserACard.Card.User.Id == Item.Id && UserACard.Card.Visibility == System.Windows.Visibility.Visible)
                    {
                        UserACard.Card.User = Item;
                    }

                    if (Client.User.Id == Item.Id)
                    {

                        Items.UpdateMainPage();
                    }
                }
            };
            System.Windows.Application.Current.Dispatcher.BeginInvoke(a);
        }

        public void OnUserAdd(User Item, User[] numerable)
        {
            Action a = () =>
            {
                if (Client.IsLogin())
                {
                    List<User> sortedApplication = (from i in numerable where i.Status != 0 && i.Status != 3 select i).ToList();
                    Items.UpdateAUser(Items.ucAUser.SearchAsLogin(sortedApplication));
                    Items.UpdateAUserHeader(numerable.ToList());
                }
            };
            System.Windows.Application.Current.Dispatcher.BeginInvoke(a);
        }

        public void OnUserDelete(User Item, User[] numerable)
        {
            Action a = () =>
            {
                if (Client.IsLogin())
                {
                    List<User> sortedApplication = (from i in numerable where i.Status != 0 && i.Status != 3 select i).ToList();
                    Items.UpdateAUser(Items.ucAUser.SearchAsLogin(sortedApplication));
                    Items.UpdateAUserHeader(numerable.ToList());

                    if (ApplicationUser.Dialog.Item.Id == Item.Id && ApplicationUser.Dialog.Visibility == System.Windows.Visibility.Visible)
                    {
                        ApplicationUser.Dialog.Hide();
                    }

                    if (UserACard.Card.User.Id == Item.Id && UserACard.Card.Visibility == System.Windows.Visibility.Visible)
                    {
                        UserACard.Card.Hide();
                    }
                }
            };
            System.Windows.Application.Current.Dispatcher.BeginInvoke(a);
        }

        public void OnEditVehicle(Vehicle item, Vehicle[] numerable)
        {
            Action a = () =>
            {
                if (Client.IsLogin())
                {
                    SearchVehicle.ComplectSearchObject(numerable.ToList());
                    Items.UpdateAVehicle(SearchVehicle.GetItemSearched());
                    Items.UpdateAVehicleHeader(SearchVehicle.GetItemSearched());
                    Items.UpdateVehicle(SearchVehicle.GetItemSearched());

                    if (VehicleEdit.Dialog.Item.VIN == item.VIN && VehicleEdit.Dialog.Visibility == System.Windows.Visibility.Visible)
                    {
                        VehicleEdit.Dialog.Item = item;
                    }

                    if (Client.Vehicle.VIN == item.VIN)
                    {
                        Items.UpdateMainPage();
                    }

                    if (Items.ucVehicle.VehicleGrid.Visibility == System.Windows.Visibility.Visible && Items.ucVehicle.Vehicle.VIN == item.VIN)
                    {
                        Items.ucVehicle.Vehicle = item;
                        //Items.UpdateVehicleActive(item);
                    }
                }
            };
            System.Windows.Application.Current.Dispatcher.BeginInvoke(a);

            
        }

        public void OnAddVehicle(Vehicle item, Vehicle[] numerable)
        {
            Action a = () =>
            {
                if (Client.IsLogin())
                {
                    SearchVehicle.ComplectSearchObject(numerable.ToList());
                    Items.UpdateAVehicle(SearchVehicle.GetItemSearched());
                    Items.UpdateAVehicleHeader(SearchVehicle.GetItemSearched());
                    Items.UpdateVehicle(SearchVehicle.GetItemSearched());
                }
            };
            System.Windows.Application.Current.Dispatcher.BeginInvoke(a);
        }

        public void OnDeleteVehicle(Vehicle item, Vehicle[] numerable)
        {
            Action a = () =>
            {
                if (Client.IsLogin())
                {
                    SearchVehicle.ComplectSearchObject(numerable.ToList());
                    Items.UpdateAVehicle(SearchVehicle.GetItemSearched());
                    Items.UpdateAVehicleHeader(SearchVehicle.GetItemSearched());
                    Items.UpdateVehicle(SearchVehicle.GetItemSearched());
                }

                if (VehicleEdit.Dialog.Item.VIN == item.VIN && VehicleEdit.Dialog.Visibility == System.Windows.Visibility.Visible)
                {
                    VehicleEdit.Dialog.Hide();
                }

                if (Client.Vehicle.VIN == item.VIN)
                {
                    Items.UpdateMainPage();
                }

                if (Items.ucVehicle.VehicleGrid.Visibility == System.Windows.Visibility.Visible && Items.ucVehicle.Vehicle.VIN == item.VIN)
                {
                    Items.ucVehicle.VehicleGrid.Visibility = System.Windows.Visibility.Hidden;
                    Items.ucVehicle.Vehicle.VIN = "null";
                }
            };
            System.Windows.Application.Current.Dispatcher.BeginInvoke(a);
        }
    }
}
