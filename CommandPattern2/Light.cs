using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{
    /// <summary>
    /// 电灯对象
    /// </summary>
    public  class Light
    {
        private string name;
        public Light(string  name)
        {
            this.name = name;
        }

        public void on()
        {
            Console.WriteLine(name + " is on\n");
        }

        public void off()
        {
            Console.WriteLine(name + " is off\n");
        }

    }
}
