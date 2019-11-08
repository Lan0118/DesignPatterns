using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class DVDPlayer
    {
        string description;
        Amplifer amplifer;
        int currentTrack;
        string movie;

        public DVDPlayer(string description, Amplifer amp)
        {
            this.description = description;
            this.amplifer = amp;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void eject()
        {
            movie = null;
            Console.WriteLine(description + " eject");
        }

        public void pause()
        {
            Console.WriteLine(description + " pause");
        }

        public void play(string movie)
        {
            this.movie = movie;
            currentTrack = 0;
            Console.WriteLine(description + " playing " + movie);
        }

        public void play(int track)
        {
            if(movie == null)
            {
                Console.WriteLine(description + " can't play track " + track + "no dvd inserted");
            }
            else
            {
                this.currentTrack = track;
                Console.WriteLine(description + " playing track" + currentTrack + " of " + movie);
            }           
            
        }

        public void stop()
        {
            currentTrack = 0;
            Console.WriteLine(description + " stopped " + movie);
        }

        public void setSurroundAuto()
        {
            currentTrack = 1;
            Console.WriteLine(description + " set surround audio");
        }

        public void setTwoChannelAudio()
        {
            Console.WriteLine(description + " set two channel audio");
        }

        public string getDescription()
        {
            return description;
        }
    }
}
