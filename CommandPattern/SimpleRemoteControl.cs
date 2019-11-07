using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 遥控器类
    /// 包含一个按钮和对应的插槽
    /// </summary>
    public class SimpleRemoteControl
    {
        //插槽，拥有一个命令
        public Command slot;

        public SimpleRemoteControl()
        {
            Console.WriteLine("This is a simple remote controller.\n");
        }


        //设置插槽控制的命令
        public void setCommand(Command command)
        {
            this.slot = command;
        }

        //按钮触发，调用命令
        public void buttonWasPressed()
        {
            Console.WriteLine("Button was pressed");
            slot.execute();
        }

    }
}
