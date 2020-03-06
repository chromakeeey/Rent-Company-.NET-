using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TRC_Redesign.header;

namespace WCF_Rent
{

    [ServiceContract(CallbackContract = typeof(IServerRentCallback))]
    public interface IServiceRent
    {
        [OperationContract]
        int userConnect();

        [OperationContract]
        void userDisconnect(int id);

        [OperationContract(IsOneWay = true)]
        void sendAccountObject(int id, account accountObject);

        [OperationContract(IsOneWay = true)]
        account selectAccount(string login, string password);

    }

    public interface IServerRentCallback
    {
        [OperationContract(IsOneWay = true)]
        void accountObjectCallBack(account accountObject);

        [OperationContract(IsOneWay = true)]
        void vehicleListCallBack(List<vehicle> vehicleObject);

    }

}
