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

namespace ClientVehicle.Dialogs.DialogsUser
{
    /// <summary>
    /// Interaction logic for UserCardAdmin.xaml
    /// </summary>
    public partial class UserCardAdmin : Window
    {
        public UserCardAdmin()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
        }
    }
}
