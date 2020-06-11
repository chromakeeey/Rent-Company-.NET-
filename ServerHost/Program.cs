using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Web.Hosting;

using System.Net;

namespace ServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WCF_Rent.ServiceRent)))
            {
                host.Open();
                Console.WriteLine($"[{DateTime.Now}] SERVER HAS BEEN STARTED");

                // freeze   
                Console.ReadLine();   
            }
        }
    }
}
