using System.Runtime.Serialization;

namespace WCF_Rent.HeaderFile
{
    [DataContract]
    public class BankCard
    {
        [DataMember]
        public string CardNumber { get; set; }

        [DataMember]
        public string ExpireDate { get; set; }

        [DataMember]
        public int CVV { get; set; }

        [DataMember]
        public string OwnerName { get; set; }
    }
}
