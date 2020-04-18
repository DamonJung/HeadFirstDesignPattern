using ObserverPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class StatisticDisplay : IObserver, IDisplay
    {
        List<double> temperatureList = new List<double>();
        List<double> humidityList = new List<double>();
        List<double> barometricPressureList = new List<double>();

        public void Display(double temperature, double humidity, double barometricPressure)
        {
            Console.WriteLine("=============================================================================================");
            Console.WriteLine($"Statistic Display. Temperature Avg : {temperatureList.Average()} / Humidity Avg : {humidityList.Average()} /Barometric Pressure AVG : {barometricPressureList.Average()}");
            Console.WriteLine("=============================================================================================");
        }

        public void UpdateNotified(double temperature, double humidity, double barometricPressure)
        {
            temperatureList.Add(temperature);
            humidityList.Add(humidity);
            barometricPressureList.Add(barometricPressure);

            Display(temperature, humidity, barometricPressure);
        }
    }
}
