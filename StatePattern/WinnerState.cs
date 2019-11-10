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
                Console.WriteLine("��ϲ���Ϊ���˹˿ͣ����Զ�����һ���ǹ�Ŷ");
                if(gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Ŷ�ϣ��ǹ������ˡ���");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("���Եȣ������Ѿ���Ϊ���ṩ�ǹ�");
        }

        public void insertQuarter()
        {
            Console.WriteLine("���Եȣ������Ѿ���Ϊ���ṩ�ǹ�");
        }

        public void refill()
        {
           
        }

        public void turnCrank()
        {
            Console.WriteLine("�ٴ�ת����Ч������һ��ֻ�ܵõ�һ���ǹ�");
        }

        public string toString()
        {
            return "��ϲ��Ϊ���˹˿ͣ�";
        }
    }
}
