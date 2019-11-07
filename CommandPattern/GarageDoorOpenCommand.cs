using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.up();
        }
    }
}
