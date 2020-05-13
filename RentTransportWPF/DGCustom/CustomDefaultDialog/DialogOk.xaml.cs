﻿using System;
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

namespace RentTransportWPF.DGCustom.CustomDefaultDialog
{
    /// <summary>
    /// Interaction logic for DialogOk.xaml
    /// </summary>
    public partial class DialogOk : Window
    {
        public DialogResult result { get; private set; }

        public DialogOk()
        {
            InitializeComponent();
        }

        public void setDialogData(string message, string caption, DialogStyle style)
        {
            Message.Text = message;
            Caption.Text = caption;

            switch (style)
            {
                case DialogStyle.Error:
                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CloseOutline;
                    break;

                case DialogStyle.Information:
                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.InformationCircleOutline;
                    break;

                case DialogStyle.Warning:
                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WarningCircleOutline;
                    break;
            }
        }

        private void onOkClick(object sender, RoutedEventArgs e)
        {
            result = RentTransportWPF.DGCustom.CustomDefaultDialog.DialogResult.Ok;
            Hide();
        }
    }
}