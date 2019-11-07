using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2
{

    /// <summary>
    /// 具体命令：开灯
    /// 实现命令接口
    /// </summary>
    public class LightOffCommand : Command
    {
        //传入电灯对象
        Light light;

        //使用电灯对象作为命令接收者
        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        //调用接收者对象的命令
        public void execute()
        {
            light.off();
        }
    }
}
