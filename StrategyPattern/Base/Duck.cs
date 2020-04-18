using StrategyPattern.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Base
{
    public abstract class Duck
    {
        public IFlyBehavior _flyBehavior;
        public IQuackBehavior _quackBehavior;

        public abstract void display();
        public abstract void swim();
        public virtual void performQuack()
        {
            _quackBehavior.Quack();
        }
        public virtual void performFly()
        {
            _flyBehavior.Fly();
        }
        public virtual void setFlyBehavior(IFlyBehavior behavior)
        {
            _flyBehavior = behavior;
        }
        public virtual void setQuackHeavior(IQuackBehavior behavior)
        {
            _quackBehavior = behavior;
        }
    }
}
