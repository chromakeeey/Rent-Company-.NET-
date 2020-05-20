using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WCF_Rent.HeaderFile
{
    public class Admin : BankCard
    {
        public int Level;

        public int GetAdminLevel() { return this.Level; }
        public void SetAdminLevel(int level) { this.Level = level; }
    }
}
