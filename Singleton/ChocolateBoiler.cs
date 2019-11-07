using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 单例模式-巧克力工厂
    ///创建唯一的锅炉对象，并提供全局访问点，懒加载。
    ///多线程安全
    /// </summary>
    class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler uniqueInstance;
        private static readonly object obj = new object();

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
            Console.WriteLine("初始化: empty=" + empty + ". boiled="+ boiled);
        }

        public static  ChocolateBoiler getInstance()
        {
           
            if (uniqueInstance == null)
            {
                lock (obj)
                {
                    {
                        uniqueInstance = new ChocolateBoiler();
                    }
                }
            }                               
            return uniqueInstance;                     
        }
    }
}
