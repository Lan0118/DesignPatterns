using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class SoldOutState : State
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("糖果已经售完啦。。。");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("您还未投入硬币");
        }

        public void insertQuarter()
        {
            Console.WriteLine("无法投币，糖果已经售完啦。。。");
        }

        public void refill()
        {
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("转动成功，但糖果已经售完啦。。。");
        }

        public string toString()
        {
            return "sold out";
        }
    }
}
