using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerObserver
{
    class WeatherDataProvider :IObservable<WeatherData>
    {
        //观察者列表
        private List<IObserver<WeatherData>> observers;
        public WeatherDataProvider()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        //可销毁的内部类，继承IDisposable接口
        //观察者注册时生成的对象，注销时，调用Dispose(),释放资源
        private class UnSubscriber : IDisposable
        {
            private List<IObserver<WeatherData>> _observers;
            private IObserver<WeatherData> _observer;

            public UnSubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if(_observer != null && _observers.Contains(_observer)){  
                    _observers.Remove(_observer);
                }
            }

        }

        //通知观察者将接收通知
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            //返回可销毁的内部类，对观察者资源进行管理
            return new UnSubscriber(observers, observer);
        }

        //通知所有观察者更新数据
        public void SendWeatherData(Nullable<WeatherData> weatherData)
        {
            foreach(var observer in observers)
            {
                //通知观察者，提供程序已完成基于推送的通知
                observer.OnCompleted();
                //向观察者提供新的数据
                observer.OnNext(weatherData.Value);
            }
        }
    }
}
