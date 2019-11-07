using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{
    /// <summary>
    /// 遥控器对象
    /// </summary>
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;

        public RemoteControl()
        {
            //遥控器上有7个开按钮，7个关按钮
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for(int i=0; i<7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        /// <summary>
        /// 设置命令
        /// </summary>
        /// <param name="slot">插槽位置</param>
        /// <param name="onCommand">开的命令</param>
        /// <param name="offCommand">关的命令</param>
        public void setCommand(int slot,Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        /// <summary>
        /// 开按钮按下时调用对应位置的命令
        /// </summary>
        /// <param name="slot"></param>
        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
        }

        /// <summary>
        /// 关按钮按下时调用对应位置的命令
        /// </summary>
        /// <param name="slot"></param>
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
        }

        /// <summary>
        /// 打印每个插槽对应的命令
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n----------Remote Control-----------------\n");
            for(int i=0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[slot" + i + "]" + onCommands[i] +
                    "   " + offCommands[i] + '\n');
            }
            return stringBuilder.ToString();

        }
    }
}
