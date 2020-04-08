using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Rent.HeaderFile;

namespace WCF_Rent.Structures
{
    public class StatBalanceInfo
    {
        public int id;
        public Account account;

        public DateTime dateTime;

        public float cardnumber;
        public float value;
    }

    public class StatVehicleInfo
    {
        public int id;

        public int userid;
        public string VIN;

        public Vehicle vehicle;
        public Account account;

        public DateTime rent_startDate;
        public DateTime rent_endDate;

        public float payment;
        public float returning;
        public float credit;
    }

    public class StatInfo
    {
        public DateTime startDate;
        public DateTime endDate;

        public List<StatVehicleInfo> statVehicles;
        public List<StatBalanceInfo> statBalances;

        public float totalbalance;
    }
}
