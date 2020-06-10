using System;
using System.Runtime.Serialization;

namespace WCF_Rent.HeaderFile
{
    [DataContract]
    public class Rent
    {
        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime FinalDate { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int RentLogId { get; set; }

        public Rent()
        {
            ClientId = 0;
            RentLogId = 0;

            StartDate = DateTime.Now;
            FinalDate = DateTime.Now;
        }
    }
}
