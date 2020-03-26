using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Rent.HeaderFile
{
    public class Rent
    {
        public DateTime start_date;
        public DateTime end_date;

        public int clientid;
        public int rentlogid;

        public Rent()
        {
            clientid = 0;
            rentlogid = 0;

            start_date = DateTime.Now;
            end_date = DateTime.Now;
        }
    }
}
