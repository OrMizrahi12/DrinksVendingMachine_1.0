using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    internal class Manager
    {
        public void MainManager()
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.AddBeverage(new Coffee("Ness", 5, 90));
            vendingMachine.AddBeverage(new Tea("Arel Gray", 5, 75));
            vendingMachine.AddBeverage(new Tea("AAA", 5, 75));
            vendingMachine.Engaine();
        }
    }
}
