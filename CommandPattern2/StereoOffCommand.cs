using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{
    class StereoOffCommand: Command
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }
    }
}
