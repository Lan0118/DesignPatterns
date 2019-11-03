using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using ObserverMode.Service;


namespace ObserverMode.ServiceImpl
{
    /// <summary>
    /// 具体主题：天气信息
    /// </summary>
    class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }


        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObserver()
        {
            for(int i = 0; i<observers.Count; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.update(temperature, humidity, pressure);
            }

        }

        //设置天气信息
        public void setMeasurementsChanged(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        //更新订阅的观察者
        public void measurementsChanged()
        {
            notifyObserver();
        }
    }
}
