using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    /// <summary>
    /// 绿头鸭
    /// 鸭子的具体对象
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
