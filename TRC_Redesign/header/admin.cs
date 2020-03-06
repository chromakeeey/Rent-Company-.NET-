using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign.header
{
    public class admin
    {
        public int level;

        public int GetAdminLevel() { return this.level; }
        public void SetAdminLevel(int level) { this.level = level; }
    }
}
