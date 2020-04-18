using ObserverPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class DefaultDisplay : IObserver, IDisplay
    {
        public void Display(double temperature, double humidity, double barometricPressure)
        {
            Console.WriteLine("=============================================================================================");
            Console.WriteLine($"Default Display. Temperature : {temperature} / Humidity : {humidity} /Barometric Pressure : {barometricPressure}");
            Console.WriteLine("=============================================================================================");
        }

        public void UpdateNotified(double temperature, double humidity, double barometricPressure)
        {
            this.Display(temperature, humidity, barometricPressure);
        }
    }
}
