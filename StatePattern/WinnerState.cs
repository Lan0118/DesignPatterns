using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class WinnerState : State
    {
        GumballMachineNew gumballMachine;
        public WinnerState(GumballMachineNew gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void dispense()
        {
            gumballMachine.releaseBall();
            if(gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
            else
            {
                gumballMachine.releaseBall();
                Console.WriteLine("恭喜你成为幸运顾客，可以额外获得一次糖果哦");
                if(gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Console.WriteLine("哦呦，糖果售完了。。");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("请稍等，我们已经在为您提供糖果");
        }

        public void insertQuarter()
        {
            Console.WriteLine("请稍等，我们已经在为您提供糖果");
        }

        public void refill()
        {
           
        }

        public void turnCrank()
        {
            Console.WriteLine("再次转动无效，购买一次只能得到一次糖果");
        }

        public string toString()
        {
            return "恭喜成为幸运顾客！";
        }
    }
}
