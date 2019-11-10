using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class NoQuarteState : State
    {
        GumballMachine gumballMachine;

        public NoQuarteState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("��Ͷ��Ӳ��");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("����û��Ͷ��Ŷ");
        }

        public void insertQuarter()
        {
            Console.WriteLine("��Ͷ��25�֣���ȴ��ǹ�����Ŷ��");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void refill()
        {
           
        }

        public void turnCrank()
        {
            Console.WriteLine("����Ͷ��");
        }

        public string toString()
        {
            return "�ȴ�Ͷ�ҡ���";
        }
    }
}
