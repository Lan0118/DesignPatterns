using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class SoldOutState : State
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("�ǹ��Ѿ�������������");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("����δͶ��Ӳ��");
        }

        public void insertQuarter()
        {
            Console.WriteLine("�޷�Ͷ�ң��ǹ��Ѿ�������������");
        }

        public void refill()
        {
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("ת���ɹ������ǹ��Ѿ�������������");
        }

        public string toString()
        {
            return "sold out";
        }
    }
}
