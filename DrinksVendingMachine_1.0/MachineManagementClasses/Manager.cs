using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    internal class Manager
    {
       static public void MainManager()
       {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.AddBeverage(new Coffee("Nesspreso", 5, 90));
            vendingMachine.AddBeverage(new Coffee("Black coffee", 4, 100));
            vendingMachine.AddBeverage(new Tea("Arel Gray", 5, 75));
            vendingMachine.AddBeverage(new Tea("Chai masala", 5, 70));

            vendingMachine.Engaine();
       }
    }
}
