using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    internal class Coffee : Beverage
    {
        public Coffee(string name, int price, int whatarTemper) : base(name, price, whatarTemper) {  }

        public override void Preper(List<string> ingredients)
        {
            Console.Clear();
            Informer.GetBeverageName(Name);
            AddingHotWater();
            AddingIngredients(ingredients);
            Stirring();
            Stock.CoffeeDishes -= 1;
        }

        public override void AddingHotWater()
        {
            Informer.GetWatarTemp(WhatarTemper);
        }

        public override void AddingIngredients(List<string> ingredients)
        {
            Informer.GetIngredients(ingredients);
        }

        public override void Stirring()
        {
            Informer.StirringBeverage(Name); 
        }

        public override List<string> SpecificIngredients()
        {
            List<string> ingredients = new List<string>();
            
            int sugarCount = SuggatCount();
            bool milk = AddMilk();

            if (sugarCount > 0) ingredients.Add($"{sugarCount} suggar");
            if (milk) ingredients.Add("milk");

            return ingredients;
        }

        private bool AddMilk()
        {
            Console.WriteLine("You want milk?\n1- Yes\n2- No");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == 1) 
                    {
                        Stock.CupOfMilk -= 1;
                        return true;
                    }
                    else if (result == 2) return false;
                    else Console.WriteLine("1 or 2");
                }   
            }
        }

        private int SuggatCount()
        {
            Console.WriteLine("How much suggar?");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int result) && result >= 0 && result <= 5)
                {
                    if ((Stock.Suggar - result) >= 0)
                    {
                        Stock.Suggar -= result;
                        return result;
                    }
                    else Console.WriteLine($"The count is {Stock.Suggar}. You cant get {Stock.Suggar} suggar.");
                }
                else Console.WriteLine("0-5");
            }
        }

        public override bool CheckStockAvailability()
        {
            return true;
            if (Stock.CoffeeDishes == 0)
            {
                Console.WriteLine("The coffee is out of stock");
                return false;
            }
            else if (Stock.CupOfMilk == 0)
            {
                Console.WriteLine("The milk is out of stock");
                return false;
            }
            else return true;  

        }

    }
}
