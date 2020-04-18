using StrategyPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class RedheadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I look exactly like a red head duck.");
        }

        public override void swim()
        {
            Console.WriteLine("I can swim for sure.");
        }
    }
}
