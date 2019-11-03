using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObserverMode.Service;

namespace ObserverMode.ServiceImpl
{
    /// <summary>
    /// 具体观察者：天气预报布告板
    /// </summary>
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("ForecastDisplay: 显示天气预报");
            Console.WriteLine("Today weatherdata is : Temperature: " + temperature + "°C");
            Console.WriteLine("Humidity: " + humidity + "%");
            Console.WriteLine("Pressure: " + pressure);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
    }
}
