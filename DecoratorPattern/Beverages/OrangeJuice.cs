using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    public class OrangeJuice : Beverage
    {
        public OrangeJuice()
        {
            Description = "Fresh Orange Juice";
        }

        public override double Cost()
        {
            return 5000;
        }
    }
}
