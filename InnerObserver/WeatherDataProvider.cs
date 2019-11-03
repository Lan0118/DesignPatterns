using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerObserver
{
    class WeatherDataProvider :IObservable<WeatherData>
    {
        //�۲����б�
        private List<IObserver<WeatherData>> observers;
        public WeatherDataProvider()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        //�����ٵ��ڲ��࣬�̳�IDisposable�ӿ�
        //�۲���ע��ʱ���ɵĶ���ע��ʱ������Dispose(),�ͷ���Դ
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

        //֪ͨ�۲��߽�����֪ͨ
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            //���ؿ����ٵ��ڲ��࣬�Թ۲�����Դ���й���
            return new UnSubscriber(observers, observer);
        }

        //֪ͨ���й۲��߸�������
        public void SendWeatherData(Nullable<WeatherData> weatherData)
        {
            foreach(var observer in observers)
            {
                //֪ͨ�۲��ߣ��ṩ��������ɻ������͵�֪ͨ
                observer.OnCompleted();
                //��۲����ṩ�µ�����
                observer.OnNext(weatherData.Value);
            }
        }
    }
}
