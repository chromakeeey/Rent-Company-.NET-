using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.ServerReference;

namespace ClientVehicle.Dialogs.DialogsUser
{
    public static class UserACard
    {
        public static UserCardAdmin Card = new UserCardAdmin();

        public static void Show(User Item)
        {
            Card.User = Item;
            Card.ShowDialog();
        }
    }
}
