using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace ClientVehicle.Dialogs.Receipts
{
    /// <summary>
    /// Interaction logic for ReceiptWindow.xaml
    /// </summary>
    public partial class ReceiptWindow : Window
    {
        private CashVoucher receipt_;

        public CashVoucher Receipt
        {
            get { return receipt_; }

            set 
            {
                receipt_ = value;
                UpdateReceipt();
            }
        }

        public ReceiptWindow()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void UpdateReceipt()
        {
            label_Num.Text = $"Номер чека - {receipt_.Id}";
            label_NameCompany.Text = receipt_.Company;
            label_Street.Text = receipt_.Street;

            label_Name.Text = receipt_.User;
            label_Information.Text = receipt_.Vehicle;

            label_StartDate.Text = receipt_.StartDate.ToString();
            label_FinalDate.Text = receipt_.FinalDate.ToString();

            label_Price.Text = $"{receipt_.Price} грн.";
            label_Date.Text = receipt_.Date.ToString();
        }

        private void onClickSave(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog Dialog = new System.Windows.Forms.SaveFileDialog();
            Dialog.Filter = "PNG Files | *.png";
            Dialog.DefaultExt = "png";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PngBitmapEncoder Encoder = new PngBitmapEncoder();

                   RenderTargetBitmap Target = new RenderTargetBitmap(
                    391, 427, 
                    96, 96, 
                    PixelFormats.Pbgra32
                );

                Target.Render(GridReceipt);
                Encoder.Frames.Add(BitmapFrame.Create(Target));

                using (Stream FileStream = File.Create(Dialog.FileName))
                {
                    Encoder.Save(FileStream);
                }
                
            }
        }

        private void onClickHide(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
