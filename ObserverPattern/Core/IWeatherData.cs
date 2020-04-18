using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Core
{
    public interface IWeatherData
    {
        double GetTemperature();
        double GetHumidity();
        double GetBarometricPressure();
    }
}
