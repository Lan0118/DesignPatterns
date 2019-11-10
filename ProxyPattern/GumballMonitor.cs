using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void report()
        {
            Console.WriteLine("�ǹ����� " + machine.getLocation());
            Console.WriteLine("�ǹ������� " + machine.getCount() + "��");
            Console.WriteLine("�ǹ���Ŀǰ״̬��" + machine.getState());
        }
    }
}
