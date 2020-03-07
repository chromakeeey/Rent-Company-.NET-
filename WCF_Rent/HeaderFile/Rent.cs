using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Rent.HeaderFile
{
    public class Rent
    {
        public int isrent;
        public int client_documentid;

        public DateTime start_date;
        public DateTime end_date;

        public Rent()
        {
            isrent = 0;
            client_documentid = 0;

            start_date = DateTime.Now;
            end_date = DateTime.Now;
    }

        public void SetRentInfo(int client_documentid, DateTime end_date)
        {
            isrent = 0;
            this.client_documentid = client_documentid;

            start_date = DateTime.Now;
            this.end_date = end_date;

        }

        public void CancelRent()
        {
            this.client_documentid = 0;

        }
    }
}
