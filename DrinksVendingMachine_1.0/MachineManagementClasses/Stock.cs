using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    internal class Stock
    {
        static private int _cups = 100;
        static private int _suggar = 100;
        static private int _cupOfMilk = 100;
        static private int _coffeeDishes = 100;
        static private int _cinnamon = 100;
        static private int _teaDishes = 100;
        private const int TYPE_OF_STOCKS = 4;

        static public int Cups { get { return _cups; } set { _cups = value; } }
        static public int Suggar { get { return _suggar; } set { _suggar = value; } }
        static public int CoffeeDishes { get { return _coffeeDishes; } set { _coffeeDishes = value; } }
        static public int TeaDishes { get { return _teaDishes; } set { _teaDishes = value; } }
        static public int CupOfMilk { get { return _cupOfMilk; } set { _cupOfMilk = value; } }
        static public int Cinnamon { get { return _cinnamon; } set { _cinnamon = value; } }

        static public void ChooseStockForUpdate()
        {
            ShowStock();
            int productNum = ChooseProductNum();
            AddStock(productNum);
        }

        static void AddStock(int productName)
        {
            switch (productName)
            {
                case 1:
                    _cups += ChoosStockCount("cups");
                    break;
                case 2:
                    _suggar += ChoosStockCount("suggar");
                    break;
                case 3:
                    _coffeeDishes += ChoosStockCount("coffeeDishes");
                    break;
                case 4:
                    _teaDishes += ChoosStockCount("teaDishes");
                    break;
                default:
                    break;
            }
            Console.Clear();
            Console.WriteLine("Success added!\n Look on your stock now --> \n\n");
            ShowStock();
        }

        static private int ChoosStockCount(string productName)
        {

            Console.WriteLine($"What the count of {productName} you want to add?");
            while (true)
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 100)
                    return result;
                else Console.WriteLine("only 1 - 100");
        }

        static public void ShowStock()
        {
            Console.WriteLine($"1. Cups: {_cups}\n2. Suggar: {_suggar}\n3. CoffeeDishes: {_coffeeDishes}\n4. TeaDishes:{_teaDishes}\n\n\n");
        }
        static private int ChooseProductNum()
        {
            Console.WriteLine($"Choose product number");
            while (true)
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result <= TYPE_OF_STOCKS)
                    return result;
                else Console.WriteLine("Choose valid option.");
            
        }
    }
}
