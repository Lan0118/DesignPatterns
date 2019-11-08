using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{
    class GarageDoorCloseCommand: Command
    {
        GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.lightOff();
            garageDoor.down();
        }

    }
}
