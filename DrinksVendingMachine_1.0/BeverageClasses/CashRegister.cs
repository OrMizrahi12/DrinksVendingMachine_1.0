using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0.BeverageClasses
{
    internal class CashRegister
    {
        public static int CashRegisterController(Beverage beverage)
        {
            Console.WriteLine($"You need pay {beverage.Price}$ for getting your {beverage.Name}");
           return ReturnModule(beverage.Price);
        }
        private static int ReturnModule(int beveragePrice)
        {
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int result) && result >= beveragePrice)
                    return result - beveragePrice;
                else
                    Console.WriteLine($"Your drink cost is {beveragePrice}. Pey as well.");
            }
        }
    }
}
