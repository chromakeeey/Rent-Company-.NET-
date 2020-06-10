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
    /// Interaction logic for FailSignIn.xaml
    /// </summary>
    public partial class FailSignIn : Window
    {
        public FailSignIn()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void onOkayClick(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
