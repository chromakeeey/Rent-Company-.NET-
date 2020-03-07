using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Rent.HeaderFile;

namespace WCF_Rent
{

    [ServiceContract(CallbackContract = typeof(IServerRentCallback))]
    public interface IServiceRent
    {
        [OperationContract]
        int userConnect();

        [OperationContract]
        void userDisconnect(int id);


        [OperationContract]
        Account selectAccount(string login, string password);

        [OperationContract(IsOneWay = true)]
        void createSqlConnection(string path);

        /*      vehicle block       */


        [OperationContract(IsOneWay = true)]
        void selectAllVehicle();

        [OperationContract(IsOneWay = true)]
        void deleteVehicle(Vehicle vehicleObject);

        [OperationContract(IsOneWay = true)]
        void addVehicle(Vehicle vehicleObject);

        [OperationContract(IsOneWay = true)]
        void saveVehicle(Vehicle vehicleObject);

        [OperationContract]
        bool isAccountValid(string login);

        [OperationContract]
        bool isSqlConnection();

        /*      account block       */

        [OperationContract(IsOneWay = true)]
        void saveAccount(Account accountObject);

        [OperationContract(IsOneWay = true)]
        void addAccount(Account accountObject);

        [OperationContract(IsOneWay = true)]
        void deleteAccount(Account accountObject);

    }

    public interface IServerRentCallback
    {
        

    }

}
