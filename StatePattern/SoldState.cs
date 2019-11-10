using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SoldState : State
    {
        GumballMachineNew gumballManchineNew;

        public SoldState(GumballMachineNew gumballManchineNew)
        {
            this.gumballManchineNew = gumballManchineNew;
        }
        public void dispense()
        {
            gumballManchineNew.releaseBall();
            if(gumballManchineNew.getCount() > 0)
            {
                gumballManchineNew.setState(gumballManchineNew.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("欧，糖果售完了...");
                gumballManchineNew.setState(gumballManchineNew.getSoldOutState());  
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
