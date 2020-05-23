using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;

using WCF_Rent.Structures;
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

        [OperationContract(IsOneWay = true)]
        void selectAllVehicle();

        [OperationContract(IsOneWay = true)]
        void deleteVehicle(Vehicle vehicleObject);

        [OperationContract(IsOneWay = true)]
        void addVehicle(Vehicle vehicleObject);

        [OperationContract(IsOneWay = true)]
        void saveVehicle(Vehicle vehicleObject);

        [OperationContract]
        int GetAllVehicle();

        [OperationContract]
        int GetAllRentVehicle();

        [OperationContract]
        int GetAllNoRentVehicle();

        [OperationContract]
        Vehicle findVehicle(string plate);

        [OperationContract]
        void uploadVehicleImage(byte[] buffer, string name, string extenstion);

        /*[OperationContract]
        Stream downloadVehicleImage(Vehicle vehicleObject);*/

        [OperationContract]
        byte[] vehicleImage(Vehicle item);

        [OperationContract(IsOneWay = true)]
        void log_AddVehicle(int userid, string VIN);

        [OperationContract(IsOneWay = true)]
        void log_Balance(int userid, string card, float value);

        [OperationContract(IsOneWay = true)]
        void log_DeleteVehicle(int userid, string VIN, string name);

        [OperationContract(IsOneWay = true)]
        void log_EditVehicle(int userid, string VIN, string str_params);

        [OperationContract(IsOneWay = true)]
        void log_RemoveRent(int userid, int takerentid, DateTime date, float balancereturn, float credit);

        [OperationContract(IsOneWay = true)]
        void log_Request(int admin_userid, int application_userid, int answer);

        [OperationContract]
        int log_TakeRent(int userid, string VIN, float price, int cashVoucherId, DateTime startdate, DateTime enddate);

        [OperationContract]
        StatInfo SendStatInfo(DateTime startDate, DateTime endDate);

        [OperationContract]
        Vehicle selectVehicle(string VIN);

        [OperationContract]
        CashVoucherData sendCashVoucherData();

        [OperationContract]
        CashVoucher readCashVoucher(int Id);

        [OperationContract]
        int writeCashVoucher(CashVoucher cashVoucher);

        [OperationContract(IsOneWay = true)]
        void setCashVoucherData(string Company, string Street);

        [OperationContract]
        int sendCashVoucherID(int logtakerentid);

        [OperationContract]
        User SelectUser_LoginPassword(string Login, string Password);

        [OperationContract]
        User SelectUser(int Id);

        [OperationContract(IsOneWay = true)]
        void SaveUser(User item);

        [OperationContract(IsOneWay = true)]
        void AddUser(User item);

        [OperationContract(IsOneWay = true)]
        void DeleteUser(User item);

        [OperationContract]
        Vehicle GetUserVehicle(User item);

        [OperationContract(IsOneWay = true)]
        void SaveBackImage(byte[] Image, string Name, string Extension);

        [OperationContract(IsOneWay = true)]
        void SaveFrontImage(byte[] Image, string Name, string Extension);

        [OperationContract]
        byte[] BackImageBytes(User item);

        [OperationContract]
        byte[] FrontImageBytes(User item);

        [OperationContract]
        bool IsVehicleValid(string VIN);

        [OperationContract]
        List<Vehicle> SendAllVehicle();

        [OperationContract]
        List<User> SelectAllUser();
    }

    public interface IServerRentCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnEditVehicle(Vehicle item, List<Vehicle> numerable);

        [OperationContract(IsOneWay = true)]
        void OnAddVehicle(Vehicle item, List<Vehicle> numerable);

        [OperationContract(IsOneWay = true)]
        void OnDeleteVehicle(Vehicle item, List<Vehicle> numerable);


        [OperationContract(IsOneWay = true)]
        void OnUserEdit(User Item, List<User> numerable);

        [OperationContract(IsOneWay = true)]
        void OnUserAdd(User Item, List<User> numerable);

        [OperationContract(IsOneWay = true)]
        void OnUserDelete(User Item, List<User> numerable);
    }

    

}
