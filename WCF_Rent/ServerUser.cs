using System.ServiceModel;

namespace WCF_Rent
{
    public class ServerUser
    {
        public int ID { get; set; }
        public OperationContext operationContext { get; set; }
    }
}
