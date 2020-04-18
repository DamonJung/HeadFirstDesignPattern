using StrategyPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I look exactly like a mallard duck!");
        }

        public override void swim()
        {
            Console.WriteLine("I can definitely swim !");
        }
    }
}
