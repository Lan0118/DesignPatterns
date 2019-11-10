using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class HasQuarteState : State
    {
        Random randomWinner = new Random();
        GumballMachine gumballMachine;

        public HasQuarteState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("没有可以掉落的糖果");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("退回硬币");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
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
            if((winner == 0) && (gumballMachine.getCount() > 1))
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldState());
            }
        }

        public string toString()
        {
            return "等待曲柄转动";
        }
    }
}
