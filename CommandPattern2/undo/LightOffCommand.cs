﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2.undo
{
    class LightOffCommand : Command
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }

        public void undo()
        {
            light.on();
        }
    }
}
