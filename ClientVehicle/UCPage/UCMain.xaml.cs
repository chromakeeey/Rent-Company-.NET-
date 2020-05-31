using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ClientVehicle.Dialogs.CustomDefaultDialog;
using ClientVehicle.Dialogs.DialogsVehicle;
using ClientVehicle.Dialogs.DialogsUser;
using ClientVehicle.Dialogs.Receipts;
using ClientVehicle.Header;

namespace ClientVehicle.UCPage
{
    /// <summary>
    /// Interaction logic for UCMain.xaml
    /// </summary>
    public partial class UCMain : UserControl
    {
         

        public UCMain()
        {
            InitializeComponent();
        }


        private void onCancelRent(object sender, RoutedEventArgs e)
        {
            //DialogWindow.Show("Ви дійсно хочите відмінити оренду?", "Відміна оренди", DialogButtons.OkNo, DialogStyle.Information);

            int Days = (DateTime.Now - Client.Vehicle.FinalDate).Days;

            if (Days < 1)
            {
                int CheckDays = (Client.Vehicle.FinalDate - DateTime.Now).Days;

                if (CheckDays > 0)
                {
                    float price = Client.Vehicle.Price * CheckDays;

                    string message = $"Ви дійсно хочете відмінити оренду достроково?\n" +
                        $"Ви отримаєте ₴‎ {price} на рахунок.";

                    if (DialogWindow.Show(message, "Відміна оренди", DialogButtons.OkNo, DialogStyle.Information) == DialogResult.Ok)
                    {
                        Client.User.Balance += CheckDays * Client.Vehicle.Price;

                        Client.Vehicle.ClientId = 0;
                        Client.Vehicle.RentLogId = 0;

                        Client.Server.ConnectProvider.SaveUser(Client.User);
                        Client.Server.ConnectProvider.saveVehicle(Client.Vehicle);
                    }
                }
                else
                {
                    if (DialogWindow.Show("Ви дійсно хочете відмінити оренду:", "Відміна оренди", DialogButtons.OkNo, DialogStyle.Information) == DialogResult.Ok)
                    {
                        Client.Vehicle.ClientId = 0;
                        Client.Vehicle.RentLogId = 0;

                        Client.Server.ConnectProvider.saveVehicle(Client.Vehicle);
                    }
                }
            }

            if (Days > 0 && Client.User.Balance < Days * Client.Vehicle.Price)
            {
                DialogWindow.Show("Ви просрочили термін здачі автомобіля в автосалон.\n\n" +
                    "На ваш аккаунт був накладений борг в розмірі - " + Days * Client.Vehicle.Price +
                    "грн.\nДнів просрочено - " + Days + ".\nЦіна оренди в день - " + Client.Vehicle.Price + "грн.\n\nВи не зможете сдати автомобіль, поки не поповните баланс на сумму боргу.",
                    "Борг", DialogButtons.Ok, DialogStyle.Information);

                return;
            }

            if (Days > 0 && Client.User.Balance >= Days * Client.Vehicle.Price)
            {
                Client.User.Balance -= Days * Client.Vehicle.Price;

                Client.Vehicle.ClientId = 0;
                Client.Vehicle.RentLogId = 0;

                Client.Server.ConnectProvider.SaveUser(Client.User);
                Client.Server.ConnectProvider.saveVehicle(Client.Vehicle);

                float price = Days * Client.Vehicle.Price;
                string message = $"Ви сдали автомобіль з оренди. З вашого рахунку був стягнутий борг (₴‎ {price})";

                DialogWindow.Show(message, "Відміна оренди", DialogButtons.Ok, DialogStyle.Information);
            }

        }

        private void onUpdatePasswordClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(field_Password.Text))
            {
                DialogWindow.Show("Ви не заповнили поле для вводу пароля", "Помилка зміни пароля", DialogButtons.Ok, DialogStyle.Error);
                return;
            }

            if (field_Password.Text.Length < 6 || field_Password.Text.Length > 32)
            {
                DialogWindow.Show("Пароль має містити від 6 до 32 символів", "Помилка зміни пароля", DialogButtons.Ok, DialogStyle.Error);
                return;
            }

            Client.User.Password = field_Password.Text;
            Client.Server.ConnectProvider.SaveUser(Client.User);

            field_Password.Text = "";
            DialogWindow.Show("Ви успішно змінили новий пароль на " + Client.User.Password, "Помилка зміни пароля", DialogButtons.Ok, DialogStyle.Information);
        }

        private void onClickCheckDocument(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            new UserDocumentWindow(Client.User).ShowDialog();
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }

        private void onReceiptSee(object sender, RoutedEventArgs e)
        {
            int Id = Client.Server.ConnectProvider.sendCashVoucherID(Client.Vehicle.RentLogId);

            if (Id != -1)
            {
                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;

                Receipt.Show(
                    Client.Server.ConnectProvider.readCashVoucher(Id)
                );

                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
            }
            else
            {
                DialogWindow.Show("Чек недоступний.", "Помилка", DialogButtons.Ok, DialogStyle.Error);
            }
        }

        private void onClickVehiclePage(object sender, RoutedEventArgs e)
        {
            UiOperation.SetPage(UIPage.Vehicle);
        }

        private void onClickBankOperation(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            BankOperationWindow.Show();
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }
    }
}
