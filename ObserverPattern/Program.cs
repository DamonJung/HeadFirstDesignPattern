using ObserverPattern.Core.Default;
using ObserverPattern.Model;
using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new WeatherDataModel();

            model.Subscribe(new DefaultDisplay());
            model.Subscribe(new StatisticDisplay());

            var data = new WeatherData();

            for(int i = 0; i < 10; i++)
            {
                model.Temperature = data.GetTemperature();
                model.Humidity = data.GetHumidity();
                model.BarometricPressure = data.GetBarometricPressure();
            }            

            Console.ReadLine();
        }
    }
}
