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
                Console.WriteLine("ŷ���ǹ�������...");
                gumballManchine.setState(gumballManchine.getSoldOutState());  
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("��ǸŶ�����Ѿ�ת�������ˣ��޷��˱��ˡ�");
        }

        public void insertQuarter()
        {
            Console.WriteLine("�����ĵȴ����ǹ�����������������");
        }

        public void refill()
        {
            
        }

        public void turnCrank()
        {
            Console.WriteLine("ת�����Ҳ���ܻ�ȡ����ǹ�Ŷ��");
        }

        public string toString()
        {
            return "�����ǹ�";
        }
    }
}
