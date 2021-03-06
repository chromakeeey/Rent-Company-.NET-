﻿using System;
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

        public int statisticPanel;

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
        public int STATISTIC_PAMEL = 5;

        public int SUB_CHECK_PANEL = 0;
        public int SUB_ACCOUNT_PANEL = 1;
        public int SUB_VEHICLE_ADD = 2;
        public int SUB_VEHICLE_EDIT = 3;

        public int STATISTIC_CLIENT = 0;
        public int STATISTIC_VEHICLE = 1;
        public int STATISTIC_MONEY = 2;

        // statistic last update information
        public DateTime year_LastUpdate;
        public DateTime month_LastUpdate;
        public DateTime week_LastUpdate;
        public DateTime day_LastUpdate;

        public string companyName;
        public string streetName; 

        public void CreateAdminSubPanel(int panelid, admin_page object_page)
        {
            if (panelid == this.subPanelNow)
                return;

            object_page.admin_check1.Visible = false;
            object_page.admin_account1.Visible = false;
            object_page.admin_vehicleadd1.Visible = false;
            object_page.vehicleEdit.Visible = false;

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
                case 3:
                    {
                        object_page.vehicleEdit.Visible = true;

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
            object_form.ucStatistic.Visible = false;

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
                case 5:
                    {
                        object_form.ucStatistic.Visible = true;

                        break;
                    }

            }

            this.panelidNow = panelid;
        }

        public void CreateStatisticPanel(int panelid, UCStatistic ucStatistic)
        {
            if (statisticPanel == panelid)
                return;

            ucStatistic.ucStatClient.Visible = false;
            ucStatistic.ucMoneyStat.Visible = false;

            switch (panelid)
            {
                case 0: ucStatistic.ucStatClient.Visible = true; break;
                case 1: break;
                case 2: ucStatistic.ucMoneyStat.Visible = true; break;
            }

            statisticPanel = panelid;
        }

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
