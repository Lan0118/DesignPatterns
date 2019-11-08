using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class TheaterLights
    {
        string description;
        public TheaterLights(string description)
        {
            this.description = description;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void dim(int level)
        {
            Console.WriteLine(description + " dimming to " + level + "%");
        }

        public string getDescription()
        {
            return description;
        }
    }
}
