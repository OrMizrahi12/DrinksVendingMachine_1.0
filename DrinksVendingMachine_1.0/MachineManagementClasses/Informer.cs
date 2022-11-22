using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    internal class Informer
    {
        static public void GetBeverageName(string beverageName)
        {
            Console.WriteLine($"Preper Your {beverageName}...\n\n");
        }
        static public void GetWatarTemp(int watarTemp)
        {
            Console.WriteLine($"**********\nAdding hot watar, temp of {watarTemp}\n**********");
        }
        static public void GetIngredients(List<string> Ingredients)
        {
            Console.WriteLine("**********\nAdd Ingredients");
            foreach (var ingredient in Ingredients)
                Console.WriteLine("- " + ingredient);
            Console.WriteLine("**********");
        }
        static public void StirringBeverage(string beverageName)
        {
            Console.WriteLine($"**********\nStirring All....\nyour {beverageName} is ready!\n***********\n\n");
        }
    }
}
