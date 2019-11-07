using System;

namespace CommandPattern
{
    /// <summary>
    ///命令模式
    ///遥控器--单个按钮
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //实例化遥控器对象
            SimpleRemoteControl remote = new SimpleRemoteControl();
            //实例化电灯对象
            Light light = new Light();
            //实例化开灯命令
            LightOnCommand lightOn = new LightOnCommand(light);

            //把开灯命令传给调用者
            remote.setCommand(lightOn);
            //触发调用命令
            remote.buttonWasPressed();

            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageDoorCommand = new GarageDoorOpenCommand(garageDoor);
            remote.setCommand(garageDoorCommand);
            remote.buttonWasPressed();

            Console.ReadKey();
        }
    }
}
