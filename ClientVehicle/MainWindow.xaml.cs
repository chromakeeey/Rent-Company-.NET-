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

using ClientVehicle.Header;
using ClientVehicle.Dialogs.CustomDefaultDialog;

namespace ClientVehicle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }


        private void onMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed == e.LeftButton)
                DragMove();

            //DragMove();
        }

        private void mainMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed == e.LeftButton)
                UiOperation.SetPage(UIPage.Main);
        }

        private void vehicleMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed == e.LeftButton)
                UiOperation.SetPage(UIPage.Vehicle);
        }

        private void aVehicleMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed == e.LeftButton)
                UiOperation.SetPage(UIPage.AVehicle);
        }

        private void aUserMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed == e.LeftButton)
                UiOperation.SetPage(UIPage.AUser);
        }

        private void statMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MouseButtonState.Pressed == e.LeftButton)
                UiOperation.SetPage(UIPage.Statistic);
        }

        private void onResizeClick(object sender, MouseButtonEventArgs e)
        {
            switch (WindowState)
            {
                case (WindowState.Maximized):
                    ResizeMode = ResizeMode.CanResize;
                    WindowState = WindowState.Normal;
                    break;

                case (WindowState.Normal):
                    ResizeMode = ResizeMode.NoResize;
                    WindowState = WindowState.Maximized;
                    break;
            }
        }
    }
}
