using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{
    public class StereoOnWithCDCommand: Command
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }
}
