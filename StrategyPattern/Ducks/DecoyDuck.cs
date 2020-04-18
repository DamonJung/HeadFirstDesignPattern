using StrategyPattern.Base;
using StrategyPattern.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class DecoyDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I look exactly like a DecoyDuck");
        }

        public override void swim()
        {
            Console.WriteLine("Can DecoyDuck swim? I'm not sure....");
        }
    }
}
