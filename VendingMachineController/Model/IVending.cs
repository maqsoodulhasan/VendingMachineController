using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineController.Model
{
   public interface IVending
    {
        void Purchase(int SelectedProduct);
       void ShowAll();
        bool InsertMoney(int money);
        void EndTransaction();
    }
}
