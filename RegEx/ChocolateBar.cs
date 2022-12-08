using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEx
{
    class ChocolateBar
    {
        public string Name;
        public int Calories;
        public int Price;
        public int Weight;

        public ChocolateBar(string name, int calories, int price, int weight)
        {
            Name = name;
            Calories = calories;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return ($"{Name}: {Weight}g {Calories} calories {Price}p");
        }

    }
}
