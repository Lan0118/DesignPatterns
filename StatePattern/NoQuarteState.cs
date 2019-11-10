using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoQuarteState : State
    {
        GumballMachineNew gumballMachine;

        public NoQuarteState(GumballMachineNew gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("请投入硬币");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("您还没有投币哦");
        }

        public void insertQuarter()
        {
            Console.WriteLine("您投入25分，请等待糖果掉落哦！");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void refill()
        {
           
        }

        public void turnCrank()
        {
            Console.WriteLine("请先投币");
        }

        public string toString()
        {
            return "等待投币。。";
        }
    }
}
