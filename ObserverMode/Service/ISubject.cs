
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode.Service
{
    /// <summary>
    /// 主题接口
    /// </summary>
    interface ISubject
    {
        //观察者注册
        void registerObserver(IObserver o);
        //移除观察者
        void removeObserver(IObserver o);
        //通知观察者
        void notifyObserver();

    }
}
