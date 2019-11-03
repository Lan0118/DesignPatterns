using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ObserverMode.Service;

namespace ObserverMode.ServiceImpl
{
    
    /// <summary>
    /// 具体观察者：气象数据统计展示布告板
    /// </summary>
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private ISubject weatherData;

        public void display()
        {
            Console.WriteLine("StatisticsDisplay: 气象统计布告板");
            Console.WriteLine("AVG/MIN/MAX: " + temperature);
        }

        //接收来自主题类的所有更新信息
        public void update(float temp, float humidity, float pressure)
        {
            //获取自己需要的信息
            this.temperature = temp;
            display();
        }
    }
}
