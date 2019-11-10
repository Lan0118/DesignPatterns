using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class HasQuarteState : State
    {
        Random randomWinner = new Random();
        GumballMachineNew gumballMachineNew;

        public HasQuarteState(GumballMachineNew gumballMachineNew)
        {
            this.gumballMachineNew = gumballMachineNew;
        }

        public void dispense()
        {
            Console.WriteLine("没有可以掉落的糖果");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("退回硬币");
            gumballMachineNew.setState(gumballMachineNew.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("请不要多次投币");
        }

        public void refill()
        {
           
        }

        public void turnCrank()
        {
            Console.WriteLine("转动中。。。");
            int winner = randomWinner.Next(10);
            if((winner == 0) && (gumballMachineNew.getCount() > 1))
            {
                gumballMachineNew.setState(gumballMachineNew.getWinnerState());
            }
            else
            {
                gumballMachineNew.setState(gumballMachineNew.getSoldState());
            }
        }

        public string toString()
        {
            return "等待曲柄转动";
        }
    }
}
