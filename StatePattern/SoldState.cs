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
                Console.WriteLine("ŷ���ǹ�������...");
                gumballManchineNew.setState(gumballManchineNew.getSoldOutState());  
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
