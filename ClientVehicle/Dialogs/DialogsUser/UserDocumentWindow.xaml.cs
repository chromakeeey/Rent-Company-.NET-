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

using ClientVehicle.ServerReference;
using ClientVehicle.Header;

namespace ClientVehicle.Dialogs.DialogsUser
{
    /// <summary>
    /// Interaction logic for UserDocumentWindow.xaml
    /// </summary>
    public partial class UserDocumentWindow : Window
    {
        public UserDocumentWindow()
        {
            InitializeComponent();
        }

        public UserDocumentWindow(User Item)
        {
            InitializeComponent();

            image_Front.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.FrontImageBytes(Item));
            image_Back.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.BackImageBytes(Item));

            lbox_Category.Items.Clear();
            
            foreach (var i in Item.LicenseCategories)
            {
                lbox_Category.Items.Add(i);

            }

            lbox_Category.IsEnabled = false;
        }
    }
}
