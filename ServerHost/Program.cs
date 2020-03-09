using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using (var host = new ServiceHost(typeof(WCF_Rent.ServiceRent)))
            {
                NetTcpBinding netTcpBinding = new NetTcpBinding();
                netTcpBinding.MaxBufferSize = 65536;
                netTcpBinding.MaxReceivedMessageSize = 204003200;
                netTcpBinding.TransferMode = TransferMode.Buffered;

                host.Open();
                Console.WriteLine("Host has been started [" + DateTime.Now.ToString() + "]");

                

                Console.ReadLine();


                
            }
        }
    }
}
