using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode.Service
{
    /// <summary>
    /// 观察者
    /// </summary>
    interface IObserver
    {
        //更新来自Subject的信息
        void update(float temp, float humidity, float pressure);
    }
}
