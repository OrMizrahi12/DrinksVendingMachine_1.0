using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    internal class Tea : Beverage
    {

        public Tea(string name, int price, int whatarTemper) :base(name, price, whatarTemper)
        {
            
        }


        public override void Preper(List<string> ingredients)
        {
            Console.Clear();
            Informer.GetBeverageName(Name);
            AddingHotWater();
            AddingIngredients(ingredients);
            Stirring();
            Stock.TeaDishes--; 
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
            bool cinnamon = false;

            int sugarCount = SuggatCount();

            if (Stock.Cinnamon > 0) cinnamon = addCinnamon();
            if (sugarCount > 0) ingredients.Add($"{sugarCount} suggar");
            if (cinnamon) ingredients.Add("cinnamon");

            return ingredients;
        }

        private bool addCinnamon()
        {
            Console.WriteLine("You want innamon?\n1- Yes\n2- No");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                    if (result == 1)
                    {
                        Stock.Cinnamon -= 1;
                        return true;
                    } 
                    else if (result == 2) return false;
                    else Console.WriteLine("1 or 2");
            }
        }

        private int SuggatCount()
        {
            Console.WriteLine("How much suggar?");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result) && result >= 0 && result <= 3)
                {
                    if ((Stock.Suggar - result) >= 1)
                    {
                        Stock.Suggar -= result;
                        return result;
                    }
                    else Console.WriteLine($"The suggar out of stock.");
                }
                else Console.WriteLine("0-3 only");
            }
        }

        public override bool CheckStockAvailability()
        {
            if (Stock.TeaDishes == 0)
            {
                Console.WriteLine("The tea is out of stock");
                return false;
            }
            else return true;
        }
    }
}
