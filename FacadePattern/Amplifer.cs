using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// À©ÒôÆ÷
    /// </summary>
    public class Amplifer
    {
        string description;
        Tuner tuner;
        CDPlayer cd;
        DVDPlayer dvd;

        public Amplifer(string description)
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

        public void setStereoSound()
        {
            Console.WriteLine(description + " stereo mode on");
        }

        public void setSurroundSound()
        {
            Console.WriteLine(description + " surround sound on (5 speakers, 1 subwoofer)");
        }

        public void setVolume(int level)
        {
            Console.WriteLine(description + " setting volume to " + level);
        }

        public void setTuner(Tuner tuner)
        {
            this.tuner = tuner;
            Console.WriteLine(description + " setting tuner to " + dvd);
        }

        public void setDVD( DVDPlayer dvd)
        {
            this.dvd = dvd;
            Console.WriteLine(description + " settting DVD player to " + dvd);
        }

        public void setCD(CDPlayer cd)
        {
            this.cd = cd;
            Console.WriteLine(description + " setting CD player to " + this.cd);
        }

        public string getDescription()
        {
            return description;
        }

    }
}
