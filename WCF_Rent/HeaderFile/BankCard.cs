using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WCF_Rent.HeaderFile
{
    public class BankCard
    {
        public string CardNumber;
        public string ExpireDate;
        public int CVV;

        [DataMember]
        public string OwnerName { get; set; }
    }
}
