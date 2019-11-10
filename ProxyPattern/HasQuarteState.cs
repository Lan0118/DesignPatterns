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
            Console.WriteLine("û�п��Ե�����ǹ�");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("�˻�Ӳ��");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("�벻Ҫ���Ͷ��");
        }

        public void refill()
        {
           
        }

        public void turnCrank()
        {
            Console.WriteLine("ת���С�����");
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
            return "�ȴ�����ת��";
        }
    }
}
