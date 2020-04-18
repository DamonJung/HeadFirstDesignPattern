using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Decorators
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + " And Sweet High-Quality Mocha";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 500;
        }
    }
}
