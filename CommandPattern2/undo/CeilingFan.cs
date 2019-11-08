using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2.undo
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        string location;
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void high()
        {
            speed = HIGH;
            Console.WriteLine(location + " ceiling fan is on high");
        }

        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine(location + " ceiling fan is on medium");
        }

        public void low()
        {
            speed = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void off()
        {
            speed = OFF;
            Console.WriteLine(location + " ceiling fan is on off");
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
