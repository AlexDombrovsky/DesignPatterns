using Decorator.BaseClasses;
using Decorator.Beverages;
using Decorator.Decorators;
using System;
using System.Collections;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost());

            Beverage beverage2 = new Mocha(new Mocha(new Whip(new DarkRoast())));
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost());

            Console.ReadKey();
        }
    }
}
