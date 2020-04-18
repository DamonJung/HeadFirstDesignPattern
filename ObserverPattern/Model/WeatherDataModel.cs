using ObserverPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Model
{
    public class WeatherDataModel : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private double _Temperature { get; set; }
        public double Temperature
        {
            get
            {
                return _Temperature;
            }
            set
            {
                _Temperature = value;
                Publish(_Temperature, _Humidity, _BarometricPressure);
            }
        }

        private double _Humidity { get; set; }
        public double Humidity
        {
            get
            {
                return _Humidity;
            }
            set
            {
                _Humidity = value;
                Publish(_Temperature, _Humidity, _BarometricPressure);
            }
        }

        private double _BarometricPressure { get; set; }
        public double BarometricPressure
        {
            get
            {
                return _BarometricPressure;
            }
            set
            {
                _BarometricPressure = value;
                Publish(_Temperature, _Humidity, _BarometricPressure);
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);            
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Publish(double temperature, double humidity, double barometricPressure)
        {
            if(observers.Count > 0)
            {
                observers.ForEach(x => x.UpdateNotified(temperature, humidity, barometricPressure));
            }            
        }
    }
}
