using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace TRC_Redesign.CashChecks
{
    public class CheckData
    {
        public string companyName;
        public string streetName;

        public CheckData() { companyName = "Rent Company"; streetName = "None street"; }

        public void saveCheckData()
        {
            List<CheckData> checkData = new List<CheckData>();
            checkData.Add(this);

            File.WriteAllText("checkdata.dat", new JavaScriptSerializer().Serialize(checkData));
        }

        public void loadCheckData()
        {
            if (File.Exists("checkdata.dat"))
            {
                List<CheckData> checkData = new List<CheckData>();

                checkData = new JavaScriptSerializer().Deserialize<List<CheckData>>(File.ReadAllText("checkdata.dat"));

                this.companyName = checkData[0].companyName;
                this.streetName = checkData[0].streetName;
            }
        }
    }
}
