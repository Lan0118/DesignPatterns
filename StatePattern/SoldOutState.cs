using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SoldOutState : State
    {
        private GumballMachineNew gumballMachineNew;

        public SoldOutState(GumballMachineNew gumballMachineNew)
        {
            this.gumballMachineNew = gumballMachineNew;
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
            gumballMachineNew.setState(gumballMachineNew.getNoQuarterState());
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
