using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.ServerReference;
using ClientVehicle.Header;

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    public static class SearchVehicle
    {
        private static BetterSearchVehicle Dialog = new BetterSearchVehicle();
        private static List<Vehicle> itemSearched = new List<Vehicle>();

        public static void Show()
        {
            Dialog.ShowDialog();

            Vehicle[] numerableArray = Client.Server.ConnectProvider.SendAllVehicle();
            ComplectSearchObject(numerableArray.ToList());
            //return Dialog.numerableVehicle;
        }

        public static void ClearSearchFields()
        {
            Dialog.field_MinPrice.Text = "";
            Dialog.field_MaxPrice.Text = "";

            Dialog.combo_Type.Text = "";
            Dialog.combo_Transmission.Text = "";
            Dialog.combo_Category.Text = "";
            Dialog.toggle_RentStatus.IsChecked = false;
        }

        public static List<Vehicle> GetItemSearched()
        {
            return itemSearched;
        }

        public static void ComplectSearchObject(List<Vehicle> numerable)
        {
            var numerableNew = numerable;

            // min price
            if ( !string.IsNullOrEmpty(Dialog.field_MinPrice.Text) )
            {
                float value;

                if (float.TryParse(Dialog.field_MinPrice.Text, out value))
                {
                    numerableNew = (from i in numerableNew
                                    where i.Price >= value
                                    select i).ToList();
                }
            }

            // max price
            if (!string.IsNullOrEmpty(Dialog.field_MaxPrice.Text))
            {
                float value;

                if (float.TryParse(Dialog.field_MaxPrice.Text, out value))
                {
                    numerableNew = (from i in numerableNew
                                    where i.Price <= value
                                    select i).ToList();
                }
            }

            // type
            if (!string.IsNullOrEmpty(Dialog.combo_Type.Text))
            {
                string value = Dialog.combo_Type.Text;

                numerableNew = (from i in numerableNew
                                where i.Type == value
                                select i).ToList();
            }

            // transmission
            if (!string.IsNullOrEmpty(Dialog.combo_Transmission.Text))
            {
                string value = Dialog.combo_Transmission.Text;

                numerableNew = (from i in numerableNew
                                where i.Transmission == value
                                select i).ToList();
            }

            // category
            if (!string.IsNullOrEmpty(Dialog.combo_Category.Text))
            {
                string value = Dialog.combo_Category.Text;

                numerableNew = (from i in numerableNew
                                where i.Category.ToLower() == value.ToLower()
                                select i).ToList();
            }

            if (Dialog.toggle_RentStatus.IsChecked == false)
            {
                numerableNew = (from i in numerableNew
                                where i.ClientId == 0 
                                select i).ToList();
            }

            itemSearched = numerableNew;
        }
    }
}
