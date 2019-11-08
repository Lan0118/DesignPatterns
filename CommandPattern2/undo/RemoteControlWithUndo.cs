using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2.undo
{
    public class RemoteControlWithUndo
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControlWithUndo()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];
            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            //记录执行的命令
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasOushed()
        {
            undoCommand.undo();
        }

        public string toString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n----------Remote Control With Undo-----------------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[slot  " + i + "]" + onCommands[i] +
                    "     " + offCommands[i] + '\n');
            }
            stringBuilder.Append("[undo]   " + undoCommand + '\n');
            return stringBuilder.ToString();
        }
        


    }
}
