using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{
    /// <summary>
    /// 音响对象
    /// </summary>
    public class Stereo
    {
        private string name;
        public Stereo(string name)
        {
            this.name = name;
        }

        public void on()
        {
            Console.WriteLine(name + " on\n");
        }

        public void off()
        {
            Console.WriteLine(name + " off\n");
        }

        public void setCD()
        {
            Console.WriteLine(name + ": putting in CD...\n");
        }

        public void setDVD()
        {
            Console.WriteLine(name + ": putting in DVD...\n");
        }

        public void setRadio()
        {
            Console.WriteLine(name + ": turning on radio...\n");
        }

        public void setVolume(int volume)
        {
            Console.WriteLine(name + ": setting volume "+ volume +"\n");
        }

    }
}
