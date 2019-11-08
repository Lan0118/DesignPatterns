using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2.undo
{
    public class CeilingFanMediumCommand : Command
    {
        CeilingFan fan;
        int prevSpeed;

        public CeilingFanMediumCommand(CeilingFan fan)
        {
            this.fan = fan;
        }

        public void execute()
        {
            prevSpeed = fan.getSpeed();
            fan.medium();
        }

        public void undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                fan.high();
            }
            else if (prevSpeed == CeilingFan.MEDIUM)
            {
                fan.medium();
            }
            else if (prevSpeed == CeilingFan.LOW)
            {
                fan.low();
            }
            else if (prevSpeed == CeilingFan.OFF)
            {
                fan.off();
            }
        }
    }
}
