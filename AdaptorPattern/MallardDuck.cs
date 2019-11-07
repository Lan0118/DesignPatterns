using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    /// <summary>
    /// ��ͷѼ
    /// Ѽ�ӵľ������
    /// </summary>
    class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("Flying...");
        }

        public void quack()
        {
            Console.WriteLine("Quacking...");
        }
    }
}
