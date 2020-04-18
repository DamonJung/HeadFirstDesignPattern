using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Core.Default
{
    public class WeatherData : IWeatherData
    {
        List<double> baroDatabase = new List<double>();
        List<double> humiDatabase = new List<double>();
        List<double> tempDatabase = new List<double>();

        public double GetBarometricPressure()
        {
            if(baroDatabase.Count == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    baroDatabase.Add(i * 0.412);
                }
            }            

            return baroDatabase.ElementAtOrDefault(GetRandomIndex());
        }

        public double GetHumidity()
        {
            if(humiDatabase.Count == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    humiDatabase.Add(i * 0.687);
                }
            }            

            return humiDatabase.ElementAtOrDefault(GetRandomIndex());
        }

        public double GetTemperature()
        {
            if(tempDatabase.Count == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    tempDatabase.Add(i);
                }
            }            

            return tempDatabase.ElementAtOrDefault(GetRandomIndex());
        }

        Random random = new Random();

        private int GetRandomIndex()
        {
            int index = random.Next(0, 100);
            return index;
        }
    }
}
