using DecoratorPattern.Beverages;
using DecoratorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have these fabulous drinkings.");

            Beverage espresso = new Espresso();
            Beverage latte = new Latte();
            Beverage orangejuice = new OrangeJuice();

            Console.WriteLine($"Espresso : {espresso.Description} \\.{espresso.Cost()}");
            Console.WriteLine($"Latte : {espresso.Description} \\.{latte.Cost()}");
            Console.WriteLine($"OrangeJuice : {espresso.Description} \\.{orangejuice.Cost()}");

            Beverage mochaLatte = new Mocha(new Latte());
            Console.WriteLine($"Mocha Latte : {mochaLatte.Description} \\.{mochaLatte.Cost()}");

            Console.ReadLine();
        }
    }
}
