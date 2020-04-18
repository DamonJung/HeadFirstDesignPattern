using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Core.Default
{
    public class DefaultObserver : IObserver, IDisplay
    {
        public void Display(double temperature, double humidity, double barometricPressure)
        {
            Console.WriteLine($"This is a default Display : Temperature : {temperature} / Humidity : {humidity} / Barometric Pressure : {barometricPressure}.");
        }

        public void UpdateNotified(double temperature, double humidity, double barometricPressure)
        {
            Display(temperature, humidity, barometricPressure);
        }
    }
}
