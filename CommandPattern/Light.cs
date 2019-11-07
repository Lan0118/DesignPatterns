using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 电灯对象
    /// </summary>
    public  class Light
    {
        private string name = "Light";
        public Light()
        {
            Console.WriteLine("This is " + name + '\n');
        }

        public void on()
        {
            Console.WriteLine("Light is on\n");
        }

        public void off()
        {
            Console.WriteLine("Light is off\n");
        }

    }
}
