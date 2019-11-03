using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObserverMode.Service;
using ObserverMode.ServiceImpl;

namespace ObserverMode
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wdata = new WeatherData();

            CurrentConditionDisplay currConditions = new CurrentConditionDisplay(wdata);
            StatisticsDisplay sDisplay = new StatisticsDisplay();
            ForecastDisplay fDisplay = new ForecastDisplay(wdata);

            wdata.setMeasurementsChanged(23, 78, 30.4f);
            wdata.setMeasurementsChanged(24, 70, 32.8f);
            wdata.setMeasurementsChanged(18, 50, 39.2f);

            Console.ReadLine();
        }
    }
}
