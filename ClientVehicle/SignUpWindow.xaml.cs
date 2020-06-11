using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;

using ClientVehicle.Header;
using ClientVehicle.ServerReference;
using ClientVehicle.Dialogs.CustomDefaultDialog;

namespace ClientVehicle
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        private byte[] FrontImageBytes = null;
        private byte[] BackImageBytes = null;

        private string ExtenstionFront = null;
        private string ExtenstionBack = null;

        public SignUpWindow()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private string Error
        {
            get { return label_Error.Text; }
            set { label_Error.Text = value; }
        }

        private void onClickReturn(object sender, MouseButtonEventArgs e)
        {
            Hide();
            Items.loginWindow.Show();
        }

        private void onRegistrerClick(object sender, RoutedEventArgs e)
        {
            Error = " ";

            if (string.IsNullOrEmpty(field_Login.Text))
            {
                Error = "Поле 'Логін' не заповнено.";
                return;
            }

            if (string.IsNullOrEmpty(field_Password.Text))
            {
                Error = "Поле 'Пароль' не заповнено.";
                return;
            }

            if (string.IsNullOrEmpty(field_Mail.Text))
            {
                Error = "Поле 'Пошта' не заповнено.";
                return;
            }

            if (string.IsNullOrEmpty(field_Number.Text))
            {
                Error = "Поле 'Номер телефона' не заповнено.";
                return;
            }

            if (field_Login.Text.Length < 3 || field_Login.Text.Length > 16)
            {
                Error = "Розмір логіна має бути від 3 до 16 символів.";
                return;
            }

            if (field_Password.Text.Length < 6 || field_Password.Text.Length > 32)
            {
                Error = "Розмір пароля має бути від 6 до 32 символів.";
                return;
            }

            if (!StringOperation.IsValidMail(field_Mail.Text))
            {
                Error = "Пошта була введена неправильно.";
                return;
            }

            if (!StringOperation.IsValidPhone(field_Number.Text))
            {
                Error = "Телефон був введений неправильно.";
                return;
            }

            if (FrontImageBytes == null)
            {
                Error = "Передня сторона фотографії прав не завантажена.";
                return;
            }

            if (BackImageBytes == null)
            {
                Error = "Передня сторона фотографії прав не завантажена.";
                return;
            }

            string NameFront = StringOperation.Random(16);
            string NameBack = StringOperation.Random(16);

            User item = new User();

            item.Name = "null";
            item.Surname = "null";
            item.LicenseCategories = new string[1] { "null" };

            item.CardNumber = "null";
            item.ExpireDate = "null";
            item.CVV = 0;
            item.OwnerName = "null";

            item.Login = field_Login.Text;
            item.Password = field_Password.Text;
            item.Mail = field_Mail.Text;
            item.Phone = field_Number.Text;
            item.Status = 0;
            item.StatusReason = "Аккаунт був зареєстрований. Очікуйте кінця перевірки адміністратором.";
            item.UserCreateDate = DateTime.Now;
            item.BirthdayDate = DateTime.Now;

            item.FrontImageName = NameFront + ExtenstionFront;
            item.BackImageName = NameBack + ExtenstionBack;

            Client.Server.ConnectProvider.SaveFrontImage(FrontImageBytes, NameFront, ExtenstionFront);
            Client.Server.ConnectProvider.SaveBackImage(BackImageBytes, NameBack, ExtenstionBack);
            Client.Server.ConnectProvider.AddUser(item);

            DialogWindow.Show("Ви успішно зареєстрували аккаунт, очікуйте перевірки", "Успішно", DialogButtons.Ok, DialogStyle.Information, false);

            Items.signUpWindow.Hide();
            Items.loginWindow.Show();
        }

        private void onClickFrontImage(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FrontImageBytes = File.ReadAllBytes(Dialog.FileName);
                ExtenstionFront = System.IO.Path.GetExtension(Dialog.FileName);

                frontDocumentImage.Source = Server.BytesToBitmapImage(FrontImageBytes);
                icon_Front.Visibility = Visibility.Hidden;
            }
        }

        private void onClickBackImage(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BackImageBytes = File.ReadAllBytes(Dialog.FileName);
                ExtenstionBack = System.IO.Path.GetExtension(Dialog.FileName);

                backDocumentImage.Source = Server.BytesToBitmapImage(BackImageBytes);
                icon_Back.Visibility = Visibility.Hidden;
            }
        }
    }
}
