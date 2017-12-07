using System;
using Starbuzz.Beverages;
using Starbuzz.Condiments;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() +
                 " " + beverage.Cost());

            
            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " " +
                beverage2.Cost());

            Console.ReadLine();
        }
    }
}
