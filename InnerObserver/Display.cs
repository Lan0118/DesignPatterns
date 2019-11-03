using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerObserver
{
    class Display : IObserver<WeatherData>
    {
        private IDisposable unsubscriber;
        private string displayName;

        public Display(string name)
        {
            this.displayName = name;
        }

        public virtual void Subscriber(IObservable<WeatherData> provider)
        {
            if(provider != null)
            {
                unsubscriber = provider.Subscribe(this);
            }
        }

        public virtual void Unsubscriber()
        {
            unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{displayName}天气数据发送完毕");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{displayName}返回数据时,发生错误");
        }

        public void OnNext(WeatherData value)
        {
            Console.WriteLine($"{displayName}实时天气信息: temperature: {value.Temperature}°C,humidity: {value.Humidity},pressure: {value.Pressure}");
        }
    }
}
