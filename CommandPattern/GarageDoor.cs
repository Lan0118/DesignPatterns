using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 车库门对象
    /// </summary>
    public class GarageDoor
    {
        private string name = "Garage Door";
        public GarageDoor()
        {
            Console.WriteLine("This is Garage Door \n");
        }

        public void up()
        {
            Console.WriteLine(name + "Up\n");
        }

        public void down()
        {
            Console.WriteLine(name + "Down\n");
        }

        public void lightOn()
        {
            Console.WriteLine(name + "lightOn\n");
        }

        public void lightOff()
        {
            Console.WriteLine(name + "lightOff\n");
        }
    }
}
