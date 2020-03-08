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

        [OperationContract]
        Vehicle getUserVehicle(Account account);

        /*      account block       */

        [OperationContract(IsOneWay = true)]
        void saveAccount(Account accountObject);

        [OperationContract(IsOneWay = true)]
        void addAccount(Account accountObject);

        [OperationContract(IsOneWay = true)]
        void deleteAccount(Account accountObject);

        [OperationContract]
        List<Vehicle> createVehicleObjectParams(int min, int max, int type);

        [OperationContract]
        int GetAllVehicle();

        [OperationContract]
        int GetAllRentVehicle();

        [OperationContract]
        int GetAllNoRentVehicle();


        [OperationContract]
        Account noAcceptedAccount();

        [OperationContract]
        Vehicle findVehicle(string plate);

    }

    public interface IServerRentCallback
    {
        

    }

    

}
