using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SoldOutState : State
    {
        private GumballMachineNew gumballMachineNew;

        public SoldOutState(GumballMachineNew gumballMachineNew)
        {
            this.gumballMachineNew = gumballMachineNew;
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
            gumballMachineNew.setState(gumballMachineNew.getNoQuarterState());
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
