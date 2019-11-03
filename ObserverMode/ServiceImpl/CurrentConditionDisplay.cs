using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObserverMode.Service;

namespace ObserverMode.ServiceImpl
{
    /// <summary>
    /// 具体观察者：显示当前weather观测值
    /// </summary>
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("CurrentConditionDisplay: 实时天气信息布告板");
            Console.WriteLine("Current Conditions: " + temperature + "°C and " + humidity + "% humidity");
        }


        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
