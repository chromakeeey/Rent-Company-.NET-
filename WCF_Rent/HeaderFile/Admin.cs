using System.Runtime.Serialization;

namespace WCF_Rent.HeaderFile
{
    [DataContract]
    public class Admin : BankCard
    {
        [DataMember]
        public int Level { get; set; }

        public int GetAdminLevel() { return this.Level; }
        public void SetAdminLevel(int level) { this.Level = level; }
    }
}
