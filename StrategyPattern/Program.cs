using StrategyPattern.Base;
using StrategyPattern.Ducks;
using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have four ducks available for the showcase.");
            Console.WriteLine("Choose one of these and type the number. ex) 1 = DecoyDuck");
            Console.WriteLine("");
            Console.WriteLine("1. DecoyDuck");
            Console.WriteLine("2. MallardDuck");
            Console.WriteLine("3. RedheadDuck");
            Console.WriteLine("4. RubberDuck");
            Console.WriteLine("");

            string end = String.Empty;
            do
            {
                Duck duck = default(Duck);

                string s = Console.ReadLine();
                if (!String.IsNullOrEmpty(s) && int.TryParse(s, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            {
                                duck = new DecoyDuck();
                                duck.setFlyBehavior(new FlyNoWay());
                                duck.setQuackHeavior(new MuteQuack());
                            }
                            break;
                        case 2:
                            {
                                duck = new MallardDuck();
                                duck.setFlyBehavior(new FlyWithWings());
                                duck.setQuackHeavior(new StrategyPattern.Quack.Quack());
                            }
                            break;
                        case 3:
                            {
                                duck = new RedheadDuck();
                                duck.setFlyBehavior(new FlyWithWings());
                                duck.setQuackHeavior(new Squeak());
                            }
                            break;
                        case 4:
                            {
                                duck = new RubberDuck();
                                duck.setFlyBehavior(new FlyNoWay());
                                duck.setQuackHeavior(new MuteQuack());
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("You choose a duck that is not on the list. I'm gonna just show you a rubber duck !");

                                duck = new RubberDuck();
                                duck.setFlyBehavior(new FlyNoWay());
                                duck.setQuackHeavior(new MuteQuack());
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input only numbers. Don't type their names.");
                }

                duck.display();
                duck.performFly();
                duck.performQuack();
                duck.swim();

                end = Console.ReadLine();
            } while (end != "exit");
        }
    }
}
