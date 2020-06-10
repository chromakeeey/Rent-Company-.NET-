using ClientVehicle.Dialogs.CustomDefaultDialog;
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

namespace ClientVehicle.Dialogs.DialogsStatistic
{
    /// <summary>
    /// Логика взаимодействия для DialogCustomDate.xaml
    /// </summary>
    public partial class DialogCustomDate : Window
    {
        public DialogResult Result;

        public DialogCustomDate()
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
            Result = CustomDefaultDialog.DialogResult.No;
            Hide();
        }

        private void onClickPick(object sender, RoutedEventArgs e)
        {
            Result = CustomDefaultDialog.DialogResult.Ok;
            Hide();
        }
    }
}
