using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void report()
        {
            Console.WriteLine("糖果机： " + machine.getLocation());
            Console.WriteLine("糖果数量： " + machine.getCount() + "颗");
            Console.WriteLine("糖果机目前状态：" + machine.getState());
        }
    }
}
