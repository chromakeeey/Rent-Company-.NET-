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

using System.Windows.Forms;
using System.IO;

using ClientVehicle.ServerReference;
using ClientVehicle.Header;
using ClientVehicle.Dialogs.CustomDefaultDialog;

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    /// <summary>
    /// Interaction logic for DialogAddVehicle.xaml
    /// </summary>
    public partial class DialogAddVehicle : Window
    {

        private byte[] ImageBytes = null;
        private string Extenstion = null;

        private string Error
        {
            get { return label_Error.Text; }

            set { label_Error.Text = value; }
        }
        

        public DialogAddVehicle()
        {
            InitializeComponent();
            Error = " ";
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void onClickClose(object sender, MouseButtonEventArgs e)
        {
            Hide();
        }

        private void onAddClick(object sender, RoutedEventArgs e)
        {
            Error = " ";

            if (string.IsNullOrEmpty(field_VIN.Text))
            {
                Error = "Ви не заповнили пункт 'VIN'";
                return;
            }

            if (string.IsNullOrEmpty(field_Name.Text))
            {
                Error = "Ви не заповнили пункт 'Назва транспорта'";
                return;
            }

            if (string.IsNullOrEmpty(field_Model.Text))
            {
                Error = "Ви не заповнили пункт 'Модель транспорта'";
                return;
            }

            if (string.IsNullOrEmpty(field_Mileage.Text))
            {
                Error = "Ви не заповнили пункт 'Пробіг'";
                return;
            }

            if (string.IsNullOrEmpty(field_MaxSpeed.Text))
            {
                Error = "Ви не заповнили пункт 'Максимальна швидкість'";
                return;
            }

            if (string.IsNullOrEmpty(field_MaxFuel.Text))
            {
                Error = "Ви не заповнили пункт 'Об'єм бака'";
                return;
            }

            if (string.IsNullOrEmpty(field_Fuel.Text))
            {
                Error = "Ви не заповнили пункт 'Бензина в баці'";
                return;
            }

            if (string.IsNullOrEmpty(field_Plate.Text))
            {
                Error = "Ви не заповнили пункт 'Номерний знак'";
                return;
            }

            if (string.IsNullOrEmpty(field_Price.Text))
            {
                Error = "Ви не заповнили пункт 'Ціна'";
                return;
            }

            if (string.IsNullOrEmpty(combo_Type.Text))
            {
                Error = "Ви не заповнили пункт 'Тип автомобіля'";
                return;
            }

            if (string.IsNullOrEmpty(combo_Transmission.Text))
            {
                Error = "Ви не заповнили пункт 'Трансмісія'";
                return;
            }

            if (string.IsNullOrEmpty(combo_Category.Text))
            {
                Error = "Ви не заповнили пункт 'Категорія прав'";
                return;
            }

            if (Client.Server.ConnectProvider.IsVehicleValid(field_VIN.Text))
            {
                Error = $"Автомобіль з VIN '{field_VIN.Text}' вже існує";
                return;
            }

            if (!int.TryParse(field_Mileage.Text, out _))
            {
                Error = "Пробіг був введений неправильно.";
                return;
            }

            if (!int.TryParse(field_MaxSpeed.Text, out _))
            {
                Error = "Максимальна швидкість була введена неправильно.";
                return;
            }

            if (!float.TryParse(field_MaxFuel.Text, out _))
            {
                Error = "Об'єм бака була введена неправильно.";
                return;
            }

            if (!float.TryParse(field_Fuel.Text, out _))
            {
                Error = "Кількість бензина в баці була введена неправильно.";
                return;
            }

            if (!float.TryParse(field_Price.Text, out _))
            {
                Error = "Ціна була введена неправильно.";
                return;
            }

            if (ImageBytes == null)
            {
                Error = "Ви не вибрали зображення.";
                return;
            }

            Vehicle item = new Vehicle();

            item.VIN = field_VIN.Text;
            item.Name = field_Name.Text;
            item.Model = field_Model.Text;
            item.Mileage = float.Parse(field_Mileage.Text);
            item.MaxSpeed = int.Parse(field_MaxSpeed.Text);
            item.MaxFuel = float.Parse(field_MaxFuel.Text);
            item.Fuel = float.Parse(field_Fuel.Text);
            item.Plate = field_Plate.Text;
            item.Price = float.Parse(field_Price.Text);
            item.Type = combo_Type.Text;
            item.Transmission = combo_Transmission.Text;
            item.Category = combo_Category.Text;

            item.PicturePath = $"{item.VIN}{Extenstion}";

            item.StartDate = DateTime.Now;
            item.FinalDate = DateTime.Now;

            Client.Server.ConnectProvider.uploadVehicleImage(ImageBytes, item.VIN, Extenstion);
            Client.Server.ConnectProvider.addVehicle(item);

            Hide();
        }

        private void onAddImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageBytes = File.ReadAllBytes(Dialog.FileName);
                Extenstion = System.IO.Path.GetExtension(Dialog.FileName);

                image_Vehicle.Source = Server.BytesToBitmapImage(ImageBytes);
            }
        }
    }
}
