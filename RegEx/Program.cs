using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string longestName = "";
            int highestCals = 0;
            int totalWeight = 0;
            int cheapest = 1000;

            

            string path = "Data.txt";
            using(StreamReader r = new StreamReader(path))
            {
                while(!r.EndOfStream)
                {
                   string input = r.ReadLine();

                    Match m = Regex.Match(input, @"([A-Za-z]+[0-9]+) (\d+) (\d+) (\d+)");
                    string name = m.Groups[1].Value;
                    int calories = int.Parse(m.Groups[2].Value);
                    int price = int.Parse(m.Groups[3].Value);
                    int weight = int.Parse(m.Groups[4].Value);

                    if (name.Length > longestName.Length)
                    {
                        longestName = name;
                    }

                    if (calories > highestCals)
                    {
                        highestCals = calories;
                    }

                    totalWeight += weight;

                    if (price < cheapest)
                    {
                        cheapest = price;
                    }




                }

                Console.WriteLine(longestName);
                Console.WriteLine(highestCals);
                Console.WriteLine(totalWeight);
                Console.WriteLine(cheapest);

                


            }

            
        }
    }
}
