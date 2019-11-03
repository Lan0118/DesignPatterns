using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerObserver
{
    /// <summary>
    /// 天气实体类
    /// 主题传递给观察者的数据
    /// </summary>
    public struct WeatherData
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public float Temperature { get { return temperature; } }
        public float Humidity { get { return humidity; } }
        public float Pressure { get { return pressure; } }

       

        public void SetMessureMents(float temperature,float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

       
    }
}
