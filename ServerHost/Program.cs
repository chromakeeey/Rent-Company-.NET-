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
                /*NetTcpBinding binding = new NetTcpBinding();

                binding.MaxReceivedMessageSize = 500000;
                binding.MaxBufferSize = 500000;

                long maxlength = binding.MaxReceivedMessageSize;
                Console.WriteLine("MaxReceivedMessageSize = " + maxlength.ToString());

                long maxbuffer = binding.MaxBufferSize;
                Console.WriteLine("MaxBufferSize = " + maxbuffer.ToString());*/

                host.Open();
                Console.WriteLine("Host has been started [" + DateTime.Now.ToString() + "]");

               

                Console.ReadLine();


                
            }
        }
    }
}
