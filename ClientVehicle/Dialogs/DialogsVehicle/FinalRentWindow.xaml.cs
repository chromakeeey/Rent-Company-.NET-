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
using System.Windows.Shapes;

using ClientVehicle.Dialogs.CustomDefaultDialog;
using ClientVehicle.ServerReference;

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    /// <summary>
    /// Логика взаимодействия для FinalRentWindow.xaml
    /// </summary>
    public partial class FinalRentWindow : Window
    {
        public DialogResult Result = CustomDefaultDialog.DialogResult.Cancel;
        public Vehicle Vehicle = null;

        private string Error
        {
            get { return label_Error.Text; }

            set
            {
                label_Error.Text = "";
            }
        }

        public FinalRentWindow()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void onClickHide(object sender, MouseButtonEventArgs e)
        {
            Result = CustomDefaultDialog.DialogResult.Cancel;
            Hide();
        }

        private void onClickSuccess(object sender, RoutedEventArgs e)
        {
            Error = "";

            if (string.IsNullOrEmpty(field_Fuel.Text) || string.IsNullOrEmpty(field_Mileage.Text))
            {
                Error = "Ви не заповнили всі поля.";
                return;
            }

            float Fuel,
                  Mileage;

            if (!float.TryParse(field_Fuel.Text, out Fuel))
            {
                Error = "Допущена помилка в полі 'Бензин'";
                return;
            }

            if (!float.TryParse(field_Mileage.Text, out Mileage))
            {
                Error = "Допущена помилка в полі 'Пробіг'";
                return;
            }

            if (Fuel > Vehicle.MaxFuel)
            {
                Error = $"Максимально л. бензина - {Vehicle.MaxFuel}";
                return;
            }

            if (Fuel < 0)
            {
                Error = "Мінімально л. бензина - 0";
                return;
            }

            if (Mileage < 0)
            {
                Error = "Мінімальний пробіг становить 0 км.";
                return;
            }

            Vehicle.Fuel = Fuel;
            Vehicle.Mileage = Mileage;

            Result = CustomDefaultDialog.DialogResult.Ok;
            Hide();
        }
    }
}
