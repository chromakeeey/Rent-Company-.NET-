using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;

namespace TRC_Redesign.header
{
    public class UI : theme
    {
        public int panelidNow;
        public int subPanelNow;

        /* PANEL ID
         * 0 - main [panel7]
         * 1 - vehicle [panel16]
         * 2 - payment page [payment_page]
         * 3 - settings [-]
         * 4 - admin [-]
        */

        public int MAIN_PANEL = 0;
        public int VEHICLE_PANEL = 1;
        public int PAYMENT_PANEL = 2;
        public int SETTING_PANEL = 3;

        public int ADMIN_PANEL = 4;

        public int SUB_CHECK_PANEL = 0;
        public int SUB_ACCOUNT_PANEL = 1;
        public int SUB_VEHICLE_ADD = 2;

        public void CreateAdminSubPanel(int panelid, admin_page object_page)
        {
            if (panelid == this.subPanelNow)
                return;

            object_page.admin_check1.Visible = false;
            object_page.admin_account1.Visible = false;
            object_page.admin_vehicleadd1.Visible = false;

            switch (panelid)
            {
                case 0:
                    {
                        object_page.admin_check1.Visible = true;

                        break;
                    }
                case 1:
                    {
                        object_page.admin_account1.Visible = true;

                        break;
                    }
                case 2:
                    {
                        object_page.admin_vehicleadd1.Visible = true;

                        break;
                    }
            }

            this.subPanelNow = panelid;
        }

        public void CreatePanel(int panelid, Form1 object_form)
        {
            if (panelid == this.panelidNow)
                return;

            object_form.main_page1.Visible = false;
            object_form.vehicle_page1.Visible = false;
            object_form.payment_page1.Visible = false;
            object_form.admin_page1.Visible = false;
            object_form.settings_page1.Visible = false;

            switch (panelid)
            {
                case 0:
                    {
                        object_form.main_page1.Visible = true; 

                        break;
                    }
                case 1:
                    {
                        object_form.vehicle_page1.Visible = true;

                        break;
                    }
                case 2:
                    {
                        object_form.payment_page1.Visible = true;

                        break;
                    }
                case 3:
                    {
                        object_form.settings_page1.Visible = true;

                        break;
                    }
                case 4:
                    {
                        object_form.admin_page1.Visible = true;

                        break;
                    }

            }

            this.panelidNow = panelid;
        }

        // vehicle [ string = "clear", no set name ]
        // [type] [0-all, 1-rent, 2-norent]
        public vehicle[] CreateObjectParams(int min, int max, int type)
        {
            int vehicleid = 0;

            // create objects
            vehicle[] paramsObject = new vehicle[1000];
            for (int i = 0; i < 1000; i++)
                paramsObject[i] = new vehicle();

            for (int i = 0; i < 1000; i++)
            {
                if (!(Form1.pointer.Vehicle[i].price >= min && Form1.pointer.Vehicle[i].price <= max))
                    continue;

                if (type == 1 && Form1.pointer.Vehicle[i].client_documentid == 0)
                    continue;

                if (type == 1 && Form1.pointer.Vehicle[i].client_documentid != 0)
                    continue;

                paramsObject[vehicleid] = Form1.pointer.Vehicle[i];
                vehicleid++;
            }

            return paramsObject;
        }

        public int ConvertFromParams(vehicle params_object)
        {
            int vehicleid = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (params_object.plate != Form1.pointer.Vehicle[i].plate)
                    continue;

                vehicleid = i;

                break;
            }

            return vehicleid;
        }

        public int GetMaxPage(vehicle[] object_data, int size)
        {
            int unRentCount = 0;

            for (int i = 0; i < size; i++)
            {
                if (!object_data[i].IsVehicleValid())
                    continue;

                if (object_data[i].client_documentid == 0)
                    unRentCount++;
            }

            double sub = unRentCount / 3;
            return Convert.ToInt32(unRentCount) / 2;
        }

        public int GetAllVehicle()
        {
            int allvehicle = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (Form1.pointer.Vehicle[i].IsVehicleValid())
                    allvehicle++;
            }

            return allvehicle;
        }

        public int GetAllRentVehicle()
        {
            int allvehicle = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (!Form1.pointer.Vehicle[i].IsVehicleValid())
                    continue;

                if (Form1.pointer.Vehicle[i].client_documentid == 0)
                    continue;

                allvehicle++;
            }

            return allvehicle;
        }

        public int GetAllNoRentVehicle()
        {
            return this.GetAllVehicle() - this.GetAllRentVehicle();
        }

        /*public int GetVehicleIndex(int type, vehicle[] object_data, int size)
        {
            int vehicleid = -1;

            switch (type)
            {
                case 0:
                    {
                        for (int i = 0; i < 1000; i++)
                        {
                            if (object_data[i].IsVehicleValid())
                            {
                                vehicleid = i;

                                break;
                            }
                        }

                        break;
                    }
            }

            return vehicleid;
        }

        public float GetMaxPrice(vehicle[] object_data, int size)
        {
            int max_i = GetVehicleIndex(0, object_data, size);

            if (max_i == -1)
                return 0;

            float max_price = object_data[GetVehicleIndex(0, object_data, size)].price;

            for (int i = 0; i < 1000; i++)
            {
                if (!object_data[i].IsVehicleValid())
                    continue;

                if (object_data[i].price > max_price)
                    max_price = object_data[i].price;
            }

            return max_price;
        }

        public float GetMinPrice(vehicle[] object_data, int size)
        {
            int min_i = GetVehicleIndex(0, object_data, size);

            if (min_i == -1)
                return 0;

            float min_price = object_data[GetVehicleIndex(0, object_data, size)].price;

            for (int i = 0; i < 1000; i++)
            {
                if (!object_data[i].IsVehicleValid())
                    continue;

                if (object_data[i].price < min_price)
                    min_price = object_data[i].price;
            }

            return min_price;
        }*/

        public UI()
        {
            panelidNow = -1;
            subPanelNow = -1;
        }

        public void SaveTheme()
        {
           
            ColorsToHTML();

            List<UI> UI_List = new List<UI>();
            UI_List.Add(this);

            File.WriteAllText("themedata.dat", new JavaScriptSerializer().Serialize(UI_List));

        }

        public List<UI> LoadTheme()
        {
            if (File.Exists("themedata.dat"))
                return new JavaScriptSerializer().Deserialize<List<UI>>(File.ReadAllText("themedata.dat"));
            else
                return new List<UI>();
        }
    }
}
