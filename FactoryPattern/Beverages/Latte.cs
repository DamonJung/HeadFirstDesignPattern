using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Beverages
{
    public class Latte : Beverage
    {
        public Latte()
        {
            Description = "Tasteful Latte";
        }
        public override double Cost()
        {
            return 4000;
        }
    }
}
