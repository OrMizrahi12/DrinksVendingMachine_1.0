using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVendingMachine_1._0
{
    abstract class Beverage
    {
        private string _name;
        private int _price;
        private int _whatarTemper;

        public string Name { get { return _name; } }
        public int Price { get { return _price; } }

        public int WhatarTemper { get { return _whatarTemper; } }

        public Beverage(string name, int price, int whatarTemper)
        {
            _name = name;
            _price = price;
            _whatarTemper = whatarTemper;
        }
 
        public abstract void Preper(List<string> ingredients);
        public abstract void AddingIngredients(List<string> ingredients);
        public abstract void AddingHotWater();
        public abstract void Stirring();
        public abstract List<string> SpecificIngredients();
        public abstract bool CheckStockAvailability();
    }
}
