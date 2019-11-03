using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            WeatherDataProvider weatherDataProvider = new WeatherDataProvider();

            Display currentConditionDisplay = new Display("CurrentConditionDisplay");
            Console.WriteLine("--------CurrentConditionDisplay Join-----------");
            currentConditionDisplay.Subscriber(weatherDataProvider);
            weatherData.SetMessureMents(28, 66, 45.3f);
            weatherDataProvider.SendWeatherData(weatherData);
            Console.WriteLine();

            Display forecastDisplay = new Display("ForecastDisplay");
            Console.WriteLine("--------ForecastDisplay Join-----------");
            forecastDisplay.Subscriber(weatherDataProvider);
            weatherData.SetMessureMents(20, 46, 78.3f);
            weatherDataProvider.SendWeatherData(weatherData);
            Console.WriteLine();

            Console.WriteLine("--------CurrentConditionDisplay Dispose-----------");
            currentConditionDisplay.Unsubscriber();

            //数据更新
            weatherData.SetMessureMents(23, 44, 34.5f);
            weatherDataProvider.SendWeatherData(weatherData);
            Console.WriteLine("Over!!!!!");

            Console.ReadLine();

            
        }
    }
}
