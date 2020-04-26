using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TRC_Redesign.ServiceRent;

namespace TRC_Redesign.CashChecks
{
    public static class ShowCashVoucher
    {
        public static void Create(CashVoucher item)
        {
            CheckStartRent window = new CheckStartRent();

            window.setCashVoucher(item);
            window.ShowDialog();
        }

        public static CashVoucher Collect(Account account, Vehicle vehicle, float price, DateTime startDate, DateTime endDate)
        {
            string vehicleData = String.Format("VIN: {0}\nІм'я: {1}\nНомерний знак: {2}\nБензина в баці: {3} л.\nПробіг: {4} км.",
                vehicle.VIN, vehicle.name + " " + vehicle.model, vehicle.plate, vehicle.fuel.ToString(), vehicle.mileage.ToString());

            return new CashVoucher()
            {
                Id = -1,
                User = String.Format("{0} {1} {2}", account.secondname, account.name, account.fathername),
                Vehicle = vehicleData,
                Price = price,
                StartDate = startDate,
                FinalDate = endDate
            };
        }
    }
}
