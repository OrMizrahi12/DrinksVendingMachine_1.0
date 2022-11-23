using DrinksVendingMachine_1._0.BeverageClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    internal class VendingMachine
    {
        readonly string[] _menuOptions = {"1. Buy beverage", "2. Update stock", "3. Show stock" };
        private readonly List <Beverage> beverages = new List<Beverage> ();

        public void Engaine()
        {
            while (true) 
            {
                ShowMenu();
                Navigation();
            }
        }
        public void AddBeverage(Beverage beverage)
        {
            beverages.Add(beverage);
        }
        public void ShowBeverage()
        {
            Console.WriteLine("Choose your best:");
            for (int i = 0; i < beverages.Count; i++)
                Console.WriteLine($"\n{i+1}. {beverages[i].Name} - {beverages[i].Price}$\n------------- "); 
        }
        void ShowMenu()
        {
            Console.WriteLine("Choose your best:");
            foreach (string option  in _menuOptions)
                Console.WriteLine(option);            
        }
        void Navigation()
        {
            int result = ChooseNumberValidation();
            Console.Clear();
            switch (result)
            {
                case 1: BuyDrinkProses(); break;
                case 2: Stock.ChooseStockForUpdate(); break;
                case 3: Stock.ShowStock(); break;
                default: break;
            }
        }
        int ChooseNumberValidation()
        {
            while (true)
            {
              if(int.TryParse(Console.ReadLine(), out int result) && result > 0 && result <= _menuOptions.Length)
                    return result;
              else
                    Console.WriteLine($"Choose number between 1 - {_menuOptions.Length}");
            }
        }
        void BuyDrinkProses()
        {
            Console.Clear();
            if (Stock.Cups == 0)
            {
                Console.WriteLine("The cups is out of stock");
                return; 
            }
            _ = new List<string>();
            int result = ChooseDrinkValidation();

            for (int i = 0; i < beverages.Count; i++)
                if (result == i && beverages[i].CheckStockAvailability())
                {
                    int module = CashRegister.CashRegisterController(beverages[i]);
                    List<string> Ingredients = beverages[i].SpecificIngredients();
                    beverages[i].Preper(Ingredients);
                    Console.WriteLine($"-->Your module is {module}$\n");
                }
                return; 
        }

        private int ChooseDrinkValidation()
        {
            ShowBeverage();
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int result) && result > 0 && result <= beverages.Count)
                    return result - 1;
                else
                    Console.WriteLine($"Inseret valid number.");
            }
        }
    }
}
