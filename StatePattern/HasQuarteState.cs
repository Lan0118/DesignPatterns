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
            Console.WriteLine("û�п��Ե�����ǹ�");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("�˻�Ӳ��");
            gumballMachineNew.setState(gumballMachineNew.getNoQuarterState());
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
            return "�ȴ�����ת��";
        }
    }
}
