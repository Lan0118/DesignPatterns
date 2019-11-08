using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 家庭影院
    /// </summary>
    class HomeTheaterFacade
    {
        Amplifer amp;
        Tuner tuner;
        DVDPlayer dvDplayer;
        CDPlayer cDPlayer;
        Projector projector;
        TheaterLights theaterLights;
        Screen screen;
        PopcornPopper popcornPopper;

        public HomeTheaterFacade(Amplifer amp,
            Tuner tuner, DVDPlayer dvdPlayer,CDPlayer cDPlayer,Projector projector,Screen screen, TheaterLights theaterLights,PopcornPopper popcornPopper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvDplayer = dvdPlayer;
            this.cDPlayer = cDPlayer;
            this.projector = projector;
            this.theaterLights = theaterLights;
            this.screen = screen;
            this.popcornPopper = popcornPopper;
        }

        public void watchMovie(string movie)
        {
            Console.WriteLine("\n----------Get Ready----------");
            popcornPopper.on();
            popcornPopper.pop();
            theaterLights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setDVD(dvDplayer);
            amp.setSurroundSound();
            amp.setVolume(5);
            dvDplayer.on();
            dvDplayer.play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("\n-------------Shutting movie theater down----------------");
            popcornPopper.off();
            theaterLights.on();
            screen.up();
            projector.off();
            amp.off();
            dvDplayer.stop();
            dvDplayer.eject();
            dvDplayer.off();
        }
    }
}
