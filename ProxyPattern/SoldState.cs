using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class SoldState : State
    {
        GumballMachine gumballManchine;

        public SoldState(GumballMachine gumballManchine)
        {
            this.gumballManchine = gumballManchine;
        }
        public void dispense()
        {
            gumballManchine.releaseBall();
            if(gumballManchine.getCount() > 0)
            {
                gumballManchine.setState(gumballManchine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("欧，糖果售完了...");
                gumballManchine.setState(gumballManchine.getSoldOutState());  
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("抱歉哦，你已经转动曲柄了，无法退币了。");
        }

        public void insertQuarter()
        {
            Console.WriteLine("请耐心等待，糖果正在向您奔来！！");
        }

        public void refill()
        {
            
        }

        public void turnCrank()
        {
            Console.WriteLine("转动多次也不能获取多次糖果哦！");
        }

        public string toString()
        {
            return "发放糖果";
        }
    }
}
