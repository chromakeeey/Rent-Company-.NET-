using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Rent.HeaderFile
{
    public class Admin
    {
        public int level;

        public int GetAdminLevel() { return this.level; }
        public void SetAdminLevel(int level) { this.level = level; }
    }
}
