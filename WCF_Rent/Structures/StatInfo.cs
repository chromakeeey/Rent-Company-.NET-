using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using WCF_Rent.HeaderFile;

namespace WCF_Rent.Structures
{
    [DataContract]
    public class StatVoucherInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Operation { get; set; }

        [DataMember]
        public string Time { get; set; }
    }

    [DataContract]
    public class StatBalanceInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public User User { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public DateTime DateNow { get; set; }


        [DataMember]
        public string CardNumber { get; set; }

        [DataMember]
        public float Value { get; set; }
    }

    [DataContract]
    public class StatVehicleInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string VIN { get; set; }


        [DataMember]
        public Vehicle Vehicle;

        [DataMember]
        public User User { get; set; }


        [DataMember]
        public DateTime RentStartDate { get; set; }

        [DataMember]
        public DateTime RentFinalDate { get; set; }


        [DataMember]
        public float Payment { get; set; }

        [DataMember]
        public float Returning { get; set; }

        [DataMember]
        public float Credit { get; set; }
    }

    [DataContract]
    public class StatInfo
    {
        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime FinalDate { get; set; }

        [DataMember]
        public List<StatVehicleInfo> StatVehicles { get; set; }

        [DataMember]
        public List<StatBalanceInfo> StatBalances { get; set; }

        [DataMember]
        public List<StatVoucherInfo> StatVouchers { get; set; }

        [DataMember]
        public float TotalBalance { get; set; }
    }
}
