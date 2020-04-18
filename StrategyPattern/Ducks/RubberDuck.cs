using StrategyPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I look like a rubber duck.");
        }

        public override void swim()
        {
            Console.WriteLine("What I do is not swimming, it's so much as floating in the water.");
        }
    }
}
