using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Core
{
    public interface IDisplay
    {
        void Display(double temperature, double humidity, double barometricPressure);
    }
}
