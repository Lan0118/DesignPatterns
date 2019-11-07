using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{
    /// <summary>
    /// 车库门对象
    /// </summary>
    public class GarageDoor
    {
        private string name;
        public GarageDoor(string name)
        {
            this.name = name;            
        }

        public void up()
        {
            Console.WriteLine(name + " Up\n");
        }

        public void down()
        {
            Console.WriteLine(name + " Down\n");
        }

        public void lightOn()
        {
            Console.WriteLine(name + " light On\n");
        }

        public void lightOff()
        {
            Console.WriteLine(name + " light Off\n");
        }
    }
}
